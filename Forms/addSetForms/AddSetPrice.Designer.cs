
namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    partial class AddSetPrice
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
            this.routeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.категория_гражданTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Категория_гражданTableAdapter();
            this.маршрутTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.МаршрутTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.priceNumComboBox = new System.Windows.Forms.ComboBox();
            this.прайс_листTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Прайс_листTableAdapter();
            this.SuspendLayout();
            // 
            // routeComboBox
            // 
            this.routeComboBox.FormattingEnabled = true;
            this.routeComboBox.Location = new System.Drawing.Point(89, 52);
            this.routeComboBox.Name = "routeComboBox";
            this.routeComboBox.Size = new System.Drawing.Size(121, 21);
            this.routeComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "№ маршрута";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(89, 106);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(121, 20);
            this.costTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(79, 142);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Категория";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(89, 79);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Стоимость";
            // 
            // категория_гражданTableAdapter1
            // 
            this.категория_гражданTableAdapter1.ClearBeforeFill = true;
            // 
            // маршрутTableAdapter1
            // 
            this.маршрутTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "№ прайса";
            // 
            // priceNumComboBox
            // 
            this.priceNumComboBox.FormattingEnabled = true;
            this.priceNumComboBox.Location = new System.Drawing.Point(89, 25);
            this.priceNumComboBox.Name = "priceNumComboBox";
            this.priceNumComboBox.Size = new System.Drawing.Size(121, 21);
            this.priceNumComboBox.TabIndex = 10;
            // 
            // прайс_листTableAdapter1
            // 
            this.прайс_листTableAdapter1.ClearBeforeFill = true;
            // 
            // AddSetPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 180);
            this.Controls.Add(this.priceNumComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.routeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddSetPrice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая цена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox routeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label3;
        private demoDataSetTableAdapters.Категория_гражданTableAdapter категория_гражданTableAdapter1;
        private demoDataSetTableAdapters.МаршрутTableAdapter маршрутTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox priceNumComboBox;
        private demoDataSetTableAdapters.Прайс_листTableAdapter прайс_листTableAdapter1;
    }
}