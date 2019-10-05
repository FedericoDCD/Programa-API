using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
namespace ApiPostPut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread Trd = new Thread(Post);
            if (TxtName.Text != "" && TxtJob.Text != "")//Si ninguno de los textbox se encuentran vacíos permito el post
            {
                Trd.Start();
            }
            else {//Sino lo digo
                LblError.Visible = true;
            }
        }
        private void Post() {
            HttpWebRequest request = WebRequest.Create("https://reqres.in/api/users/2") as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            String Name, Job;
            Name = TxtName.Text;
            Job = TxtJob.Text;
            // Metodo modificado
            string postData = "name=" + Name + "&job=" + Job; byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                using (StreamWriter stmw = new StreamWriter(dataStream))
                {
                    stmw.Write(postData);
                }
                //dataStream.Write(byteArray, 0, byteArray.Length);
            }

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string resp = reader.ReadToEnd();
                MessageBox.Show(resp);
            }
        }
        private void Put() {
            HttpWebRequest request = WebRequest.Create("https://reqres.in/api/users/2") as HttpWebRequest;
            request.Method = "PUT";
            request.ContentType = "application/x-www-form-urlencoded";
            String Job;
            Job = TxtJobPut.Text;
            // Metodo modificado
            string putData = "name=morpheus&job=" + Job; byte[] byteArray = Encoding.UTF8.GetBytes(putData);
            request.ContentLength = byteArray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                using (StreamWriter stmw = new StreamWriter(dataStream))
                {
                    stmw.Write(putData);
                }
                //dataStream.Write(byteArray, 0, byteArray.Length);
            }

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string resp = reader.ReadToEnd();
                MessageBox.Show(resp);
            }
        }
        private void Delete()
        {
            HttpWebRequest request = WebRequest.Create("https://reqres.in/api/users/2") as HttpWebRequest;
            request.Method = "DELETE";
            request.ContentType = "application/x-www-form-urlencoded";
            int ID;
            ID = int.Parse(TxtIDDel.Text);
            // Metodo modificado
            string putData = "id=" + ID; byte[] byteArray = Encoding.UTF8.GetBytes(putData);
            request.ContentLength = byteArray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                using (StreamWriter stmw = new StreamWriter(dataStream))
                {
                    stmw.Write(putData);
                }
                //dataStream.Write(byteArray, 0, byteArray.Length);
            }

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string resp = reader.ReadToEnd();
                MessageBox.Show(resp);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtName_OnValueChanged(object sender, EventArgs e)
        {
            if (LblError.Visible) {//Si se ha anunciado un error entonces lo oculto
                LblError.Visible = false;
            }
        }

        private void TxtJob_OnValueChanged(object sender, EventArgs e)
        {
            if (LblError.Visible)
            {//Si se ha anunciado un error entonces lo oculto
                LblError.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread Trd = new Thread(Put);
            if (TxtJobPut.Text != "")
            {//Si los campos requeridos no están vacíos realizo el put
                Trd.Start();
            }else {//Sino lo aviso
                LblErrorPut.Visible = true;
            }
        }

        private void TxtJobPut_OnValueChanged(object sender, EventArgs e)
        {
            if (LblErrorPut.Visible) {//Si el error se muestra la oculto
                LblErrorPut.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread Trd = new Thread(Delete);
            if (TxtIDDel.Text != "")
            {//Si los campos requeridos no están vacíos realizo el put
                Trd.Start();
            }
            else
            {//Sino lo aviso
                LblErrorDel.Visible = true;
            }
            
        }

        private void TxtIDDel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)//Permito la insersión sólo de números en el textbox
            {
                e.Handled = true;
            }
        }
    }
}
