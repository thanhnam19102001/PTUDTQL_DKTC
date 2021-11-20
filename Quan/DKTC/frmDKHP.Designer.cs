namespace DKTC
{
    partial class frmDKHP
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
            this.txtTENMON = new System.Windows.Forms.TextBox();
            this.txtMALHP = new System.Windows.Forms.TextBox();
            this.txtSOTC = new System.Windows.Forms.TextBox();
            this.txtLICHHOC = new System.Windows.Forms.TextBox();
            this.txtPHONGHOC = new System.Windows.Forms.TextBox();
            this.txtGIANGVIEN = new System.Windows.Forms.TextBox();
            this.txtSOLUONGSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.comFvalue = new System.Windows.Forms.ComboBox();
            this.comFname = new System.Windows.Forms.ComboBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.txtMAMON = new System.Windows.Forms.TextBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MAMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANGVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LICHHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONGHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dKTCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKTCDataSet = new DKTC.DKTCDataSet();
            this.HOCPHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHOCPHI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTENMON
            // 
            this.txtTENMON.Location = new System.Drawing.Point(1087, 102);
            this.txtTENMON.Name = "txtTENMON";
            this.txtTENMON.Size = new System.Drawing.Size(231, 22);
            this.txtTENMON.TabIndex = 2;
            // 
            // txtMALHP
            // 
            this.txtMALHP.Location = new System.Drawing.Point(1087, 61);
            this.txtMALHP.Name = "txtMALHP";
            this.txtMALHP.Size = new System.Drawing.Size(231, 22);
            this.txtMALHP.TabIndex = 3;
            // 
            // txtSOTC
            // 
            this.txtSOTC.Location = new System.Drawing.Point(1087, 142);
            this.txtSOTC.Name = "txtSOTC";
            this.txtSOTC.Size = new System.Drawing.Size(231, 22);
            this.txtSOTC.TabIndex = 4;
            // 
            // txtLICHHOC
            // 
            this.txtLICHHOC.Location = new System.Drawing.Point(1087, 182);
            this.txtLICHHOC.Name = "txtLICHHOC";
            this.txtLICHHOC.Size = new System.Drawing.Size(231, 22);
            this.txtLICHHOC.TabIndex = 5;
            // 
            // txtPHONGHOC
            // 
            this.txtPHONGHOC.Location = new System.Drawing.Point(1087, 224);
            this.txtPHONGHOC.Name = "txtPHONGHOC";
            this.txtPHONGHOC.Size = new System.Drawing.Size(231, 22);
            this.txtPHONGHOC.TabIndex = 6;
            // 
            // txtGIANGVIEN
            // 
            this.txtGIANGVIEN.Location = new System.Drawing.Point(1087, 266);
            this.txtGIANGVIEN.Name = "txtGIANGVIEN";
            this.txtGIANGVIEN.Size = new System.Drawing.Size(231, 22);
            this.txtGIANGVIEN.TabIndex = 7;
            // 
            // txtSOLUONGSV
            // 
            this.txtSOLUONGSV.Location = new System.Drawing.Point(1087, 306);
            this.txtSOLUONGSV.Name = "txtSOLUONGSV";
            this.txtSOLUONGSV.Size = new System.Drawing.Size(231, 22);
            this.txtSOLUONGSV.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(947, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(947, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã lớp học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(947, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(947, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số tín chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(947, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lịch học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(947, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phòng học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(947, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giảng viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(947, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số lượng sinh viên";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(75, 516);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.Text = "Đầu ";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(192, 516);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(75, 23);
            this.btnPrv.TabIndex = 18;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(309, 516);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(428, 516);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1206, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 55);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDk
            // 
            this.btnDk.Location = new System.Drawing.Point(937, 439);
            this.btnDk.Name = "btnDk";
            this.btnDk.Size = new System.Drawing.Size(155, 55);
            this.btnDk.TabIndex = 22;
            this.btnDk.Text = "Đăng ký";
            this.btnDk.UseVisualStyleBackColor = true;
            this.btnDk.Click += new System.EventHandler(this.btnDk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.comFvalue);
            this.groupBox1.Controls.Add(this.comFname);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(93, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 154);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm học phần";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(216, 95);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 41);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Nạp lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(6, 96);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(121, 42);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Tìm kiếm";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // comFvalue
            // 
            this.comFvalue.FormattingEnabled = true;
            this.comFvalue.Location = new System.Drawing.Point(157, 65);
            this.comFvalue.Name = "comFvalue";
            this.comFvalue.Size = new System.Drawing.Size(247, 24);
            this.comFvalue.TabIndex = 2;
            // 
            // comFname
            // 
            this.comFname.FormattingEnabled = true;
            this.comFname.Items.AddRange(new object[] {
            "Mã môn",
            "Mã lớp học phần",
            "Tên môn"});
            this.comFname.Location = new System.Drawing.Point(6, 65);
            this.comFname.Name = "comFname";
            this.comFname.Size = new System.Drawing.Size(121, 24);
            this.comFname.TabIndex = 1;
            this.comFname.SelectedIndexChanged += new System.EventHandler(this.comFname_SelectedIndexChanged);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(26, 21);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(353, 28);
            this.txtTimkiem.TabIndex = 0;
            this.txtTimkiem.Text = "Tên trường tìm kiếm = giá trị";
            // 
            // txtMAMON
            // 
            this.txtMAMON.Location = new System.Drawing.Point(1087, 22);
            this.txtMAMON.Name = "txtMAMON";
            this.txtMAMON.Size = new System.Drawing.Size(231, 22);
            this.txtMAMON.TabIndex = 25;
            // 
            // grdData
            // 
            this.grdData.AutoGenerateColumns = false;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMON,
            this.MALHP,
            this.TENMON,
            this.SOTC,
            this.GIANGVIEN,
            this.LICHHOC,
            this.PHONGHOC,
            this.SOLUONGSV,
            this.HOCPHI});
            this.grdData.DataSource = this.dKTCDataSetBindingSource;
            this.grdData.Location = new System.Drawing.Point(35, 22);
            this.grdData.Name = "grdData";
            this.grdData.RowTemplate.Height = 24;
            this.grdData.Size = new System.Drawing.Size(877, 314);
            this.grdData.TabIndex = 26;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellClick_1);
            // 
            // MAMON
            // 
            this.MAMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MAMON.DataPropertyName = "MAMON";
            this.MAMON.HeaderText = "Mã môn";
            this.MAMON.Name = "MAMON";
            this.MAMON.Width = 81;
            // 
            // MALHP
            // 
            this.MALHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MALHP.DataPropertyName = "MALHP";
            this.MALHP.HeaderText = "Mã lớp học phần";
            this.MALHP.Name = "MALHP";
            this.MALHP.Width = 101;
            // 
            // TENMON
            // 
            this.TENMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENMON.DataPropertyName = "TENMON";
            this.TENMON.HeaderText = "Tên môn";
            this.TENMON.Name = "TENMON";
            this.TENMON.Width = 86;
            // 
            // SOTC
            // 
            this.SOTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SOTC.DataPropertyName = "SOTC";
            this.SOTC.HeaderText = "Số tín chỉ";
            this.SOTC.Name = "SOTC";
            this.SOTC.Width = 88;
            // 
            // GIANGVIEN
            // 
            this.GIANGVIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIANGVIEN.DataPropertyName = "GIANGVIEN";
            this.GIANGVIEN.HeaderText = "Giảng viên";
            this.GIANGVIEN.Name = "GIANGVIEN";
            this.GIANGVIEN.Width = 97;
            // 
            // LICHHOC
            // 
            this.LICHHOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LICHHOC.DataPropertyName = "LICHHOC";
            this.LICHHOC.HeaderText = "Lịch học";
            this.LICHHOC.Name = "LICHHOC";
            this.LICHHOC.Width = 63;
            // 
            // PHONGHOC
            // 
            this.PHONGHOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PHONGHOC.DataPropertyName = "PHONGHOC";
            this.PHONGHOC.HeaderText = "Phòng học";
            this.PHONGHOC.Name = "PHONGHOC";
            this.PHONGHOC.Width = 97;
            // 
            // SOLUONGSV
            // 
            this.SOLUONGSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SOLUONGSV.DataPropertyName = "SOLUONGSV";
            this.SOLUONGSV.HeaderText = "Số lượng sinh viên";
            this.SOLUONGSV.Name = "SOLUONGSV";
            this.SOLUONGSV.Width = 117;
            // 
            // dKTCDataSetBindingSource
            // 
            this.dKTCDataSetBindingSource.DataSource = this.dKTCDataSet;
            this.dKTCDataSetBindingSource.Position = 0;
            // 
            // dKTCDataSet
            // 
            this.dKTCDataSet.DataSetName = "DKTCDataSet";
            this.dKTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOCPHI
            // 
            this.HOCPHI.HeaderText = "Học phí";
            this.HOCPHI.Name = "HOCPHI";
            // 
            // txtHOCPHI
            // 
            this.txtHOCPHI.Location = new System.Drawing.Point(1087, 345);
            this.txtHOCPHI.Name = "txtHOCPHI";
            this.txtHOCPHI.Size = new System.Drawing.Size(231, 22);
            this.txtHOCPHI.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(947, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Học phí";
            // 
            // frmDKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1402, 551);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHOCPHI);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.txtMAMON);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDk);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSOLUONGSV);
            this.Controls.Add(this.txtGIANGVIEN);
            this.Controls.Add(this.txtPHONGHOC);
            this.Controls.Add(this.txtLICHHOC);
            this.Controls.Add(this.txtSOTC);
            this.Controls.Add(this.txtMALHP);
            this.Controls.Add(this.txtTENMON);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDKHP";
            this.Text = "frmDKHP";
            this.Load += new System.EventHandler(this.frmDKHP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTENMON;
        private System.Windows.Forms.TextBox txtMALHP;
        private System.Windows.Forms.TextBox txtSOTC;
        private System.Windows.Forms.TextBox txtLICHHOC;
        private System.Windows.Forms.TextBox txtPHONGHOC;
        private System.Windows.Forms.TextBox txtGIANGVIEN;
        private System.Windows.Forms.TextBox txtSOLUONGSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox comFvalue;
        private System.Windows.Forms.ComboBox comFname;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.TextBox txtMAMON;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANGVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LICHHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONGHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGSV;
        private System.Windows.Forms.BindingSource dKTCDataSetBindingSource;
        private DKTCDataSet dKTCDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCPHI;
        private System.Windows.Forms.TextBox txtHOCPHI;
        private System.Windows.Forms.Label label9;
    }
}