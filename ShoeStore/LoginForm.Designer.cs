namespace ShoeStore
{
    partial class LoginForm
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
            this.Text = "LoginForm";

            // Настройка формы
            this.Text = "ООО «Обувь» - Авторизация";
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Заголовок
            lblTitle = new Label();
            lblTitle.Text = "Вход в систему";
            lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTitle.Size = new Size(200, 30);
            lblTitle.Location = new Point(100, 30);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Поле логина
            lblUsername = new Label();
            lblUsername.Text = "Логин:";
            lblUsername.Size = new Size(80, 20);
            lblUsername.Location = new Point(50, 100);

            txtUsername = new TextBox();
            txtUsername.Size = new Size(250, 20);
            txtUsername.Location = new Point(50, 120);

            // Поле пароля
            lblPassword = new Label();
            lblPassword.Text = "Пароль:";
            lblPassword.Size = new Size(80, 20);
            lblPassword.Location = new Point(50, 160);

            txtPassword = new TextBox();
            txtPassword.Size = new Size(250, 20);
            txtPassword.Location = new Point(50, 180);
            txtPassword.PasswordChar = '*';

            // Кнопка входа
            btnLogin = new Button();
            btnLogin.Text = "Войти";
            btnLogin.Size = new Size(120, 35);
            btnLogin.Location = new Point(50, 230);
            btnLogin.BackColor = Color.LightBlue;

            // Кнопка гостя
            btnGuest = new Button();
            btnGuest.Text = "Войти как гость";
            btnGuest.Size = new Size(120, 35);
            btnGuest.Location = new Point(180, 230);
            btnGuest.BackColor = Color.LightGray;

            // Добавление элементов на форму
            this.Controls.AddRange(new Control[] {
                lblTitle, lblUsername, txtUsername,
                lblPassword, txtPassword, btnLogin, btnGuest
            });
        }

        private void SetupEventHandlers()
        {
            // Обработчик для кнопки входа
            btnLogin.Click += (sender, e) =>
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                // Простая проверка авторизации (для демонстрации)
                if (AuthenticateUser(username, password))
                {
                    OpenUserForm(username);
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Обработчик для кнопки гостя
            btnGuest.Click += (sender, e) =>
            {
                OpenGuestForm();
            };

            // Обработчик для нажатия Enter в полях ввода
            txtPassword.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnLogin.PerformClick();
                    e.Handled = true;
                }
            };
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Временная логика авторизации для демонстрации
            // В реальном приложении здесь будет проверка в базе данных
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            // Демо-логины для тестирования
            if (username == "admin" && password == "admin")
                return true;
            if (username == "manager" && password == "manager")
                return true;
            if (username == "user" && password == "user")
                return true;

            return false;
        }

        private void OpenUserForm(string username)
        {
            Form userForm = null;

            // Определяем тип пользователя и открываем соответствующую форму
            if (username == "admin")
            {
                userForm = new AdminForm();
            }
            else if (username == "manager")
            {
                userForm = new ManagerForm();
            }
            else
            {
                userForm = new GuestForm(); // Для обычных пользователей
            }

            // Настройка формы пользователя
            userForm.StartPosition = FormStartPosition.CenterScreen;

            // Подписываемся на событие закрытия формы пользователя
            userForm.FormClosed += (s, args) => this.Show();

            // Показываем форму пользователя и скрываем форму авторизации
            this.Hide();
            userForm.Show();
        }

        private void OpenGuestForm()
        {
            GuestForm guestForm = new GuestForm();
            guestForm.StartPosition = FormStartPosition.CenterScreen;

            // Подписываемся на событие закрытия гостевой формы
            guestForm.FormClosed += (s, args) => this.Show();

            // Показываем гостевую форму и скрываем форму авторизации
            this.Hide();
            guestForm.Show();
        }
    }
    #endregion
}