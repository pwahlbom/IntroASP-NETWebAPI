using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroASP_NETWebAPI.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
