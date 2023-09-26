using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerData.Model
{
    public class UserInfo : LoginVM
    {
        public int id { get; set; }

        public int roleId { get; set; }
       
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(32)]
        public string Contactno { get; set; }
        public int TotalmatchPlayed { get; set; }

        [Required]
        public int Height { get; set; }
        public int Weight { get; set; }



    }
}
