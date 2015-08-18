namespace Subtitle_Editor
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.previewBox = new System.Windows.Forms.RichTextBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_ASCII = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.Transparent;
            this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Open.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btn_Open.FlatAppearance.BorderSize = 0;
            this.btn_Open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Open.Location = new System.Drawing.Point(276, 12);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(154, 37);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Otvori titl";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Save.Location = new System.Drawing.Point(276, 55);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(154, 37);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Sačuvaj kopiju";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Subtitle_Editor.Properties.Resources._01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.previewBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 215);
            this.panel1.TabIndex = 3;
            // 
            // previewBox
            // 
            this.previewBox.BackColor = System.Drawing.Color.White;
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.previewBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previewBox.Location = new System.Drawing.Point(3, 3);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(252, 209);
            this.previewBox.TabIndex = 0;
            this.previewBox.Text = "";
            // 
            // openDialog
            // 
            this.openDialog.AddExtension = false;
            this.openDialog.DefaultExt = "Subtitle Files (*.sub;*.srt)|*.sub;*.srt|All files (*.*)|*.*";
            this.openDialog.Filter = "Subtitle Files (*.sub;*.srt)|*.sub;*.srt|Text files (*.txt)|*.txt|All files (*.*)" +
    "|*.*";
            // 
            // btn_ASCII
            // 
            this.btn_ASCII.BackColor = System.Drawing.Color.Transparent;
            this.btn_ASCII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ASCII.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btn_ASCII.FlatAppearance.BorderSize = 0;
            this.btn_ASCII.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_ASCII.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_ASCII.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ASCII.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ASCII.Location = new System.Drawing.Point(6, 19);
            this.btn_ASCII.Name = "btn_ASCII";
            this.btn_ASCII.Size = new System.Drawing.Size(142, 37);
            this.btn_ASCII.TabIndex = 4;
            this.btn_ASCII.Text = "ASCII Tekst";
            this.btn_ASCII.UseVisualStyleBackColor = false;
            this.btn_ASCII.Click += new System.EventHandler(this.btn_ASCII_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 236);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(203, 15);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Dobrodošli u subtitle editor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ASCII);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(276, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obrada";
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "Subtitle Files (*.sub;*.srt)|*.sub;*.srt|All files (*.*)|*.*";
            this.saveDialog.Filter = "Subtitle Files (*.sub;*.srt)|*.sub;*.srt|Text files (*.txt)|*.txt|All files (*.*)" +
    "|*.*";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(442, 260);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Subtitle Editor";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox previewBox;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Button btn_ASCII;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveDialog;
    }
}

