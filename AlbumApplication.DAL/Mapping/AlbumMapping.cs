using AlbumApplication.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumApplication.DAL.Mapping
{
    public class AlbumMapping: IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasQueryFilter(x => x.IsDeleted == false);
            builder.Property(y=>y.Name).HasMaxLength(100);
            builder.Property(y => y.Artist).HasMaxLength(50);
            builder.HasData(
            new Album { Id = 1, Name = "İki Aşk", Artist = "Teoman", ReleaseDate = new DateTime(2006, 1, 1), Price = 10.99m, DiscountRate = 0, SalesStatu = true },
            new Album { Id = 2, Name = "21", Artist = "Adele", ReleaseDate = new DateTime(2011, 1, 24), Price = 12.99m, DiscountRate = 0, SalesStatu = true },
            new Album { Id = 3, Name = "Back to Black", Artist = "Amy Winehouse", ReleaseDate = new DateTime(2006, 10, 27), Price = 9.99m, DiscountRate = 0.10m, SalesStatu = true },
            new Album { Id = 4, Name = "Nevermind", Artist = "Nirvana", ReleaseDate = new DateTime(1991, 9, 24), Price = 8.99m, DiscountRate = 0, SalesStatu = true },
            new Album { Id = 5, Name = "The Dark Side of the Moon", Artist = "Pink Floyd", ReleaseDate = new DateTime(1973, 3, 1), Price = 11.99m, DiscountRate = 0, SalesStatu = true },
            new Album { Id = 6, Name = "Abbey Road", Artist = "The Beatles", ReleaseDate = new DateTime(1969, 9, 26), Price = 10.99m, DiscountRate = 0.11m, SalesStatu = true },
            new Album { Id = 7, Name = "Rumours", Artist = "Fleetwood Mac", ReleaseDate = new DateTime(1977, 2, 4), Price = 9.99m, DiscountRate = 0, SalesStatu = true },
            new Album { Id = 8, Name = "Thriller", Artist = "Michael Jackson", ReleaseDate = new DateTime(1982, 11, 30), Price = 12.99m, DiscountRate = 0, SalesStatu = true },
            new Album { Id = 9, Name = "The Joshua Tree", Artist = "U2", ReleaseDate = new DateTime(1987, 3, 9), Price = 11.99m, DiscountRate = 0.15m, SalesStatu = true },
            new Album { Id = 10, Name = "Appetite for Destruction", Artist = "Guns N' Roses", ReleaseDate = new DateTime(1987, 7, 21), Price = 10.99m, DiscountRate = 0, SalesStatu = true });
        }
    }
}
