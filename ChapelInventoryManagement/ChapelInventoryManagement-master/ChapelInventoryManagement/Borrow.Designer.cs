namespace ChapelInventoryManagement
{
    partial class Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow));
            this.s = new System.Windows.Forms.GroupBox();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAvail = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.Controls.Add(this.txtAvail);
            this.s.Controls.Add(this.txtQty);
            this.s.Controls.Add(this.txtItem);
            this.s.Controls.Add(this.txtID);
            this.s.Controls.Add(this.lblAvail);
            this.s.Controls.Add(this.lblQty);
            this.s.Controls.Add(this.lblID);
            this.s.Controls.Add(this.lblItem);
            this.s.Location = new System.Drawing.Point(180, 30);
            this.s.Margin = new System.Windows.Forms.Padding(4);
            this.s.Name = "s";
            this.s.Padding = new System.Windows.Forms.Padding(4);
            this.s.Size = new System.Drawing.Size(621, 240);
            this.s.TabIndex = 1;
            this.s.TabStop = false;
            this.s.Text = "Inventory";
            // 
            // txtAvail
            // 
            this.txtAvail.Location = new System.Drawing.Point(127, 165);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.Size = new System.Drawing.Size(311, 22);
            this.txtAvail.TabIndex = 1;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(127, 125);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(311, 22);
            this.txtQty.TabIndex = 1;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(127, 74);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(311, 22);
            this.txtItem.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(127, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(311, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.Location = new System.Drawing.Point(28, 171);
            this.lblAvail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(72, 16);
            this.lblAvail.TabIndex = 0;
            this.lblAvail.Text = "Availability";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(28, 131);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(55, 16);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "Quantity";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(28, 31);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(28, 80);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(32, 16);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(821, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(821, 99);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 32);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(821, 48);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(95, 32);
            this.btnBorrow.TabIndex = 8;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 278);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(727, 22);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(748, 269);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 31);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 11;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(13, 313);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(907, 208);
            this.dgvItems.TabIndex = 12;
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 534);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.s);
            this.Name = "Borrow";
            this.Text = "s";
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox s;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.DataGridView dgvItems;
    }
}