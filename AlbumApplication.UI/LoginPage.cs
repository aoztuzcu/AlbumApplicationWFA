using AlbumApplication.BLL.Interfaces;
using AlbumApplication.BLL.Services;
using AlbumApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumApplication.UI
{
    public partial class LoginPage : Form
    {
        private readonly IAdminService service;
        public LoginPage()
        {
            InitializeComponent();
            service = new AdminService();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var admin = service.FirstAdmin(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text);
            if (admin != null)
            {
                MessageBox.Show("Logined succesfully.");
                AlbumList listAlbum = new AlbumList();
                this.Hide();
                listAlbum.Show();
            }
            else
            {
                MessageBox.Show("Not found admin. Please create new user.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var admin = service.FirstAdmin(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text);
            if (admin == null)
            {
                var newAdmin = new Admin {UserName= txtUserName.Text , Password = txtPassword.Text };
                service.InsertAdmin(newAdmin);
                MessageBox.Show("Created succesfully.");
            }
            else
            {
                MessageBox.Show("There is an admin with this username!");
            }
        }
    }
}
