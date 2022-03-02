using Hiver.ViewModels.Catalog.Customers;
using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Catalog.Customers
{
    public interface ICustomerService
    {
        Task<PagedResult<CustomerVm>> GetAllPaging(GetCustomerPagingRequest request);
        Task<CustomerVm> GetById(int Id);
        Task<int> Create(CustomerCreateRequest request);
        Task<int> Update(CustomerUpdateRequest request);
        Task<int> Delete(int Id);

    }
}
