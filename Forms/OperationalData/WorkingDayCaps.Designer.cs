
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.date_label = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkDate_button = new System.Windows.Forms.Button();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.setButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.vesselLabel = new System.Windows.Forms.Label();
            this.vesselComboBox = new System.Windows.Forms.ComboBox();
            this.LogbookGridView = new System.Windows.Forms.DataGridView();
            this.ФИО_сотрудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_судна = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзаписиввахтенномжурналеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.капитанDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номернавигационногопериодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet1 = new Grishkova_vkr_PortApp.demoDataSet();
            this.навигацияTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.НавигацияTableAdapter();
            this.вахтенный_журналTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Вахтенный_журналTableAdapter();
            this.персоналTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.ПерсоналTableAdapter();
            this.судноTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.СудноTableAdapter();
            this.demoDataSet = new Grishkova_vkr_PortApp.demoDataSet();
            this.вахтенныйжурналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рейсTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.РейсTableAdapter();
            this.кассаTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.КассаTableAdapter();
            this.dataTable1TableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.DataTable1TableAdapter();
            this.menuStrip1.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogbookGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вахтенныйжурналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
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
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(12, 36);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(33, 13);
            this.date_label.TabIndex = 22;
            this.date_label.Text = "Дата";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(51, 33);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker.TabIndex = 21;
            // 
            // checkDate_button
            // 
            this.checkDate_button.Location = new System.Drawing.Point(211, 33);
            this.checkDate_button.Name = "checkDate_button";
            this.checkDate_button.Size = new System.Drawing.Size(75, 20);
            this.checkDate_button.TabIndex = 23;
            this.checkDate_button.Text = "Применить";
            this.checkDate_button.UseVisualStyleBackColor = true;
            this.checkDate_button.Click += new System.EventHandler(this.checkDate_button_Click);
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.setButton);
            this.dataGroupBox.Controls.Add(this.removeButton);
            this.dataGroupBox.Controls.Add(this.name_label);
            this.dataGroupBox.Controls.Add(this.nameComboBox);
            this.dataGroupBox.Controls.Add(this.addButton);
            this.dataGroupBox.Controls.Add(this.vesselLabel);
            this.dataGroupBox.Controls.Add(this.vesselComboBox);
            this.dataGroupBox.Location = new System.Drawing.Point(12, 282);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(458, 83);
            this.dataGroupBox.TabIndex = 24;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Данные";
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(188, 48);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 30;
            this.setButton.Text = "Изменить";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(296, 48);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 31;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(6, 24);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(34, 13);
            this.name_label.TabIndex = 27;
            this.name_label.Text = "ФИО";
            // 
            // nameComboBox
            // 
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(46, 21);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(156, 21);
            this.nameComboBox.TabIndex = 26;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(82, 48);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // vesselLabel
            // 
            this.vesselLabel.AutoSize = true;
            this.vesselLabel.Location = new System.Drawing.Point(253, 24);
            this.vesselLabel.Name = "vesselLabel";
            this.vesselLabel.Size = new System.Drawing.Size(37, 13);
            this.vesselLabel.TabIndex = 28;
            this.vesselLabel.Text = "Судно";
            // 
            // vesselComboBox
            // 
            this.vesselComboBox.FormattingEnabled = true;
            this.vesselComboBox.Location = new System.Drawing.Point(296, 21);
            this.vesselComboBox.Name = "vesselComboBox";
            this.vesselComboBox.Size = new System.Drawing.Size(156, 21);
            this.vesselComboBox.TabIndex = 25;
            // 
            // LogbookGridView
            // 
            this.LogbookGridView.AllowUserToAddRows = false;
            this.LogbookGridView.AllowUserToDeleteRows = false;
            this.LogbookGridView.AutoGenerateColumns = false;
            this.LogbookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogbookGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn,
            this.ФИО_сотрудника,
            this.Название_судна,
            this.датаDataGridViewTextBoxColumn,
            this.номерзаписиввахтенномжурналеDataGridViewTextBoxColumn,
            this.капитанDataGridViewTextBoxColumn,
            this.номернавигационногопериодаDataGridViewTextBoxColumn});
            this.LogbookGridView.DataSource = this.dataTable1BindingSource;
            this.LogbookGridView.Location = new System.Drawing.Point(15, 59);
            this.LogbookGridView.MultiSelect = false;
            this.LogbookGridView.Name = "LogbookGridView";
            this.LogbookGridView.ReadOnly = true;
            this.LogbookGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogbookGridView.Size = new System.Drawing.Size(455, 217);
            this.LogbookGridView.TabIndex = 25;
            // 
            // ФИО_сотрудника
            // 
            this.ФИО_сотрудника.DataPropertyName = "ФИО_сотрудника";
            this.ФИО_сотрудника.HeaderText = "ФИО_сотрудника";
            this.ФИО_сотрудника.Name = "ФИО_сотрудника";
            this.ФИО_сотрудника.ReadOnly = true;
            // 
            // Название_судна
            // 
            this.Название_судна.DataPropertyName = "Название_судна";
            this.Название_судна.HeaderText = "Название_судна";
            this.Название_судна.Name = "Название_судна";
            this.Название_судна.ReadOnly = true;
            // 
            // регистрационныйномерсуднаDataGridViewTextBoxColumn
            // 
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.DataPropertyName = "Регистрационный_номер_судна";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.HeaderText = "Регистрационный_номер_судна";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.Name = "регистрационныйномерсуднаDataGridViewTextBoxColumn";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерзаписиввахтенномжурналеDataGridViewTextBoxColumn
            // 
            this.номерзаписиввахтенномжурналеDataGridViewTextBoxColumn.DataPropertyName = "Номер_записи_в_вахтенном_журнале";
            this.номерзаписиввахтенномжурналеDataGridViewTextBoxColumn.HeaderText = "Номер_записи_в_вахтенном_журнале";
            this.номерзаписиввахтенномжурналеDataGridViewTextBoxColumn.Name = "номерзаписиввахтенномжурналеDataGridViewTextBoxColumn";
            this.номерзаписиввахтенномжурналеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // капитанDataGridViewTextBoxColumn
            // 
            this.капитанDataGridViewTextBoxColumn.DataPropertyName = "капитан";
            this.капитанDataGridViewTextBoxColumn.HeaderText = "капитан";
            this.капитанDataGridViewTextBoxColumn.Name = "капитанDataGridViewTextBoxColumn";
            this.капитанDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номернавигационногопериодаDataGridViewTextBoxColumn
            // 
            this.номернавигационногопериодаDataGridViewTextBoxColumn.DataPropertyName = "Номер_навигационного_периода";
            this.номернавигационногопериодаDataGridViewTextBoxColumn.HeaderText = "Номер_навигационного_периода";
            this.номернавигационногопериодаDataGridViewTextBoxColumn.Name = "номернавигационногопериодаDataGridViewTextBoxColumn";
            this.номернавигационногопериодаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.demoDataSet1;
            // 
            // demoDataSet1
            // 
            this.demoDataSet1.DataSetName = "demoDataSet";
            this.demoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // навигацияTableAdapter1
            // 
            this.навигацияTableAdapter1.ClearBeforeFill = true;
            // 
            // вахтенный_журналTableAdapter1
            // 
            this.вахтенный_журналTableAdapter1.ClearBeforeFill = true;
            // 
            // персоналTableAdapter1
            // 
            this.персоналTableAdapter1.ClearBeforeFill = true;
            // 
            // судноTableAdapter1
            // 
            this.судноTableAdapter1.ClearBeforeFill = true;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вахтенныйжурналBindingSource
            // 
            this.вахтенныйжурналBindingSource.DataMember = "Вахтенный_журнал";
            this.вахтенныйжурналBindingSource.DataSource = this.demoDataSet;
            // 
            // demoDataSetBindingSource
            // 
            this.demoDataSetBindingSource.DataSource = this.demoDataSet;
            this.demoDataSetBindingSource.Position = 0;
            // 
            // рейсTableAdapter
            // 
            this.рейсTableAdapter.ClearBeforeFill = true;
            // 
            // кассаTableAdapter
            // 
            this.кассаTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // WorkingDayCaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 368);
            this.Controls.Add(this.LogbookGridView);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.checkDate_button);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WorkingDayCaps";
            this.ShowIcon = false;
            this.Text = "Вахтенный журнал";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogbookGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вахтенныйжурналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button checkDate_button;
        private demoDataSetTableAdapters.НавигацияTableAdapter навигацияTableAdapter1;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label vesselLabel;
        private System.Windows.Forms.ComboBox vesselComboBox;
        private demoDataSetTableAdapters.Вахтенный_журналTableAdapter вахтенный_журналTableAdapter1;
        private demoDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter1;
        private demoDataSetTableAdapters.СудноTableAdapter судноTableAdapter1;
        private System.Windows.Forms.BindingSource вахтенныйжурналBindingSource;
        private demoDataSet demoDataSet;
        private System.Windows.Forms.DataGridView LogbookGridView;
        private System.Windows.Forms.BindingSource demoDataSetBindingSource;
        private demoDataSetTableAdapters.РейсTableAdapter рейсTableAdapter;
        private demoDataSetTableAdapters.КассаTableAdapter кассаTableAdapter;
        private demoDataSet demoDataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private demoDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйномерсуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО_сотрудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_судна;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаписиввахтенномжурналеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn капитанDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номернавигационногопериодаDataGridViewTextBoxColumn;
    }
}