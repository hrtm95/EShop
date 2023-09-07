using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.Entity;

namespace EShop.Domain.IRepositories
{
    public interface ICustomerRepository
    {
        Task<GeneralDto<bool>> Create(CustomerAddDto customer);
        Task<GeneralDto<bool>> Update(CustomerEditDto customer);
        Task<GeneralDto<bool>> Delete(int customerId);
        Task<GeneralDto<CustomerOutPutDto>> GetById(int customerId);
        Task<GeneralDto<List<CustomerOutPutDto>>> GetAll();
    }
}
