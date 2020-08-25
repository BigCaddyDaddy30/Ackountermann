namespace Ackountermann
{
    partial class vendorInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendorInputForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblVendorAddress = new System.Windows.Forms.Label();
            this.lblVendorPhone = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorAddress = new System.Windows.Forms.TextBox();
            this.txtVendorPhone = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(713, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorID.Location = new System.Drawing.Point(197, 19);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(86, 20);
            this.lblVendorID.TabIndex = 2;
            this.lblVendorID.Text = "Vendor ID:";
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorName.Location = new System.Drawing.Point(172, 83);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(111, 20);
            this.lblVendorName.TabIndex = 3;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblVendorAddress
            // 
            this.lblVendorAddress.AutoSize = true;
            this.lblVendorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorAddress.Location = new System.Drawing.Point(211, 148);
            this.lblVendorAddress.Name = "lblVendorAddress";
            this.lblVendorAddress.Size = new System.Drawing.Size(72, 20);
            this.lblVendorAddress.TabIndex = 4;
            this.lblVendorAddress.Text = "Address:";
            // 
            // lblVendorPhone
            // 
            this.lblVendorPhone.AutoSize = true;
            this.lblVendorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorPhone.Location = new System.Drawing.Point(164, 401);
            this.lblVendorPhone.Name = "lblVendorPhone";
            this.lblVendorPhone.Size = new System.Drawing.Size(119, 20);
            this.lblVendorPhone.TabIndex = 5;
            this.lblVendorPhone.Text = "Phone Number:";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(289, 21);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(346, 20);
            this.txtVendorID.TabIndex = 6;
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(289, 85);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(346, 20);
            this.txtVendorName.TabIndex = 7;
            // 
            // txtVendorAddress
            // 
            this.txtVendorAddress.Location = new System.Drawing.Point(289, 150);
            this.txtVendorAddress.Name = "txtVendorAddress";
            this.txtVendorAddress.Size = new System.Drawing.Size(346, 20);
            this.txtVendorAddress.TabIndex = 8;
            // 
            // txtVendorPhone
            // 
            this.txtVendorPhone.Location = new System.Drawing.Point(289, 403);
            this.txtVendorPhone.Name = "txtVendorPhone";
            this.txtVendorPhone.Size = new System.Drawing.Size(346, 20);
            this.txtVendorPhone.TabIndex = 9;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(244, 214);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(231, 275);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(52, 20);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "State:";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipcode.Location = new System.Drawing.Point(213, 341);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(70, 20);
            this.lblZipcode.TabIndex = 12;
            this.lblZipcode.Text = "Zipcode:";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(289, 343);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(346, 20);
            this.txtZipcode.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(289, 216);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(346, 20);
            this.txtCity.TabIndex = 14;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(289, 277);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(346, 20);
            this.txtState.TabIndex = 15;
            // 
            // vendorInputForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.lblZipcode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtVendorPhone);
            this.Controls.Add(this.txtVendorAddress);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.lblVendorPhone);
            this.Controls.Add(this.lblVendorAddress);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "vendorInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Vendor Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblVendorAddress;
        private System.Windows.Forms.Label lblVendorPhone;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtVendorAddress;
        private System.Windows.Forms.TextBox txtVendorPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
    }
}