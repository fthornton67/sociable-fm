using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sociable_fm.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
