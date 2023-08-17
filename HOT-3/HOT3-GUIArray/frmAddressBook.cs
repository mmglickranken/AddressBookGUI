using System;
using System.Windows.Forms;

namespace HOT3_GUIArray
{
    public partial class frmAddressBook : Form
    {
        public frmAddressBook()
        {
            InitializeComponent();
        }

        // Delcare and initialize program global constants.
        const decimal MINSALARY = 2500m;
        const decimal MAXSALARY = 100000m;

        string[] firstNames =
        {
            "Markel", "Luiza", "Byrony", "Giraldo", "Lowri"
        };

        string[] lastNames =
        {
            "Diggory", "Gunnar", "Hester", "Addy", "Hari"
        };

        string[] salaries =
        {
            "$54321.00", "$88732.00", "$66778.00", "$33445.00", "$99883.00"
        };

        private void btnFirst_Click(object sender, EventArgs e)
        {
            SearchForValidFirstName();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            SearchForValidLastName();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            SearchForValidSalary();
        }

        private void SearchForValidFirstName()
        {
            string term = (txtGeneral.Text);

            // Validate the prescence of text in textbox.
            string errorMessage = IsPresent(term, "firstName", txtGeneral);

            // No text was inputted, display error message.
            if (errorMessage != "")
            {
                ShowErrorMessage(errorMessage, "Error");

                return;
            }

            // Verify that text inputted is non-numeric.
            if (Decimal.TryParse(term, out _))
            {
                ShowErrorMessage("first name must be non-numeric","Error");
            }

            for (int i = 0; i < firstNames.Length; i++)
            {
                if ((firstNames[i].ToLower()).Contains(term.ToLower()))
                {
                    txtFirst.Text  = firstNames[i];
                    txtLast.Text   =  lastNames[i];
                    txtSalary.Text =   salaries[i];

                    return;
                }
            }

            // There was no match for the inputted first name, display error in textboxes.
            ShowNoData();
        }

        private void SearchForValidLastName()
        {
            string term = txtGeneral.Text;

            // Validate the prescence of text in textbox.
            string errorMessage = IsPresent(term, "lastName", txtGeneral);

            // No text was inputted, display error message.
            if (errorMessage != "")
            {
                ShowErrorMessage(errorMessage, "Error");

                return;
            }

            // Verify that text inputted is non-numeric.
            if (Decimal.TryParse(term, out _))
            {
                ShowErrorMessage("last name must be non-numeric", "Error");
            }

            for (int i = 0; i < lastNames.Length; i++)
            {
                if ((lastNames[i].ToLower()).Contains(term.ToLower()))
                {
                    txtFirst.Text  = firstNames[i];
                    txtLast.Text   =  lastNames[i];
                    txtSalary.Text =   salaries[i];

                    return;
                }
            }

            // There was no match for the inputted first name, display error in textboxes.
            ShowNoData();
        }

        private void SearchForValidSalary()
        {
            string term = txtGeneral.Text;

            // Validate the prescence of text in textbox.
            string errorMessage = IsPresent(term, "salary", txtGeneral);

            // No text was inputted, display error message.
            if (errorMessage != "")
            {
                ShowErrorMessage(errorMessage, "Error");

                return;
            }

            // Validate that the text inputted is a decimal.
            errorMessage = IsDecimal(term, "salary", txtGeneral);

            // A non-decimal was inputted, display error message.
            if (errorMessage != "")
            {
                ShowErrorMessage(errorMessage, "Error");

                return;
            }

            // Validate that the text inputted is within range.
            errorMessage = IsWithinRange(term, "salary", MINSALARY, MAXSALARY, txtGeneral);

            // If text inputted is not within range, then display error message.
            if (errorMessage != "")
            {
                ShowErrorMessage(errorMessage, "Error");

                return;
            }

            for (int i = 0; i < salaries.Length; i++)
            {
                if ((salaries[i]).Contains(term))
                {
                    txtFirst.Text  = firstNames[i];
                    txtLast.Text   =  lastNames[i];
                    txtSalary.Text =   salaries[i];

                    return;
                }
            }

            // There was no match for the inputted first name, display error in textboxes.
            ShowNoData();
        }

        // Validate the presence or absence of text in the control textbox. 
        private string IsPresent(string value, string name, Control ctrl)
        {
            string msg = "";

            if (value.Trim() == "")
            {
                msg = name + " is a required field.\n";
                ClearAndSetFocusToCorrectControl(ctrl);
            }

            return msg;
        }

        // Validate the control textbox text is a decimal.
        private string IsDecimal(string value, string name, Control ctrl)
        {
            string msg = "";

            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
                ClearAndSetFocusToCorrectControl(ctrl);
            }

            return msg;
        }

        // Validate the control textbox is between the min and max.
        private string IsWithinRange(string value, string name, decimal min, decimal max, Control ctrl)
        {
            string  msg = "";
            decimal salary;

            if (Decimal.TryParse(value, out salary))
            {
                if ((salary < min) || (salary > max))
                {
                    msg = name + " must be between " + min + " and " + max + ".\n";
                    ClearAndSetFocusToCorrectControl(ctrl);
                }
            }

            return msg;
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void ClearAndSetFocusToCorrectControl(Control ctrl)
        {
            ctrl.Text = "";

            ctrl.Focus();
        }

        private void ShowNoData()
        {
            txtFirst.Text   = "Error!";
            txtLast.Text    = "Error!";
            txtSalary.Text  = "Error!";

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
