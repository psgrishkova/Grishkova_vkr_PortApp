
namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    partial class UpdateLogbook
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
            this.name_label = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.vesselLabel = new System.Windows.Forms.Label();
            this.vesselComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(20, 30);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(34, 13);
            this.name_label.TabIndex = 27;
            this.name_label.Text = "ФИО";
            // 
            // nameComboBox
            // 
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(60, 27);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(156, 21);
            this.nameComboBox.TabIndex = 26;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(141, 103);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // vesselLabel
            // 
            this.vesselLabel.AutoSize = true;
            this.vesselLabel.Location = new System.Drawing.Point(17, 57);
            this.vesselLabel.Name = "vesselLabel";
            this.vesselLabel.Size = new System.Drawing.Size(37, 13);
            this.vesselLabel.TabIndex = 28;
            this.vesselLabel.Text = "Судно";
            // 
            // vesselComboBox
            // 
            this.vesselComboBox.FormattingEnabled = true;
            this.vesselComboBox.Location = new System.Drawing.Point(60, 54);
            this.vesselComboBox.Name = "vesselComboBox";
            this.vesselComboBox.Size = new System.Drawing.Size(156, 21);
            this.vesselComboBox.TabIndex = 25;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(23, 103);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // UpdateLogbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 138);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.vesselLabel);
            this.Controls.Add(this.vesselComboBox);
            this.Name = "UpdateLogbook";
            this.Text = "UpdateLogbook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label vesselLabel;
        private System.Windows.Forms.ComboBox vesselComboBox;
        private System.Windows.Forms.Button saveButton;
    }
}