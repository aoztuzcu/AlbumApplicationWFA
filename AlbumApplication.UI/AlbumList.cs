using AlbumApplication.BLL.Interfaces;
using AlbumApplication.BLL.Services;
using AlbumApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumApplication.UI
{
    public partial class AlbumList : Form
    {
        private readonly IAlbumService albumsService;
        public AlbumList()
        {
            albumsService = new AlbumService();
            InitializeComponent();
        }

        private void AlbumList_Load(object sender, EventArgs e)
        {
            var list = albumsService.GetAlbums();
            dataGridView1.DataSource = list;

            var list1 = albumsService.OnGoingSaleAlbums();
            ongo.DataSource = list1;

            var list2 = albumsService.LastAddedAlbums();
            lastaddeddv.DataSource = list2;

            var list3 = albumsService.NotinSaleAlbums();
            notindv.DataSource = list3;

            var list4 = albumsService.InDiscountAlbums();
            indiscountdv.DataSource = list4;
        }

        private void addalbumbuton_Click(object sender, EventArgs e)
        {
            Album album = new Album() { Name= adtxt.Text, Artist= artisttxt.Text, DiscountRate=Convert.ToDecimal( discounttxt.Text), ReleaseDate=dateTimePicker1.Value, Price= Convert.ToDecimal(pricetxt.Text), SalesStatu = checkBox1.Checked };
            albumsService.AddAlbum(album);
          
        }
    }
}
