namespace Final_Exam__Net_Pay_Calculator_Balisbis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const decimal SUB_INCOME_TAX = 61.54m;

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double salary;
            string marital_status;
            int dependents;
            double tax = 0;
            double netPay;
            double incomeTax;

        try {
             salary = double.Parse(txtSalary.Text);     
                try {
                    marital_status = txtMaritalStatus.Text;
                    try { 
                        dependents = int.Parse(txtDependents.Text);

                        if (marital_status == "Single")
                        {
                            if (salary <= 606)
                            {
                                tax = 0;
                            }
                            else if (salary <= 1341)
                            {
                                tax = 76.40 + (salary * 606) * 0.1;
                            }
                            else if (salary <= 4922)
                            {
                                tax = 260.15 + (salary - 1341) * 0.18;
                            }
                            else if (salary <= 6313)
                            {
                                tax = 702.83 + (salary - 4922) * 0.23;
                            }
                            else if (salary >= 6316)
                            {
                                tax = 1821.86 + (salary - 6316) * 0.25;
                            }
                        }
                        if (marital_status == "Married")
                        {
                            if (salary <= 1273)
                            {
                                tax = 0;
                            }
                            else if (salary <= 2322)
                            {
                                tax = 153.80 + (salary - 1273) * 0.05;
                            }
                            else if (salary <= 3646)
                            {
                                tax = 416.05 + (salary - 2322) * 0.08;
                            }
                            else if (salary <= 6409)
                            {
                                tax = 786.77 + (salary - 3646) * 0.13;
                            }
                            else
                            {
                                tax = 1698.56 + (salary - 6409) * 0.16;
                            }
                        }

                        incomeTax = tax + ((double)SUB_INCOME_TAX * dependents);
                        netPay = salary - incomeTax;

                        //Display output
                        txtTax.Text = incomeTax.ToString("0.00");
                        txtNetPay.Text = netPay.ToString("0.00");

                    } catch {
                        MessageBox.Show("Invalid Dependents.", "Data Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDependents.Focus();
                        txtDependents.SelectAll();
                    }
                } catch {
                    MessageBox.Show("Invalid Marital Status.", "Data Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaritalStatus.Focus();
                    txtMaritalStatus.SelectAll();
                }
            } catch {
                MessageBox.Show("Invalid Salary.", "Data Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                txtSalary.SelectAll();
            }           
        }
    }
}