using System;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class FrmPin : Form
    {
        private readonly Information.Information _infos;
        private string noNumber = "Pls enter only numbers!";
        private int fails = 0;
        private int trys = 3;

        public FrmPin()
        {
            InitializeComponent();
            _infos = new Information.Information();
        }

        /// <summary>
        /// By converting the string to a int, it will check if it is a number or not
        /// </summary>
        /// <param name="pinNumber"></param>
        /// <returns>
        /// a bool statement
        /// </returns>
        private bool isDigital(string pinNumber)
        {
            int x;
            try
            {
                x = Convert.ToInt32(pinNumber);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        // TODO IDEEN Wirtes in log that somebody failed and how often with time
        private void tbxPin1_TextChanged(object sender, EventArgs e)
        {
            // Only accept numbers and move to next Textbox
            if (isDigital(tbxPin1.Text))
            {
               lblErrorNumber.Visible = false;
               tbxPin2.Focus();
            }
            else if (tbxPin1.Text != "")
            {
               lblErrorNumber.Visible = true;
               lblErrorNumber.Text = noNumber;
               tbxPin1.Clear();
            }
        }
        private void tbxPin2_TextChanged(object sender, EventArgs e)
        {
            // Only accept numbers and move to next Textbox 
            if (isDigital(tbxPin2.Text))
            {
                lblErrorNumber.Visible = false;
                tbxPin3.Focus();
            }
            else if(tbxPin2.Text != "")
            {
                lblErrorNumber.Visible = true;
                lblErrorNumber.Text = noNumber;
                tbxPin2.Clear();
            }
        }
        private void tbxPin3_TextChanged(object sender, EventArgs e)
        {
            // Only accept numbers and move to next Textbox 
            if (isDigital(tbxPin3.Text))
            {
                lblErrorNumber.Visible = false;
                tbxPin4.Focus();
            }
            else if(tbxPin3.Text != "")
            {
                lblErrorNumber.Visible = true;
                lblErrorNumber.Text = noNumber;
                tbxPin3.Clear();
            }
        }
        private void tbxPin4_TextChanged(object sender, EventArgs e)
        {
            // will cancel it if too many tries
            if (fails == trys)
            {
                this.Close();
            }

            // Only accept numbers and show admin form
            if (isDigital(tbxPin4.Text))
            {
                lblErrorNumber.Visible = false;
                string number = tbxPin1.Text + tbxPin2.Text + tbxPin3.Text + tbxPin4.Text;
                
                if (number == _infos.ReadPin())
                {
                    // Login 
                    this.Close();
                    new FrmAdmin().ShowDialog();
                }
                else
                {
                    tbxPin1.Text = "";
                    tbxPin2.Text = "";
                    tbxPin3.Text = "";
                    tbxPin4.Text = "";
                    tbxPin1.Focus();
                    lblErrorNumber.Visible = false;

                    fails++;
                    lblErrorTrys.Visible = true;
                    lblErrorTrys.Text = $"You have {trys - fails} trys left!";
                }
            }
            else
            {
                lblErrorNumber.Visible = true;
                lblErrorNumber.Text = noNumber;
                tbxPin4.Clear();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbxPin2_KeyUp(object sender, KeyEventArgs e)
        {
            // After "Back" Key was pressed, Clear Textbox and move on Textbox back
            if (e.KeyCode == Keys.Back)
            {
                tbxPin1.Clear();
                tbxPin1.Focus();
            }
        }
        private void tbxPin3_KeyUp(object sender, KeyEventArgs e)
        {
            // After "Back" Key was pressed, Clear Textbox and move on Textbox back
            if (e.KeyCode == Keys.Back)
            {
                tbxPin2.Clear();
                tbxPin2.Focus();
            }
        }
        private void tbxPin4_KeyUp(object sender, KeyEventArgs e)
        {
            // After "Back" Key was pressed, Clear Textbox and move on Textbox back
            if (e.KeyCode == Keys.Back)
            {
                tbxPin3.Clear();
                tbxPin3.Focus();
            }
        }
    }
}
