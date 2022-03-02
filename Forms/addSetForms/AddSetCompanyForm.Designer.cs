
namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    partial class AddSetCompanyForm
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.inn_textBox = new System.Windows.Forms.TextBox();
            this.inn_label = new System.Windows.Forms.Label();
            this.tel_textBox = new System.Windows.Forms.TextBox();
            this.tel_label = new System.Windows.Forms.Label();
            this.legalAdress_textBox = new System.Windows.Forms.TextBox();
            this.legalAdress_label = new System.Windows.Forms.Label();
            this.physicalAddress_textBox = new System.Windows.Forms.TextBox();
            this.physicalAddress_label = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(21, 31);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(57, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Название";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(84, 28);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(125, 20);
            this.name_textBox.TabIndex = 1;
            // 
            // inn_textBox
            // 
            this.inn_textBox.Location = new System.Drawing.Point(84, 54);
            this.inn_textBox.Name = "inn_textBox";
            this.inn_textBox.Size = new System.Drawing.Size(125, 20);
            this.inn_textBox.TabIndex = 3;
            // 
            // inn_label
            // 
            this.inn_label.AutoSize = true;
            this.inn_label.Location = new System.Drawing.Point(47, 57);
            this.inn_label.Name = "inn_label";
            this.inn_label.Size = new System.Drawing.Size(31, 13);
            this.inn_label.TabIndex = 2;
            this.inn_label.Text = "ИНН";
            // 
            // tel_textBox
            // 
            this.tel_textBox.Location = new System.Drawing.Point(84, 80);
            this.tel_textBox.Name = "tel_textBox";
            this.tel_textBox.Size = new System.Drawing.Size(125, 20);
            this.tel_textBox.TabIndex = 5;
            // 
            // tel_label
            // 
            this.tel_label.AutoSize = true;
            this.tel_label.Location = new System.Drawing.Point(26, 83);
            this.tel_label.Name = "tel_label";
            this.tel_label.Size = new System.Drawing.Size(52, 13);
            this.tel_label.TabIndex = 4;
            this.tel_label.Text = "Телефон";
            // 
            // legalAdress_textBox
            // 
            this.legalAdress_textBox.Location = new System.Drawing.Point(84, 106);
            this.legalAdress_textBox.Name = "legalAdress_textBox";
            this.legalAdress_textBox.Size = new System.Drawing.Size(125, 20);
            this.legalAdress_textBox.TabIndex = 9;
            // 
            // legalAdress_label
            // 
            this.legalAdress_label.AutoSize = true;
            this.legalAdress_label.Location = new System.Drawing.Point(20, 109);
            this.legalAdress_label.Name = "legalAdress_label";
            this.legalAdress_label.Size = new System.Drawing.Size(58, 13);
            this.legalAdress_label.TabIndex = 8;
            this.legalAdress_label.Text = "Юр. адрес";
            // 
            // physicalAddress_textBox
            // 
            this.physicalAddress_textBox.Location = new System.Drawing.Point(84, 132);
            this.physicalAddress_textBox.Name = "physicalAddress_textBox";
            this.physicalAddress_textBox.Size = new System.Drawing.Size(125, 20);
            this.physicalAddress_textBox.TabIndex = 7;
            // 
            // physicalAddress_label
            // 
            this.physicalAddress_label.AutoSize = true;
            this.physicalAddress_label.Location = new System.Drawing.Point(12, 135);
            this.physicalAddress_label.Name = "physicalAddress_label";
            this.physicalAddress_label.Size = new System.Drawing.Size(66, 13);
            this.physicalAddress_label.TabIndex = 6;
            this.physicalAddress_label.Text = "Физ. адрес";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(84, 167);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddSetCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 206);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.legalAdress_textBox);
            this.Controls.Add(this.legalAdress_label);
            this.Controls.Add(this.physicalAddress_textBox);
            this.Controls.Add(this.physicalAddress_label);
            this.Controls.Add(this.tel_textBox);
            this.Controls.Add(this.tel_label);
            this.Controls.Add(this.inn_textBox);
            this.Controls.Add(this.inn_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddSetCompanyForm";
            this.ShowIcon = false;
            this.Text = "Компания";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox inn_textBox;
        private System.Windows.Forms.Label inn_label;
        private System.Windows.Forms.TextBox tel_textBox;
        private System.Windows.Forms.Label tel_label;
        private System.Windows.Forms.TextBox legalAdress_textBox;
        private System.Windows.Forms.Label legalAdress_label;
        private System.Windows.Forms.TextBox physicalAddress_textBox;
        private System.Windows.Forms.Label physicalAddress_label;
        private System.Windows.Forms.Button saveButton;
    }
}