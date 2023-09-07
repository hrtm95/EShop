using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.IRepositories;

namespace EShop.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<GeneralDto<bool>> Create(CustomerAddDto customer)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<bool>> Delete(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<List<CustomerOutPutDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<CustomerOutPutDto>> GetById(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<bool>> Update(CustomerEditDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
