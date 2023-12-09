using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntityLayer.Concrete
{
    public class SubscribeMail
    {
        [Key] //CLASS EKLENDİ --> DATAACCESS/CONTEXTE SINIFI TANIT
        public int MailID { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
    }
}
