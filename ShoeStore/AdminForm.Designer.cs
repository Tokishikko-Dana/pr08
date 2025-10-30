using System.Data;

namespace ShoeStore
{
    partial class AdminForm
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
            // Настройка формы
            this.Text = "ООО «Обувь» - Администрирование товаров";
            this.Size = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Заголовок
            lblTitle = new Label();
            lblTitle.Text = "Администрирование товаров";
            lblTitle.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTitle.Size = new Size(400, 30);
            lblTitle.Location = new Point(300, 20);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // DataGridView для товаров
            dataGridViewProducts = new DataGridView();
            dataGridViewProducts.Location = new Point(50, 70);
            dataGridViewProducts.Size = new Size(600, 400);
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Группа для редактирования
            grpEdit = new GroupBox();
            grpEdit.Text = "Редактирование товара";
            grpEdit.Size = new Size(300, 400);
            grpEdit.Location = new Point(670, 70);

            // Поля для ввода
            lblName = new Label();
            lblName.Text = "Название:";
            lblName.Size = new Size(80, 20);
            lblName.Location = new Point(20, 40);

            txtName = new TextBox();
            txtName.Size = new Size(200, 20);
            txtName.Location = new Point(20, 60);

            lblBrand = new Label();
            lblBrand.Text = "Бренд:";
            lblBrand.Size = new Size(80, 20);
            lblBrand.Location = new Point(20, 100);

            txtBrand = new TextBox();
            txtBrand.Size = new Size(200, 20);
            txtBrand.Location = new Point(20, 120);

            lblSize = new Label();
            lblSize.Text = "Размер:";
            lblSize.Size = new Size(80, 20);
            lblSize.Location = new Point(20, 160);

            txtSize = new TextBox();
            txtSize.Size = new Size(200, 20);
            txtSize.Location = new Point(20, 180);

            lblPrice = new Label();
            lblPrice.Text = "Цена:";
            lblPrice.Size = new Size(80, 20);
            lblPrice.Location = new Point(20, 220);

            txtPrice = new TextBox();
            txtPrice.Size = new Size(200, 20);
            txtPrice.Location = new Point(20, 240);

            lblQuantity = new Label();
            lblQuantity.Text = "Количество:";
            lblQuantity.Size = new Size(80, 20);
            lblQuantity.Location = new Point(20, 280);

            txtQuantity = new TextBox();
            txtQuantity.Size = new Size(200, 20);
            txtQuantity.Location = new Point(20, 300);

            // Кнопка очистки
            btnClear = new Button();
            btnClear.Text = "Очистить";
            btnClear.Size = new Size(80, 25);
            btnClear.Location = new Point(140, 340);
            btnClear.BackColor = Color.LightGray;

            // Кнопки управления
            btnAdd = new Button();
            btnAdd.Text = "Добавить";
            btnAdd.Size = new Size(120, 35);
            btnAdd.Location = new Point(50, 500);
            btnAdd.BackColor = Color.LightGreen;

            btnEdit = new Button();
            btnEdit.Text = "Редактировать";
            btnEdit.Size = new Size(120, 35);
            btnEdit.Location = new Point(180, 500);
            btnEdit.BackColor = Color.LightYellow;

            btnDelete = new Button();
            btnDelete.Text = "Удалить";
            btnDelete.Size = new Size(120, 35);
            btnDelete.Location = new Point(310, 500);
            btnDelete.BackColor = Color.LightCoral;

            // Кнопка возврата
            btnBack = new Button();
            btnBack.Text = "Выйти";
            btnBack.Size = new Size(100, 35);
            btnBack.Location = new Point(450, 500);
            btnBack.BackColor = Color.LightGray;

            // Добавление элементов в группу
            grpEdit.Controls.AddRange(new Control[] {
                lblName, txtName, lblBrand, txtBrand,
                lblSize, txtSize, lblPrice, txtPrice,
                lblQuantity, txtQuantity, btnClear
            });

