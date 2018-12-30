using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;

namespace EInvoice.Service
{
    public class RoleService : BaseService<Role>, IRoleService
    {
        private readonly IRepository<Role> _roleRepository;

        public RoleService(IRepository<Role> roleRepository, IUnitOfWork unitOfWork) : base(roleRepository, unitOfWork)
        {
            _roleRepository = roleRepository;
        }
    }
}