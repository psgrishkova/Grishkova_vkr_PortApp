
namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    partial class AddSetNavForm
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
            this.num_textBox = new System.Windows.Forms.TextBox();
            this.num_label = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.start_label = new System.Windows.Forms.Label();
            this.end_label = new System.Windows.Forms.Label();
            this.NullCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(125, 113);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // num_textBox
            // 
            this.num_textBox.Location = new System.Drawing.Point(62, 12);
            this.num_textBox.Name = "num_textBox";
            this.num_textBox.Size = new System.Drawing.Size(137, 20);
            this.num_textBox.TabIndex = 1;
            // 
            // num_label
            // 
            this.num_label.AutoSize = true;
            this.num_label.Location = new System.Drawing.Point(38, 15);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(18, 13);
            this.num_label.TabIndex = 2;
            this.num_label.Text = "№";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(62, 38);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.startDateTimePicker.TabIndex = 3;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(62, 64);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.endDateTimePicker.TabIndex = 4;
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Location = new System.Drawing.Point(12, 41);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(44, 13);
            this.start_label.TabIndex = 5;
            this.start_label.Text = "Начало";
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Location = new System.Drawing.Point(12, 66);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(38, 13);
            this.end_label.TabIndex = 6;
            this.end_label.Text = "Конец";
            // 
            // NullCheckBox
            // 
            this.NullCheckBox.AutoSize = true;
            this.NullCheckBox.Location = new System.Drawing.Point(90, 90);
            this.NullCheckBox.Name = "NullCheckBox";
            this.NullCheckBox.Size = new System.Drawing.Size(110, 17);
            this.NullCheckBox.TabIndex = 7;
            this.NullCheckBox.Text = "Текущий период";
            this.NullCheckBox.UseVisualStyleBackColor = true;
            this.NullCheckBox.CheckedChanged += new System.EventHandler(this.NullCheckBox_CheckedChanged);
            // 
            // AddSetNavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 144);
            this.Controls.Add(this.NullCheckBox);
            this.Controls.Add(this.end_label);
            this.Controls.Add(this.start_label);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.num_label);
            this.Controls.Add(this.num_textBox);
            this.Controls.Add(this.save_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddSetNavForm";
            this.ShowIcon = false;
            this.Text = "Навигационный период";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label start_label;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.CheckBox NullCheckBox;
    }
}