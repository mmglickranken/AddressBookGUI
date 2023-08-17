using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace HOT3GUILists
{
    public partial class frmAddressBook : Form
    {
        public frmAddressBook()
        {
            InitializeComponent();
        }

        // Declare and initialize global program constants.
        const decimal MINSALARY = 2500m;
        const decimal MAXSALARY = 100000m;

        // Declare and initialize global program lists.
        List<string> firstNames = new List<string>()
        {
            "Markel", "Luiza", "Byrony", "Giraldo", "Lowri"
        };

        List<string> lastNames = new List<string>()
        {
            "Diggory", "Gunnar", "Hester", "Addy", "Hari"
        };

        List<string> salaries = new List<string>()
        {
            "$54321.00", "$88732.00", "$66778.00", "$33445.00", "$99883.00"
        };

        private void btnFirst_Click(object sender, EventArgs e)
        {
            ValidateAndSearchForFirstName();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            ValidateAndSearchForLastName();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            ValidateAndSearchForSalary();
        }

        private void ValidateAndSearchForFirstName()
        {
            string term = txtGeneral.Text;

            try
            {
                if (term == "")
                {
                    throw new FormatException();
                }
                
                // Verify that the inputted search value is non-numeric and not empty.
                else if (Decimal.TryParse(term, out _))
                {
                    throw new FormatException();
                }

                for (int i = 0; i < salaries.Count; i++)
                {
                    if ((firstNames[i].ToLower()).Contains(term.ToLower()))
                    {

                        txtFirst.Text  = firstNames[i];
                        txtLast.Text   =  lastNames[i];
                        txtSalary.Text =   salaries[i];

                        return;
                    }

                    else
                    {
                        ShowNoData();
                    }
                }
            }

            catch (FormatException fe)
            {
                ShowErrorMessage("Illegal search value!\n" + fe.Message,
                                 "Search Value Blank Or Numeric");

                txtGeneral.Text = "";

                txtGeneral.Focus();

                return;
            }
        }

        private void ValidateAndSearchForLastName()
        {
            string term = txtGeneral.Text;

            try
            {
                if (term == "")
                {
                    throw new FormatException();
                }

                // Verify that the inputted search value is non-numeric.
                else if (Decimal.TryParse(term, out _))
                {
                    throw new FormatException();
                }

                for (int i = 0; i < salaries.Count; i++)
                {
                    if ((lastNames[i].ToLower()).Contains(term.ToLower()))
                    {

                        txtFirst.Text  = firstNames[i];
                        txtLast.Text   =  lastNames[i];
                        txtSalary.Text =   salaries[i];

                        return;
                    }

                    else
                    {
                        ShowNoData();
                    }
                }
            }

            catch (FormatException fe)
            {
                ShowErrorMessage("Illegal search value!\n" + fe.Message,
                                 "Search Value Blank Or Numeric");

                txtGeneral.Text = "";

                txtGeneral.Focus();

                return;
            }
        }

        private void ValidateAndSearchForSalary()
        {
            string term = txtGeneral.Text;

            try
            {
                if (term == "")
                {
                    throw new FormatException();
                }

                // Attempt to convert the inputted search value into a decimal.
                decimal value = Convert.ToDecimal(term);

                // Verify that the inputted search value is within range.
                if ((value < MINSALARY) || (value > MAXSALARY))
                {
                    throw new ArgumentOutOfRangeException();
                }

                for (int i = 0; i < salaries.Count; i++)
                {
                    if (salaries[i].Contains(term))
                    {

                        txtFirst.Text  = firstNames[i];
                        txtLast.Text   =  lastNames[i];
                        txtSalary.Text =   salaries[i];

                        return;
                    }

                    else
                    {
                        ShowNoData();
                    }
                }
            }

            catch(FormatException fe)
            {
                ShowErrorMessage("Illegal search value!\n" + fe.Message,
                                 "Search Value Blank Or Non-Numeric");

                txtGeneral.Text = "";

                txtGeneral.Focus();

                return;
            }

            catch (ArgumentOutOfRangeException aoore)
            {
                ShowErrorMessage("Out-of-range salary! Salary must be between $2,500.00 and $100,000.00\n" + aoore.Message,
                                 "Salary Out-Of-Range.");

                txtGeneral.Text = "";

                txtGeneral.Focus();

                return;
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void ShowNoData()
        {
            txtFirst.Text   = "Error!";
            txtLast.Text    = "Error!";
            txtSalary.Text  = "Error!";
            txtGeneral.Text = "";

            txtGeneral.Focus();
        }

        private void ClearGeneral()
        {
            txtGeneral.Text = "";

            txtGeneral.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtFirst.Text   = "";
            txtLast.Text    = "";
            txtSalary.Text  = "";
            txtGeneral.Text = "";

            txtGeneral.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Exit The Program?",
                                                  "Exit Now?",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
