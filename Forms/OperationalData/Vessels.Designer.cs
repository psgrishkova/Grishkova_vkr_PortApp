
namespace Grishkova_vkr_PortApp.Forms.OperationalData
{
    partial class Vessels
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
            this.vesselsDataGridView = new System.Windows.Forms.DataGridView();
            this.vesselsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet1 = new Grishkova_vkr_PortApp.demoDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вахтенныйЖурналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setDateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.рейсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet = new Grishkova_vkr_PortApp.demoDataSet();
            this.рейсTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.РейсTableAdapter();
            this.vesselsTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.VesselsTableAdapter();
            this.вахтенный_журналTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Вахтенный_журналTableAdapter();
            this.прайс_листTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Прайс_листTableAdapter();
            this.Номер_рейса = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время_рейса = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_маршрута = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО_сотрудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_судна = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Доход_за_рейс = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vesselsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vesselsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vesselsDataGridView
            // 
            this.vesselsDataGridView.AllowUserToAddRows = false;
            this.vesselsDataGridView.AllowUserToDeleteRows = false;
            this.vesselsDataGridView.AllowUserToResizeColumns = false;
            this.vesselsDataGridView.AllowUserToResizeRows = false;
            this.vesselsDataGridView.AutoGenerateColumns = false;
            this.vesselsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vesselsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер_рейса,
            this.Время_рейса,
            this.Название_маршрута,
            this.ФИО_сотрудника,
            this.Название_судна,
            this.Доход_за_рейс});
            this.vesselsDataGridView.DataSource = this.vesselsBindingSource;
            this.vesselsDataGridView.Location = new System.Drawing.Point(13, 63);
            this.vesselsDataGridView.MultiSelect = false;
            this.vesselsDataGridView.Name = "vesselsDataGridView";
            this.vesselsDataGridView.ReadOnly = true;
            this.vesselsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vesselsDataGridView.Size = new System.Drawing.Size(534, 215);
            this.vesselsDataGridView.TabIndex = 0;
            // 
            // vesselsBindingSource
            // 
            this.vesselsBindingSource.DataMember = "Vessels";
            this.vesselsBindingSource.DataSource = this.demoDataSet1;
            // 
            // demoDataSet1
            // 
            this.demoDataSet1.DataSetName = "demoDataSet";
            this.demoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вахтенныйЖурналToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вахтенныйЖурналToolStripMenuItem
            // 
            this.вахтенныйЖурналToolStripMenuItem.Name = "вахтенныйЖурналToolStripMenuItem";
            this.вахтенныйЖурналToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.вахтенныйЖурналToolStripMenuItem.Text = "Вахтенный журнал";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(13, 37);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // setDateButton
            // 
            this.setDateButton.Location = new System.Drawing.Point(156, 37);
            this.setDateButton.Name = "setDateButton";
            this.setDateButton.Size = new System.Drawing.Size(75, 20);
            this.setDateButton.TabIndex = 3;
            this.setDateButton.Text = "Применить";
            this.setDateButton.UseVisualStyleBackColor = true;
            this.setDateButton.Click += new System.EventHandler(this.setDateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(472, 37);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 20);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // рейсBindingSource
            // 
            this.рейсBindingSource.DataMember = "Рейс";
            this.рейсBindingSource.DataSource = this.demoDataSet;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рейсTableAdapter
            // 
            this.рейсTableAdapter.ClearBeforeFill = true;
            // 
            // vesselsTableAdapter
            // 
            this.vesselsTableAdapter.ClearBeforeFill = true;
            // 
            // вахтенный_журналTableAdapter1
            // 
            this.вахтенный_журналTableAdapter1.ClearBeforeFill = true;
            // 
            // прайс_листTableAdapter1
            // 
            this.прайс_листTableAdapter1.ClearBeforeFill = true;
            // 
            // Номер_рейса
            // 
            this.Номер_рейса.DataPropertyName = "Номер_рейса";
            this.Номер_рейса.HeaderText = "№";
            this.Номер_рейса.Name = "Номер_рейса";
            this.Номер_рейса.ReadOnly = true;
            this.Номер_рейса.Width = 50;
            // 
            // Время_рейса
            // 
            this.Время_рейса.DataPropertyName = "Время_рейса";
            this.Время_рейса.HeaderText = "Время";
            this.Время_рейса.Name = "Время_рейса";
            this.Время_рейса.ReadOnly = true;
            this.Время_рейса.Width = 70;
            // 
            // Название_маршрута
            // 
            this.Название_маршрута.DataPropertyName = "Название_маршрута";
            this.Название_маршрута.HeaderText = "Маршрут";
            this.Название_маршрута.Name = "Название_маршрута";
            this.Название_маршрута.ReadOnly = true;
            // 
            // ФИО_сотрудника
            // 
            this.ФИО_сотрудника.DataPropertyName = "ФИО_сотрудника";
            this.ФИО_сотрудника.HeaderText = "Капитан";
            this.ФИО_сотрудника.Name = "ФИО_сотрудника";
            this.ФИО_сотрудника.ReadOnly = true;
            // 
            // Название_судна
            // 
            this.Название_судна.DataPropertyName = "Название_судна";
            this.Название_судна.HeaderText = "Судно";
            this.Название_судна.Name = "Название_судна";
            this.Название_судна.ReadOnly = true;
            // 
            // Доход_за_рейс
            // 
            this.Доход_за_рейс.DataPropertyName = "Доход_за_рейс";
            this.Доход_за_рейс.HeaderText = "Доход";
            this.Доход_за_рейс.Name = "Доход_за_рейс";
            this.Доход_за_рейс.ReadOnly = true;
            this.Доход_за_рейс.Width = 70;
            // 
            // Vessels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 285);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.setDateButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.vesselsDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Vessels";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рейсы";
            this.Load += new System.EventHandler(this.Vessels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vesselsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vesselsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vesselsDataGridView;
        private demoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource рейсBindingSource;
        private demoDataSetTableAdapters.РейсTableAdapter рейсTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button setDateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private demoDataSet demoDataSet1;
        private System.Windows.Forms.BindingSource vesselsBindingSource;
        private demoDataSetTableAdapters.VesselsTableAdapter vesselsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem вахтенныйЖурналToolStripMenuItem;
        private demoDataSetTableAdapters.Вахтенный_журналTableAdapter вахтенный_журналTableAdapter1;
        private demoDataSetTableAdapters.Прайс_листTableAdapter прайс_листTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_рейса;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_рейса;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_маршрута;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО_сотрудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_судна;
        private System.Windows.Forms.DataGridViewTextBoxColumn Доход_за_рейс;
    }
}