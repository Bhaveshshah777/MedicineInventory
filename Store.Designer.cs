namespace Medicine_Inventory_using_Core
{
    partial class Store
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
            this.gridViewAllData = new System.Windows.Forms.DataGridView();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.lblStockName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbMedicineName = new System.Windows.Forms.ComboBox();
            this.lblFetchedPrice = new System.Windows.Forms.Label();
            this.lblRowEffected = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewAllData
            // 
            this.gridViewAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAllData.Location = new System.Drawing.Point(454, 12);
            this.gridViewAllData.Name = "gridViewAllData";
            this.gridViewAllData.RowHeadersWidth = 51;
            this.gridViewAllData.RowTemplate.Height = 31;
            this.gridViewAllData.Size = new System.Drawing.Size(636, 599);
            this.gridViewAllData.TabIndex = 0;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(149, 271);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(136, 54);
            this.btnAddStock.TabIndex = 1;
            this.btnAddStock.Text = "Add Stock ";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Location = new System.Drawing.Point(11, 89);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(96, 21);
            this.lblStockName.TabIndex = 2;
            this.lblStockName.Text = "Stock Name:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(34, 186);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 21);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(60, 141);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(119, 186);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(152, 29);
            this.txtQuantity.TabIndex = 6;
            // 
            // cmbMedicineName
            // 
            this.cmbMedicineName.AllowDrop = true;
            this.cmbMedicineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicineName.FormattingEnabled = true;
            this.cmbMedicineName.Location = new System.Drawing.Point(119, 86);
            this.cmbMedicineName.Name = "cmbMedicineName";
            this.cmbMedicineName.Size = new System.Drawing.Size(283, 29);
            this.cmbMedicineName.TabIndex = 8;
            this.cmbMedicineName.SelectedIndexChanged += new System.EventHandler(this.cmbMedicineName_SelectedIndexChanged);
            // 
            // lblFetchedPrice
            // 
            this.lblFetchedPrice.AutoSize = true;
            this.lblFetchedPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFetchedPrice.Location = new System.Drawing.Point(119, 141);
            this.lblFetchedPrice.Name = "lblFetchedPrice";
            this.lblFetchedPrice.Size = new System.Drawing.Size(0, 28);
            this.lblFetchedPrice.TabIndex = 9;
            // 
            // lblRowEffected
            // 
            this.lblRowEffected.AutoSize = true;
            this.lblRowEffected.Location = new System.Drawing.Point(181, 346);
            this.lblRowEffected.Name = "lblRowEffected";
            this.lblRowEffected.Size = new System.Drawing.Size(0, 21);
            this.lblRowEffected.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(163, 560);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 51);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 623);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblRowEffected);
            this.Controls.Add(this.lblFetchedPrice);
            this.Controls.Add(this.cmbMedicineName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblStockName);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.gridViewAllData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridViewAllData;
        private Button btnAddStock;
        private Label lblStockName;
        private Label lblQuantity;
        private Label lblPrice;
        private TextBox txtQuantity;
        private ComboBox cmbMedicineName;
        private Label lblFetchedPrice;
        private Label lblRowEffected;
        private Button btnUpdate;
    }
}