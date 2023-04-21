namespace DBATool
{
    partial class frmViewDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDataDetail = new System.Windows.Forms.DataGridView();
            this.Quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.RefCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNetTotal = new System.Windows.Forms.Label();
            this.txtFinalTotal = new System.Windows.Forms.Label();
            this.txtWhoClose = new System.Windows.Forms.Label();
            this.txtEmpClose = new System.Windows.Forms.Label();
            this.txtTableNum = new System.Windows.Forms.Label();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(86)))), ((int)(((byte)(135)))));
            this.panel22.Controls.Add(this.txtTableNum);
            this.panel22.Controls.Add(this.txtEmpClose);
            this.panel22.Controls.Add(this.txtWhoClose);
            this.panel22.Controls.Add(this.txtFinalTotal);
            this.panel22.Controls.Add(this.txtNetTotal);
            this.panel22.Controls.Add(this.label4);
            this.panel22.Controls.Add(this.label2);
            this.panel22.Controls.Add(this.label1);
            this.panel22.Controls.Add(this.dgvDataDetail);
            this.panel22.Controls.Add(this.btnConfirm);
            this.panel22.Controls.Add(this.btnClose);
            this.panel22.Location = new System.Drawing.Point(1, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(699, 635);
            this.panel22.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(415, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Final Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(430, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Net Total:";
            // 
            // dgvDataDetail
            // 
            this.dgvDataDetail.AllowUserToAddRows = false;
            this.dgvDataDetail.AllowUserToDeleteRows = false;
            this.dgvDataDetail.AllowUserToResizeColumns = false;
            this.dgvDataDetail.AllowUserToResizeRows = false;
            this.dgvDataDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDataDetail.ColumnHeadersHeight = 35;
            this.dgvDataDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataDetail.ColumnHeadersVisible = false;
            this.dgvDataDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quan,
            this.Descript,
            this.Amount,
            this.UniqueID});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataDetail.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDataDetail.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDataDetail.Location = new System.Drawing.Point(21, 22);
            this.dgvDataDetail.MultiSelect = false;
            this.dgvDataDetail.Name = "dgvDataDetail";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDataDetail.RowHeadersVisible = false;
            this.dgvDataDetail.RowHeadersWidth = 51;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvDataDetail.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDataDetail.RowTemplate.Height = 50;
            this.dgvDataDetail.Size = new System.Drawing.Size(651, 427);
            this.dgvDataDetail.TabIndex = 19;
            // 
            // Quan
            // 
            this.Quan.DataPropertyName = "Quan";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.Quan.DefaultCellStyle = dataGridViewCellStyle8;
            this.Quan.HeaderText = "Quan";
            this.Quan.Name = "Quan";
            this.Quan.ReadOnly = true;
            this.Quan.Width = 50;
            // 
            // Descript
            // 
            this.Descript.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descript.DataPropertyName = "Descript";
            this.Descript.HeaderText = "Descript";
            this.Descript.Name = "Descript";
            this.Descript.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle9;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 150;
            // 
            // UniqueID
            // 
            this.UniqueID.DataPropertyName = "UniqueID";
            this.UniqueID.HeaderText = "UniqueID";
            this.UniqueID.Name = "UniqueID";
            this.UniqueID.ReadOnly = true;
            this.UniqueID.Visible = false;
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
            this.btnClose.Location = new System.Drawing.Point(21, 571);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 39);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(551, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 22;
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNetTotal.Location = new System.Drawing.Point(537, 468);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Size = new System.Drawing.Size(135, 29);
            this.txtNetTotal.TabIndex = 24;
            this.txtNetTotal.Text = "0";
            this.txtNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFinalTotal
            // 
            this.txtFinalTotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFinalTotal.Location = new System.Drawing.Point(542, 504);
            this.txtFinalTotal.Name = "txtFinalTotal";
            this.txtFinalTotal.Size = new System.Drawing.Size(130, 29);
            this.txtFinalTotal.TabIndex = 25;
            this.txtFinalTotal.Text = "0";
            this.txtFinalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWhoClose
            // 
            this.txtWhoClose.AutoSize = true;
            this.txtWhoClose.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhoClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtWhoClose.Location = new System.Drawing.Point(16, 505);
            this.txtWhoClose.Name = "txtWhoClose";
            this.txtWhoClose.Size = new System.Drawing.Size(0, 29);
            this.txtWhoClose.TabIndex = 26;
            // 
            // txtEmpClose
            // 
            this.txtEmpClose.AutoSize = true;
            this.txtEmpClose.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEmpClose.Location = new System.Drawing.Point(16, 505);
            this.txtEmpClose.Name = "txtEmpClose";
            this.txtEmpClose.Size = new System.Drawing.Size(65, 29);
            this.txtEmpClose.TabIndex = 27;
            this.txtEmpClose.Text = "Emp";
            // 
            // txtTableNum
            // 
            this.txtTableNum.AutoSize = true;
            this.txtTableNum.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTableNum.Location = new System.Drawing.Point(16, 468);
            this.txtTableNum.Name = "txtTableNum";
            this.txtTableNum.Size = new System.Drawing.Size(65, 29);
            this.txtTableNum.TabIndex = 28;
            this.txtTableNum.Text = "Emp";
            // 
            // frmViewDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 641);
            this.Controls.Add(this.panel22);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed Count Down";
            this.Load += new System.EventHandler(this.frmViewDetail_Load);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDataDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descript;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniqueID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtFinalTotal;
        private System.Windows.Forms.Label txtNetTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtWhoClose;
        private System.Windows.Forms.Label txtTableNum;
        private System.Windows.Forms.Label txtEmpClose;
    }
}

