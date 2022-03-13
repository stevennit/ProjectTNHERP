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
        Task<int> AddImage(int tableId, ProductImageCreateRequest request);
        Task<ProductImageVm> GetImageById(int imageId);
        Task<List<ProductImageVm>> GetListImages(int tableId);
        Task<int> UpdateImage(int imageId,ProductImageUpdateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<PagedResult<ProductVm>> GetAllPaging(GetManageProductPagingRequest request);
        Task<ProductVm> GetById(int Id);
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task AddViewcount(int productId);

        Task<ApiResult<bool>> ProductAssignCategory(int id, ProductAssignCategoryRequest request);

    }
}
