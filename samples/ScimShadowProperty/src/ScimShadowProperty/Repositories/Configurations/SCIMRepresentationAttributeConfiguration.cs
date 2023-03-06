﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleIdServer.Scim.Domains;

namespace ScimShadowProperty.Repositories.Configurations
{
    public class SCIMRepresentationAttributeConfiguration : IEntityTypeConfiguration<SCIMRepresentationAttribute>
    {
        public void Configure(EntityTypeBuilder<SCIMRepresentationAttribute> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasOne(a => a.SchemaAttribute).WithMany().HasForeignKey(a => a.SchemaAttributeId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(a => a.Children).WithOne().HasForeignKey("ParentAttributeId");
            builder.Ignore(a => a.CachedChildren);
            builder.Property(a => a.ValueString).HasMaxLength(255);
            builder.Property<string>("Tenant");
        }
    }
}
