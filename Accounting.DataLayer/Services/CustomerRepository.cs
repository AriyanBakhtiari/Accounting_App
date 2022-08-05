using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.ViewModels.Customer;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities Context)
        {
            db = Context;
        }
        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(int CustomerID)
        {
            try
            {
                var c1 = GetCustomerByID(CustomerID);
                DeleteCustomer(c1);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }
        public Customer GetCustomerByID(int CustomerID)
        {
            return db.Customers.Find(CustomerID);

        }
        public List<Customer> GetCustomerByFilter(string filter)
        {
            return db.Customers.Where(C => C.FullName.Contains(filter) || C.Email.Contains(filter) || C.Mobile.Contains(filter)).ToList();
        }
        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {

            var local = db.Set<Customer>()
                     .Local
                     .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(customer).State = EntityState.Modified;
            return true;

        }
        public List<ListCustomer> GetCustomerName(string filter = "")
        {
            if (filter == null)
            {

                return db.Customers.Select(n => new ListCustomer
                {
                    FullName = n.FullName
                }).ToList();
            }
            else
            {

                return db.Customers.Where(n => n.FullName.Contains(filter)).Select(n => new ListCustomer
                {
                    FullName = n.FullName
                }).ToList();
            }
        }
        public int GetCustomerID(string name)
        {
            return db.Customers.First(a => a.FullName == name).CustomerID;
        }
        public string GetCustomerNamebyID(int Customerid)
        {
            return db.Customers.Find(Customerid).FullName;
        }
    }
}
