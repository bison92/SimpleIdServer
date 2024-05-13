﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using Microsoft.EntityFrameworkCore;
using SimpleIdServer.IdServer.Domains;
using SimpleIdServer.IdServer.Stores;
using System.Linq.Dynamic.Core;

namespace SimpleIdServer.IdServer.Store.EF;

public class ApiResourceRepository : IApiResourceRepository
{
    private readonly StoreDbContext _dbContext;

    public ApiResourceRepository(StoreDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<ApiResource> Get(string realm, string id, CancellationToken cancellationToken)
    {
        var result = _dbContext.ApiResources
                .Include(p => p.Realms)
                .Include(p => p.Scopes)
                .SingleOrDefaultAsync(p => p.Realms.Any(r => r.Name == realm) && p.Id == id, cancellationToken);
        return result;
    }

    public Task<ApiResource> GetByName(string realm, string name, CancellationToken cancellationToken)
    {
        var result = _dbContext.ApiResources
                .Include(p => p.Realms)
                .Include(p => p.Scopes)
                .SingleOrDefaultAsync(p => p.Realms.Any(r => r.Name == realm) && p.Name == name, cancellationToken);
        return result;
    }

    public async Task<SearchResult<ApiResource>> Search(string realm, SearchRequest request, CancellationToken cancellationToken)
    {
        var query  = _dbContext.ApiResources
                .Include(p => p.Realms)
                .Include(p => p.Scopes)
                .Where(p => p.Realms.Any(r => r.Name == realm))
                .AsNoTracking();
        if (!string.IsNullOrWhiteSpace(request.Filter))
            query = query.Where(request.Filter);

        if (!string.IsNullOrWhiteSpace(request.OrderBy))
            query = query.OrderBy(request.OrderBy);
        else
            query = query.OrderBy(r => r.Name);
        var nb = query.Count();
        var apiResources = await query.Skip(request.Skip.Value).Take(request.Take.Value).ToListAsync(cancellationToken);
        return new SearchResult<ApiResource>
        {
            Count = nb,
            Content = apiResources
        };
    }

    public void Add(ApiResource apiResource)
        => _dbContext.ApiResources.Add(apiResource);

    public void Delete(ApiResource apiResource)
        => _dbContext.ApiResources.Remove(apiResource);

    public IQueryable<ApiResource> Query()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChanges(CancellationToken cancellationToken)
        => _dbContext.SaveChangesAsync(cancellationToken);
}