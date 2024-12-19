namespace Lab4_4
{
    partial class Form1
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
            this.grbInfor = new System.Windows.Forms.GroupBox();
            this.dtpGiao = new System.Windows.Forms.DateTimePicker();
            this.dtpDat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkView = new System.Windows.Forms.CheckBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.clnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDateD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDateG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfor
            // 
            this.grbInfor.Controls.Add(this.dtpGiao);
            this.grbInfor.Controls.Add(this.dtpDat);
            this.grbInfor.Controls.Add(this.label2);
            this.grbInfor.Controls.Add(this.label1);
            this.grbInfor.Controls.Add(this.chkView);
            this.grbInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfor.Location = new System.Drawing.Point(0, 0);
            this.grbInfor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInfor.Name = "grbInfor";
            this.grbInfor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInfor.Size = new System.Drawing.Size(1067, 160);
            this.grbInfor.TabIndex = 0;
            this.grbInfor.TabStop = false;
            this.grbInfor.Text = "Thông Tin Đơn Hàng";
            this.grbInfor.Enter += new System.EventHandler(this.grbInfor_Enter);
            // 
            // dtpGiao
            // 
            this.dtpGiao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGiao.Location = new System.Drawing.Point(539, 95);
            this.dtpGiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpGiao.Name = "dtpGiao";
            this.dtpGiao.Size = new System.Drawing.Size(157, 30);
            this.dtpGiao.TabIndex = 2;
            this.dtpGiao.Value = new System.DateTime(2024, 12, 13, 0, 0, 0, 0);
            this.dtpGiao.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtpDat
            // 
            this.dtpDat.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDat.Location = new System.Drawing.Point(335, 95);
            this.dtpDat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDat.Name = "dtpDat";
            this.dtpDat.Size = new System.Drawing.Size(157, 30);
            this.dtpDat.TabIndex = 2;
            this.dtpDat.UseWaitCursor = true;
            this.dtpDat.Value = new System.DateTime(2024, 12, 13, 0, 0, 0, 0);
            this.dtpDat.ValueChanged += new System.EventHandler(this.dtpDat_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // chkView
            // 
            this.chkView.AutoSize = true;
            this.chkView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkView.Location = new System.Drawing.Point(119, 49);
            this.chkView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkView.Name = "chkView";
            this.chkView.Size = new System.Drawing.Size(230, 29);
            this.chkView.TabIndex = 0;
            this.chkView.Text = "Xem tất cả trong tháng";
            this.chkView.UseVisualStyleBackColor = true;
            this.chkView.CheckedChanged += new System.EventHandler(this.chkView_CheckedChanged);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSTT,
            this.clnID,
            this.clnDateD,
            this.clnDateG,
            this.clnCost});
            this.dgvOrders.Location = new System.Drawing.Point(0, 155);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.Size = new System.Drawing.Size(1059, 399);
            this.dgvOrders.TabIndex = 1;
            // 
            // clnSTT
            // 
            this.clnSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnSTT.HeaderText = "STT";
            this.clnSTT.MinimumWidth = 6;
            this.clnSTT.Name = "clnSTT";
            // 
            // clnID
            // 
            this.clnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnID.HeaderText = "Số HĐ";
            this.clnID.MinimumWidth = 6;
            this.clnID.Name = "clnID";
            // 
            // clnDateD
            // 
            this.clnDateD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnDateD.HeaderText = "Ngày Đặt Hàng";
            this.clnDateD.MinimumWidth = 6;
            this.clnDateD.Name = "clnDateD";
            // 
            // clnDateG
            // 
            this.clnDateG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnDateG.HeaderText = "Ngày Giao Hàng";
            this.clnDateG.MinimumWidth = 6;
            this.clnDateG.Name = "clnDateG";
            // 
            // clnCost
            // 
            this.clnCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCost.HeaderText = "Thành Tiền";
            this.clnCost.MinimumWidth = 6;
            this.clnCost.Name = "clnCost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 567);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng Cộng:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(795, 566);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(101, 22);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 603);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.grbInfor);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbInfor.ResumeLayout(false);
            this.grbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkView;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DateTimePicker dtpGiao;
        private System.Windows.Forms.DateTimePicker dtpDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDateD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDateG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

