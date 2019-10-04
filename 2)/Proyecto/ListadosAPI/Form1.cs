using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;
namespace ListadosAPI
{
    public partial class Form1 : Form
    {
        bool CanMove=false;
        private String Mode;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {//Muestro los Users
            string sURL;
            sURL = "https://reqres.in/api/users?page=2";
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            string sLine = "";
            sLine = objReader.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject(sLine);
            UsersDataGrid.DataSource = obj.data;//Utilizo el .data puesto a que los datos están almacenados en éste atributo
            Mode = "Users";
            PictUser.Visible = true;
        }

       

        private void button3_Click(object sender, EventArgs e)
        {//Muestro el Post
            string sURL;
            sURL = "https://jsonplaceholder.typicode.com/posts";
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            string sLine = "";
            sLine = objReader.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject(sLine);
            UsersDataGrid.DataSource = obj;//Cargo el DataGridView
            Mode = "Post";
            LblNameUser.Visible = false;
            PictUser.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UsersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Mode == "Users")
            {//Si lo que se ha buscado son Users accedo y cargo su imagen
                String Image;
                Image = (UsersDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString());
                SetImage(Image);
                LblNameUser.Text = UsersDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                LblNameUser.Visible = true;
            }
        }
        private void SetImage(String UrlImage) {//Actualizo la imagen
            var request = WebRequest.Create(UrlImage);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                PictUser.Image = Bitmap.FromStream(stream);
            }
        }

        private void UsersDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Mode == "Users")
            {//Si lo que se ha buscado son Users accedo y cargo su imagen
                String Image;
                Image = (UsersDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString());
                LblNameUser.Text = UsersDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                SetImage(Image);
                LblNameUser.Visible = true;
            }
        }

        private void LblNameUser_Click(object sender, EventArgs e)
        {

        }
    }
}
