using System;
using System.Collections.Generic;
using System.Text;

namespace SafeAndroid.Services
{
    public interface ILoginService
    {
       bool login(string username, string password);
    }
}
