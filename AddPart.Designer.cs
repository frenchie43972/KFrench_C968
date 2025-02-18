﻿
namespace KFrench_C968
{
    partial class AddPart
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
            this.radioInHouseAdd = new System.Windows.Forms.RadioButton();
            this.radioOutsourcedAdd = new System.Windows.Forms.RadioButton();
            this.lblAddPartTitle = new System.Windows.Forms.Label();
            this.txtAddPartID = new System.Windows.Forms.TextBox();
            this.txtAddPartPrice = new System.Windows.Forms.TextBox();
            this.txtAddPartMachineID = new System.Windows.Forms.TextBox();
            this.txtAddPartInv = new System.Windows.Forms.TextBox();
            this.txtAddPartName = new System.Windows.Forms.TextBox();
            this.txtAddPartMax = new System.Windows.Forms.TextBox();
            this.txtAddPartMin = new System.Windows.Forms.TextBox();
            this.lblAddPartID = new System.Windows.Forms.Label();
            this.lblAddPartName = new System.Windows.Forms.Label();
            this.lblAddPartInv = new System.Windows.Forms.Label();
            this.lblAddPartPrice = new System.Windows.Forms.Label();
            this.lblAddPartMin = new System.Windows.Forms.Label();
            this.lblAddPartMax = new System.Windows.Forms.Label();
            this.lblAddPartMachineID = new System.Windows.Forms.Label();
            this.btnAddPartSave = new System.Windows.Forms.Button();
            this.btnAddPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioInHouseAdd
            // 
            this.radioInHouseAdd.AutoSize = true;
            this.radioInHouseAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioInHouseAdd.Location = new System.Drawing.Point(160, 16);
            this.radioInHouseAdd.Name = "radioInHouseAdd";
            this.radioInHouseAdd.Size = new System.Drawing.Size(82, 21);
            this.radioInHouseAdd.TabIndex = 0;
            this.radioInHouseAdd.TabStop = true;
            this.radioInHouseAdd.Text = "In-House";
            this.radioInHouseAdd.UseVisualStyleBackColor = true;
            this.radioInHouseAdd.CheckedChanged += new System.EventHandler(this.radioInHouseAdd_CheckedChanged);
            // 
            // radioOutsourcedAdd
            // 
            this.radioOutsourcedAdd.AutoSize = true;
            this.radioOutsourcedAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioOutsourcedAdd.Location = new System.Drawing.Point(292, 16);
            this.radioOutsourcedAdd.Name = "radioOutsourcedAdd";
            this.radioOutsourcedAdd.Size = new System.Drawing.Size(97, 21);
            this.radioOutsourcedAdd.TabIndex = 1;
            this.radioOutsourcedAdd.TabStop = true;
            this.radioOutsourcedAdd.Text = "Outsourced";
            this.radioOutsourcedAdd.UseVisualStyleBackColor = true;
            this.radioOutsourcedAdd.CheckedChanged += new System.EventHandler(this.radioOutsourcedAdd_CheckedChanged);
            // 
            // lblAddPartTitle
            // 
            this.lblAddPartTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddPartTitle.Location = new System.Drawing.Point(12, 16);
            this.lblAddPartTitle.Name = "lblAddPartTitle";
            this.lblAddPartTitle.Size = new System.Drawing.Size(128, 35);
            this.lblAddPartTitle.TabIndex = 2;
            this.lblAddPartTitle.Text = "Add Part";
            // 
            // txtAddPartID
            // 
            this.txtAddPartID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddPartID.Location = new System.Drawing.Point(165, 83);
            this.txtAddPartID.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddPartID.Name = "txtAddPartID";
            this.txtAddPartID.Size = new System.Drawing.Size(174, 29);
            this.txtAddPartID.TabIndex = 3;
            this.txtAddPartID.TextChanged += new System.EventHandler(this.txtAddPartID_TextChanged);
            // 
            // txtAddPartPrice
            // 
            this.txtAddPartPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddPartPrice.Location = new System.Drawing.Point(165, 251);
            this.txtAddPartPrice.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddPartPrice.Name = "txtAddPartPrice";
            this.txtAddPartPrice.Size = new System.Drawing.Size(174, 29);
            this.txtAddPartPrice.TabIndex = 4;
            this.txtAddPartPrice.TextChanged += new System.EventHandler(this.txtAddPartPrice_TextChanged);
            // 
            // txtAddPartMachineID
            // 
            this.txtAddPartMachineID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddPartMachineID.Location = new System.Drawing.Point(165, 363);
            this.txtAddPartMachineID.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddPartMachineID.Name = "txtAddPartMachineID";
            this.txtAddPartMachineID.Size = new System.Drawing.Size(174, 29);
            this.txtAddPartMachineID.TabIndex = 5;
            this.txtAddPartMachineID.TextChanged += new System.EventHandler(this.txtAddPartMachineID_TextChanged);
            // 
            // txtAddPartInv
            // 
            this.txtAddPartInv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddPartInv.Location = new System.Drawing.Point(165, 196);
            this.txtAddPartInv.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddPartInv.Name = "txtAddPartInv";
            this.txtAddPartInv.Size = new System.Drawing.Size(174, 29);
            this.txtAddPartInv.TabIndex = 6;
            this.txtAddPartInv.TextChanged += new System.EventHandler(this.txtAddPartInv_TextChanged);
            // 
            // txtAddPartName
            // 
            this.txtAddPartName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddPartName.Location = new System.Drawing.Point(165, 140);
            this.txtAddPartName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddPartName.Name = "txtAddPartName";
            this.txtAddPartName.Size = new System.Drawing.Size(174, 29);
            this.txtAddPartName.TabIndex = 7;
            this.txtAddPartName.TextChanged += new System.EventHandler(this.txtAddPartName_TextChanged);
            // 
            // txtAddPartMax
            // 
            this.txtAddPartMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddPartMax.Location = new System.Drawing.Point(165, 306);
            this.txtAddPartMax.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddPartMax.Name = "txtAddPartMax";
            this.txtAddPartMax.Size = new System.Drawing.Size(77, 29);
            this.txtAddPartMax.TabIndex = 8;
            this.txtAddPartMax.TextChanged += new System.EventHandler(this.txtAddPartMax_TextChanged);
            // 
            // txtAddPartMin
            // 
            this.txtAddPartMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddPartMin.Location = new System.Drawing.Point(342, 306);
            this.txtAddPartMin.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddPartMin.Name = "txtAddPartMin";
            this.txtAddPartMin.Size = new System.Drawing.Size(77, 29);
            this.txtAddPartMin.TabIndex = 9;
            this.txtAddPartMin.TextChanged += new System.EventHandler(this.txtAddPartMin_TextChanged);
            // 
            // lblAddPartID
            // 
            this.lblAddPartID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddPartID.Location = new System.Drawing.Point(60, 90);
            this.lblAddPartID.Name = "lblAddPartID";
            this.lblAddPartID.Size = new System.Drawing.Size(80, 23);
            this.lblAddPartID.TabIndex = 10;
            this.lblAddPartID.Text = "Part ID";
            // 
            // lblAddPartName
            // 
            this.lblAddPartName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddPartName.Location = new System.Drawing.Point(71, 147);
            this.lblAddPartName.Name = "lblAddPartName";
            this.lblAddPartName.Size = new System.Drawing.Size(69, 23);
            this.lblAddPartName.TabIndex = 11;
            this.lblAddPartName.Text = "Name";
            // 
            // lblAddPartInv
            // 
            this.lblAddPartInv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddPartInv.Location = new System.Drawing.Point(40, 203);
            this.lblAddPartInv.Name = "lblAddPartInv";
            this.lblAddPartInv.Size = new System.Drawing.Size(100, 23);
            this.lblAddPartInv.TabIndex = 12;
            this.lblAddPartInv.Text = "Inventory";
            // 
            // lblAddPartPrice
            // 
            this.lblAddPartPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddPartPrice.Location = new System.Drawing.Point(23, 258);
            this.lblAddPartPrice.Name = "lblAddPartPrice";
            this.lblAddPartPrice.Size = new System.Drawing.Size(100, 23);
            this.lblAddPartPrice.TabIndex = 13;
            this.lblAddPartPrice.Text = "Price / Cost";
            this.lblAddPartPrice.Click += new System.EventHandler(this.lblAddPartPrice_Click);
            // 
            // lblAddPartMin
            // 
            this.lblAddPartMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddPartMin.Location = new System.Drawing.Point(276, 313);
            this.lblAddPartMin.Name = "lblAddPartMin";
            this.lblAddPartMin.Size = new System.Drawing.Size(60, 31);
            this.lblAddPartMin.TabIndex = 14;
            this.lblAddPartMin.Text = "Min";
            // 
            // lblAddPartMax
            // 
            this.lblAddPartMax.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddPartMax.Location = new System.Drawing.Point(81, 313);
            this.lblAddPartMax.Name = "lblAddPartMax";
            this.lblAddPartMax.Size = new System.Drawing.Size(59, 23);
            this.lblAddPartMax.TabIndex = 15;
            this.lblAddPartMax.Text = "Max";
            // 
            // lblAddPartMachineID
            // 
            this.lblAddPartMachineID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddPartMachineID.Location = new System.Drawing.Point(23, 370);
            this.lblAddPartMachineID.Name = "lblAddPartMachineID";
            this.lblAddPartMachineID.Size = new System.Drawing.Size(142, 23);
            this.lblAddPartMachineID.TabIndex = 16;
            this.lblAddPartMachineID.Text = "Machine ID";
            this.lblAddPartMachineID.Click += new System.EventHandler(this.lblAddPartMachineID_Click);
            // 
            // btnAddPartSave
            // 
            this.btnAddPartSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPartSave.Location = new System.Drawing.Point(261, 409);
            this.btnAddPartSave.Name = "btnAddPartSave";
            this.btnAddPartSave.Size = new System.Drawing.Size(75, 30);
            this.btnAddPartSave.TabIndex = 17;
            this.btnAddPartSave.Text = "Save";
            this.btnAddPartSave.UseVisualStyleBackColor = true;
            this.btnAddPartSave.Click += new System.EventHandler(this.BtnAddPartSave_Click);
            // 
            // btnAddPartCancel
            // 
            this.btnAddPartCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPartCancel.Location = new System.Drawing.Point(344, 409);
            this.btnAddPartCancel.Name = "btnAddPartCancel";
            this.btnAddPartCancel.Size = new System.Drawing.Size(75, 30);
            this.btnAddPartCancel.TabIndex = 18;
            this.btnAddPartCancel.Text = "Cancel";
            this.btnAddPartCancel.UseVisualStyleBackColor = true;
            this.btnAddPartCancel.Click += new System.EventHandler(this.btnAddPartCancel_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 481);
            this.Controls.Add(this.btnAddPartCancel);
            this.Controls.Add(this.btnAddPartSave);
            this.Controls.Add(this.lblAddPartMachineID);
            this.Controls.Add(this.lblAddPartMax);
            this.Controls.Add(this.lblAddPartMin);
            this.Controls.Add(this.lblAddPartPrice);
            this.Controls.Add(this.lblAddPartInv);
            this.Controls.Add(this.lblAddPartName);
            this.Controls.Add(this.lblAddPartID);
            this.Controls.Add(this.txtAddPartMin);
            this.Controls.Add(this.txtAddPartMax);
            this.Controls.Add(this.txtAddPartName);
            this.Controls.Add(this.txtAddPartInv);
            this.Controls.Add(this.txtAddPartMachineID);
            this.Controls.Add(this.txtAddPartPrice);
            this.Controls.Add(this.txtAddPartID);
            this.Controls.Add(this.lblAddPartTitle);
            this.Controls.Add(this.radioOutsourcedAdd);
            this.Controls.Add(this.radioInHouseAdd);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioInHouseAdd;
        private System.Windows.Forms.RadioButton radioOutsourcedAdd;
        private System.Windows.Forms.Label lblAddPartTitle;
        private System.Windows.Forms.TextBox txtAddPartID;
        private System.Windows.Forms.TextBox txtAddPartPrice;
        private System.Windows.Forms.TextBox txtAddPartMachineID;
        private System.Windows.Forms.TextBox txtAddPartInv;
        private System.Windows.Forms.TextBox txtAddPartName;
        private System.Windows.Forms.TextBox txtAddPartMax;
        private System.Windows.Forms.TextBox txtAddPartMin;
        private System.Windows.Forms.Label lblAddPartID;
        private System.Windows.Forms.Label lblAddPartName;
        private System.Windows.Forms.Label lblAddPartInv;
        private System.Windows.Forms.Label lblAddPartPrice;
        private System.Windows.Forms.Label lblAddPartMin;
        private System.Windows.Forms.Label lblAddPartMax;
        private System.Windows.Forms.Label lblAddPartMachineID;
        private System.Windows.Forms.Button btnAddPartSave;
        private System.Windows.Forms.Button btnAddPartCancel;
    }
}