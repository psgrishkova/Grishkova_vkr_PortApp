
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
            this.button1 = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.pass_label2 = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
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
            // pass_label2
            // 
            this.pass_label2.AutoSize = true;
            this.pass_label2.Location = new System.Drawing.Point(10, 134);
            this.pass_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass_label2.Name = "pass_label2";
            this.pass_label2.Size = new System.Drawing.Size(57, 17);
            this.pass_label2.TabIndex = 2;
            this.pass_label2.Text = "Пароль";
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(13, 89);
            this.login_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(209, 23);
            this.login_textBox.TabIndex = 3;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_textBox.Location = new System.Drawing.Point(13, 154);
            this.pass_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.Size = new System.Drawing.Size(209, 23);
            this.pass_textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вход";
            // 
            // SignIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.pass_label2);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SignIn_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label pass_label2;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Label label1;
    }
}

