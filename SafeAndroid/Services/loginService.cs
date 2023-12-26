using SafeAndroid.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafeAndroid.Services
{
    
    public class loginService : ILoginService
    {
        List<UserModel> userList = new List<UserModel>();

        public loginService() 
        { 
            userList.Add(new UserModel { userName="igor",password="123456" });
            userList.Add(new UserModel { userName = "igorl", password = "123456" });
        }   

        public bool login(string username, string password)
        {
            foreach(var user in userList)
            {
                if(username==user.userName & password == user.password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
