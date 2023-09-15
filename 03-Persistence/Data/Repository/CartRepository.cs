using _01_Domain.Contract.IRepositories;
using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Cart;
using EShop.Domain.DTOs.Category;
using EShop.Domain.DTOs.Product;
using EShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly EshopContext _context;

        public CartRepository(EshopContext context)
        {
            _context = context;
        }
        public async Task<GeneralDto<bool>> Create(CartAddDto cartdto)
        {
            var cart = new Cart()
            {
                Quntity = cartdto.Quntity,
                CustomerId = cartdto.CustomerId,
                IsPaied = cartdto.IsPaied,
               
            };
            await _context.Carts.AddAsync(cart);    
            await _context.SaveChangesAsync();
            return new GeneralDto<bool> { Id = cart.Id, Data = true };
        }

        public async Task<GeneralDto<bool>> Delete(int cartId)
        {
            var cart = await _context.Carts.FindAsync(cartId);
            cart.IsDeleted = true;
            int number = await _context.SaveChangesAsync();
            if (number == 0)
            {
                return new GeneralDto<bool> { Id = cartId, Data = false };
            }
            return new GeneralDto<bool> { Id = cartId, Data = true };
        }

        public async Task<List<CartOutputDto>> GetAll()
        {
            var carts = await _context.Carts.AsNoTracking().Include(c => c.Products).Include(c => c.Customer)
                .Select(p => new CartOutputDto
                {
                Id = p.Id,
                CustomerId = p.CustomerId,
                Quntity = p.Quntity,
               
                Products = p.Products.Select(C => new ProductOutPutDto { Name = C.Name, Description = C.Description }).ToList()
            }).ToListAsync();

            return carts ;
        }

        public async Task<CartOutputDto> GetById(int cartId)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(p => p.Id == cartId);
            var output = new CartOutputDto
            {

                Id = cartId,
                CustomerId = cart.CustomerId,
                Quntity = cart.Quntity,

            };
            return output;
        }

        public async Task<GeneralDto<bool>> Update(CartEditDto cart)
        {
            var entity = _context.Carts.Find(cart.Id);
            entity.Quntity = cart.Quntity;
            entity.CustomerId = cart.CustomerId;
            entity.IsPaied = cart.IsPaied;

        

            _context.Entry(entity).State = EntityState.Modified;
            int number = await _context.SaveChangesAsync();
            if (number == 0)
            {
                return new GeneralDto<bool> { Id = entity.Id, Data = false };
            }
            return new GeneralDto<bool> { Id = entity.Id, Data = true };
        }

        public async Task<CartOutputDto> GetActiveCart(int customerId)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(p => p.CustomerId == customerId &&  p.IsPaied == false);
            if (cart == null)
            {
                var output = new CartOutputDto
                {

                    Id = cart.Id,
                    CustomerId = cart.CustomerId,
                    Quntity = cart.Quntity,

                };
                return output;
            }
            return null;
           
        }
    }
}
