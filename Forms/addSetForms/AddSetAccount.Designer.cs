
namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    partial class AddSetAccount
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
            this.save_button = new System.Windows.Forms.Button();
            this.role_comboBox = new System.Windows.Forms.ComboBox();
            this.role_label = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(53, 110);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // role_comboBox
            // 
            this.role_comboBox.FormattingEnabled = true;
            this.role_comboBox.Items.AddRange(new object[] {
            "Менеджер",
            "Директор"});
            this.role_comboBox.Location = new System.Drawing.Point(62, 18);
            this.role_comboBox.Name = "role_comboBox";
            this.role_comboBox.Size = new System.Drawing.Size(100, 21);
            this.role_comboBox.TabIndex = 1;
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Location = new System.Drawing.Point(24, 21);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(32, 13);
            this.role_label.TabIndex = 2;
            this.role_label.Text = "Роль";
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(62, 45);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(100, 20);
            this.login_textBox.TabIndex = 3;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(18, 48);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(38, 13);
            this.login_label.TabIndex = 4;
            this.login_label.Text = "Логин";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(11, 74);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(45, 13);
            this.pass_label.TabIndex = 6;
            this.pass_label.Text = "Пароль";
            // 
            // pass_textBox
            // 
            this.pass_textBox.Location = new System.Drawing.Point(62, 71);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.Size = new System.Drawing.Size(100, 20);
            this.pass_textBox.TabIndex = 5;
            // 
            // AddSetAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 145);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.role_label);
            this.Controls.Add(this.role_comboBox);
            this.Controls.Add(this.save_button);
            this.MaximizeBox = false;
            this.Name = "AddSetAccount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аккаунт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox role_comboBox;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox pass_textBox;
    }
}