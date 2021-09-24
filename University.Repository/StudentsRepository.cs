using System.Collections.Generic;
using System.Linq;
using UniversityManagementUseRepositoryUnitOfWork.Domain.StudentsAggregate;

namespace UniversityManagementUseRepositoryUnitOfWork.Repository
{
    public class StudentsRepository:GenericRepository<Student>, IStudentsRepository
    {
        public StudentsRepository(UniversityDbContext context) : base(context)
        {
            
        }

        public IEnumerable<Student> GetBooksByName(string Name)
        {
            return _context.Students.Where(x => x.Name == Name);
        }

    }
}
