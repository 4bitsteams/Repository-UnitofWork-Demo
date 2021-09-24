using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UniversityManagementUseRepositoryUnitOfWork.Entity;

namespace UniversityManagementUseRepositoryUnitOfWork.Repository
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}
