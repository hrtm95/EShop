using EShop.Domain.DTOs;
using EShop.Domain.IRepositories;

namespace EShop.Data.Repository
{
    public class CartRepository : ICartRepository
    {
        public Task<GeneralDto<bool>> Create(CartAddDto cart)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<bool>> Delete(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<List<CartOutputDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<CartOutputDto>> GetById(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<bool>> Update(CartEditDto cart)
        {
            throw new NotImplementedException();
        }
    }
}
