using System;
using UniversityManagementUseRepositoryUnitOfWork.Domain.StudentsAggregate;
using UniversityManagementUseRepositoryUnitOfWork.Domain.SubjectAggregate;

namespace UniversityManagementUseRepositoryUnitOfWork.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentsRepository Students { get; }
        ISubjectRepository Subjects { get; }
        int Complete();
    }
}
