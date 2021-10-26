using S10UESAN_NCORE.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace S10UESAN_NCORE.Domain.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Task<bool> Delete(int id);
        Task<Customer> GetCustomerById(int id);
        Task<IEnumerable<Customer>> GetCustomers();
        Task Insert(Customer customer);
        Task<bool> Update(Customer customer);
    }
}