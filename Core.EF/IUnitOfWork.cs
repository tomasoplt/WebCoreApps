using EF.Core;

namespace Net.Core.EF
{
    public interface IUnitOfWork
    {
        void Dispose();
        void Dispose(bool disposing);
        Repository<T> Repository<T>() where T : BaseEntity;
        void Save();
    }
}