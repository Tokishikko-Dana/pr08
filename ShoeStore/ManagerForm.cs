using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class ManagerForm : Form
    {
        private DataGridView dataGridViewProducts;
        private Label lblTitle;
        private TextBox txtSearch;
        private ComboBox cmbSortBy;
        private ComboBox cmbFilterBy;
        private Button btnSearch;
        private Label lblSearch;
        private Label lblSort;
        private Label lblFilter;
        private Button btnBack;
        private DataTable productsTable;

        public ManagerForm()
        {
            InitializeComponent();
            SetupEventHandlers();
            InitializeSampleData();
            InitializeComboBoxes();
        }
    }
}
