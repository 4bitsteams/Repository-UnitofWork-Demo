using System;
using UniversityManagementUseRepositoryUnitOfWork.Domain;
using UniversityManagementUseRepositoryUnitOfWork.Domain.StudentsAggregate;
using UniversityManagementUseRepositoryUnitOfWork.Domain.SubjectAggregate;

namespace UniversityManagementUseRepositoryUnitOfWork.Repository
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly UniversityDbContext _context;
        public IStudentsRepository Students { get; }

        public ISubjectRepository Subjects { get; }

        public UnitOfWork(UniversityDbContext universityDbContext,
            IStudentsRepository studentsRepository, 
            ISubjectRepository subjectRepository)
        {
            this._context = universityDbContext;
            
            this.Students = studentsRepository;
            this.Subjects = subjectRepository;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
