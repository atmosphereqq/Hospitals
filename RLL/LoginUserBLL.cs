using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class LoginUserBLL
    {
        public Boolean Check(LoginUser u)
        {
            return new LoginUserDAL().Chcek(u);
        }
    }
}
