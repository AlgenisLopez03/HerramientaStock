using CapaDato;
using Common.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UserModel
    {
        UserPass userPass = new UserPass();
        public bool LoginUser(string user, string password)
        {
            return userPass.Login(user, password);
        }
        public void AnyMethod()
        {
            if (UserLoginCache.Position == CargosINV.Administrator)
            {

            }
            if (UserLoginCache.Position == CargosINV.General)
            {

            }

        }
    }
}
