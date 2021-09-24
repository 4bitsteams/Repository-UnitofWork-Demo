using UniversityManagementUseRepositoryUnitOfWork.Domain.SubjectAggregate;
using UniversityManagementUseRepositoryUnitOfWork.Entity;

namespace UniversityManagementUseRepositoryUnitOfWork.Repository
{
    public  class SubjectsRepository :GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectsRepository(UniversityDbContext context):base(context)
        {
            
        }
    }
}
