
namespace Grishkova_vkr_PortApp
{
    partial class SignIn_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.аккаунтTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.АккаунтTableAdapter();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(67, 210);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 28);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(10, 68);
            this.login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(47, 17);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Логин";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(10, 134);
            this.pass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(57, 17);
            this.pass_label.TabIndex = 2;
            this.pass_label.Text = "Пароль";
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(13, 89);
            this.login_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(209, 23);
            this.login_textBox.TabIndex = 0;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_textBox.Location = new System.Drawing.Point(13, 154);
            this.pass_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.Size = new System.Drawing.Size(209, 23);
            this.pass_textBox.TabIndex = 1;
            this.pass_textBox.UseSystemPasswordChar = true;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(92, 27);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(47, 20);
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Вход";
            // 
            // аккаунтTableAdapter1
            // 
            this.аккаунтTableAdapter1.ClearBeforeFill = true;
            // 
            // SignIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 283);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SignIn_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Label headerLabel;
        private demoDataSetTableAdapters.АккаунтTableAdapter аккаунтTableAdapter1;
    }
}

