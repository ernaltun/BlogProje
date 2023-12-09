using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repoContact = new Repository<Contact>();

        public int BLContctAdd(Contact c)
        {
            if(c.Mail==""|| c.Message==""||c.Name==""||c.Subject==""||
                c.SurName == "" || c.Mail.Length <= 10 || c.Subject.Length <= 3)
            {
                return -1;
            }
            return repoContact.Insert(c);
        }
    }
}
