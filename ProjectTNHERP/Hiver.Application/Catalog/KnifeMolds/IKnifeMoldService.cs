using Hiver.ViewModels.Catalog.KnifeMoldImages;
using Hiver.ViewModels.Catalog.KnifeMolds;
using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Catalog.KnifeMolds
{
    public interface IKnifeMoldService
    {
        Task<int> AddImage(Guid tableId, KnifeMoldImageCreateRequest request);
        Task<KnifeMoldImageVm> GetImageById(int imageId);
        Task<List<KnifeMoldImageVm>> GetListImages(Guid tableId);
        Task<int> UpdateImage(int imageId, KnifeMoldImageUpdateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<PagedResult<KnifeMoldVm>> GetAllPaging(GetAllKnifeMoldPagingRequest request);
        Task<KnifeMoldVm> GetById(Guid Id);
        Task<Guid> Create(KnifeMoldCreateRequest request);
        Task<Guid> Update(KnifeMoldUpdateRequest request);
        Task<Guid> Delete(Guid Id);

    }
}
