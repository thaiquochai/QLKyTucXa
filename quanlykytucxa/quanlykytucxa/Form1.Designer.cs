namespace quanlythuvien
{
    partial class frmtaomoitk
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butdau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.butlui = new System.Windows.Forms.Button();
            this.buttien = new System.Windows.Forms.Button();
            this.butcuoi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttaomoi = new System.Windows.Forms.Button();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.butxoabo = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(740, 224);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ Tên";
            this.columnHeader1.Width = 191;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Địa Chỉ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Đăng Nhập";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 195;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quyền Hạn";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 147;
            // 
            // butdau
            // 
            this.butdau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdau.Location = new System.Drawing.Point(457, 289);
            this.butdau.Name = "butdau";
            this.butdau.Size = new System.Drawing.Size(75, 35);
            this.butdau.TabIndex = 1;
            this.butdau.Text = "K";
            this.butdau.UseVisualStyleBackColor = true;
            this.butdau.Click += new System.EventHandler(this.butdau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nhân Viên :";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(171, 296);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 20);
            this.txtmanv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ Tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa Chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Đăng Nhập :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quyền hạn :";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(171, 336);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(158, 20);
            this.txthoten.TabIndex = 3;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(171, 384);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(212, 20);
            this.txtdiachi.TabIndex = 3;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(171, 448);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(158, 20);
            this.txttendangnhap.TabIndex = 3;
            // 
            // butlui
            // 
            this.butlui.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlui.Location = new System.Drawing.Point(457, 358);
            this.butlui.Name = "butlui";
            this.butlui.Size = new System.Drawing.Size(75, 35);
            this.butlui.TabIndex = 8;
            this.butlui.Text = "<";
            this.butlui.UseVisualStyleBackColor = true;
            this.butlui.Click += new System.EventHandler(this.butlui_Click);
            // 
            // buttien
            // 
            this.buttien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttien.Location = new System.Drawing.Point(457, 433);
            this.buttien.Name = "buttien";
            this.buttien.Size = new System.Drawing.Size(75, 35);
            this.buttien.TabIndex = 9;
            this.buttien.Text = ">";
            this.buttien.UseVisualStyleBackColor = true;
            this.buttien.Click += new System.EventHandler(this.buttien_Click);
            // 
            // butcuoi
            // 
            this.butcuoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcuoi.Location = new System.Drawing.Point(457, 513);
            this.butcuoi.Name = "butcuoi";
            this.butcuoi.Size = new System.Drawing.Size(75, 35);
            this.butcuoi.TabIndex = 10;
            this.butcuoi.Text = ">|";
            this.butcuoi.UseVisualStyleBackColor = true;
            this.butcuoi.Click += new System.EventHandler(this.butcuoi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NHANVIEN",
            "QUẢN LÝ",
            "GIÁM ĐỐC",
            "THU NGÂN"});
            this.comboBox1.Location = new System.Drawing.Point(171, 513);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // buttaomoi
            // 
            this.buttaomoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttaomoi.Location = new System.Drawing.Point(595, 289);
            this.buttaomoi.Name = "buttaomoi";
            this.buttaomoi.Size = new System.Drawing.Size(103, 35);
            this.buttaomoi.TabIndex = 12;
            this.buttaomoi.Text = "Tạo Mới";
            this.buttaomoi.UseVisualStyleBackColor = true;
            this.buttaomoi.Click += new System.EventHandler(this.buttaomoi_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttimkiem.Location = new System.Drawing.Point(595, 358);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(103, 35);
            this.buttimkiem.TabIndex = 13;
            this.buttimkiem.Text = "Tìm Kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // butxoabo
            // 
            this.butxoabo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butxoabo.Location = new System.Drawing.Point(595, 448);
            this.butxoabo.Name = "butxoabo";
            this.butxoabo.Size = new System.Drawing.Size(103, 35);
            this.butxoabo.TabIndex = 14;
            this.butxoabo.Text = "Xóa Bỏ";
            this.butxoabo.UseVisualStyleBackColor = true;
            this.butxoabo.Click += new System.EventHandler(this.butxoabo_Click);
            // 
            // butthoat
            // 
            this.butthoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthoat.Location = new System.Drawing.Point(595, 513);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(103, 35);
            this.butthoat.TabIndex = 15;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // frmtaomoitk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 609);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butxoabo);
            this.Controls.Add(this.buttimkiem);
            this.Controls.Add(this.buttaomoi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.butcuoi);
            this.Controls.Add(this.buttien);
            this.Controls.Add(this.butlui);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butdau);
            this.Controls.Add(this.listView1);
            this.Name = "frmtaomoitk";
            this.Text = "Tạo Mới Một Tài Khoản";
            this.Load += new System.EventHandler(this.frmtaomoitk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button butdau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.Button butlui;
        private System.Windows.Forms.Button buttien;
        private System.Windows.Forms.Button butcuoi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttaomoi;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.Button butxoabo;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

