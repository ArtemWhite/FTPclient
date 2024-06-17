using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tBoxL.Text = @"C:\";
            tBoxR.Text = "ip";
            tBoxLogin.Text = "name";
            tBoxPass.Text = "password";
            foreach (var disk in DriveInfo.GetDrives())
                cBoxDrivers.Items.Add(disk);
            cBoxDrivers.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            lBoxL.Items.Clear();
            bool disk = false;
            foreach (var item in cBoxDrivers.Items)
                if (item.ToString() == tBoxL.Text)
                    disk = true;
            try
            {
                string[] dir = Directory.GetDirectories(tBoxL.Text);
                string[] file = Directory.GetFiles(tBoxL.Text);
                
               if(!disk)lBoxL.Items.Add("..");
                foreach (var d in dir)
                {
                    string temp = d.Replace(tBoxL.Text, "");
                    //if (temp[0] == '\\') temp = temp.Substring(1);
                    lBoxL.Items.Add(temp);
                }
                foreach (var f in file)
                    lBoxL.Items.Add(f.Replace(tBoxL.Text, ""));
            }
            catch 
            {
                if (!disk) lBoxL.Items.Add("..");
                lBoxL.Items.Add("Ошибка! Не удалось загрузить содержимое.");
            }

        }

        private void btnRConnect_Click(object sender, EventArgs e)
        {
            lBoxR.Items.Clear();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://"+tBoxR.Text);
            request.Credentials = new NetworkCredential(tBoxLogin.Text, tBoxPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            while (!sr.EndOfStream)
                lBoxR.Items.Add(sr.ReadLine());
            sr.Close();
            response.Close();
        }

        private void cBoxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxL.Text = cBoxDrivers.Text;
            btnL_Click(sender, e);

        }

        private void lBoxL_DoubleClick(object sender, EventArgs e)
        {
            if (lBoxL.SelectedItem == "..")
            {
                string path = tBoxL.Text.Substring(0, tBoxL.Text.Length-2);
                tBoxL.Text = (Directory.GetParent(path).FullName)+'\\';
                btnL_Click(sender, e);
            }
            else if (Directory.Exists(tBoxL.Text + lBoxL.SelectedItem + @"\"))
            {
                tBoxL.Text += lBoxL.SelectedItem + @"\";
                btnL_Click(sender, e);
            }
        }

        private void lBoxR_Click(object sender, EventArgs e)
        {
            lBoxL.SelectedIndex = -1;
        }

        private void lBoxL_Click(object sender, EventArgs e)
        {
            lBoxR.SelectedIndex = -1;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lBoxL.SelectedIndex == -1)
            {

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + tBoxR.Text+
                    "/"+lBoxR.SelectedItem.ToString());
                request.Credentials = new NetworkCredential(tBoxLogin.Text, tBoxPass.Text);
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();                
                response.Close();
                btnRConnect_Click(sender, e);

            }
            else if (lBoxR.SelectedIndex == -1)
            {
                FileInfo file = new FileInfo(tBoxL.Text + @"\" + lBoxL.SelectedItem.ToString());
                file.Delete();
                btnL_Click(sender, e);
            }
        }               

        private void btnNewDir_Click(object sender, EventArgs e)
        {
            if (lBoxL.SelectedIndex == -1 && lBoxR.SelectedIndex != -1)
            {//ftp
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + tBoxR.Text +
                    "/" + tBoxNew.Text);
                request.Credentials = new NetworkCredential(tBoxLogin.Text, tBoxPass.Text);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                btnRConnect_Click(sender, e);
            }
            else if (lBoxR.SelectedIndex == -1 && lBoxL.SelectedIndex != -1)
            { //pc
                Directory.CreateDirectory(tBoxL.Text + "/" + tBoxNew.Text);
                btnL_Click(sender, e);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lBoxL.SelectedIndex == -1 && lBoxR.SelectedIndex != -1)
            {//ftp
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + tBoxR.Text +
                   "/" + lBoxR.SelectedItem);
                request.Credentials = new NetworkCredential(tBoxLogin.Text, tBoxPass.Text);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream sr = response.GetResponseStream();
                FileStream fs = new FileStream(tBoxL.Text + @"\" + lBoxR.SelectedItem, FileMode.Create);
                byte[] data = new byte[128];
                int size = 0;
                while ((size = sr.Read(data, 0, data.Length)) > 0)
                {
                    fs.Write(data, 0, size);
                }

                sr.Close();
                fs.Close();
                response.Close();
                btnL_Click(sender, e);
            }
            else if (lBoxR.SelectedIndex == -1 && lBoxL.SelectedIndex != -1)
            { //pc
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + tBoxR.Text +
                     "/" + lBoxL.SelectedItem);
                request.Credentials = new NetworkCredential(tBoxLogin.Text, tBoxPass.Text);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                //FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                FileStream fs = new FileStream(tBoxL.Text + lBoxL.SelectedItem, FileMode.Open);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                //response.Close();
                fs.Close();
                Stream st = request.GetRequestStream();
                st.Write(data, 0, data.Length);
                st.Close();
                btnRConnect_Click(sender, e);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnCopy_Click(sender, e);
            btnDel_Click(sender, e);
        }
    }
}
