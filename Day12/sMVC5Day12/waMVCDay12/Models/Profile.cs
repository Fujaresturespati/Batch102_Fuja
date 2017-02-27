using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace waMVCDay12.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string NamaLengkap { get; set; }
        public string Alamat { get; set; }
        public string Hobby { get; set; }
    }
}