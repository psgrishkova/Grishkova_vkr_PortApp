
namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    partial class AddSetStaffForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.role_comboBox = new System.Windows.Forms.ComboBox();
            this.tel_label = new System.Windows.Forms.Label();
            this.bday_label = new System.Windows.Forms.Label();
            this.bday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.role_label = new System.Windows.Forms.Label();
            this.tel_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(117, 139);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_button_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(77, 24);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(34, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "ФИО";
            // 
            // role_comboBox
            // 
            this.role_comboBox.FormattingEnabled = true;
            this.role_comboBox.Items.AddRange(new object[] {
            "Капитан",
            "Менеджер",
            "Кассир",
            "Директор",
            "Водитель бензовоза"});
            this.role_comboBox.Location = new System.Drawing.Point(117, 99);
            this.role_comboBox.Name = "role_comboBox";
            this.role_comboBox.Size = new System.Drawing.Size(190, 21);
            this.role_comboBox.TabIndex = 4;
            // 
            // tel_label
            // 
            this.tel_label.AutoSize = true;
            this.tel_label.Location = new System.Drawing.Point(82, 50);
            this.tel_label.Name = "tel_label";
            this.tel_label.Size = new System.Drawing.Size(29, 13);
            this.tel_label.TabIndex = 4;
            this.tel_label.Text = "Тел.";
            // 
            // bday_label
            // 
            this.bday_label.AutoSize = true;
            this.bday_label.Location = new System.Drawing.Point(25, 76);
            this.bday_label.Name = "bday_label";
            this.bday_label.Size = new System.Drawing.Size(86, 13);
            this.bday_label.TabIndex = 6;
            this.bday_label.Text = "Дата рождения";
            // 
            // bday_dateTimePicker
            // 
            this.bday_dateTimePicker.Location = new System.Drawing.Point(117, 73);
            this.bday_dateTimePicker.Name = "bday_dateTimePicker";
            this.bday_dateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.bday_dateTimePicker.TabIndex = 3;
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Location = new System.Drawing.Point(46, 102);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(65, 13);
            this.role_label.TabIndex = 8;
            this.role_label.Text = "Должность";
            // 
            // tel_maskedTextBox
            // 
            this.tel_maskedTextBox.Location = new System.Drawing.Point(117, 47);
            this.tel_maskedTextBox.Mask = "8(000)0000000";
            this.tel_maskedTextBox.Name = "tel_maskedTextBox";
            this.tel_maskedTextBox.Size = new System.Drawing.Size(190, 20);
            this.tel_maskedTextBox.TabIndex = 2;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(117, 21);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(190, 20);
            this.name_textBox.TabIndex = 1;
            // 
            // AddSetStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 174);
            this.Controls.Add(this.tel_maskedTextBox);
            this.Controls.Add(this.role_label);
            this.Controls.Add(this.bday_dateTimePicker);
            this.Controls.Add(this.bday_label);
            this.Controls.Add(this.tel_label);
            this.Controls.Add(this.role_comboBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddSetStaffForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.ComboBox role_comboBox;
        private System.Windows.Forms.Label tel_label;
        private System.Windows.Forms.Label bday_label;
        private System.Windows.Forms.DateTimePicker bday_dateTimePicker;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.MaskedTextBox tel_maskedTextBox;
        private System.Windows.Forms.TextBox name_textBox;
    }
}