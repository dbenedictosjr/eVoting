using System;
using System.Collections.Generic;
using System.Text;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IEmailSender // don't forget the public modifier
    {
        void Send(string toAddress, string subject, string body, bool sendAsync = true);
    }
}
