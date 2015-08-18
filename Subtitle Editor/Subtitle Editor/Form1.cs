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
namespace Subtitle_Editor
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            string file_name = "";
            System.IO.StreamReader Title;
            openDialog.ShowDialog();
            file_name = openDialog.FileName;
            if (file_name != "")
            {
                Title = new System.IO.StreamReader(file_name, Encoding.Default, true);
                previewBox.Text = Title.ReadToEnd();
                StatusLabel.Text = file_name;
                Title.Close();
            }
        }


        private void btn_ASCII_Click(object sender, EventArgs e)
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
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string save_location = "";
            System.IO.StreamWriter new_title;
            saveDialog.ShowDialog();
            save_location = saveDialog.FileName;
            if (save_location != "" && previewBox.Text != "")
            {
                new_title = new System.IO.StreamWriter(save_location, true, Encoding.Default);
                new_title.Write(previewBox.Text);
                new_title.Close();
            }
        }

        //public DateTime GetShift(string min, string sec)
        //{
        //    int mins,secs,mils;
        //    mins = Convert.ToInt32(min);
        //    secs = Convert.ToInt32(sec.Split(',')[0]);
        //    mils = Convert.ToInt32(sec.Split(',')[1]);
        //    DateTime shift = new DateTime(0,0, 0, 0, mins, secs, mils);
        //    return shift;
        //}

        private void shright_Click(object sender, EventArgs e)
        {
            int i = 0;
            //string pom;
            string line_pattern = "\\d\\d:\\d\\d:\\d\\d,\\d\\d\\d --> \\d\\d:\\d\\d:\\d\\d,\\d\\d\\d";
            Array lines;
            int sat1, min1, sek1, mili1, sat2, min2, sek2, mili2;


            //DateTime v1 = new DateTime();
            //DateTime v2 = new DateTime();
            //DateTime shift = GetShift(mins.Value.ToString(), secs.Value.ToString());
            //string time = shift.ToString("HH:mm:ss:fff");

            StringBuilder buffer = new StringBuilder();
            lines = previewBox.Lines.ToArray();
            foreach (string line in lines)
            {
                if (Regex.IsMatch(line, line_pattern))
                {
                    //obrada

                    ;
                }
                //buffer.Append(line);
                //buffer.Append('\n');
                i++;
            }
            previewBox.Text = buffer.ToString();
            
            //MessageBox.Show(lines.GetValue(101).ToString());
        }
        
    }
}
