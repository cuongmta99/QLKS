﻿namespace Qlks
{
    partial class DangNhap
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
               this.label1 = new System.Windows.Forms.Label();
               this.bt_thoat = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.txt_tk = new System.Windows.Forms.TextBox();
               this.txt_mk = new System.Windows.Forms.TextBox();
               this.bt_dn = new System.Windows.Forms.Button();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.button1 = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.DarkCyan;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.label1.Location = new System.Drawing.Point(0, 0);
               this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(418, 44);
               this.label1.TabIndex = 0;
               this.label1.Text = "Đăng Nhập Hệ Thống";
               // 
               // bt_thoat
               // 
               this.bt_thoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
               this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.bt_thoat.Location = new System.Drawing.Point(436, -1);
               this.bt_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.bt_thoat.Name = "bt_thoat";
               this.bt_thoat.Size = new System.Drawing.Size(59, 44);
               this.bt_thoat.TabIndex = 1;
               this.bt_thoat.Text = "X";
               this.bt_thoat.UseVisualStyleBackColor = false;
               this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.Black;
               this.label2.Location = new System.Drawing.Point(33, 208);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(106, 26);
               this.label2.TabIndex = 2;
               this.label2.Text = "Tài khoản";
               // 
               // txt_tk
               // 
               this.txt_tk.Location = new System.Drawing.Point(173, 212);
               this.txt_tk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txt_tk.Name = "txt_tk";
               this.txt_tk.Size = new System.Drawing.Size(286, 22);
               this.txt_tk.TabIndex = 0;
               this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
               // 
               // txt_mk
               // 
               this.txt_mk.Location = new System.Drawing.Point(173, 261);
               this.txt_mk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txt_mk.Name = "txt_mk";
               this.txt_mk.PasswordChar = '*';
               this.txt_mk.Size = new System.Drawing.Size(286, 22);
               this.txt_mk.TabIndex = 1;
               // 
               // bt_dn
               // 
               this.bt_dn.BackColor = System.Drawing.Color.DarkCyan;
               this.bt_dn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.bt_dn.ForeColor = System.Drawing.Color.Black;
               this.bt_dn.Location = new System.Drawing.Point(173, 307);
               this.bt_dn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.bt_dn.Name = "bt_dn";
               this.bt_dn.Size = new System.Drawing.Size(135, 43);
               this.bt_dn.TabIndex = 2;
               this.bt_dn.Text = "Đăng Nhập";
               this.bt_dn.UseVisualStyleBackColor = false;
               this.bt_dn.Click += new System.EventHandler(this.bt_dn_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.Color.Black;
               this.label3.Location = new System.Drawing.Point(39, 257);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(105, 26);
               this.label3.TabIndex = 2;
               this.label3.Text = "Mật Khẩu";
               // 
               // label4
               // 
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(38, 83);
               this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(422, 76);
               this.label4.TabIndex = 3;
               this.label4.Text = "QUẢN LÝ KHÁCH SẠN";
               this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.DarkCyan;
               this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.Color.Black;
               this.button1.Location = new System.Drawing.Point(317, 307);
               this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(141, 43);
               this.button1.TabIndex = 4;
               this.button1.Text = "Thoát";
               this.button1.UseVisualStyleBackColor = false;
               // 
               // DangNhap
               // 
               this.AcceptButton = this.bt_dn;
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ControlLightLight;
               this.ClientSize = new System.Drawing.Size(493, 369);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.bt_dn);
               this.Controls.Add(this.txt_mk);
               this.Controls.Add(this.txt_tk);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.bt_thoat);
               this.Controls.Add(this.label1);
               this.ForeColor = System.Drawing.Color.Red;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Location = new System.Drawing.Point(500, 0);
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "DangNhap";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "DangNhap";
               this.Load += new System.EventHandler(this.DangNhap_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Button bt_dn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}