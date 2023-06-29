namespace Final_Exam__Net_Pay_Calculator_Balisbis //this is your project name. it is automatically created as you create your project at first.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare constant variable
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
            // Convert input values to numeric and assign to variable.
             salary = double.Parse(txtSalary.Text);     
                try {
                    marital_status = txtMaritalStatus.Text;
                    try { 
                        // Convert input values to numeric and assign to variable.
                        dependents = int.Parse(txtDependents.Text);

                        // Conditional Statements under single
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
                        // Conditional Statement under married
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

                        // Calculation to get tax and net pay
                        incomeTax = tax + ((double)SUB_INCOME_TAX * dependents);
                        netPay = salary - incomeTax;

                        //Display output
                        txtTax.Text = incomeTax.ToString("0.00");
                        txtNetPay.Text = netPay.ToString("0.00");

                    } catch {
                        // Show invalid message when invalid input occurs
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
