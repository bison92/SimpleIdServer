﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Scim.Domain;
using SimpleIdServer.Scim.Domains;
using SimpleIdServer.Scim.Parser.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.Scim.Persistence.InMemory
{
    public class DefaultSCIMRepresentationQueryRepository : ISCIMRepresentationQueryRepository
    {
        private readonly List<SCIMRepresentation> _representations;
        private readonly List<SCIMRepresentationAttribute> _attributes;

        public DefaultSCIMRepresentationQueryRepository(List<SCIMRepresentation> representations, List<SCIMRepresentationAttribute> attributes)
        {
            _representations = representations;
            _attributes = attributes;
        }

        public Task<SearchSCIMRepresentationsResponse> FindSCIMRepresentations(SearchSCIMRepresentationsParameter parameter, CancellationToken cancellationToken)
        {
            var queryableRepresentations = _representations.Select(r => Enrich(r)).AsQueryable().Where(r => r.ResourceType == parameter.ResourceType);
            if(!string.IsNullOrWhiteSpace(parameter.Realm))
            {
                queryableRepresentations = queryableRepresentations.Where(r => r.RealmName == parameter.Realm);
            }

            if (parameter.Filter != null)
            {
                var evaluatedExpression = parameter.Filter.Evaluate(queryableRepresentations);
                queryableRepresentations = (IQueryable<SCIMRepresentation>)evaluatedExpression.Compile().DynamicInvoke(queryableRepresentations);
            }

            if (parameter.SortBy != null)
            {
                var evaluatedExpression = parameter.SortBy.Evaluate(queryableRepresentations);
                var ordered = (IEnumerable<SCIMRepresentation>)evaluatedExpression.Compile().DynamicInvoke(queryableRepresentations);
                queryableRepresentations = ordered.ToList().AsQueryable();
            }

            int totalResults = queryableRepresentations.Count();
            if (parameter.Count == 0)
                return Task.FromResult(new SearchSCIMRepresentationsResponse(totalResults, new List<SCIMRepresentation>()));
            IEnumerable<SCIMRepresentation> result = new List<SCIMRepresentation>();
            result = queryableRepresentations.Skip(parameter.StartIndex <= 1 ? 0 : parameter.StartIndex - 1).Take(parameter.Count).Select(r => (SCIMRepresentation)r.Clone()).ToList();
            result.FilterAttributes(parameter.IncludedAttributes, parameter.ExcludedAttributes);
            return Task.FromResult(new SearchSCIMRepresentationsResponse(totalResults, result));
        }

        public Task<SCIMRepresentation> FindSCIMRepresentationById(string realm, string representationId, string resourceType, GetSCIMResourceParameter parameter, CancellationToken cancellationToken)
        {
            SCIMRepresentation result;
            if(!string.IsNullOrWhiteSpace(realm))
                result = _representations.FirstOrDefault(r => r.Id == representationId && r.ResourceType == resourceType && r.RealmName == realm);
            else
                result = _representations.FirstOrDefault(r => r.Id == representationId && r.ResourceType == resourceType);
            if (result == null)
            {
                return Task.FromResult((SCIMRepresentation)null);
            }

            var clone = Enrich(result);
            clone.FilterAttributes(parameter.IncludedAttributes, parameter.ExcludedAttributes);
            return Task.FromResult(clone);
        }

        private SCIMRepresentation Enrich(SCIMRepresentation representation)
        {
            var clone = (SCIMRepresentation)representation.Clone();
            clone.FlatAttributes = _attributes.Where(a => a.RepresentationId == representation.Id).ToList();
            return clone;
        }
    }
}
