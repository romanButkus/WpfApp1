using BOL.Abstractions;
using DLL.Abstractions;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Services
{
    public class UserServices : GenericService<User>
    {
        public UserServices(IRepository<User> repository) : base(repository)
        {
        }
    }
}
