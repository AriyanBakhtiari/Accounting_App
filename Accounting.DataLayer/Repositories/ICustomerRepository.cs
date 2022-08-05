using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Customer;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();

        List<ListCustomer> GetCustomerName(string filter = "");
        List<Customer> GetCustomerByFilter(String filter);
        Customer GetCustomerByID(int CustomerID);
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int CustomerID);
        int GetCustomerID (string name); 

        string GetCustomerNamebyID (int Customerid);
        

    }
}
