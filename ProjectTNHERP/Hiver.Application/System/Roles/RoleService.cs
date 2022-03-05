using Hiver.Data.EF;
using Hiver.Data.Entities;
using Hiver.Utilities.Exceptions;
using Hiver.ViewModels.Common;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly HiverDbContext _context;


        public RoleService(RoleManager<AppRole> roleManager, HiverDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<ApiResult<bool>> Create(RoleCreateRequest request)
        {
            var table = await _roleManager.Roles.Where(x => x.ControllerName == request.ControllerName 
                && x.ActionName == request.ActionName).FirstOrDefaultAsync();

            if (table != null)
            {
                return new ApiErrorResult<bool>("Đã tồn tại");
            }

            table = new AppRole()
            {
                ControllerName = request.ControllerName,
                ActionName = request.ActionName,
                Description = request.Description,
                Name = request.Name
            };
            var result = await _roleManager.CreateAsync(table);

            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Tạo không thành công");
        }

        public async Task<ApiResult<bool>> Delete(Guid id)
        {
            var user = await _roleManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<bool>("Id không tồn tại");
            }
            var reult = await _roleManager.DeleteAsync(user);
            if (reult.Succeeded)
                return new ApiSuccessResult<bool>();

            return new ApiErrorResult<bool>("Xóa không thành công");
        }

        public async Task<List<RoleVm>> GetAll()
        {
            var roles = await _roleManager.Roles
                .Select(x => new RoleVm()
                {
                    Id = x.Id,
                    ControllerName = x.Description,
                    ActionName = x.ActionName,
                    Description = x.Description,
                    Name = x.Name
                }).ToListAsync();

            return roles;
        }

        public async Task<ApiResult<RoleVm>> GetById(Guid id)
        {
            var table = await _roleManager.FindByIdAsync(id.ToString());
            if (table == null)
            {
                return new ApiErrorResult<RoleVm>("Idhông tồn tại");
            }

            var tableVm = new RoleVm()
            {
                ControllerName = table.ControllerName,
                ActionName = table.ActionName,
                Description = table.Description,
                Name = table.Name,
                Id = table.Id
            };
            return new ApiSuccessResult<RoleVm>(tableVm);
        }

        public async Task<ApiResult<PagedResult<RoleVm>>> GetRolesPaging(GetRolePagingRequest request)
        {
            var query = _roleManager.Roles;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.ControllerName.Contains(request.Keyword)
                 || x.ActionName.Contains(request.Keyword));
            }

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new RoleVm()
                {
                    Id = x.Id,
                    ControllerName = x.ControllerName,
                    ActionName = x.ActionName,
                    Description = x.Description,
                    Name = x.Name
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<RoleVm>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return new ApiSuccessResult<PagedResult<RoleVm>>(pagedResult);
        }

        public async Task<ApiResult<bool>> roleCheck(string userName ,RoleCheckVm request)
        {
            var rel = await _context.Roles.Where(x => x.ControllerName == request.ControllerName &&
                x.ActionName == request.ActionName).FirstOrDefaultAsync();

            if (rel == null)
            {
                return new ApiErrorResult<bool>("Bạn không có quyền đăng nhập");
            }

            var checkidUser = await _context.Users.SingleOrDefaultAsync(x => x.UserName == userName);

            if (checkidUser == null)
            {
                return new ApiErrorResult<bool>("Bạn không có quyền đăng nhập");
            }

            var result = await _context.UserRoles.SingleOrDefaultAsync(x => x.UserId == checkidUser.Id
            && x.RoleId == rel.Id);

            if (result == null)
            {
                return new ApiErrorResult<bool>("Bạn không có quyền đăng nhập");
            }

            return new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> Update(Guid id, RoleUpdateRequest request)
        {
            var tablerole = await _context.Roles.FindAsync(id);

            var table = await _context.Roles.Where(x => x.Id != tablerole.Id).Select(x => new RoleVm()
            {
                ActionName = x.ActionName,
                ControllerName = x.ControllerName,
                Description = x.Description,
                Id = id,
                Name = x.Name
            }).ToListAsync();

            foreach(var role in table)
            {
                if(String.Compare(role.ControllerName,request.ControllerName,true) == 0 && String.Compare(role.ActionName, request.ActionName, true) == 0)
                {
                    return new ApiErrorResult<bool>("Quyền hạn đã trùng khớp không thể cập nhập");
                }    
            }

            tablerole.ControllerName = request.ControllerName;
            tablerole.ActionName = request.ActionName;
            tablerole.Description = request.Description;
            tablerole.Name = request.Name;


            _context.Roles.Update(tablerole);

            await _context.SaveChangesAsync();

            return new ApiSuccessResult<bool>();
        }
    }
}