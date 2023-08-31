using EShop.Domain.DTOs;
using EShop.Domain.Entity;

namespace EShop.Domain.IServices.CustomerService.Command
{
    public interface ICustomerCommandService
    {
        Task<bool> EditProfile(CustomerEditDto customer);
        Task<bool> PayByCustomerId(int customerId);

    }
}
