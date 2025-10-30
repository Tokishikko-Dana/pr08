namespace ShoeStore
{
    partial class GuestForm
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
            this.Text = "GuestForm";


            // Настройка формы
            this.Text = "ООО «Обувь» - Просмотр товаров (Гость)";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Заголовок
            lblTitle = new Label();
            lblTitle.Text = "Каталог обуви - Гостевой доступ";
            lblTitle.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTitle.Size = new Size(400, 30);
            lblTitle.Location = new Point(200, 20);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Кнопка возврата
            btnBack = new Button();
            btnBack.Text = "Выйти";
            btnBack.Size = new Size(100, 35);
            btnBack.Location = new Point(350, 540);
            btnBack.BackColor = Color.LightGray;

            // DataGridView для товаров
            dataGridViewProducts = new DataGridView();
            dataGridViewProducts.Location = new Point(50, 70);
            dataGridViewProducts.Size = new Size(700, 450);
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Добавление колонок (пример структуры)
            dataGridViewProducts.Columns.Add("Name", "Название");
            dataGridViewProducts.Columns.Add("Brand", "Бренд");
            dataGridViewProducts.Columns.Add("Size", "Размер");
            dataGridViewProducts.Columns.Add("Price", "Цена");
            dataGridViewProducts.Columns.Add("Quantity", "Количество");

            // Добавление элементов на форму
            this.Controls.AddRange(new Control[] {
                lblTitle, dataGridViewProducts
            });
        }
        private void SetupEventHandlers()
        {
            // Обработчик для кнопки возврата
            btnBack.Click += (sender, e) =>
            {
                this.Close();
            };
        }

        #endregion
    }
}