using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Models
{
    public class User : IdentityUser
    {
        public string FirtsName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
