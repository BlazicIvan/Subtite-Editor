using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
    }
}
