using System.Data;

namespace ShoeStore
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ManagerForm";

            // Настройка формы
            this.Text = "ООО «Обувь» - Управление товарами (Менеджер)";
            this.Size = new Size(900, 650);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Заголовок
            lblTitle = new Label();
            lblTitle.Text = "Управление товарами - Менеджер";
            lblTitle.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTitle.Size = new Size(400, 30);
            lblTitle.Location = new Point(250, 20);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Поиск
            lblSearch = new Label();
            lblSearch.Text = "Поиск:";
            lblSearch.Size = new Size(50, 20);
            lblSearch.Location = new Point(50, 70);

            txtSearch = new TextBox();
            txtSearch.Size = new Size(200, 20);
            txtSearch.Location = new Point(100, 70);
            txtSearch.PlaceholderText = "Введите поисковый запрос...";

            btnSearch = new Button();
            btnSearch.Text = "Найти";
            btnSearch.Size = new Size(80, 25);
            btnSearch.Location = new Point(310, 70);

            // Сортировка
            lblSort = new Label();
            lblSort.Text = "Сортировка:";
            lblSort.Size = new Size(70, 20);
            lblSort.Location = new Point(400, 70);

            cmbSortBy = new ComboBox();
            cmbSortBy.Size = new Size(150, 20);
            cmbSortBy.Location = new Point(480, 70);
            cmbSortBy.DropDownStyle = ComboBoxStyle.DropDownList;

            // Фильтрация
            lblFilter = new Label();
            lblFilter.Text = "Фильтр:";
            lblFilter.Size = new Size(50, 20);
            lblFilter.Location = new Point(650, 70);

            cmbFilterBy = new ComboBox();
            cmbFilterBy.Size = new Size(150, 20);
            cmbFilterBy.Location = new Point(710, 70);
            cmbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;

            // Кнопка возврата
            btnBack = new Button();
            btnBack.Text = "Выйти";
            btnBack.Size = new Size(100, 35);
            btnBack.Location = new Point(400, 580);
            btnBack.BackColor = Color.LightGray;

            // DataGridView для товаров
            dataGridViewProducts = new DataGridView();
            dataGridViewProducts.Location = new Point(50, 110);
            dataGridViewProducts.Size = new Size(800, 450);
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Добавление колонок
            dataGridViewProducts.Columns.Add("Name", "Название");
            dataGridViewProducts.Columns.Add("Brand", "Бренд");
            dataGridViewProducts.Columns.Add("Size", "Размер");
            dataGridViewProducts.Columns.Add("Price", "Цена");
            dataGridViewProducts.Columns.Add("Quantity", "Количество");

            // Добавление элементов на форму
            this.Controls.AddRange(new Control[] {
                lblTitle, lblSearch, txtSearch, btnSearch,
                lblSort, cmbSortBy, lblFilter, cmbFilterBy,
                dataGridViewProducts
            });
        }
        private void InitializeSampleData()
        {
            // Создаем таблицу с демо-данными
            productsTable = new DataTable();
            productsTable.Columns.Add("Name", typeof(string));
            productsTable.Columns.Add("Brand", typeof(string));
            productsTable.Columns.Add("Size", typeof(string));
            productsTable.Columns.Add("Price", typeof(decimal));
            productsTable.Columns.Add("Quantity", typeof(int));

            // Добавляем демо-данные
            productsTable.Rows.Add("Кроссовки белые", "Nike", "42", 4999, 10);
            productsTable.Rows.Add("Туфли черные", "ECCO", "41", 7999, 5);
            productsTable.Rows.Add("Ботинки зимние", "Salomon", "43", 12999, 3);
            productsTable.Rows.Add("Кеды красные", "Converse", "40", 3999, 8);
            productsTable.Rows.Add("Сапоги женские", "Ralf Ringer", "38", 8999, 4);

            dataGridViewProducts.DataSource = productsTable;
        }

        private void InitializeComboBoxes()
        {
            // Заполняем комбобоксы
            cmbSortBy.Items.AddRange(new object[] {
                "По названию (А-Я)",
                "По названию (Я-А)",
                "По цене (возрастание)",
                "По цене (убывание)",
                "По количеству (возрастание)",
                "По количеству (убывание)"
            });

            cmbFilterBy.Items.AddRange(new object[] {
                "Все бренды",
                "Nike",
                "ECCO",
                "Salomon",
                "Converse",
                "Ralf Ringer"
            });

            if (cmbSortBy.Items.Count > 0) cmbSortBy.SelectedIndex = 0;
            if (cmbFilterBy.Items.Count > 0) cmbFilterBy.SelectedIndex = 0;
        }

        private void SetupEventHandlers()
        {
            // Обработчик для кнопки возврата
            btnBack.Click += (sender, e) =>
            {
                this.Close();
            };

            // Обработчик для кнопки поиска
            btnSearch.Click += (sender, e) =>
            {
                PerformSearch();
            };

            // Обработчик для нажатия Enter в поле поиска
            txtSearch.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    PerformSearch();
                    e.Handled = true;
                }
            };

            // Обработчик для изменения сортировки
            cmbSortBy.SelectedIndexChanged += (sender, e) =>
            {
                ApplySortingAndFiltering();
            };

            // Обработчик для изменения фильтра
            cmbFilterBy.SelectedIndexChanged += (sender, e) =>
            {
                ApplySortingAndFiltering();
            };

            // Обработчик двойного клика по строке
            dataGridViewProducts.CellDoubleClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                    string productName = row.Cells["Name"].Value.ToString();
                    string brand = row.Cells["Brand"].Value.ToString();
                    string price = row.Cells["Price"].Value.ToString();

                    MessageBox.Show($"Товар: {productName}\nБренд: {brand}\nЦена: {price} руб.",
                                  "Информация о товаре",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }

        private void PerformSearch()
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                // Если поиск пустой, показываем все данные
                dataGridViewProducts.DataSource = productsTable;
                ApplySortingAndFiltering();
                return;
            }

            // Фильтруем данные по поисковому запросу
            DataView filteredView = productsTable.DefaultView;
            filteredView.RowFilter = $"Name LIKE '%{searchText}%' OR Brand LIKE '%{searchText}%'";

            dataGridViewProducts.DataSource = filteredView;
            ApplySortingAndFiltering();
        }

        private void ApplySortingAndFiltering()
        {
            if (dataGridViewProducts.DataSource == null) return;

            DataView dataView = dataGridViewProducts.DataSource as DataView;
            if (dataView == null) return;

            // Применяем сортировку
            string sortExpression = "";
            switch (cmbSortBy.SelectedItem?.ToString())
            {
                case "По названию (А-Я)":
                    sortExpression = "Name ASC";
                    break;
                case "По названию (Я-А)":
                    sortExpression = "Name DESC";
                    break;
                case "По цене (возрастание)":
                    sortExpression = "Price ASC";
                    break;
                case "По цене (убывание)":
                    sortExpression = "Price DESC";
                    break;
                case "По количеству (возрастание)":
                    sortExpression = "Quantity ASC";
                    break;
                case "По количеству (убывание)":
                    sortExpression = "Quantity DESC";
                    break;
            }

            // Применяем фильтрацию по бренду
            string brandFilter = cmbFilterBy.SelectedItem?.ToString();
            if (brandFilter != null && brandFilter != "Все бренды")
            {
                dataView.RowFilter = $"Brand = '{brandFilter}'";
            }
            else
            {
                dataView.RowFilter = "";
            }

            dataView.Sort = sortExpression;
        }

        #endregion
    }
}