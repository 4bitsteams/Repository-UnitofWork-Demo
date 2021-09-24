using System;
using UniversityManagementUseRepositoryUnitOfWork.Domain;
using UniversityManagementUseRepositoryUnitOfWork.Domain;

namespace UniversityManagementUseRepositoryUnitOfWork.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentsRepository Students { get; }
        ISubjectRepository Subjects { get; }
        int Complete();
    }
}
