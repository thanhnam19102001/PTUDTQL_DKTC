
namespace DKTC
{
    partial class frmLichsu
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
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MAMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dKTCDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKTCDataSet1 = new DKTC.DKTCDataSet1();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHOCPHI = new System.Windows.Forms.TextBox();
            this.txtMAMON = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGIANGVIEN = new System.Windows.Forms.TextBox();
            this.txtSOTC = new System.Windows.Forms.TextBox();
            this.txtMALHP = new System.Windows.Forms.TextBox();
            this.txtTENMON = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.AutoGenerateColumns = false;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMON,
            this.MALHP,
            this.DSMH,
            this.DSGV,
            this.DSTC,
            this.DSHP});
            this.grdData.DataSource = this.dKTCDataSet1BindingSource;
            this.grdData.Location = new System.Drawing.Point(30, 12);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.RowTemplate.Height = 24;
            this.grdData.Size = new System.Drawing.Size(756, 523);
            this.grdData.TabIndex = 0;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellClick);
            // 
            // MAMON
            // 
            this.MAMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MAMON.DataPropertyName = "MAMON";
            this.MAMON.HeaderText = "Mã môn";
            this.MAMON.MinimumWidth = 6;
            this.MAMON.Name = "MAMON";
            this.MAMON.Width = 81;
            // 
            // MALHP
            // 
            this.MALHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MALHP.DataPropertyName = "MALHP";
            this.MALHP.HeaderText = "Mã lớp học phần";
            this.MALHP.MinimumWidth = 6;
            this.MALHP.Name = "MALHP";
            this.MALHP.Width = 101;
            // 
            // DSMH
            // 
            this.DSMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSMH.DataPropertyName = "DSMH";
            this.DSMH.HeaderText = "Môn học";
            this.DSMH.MinimumWidth = 6;
            this.DSMH.Name = "DSMH";
            this.DSMH.Width = 64;
            // 
            // DSGV
            // 
            this.DSGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSGV.DataPropertyName = "DSGV";
            this.DSGV.HeaderText = "Giảng viên";
            this.DSGV.MinimumWidth = 6;
            this.DSGV.Name = "DSGV";
            this.DSGV.Width = 97;
            // 
            // DSTC
            // 
            this.DSTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSTC.DataPropertyName = "DSTC";
            this.DSTC.HeaderText = "Số tín chỉ";
            this.DSTC.MinimumWidth = 6;
            this.DSTC.Name = "DSTC";
            this.DSTC.Width = 88;
            // 
            // DSHP
            // 
            this.DSHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSHP.DataPropertyName = "DSHP";
            this.DSHP.HeaderText = "Học phí";
            this.DSHP.MinimumWidth = 6;
            this.DSHP.Name = "DSHP";
            this.DSHP.Width = 62;
            // 
            // dKTCDataSet1BindingSource
            // 
            this.dKTCDataSet1BindingSource.DataSource = this.dKTCDataSet1;
            this.dKTCDataSet1BindingSource.Position = 0;
            // 
            // dKTCDataSet1
            // 
            this.dKTCDataSet1.DataSetName = "DKTCDataSet1";
            this.dKTCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(383, 644);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 24;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(264, 644);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(147, 644);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(75, 23);
            this.btnPrv.TabIndex = 22;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(30, 644);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 21;
            this.btnFirst.Text = "Đầu ";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(849, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Học phí";
            // 
            // txtHOCPHI
            // 
            this.txtHOCPHI.Location = new System.Drawing.Point(989, 337);
            this.txtHOCPHI.Name = "txtHOCPHI";
            this.txtHOCPHI.Size = new System.Drawing.Size(231, 22);
            this.txtHOCPHI.TabIndex = 45;
            // 
            // txtMAMON
            // 
            this.txtMAMON.Location = new System.Drawing.Point(989, 134);
            this.txtMAMON.Name = "txtMAMON";
            this.txtMAMON.Size = new System.Drawing.Size(231, 22);
            this.txtMAMON.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(849, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Giảng viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(849, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Số tín chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tên môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã lớp học phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã môn";
            // 
            // txtGIANGVIEN
            // 
            this.txtGIANGVIEN.Location = new System.Drawing.Point(989, 256);
            this.txtGIANGVIEN.Name = "txtGIANGVIEN";
            this.txtGIANGVIEN.Size = new System.Drawing.Size(231, 22);
            this.txtGIANGVIEN.TabIndex = 34;
            // 
            // txtSOTC
            // 
            this.txtSOTC.Location = new System.Drawing.Point(989, 298);
            this.txtSOTC.Name = "txtSOTC";
            this.txtSOTC.Size = new System.Drawing.Size(231, 22);
            this.txtSOTC.TabIndex = 31;
            // 
            // txtMALHP
            // 
            this.txtMALHP.Location = new System.Drawing.Point(989, 173);
            this.txtMALHP.Name = "txtMALHP";
            this.txtMALHP.Size = new System.Drawing.Size(231, 22);
            this.txtMALHP.TabIndex = 30;
            // 
            // txtTENMON
            // 
            this.txtTENMON.Location = new System.Drawing.Point(989, 214);
            this.txtTENMON.Name = "txtTENMON";
            this.txtTENMON.Size = new System.Drawing.Size(231, 22);
            this.txtTENMON.TabIndex = 29;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(796, 627);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(155, 55);
            this.btnDel.TabIndex = 48;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1065, 627);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 55);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLichsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1253, 694);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHOCPHI);
            this.Controls.Add(this.txtMAMON);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGIANGVIEN);
            this.Controls.Add(this.txtSOTC);
            this.Controls.Add(this.txtMALHP);
            this.Controls.Add(this.txtTENMON);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.grdData);
            this.Name = "frmLichsu";
            this.Text = "frmLichsu";
            this.Load += new System.EventHandler(this.frmLichsu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.BindingSource dKTCDataSet1BindingSource;
        private DKTCDataSet1 dKTCDataSet1;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHOCPHI;
        private System.Windows.Forms.TextBox txtMAMON;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGIANGVIEN;
        private System.Windows.Forms.TextBox txtSOTC;
        private System.Windows.Forms.TextBox txtMALHP;
        private System.Windows.Forms.TextBox txtTENMON;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSHP;
    }
}