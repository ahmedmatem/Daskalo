
namespace Daskalo.Infrastructure.Data.Types
{
    [Flags]
    public enum Role
    {
        Admin =  1,
        SchoolAdmin = 2,
        Teacher = 4,
        Student = 8,
        Parent = 16
    }
}
