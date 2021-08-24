
namespace RSASignature
{
    partial class CreateForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoVertification = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.tbChuKy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btTaoChuKy = new System.Windows.Forms.Button();
            this.comboBoxLengKey = new System.Windows.Forms.ComboBox();
            this.btBam = new System.Windows.Forms.Button();
            this.btTaoKhoa = new System.Windows.Forms.Button();
            this.btImportFile1 = new System.Windows.Forms.Button();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.tbKetQuaBam1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuyTrinhTạoChuKy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThongTinDoAn = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(169, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.GoVertification);
            this.panel1.Controls.Add(this.btReset);
            this.panel1.Controls.Add(this.tbChuKy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btTaoChuKy);
            this.panel1.Controls.Add(this.comboBoxLengKey);
            this.panel1.Controls.Add(this.btBam);
            this.panel1.Controls.Add(this.btTaoKhoa);
            this.panel1.Controls.Add(this.btImportFile1);
            this.panel1.Controls.Add(this.tbPublicKey);
            this.panel1.Controls.Add(this.tbInput1);
            this.panel1.Controls.Add(this.tbKetQuaBam1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.tbPrivateKey);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(22, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 415);
            this.panel1.TabIndex = 1;
            // 
            // GoVertification
            // 
            this.GoVertification.Location = new System.Drawing.Point(346, 372);
            this.GoVertification.Name = "GoVertification";
            this.GoVertification.Size = new System.Drawing.Size(131, 29);
            this.GoVertification.TabIndex = 16;
            this.GoVertification.Text = "Go to vertification";
            this.GoVertification.UseVisualStyleBackColor = true;
            this.GoVertification.Click += new System.EventHandler(this.button1_Click);
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btReset.Location = new System.Drawing.Point(166, 364);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(152, 37);
            this.btReset.TabIndex = 15;
            this.btReset.Text = "RESET FORM";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // tbChuKy
            // 
            this.tbChuKy.Location = new System.Drawing.Point(112, 322);
            this.tbChuKy.Name = "tbChuKy";
            this.tbChuKy.Size = new System.Drawing.Size(349, 27);
            this.tbChuKy.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Choose key size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Signature";
            // 
            // btTaoChuKy
            // 
            this.btTaoChuKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTaoChuKy.Location = new System.Drawing.Point(142, 277);
            this.btTaoChuKy.Name = "btTaoChuKy";
            this.btTaoChuKy.Size = new System.Drawing.Size(170, 29);
            this.btTaoChuKy.TabIndex = 13;
            this.btTaoChuKy.Text = "Create digital signature";
            this.btTaoChuKy.UseVisualStyleBackColor = true;
            this.btTaoChuKy.Click += new System.EventHandler(this.btTaoChuKy_Click);
            // 
            // comboBoxLengKey
            // 
            this.comboBoxLengKey.FormattingEnabled = true;
            this.comboBoxLengKey.Location = new System.Drawing.Point(155, 17);
            this.comboBoxLengKey.Name = "comboBoxLengKey";
            this.comboBoxLengKey.Size = new System.Drawing.Size(116, 28);
            this.comboBoxLengKey.TabIndex = 14;
            // 
            // btBam
            // 
            this.btBam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBam.Location = new System.Drawing.Point(188, 189);
            this.btBam.Name = "btBam";
            this.btBam.Size = new System.Drawing.Size(94, 29);
            this.btBam.TabIndex = 8;
            this.btBam.Text = "Hash";
            this.btBam.UseVisualStyleBackColor = true;
            this.btBam.Click += new System.EventHandler(this.btBam_Click);
            // 
            // btTaoKhoa
            // 
            this.btTaoKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTaoKhoa.Location = new System.Drawing.Point(288, 16);
            this.btTaoKhoa.Name = "btTaoKhoa";
            this.btTaoKhoa.Size = new System.Drawing.Size(173, 29);
            this.btTaoKhoa.TabIndex = 13;
            this.btTaoKhoa.Text = "Start generating keys";
            this.btTaoKhoa.UseVisualStyleBackColor = true;
            this.btTaoKhoa.Click += new System.EventHandler(this.btTaoKhoa_Click);
            // 
            // btImportFile1
            // 
            this.btImportFile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImportFile1.Location = new System.Drawing.Point(367, 148);
            this.btImportFile1.Name = "btImportFile1";
            this.btImportFile1.Size = new System.Drawing.Size(94, 29);
            this.btImportFile1.TabIndex = 7;
            this.btImportFile1.Text = "Import";
            this.btImportFile1.UseVisualStyleBackColor = true;
            this.btImportFile1.Click += new System.EventHandler(this.btImportFile1_Click);
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Location = new System.Drawing.Point(123, 101);
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.Size = new System.Drawing.Size(338, 27);
            this.tbPublicKey.TabIndex = 12;
            // 
            // tbInput1
            // 
            this.tbInput1.Location = new System.Drawing.Point(79, 149);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(281, 27);
            this.tbInput1.TabIndex = 2;
            // 
            // tbKetQuaBam1
            // 
            this.tbKetQuaBam1.Location = new System.Drawing.Point(124, 231);
            this.tbKetQuaBam1.Name = "tbKetQuaBam1";
            this.tbKetQuaBam1.Size = new System.Drawing.Size(337, 27);
            this.tbKetQuaBam1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pubilc key";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(21, 151);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "Input";
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.Location = new System.Drawing.Point(123, 64);
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.Size = new System.Drawing.Size(338, 27);
            this.tbPrivateKey.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(23, 232);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "Hash value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Private key";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(538, 30);
            this.menu.TabIndex = 16;
            this.menu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuQuyTrinhTạoChuKy,
            this.MenuThongTinDoAn});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // MenuQuyTrinhTạoChuKy
            // 
            this.MenuQuyTrinhTạoChuKy.Name = "MenuQuyTrinhTạoChuKy";
            this.MenuQuyTrinhTạoChuKy.Size = new System.Drawing.Size(243, 26);
            this.MenuQuyTrinhTạoChuKy.Text = "Quy trình tạo chữ ký số";
            this.MenuQuyTrinhTạoChuKy.Click += new System.EventHandler(this.MenuQuyTrinhTạoChuKy_Click);
            // 
            // MenuThongTinDoAn
            // 
            this.MenuThongTinDoAn.Name = "MenuThongTinDoAn";
            this.MenuThongTinDoAn.Size = new System.Drawing.Size(243, 26);
            this.MenuThongTinDoAn.Text = "Thông tin đồ án";
            this.MenuThongTinDoAn.Click += new System.EventHandler(this.MenuThongTinDoAn_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrivateKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btTaoKhoa;
        private System.Windows.Forms.Button btTaoChuKy;
        private System.Windows.Forms.TextBox tbKetQuaBam1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btImportFile1;
        private System.Windows.Forms.Button btBam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLengKey;
        private System.Windows.Forms.TextBox tbChuKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuQuyTrinhTạoChuKy;
        
        private System.Windows.Forms.ToolStripMenuItem MenuThongTinDoAn;
        private System.Windows.Forms.Button GoVertification;
    }
}

