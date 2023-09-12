using AlbumApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumApplication.BLL.Interfaces
{
    public interface IAdminService
    {
        public void InsertAdmin(Admin admin);
        public bool ValidatePassword(string password);
        public Admin FirstAdmin(Func<Admin,bool> filter);
    }
}
