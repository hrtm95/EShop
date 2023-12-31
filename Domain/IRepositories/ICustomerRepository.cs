﻿using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.Entity;

namespace EShop.Domain.IRepositories
{
    public interface ICustomerRepository
    {
        Task<GeneralDto<bool>> Create(CustomerAddDto customer, ApplicationUser user);
        Task<GeneralDto<bool>> Update(CustomerEditDto customer);
        Task<GeneralDto<bool>> Delete(int customerId);
        Task<GeneralDto<CustomerOutPutDto>> GetById(int customerId);
        Task<List<CustomerOutPutDto>> GetAll();
    }
}
