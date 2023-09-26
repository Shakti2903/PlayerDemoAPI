using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerData.Model
{
    public class UserInfoDTO
    {
        public int id { get; set; }

        public int roleId { get; set; }
        public RoleInfo RoleInfo { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public int Contactno { get; set; }
        public int TotalmatchPlayed { get; set; }

        [Required]
        public string Email { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public string Password { get; set; }
    }
}
