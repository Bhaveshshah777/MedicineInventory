namespace Medicine_Inventory_using_Core
{
    partial class UpdateForm
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.txtInsertQuantity = new System.Windows.Forms.TextBox();
            this.txtInsertPrice = new System.Windows.Forms.TextBox();
            this.txtInsertName = new System.Windows.Forms.TextBox();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.lblStockName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.cmbDeleteList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.lblInsertStatus = new System.Windows.Forms.Label();
            this.lblDeleteSuccess = new System.Windows.Forms.Label();
            this.insertPanel.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(50, 41);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 53);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(478, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // insertPanel
            // 
            this.insertPanel.Controls.Add(this.txtInsertQuantity);
            this.insertPanel.Controls.Add(this.txtInsertPrice);
            this.insertPanel.Controls.Add(this.txtInsertName);
            this.insertPanel.Controls.Add(this.lblStockQuantity);
            this.insertPanel.Controls.Add(this.lblStockPrice);
            this.insertPanel.Controls.Add(this.lblStockName);
            this.insertPanel.Controls.Add(this.btnCancel);
            this.insertPanel.Controls.Add(this.btnInsertUpdate);
            this.insertPanel.Location = new System.Drawing.Point(50, 124);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(547, 262);
            this.insertPanel.TabIndex = 3;
            // 
            // txtInsertQuantity
            // 
            this.txtInsertQuantity.Location = new System.Drawing.Point(201, 104);
            this.txtInsertQuantity.Name = "txtInsertQuantity";
            this.txtInsertQuantity.Size = new System.Drawing.Size(221, 29);
            this.txtInsertQuantity.TabIndex = 7;
            // 
            // txtInsertPrice
            // 
            this.txtInsertPrice.Location = new System.Drawing.Point(201, 65);
            this.txtInsertPrice.Name = "txtInsertPrice";
            this.txtInsertPrice.Size = new System.Drawing.Size(221, 29);
            this.txtInsertPrice.TabIndex = 6;
            // 
            // txtInsertName
            // 
            this.txtInsertName.Location = new System.Drawing.Point(201, 23);
            this.txtInsertName.Name = "txtInsertName";
            this.txtInsertName.Size = new System.Drawing.Size(221, 29);
            this.txtInsertName.TabIndex = 5;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(122, 107);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(73, 21);
            this.lblStockQuantity.TabIndex = 4;
            this.lblStockQuantity.Text = "Quantity:";
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Location = new System.Drawing.Point(148, 71);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(47, 21);
            this.lblStockPrice.TabIndex = 3;
            this.lblStockPrice.Text = "Price:";
            this.lblStockPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Location = new System.Drawing.Point(88, 31);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(107, 21);
            this.lblStockName.TabIndex = 2;
            this.lblStockName.Text = "Stock\'s Name:";
            this.lblStockName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(291, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 43);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.Location = new System.Drawing.Point(148, 155);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(114, 43);
            this.btnInsertUpdate.TabIndex = 0;
            this.btnInsertUpdate.Text = "Insert";
            this.btnInsertUpdate.UseVisualStyleBackColor = true;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.cmbDeleteList);
            this.panelDelete.Controls.Add(this.label4);
            this.panelDelete.Controls.Add(this.btnDeleteCancel);
            this.panelDelete.Controls.Add(this.btnDeleteEntry);
            this.panelDelete.Location = new System.Drawing.Point(52, 123);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(553, 266);
            this.panelDelete.TabIndex = 9;
            // 
            // cmbDeleteList
            // 
            this.cmbDeleteList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteList.FormattingEnabled = true;
            this.cmbDeleteList.Location = new System.Drawing.Point(206, 71);
            this.cmbDeleteList.Name = "cmbDeleteList";
            this.cmbDeleteList.Size = new System.Drawing.Size(209, 29);
            this.cmbDeleteList.TabIndex = 9;
            this.cmbDeleteList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stock\'s Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Location = new System.Drawing.Point(291, 155);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(114, 43);
            this.btnDeleteCancel.TabIndex = 1;
            this.btnDeleteCancel.Text = "Cancel";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Location = new System.Drawing.Point(148, 155);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(114, 43);
            this.btnDeleteEntry.TabIndex = 0;
            this.btnDeleteEntry.Text = "Delete";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // lblInsertStatus
            // 
            this.lblInsertStatus.AutoSize = true;
            this.lblInsertStatus.ForeColor = System.Drawing.Color.Green;
            this.lblInsertStatus.Location = new System.Drawing.Point(228, 244);
            this.lblInsertStatus.Name = "lblInsertStatus";
            this.lblInsertStatus.Size = new System.Drawing.Size(190, 21);
            this.lblInsertStatus.TabIndex = 8;
            this.lblInsertStatus.Text = "Data Inserted Successfully";
            this.lblInsertStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeleteSuccess
            // 
            this.lblDeleteSuccess.AutoSize = true;
            this.lblDeleteSuccess.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteSuccess.Location = new System.Drawing.Point(229, 229);
            this.lblDeleteSuccess.Name = "lblDeleteSuccess";
            this.lblDeleteSuccess.Size = new System.Drawing.Size(180, 21);
            this.lblDeleteSuccess.TabIndex = 8;
            this.lblDeleteSuccess.Text = "Data Deleted Succesfully";
            this.lblDeleteSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 420);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblInsertStatus);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblDeleteSuccess);
            this.Controls.Add(this.insertPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnInsert;
        private Button btnDelete;
        private Panel insertPanel;
        private Button btnCancel;
        private Button btnInsertUpdate;
        private TextBox txtInsertQuantity;
        private TextBox txtInsertPrice;
        private TextBox txtInsertName;
        private Label lblStockQuantity;
        private Label lblStockPrice;
        private Label lblStockName;
        private Label lblInsertStatus;
        private Panel panelDelete;
        private ComboBox cmbDeleteList;
        private Label lblDeleteSuccess;
        private Label label4;
        private Button btnDeleteCancel;
        private Button btnDeleteEntry;
    }
}