using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumApplication.Data.Entities
{
    public class Admin:BaseEntity
    {
        public Admin()
        {
            Albums = new HashSet<Album>();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
