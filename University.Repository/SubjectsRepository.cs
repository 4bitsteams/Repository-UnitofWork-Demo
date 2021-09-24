using UniversityManagementUseRepositoryUnitOfWork.Domain.SubjectAggregate;
using UniversityManagementUseRepositoryUnitOfWork.Entity;

namespace UniversityManagementUseRepositoryUnitOfWork.Repository
{
    class SubjectsRepository :GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectsRepository(UniversityDbContext context):base(context)
        {
            
        }
    }
}
