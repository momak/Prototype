namespace Prototype
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
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblDoorNo = new System.Windows.Forms.Label();
            this.txtDoorNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShollowCopy = new System.Windows.Forms.Button();
            this.btnDeepCopy = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(114, 50);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(163, 26);
            this.txtEmpId.TabIndex = 0;
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(30, 50);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(60, 20);
            this.lblEmpId.TabIndex = 1;
            this.lblEmpId.Text = "Emp Id";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(18, 97);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(88, 20);
            this.lblEmpName.TabIndex = 3;
            this.lblEmpName.Text = "Emp Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(114, 97);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(163, 26);
            this.txtEmpName.TabIndex = 2;
            // 
            // lblDoorNo
            // 
            this.lblDoorNo.AutoSize = true;
            this.lblDoorNo.Location = new System.Drawing.Point(30, 206);
            this.lblDoorNo.Name = "lblDoorNo";
            this.lblDoorNo.Size = new System.Drawing.Size(68, 20);
            this.lblDoorNo.TabIndex = 5;
            this.lblDoorNo.Text = "Door No";
            // 
            // txtDoorNo
            // 
            this.txtDoorNo.Location = new System.Drawing.Point(114, 206);
            this.txtDoorNo.Name = "txtDoorNo";
            this.txtDoorNo.Size = new System.Drawing.Size(163, 26);
            this.txtDoorNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Street No";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(114, 256);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(163, 26);
            this.txtStreet.TabIndex = 6;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(30, 300);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(73, 20);
            this.lblZip.TabIndex = 9;
            this.lblZip.Text = "Zip Code";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(114, 300);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(163, 26);
            this.txtZip.TabIndex = 8;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(30, 345);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(64, 20);
            this.lblCountry.TabIndex = 11;
            this.lblCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(114, 345);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(163, 26);
            this.txtCountry.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(76, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShollowCopy
            // 
            this.btnShollowCopy.Location = new System.Drawing.Point(321, 66);
            this.btnShollowCopy.Name = "btnShollowCopy";
            this.btnShollowCopy.Size = new System.Drawing.Size(136, 39);
            this.btnShollowCopy.TabIndex = 13;
            this.btnShollowCopy.Text = "Shallow Copy";
            this.btnShollowCopy.UseVisualStyleBackColor = true;
            this.btnShollowCopy.Click += new System.EventHandler(this.btnShollowCopy_Click);
            // 
            // btnDeepCopy
            // 
            this.btnDeepCopy.Location = new System.Drawing.Point(321, 126);
            this.btnDeepCopy.Name = "btnDeepCopy";
            this.btnDeepCopy.Size = new System.Drawing.Size(136, 39);
            this.btnDeepCopy.TabIndex = 14;
            this.btnDeepCopy.Text = "Deep Copy";
            this.btnDeepCopy.UseVisualStyleBackColor = true;
            this.btnDeepCopy.Click += new System.EventHandler(this.btnDeepCopy_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(321, 193);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 39);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(785, 629);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 39);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(850, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(58, 20);
            this.lblOutput.TabIndex = 17;
            this.lblOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(593, 47);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(521, 576);
            this.txtOutput.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 699);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeepCopy);
            this.Controls.Add(this.btnShollowCopy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblDoorNo);
            this.Controls.Add(this.txtDoorNo);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.txtEmpId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblDoorNo;
        private System.Windows.Forms.TextBox txtDoorNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShollowCopy;
        private System.Windows.Forms.Button btnDeepCopy;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

