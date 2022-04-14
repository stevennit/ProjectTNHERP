using Hiver.ViewModels.Catalog.ProductCategories;
using Hiver.ViewModels.Catalog.ProductImages;
using Hiver.ViewModels.Catalog.Products;
using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> AddImage(Guid tableId, ProductImageCreateRequest request);
        Task<ProductImageVm> GetImageById(int imageId);
        Task<List<Guid>> GetListProductCategory(Guid tableId);
        Task<List<ProductImageVm>> GetListProductImages(Guid tableId);
        Task<int> UpdateImage(int imageId,ProductImageUpdateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<PagedResult<ProductVm>> GetAllPaging(GetManageProductPagingRequest request);
        List<ProductVm> GetAll();
        Task<ProductVm> GetById(Guid Id);
        Task<Guid> Create(ProductVm request);
        Task<Guid> Update(ProductVm request);
        Task<Guid> Delete(Guid productId);

        Task<ApiResult<bool>> ProductAssignCategory(Guid id, CategoryAssignRequest request);

    }
}
