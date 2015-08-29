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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_ASCII = new System.Windows.Forms.Button();
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
            this.toolTip_Slow = new System.Windows.Forms.ToolTip(this.components);
            this.btn_About = new System.Windows.Forms.Button();
            this.previewBox = new System.Windows.Forms.RichTextBox();
            this.toolTip_Fast = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msecs_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secs_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mins_btn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.Transparent;
            this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Open.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Open.FlatAppearance.BorderSize = 0;
            this.btn_Open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Open.Location = new System.Drawing.Point(284, 12);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(251, 37);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Otvori titl";
            this.toolTip_Slow.SetToolTip(this.btn_Open, "Otvaranje datoteke sa prevodom.");
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Save.Location = new System.Drawing.Point(284, 53);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(251, 37);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Sačuvaj kopiju";
            this.toolTip_Slow.SetToolTip(this.btn_Save, "Čuvanje prevoda prikazanog sa leve strane u datoteku.");
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // openDialog
            // 
            this.openDialog.AddExtension = false;
            this.openDialog.DefaultExt = "Subtitle Files (*.srt)|*.srt";
            this.openDialog.Filter = "Subtitle Files (*.srt)|*.srt";
            // 
            // btn_ASCII
            // 
            this.btn_ASCII.BackColor = System.Drawing.Color.Transparent;
            this.btn_ASCII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ASCII.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_ASCII.FlatAppearance.BorderSize = 0;
            this.btn_ASCII.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn_ASCII.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ASCII.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ASCII.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ASCII.Location = new System.Drawing.Point(8, 24);
            this.btn_ASCII.Name = "btn_ASCII";
            this.btn_ASCII.Size = new System.Drawing.Size(235, 37);
            this.btn_ASCII.TabIndex = 4;
            this.btn_ASCII.Text = "Bez [Š,Đ,Č,Ć,Ž]";
            this.toolTip_Fast.SetToolTip(this.btn_ASCII, "Sve pojave slova Š, Đ, Č, Ć i Ž se zamenjuju sa S, DJ, C, C, i Z.");
            this.btn_ASCII.UseVisualStyleBackColor = false;
            this.btn_ASCII.Click += new System.EventHandler(this.btn_ASCII_Click);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(284, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "milisek";
            this.toolTip_Fast.SetToolTip(this.label4, "Milisekunde");
            // 
            // msecs_btn
            // 
            this.msecs_btn.Location = new System.Drawing.Point(139, 99);
            this.msecs_btn.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.msecs_btn.Name = "msecs_btn";
            this.msecs_btn.Size = new System.Drawing.Size(48, 25);
            this.msecs_btn.TabIndex = 11;
            this.toolTip_Slow.SetToolTip(this.msecs_btn, "Milisekunde");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "sek";
            this.toolTip_Fast.SetToolTip(this.label3, "Sekunde");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "min";
            this.toolTip_Fast.SetToolTip(this.label2, "Minuti");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pomeranje vremena";
            this.toolTip_Fast.SetToolTip(this.label1, "Prevod se podešava vremenski\r\npomeranjem za zadato vreme\r\nu napred (dugme desno)\r" +
        "\nili unazad (dugme levo)");
            // 
            // shright
            // 
            this.shright.BackColor = System.Drawing.Color.Transparent;
            this.shright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shright.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.shright.FlatAppearance.BorderSize = 0;
            this.shright.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.shright.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.shright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shright.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shright.Location = new System.Drawing.Point(193, 95);
            this.shright.Name = "shright";
            this.shright.Size = new System.Drawing.Size(45, 33);
            this.shright.TabIndex = 8;
            this.shright.Text = ">>";
            this.toolTip_Fast.SetToolTip(this.shright, "Prevod se podešava vremenski\r\npomeranjem za zadato vreme\r\nu napred.");
            this.shright.UseVisualStyleBackColor = false;
            this.shright.Click += new System.EventHandler(this.shright_Click);
            // 
            // shleft
            // 
            this.shleft.BackColor = System.Drawing.Color.Transparent;
            this.shleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shleft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shleft.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.shleft.FlatAppearance.BorderSize = 0;
            this.shleft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.shleft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.shleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shleft.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shleft.Location = new System.Drawing.Point(10, 95);
            this.shleft.Name = "shleft";
            this.shleft.Size = new System.Drawing.Size(44, 33);
            this.shleft.TabIndex = 7;
            this.shleft.Text = "<<";
            this.toolTip_Fast.SetToolTip(this.shleft, "Prevod se podešava vremenski\r\npomeranjem za zadato vreme\r\nunazad.");
            this.shleft.UseVisualStyleBackColor = false;
            this.shleft.Click += new System.EventHandler(this.shleft_Click);
            // 
            // secs_btn
            // 
            this.secs_btn.Location = new System.Drawing.Point(98, 99);
            this.secs_btn.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secs_btn.Name = "secs_btn";
            this.secs_btn.Size = new System.Drawing.Size(36, 25);
            this.secs_btn.TabIndex = 5;
            this.toolTip_Slow.SetToolTip(this.secs_btn, "Sekunde");
            // 
            // mins_btn
            // 
            this.mins_btn.Location = new System.Drawing.Point(60, 99);
            this.mins_btn.Name = "mins_btn";
            this.mins_btn.Size = new System.Drawing.Size(35, 25);
            this.mins_btn.TabIndex = 4;
            this.toolTip_Slow.SetToolTip(this.mins_btn, "Minuti");
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*";
            this.saveDialog.Filter = "Subtitle Files (*.srt)|*.srt|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // toolTip_Slow
            // 
            this.toolTip_Slow.AutoPopDelay = 5000;
            this.toolTip_Slow.BackColor = System.Drawing.Color.White;
            this.toolTip_Slow.InitialDelay = 3000;
            this.toolTip_Slow.IsBalloon = true;
            this.toolTip_Slow.ReshowDelay = 100;
            this.toolTip_Slow.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_Slow.ToolTipTitle = "Pomoć";
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.Transparent;
            this.btn_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_About.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn_About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_About.Location = new System.Drawing.Point(284, 94);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(251, 37);
            this.btn_About.TabIndex = 3;
            this.btn_About.Text = "O programu";
            this.toolTip_Slow.SetToolTip(this.btn_About, "Informacije oo programu.");
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
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
            this.previewBox.Size = new System.Drawing.Size(252, 270);
            this.previewBox.TabIndex = 0;
            this.previewBox.Text = "";
            this.toolTip_Slow.SetToolTip(this.previewBox, "Prikaz izmena u prevodu.");
            // 
            // toolTip_Fast
            // 
            this.toolTip_Fast.AutoPopDelay = 5000;
            this.toolTip_Fast.BackColor = System.Drawing.Color.White;
            this.toolTip_Fast.InitialDelay = 1250;
            this.toolTip_Fast.IsBalloon = true;
            this.toolTip_Fast.ReshowDelay = 100;
            this.toolTip_Fast.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_Fast.ToolTipTitle = "Pomoć";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(471, 294);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Pomoć";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.Location = new System.Drawing.Point(9, 295);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(210, 15);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Dobrodošli u subtitle editor.";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Subtitle_Editor.Properties.Resources._01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.previewBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 276);
            this.panel1.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(545, 319);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.checkBox1);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainForm_DragEnter);
            this.DragLeave += new System.EventHandler(this.mainForm_DragLeave);
            this.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msecs_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secs_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mins_btn)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolTip toolTip_Slow;
        private System.Windows.Forms.ToolTip toolTip_Fast;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button btn_About;
    }
}

