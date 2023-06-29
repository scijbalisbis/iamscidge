namespace Final_Exam__Net_Pay_Calculator_Balisbis
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnCompute = new Button();
            txtDependents = new TextBox();
            txtMaritalStatus = new TextBox();
            txtSalary = new TextBox();
            txtEmployeeName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTax = new TextBox();
            txtNetPay = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCompute);
            groupBox1.Controls.Add(txtDependents);
            groupBox1.Controls.Add(txtMaritalStatus);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(txtEmployeeName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Details";
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompute.Location = new Point(382, 109);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(145, 66);
            btnCompute.TabIndex = 10;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // txtDependents
            // 
            txtDependents.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDependents.Location = new Point(204, 159);
            txtDependents.Name = "txtDependents";
            txtDependents.Size = new Size(63, 27);
            txtDependents.TabIndex = 7;
            // 
            // txtMaritalStatus
            // 
            txtMaritalStatus.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaritalStatus.Location = new Point(204, 119);
            txtMaritalStatus.Name = "txtMaritalStatus";
            txtMaritalStatus.Size = new Size(125, 27);
            txtMaritalStatus.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(204, 80);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(125, 27);
            txtSalary.TabIndex = 5;
            txtSalary.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeeName.Location = new Point(204, 41);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(339, 27);
            txtEmployeeName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 166);
            label4.Name = "label4";
            label4.Size = new Size(101, 19);
            label4.TabIndex = 3;
            label4.Text = "Dependents:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 122);
            label3.Name = "label3";
            label3.Size = new Size(112, 19);
            label3.TabIndex = 2;
            label3.Text = "Marital Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 87);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 1;
            label2.Text = "Salary:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 48);
            label1.Name = "label1";
            label1.Size = new Size(133, 19);
            label1.TabIndex = 0;
            label1.Text = "Employee Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(58, 264);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 4;
            label5.Text = "Tax:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(58, 309);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 5;
            label6.Text = "Net Pay:";
            // 
            // txtTax
            // 
            txtTax.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTax.Location = new Point(227, 261);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(125, 30);
            txtTax.TabIndex = 8;
            txtTax.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNetPay
            // 
            txtNetPay.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNetPay.Location = new Point(227, 306);
            txtNetPay.Name = "txtNetPay";
            txtNetPay.ReadOnly = true;
            txtNetPay.Size = new Size(125, 30);
            txtNetPay.TabIndex = 9;
            txtNetPay.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 365);
            Controls.Add(txtTax);
            Controls.Add(txtNetPay);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weekly Payroll";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCompute;
        private TextBox txtDependents;
        private TextBox txtMaritalStatus;
        private TextBox txtSalary;
        private TextBox txtEmployeeName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox txtTax;
        private TextBox txtNetPay;
    }
}