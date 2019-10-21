using Common;
using Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.method
{
    public class UserMethod
    {
       

        DBModel db = null;
        public UserMethod()
        {
            db = new DBModel();
        }
        public User GetById(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }

        public int Login(string userName, string passWord, bool isLoginAdmin = false)
        {
             
            
            var result = db.Users.SingleOrDefault(x => x.UserName == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (isLoginAdmin == true)
                {

                    if ( result.Position == CommonConstants.ADMIN_GROUP )
                    {
                        if (result.Status == false)
                        {
                            return -1;
                        }
                        else
                        {
                            if (result.Password == passWord)
                                return 1;
                            else
                                return -2;
                        }
                    }
                    else
                    {
                        return -3;
                    }

                }
                else
                {
                    if (result.Status == false)
                    {
                        return -1;
                    }
                    else
                    {
                        if (result.Password == passWord)
                            return 1;
                        else
                            return -2;
                    }
                }
            }
        }
    }
}
