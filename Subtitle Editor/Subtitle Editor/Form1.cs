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

        void showError(string text)
        {
            MessageBox.Show(text, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void ErrorOpen()
        {
            showError("Otvorite titl datoteku!");
        }

        void askSave()
        {
            if (previewBox.Enabled)
            {
                DialogResult ask = MessageBox.Show("Da li želite da sačuvate izmene?", "Subtitle Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    btn_Save.PerformClick();
                }
            }
        }

        void SaveTempFile()
        {
            DeleteTempFile();
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
            StreamReader Temp = new StreamReader("Temp",Encoding.Default);
            previewBox.Text = Temp.ReadToEnd();
            Temp.Close();
        }

        void Open(string file_name)
        {
            StreamReader Title;
            string tipFajla;
            if (file_name != "")
            {
                Title = new StreamReader(file_name, Encoding.Default, true);
                StatusLabel.Text = Path.GetFileName(file_name);
                tipFajla = Path.GetExtension(file_name);
                if (tipFajla == ".srt")
                {
                    previewBox.Text = Title.ReadToEnd();
                    SaveTempFile();
                    Title.Close();
                    previewBox.Enabled = true;
                }
                else
                {
                    previewBox.Text = "";
                    previewBox.Enabled = false;
                    StatusLabel.Text = "Otvorite datoteku ili je prevucite u prozor.";
                    showError("Nepravilan format titla, pokušajte ponovo!");
                    
                }
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            askSave();
            openDialog.ShowDialog();
            Open(openDialog.FileName);
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
                    SaveTempFile();
                    File.Copy("Temp", save_location,true);
                }
            }
            else
                ErrorOpen();
        }

        private void shift(char direction)
        {
            string output = "";
            string msc = "";
            if (direction == 'r')
                output += '+';
            else
                output += '-';
            decimal mins, secs, milsecs;
            string file_name = "Temp";
            mins = mins_btn.Value;
            secs = secs_btn.Value;
            milsecs = msecs_btn.Value;
            secs += mins * 60;
            if (milsecs < 10)
                msc += "0";
            if (milsecs < 100)
                msc += "0";
            msc += milsecs.ToString();
            output += secs.ToString() + "." + msc + " " + file_name;
            ProcessStartInfo shifter = new ProcessStartInfo("Shifter", output);
            Process.Start(shifter);
            for (int i = 0; i < 100000000; i++);
            ReadTempFile();
        }

        private void shright_Click(object sender, EventArgs e)
        {
            if (previewBox.Enabled == true)
            {
                shift('r');
            }
            else
                ErrorOpen();
        }

        private void shleft_Click(object sender, EventArgs e)
        {
            if (previewBox.Enabled == true)
            {
                shift('l');
            }
            else
                ErrorOpen();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteTempFile();
        }

        private void mainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            this.Opacity = 0.75;
        }

        private void mainForm_MouseEnter(object sender, EventArgs e)
        {
            if (previewBox.Enabled == false)
            {
                StatusLabel.Text = "Otvorite datoteku ili je prevucite u prozor.";
            }
        }

        private void mainForm_DragDrop(object sender, DragEventArgs e)
        {
            this.Opacity = 1;
            askSave();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                Open(filePaths[0]);
            }
        }

        private void mainForm_DragLeave(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            toolTip_Fast.Active = checkBox1.Checked;
            toolTip_Slow.Active = checkBox1.Checked;
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            Form_About Frm = new Form_About();
            Frm.ShowDialog();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            askSave();
        }

    }
}
