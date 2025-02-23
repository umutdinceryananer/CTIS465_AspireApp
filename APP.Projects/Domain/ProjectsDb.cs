﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Collections.Generic;

namespace APP.Projects.Domain
{
    public class ProjectsDb : DbContext
    {
        public DbSet<Tag> Tags { get; set; }

        public ProjectsDb(DbContextOptions options) : base(options)
        {
        }
    }

    public class ProjectsDbFactory : IDesignTimeDbContextFactory<ProjectsDb>
    {
        public ProjectsDb CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProjectsDb>();
            //optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=PMSProjectsDB;trusted_connection=true;");
            optionsBuilder.UseSqlServer("server=127.0.0.1,1433;database=PMSProjectsDB;user id=sa;password=Cagil123!;trustservercertificate=true;");
            return new ProjectsDb(optionsBuilder.Options);
        }
    }
}