namespace HOT3GUILists
{
    partial class frmAddressBook
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtGeneral = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(260, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(91, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.Location = new System.Drawing.Point(456, 216);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(176, 35);
            this.btnSalary.TabIndex = 3;
            this.btnSalary.Tag = "salary";
            this.btnSalary.Text = "Search Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(456, 156);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(176, 35);
            this.btnLast.TabIndex = 2;
            this.btnLast.Tag = "lastName";
            this.btnLast.Text = "Search Last Name";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(456, 96);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(176, 35);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Tag = "firstName";
            this.btnFirst.Text = "Search First Name";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(190, 244);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(223, 26);
            this.txtSalary.TabIndex = 8;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(190, 187);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(223, 26);
            this.txtLast.TabIndex = 7;
            this.txtLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(190, 129);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(223, 26);
            this.txtFirst.TabIndex = 6;
            this.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGeneral
            // 
            this.txtGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneral.Location = new System.Drawing.Point(33, 75);
            this.txtGeneral.Name = "txtGeneral";
            this.txtGeneral.Size = new System.Drawing.Size(380, 26);
            this.txtGeneral.TabIndex = 0;
            this.txtGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalary
            // 
            this.lblSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(29, 242);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(143, 31);
            this.lblSalary.TabIndex = 12;
            this.lblSalary.Text = "Salary:";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLast
            // 
            this.lblLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(29, 185);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(143, 31);
            this.lblLast.TabIndex = 11;
            this.lblLast.Text = "Last Name:";
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirst
            // 
            this.lblFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(29, 124);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(143, 31);
            this.lblFirst.TabIndex = 10;
            this.lblFirst.Text = "First Name:";
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeneral
            // 
            this.lblGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.Location = new System.Drawing.Point(33, 30);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(380, 31);
            this.lblGeneral.TabIndex = 9;
            this.lblGeneral.Text = "First Name, Last Name, or Salary";
            this.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHOT3GUILists
            // 
            this.AcceptButton = this.btnFirst;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(662, 394);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtGeneral);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblGeneral);
            this.Name = "frmHOT3GUILists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book 2 - Lists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtGeneral;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblGeneral;
    }
}

