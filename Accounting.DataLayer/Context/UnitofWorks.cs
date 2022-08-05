using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Context
{
    public class UnitofWorks : IDisposable
    {

        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepository _customerrepository;
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerrepository == null)
                {
                    _customerrepository = new CustomerRepository(db);
                    return _customerrepository;
                }
                return _customerrepository;
            }
        }


        private GenericRepository<Accounting> _accountingrepository;
        public GenericRepository<Accounting> AccountingRepository
        {
            get
            {
                if (_accountingrepository == null)
                {
                    _accountingrepository = new GenericRepository<Accounting>(db);
                }
                return _accountingrepository;
            }
        }


        private GenericRepository<Login> _LoginRepostitory;
        public GenericRepository <Login> LoginRepostitory
        {
            get
            {
                 if (_LoginRepostitory == null)
                {
                    _LoginRepostitory = new GenericRepository<Login>(db);
                }
                 return (_LoginRepostitory);
            }
        }



        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
