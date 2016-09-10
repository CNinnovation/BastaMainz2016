using PortableLibrary.Services;
using System.Threading.Tasks;
using System.Windows;

namespace WPFClient.LocalServices
{
    public class WPFMessageService : IMessageService
    {
        public Task MessageAsync(string message)
        {
            MessageBox.Show(message);
            return Task.FromResult<object>(null);
        }
    }
}
