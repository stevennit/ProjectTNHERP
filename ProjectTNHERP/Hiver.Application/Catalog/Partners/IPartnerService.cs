using Hiver.ViewModels.Catalog.Partners;
using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Catalog.Partners
{
    public interface IPartnerService
    {
        Task<PagedResult<PartnerVm>> GetAllPaging(GetPartnerPagingRequest request);
        Task<PartnerVm> GetById(Guid Id);
        Task<Guid> Create(PartnerCreateRequest request);
        Task<Guid> Update(PartnerUpdateRequest request);
        Task<Guid> Delete(Guid Id);

    }
}
