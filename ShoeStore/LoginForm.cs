using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnGuest;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;

        public LoginForm()
        {
            InitializeComponent();
            SetupEventHandlers();
        }
    }
}
