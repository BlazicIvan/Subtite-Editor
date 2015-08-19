using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;

namespace Subtitle_Editor
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        void ErrorOpen()
        {
            MessageBox.Show("Otvorite titl datoteku!", "Greška");
        }

        void SaveTempFile()
        {
            StreamWriter Temp;
            Temp = new StreamWriter("Temp", true, Encoding.Default);
            Temp.Write(previewBox.Text);
            Temp.Close();
        }

        void DeleteTempFile()
        {
            if(File.Exists("Temp"))
            {
                File.Delete("Temp");
            }
        }

        void ReadTempFile()
        {
            StreamReader Temp = new StreamReader("Temp");
            previewBox.Text = Temp.ReadToEnd();
            Temp.Close();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            string file_name = "";
            StreamReader Title;
            openDialog.ShowDialog();
            file_name = openDialog.FileName;
            if (file_name != "")
            {
                Title = new StreamReader(file_name, Encoding.Default, true);             
                previewBox.Text = Title.ReadToEnd();     
                StatusLabel.Text = Path.GetFileName(file_name);
                Title.Close();
                SaveTempFile();
                previewBox.Enabled = true;
            }
        }


        private void btn_ASCII_Click(object sender, EventArgs e)
        {
            if (previewBox.Enabled == true)
            {
                string text = previewBox.Text;

                text = text.Replace('š', 's');
                text = text.Replace('Š', 'S');

                text = text.Replace("Đ", "Dj");
                text = text.Replace("đ", "dj");

                text = text.Replace('Č', 'C');
                text = text.Replace('č', 'c');

                text = text.Replace('Ć', 'C');
                text = text.Replace('ć', 'c');

                text = text.Replace('Ž', 'Z');
                text = text.Replace('ž', 'z');

                previewBox.Text = text;
                SaveTempFile();
            }
            else
                ErrorOpen();
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (previewBox.Enabled == true)
            {
                string save_location = "";
                saveDialog.ShowDialog();
                save_location = saveDialog.FileName;
                if (save_location != "" && previewBox.Text != "")
                {
                    File.Copy("Temp", save_location);
                }
            }
            else
                ErrorOpen();
        }

        private void shift(char direction)
        {
            string output = "";
            if (direction == 'r')
                output += '+';
            else
                output += '-';
            decimal mins, secs, milsecs;
            string file_name = "temp";
            mins = mins_btn.Value;
            secs = secs_btn.Value;
            milsecs = msecs_btn.Value;
            secs += mins * 60;
            output += secs.ToString() + "." + milsecs.ToString() + " " + file_name;
            ProcessStartInfo shifter = new ProcessStartInfo("Shifter", output);
            Process.Start(shifter);
        }

        private void shright_Click(object sender, EventArgs e)
        {
            if (previewBox.Enabled == true)
            {
                shift('r');
                ReadTempFile();
            }
            else
                ErrorOpen();
        }

        private void shleft_Click(object sender, EventArgs e)
        {
            if (previewBox.Enabled == true)
            {
                shift('l');
                ReadTempFile();
            }
            else
                ErrorOpen();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteTempFile();
        }
        
    }
}
