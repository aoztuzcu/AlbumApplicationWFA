using AlbumApplication.BLL.Interfaces;
using AlbumApplication.DAL.Repositories;
using AlbumApplication.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlbumApplication.BLL.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository<Admin> repository;
        public AdminService()
        {
            repository = new BaseRepository<Admin>();
        }

        public Admin FirstAdmin(Func<Admin, bool> filter)
        {
            return repository.FirstEntity(filter);
        }

        public void InsertAdmin(Admin admin)
        {            
            bool passwordControl = ValidatePassword(admin.Password);
            if (passwordControl) 
            {
                repository.Insert(admin);
            }
            else { throw new Exception("Password is not valid!"); }
            string hashedPassword = HashPassword(admin.Password);
            admin.Password = hashedPassword;
        }

        public bool ValidatePassword(string password)
        {
            // En az 8 karakter uzunluğunda olmalıdır.
            if (password.Length < 8) return false;
            // En az 2 büyük harf içermelidir.
            if (password.Count(char.IsUpper) < 2) return false;
            // En az 3 küçük harf içermelidir.
            if (password.Count(char.IsLower) < 3) return false;
            // Belirtilen özel karakterlerden en az 2 tanesini içermelidir.
            string specialCharacters = "!:+*";
            if (password.Count(c => specialCharacters.Contains(c)) < 2) return false;
            // Yukarıdaki tüm koşulları geçerse, şifre geçerlidir.
            return true;
        }
        private string HashPassword(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
    }
}
