
namespace Grishkova_vkr_PortApp.Forms.OperationalData
{
    partial class Fuel
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FuelGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.giveFuelButton = new System.Windows.Forms.Button();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
            this.capsComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.receiptGroupBox = new System.Windows.Forms.GroupBox();
            this.saveReceiptButton = new System.Windows.Forms.Button();
            this.receiptSumTextBox = new System.Windows.Forms.TextBox();
            this.receiptVolumeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.remainsVolumeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.givedVolumetextBox = new System.Windows.Forms.TextBox();
            this.fuelDataGridView = new System.Windows.Forms.DataGridView();
            this.ФИО_сотрудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.driversComboBox = new System.Windows.Forms.ComboBox();
            this.объемтопливаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.потраченнаясуммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet = new Grishkova_vkr_PortApp.demoDataSet();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учеттопливаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.персоналTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.ПерсоналTableAdapter();
            this.вахтенный_журналTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Вахтенный_журналTableAdapter();
            this.учет_топливаTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Учет_топливаTableAdapter();
            this.dataTable2TableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.DataTable2TableAdapter();
            this.FuelGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.receiptGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учеттопливаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(16, 32);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Дата: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // FuelGroupBox
            // 
            this.FuelGroupBox.Controls.Add(this.driversComboBox);
            this.FuelGroupBox.Controls.Add(this.label11);
            this.FuelGroupBox.Controls.Add(this.deleteButton);
            this.FuelGroupBox.Controls.Add(this.groupBox3);
            this.FuelGroupBox.Controls.Add(this.receiptGroupBox);
            this.FuelGroupBox.Controls.Add(this.button2);
            this.FuelGroupBox.Controls.Add(this.remainsVolumeTextBox);
            this.FuelGroupBox.Controls.Add(this.label7);
            this.FuelGroupBox.Controls.Add(this.label6);
            this.FuelGroupBox.Controls.Add(this.givedVolumetextBox);
            this.FuelGroupBox.Controls.Add(this.fuelDataGridView);
            this.FuelGroupBox.Location = new System.Drawing.Point(12, 48);
            this.FuelGroupBox.Name = "FuelGroupBox";
            this.FuelGroupBox.Size = new System.Drawing.Size(530, 346);
            this.FuelGroupBox.TabIndex = 4;
            this.FuelGroupBox.TabStop = false;
            this.FuelGroupBox.Text = "Выдача";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(444, 263);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.giveFuelButton);
            this.groupBox3.Controls.Add(this.VolumeTextBox);
            this.groupBox3.Controls.Add(this.capsComboBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(303, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 104);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кому выдано";
            // 
            // giveFuelButton
            // 
            this.giveFuelButton.Location = new System.Drawing.Point(141, 72);
            this.giveFuelButton.Name = "giveFuelButton";
            this.giveFuelButton.Size = new System.Drawing.Size(75, 23);
            this.giveFuelButton.TabIndex = 16;
            this.giveFuelButton.Text = "Выдать";
            this.giveFuelButton.UseVisualStyleBackColor = true;
            this.giveFuelButton.Click += new System.EventHandler(this.giveFuelButton_Click);
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.Location = new System.Drawing.Point(69, 46);
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(141, 20);
            this.VolumeTextBox.TabIndex = 15;
            // 
            // capsComboBox
            // 
            this.capsComboBox.FormattingEnabled = true;
            this.capsComboBox.Location = new System.Drawing.Point(69, 19);
            this.capsComboBox.Name = "capsComboBox";
            this.capsComboBox.Size = new System.Drawing.Size(141, 21);
            this.capsComboBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Объем, л";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Капитан";
            // 
            // receiptGroupBox
            // 
            this.receiptGroupBox.Controls.Add(this.saveReceiptButton);
            this.receiptGroupBox.Controls.Add(this.receiptSumTextBox);
            this.receiptGroupBox.Controls.Add(this.receiptVolumeTextBox);
            this.receiptGroupBox.Controls.Add(this.label5);
            this.receiptGroupBox.Controls.Add(this.label4);
            this.receiptGroupBox.Location = new System.Drawing.Point(302, 43);
            this.receiptGroupBox.Name = "receiptGroupBox";
            this.receiptGroupBox.Size = new System.Drawing.Size(222, 104);
            this.receiptGroupBox.TabIndex = 12;
            this.receiptGroupBox.TabStop = false;
            this.receiptGroupBox.Text = "Чек";
            // 
            // saveReceiptButton
            // 
            this.saveReceiptButton.Location = new System.Drawing.Point(141, 75);
            this.saveReceiptButton.Name = "saveReceiptButton";
            this.saveReceiptButton.Size = new System.Drawing.Size(75, 23);
            this.saveReceiptButton.TabIndex = 17;
            this.saveReceiptButton.Text = "Сохранить";
            this.saveReceiptButton.UseVisualStyleBackColor = true;
            this.saveReceiptButton.Click += new System.EventHandler(this.saveReceiptButton_Click);
            // 
            // receiptSumTextBox
            // 
            this.receiptSumTextBox.Location = new System.Drawing.Point(116, 43);
            this.receiptSumTextBox.Name = "receiptSumTextBox";
            this.receiptSumTextBox.Size = new System.Drawing.Size(100, 20);
            this.receiptSumTextBox.TabIndex = 5;
            // 
            // receiptVolumeTextBox
            // 
            this.receiptVolumeTextBox.Location = new System.Drawing.Point(116, 16);
            this.receiptVolumeTextBox.Name = "receiptVolumeTextBox";
            this.receiptVolumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.receiptVolumeTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Сумма, руб";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Объем, л";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Закончить выдачу";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // remainsVolumeTextBox
            // 
            this.remainsVolumeTextBox.Enabled = false;
            this.remainsVolumeTextBox.Location = new System.Drawing.Point(204, 302);
            this.remainsVolumeTextBox.Name = "remainsVolumeTextBox";
            this.remainsVolumeTextBox.Size = new System.Drawing.Size(92, 20);
            this.remainsVolumeTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Осталось, л";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Общий объем выданного топлива, л";
            // 
            // givedVolumetextBox
            // 
            this.givedVolumetextBox.Enabled = false;
            this.givedVolumetextBox.Location = new System.Drawing.Point(204, 276);
            this.givedVolumetextBox.Name = "givedVolumetextBox";
            this.givedVolumetextBox.Size = new System.Drawing.Size(92, 20);
            this.givedVolumetextBox.TabIndex = 1;
            // 
            // fuelDataGridView
            // 
            this.fuelDataGridView.AllowUserToAddRows = false;
            this.fuelDataGridView.AllowUserToDeleteRows = false;
            this.fuelDataGridView.AutoGenerateColumns = false;
            this.fuelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fuelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ФИО_сотрудника,
            this.объемтопливаDataGridViewTextBoxColumn,
            this.потраченнаясуммаDataGridViewTextBoxColumn});
            this.fuelDataGridView.DataSource = this.dataTable2BindingSource1;
            this.fuelDataGridView.Location = new System.Drawing.Point(6, 19);
            this.fuelDataGridView.Name = "fuelDataGridView";
            this.fuelDataGridView.ReadOnly = true;
            this.fuelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fuelDataGridView.Size = new System.Drawing.Size(290, 251);
            this.fuelDataGridView.TabIndex = 0;
            // 
            // ФИО_сотрудника
            // 
            this.ФИО_сотрудника.DataPropertyName = "ФИО_сотрудника";
            this.ФИО_сотрудника.HeaderText = "Капитан";
            this.ФИО_сотрудника.Name = "ФИО_сотрудника";
            this.ФИО_сотрудника.ReadOnly = true;
            this.ФИО_сотрудника.Width = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Водитель";
            // 
            // driversComboBox
            // 
            this.driversComboBox.FormattingEnabled = true;
            this.driversComboBox.Location = new System.Drawing.Point(363, 16);
            this.driversComboBox.Name = "driversComboBox";
            this.driversComboBox.Size = new System.Drawing.Size(155, 21);
            this.driversComboBox.TabIndex = 17;
            // 
            // объемтопливаDataGridViewTextBoxColumn
            // 
            this.объемтопливаDataGridViewTextBoxColumn.DataPropertyName = "Объем_топлива";
            this.объемтопливаDataGridViewTextBoxColumn.HeaderText = "Объем";
            this.объемтопливаDataGridViewTextBoxColumn.Name = "объемтопливаDataGridViewTextBoxColumn";
            this.объемтопливаDataGridViewTextBoxColumn.ReadOnly = true;
            this.объемтопливаDataGridViewTextBoxColumn.Width = 70;
            // 
            // потраченнаясуммаDataGridViewTextBoxColumn
            // 
            this.потраченнаясуммаDataGridViewTextBoxColumn.DataPropertyName = "Потраченная_сумма";
            this.потраченнаясуммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.потраченнаясуммаDataGridViewTextBoxColumn.Name = "потраченнаясуммаDataGridViewTextBoxColumn";
            this.потраченнаясуммаDataGridViewTextBoxColumn.ReadOnly = true;
            this.потраченнаясуммаDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataTable2BindingSource1
            // 
            this.dataTable2BindingSource1.DataMember = "DataTable2";
            this.dataTable2BindingSource1.DataSource = this.demoDataSet;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.demoDataSet;
            // 
            // учеттопливаBindingSource
            // 
            this.учеттопливаBindingSource.DataMember = "Учет_топлива";
            this.учеттопливаBindingSource.DataSource = this.demoDataSet;
            // 
            // персоналTableAdapter1
            // 
            this.персоналTableAdapter1.ClearBeforeFill = true;
            // 
            // вахтенный_журналTableAdapter1
            // 
            this.вахтенный_журналTableAdapter1.ClearBeforeFill = true;
            // 
            // учет_топливаTableAdapter
            // 
            this.учет_топливаTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // Fuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 406);
            this.Controls.Add(this.FuelGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Fuel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Топливо";
            this.Load += new System.EventHandler(this.Fuel_Load);
            this.FuelGroupBox.ResumeLayout(false);
            this.FuelGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.receiptGroupBox.ResumeLayout(false);
            this.receiptGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учеттопливаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox FuelGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button giveFuelButton;
        private System.Windows.Forms.TextBox VolumeTextBox;
        private System.Windows.Forms.ComboBox capsComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox receiptGroupBox;
        private System.Windows.Forms.TextBox receiptSumTextBox;
        private System.Windows.Forms.TextBox receiptVolumeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox givedVolumetextBox;
        private System.Windows.Forms.DataGridView fuelDataGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button saveReceiptButton;
        private System.Windows.Forms.TextBox remainsVolumeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox driversComboBox;
        private demoDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter1;
        private demoDataSetTableAdapters.Вахтенный_журналTableAdapter вахтенный_журналTableAdapter1;
        private demoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource учеттопливаBindingSource;
        private demoDataSetTableAdapters.Учет_топливаTableAdapter учет_топливаTableAdapter;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private demoDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.BindingSource dataTable2BindingSource1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО_сотрудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемтопливаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn потраченнаясуммаDataGridViewTextBoxColumn;
    }
}