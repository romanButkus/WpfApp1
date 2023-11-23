using DLL.Abstractions;
using DLL.Context;
using DLL.Models;

namespace DLL.Repository
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }
    }
}
