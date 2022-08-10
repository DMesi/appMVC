using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StorageServiceLibrary.IRepository;
using StorageServiceLibrary.Model;

namespace StorageServiceLibrary.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly App_Data_Base _context;

        private IGenericRepository<Proizvod> _proizvodi;
        private IGenericRepository<Kategorija> _kategorije;
        private IGenericRepository<Proizvodjac> _proizvodjaci;
        private IGenericRepository<Dobavljac> _dobavljaci;
        public UnitOfWork(App_Data_Base context)
        {
            _context = context;
        }

        public IGenericRepository<Proizvod> Proizvodi => _proizvodi ??= new GenericRepositroy<Proizvod>(_context);

        public IGenericRepository<Kategorija> Kategorije => _kategorije ??= new GenericRepositroy<Kategorija>(_context);

        public IGenericRepository<Proizvodjac> Proizvodjaci => _proizvodjaci ??= new GenericRepositroy<Proizvodjac>(_context);

        public IGenericRepository<Dobavljac> Dobavljaci => _dobavljaci ??= new GenericRepositroy<Dobavljac>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);

        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
