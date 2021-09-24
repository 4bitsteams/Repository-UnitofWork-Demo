using System.Collections.Generic;
using UniversityManagementUseRepositoryUnitOfWork.Entity;

namespace UniversityManagementUseRepositoryUnitOfWork.Domain
{
    public interface IStudentsRepository :IGenericRepository<Student>
    {
        IEnumerable<Student> GetStudentsByName(string Name);
    }
}
