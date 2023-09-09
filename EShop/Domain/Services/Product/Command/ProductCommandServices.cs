using EShop.Domain.DTOs.Cart;
using EShop.Domain.DTOs.Product;
using EShop.Domain.Entity;
using EShop.Domain.IRepositories;
using EShop.Domain.IServices.ProductService.Commands;
using System.Net.Http.Headers;

namespace EShop.Domain.Services.Product.Command
{
    public class ProductCommandServices : IProductCommandService
    {
        private readonly IProductRepository productRepository;
        private readonly ICartRepository cartRepository;
        public ProductCommandServices(IProductRepository productRepository, ICartRepository cartRepository)
        {
            this.productRepository = productRepository;
            this.cartRepository = cartRepository;
        }

        public Task<bool> AddPicture(int PictureId, int item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AddProductToCartByProductid(int customerid, int productid)
        {
            try
            {
                var product = await productRepository.GetById(productid);
                var cart = (await cartRepository.GetActiveCart(customerid));
                if (cart != null)
                {
                    if (cart.Products.Where(x => x.Id == productid).FirstOrDefault() != null)
                    {
                        cart.Products.Add(product);
                        var newDto = new CartEditDto()
                        {
                            CustomerId = customerid,
                            Id = cart.Id,
                            IsPaied = false,
                        };
                        await cartRepository.Update(newDto);
                        return true;
                    }
                    else
                    {
                        cart.Products.Add(product);

                        var newDto = new CartEditDto()
                        {
                            CustomerId = customerid,
                            Id = cart.Id,
                            IsPaied = false,
                            Quntity = cart.Quntity + 1,
                        };
                        await cartRepository.Update(newDto);
                        return true;
                    }
                }
                else
                {
                    // fix quantity 

                    var newCard = new CartAddDto()
                    {
                        CustomerId = customerid,
                        IsPaied = false,
                        Quntity = 1
                    };
                    await cartRepository.Create(newCard);
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> CreateProduct(ProductAddDto product)
        {
            var result = await productRepository.Create(product);
            return result.Data;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var result = await productRepository.Delete(productId);
            return result.Data;
        }

        public async Task<bool> DeleteProductFromCart(int cartId, int productId)
        {
            var product = await productRepository.GetById(productId);
            var cart = await cartRepository.GetById(cartId);
            if (cart != null)
            {
                var number = cart.Products.Where(x => x.Id == productId).Count();
                var productRemove = cart.Products.FirstOrDefault(x => x.Id == productId);

                cart.Products.Remove(productRemove);
                if (number == 1)
                {
                    await cartRepository.Update(new CartEditDto
                    {
                        Id = cart.Id,
                        CustomerId = cart.CustomerId,
                        IsPaied = false,
                        Quntity = cart.Quntity - 1,
                        productDtos=cart.Products
                    });
                }
                else
                {
                    await cartRepository.Update(new CartEditDto
                    {
                        Id = cart.Id,
                        CustomerId = cart.CustomerId,
                        IsPaied = false,
                        Quntity = cart.Quntity,
                        productDtos = cart.Products
                    });
                }
            }
            else
            {
                return false;
            }
            return false;
        }

        public Task<bool> EditeProduct(ProductEditDto product)
        {
           throw new NotImplementedException();
        }
    }
}
