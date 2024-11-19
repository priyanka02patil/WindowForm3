namespace WindowForm3
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnBinRead = new System.Windows.Forms.Button();
            this.btnBinWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(100, 72);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(69, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Enter ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(100, 137);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(94, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Enter Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(100, 201);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(87, 20);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Enter Price";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(270, 66);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(211, 26);
            this.textID.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(270, 137);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(211, 26);
            this.textName.TabIndex = 4;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(270, 201);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(211, 26);
            this.textPrice.TabIndex = 5;
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(104, 351);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(146, 49);
            this.btnXmlWrite.TabIndex = 6;
            this.btnXmlWrite.Text = "Xml Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(104, 442);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(146, 51);
            this.btnSoapWrite.TabIndex = 7;
            this.btnSoapWrite.Text = "SOAP Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(341, 351);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(140, 49);
            this.btnXmlRead.TabIndex = 8;
            this.btnXmlRead.Text = "Xml Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnBinRead
            // 
            this.btnBinRead.Location = new System.Drawing.Point(341, 264);
            this.btnBinRead.Name = "btnBinRead";
            this.btnBinRead.Size = new System.Drawing.Size(140, 49);
            this.btnBinRead.TabIndex = 9;
            this.btnBinRead.Text = "Binary Read";
            this.btnBinRead.UseVisualStyleBackColor = true;
            this.btnBinRead.Click += new System.EventHandler(this.btnBinRead_Click);
            // 
            // btnBinWrite
            // 
            this.btnBinWrite.Location = new System.Drawing.Point(104, 264);
            this.btnBinWrite.Name = "btnBinWrite";
            this.btnBinWrite.Size = new System.Drawing.Size(146, 49);
            this.btnBinWrite.TabIndex = 10;
            this.btnBinWrite.Text = "Binary Write";
            this.btnBinWrite.UseVisualStyleBackColor = true;
            this.btnBinWrite.Click += new System.EventHandler(this.btnBinWrite_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(341, 442);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(140, 51);
            this.btnSoapRead.TabIndex = 11;
            this.btnSoapRead.Text = "SOAP Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(697, 66);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 57);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(331, 529);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(150, 51);
            this.btnJsonRead.TabIndex = 13;
            this.btnJsonRead.Text = "JSON Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.btnJsonRead_Click);
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Location = new System.Drawing.Point(104, 529);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(146, 51);
            this.btnJsonWrite.TabIndex = 14;
            this.btnJsonWrite.Text = "JSON Write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            this.btnJsonWrite.Click += new System.EventHandler(this.btnJsonWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 634);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnBinWrite);
            this.Controls.Add(this.btnBinRead);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnBinRead;
        private System.Windows.Forms.Button btnBinWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnJsonRead;
        private System.Windows.Forms.Button btnJsonWrite;
    }
}

