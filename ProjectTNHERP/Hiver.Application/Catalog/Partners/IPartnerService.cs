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
        //Task<PagedResult<PartnerVm>> GetAllPaging(GetPartnerPagingRequest request);
        Task<PartnerVm> GetById(int Id);
        Task<int> Create(PartnerCreateRequest request);
        Task<int> Update(PartnerUpdateRequest request);
        Task<int> Delete(int Id);

    }
}
