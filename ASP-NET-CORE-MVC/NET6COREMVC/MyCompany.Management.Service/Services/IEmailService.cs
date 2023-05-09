using MyCompany.Management.Service.Models;

namespace MyCompany.Management.Service.Services
{
    public interface IEmailService
    {
        void SendEmail(MailMessage mailMessage);
    }
}
