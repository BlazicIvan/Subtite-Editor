using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;

namespace Subtitle_Editor
{
    public partial class mainForm : Form
    {
        string FileName;
        bool IsSaved = true;

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
            if (previewBox.Enabled && IsSaved == false)
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
            if (File.Exists("Temp"))
            {
                StreamReader Temp = new StreamReader("Temp", Encoding.Default, true);
                previewBox.Text = Temp.ReadToEnd();
                Temp.Close();
            }
        }

        void Open(string file_name)
        {
            askSave();
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
                    //SaveTempFile();
                    Title.Close();
                    previewBox.Enabled = true;
                    IsSaved = true;
                    FileName = file_name;
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
                IsSaved = false;
                //SaveTempFile();
            }
            else
                ErrorOpen();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (previewBox.Enabled == true)
            {
                string save_location = "";
                saveDialog.FileName = FileName;
                saveDialog.ShowDialog();
                save_location = saveDialog.FileName;
                if (save_location != "" && previewBox.Text != "")
                {
                    SaveTempFile();
                    File.Copy("Temp", save_location,true);
                    DeleteTempFile();
                    IsSaved = true;
                }
            }
            else
                ErrorOpen();
        }

        private void ShiftSubtitle(string TimeDisp)
        {
            string str = previewBox.Text;
            string[] lines = str.Split('\n');
            try
            {
                double disp = Convert.ToDouble(TimeDisp);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Length >= 29 && lines[i].Contains("-->"))
                    {
                        string l = lines[i];
                        l = l.Replace(" --> ", ":");
                       // l = l.Replace(",", ".");
                        string[] parts = l.Split(':');
                        int h1, m1, s1, ms1, h2, m2, s2, ms2;
                        double NewTime1 = 0, NewTime2 = 0;
                        NewTime1 = Convert.ToDouble(parts[0]);
                        NewTime1 = NewTime1 * 60 + Convert.ToDouble(parts[1]);
                        NewTime1 = NewTime1 * 60 + Convert.ToDouble(parts[2]);
                        NewTime2 = Convert.ToDouble(parts[3]);
                        NewTime2 = NewTime2 * 60 + Convert.ToDouble(parts[4]);
                        NewTime2 = NewTime2 * 60 + Convert.ToDouble(parts[5]);
                        NewTime1 += disp;
                        NewTime2 += disp;

                        if (NewTime1 < 0)
                            NewTime1 = 0;

                        if (NewTime2 < 0)
                            NewTime2 = 0;

                        h1 = (int)(Math.Floor(NewTime1) / 3600);
                        h2 = (int)(Math.Floor(NewTime2) / 3600);
                        m1 = (int)(Math.Floor(NewTime1 - 3600 * h1) / 60);
                        m2 = (int)(Math.Floor(NewTime2 - 3600 * h2) / 60);
                        NewTime1 = NewTime1 - 3600 * h1 - 60 * m1;
                        NewTime2 = NewTime2 - 3600 * h2 - 60 * m2;
                        s1 = (int)Math.Floor(NewTime1);
                        s2 = (int)Math.Floor(NewTime2);
                        ms1 = (int)Math.Round(1000 * (NewTime1 - Math.Floor(NewTime1)));
                        ms2 = (int)Math.Round(1000 * (NewTime2 - Math.Floor(NewTime2)));

                        l = String.Format("{0:D2}:{1:D2}:{2:D2},{3:D3} --> {4:D2}:{5:D2}:{6:D2},{7:D3}", h1, m1, s1, ms1, h2, m2, s2, ms2);
                        lines[i] = l;
                    }
                }
            }
            catch (Exception e) { }

            /*
            DeleteTempFile();
            StreamWriter Temp;
            Temp = new StreamWriter("Temp", true, Encoding.UTF8);
            foreach (string l in lines)
                Temp.Write(l + "\n");
            Temp.Close();
            */

            StringBuilder sb = new StringBuilder();
            foreach (string l in lines)
                sb.Append(l + "\n");
            previewBox.Text = Convert.ToString(sb);

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
            //string file_name = "Temp";
            mins = mins_btn.Value;
            secs = secs_btn.Value;
            milsecs = msecs_btn.Value;
            secs += mins * 60;
            if (milsecs < 10)
                msc += "0";
            if (milsecs < 100)
                msc += "0";
            msc += milsecs.ToString();
            // output += secs.ToString() + "." + msc + " " + file_name;

            output += secs.ToString() + "," + msc;

            /*
            ProcessStartInfo shifter = new ProcessStartInfo("Shifter", output);
            Process.Start(shifter);
            for (int i = 0; i < 100000000; i++);
            */

            ShiftSubtitle(output);

            IsSaved = false;

            //ReadTempFile();
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
