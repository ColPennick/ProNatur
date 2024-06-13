namespace ProNatur_Biomarkt_GmbH
{
    partial class BillsScreen
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
            this.textBoxBillRecipient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBillTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBillDescription = new System.Windows.Forms.TextBox();
            this.btnBillDelete = new System.Windows.Forms.Button();
            this.btnBillClear = new System.Windows.Forms.Button();
            this.btnBillEdit = new System.Windows.Forms.Button();
            this.btnBillSave = new System.Windows.Forms.Button();
            this.billsDGV = new System.Windows.Forms.DataGridView();
            this.textBoxBillId = new System.Windows.Forms.TextBox();
            this._Pro_Natur_Biomarkt_GmbHDataSet = new ProNatur_Biomarkt_GmbH._Pro_Natur_Biomarkt_GmbHDataSet();
            this.textBoxDbPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.billsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Pro_Natur_Biomarkt_GmbHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBillRecipient
            // 
            this.textBoxBillRecipient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxBillRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBillRecipient.ForeColor = System.Drawing.Color.White;
            this.textBoxBillRecipient.Location = new System.Drawing.Point(77, 6);
            this.textBoxBillRecipient.MaxLength = 255;
            this.textBoxBillRecipient.Name = "textBoxBillRecipient";
            this.textBoxBillRecipient.Size = new System.Drawing.Size(172, 20);
            this.textBoxBillRecipient.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rechnung";
            // 
            // textBoxBillTotalPrice
            // 
            this.textBoxBillTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxBillTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBillTotalPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxBillTotalPrice.Location = new System.Drawing.Point(77, 96);
            this.textBoxBillTotalPrice.MaxLength = 255;
            this.textBoxBillTotalPrice.Name = "textBoxBillTotalPrice";
            this.textBoxBillTotalPrice.Size = new System.Drawing.Size(172, 20);
            this.textBoxBillTotalPrice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Preis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Posten";
            // 
            // textBoxBillDescription
            // 
            this.textBoxBillDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxBillDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBillDescription.ForeColor = System.Drawing.Color.White;
            this.textBoxBillDescription.Location = new System.Drawing.Point(77, 66);
            this.textBoxBillDescription.MaxLength = 255;
            this.textBoxBillDescription.Name = "textBoxBillDescription";
            this.textBoxBillDescription.Size = new System.Drawing.Size(172, 20);
            this.textBoxBillDescription.TabIndex = 6;
            // 
            // btnBillDelete
            // 
            this.btnBillDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillDelete.ForeColor = System.Drawing.Color.White;
            this.btnBillDelete.Location = new System.Drawing.Point(333, 127);
            this.btnBillDelete.Name = "btnBillDelete";
            this.btnBillDelete.Size = new System.Drawing.Size(69, 23);
            this.btnBillDelete.TabIndex = 16;
            this.btnBillDelete.Text = "Löschen";
            this.btnBillDelete.UseVisualStyleBackColor = false;
            this.btnBillDelete.Click += new System.EventHandler(this.btnBillDelete_Click);
            // 
            // btnBillClear
            // 
            this.btnBillClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillClear.ForeColor = System.Drawing.Color.White;
            this.btnBillClear.Location = new System.Drawing.Point(241, 127);
            this.btnBillClear.Name = "btnBillClear";
            this.btnBillClear.Size = new System.Drawing.Size(79, 23);
            this.btnBillClear.TabIndex = 15;
            this.btnBillClear.Text = "Felder leeren";
            this.btnBillClear.UseVisualStyleBackColor = false;
            this.btnBillClear.Click += new System.EventHandler(this.btnBillClear_Click);
            // 
            // btnBillEdit
            // 
            this.btnBillEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillEdit.ForeColor = System.Drawing.Color.White;
            this.btnBillEdit.Location = new System.Drawing.Point(159, 127);
            this.btnBillEdit.Name = "btnBillEdit";
            this.btnBillEdit.Size = new System.Drawing.Size(69, 23);
            this.btnBillEdit.TabIndex = 14;
            this.btnBillEdit.Text = "Bearbeiten";
            this.btnBillEdit.UseVisualStyleBackColor = false;
            this.btnBillEdit.Click += new System.EventHandler(this.btnBillEdit_Click);
            // 
            // btnBillSave
            // 
            this.btnBillSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillSave.ForeColor = System.Drawing.Color.White;
            this.btnBillSave.Location = new System.Drawing.Point(77, 127);
            this.btnBillSave.Name = "btnBillSave";
            this.btnBillSave.Size = new System.Drawing.Size(69, 23);
            this.btnBillSave.TabIndex = 13;
            this.btnBillSave.Text = "Speichern";
            this.btnBillSave.UseVisualStyleBackColor = false;
            this.btnBillSave.Click += new System.EventHandler(this.btnBillSave_Click);
            // 
            // billsDGV
            // 
            this.billsDGV.AllowUserToAddRows = false;
            this.billsDGV.AllowUserToDeleteRows = false;
            this.billsDGV.AllowUserToResizeColumns = false;
            this.billsDGV.AllowUserToResizeRows = false;
            this.billsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.billsDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.billsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.billsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsDGV.ColumnHeadersVisible = false;
            this.billsDGV.Location = new System.Drawing.Point(12, 156);
            this.billsDGV.MultiSelect = false;
            this.billsDGV.Name = "billsDGV";
            this.billsDGV.ReadOnly = true;
            this.billsDGV.RowHeadersVisible = false;
            this.billsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.billsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.billsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.billsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billsDGV.Size = new System.Drawing.Size(775, 293);
            this.billsDGV.TabIndex = 17;
            this.billsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billsDGV_CellContentClick);
            // 
            // textBoxBillId
            // 
            this.textBoxBillId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBillId.ForeColor = System.Drawing.Color.White;
            this.textBoxBillId.Location = new System.Drawing.Point(77, 36);
            this.textBoxBillId.MaxLength = 255;
            this.textBoxBillId.Name = "textBoxBillId";
            this.textBoxBillId.ReadOnly = true;
            this.textBoxBillId.Size = new System.Drawing.Size(172, 20);
            this.textBoxBillId.TabIndex = 5;
            // 
            // _Pro_Natur_Biomarkt_GmbHDataSet
            // 
            this._Pro_Natur_Biomarkt_GmbHDataSet.DataSetName = "_Pro_Natur_Biomarkt_GmbHDataSet";
            this._Pro_Natur_Biomarkt_GmbHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxDbPath
            // 
            this.textBoxDbPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxDbPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDbPath.ForeColor = System.Drawing.Color.White;
            this.textBoxDbPath.Location = new System.Drawing.Point(333, 6);
            this.textBoxDbPath.MaxLength = 255;
            this.textBoxDbPath.Name = "textBoxDbPath";
            this.textBoxDbPath.ReadOnly = true;
            this.textBoxDbPath.Size = new System.Drawing.Size(454, 13);
            this.textBoxDbPath.TabIndex = 18;
            // 
            // BillsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProNatur_Biomarkt_GmbH.Properties.Resources.BtnImgBill;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.textBoxDbPath);
            this.Controls.Add(this.billsDGV);
            this.Controls.Add(this.btnBillDelete);
            this.Controls.Add(this.btnBillClear);
            this.Controls.Add(this.btnBillEdit);
            this.Controls.Add(this.btnBillSave);
            this.Controls.Add(this.textBoxBillTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBillDescription);
            this.Controls.Add(this.textBoxBillId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBillRecipient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BillsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bills";
            ((System.ComponentModel.ISupportInitialize)(this.billsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Pro_Natur_Biomarkt_GmbHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBillRecipient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBillTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBillDescription;
        private System.Windows.Forms.Button btnBillDelete;
        private System.Windows.Forms.Button btnBillClear;
        private System.Windows.Forms.Button btnBillEdit;
        private System.Windows.Forms.Button btnBillSave;
        private System.Windows.Forms.DataGridView billsDGV;
        private _Pro_Natur_Biomarkt_GmbHDataSet _Pro_Natur_Biomarkt_GmbHDataSet;
        private System.Windows.Forms.TextBox textBoxBillId;
        private System.Windows.Forms.TextBox textBoxDbPath;
    }
}