            // Добавление элементов на форму
            this.Controls.AddRange(new Control[] {
                lblTitle, dataGridViewProducts, grpEdit,
                btnAdd, btnEdit, btnDelete, btnBack
            });
        }

        private void InitializeSampleData()
        {
            // Создаем таблицу с демо-данными
            productsTable = new DataTable();
            productsTable.Columns.Add("Id", typeof(int));
            productsTable.Columns.Add("Name", typeof(string));
            productsTable.Columns.Add("Brand", typeof(string));
            productsTable.Columns.Add("Size", typeof(string));
            productsTable.Columns.Add("Price", typeof(decimal));
            productsTable.Columns.Add("Quantity", typeof(int));

            // Добавляем демо-данные
            productsTable.Rows.Add(1, "Кроссовки белые", "Nike", "42", 4999, 10);
            productsTable.Rows.Add(2, "Туфли черные", "ECCO", "41", 7999, 5);
            productsTable.Rows.Add(3, "Ботинки зимние", "Salomon", "43", 12999, 3);
            productsTable.Rows.Add(4, "Кеды красные", "Converse", "40", 3999, 8);
            productsTable.Rows.Add(5, "Сапоги женские", "Ralf Ringer", "38", 8999, 4);

            dataGridViewProducts.DataSource = productsTable;

            // Скрываем колонку Id
            dataGridViewProducts.Columns["Id"].Visible = false;
        }

        private void SetupEventHandlers()
        {
            // Обработчик для кнопки возврата
            btnBack.Click += (sender, e) =>
            {
                this.Close();
            };

            // Обработчик для кнопки очистки
            btnClear.Click += (sender, e) =>
            {
                ClearForm();
            };

            // Обработчик для кнопки добавления
            btnAdd.Click += (sender, e) =>
            {
                AddProduct();
            };

            // Обработчик для кнопки редактирования
            btnEdit.Click += (sender, e) =>
            {
                EditProduct();
            };

            // Обработчик для кнопки удаления
            btnDelete.Click += (sender, e) =>
            {
                DeleteProduct();
            };

            // Обработчик выбора строки в DataGridView
            dataGridViewProducts.SelectionChanged += (sender, e) =>
            {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridViewProducts.SelectedRows[0];
                    LoadProductToForm(row);
                }
            };

            // Обработчик двойного клика по строке
            dataGridViewProducts.CellDoubleClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                    LoadProductToForm(row);
                }
            };

            // Валидация ввода для числовых полей
            txtPrice.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            };

            txtQuantity.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtBrand.Clear();
            txtSize.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            currentEditId = -1;
            dataGridViewProducts.ClearSelection();
        }

        private void LoadProductToForm(DataGridViewRow row)
        {
            currentEditId = Convert.ToInt32(row.Cells["Id"].Value);
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtBrand.Text = row.Cells["Brand"].Value.ToString();
            txtSize.Text = row.Cells["Size"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Введите бренд товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrand.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSize.Text))
            {
                MessageBox.Show("Введите размер товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSize.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Введите корректное количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }

            return true;
        }

        private void AddProduct()
        {
            if (!ValidateForm()) return;

            try
            {
                // Генерируем новый ID
                int newId = 1;
                if (productsTable.Rows.Count > 0)
                {
                    newId = Convert.ToInt32(productsTable.Compute("MAX(Id)", "")) + 1;
                }

                // Добавляем новую запись
                productsTable.Rows.Add(
                    newId,
                    txtName.Text.Trim(),
                    txtBrand.Text.Trim(),
                    txtSize.Text.Trim(),
                    decimal.Parse(txtPrice.Text),
                    int.Parse(txtQuantity.Text)
                );

                MessageBox.Show("Товар успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении товара: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditProduct()
        {
            if (currentEditId == -1)
            {
                MessageBox.Show("Выберите товар для редактирования", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateForm()) return;

            try
            {
                // Находим и обновляем запись
                DataRow[] rows = productsTable.Select($"Id = {currentEditId}");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    row["Name"] = txtName.Text.Trim();
                    row["Brand"] = txtBrand.Text.Trim();
                    row["Size"] = txtSize.Text.Trim();
                    row["Price"] = decimal.Parse(txtPrice.Text);
                    row["Quantity"] = int.Parse(txtQuantity.Text);

                    MessageBox.Show("Товар успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании товара: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProduct()
        {
            if (currentEditId == -1)
            {
                MessageBox.Show("Выберите товар для удаления", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить этот товар?",
                                       "Подтверждение удаления",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Находим и удаляем запись
                    DataRow[] rows = productsTable.Select($"Id = {currentEditId}");
                    if (rows.Length > 0)
                    {
                        rows[0].Delete();
                        productsTable.AcceptChanges();

                        MessageBox.Show("Товар успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении товара: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}