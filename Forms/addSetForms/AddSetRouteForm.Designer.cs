
namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    partial class AddSetRouteForm
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
            this.num_label = new System.Windows.Forms.Label();
            this.num_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.start_textBox = new System.Windows.Forms.TextBox();
            this.start_label = new System.Windows.Forms.Label();
            this.end_textBox = new System.Windows.Forms.TextBox();
            this.end_label = new System.Windows.Forms.Label();
            this.desc_textBox = new System.Windows.Forms.TextBox();
            this.desc_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num_label
            // 
            this.num_label.AutoSize = true;
            this.num_label.Location = new System.Drawing.Point(80, 54);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(41, 13);
            this.num_label.TabIndex = 0;
            this.num_label.Text = "Номер";
            // 
            // num_textBox
            // 
            this.num_textBox.Location = new System.Drawing.Point(127, 51);
            this.num_textBox.Name = "num_textBox";
            this.num_textBox.Size = new System.Drawing.Size(100, 20);
            this.num_textBox.TabIndex = 1;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(127, 25);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 20);
            this.name_textBox.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(64, 28);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(57, 13);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Название";
            // 
            // start_textBox
            // 
            this.start_textBox.Location = new System.Drawing.Point(127, 77);
            this.start_textBox.Name = "start_textBox";
            this.start_textBox.Size = new System.Drawing.Size(100, 20);
            this.start_textBox.TabIndex = 5;
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Location = new System.Drawing.Point(16, 80);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(105, 13);
            this.start_label.TabIndex = 4;
            this.start_label.Text = "Пункт отправления";
            // 
            // end_textBox
            // 
            this.end_textBox.Location = new System.Drawing.Point(127, 103);
            this.end_textBox.Name = "end_textBox";
            this.end_textBox.Size = new System.Drawing.Size(100, 20);
            this.end_textBox.TabIndex = 7;
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Location = new System.Drawing.Point(32, 106);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(89, 13);
            this.end_label.TabIndex = 6;
            this.end_label.Text = "Пункт прибытия";
            // 
            // desc_textBox
            // 
            this.desc_textBox.Location = new System.Drawing.Point(127, 129);
            this.desc_textBox.Name = "desc_textBox";
            this.desc_textBox.Size = new System.Drawing.Size(100, 20);
            this.desc_textBox.TabIndex = 9;
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Location = new System.Drawing.Point(64, 132);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(57, 13);
            this.desc_label.TabIndex = 8;
            this.desc_label.Text = "Описание";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(95, 163);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // AddSetRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 201);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.desc_textBox);
            this.Controls.Add(this.desc_label);
            this.Controls.Add(this.end_textBox);
            this.Controls.Add(this.end_label);
            this.Controls.Add(this.start_textBox);
            this.Controls.Add(this.start_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.num_textBox);
            this.Controls.Add(this.num_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddSetRouteForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Маршрут";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox start_textBox;
        private System.Windows.Forms.Label start_label;
        private System.Windows.Forms.TextBox end_textBox;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.TextBox desc_textBox;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.Button save_button;
    }
}