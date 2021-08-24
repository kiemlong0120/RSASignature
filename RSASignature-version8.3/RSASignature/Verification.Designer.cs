﻿
namespace RSASignature
{
    partial class Verification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verification));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddFileZip = new System.Windows.Forms.Button();
            this.btXacThuc = new System.Windows.Forms.Button();
            this.tbDuongDanChuKyDcGiaMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportPKey = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.tbDuongDanChuKy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btImportChuKy = new System.Windows.Forms.Button();
            this.btImportFile2 = new System.Windows.Forms.Button();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuyTrinhTạoChuKy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThongTinDoAn = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAddFileZip);
            this.panel1.Controls.Add(this.btXacThuc);
            this.panel1.Controls.Add(this.tbDuongDanChuKyDcGiaMa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnImportPKey);
            this.panel1.Controls.Add(this.btReset);
            this.panel1.Controls.Add(this.tbDuongDanChuKy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btImportChuKy);
            this.panel1.Controls.Add(this.btImportFile2);
            this.panel1.Controls.Add(this.tbPublicKey);
            this.panel1.Controls.Add(this.tbInput2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Location = new System.Drawing.Point(21, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 336);
            this.panel1.TabIndex = 3;
            // 
            // btnAddFileZip
            // 
            this.btnAddFileZip.Location = new System.Drawing.Point(363, 235);
            this.btnAddFileZip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFileZip.Name = "btnAddFileZip";
            this.btnAddFileZip.Size = new System.Drawing.Size(97, 83);
            this.btnAddFileZip.TabIndex = 20;
            this.btnAddFileZip.Text = "AddFileZip";
            this.btnAddFileZip.UseVisualStyleBackColor = true;
            this.btnAddFileZip.Click += new System.EventHandler(this.btnAddFileZip_Click);
            // 
            // btXacThuc
            // 
            this.btXacThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXacThuc.Location = new System.Drawing.Point(165, 228);
            this.btXacThuc.Name = "btXacThuc";
            this.btXacThuc.Size = new System.Drawing.Size(152, 39);
            this.btXacThuc.TabIndex = 19;
            this.btXacThuc.Text = "Vertification";
            this.btXacThuc.UseVisualStyleBackColor = true;
            this.btXacThuc.Click += new System.EventHandler(this.btXacThuc_Click);
            // 
            // tbDuongDanChuKyDcGiaMa
            // 
            this.tbDuongDanChuKyDcGiaMa.Location = new System.Drawing.Point(183, 189);
            this.tbDuongDanChuKyDcGiaMa.Name = "tbDuongDanChuKyDcGiaMa";
            this.tbDuongDanChuKyDcGiaMa.Size = new System.Drawing.Size(277, 27);
            this.tbDuongDanChuKyDcGiaMa.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Decrypted signature";
            // 
            // btnImportPKey
            // 
            this.btnImportPKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportPKey.Location = new System.Drawing.Point(366, 41);
            this.btnImportPKey.Name = "btnImportPKey";
            this.btnImportPKey.Size = new System.Drawing.Size(94, 29);
            this.btnImportPKey.TabIndex = 16;
            this.btnImportPKey.Text = "Import";
            this.btnImportPKey.UseVisualStyleBackColor = true;
            this.btnImportPKey.Click += new System.EventHandler(this.btnImportPKey_Click);
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btReset.Location = new System.Drawing.Point(165, 280);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(152, 37);
            this.btReset.TabIndex = 15;
            this.btReset.Text = "RESET FORM";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // tbDuongDanChuKy
            // 
            this.tbDuongDanChuKy.Location = new System.Drawing.Point(102, 144);
            this.tbDuongDanChuKy.Name = "tbDuongDanChuKy";
            this.tbDuongDanChuKy.Size = new System.Drawing.Size(249, 27);
            this.tbDuongDanChuKy.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Signature";
            // 
            // btImportChuKy
            // 
            this.btImportChuKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImportChuKy.Location = new System.Drawing.Point(363, 144);
            this.btImportChuKy.Name = "btImportChuKy";
            this.btImportChuKy.Size = new System.Drawing.Size(97, 29);
            this.btImportChuKy.TabIndex = 13;
            this.btImportChuKy.Text = "Import";
            this.btImportChuKy.UseVisualStyleBackColor = true;
            this.btImportChuKy.Click += new System.EventHandler(this.btImportChuKy_Click);
            // 
            // btImportFile2
            // 
            this.btImportFile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImportFile2.Location = new System.Drawing.Point(366, 95);
            this.btImportFile2.Name = "btImportFile2";
            this.btImportFile2.Size = new System.Drawing.Size(94, 29);
            this.btImportFile2.TabIndex = 7;
            this.btImportFile2.Text = "Import";
            this.btImportFile2.UseVisualStyleBackColor = true;
            this.btImportFile2.Click += new System.EventHandler(this.btImportFile2_Click);
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Location = new System.Drawing.Point(25, 41);
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.Size = new System.Drawing.Size(329, 27);
            this.tbPublicKey.TabIndex = 12;
            // 
            // tbInput2
            // 
            this.tbInput2.Location = new System.Drawing.Point(78, 97);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(275, 27);
            this.tbInput2.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pubilc key";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(13, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(101, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "VERIFICATION";
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
            this.menu.TabIndex = 19;
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
            // Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 460);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Verification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Verification_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox tbDuongDanChuKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btImportChuKy;
        private System.Windows.Forms.Button btImportFile2;
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuQuyTrinhTạoChuKy;
        private System.Windows.Forms.ToolStripMenuItem MenuThongTinDoAn;
        private System.Windows.Forms.Button btXacThuc;
        private System.Windows.Forms.TextBox tbDuongDanChuKyDcGiaMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportPKey;
        private System.Windows.Forms.Button btnAddFileZip;
    }
}