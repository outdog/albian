using Albian.Service;

namespace Albian.Kernel
{
    public interface IIdService : IAlbianService
    {
        string Generator();
        string Generator(string mark);
    }
}