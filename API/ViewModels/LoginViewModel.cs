using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class LoginViewModel
    {
        [Required]
        public string email { get; set; }
        public string senha { get; set; }
    }
}
