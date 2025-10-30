using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class AdminForm : Form
    {
        private DataGridView dataGridViewProducts;
        private Label lblTitle;
        private Label lblName;
        private Label lblBrand;
        private Label lblSize;
        private Label lblPrice;
        private Label lblQuantity;
        private TextBox txtName;
        private TextBox txtBrand;
        private TextBox txtSize;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private GroupBox grpEdit;
        private Button btnBack;
        private Button btnClear;
        private DataTable productsTable;
        private int currentEditId = -1;
        public AdminForm()
        {
            InitializeComponent();
            SetupEventHandlers();
            InitializeSampleData();
        }
    }
}
