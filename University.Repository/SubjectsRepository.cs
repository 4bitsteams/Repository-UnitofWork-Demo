using UniversityManagementUseRepositoryUnitOfWork.Domain.StudentAggregate;
using UniversityManagementUseRepositoryUnitOfWork.Domain.SubjectAggregate;

namespace UniversityManagementUseRepositoryUnitOfWork.Repository
{
    class SubjectsRepository :GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectsRepository(UniversityDbContext context):base(context)
        {
            
        }
    }
}
