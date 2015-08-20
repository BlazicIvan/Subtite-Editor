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
            this.label4 = new System.Windows.Forms.Label();
            this.msecs_btn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shright = new System.Windows.Forms.Button();
            this.shleft = new System.Windows.Forms.Button();
            this.secs_btn = new System.Windows.Forms.NumericUpDown();
            this.mins_btn = new System.Windows.Forms.NumericUpDown();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msecs_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secs_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mins_btn)).BeginInit();
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
            this.btn_Open.Location = new System.Drawing.Point(293, 12);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(201, 37);
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
            this.btn_Save.Location = new System.Drawing.Point(293, 55);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(201, 37);
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
            this.panel1.Size = new System.Drawing.Size(258, 266);
            this.panel1.TabIndex = 3;
            // 
            // previewBox
            // 
            this.previewBox.BackColor = System.Drawing.Color.White;
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.previewBox.DetectUrls = false;
            this.previewBox.Enabled = false;
            this.previewBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previewBox.Location = new System.Drawing.Point(3, 3);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(252, 260);
            this.previewBox.TabIndex = 0;
            this.previewBox.Text = "";
            // 
            // openDialog
            // 
            this.openDialog.AddExtension = false;
            this.openDialog.DefaultExt = "Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*";
            this.openDialog.Filter = "Subtitle Files (*.srt)|*.srt|Text files (*.txt)|*.txt|All files (*.*)|*.*";
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
            this.btn_ASCII.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ASCII.Location = new System.Drawing.Point(17, 21);
            this.btn_ASCII.Name = "btn_ASCII";
            this.btn_ASCII.Size = new System.Drawing.Size(201, 37);
            this.btn_ASCII.TabIndex = 4;
            this.btn_ASCII.Text = "Bez [š,đ,č,ć,ž]";
            this.btn_ASCII.UseVisualStyleBackColor = false;
            this.btn_ASCII.Click += new System.EventHandler(this.btn_ASCII_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 290);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(210, 15);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Dobrodošli u subtitle editor.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.msecs_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shright);
            this.groupBox1.Controls.Add(this.shleft);
            this.groupBox1.Controls.Add(this.secs_btn);
            this.groupBox1.Controls.Add(this.mins_btn);
            this.groupBox1.Controls.Add(this.btn_ASCII);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(276, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "milisec";
            // 
            // msecs_btn
            // 
            this.msecs_btn.Location = new System.Drawing.Point(138, 127);
            this.msecs_btn.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.msecs_btn.Name = "msecs_btn";
            this.msecs_btn.Size = new System.Drawing.Size(36, 22);
            this.msecs_btn.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "sec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pomeranje vremena";
            // 
            // shright
            // 
            this.shright.BackColor = System.Drawing.Color.Transparent;
            this.shright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shright.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.shright.FlatAppearance.BorderSize = 0;
            this.shright.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.shright.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.shright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shright.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shright.Location = new System.Drawing.Point(173, 118);
            this.shright.Name = "shright";
            this.shright.Size = new System.Drawing.Size(45, 33);
            this.shright.TabIndex = 8;
            this.shright.Text = ">>";
            this.shright.UseVisualStyleBackColor = false;
            this.shright.Click += new System.EventHandler(this.shright_Click);
            // 
            // shleft
            // 
            this.shleft.BackColor = System.Drawing.Color.Transparent;
            this.shleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shleft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shleft.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.shleft.FlatAppearance.BorderSize = 0;
            this.shleft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.shleft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.shleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shleft.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shleft.Location = new System.Drawing.Point(8, 118);
            this.shleft.Name = "shleft";
            this.shleft.Size = new System.Drawing.Size(44, 33);
            this.shleft.TabIndex = 7;
            this.shleft.Text = "<<";
            this.shleft.UseVisualStyleBackColor = false;
            this.shleft.Click += new System.EventHandler(this.shleft_Click);
            // 
            // secs_btn
            // 
            this.secs_btn.Location = new System.Drawing.Point(96, 127);
            this.secs_btn.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secs_btn.Name = "secs_btn";
            this.secs_btn.Size = new System.Drawing.Size(36, 22);
            this.secs_btn.TabIndex = 7;
            // 
            // mins_btn
            // 
            this.mins_btn.Location = new System.Drawing.Point(58, 127);
            this.mins_btn.Name = "mins_btn";
            this.mins_btn.Size = new System.Drawing.Size(35, 22);
            this.mins_btn.TabIndex = 6;
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*";
            this.saveDialog.Filter = "Subtitle Files (*.srt)|*.srt|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(517, 314);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainForm_DragEnter);
            this.DragLeave += new System.EventHandler(this.mainForm_DragLeave);
            this.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msecs_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secs_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mins_btn)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shright;
        private System.Windows.Forms.Button shleft;
        private System.Windows.Forms.NumericUpDown secs_btn;
        private System.Windows.Forms.NumericUpDown mins_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown msecs_btn;
    }
}

