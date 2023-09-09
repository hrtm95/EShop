using EShop.Domain.DTOs.Customer;
using EShop.Domain.IRepositories;
using EShop.Domain.IServices.CustomerService.Command;

namespace EShop.Domain.Services.CustomerService.Command
{
    public class CustomerCommandService : ICustomerCommandService
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICustomerRepository _customerRepository;

        public CustomerCommandService(ICartRepository cartRepository, ICustomerRepository customerRepository)
        {
            _cartRepository = cartRepository;
            _customerRepository = customerRepository;
        }

        public Task<bool> AddPicture(int PictureId, int item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EditProfile(CustomerEditDto customer)
        {
            var result =await _customerRepository.Update(customer);
            return result.Data;
        }

        public async Task<bool> PayByCustomerId(int customerId)
        {
            var cart = await _cartRepository.GetActiveCart(customerId);
            var result = await _cartRepository.Update(new DTOs.Cart.CartEditDto
            {
                Id = cart.Id,
                productDtos = cart.Products,
                Quntity = cart.Quntity,
                IsPaied = true,
                CustomerId = cart.CustomerId
            }) ;
            return result.Data;
        }
    }
}
