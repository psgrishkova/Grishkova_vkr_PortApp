
namespace Grishkova_vkr_PortApp.Forms.OperationalData
{
    partial class WorkingDayCaps
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vesselComboBox = new System.Windows.Forms.ComboBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.name_label = new System.Windows.Forms.Label();
            this.vesselLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(529, 249);
            this.dataGridView1.TabIndex = 4;
            // 
            // vesselComboBox
            // 
            this.vesselComboBox.FormattingEnabled = true;
            this.vesselComboBox.Location = new System.Drawing.Point(548, 154);
            this.vesselComboBox.Name = "vesselComboBox";
            this.vesselComboBox.Size = new System.Drawing.Size(156, 21);
            this.vesselComboBox.TabIndex = 6;
            // 
            // nameComboBox
            // 
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(548, 114);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(156, 21);
            this.nameComboBox.TabIndex = 7;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(545, 98);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(34, 13);
            this.name_label.TabIndex = 9;
            this.name_label.Text = "ФИО";
            // 
            // vesselLabel
            // 
            this.vesselLabel.AutoSize = true;
            this.vesselLabel.Location = new System.Drawing.Point(545, 138);
            this.vesselLabel.Name = "vesselLabel";
            this.vesselLabel.Size = new System.Drawing.Size(37, 13);
            this.vesselLabel.TabIndex = 10;
            this.vesselLabel.Text = "Судно";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(548, 181);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(629, 181);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 16;
            this.setButton.Text = "Изменить";
            this.setButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(548, 210);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 17;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // WorkingDayCaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 289);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.vesselLabel);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.vesselComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WorkingDayCaps";
            this.ShowIcon = false;
            this.Text = "Составление смены";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox vesselComboBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label vesselLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button removeButton;
    }
}