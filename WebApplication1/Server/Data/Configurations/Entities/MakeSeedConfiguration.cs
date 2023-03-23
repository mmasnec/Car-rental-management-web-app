﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Shared.Domain;

namespace WebApplication1.Server.Data.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
               new Make
               {
                   Id = 1,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   Name = "Toyota",
                   UpdatedBy = "System"
               },
               new Make
               {
                   Id = 2,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   Name = "Mazda",
                   UpdatedBy = "System"
               }
               );
        }
    }
}