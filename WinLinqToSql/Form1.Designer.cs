
namespace WinLinqToSql
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.btnEmpDetails = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 154);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "EmpId";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(129, 11);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 20);
            this.txtEmpId.TabIndex = 2;
            // 
            // btnEmpDetails
            // 
            this.btnEmpDetails.Location = new System.Drawing.Point(488, 341);
            this.btnEmpDetails.Name = "btnEmpDetails";
            this.btnEmpDetails.Size = new System.Drawing.Size(97, 23);
            this.btnEmpDetails.TabIndex = 3;
            this.btnEmpDetails.Text = "ShowEmpDetail";
            this.btnEmpDetails.UseVisualStyleBackColor = true;
            this.btnEmpDetails.Click += new System.EventHandler(this.btnEmpDetails_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 383);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(78, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Count Of Emps";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(359, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DeleteEmp";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(237, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "UpdateEmpDetail";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "EmpName";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(129, 50);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 9;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(129, 86);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 10;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(129, 124);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 11;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(32, 93);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 12;
            this.lblSalary.Text = "Salary";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(32, 131);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(30, 13);
            this.lblDept.TabIndex = 13;
            this.lblDept.Text = "Dept";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(129, 341);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 23);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "InsertEmpDet";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnEmpDetails);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Button btnEmpDetails;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Button btnInsert;
    }
}

