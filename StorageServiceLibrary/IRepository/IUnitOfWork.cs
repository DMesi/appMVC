using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StorageServiceLibrary.Model;

namespace StorageServiceLibrary.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Proizvod> Proizvodi { get; }
        IGenericRepository<Kategorija> Kategorije { get; }
        IGenericRepository<Dobavljac> Dobavljaci { get; }
        IGenericRepository<Proizvodjac> Proizvodjaci { get; }
        Task Save();

    }
}
