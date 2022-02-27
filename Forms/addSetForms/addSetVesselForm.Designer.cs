
namespace Grishkova_vkr_PortApp.Forms.addForms
{
    partial class addSetVesselForm
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
            this.number_label = new System.Windows.Forms.Label();
            this.number_textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.places_label = new System.Windows.Forms.Label();
            this.places_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.type_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.places_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(101, 168);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(58, 24);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(63, 13);
            this.number_label.TabIndex = 1;
            this.number_label.Text = "Рег. номер";
            // 
            // number_textBox
            // 
            this.number_textBox.Location = new System.Drawing.Point(127, 21);
            this.number_textBox.Name = "number_textBox";
            this.number_textBox.Size = new System.Drawing.Size(126, 20);
            this.number_textBox.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Дата последнего ТО";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(127, 47);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 2, 2, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2022, 2, 2, 0, 0, 0, 0);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(127, 73);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(126, 20);
            this.name_textBox.TabIndex = 6;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(58, 76);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(57, 13);
            this.name_label.TabIndex = 5;
            this.name_label.Text = "Название";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(89, 102);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(26, 13);
            this.type_label.TabIndex = 7;
            this.type_label.Text = "Тип";
            // 
            // places_label
            // 
            this.places_label.AutoSize = true;
            this.places_label.Location = new System.Drawing.Point(45, 128);
            this.places_label.Name = "places_label";
            this.places_label.Size = new System.Drawing.Size(76, 13);
            this.places_label.TabIndex = 9;
            this.places_label.Text = "Вместимость";
            // 
            // places_numericUpDown
            // 
            this.places_numericUpDown.Location = new System.Drawing.Point(127, 126);
            this.places_numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.places_numericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.places_numericUpDown.Name = "places_numericUpDown";
            this.places_numericUpDown.Size = new System.Drawing.Size(126, 20);
            this.places_numericUpDown.TabIndex = 10;
            this.places_numericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // type_comboBox
            // 
            this.type_comboBox.FormattingEnabled = true;
            this.type_comboBox.Items.AddRange(new object[] {
            "Пассажирский",
            "Грузовой"});
            this.type_comboBox.Location = new System.Drawing.Point(127, 99);
            this.type_comboBox.Name = "type_comboBox";
            this.type_comboBox.Size = new System.Drawing.Size(126, 21);
            this.type_comboBox.TabIndex = 11;
            // 
            // addSetVesselForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 202);
            this.Controls.Add(this.type_comboBox);
            this.Controls.Add(this.places_numericUpDown);
            this.Controls.Add(this.places_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label);
            this.Controls.Add(this.number_textBox);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.save_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "addSetVesselForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Судно";
            this.Load += new System.EventHandler(this.addSetVesselForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.places_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.TextBox number_textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label places_label;
        private System.Windows.Forms.NumericUpDown places_numericUpDown;
        private System.Windows.Forms.ComboBox type_comboBox;
    }
}