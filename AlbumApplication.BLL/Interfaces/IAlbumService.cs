using AlbumApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumApplication.BLL.Interfaces
{
    public interface IAlbumService
    {
        public void AddAlbum(Album album );
        public List<Album> GetAlbums();
        public List<Album> NotinSaleAlbums();
        public List<Album> OnGoingSaleAlbums();
        public List<Album> LastAddedAlbums();
        public IEnumerable<Album> InDiscountAlbums();

    }
}
