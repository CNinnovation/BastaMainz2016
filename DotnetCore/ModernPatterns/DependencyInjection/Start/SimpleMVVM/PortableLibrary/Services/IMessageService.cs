using System.Threading.Tasks;

namespace PortableLibrary.Services
{
    public interface IMessageService
    {
        Task MessageAsync(string message);
    }
}
