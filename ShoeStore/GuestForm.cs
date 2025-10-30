using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class GuestForm : Form
    {
        private DataGridView dataGridViewProducts;
        private Label lblTitle;
        private Button btnBack;

        public GuestForm()
        {
            InitializeComponent();
            SetupEventHandlers();
        }

    }
}
