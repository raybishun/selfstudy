﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Models;

namespace SparkAuto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<ServiceType> ServiceType { get; set; }
        // In the PM Console, don't forget to run:
        //  1/2: Add-Migration AddServiceTypeToTheDB
        //  2/2: Update-Database
    }
}
