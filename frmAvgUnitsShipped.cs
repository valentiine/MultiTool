using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valentine.sah_project
{
    public partial class frmAvgUnitsShipped : Form
    {
        int employeeCount = 1;
        int dayCount = 1;
        const int MAX_EMPLOYEES = 4;
        const int MAX_DAYS = 8;

        Boolean checker;

        double emp1 = 0;
        double emp2 = 0;
        double emp3 = 0;

        int[,] basicArray = new int[MAX_EMPLOYEES, MAX_DAYS];

        public frmAvgUnitsShipped()
        {
            InitializeComponent();
        }

private void btnEnter_Click(object sender, EventArgs e)
        {
            checker = true;
            if (employeeCount == 1 && isValid(txtUnits, 0, 1000) && checker == true)
            {
                lblDay.Text = "Day: " + dayCount;
                lblEmployee1.Font = new Font(lblEmployee1.Font, FontStyle.Bold);


                int z = int.Parse(txtUnits.Text);
                basicArray[employeeCount, dayCount] = z;
                dayCount++;

                lbxUnits1.Items.Add(txtUnits.Text);

                double unitsAvg = 0;
                double sum = 0;
                int lstCount = lbxUnits1.Items.Count;

                if (dayCount == MAX_DAYS)
                {
                    for (int i = 0; i < lstCount; i++)
                    {
                        sum += Convert.ToDouble(lbxUnits1.Items[i]);
                    }

                    unitsAvg = Math.Round((sum / lstCount), 2);
                    txtAverage1.Text = "Average : " + unitsAvg;

                    emp1 = unitsAvg;

                    employeeCount++;
                    dayCount = 1;
                    checker = false;
                    txtUnits.Text = "  ";
                    lblDay.Text = "Day: 1";
                    lblEmployee1.Font = new Font(lblEmployee1.Font, FontStyle.Regular);
                    lblEmployee2.Font = new Font(lblEmployee2.Font, FontStyle.Bold);
                }
                txtUnits.Text = "  ";
            }

            checker = true;

            if (employeeCount == 2 && isValid(txtUnits, 0, 1000) && checker == true)
            {
                lblDay.Text = "Day: " + dayCount;

                int f = int.Parse(txtUnits.Text);
                basicArray[employeeCount, dayCount] = f;
                dayCount++;

                lbxUnits2.Items.Add(txtUnits.Text);

                double unitsAvg2 = 0;
                double sum2 = 0;
                int lstCount2 = lbxUnits2.Items.Count;

                if (dayCount == MAX_DAYS)
                {
                    for (int q = 0; q < lstCount2; q++)
                    {
                        sum2 += Convert.ToDouble(lbxUnits2.Items[q]);
                    }

                    unitsAvg2 = Math.Round((sum2 / lstCount2), 2);
                    txtAverage2.Text = "Average : " + unitsAvg2;

                    emp2 = unitsAvg2;

                    employeeCount++;
                    dayCount = 1;
                    checker = false;
                    txtUnits.Text = "  ";
                    lblDay.Text = "Day: 1";
                    lblEmployee2.Font = new Font(lblEmployee2.Font, FontStyle.Regular);
                    lblEmployee3.Font = new Font(lblEmployee3.Font, FontStyle.Bold);
                }
                txtUnits.Text = "  ";
            }

            checker = true;

            if (employeeCount == 3 && isValid(txtUnits, 0, 1000) && checker == true)
            {
                lblDay.Text = "Day: " + dayCount;

                int g = int.Parse(txtUnits.Text);
                basicArray[employeeCount, dayCount] = g;
                dayCount++;

                lbxUnits3.Items.Add(txtUnits.Text);

                double unitsAvg3 = 0;
                double sum3 = 0;
                int lstCount3 = lbxUnits3.Items.Count;

                if (dayCount == MAX_DAYS)
                {
                    for (int r = 0; r < lstCount3; r++)
                    {
                        sum3 += Convert.ToDouble(lbxUnits3.Items[r]);
                    }

                    unitsAvg3 = Math.Round((sum3 / lstCount3), 2);
                    txtAverage3.Text = "Average : " + unitsAvg3;

                    emp3 = unitsAvg3;

                    lblDay.Text = "Done";
                    employeeCount++;
                    checker = false;
                    txtUnits.Text = "  ";
                    lblEmployee3.Font = new Font(lblEmployee3.Font, FontStyle.Regular);
                }
                txtUnits.Text = "  ";
            }

            if (dayCount == MAX_DAYS && employeeCount == MAX_EMPLOYEES)
            {
                txtUnits.ReadOnly = true;
                btnEnter.Enabled = false;

                employeeCount = 1;

                double employeesSum = emp1 + emp2 + emp3;
                double division = MAX_EMPLOYEES - employeeCount;

                double allAverages = Math.Round((employeesSum / division), 2);

                txtResult.Text = "Average per day: " + allAverages;
            }
        }
    

        

        private bool isValid(TextBox textBox, int min, int max)
        {
            return (isPresent(textBox)
                    && isInt(textBox)
                    && isWithinRange(textBox, min, max));

        }

        private bool isPresent(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show("Please enter a valid integer");
                txtUnits.Focus();
                return false;
            }
            return true;
        }

        private bool isInt(TextBox textbox)
        {
            int val = 0;
            if (int.TryParse(txtUnits.Text, out val))
            {
                return true;
            }
            MessageBox.Show("Please enter a whole number unit for employee: " + employeeCount);
            txtUnits.Focus();
            txtUnits.Clear();
            return false;
        }

        private bool isWithinRange(TextBox textbox, int min, int max)
        {
            int number = Convert.ToInt32(((TextBox)textbox).Text);
            if (number < min || number > max)
            {
                MessageBox.Show("Please ensure the units shipped are between 0 and 1000!");
                txtUnits.Focus();
                txtUnits.Clear();
                return false;
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnEnter.Enabled = true;

            txtUnits.ReadOnly = false;
            txtUnits.Focus();

            txtAverage1.Clear();
            txtAverage2.Clear();
            txtAverage3.Clear();

            txtResult.Clear();

            lbxUnits1.Items.Clear();
            lbxUnits2.Items.Clear();
            lbxUnits3.Items.Clear();

            basicArray = new int[MAX_EMPLOYEES, MAX_DAYS];
            employeeCount = 1;
            dayCount = 1;

            lblDay.Text = "Day: 1";
            lblEmployee1.Font = new Font(lblEmployee1.Font, FontStyle.Bold);
            lblEmployee2.Font = new Font(lblEmployee2.Font, FontStyle.Regular);
            lblEmployee3.Font = new Font(lblEmployee3.Font, FontStyle.Regular);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
