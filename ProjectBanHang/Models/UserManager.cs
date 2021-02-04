using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBanHang.Models
{
    public class UserManager
    {

        public bool CheckUserName(String username)
        {
            Model1 db = new Model1();

            System.Threading.Thread.Sleep(200);
            var SearchData = db.Accounts.Where(x => x.name == username).SingleOrDefault();
            if (SearchData != null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool CheckEmail(String email)
        {

            Model1 db = new Model1();
            System.Threading.Thread.Sleep(200);
            var SearchData = db.Accounts.Where(x => x.email == email).SingleOrDefault();
            if (SearchData != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        //public bool CheckUserName(String username)
        //{
        //    Model1 db = new Model1();
        //    List<Account> user_finded = (from nd in db.Accounts where nd.username == username select nd).ToList();
        //    if (user_finded.Count == 1)
        //    {
        //        return true;
        //    }
        //    else { return false; }
        //    //Kiem tra ton tai username trong DB chua
        //    //true: ton tai trong DB
        //}
        //public bool CheckEmail(String email)
        //{
        //    Model1 db = new Model1();
        //    List<Account> email_finded = (from nd in db.Accounts where nd.email == email select nd).ToList();
        //    if (email_finded.Count == 1)
        //    {
        //        return true;
        //    }
        //    else { return false; }
        //    //Kiem tra ton tai email trong DB chua
        //    //true: ton tai trong DB
        //}
        public bool CheckUser(String username, String password)
        {
            Model1 db = new Model1();
            List<Account> user_finded = (from nd in db.Accounts where nd.username == username && nd.password == password select nd).ToList();
            if (user_finded.Count == 1)
            {
                return true;
            }
            else { return false; }
            //Kiem tra ton tai username trong DB chua
            //true: ton tai trong DB
        }
    }
}