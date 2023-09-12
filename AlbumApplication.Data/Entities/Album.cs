using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumApplication.Data.Entities
{
    public class Album:BaseEntity
    {
        public Album()
        {
            Admins = new HashSet<Admin>();
        }
        public string Name { get; set; }
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountRate { get; set; }
        public bool SalesStatu { get; set; }
        public virtual ICollection<Admin> Admins { get; set; }
    }
}
