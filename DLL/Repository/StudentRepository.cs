using DLL.Abstractions;
using DLL.Context;
using DLL.Models;

namespace DLL.Repository
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
