
using Microsoft.Extensions.DependencyInjection;
using UniversityManagementUseRepositoryUnitOfWork.Domain;
using UniversityManagementUseRepositoryUnitOfWork.Domain.StudentsAggregate;
using UniversityManagementUseRepositoryUnitOfWork.Domain.SubjectAggregate;

namespace UniversityManagementUseRepositoryUnitOfWork.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IStudentsRepository, StudentsRepository>();
            services.AddTransient<ISubjectRepository, SubjectsRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            
            //services.AddDbContext<UniversityDbContext>(opt => opt
            //    .UseSqlServer("Server=localhost,1433; Database=BooksDB;User Id=sa; Password=password_01;"));
            return services;
        }
    }
}
