using DLL.Abstractions;
using DLL.Context;
using DLL.Models;

namespace DLL.Repository
{
    public class TeacherRepository : GenericRepository<Teacher>
    {
        public TeacherRepository(AppDbContext context) : base(context)
        {
        }
    }
}
