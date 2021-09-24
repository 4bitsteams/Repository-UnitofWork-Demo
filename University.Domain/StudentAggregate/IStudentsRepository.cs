using System.Collections.Generic;
using UniversityManagementUseRepositoryUnitOfWork.Entity;

namespace UniversityManagementUseRepositoryUnitOfWork.Domain.StudentsAggregate
{
    public interface IStudentsRepository :IGenericRepository<Student>
    {
        IEnumerable<Student> GetStudentsByName(string Name);
    }
}
