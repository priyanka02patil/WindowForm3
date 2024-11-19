namespace WindowForm3
{
    partial class FormEmployee
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
            this.labelEmpId = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelEmpSalary = new System.Windows.Forms.Label();
            this.textEmpId = new System.Windows.Forms.TextBox();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.textEmpSal = new System.Windows.Forms.TextBox();
            this.btnBinWrite = new System.Windows.Forms.Button();
            this.btnBinRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnXmlRaed = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmpId
            // 
            this.labelEmpId.AutoSize = true;
            this.labelEmpId.Location = new System.Drawing.Point(45, 62);
            this.labelEmpId.Name = "labelEmpId";
            this.labelEmpId.Size = new System.Drawing.Size(143, 20);
            this.labelEmpId.TabIndex = 0;
            this.labelEmpId.Text = "Enter Employee ID";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(47, 126);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(168, 20);
            this.labelEmpName.TabIndex = 1;
            this.labelEmpName.Text = "Enter Employee Name";
            // 
            // labelEmpSalary
            // 
            this.labelEmpSalary.AutoSize = true;
            this.labelEmpSalary.Location = new System.Drawing.Point(45, 181);
            this.labelEmpSalary.Name = "labelEmpSalary";
            this.labelEmpSalary.Size = new System.Drawing.Size(170, 20);
            this.labelEmpSalary.TabIndex = 2;
            this.labelEmpSalary.Text = "Enter Employee Salary";
            // 
            // textEmpId
            // 
            this.textEmpId.Location = new System.Drawing.Point(252, 53);
            this.textEmpId.Name = "textEmpId";
            this.textEmpId.Size = new System.Drawing.Size(155, 26);
            this.textEmpId.TabIndex = 3;
            // 
            // textEmpName
            // 
            this.textEmpName.Location = new System.Drawing.Point(252, 120);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(155, 26);
            this.textEmpName.TabIndex = 4;
            // 
            // textEmpSal
            // 
            this.textEmpSal.Location = new System.Drawing.Point(252, 175);
            this.textEmpSal.Name = "textEmpSal";
            this.textEmpSal.Size = new System.Drawing.Size(155, 26);
            this.textEmpSal.TabIndex = 5;
            // 
            // btnBinWrite
            // 
            this.btnBinWrite.Location = new System.Drawing.Point(49, 248);
            this.btnBinWrite.Name = "btnBinWrite";
            this.btnBinWrite.Size = new System.Drawing.Size(121, 45);
            this.btnBinWrite.TabIndex = 8;
            this.btnBinWrite.Text = "Binary Write";
            this.btnBinWrite.UseVisualStyleBackColor = true;
            this.btnBinWrite.Click += new System.EventHandler(this.btnBinWrite_Click);
            // 
            // btnBinRead
            // 
            this.btnBinRead.Location = new System.Drawing.Point(252, 248);
            this.btnBinRead.Name = "btnBinRead";
            this.btnBinRead.Size = new System.Drawing.Size(129, 45);
            this.btnBinRead.TabIndex = 9;
            this.btnBinRead.Text = "Binary Read";
            this.btnBinRead.UseVisualStyleBackColor = true;
            this.btnBinRead.Click += new System.EventHandler(this.btnBinRead_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(51, 319);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(119, 43);
            this.btnXmlWrite.TabIndex = 10;
            this.btnXmlWrite.Text = "Xml Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnXmlRaed
            // 
            this.btnXmlRaed.Location = new System.Drawing.Point(252, 319);
            this.btnXmlRaed.Name = "btnXmlRaed";
            this.btnXmlRaed.Size = new System.Drawing.Size(129, 43);
            this.btnXmlRaed.TabIndex = 11;
            this.btnXmlRaed.Text = "Xml Read";
            this.btnXmlRaed.UseVisualStyleBackColor = true;
            this.btnXmlRaed.Click += new System.EventHandler(this.btnXmlRaed_Click);
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(51, 390);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(119, 39);
            this.btnSOAPWrite.TabIndex = 12;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(252, 390);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(129, 39);
            this.btnSOAPRead.TabIndex = 13;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(51, 463);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(119, 42);
            this.btnJSONWrite.TabIndex = 14;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.btnJSONWrite_Click);
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(252, 463);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(129, 42);
            this.btnJSONRead.TabIndex = 15;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(551, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXmlRaed);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnBinRead);
            this.Controls.Add(this.btnBinWrite);
            this.Controls.Add(this.textEmpSal);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.textEmpId);
            this.Controls.Add(this.labelEmpSalary);
            this.Controls.Add(this.labelEmpName);
            this.Controls.Add(this.labelEmpId);
            this.Name = "FormEmployee";
            this.Text = "Employee Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpId;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelEmpSalary;
        private System.Windows.Forms.TextBox textEmpId;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.TextBox textEmpSal;
        private System.Windows.Forms.Button btnBinWrite;
        private System.Windows.Forms.Button btnBinRead;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnXmlRaed;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnJSONRead;
        private System.Windows.Forms.Button btnClear;
    }
}