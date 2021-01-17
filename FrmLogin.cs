using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using GameLauncher.Handler;
using GameLauncher.Objects;

namespace GameLauncher
{
    public partial class FrmLogin : Form
    {
        private static readonly Information.Information Infos = new Information.Information();
        private readonly string _pathPin = Infos.PathPin;
        private bool _isLogin = false;

        private List<Person> _users;

        public FrmLogin()
        {
            InitializeComponent();

            // Gets all Users
            _users = FileHandler.GetActiveUserList();
        }

        /// <summary>
        /// Checks if the user exists and if so if the password is right => next Form
        /// </summary>
        private void LoginMethode()
        {
            try
            {
                // Update users list to only the Active Users
                _users = FileHandler.GetActiveUserList();
            }
            catch (Exception)
            {
                // ignored
            }

            string name = tbxName.Text;
            string password = tbxPassword.Text;

            if (!CheckBoxes(name, password))
            {
                return;
            }

            foreach (Person user in _users)
            {
                if (user.Name != name) continue;

                if (user.Password == password)
                {
                    // Jackpot == Login
                    Information.User.Name = user.Name;
                    Information.User.Password = user.Password;
                    Information.User.Age = user.Age;
                    _isLogin = true;
                    this.Close();
                }
                else
                {
                    errorProvider.SetError(tbxPassword, "Password is wrong");
                    return;
                }
            }

            errorProvider.SetError(tbxName, "Username doesnt Exist");
        }

        /// <summary>
        /// Checks if textboxes are not empty
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>
        /// a bool depending it is ok
        /// </returns>
        private bool CheckBoxes(string name, string password)
        {
            // Checks if name & password are not correct

            if (tbxName.Text != null && tbxPassword.Text != null && (tbxName.Text == "" || tbxPassword.Text == ""))
            {
                errorProvider.SetError(tbxName, "Enter name or password!");
                errorProvider.SetError(tbxPassword, "Enter name or password!");
                return false;
            }

            if (!IsNameAndPaswwort(name, password))
            {
                errorProvider.SetError(tbxName, "Name or Password contains letter {@!;:\"+#} which you cannot use!");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if Textboxes contain any of these ("@", ";", "!", ":", "\"", "+" ,"#") charaters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="passowrt"></param>
        /// <returns>
        /// a bool depending if it is right
        /// </returns>
        private bool IsNameAndPaswwort(string name, string passowrt)
        {
            // Checks if these letter are included in name / password
            string[] notAllowed = { "@", ";", "!", ":", "\"", "+", "#" };

            foreach (string value in notAllowed)
            {
                if (name.Contains(value))
                {
                    return false;
                }

                if (passowrt.Contains(value))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            // Needs Admin pin to create user
            if (!File.Exists(_pathPin)) 
            {
                // if the file doesnt exists it will create one with a random Pin
                Infos.WritePin();
            }

            // Will only show the admin View if the pin was entered right!
            new FrmPin().ShowDialog();

        }
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isLogin)
            {
                // Asks what to close
                switch (DialogResult = MessageBox.Show("Close all?", "Closing", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.OK:
                        Environment.Exit(0);
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
        #region BtnShow Methods

        private void btnShowPassword_MouseEnter(object sender, EventArgs e)
        {
            // If cursor moves to this Button 
            tbxPassword.UseSystemPasswordChar = false;
        }

        private void btnShowPassword_MouseLeave(object sender, EventArgs e)
        {
            // If cursor leaves to this Button
            tbxPassword.UseSystemPasswordChar = true;
        }

        #endregion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginMethode();
        }
        private void tbxName_KeyUp(object sender, KeyEventArgs e)
        {
            // if "Enter" key was pressed move to next Textbox
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) && tbxName.Text.Trim().Length > 0)
            {
                tbxPassword.Focus();
            }
        }
        private void tbxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            // Can directly login after key enter was pressed
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) && tbxName.Text.Trim().Length > 0)
            {
                LoginMethode();
            }
        }
    }
}
