using BOL.Abstractions;
using DLL.Abstractions;
using DLL.Context;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Services
{
    public class TeacherServices : GenericService<Teacher>
    {
        public TeacherServices(IRepository<Teacher> repository) : base(repository)
        {
        }
    }
}
