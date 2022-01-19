using StoreManager2.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace StoreManager2.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}