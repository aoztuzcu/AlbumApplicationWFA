using AlbumApplication.BLL.Interfaces;
using AlbumApplication.DAL.Repositories;
using AlbumApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlbumApplication.BLL.Services
{
    public class AlbumService:IAlbumService
    {
        private readonly IRepository<Album> repository;
        public AlbumService()
        {
            repository = new BaseRepository<Album>();
        }

        public void AddAlbum(Album album)
        {
            repository.Insert( album);
        }

        public List<Album> GetAlbums()
        {
           return repository.GetAll();
        }

        public IEnumerable<Album> InDiscountAlbums()
        {
            var list = repository.Where(x => x.DiscountRate > 0).OrderByDescending(x => x.DiscountRate);
            return list;
        }

        public List<Album> LastAddedAlbums()
        {
            var list = repository.GetQueryable().OrderByDescending(x => x.Id)
                .Take(10)
                .ToList();
            return list;
        }

        public List<Album> NotinSaleAlbums()
        {
            var list = repository.Where(x => x.SalesStatu = false);
            return list;
        }

        public List<Album> OnGoingSaleAlbums()
        {
            var list = repository.Where(x => x.SalesStatu = true);
            return list;
        }
    }
}
