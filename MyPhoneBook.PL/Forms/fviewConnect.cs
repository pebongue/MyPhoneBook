using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPhoneBook.PL.Forms
{
    public partial class fviewConnect : Form
    {
        #region: login variables declaration
        private static fviewConnect _fviewConnect = null;
        private static Object _synchRoot = new object();
        private int diff_x;
        private int diff_y;
        private bool mouse_down = false;
        #endregion end variable declaration

        private fviewConnect()
        {
            InitializeComponent();
        }

        #region: Public properties for this form
        /// <summary>
        /// check the status of the form
        /// </summary>
        public static fviewConnect CheckInstConnect
        {
            get
            {
                return _fviewConnect;
            }
        }
        /// <summary>
        /// return a single copy of the form at any time
        /// </summary>
        public static fviewConnect CreateInstConnect
        {
            get
            {
                if (_fviewConnect == null)
                {
                    lock (_synchRoot)
                    {
                        if (_fviewConnect == null)
                            _fviewConnect = new fviewConnect();
                    }
                }
                return _fviewConnect;
            }
        }
        /// <summary>
        /// make sure that the form is properly closed by overriding the this.Onclose(...)
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            _fviewConnect = null;
            base.OnClosed(e);
        }
        #endregion end public property for this form

        #region: Login Code
        private void picboxConnect_MouseDown(object sender, MouseEventArgs e)
        {
            diff_x = Form.MousePosition.X - Form.ActiveForm.Location.X;
            diff_y = Form.MousePosition.Y - Form.ActiveForm.Location.Y; mouse_down = true; 
        }

        private void picboxConnect_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down == true)
            {
                Point p = new Point(MousePosition.X - diff_x, MousePosition.Y - diff_y);
                Form.ActiveForm.Location = p;
            }
        }

        private void picboxConnect_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false; 
        }
        /// <summary>
        /// on login connect button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoginConnectClick(object sender, EventArgs e)
        {
            if (cbLoginUsername.SelectedIndex >= 0)
            {
                if (txtLoginPassword.Text.Length != 0)
                {
                    LoginUser();
                }
                else
                {
                    MessageBox.Show("Please enter your password.", "Password Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select your login name.", "Username Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// login user
        /// </summary>
        private void LoginUser()
        {
            if (txtLoginPassword.Text.Equals("admin"))
            {
                MessageBox.Show("Successful login");
            }
            else
            {
                MessageBox.Show(this, "Wrong username and / or password.\nPlease check login details.", "Invalid User Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion end login code

        private void OnPwdKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter) && (txtLoginPassword.Text.Length != 0))
            {
                LoginUser();
            }
        }
    }
}
