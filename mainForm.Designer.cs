namespace Medicine_Inventory_using_Core
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listMedicines = new System.Windows.Forms.ListBox();
            this.listCart = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMedicines
            // 
            this.listMedicines.FormattingEnabled = true;
            this.listMedicines.ItemHeight = 21;
            this.listMedicines.Location = new System.Drawing.Point(38, 84);
            this.listMedicines.Name = "listMedicines";
            this.listMedicines.Size = new System.Drawing.Size(267, 214);
            this.listMedicines.TabIndex = 0;
            // 
            // listCart
            // 
            this.listCart.FormattingEnabled = true;
            this.listCart.ItemHeight = 21;
            this.listCart.Location = new System.Drawing.Point(487, 84);
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(267, 214);
            this.listCart.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(340, 125);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(105, 53);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add>>";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(340, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 53);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(649, 385);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(105, 53);
            this.btnBuy.TabIndex = 4;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(105, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 29);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(562, 339);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 29);
            this.textBox2.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(39, 40);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 21);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patient Name:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(385, 401);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 21);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(621, 27);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(133, 41);
            this.btnStore.TabIndex = 10;
            this.btnStore.Text = "Store Options";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.listCart);
            this.Controls.Add(this.listMedicines);
            this.Name = "mainForm";
            this.Text = "Medicine Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listMedicines;
        private ListBox listCart;
        private Button btnAddToCart;
        private Button btnDelete;
        private Button btnBuy;
        private TextBox txtSearch;
        private TextBox textBox2;
        private Label lblSearch;
        private Label label1;
        private Label lblStatus;
        private Button btnStore;
    }
}