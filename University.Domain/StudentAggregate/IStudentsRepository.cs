using System.Collections.Generic;

namespace UniversityManagementUseRepositoryUnitOfWork.Domain.StudentsAggregate
{
    public interface IStudentsRepository :IGenericRepository<Student>
    {
        IEnumerable<Student> GetStudentsByName(string Name);
    }
}
