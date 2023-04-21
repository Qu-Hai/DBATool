namespace DBATool
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel22 = new System.Windows.Forms.Panel();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFromAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToStore = new System.Windows.Forms.Label();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.dgvDataTransaction = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Transact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhoOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhoClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.RefCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(86)))), ((int)(((byte)(135)))));
            this.panel22.Controls.Add(this.cbAll);
            this.panel22.Controls.Add(this.label4);
            this.panel22.Controls.Add(this.txtToAmount);
            this.panel22.Controls.Add(this.label3);
            this.panel22.Controls.Add(this.txtFromAmount);
            this.panel22.Controls.Add(this.label1);
            this.panel22.Controls.Add(this.dtToDate);
            this.panel22.Controls.Add(this.dtFromDate);
            this.panel22.Controls.Add(this.lblToStore);
            this.panel22.Controls.Add(this.btnInquiry);
            this.panel22.Controls.Add(this.dgvDataTransaction);
            this.panel22.Controls.Add(this.btnConfirm);
            this.panel22.Controls.Add(this.btnClose);
            this.panel22.Location = new System.Drawing.Point(3, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(1341, 736);
            this.panel22.TabIndex = 4;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(31, 95);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(18, 17);
            this.cbAll.TabIndex = 76;
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(571, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 35);
            this.label4.TabIndex = 75;
            this.label4.Text = "To Amount:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtToAmount
            // 
            this.txtToAmount.Location = new System.Drawing.Point(575, 44);
            this.txtToAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtToAmount.MaxLength = 10;
            this.txtToAmount.Name = "txtToAmount";
            this.txtToAmount.Size = new System.Drawing.Size(173, 30);
            this.txtToAmount.TabIndex = 74;
            this.txtToAmount.Tag = "1";
            this.txtToAmount.Text = "99,999,999";
            this.txtToAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtToAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToAmount_KeyPress);
            this.txtToAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtToAmount_Validating);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(390, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 35);
            this.label3.TabIndex = 73;
            this.label3.Text = "From Amount:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFromAmount
            // 
            this.txtFromAmount.Location = new System.Drawing.Point(394, 44);
            this.txtFromAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtFromAmount.MaxLength = 10;
            this.txtFromAmount.Name = "txtFromAmount";
            this.txtFromAmount.Size = new System.Drawing.Size(173, 30);
            this.txtFromAmount.TabIndex = 72;
            this.txtFromAmount.Tag = "1";
            this.txtFromAmount.Text = "0";
            this.txtFromAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFromAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromAmount_KeyPress);
            this.txtFromAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromAmount_Validating);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 35);
            this.label1.TabIndex = 71;
            this.label1.Text = "To Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtToDate
            // 
            this.dtToDate.CustomFormat = "";
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(188, 44);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(168, 30);
            this.dtToDate.TabIndex = 70;
            this.dtToDate.Value = new System.DateTime(2023, 4, 18, 0, 0, 0, 0);
            this.dtToDate.ValueChanged += new System.EventHandler(this.dtToDate_ValueChanged);
            // 
            // dtFromDate
            // 
            this.dtFromDate.CustomFormat = "";
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(14, 44);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(168, 30);
            this.dtFromDate.TabIndex = 69;
            this.dtFromDate.Value = new System.DateTime(2023, 4, 18, 0, 0, 0, 0);
            this.dtFromDate.ValueChanged += new System.EventHandler(this.dtFromDate_ValueChanged);
            // 
            // lblToStore
            // 
            this.lblToStore.BackColor = System.Drawing.Color.Transparent;
            this.lblToStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToStore.ForeColor = System.Drawing.Color.White;
            this.lblToStore.Location = new System.Drawing.Point(9, 6);
            this.lblToStore.Name = "lblToStore";
            this.lblToStore.Size = new System.Drawing.Size(177, 35);
            this.lblToStore.TabIndex = 63;
            this.lblToStore.Text = "From Date:";
            this.lblToStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInquiry
            // 
            this.btnInquiry.BackColor = System.Drawing.Color.Transparent;
            this.btnInquiry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnInquiry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquiry.ForeColor = System.Drawing.Color.White;
            this.btnInquiry.Location = new System.Drawing.Point(791, 44);
            this.btnInquiry.Margin = new System.Windows.Forms.Padding(4);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(227, 26);
            this.btnInquiry.TabIndex = 49;
            this.btnInquiry.Text = "Inquiry";
            this.btnInquiry.UseVisualStyleBackColor = false;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // dgvDataTransaction
            // 
            this.dgvDataTransaction.AllowUserToAddRows = false;
            this.dgvDataTransaction.AllowUserToDeleteRows = false;
            this.dgvDataTransaction.AllowUserToResizeColumns = false;
            this.dgvDataTransaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataTransaction.ColumnHeadersHeight = 35;
            this.dgvDataTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Transact,
            this.TimeEnd,
            this.NetTotal,
            this.SVC,
            this.VAT,
            this.FinalTotal,
            this.WhoOpen,
            this.WhoClose,
            this.Detail});
            this.dgvDataTransaction.Location = new System.Drawing.Point(10, 84);
            this.dgvDataTransaction.MultiSelect = false;
            this.dgvDataTransaction.Name = "dgvDataTransaction";
            this.dgvDataTransaction.RowHeadersVisible = false;
            this.dgvDataTransaction.RowHeadersWidth = 51;
            this.dgvDataTransaction.RowTemplate.Height = 50;
            this.dgvDataTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataTransaction.Size = new System.Drawing.Size(1322, 598);
            this.dgvDataTransaction.TabIndex = 19;
            this.dgvDataTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataTransaction_CellClick);
            this.dgvDataTransaction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataTransaction_CellDoubleClick);
            // 
            // Select
            // 
            this.Select.FillWeight = 500F;
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 50;
            // 
            // Transact
            // 
            this.Transact.DataPropertyName = "Transact";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Transact.DefaultCellStyle = dataGridViewCellStyle2;
            this.Transact.HeaderText = "Transact";
            this.Transact.Name = "Transact";
            this.Transact.ReadOnly = true;
            this.Transact.Width = 90;
            // 
            // TimeEnd
            // 
            this.TimeEnd.DataPropertyName = "TimeEnd";
            this.TimeEnd.HeaderText = "DateTime";
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.ReadOnly = true;
            this.TimeEnd.Width = 150;
            // 
            // NetTotal
            // 
            this.NetTotal.DataPropertyName = "NetTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.NetTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.NetTotal.HeaderText = "NetTotal";
            this.NetTotal.Name = "NetTotal";
            this.NetTotal.ReadOnly = true;
            this.NetTotal.Width = 130;
            // 
            // SVC
            // 
            this.SVC.DataPropertyName = "SVC";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.SVC.DefaultCellStyle = dataGridViewCellStyle4;
            this.SVC.HeaderText = "SVC";
            this.SVC.Name = "SVC";
            this.SVC.ReadOnly = true;
            this.SVC.Width = 130;
            // 
            // VAT
            // 
            this.VAT.DataPropertyName = "VAT";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.VAT.DefaultCellStyle = dataGridViewCellStyle5;
            this.VAT.HeaderText = "VAT";
            this.VAT.Name = "VAT";
            this.VAT.ReadOnly = true;
            this.VAT.Width = 130;
            // 
            // FinalTotal
            // 
            this.FinalTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FinalTotal.DataPropertyName = "FinalTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.FinalTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.FinalTotal.HeaderText = "FinalTotal";
            this.FinalTotal.Name = "FinalTotal";
            this.FinalTotal.ReadOnly = true;
            // 
            // WhoOpen
            // 
            this.WhoOpen.DataPropertyName = "WhoOpen";
            this.WhoOpen.HeaderText = "WhoOpen";
            this.WhoOpen.Name = "WhoOpen";
            this.WhoOpen.ReadOnly = true;
            this.WhoOpen.Width = 200;
            // 
            // WhoClose
            // 
            this.WhoClose.DataPropertyName = "WhoClose";
            this.WhoClose.HeaderText = "WhoClose";
            this.WhoClose.Name = "WhoClose";
            this.WhoClose.ReadOnly = true;
            this.WhoClose.Width = 200;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = "View";
            this.Detail.DefaultCellStyle = dataGridViewCellStyle7;
            this.Detail.HeaderText = "";
            this.Detail.Name = "Detail";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(1209, 688);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(123, 39);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(9, 688);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 39);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RefCode
            // 
            this.RefCode.Name = "RefCode";
            // 
            // ProductCode
            // 
            this.ProductCode.Name = "ProductCode";
            // 
            // ProductName
            // 
            this.ProductName.Name = "ProductName";
            // 
            // CategoryName
            // 
            this.CategoryName.Name = "CategoryName";
            // 
            // CategoryCode
            // 
            this.CategoryCode.Name = "CategoryCode";
            // 
            // Quantity
            // 
            this.Quantity.Name = "Quantity";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1347, 742);
            this.Controls.Add(this.panel22);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed Count Down";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDataTransaction;
        public System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Label lblToStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtToAmount;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtFromAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transact;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhoOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhoClose;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

