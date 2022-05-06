
namespace Grishkova_vkr_PortApp.Forms
{
    partial class Queries
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.queryComboBox = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.showButton = new System.Windows.Forms.Button();
            this.demoDataSet = new Grishkova_vkr_PortApp.demoDataSet();
            this.getCountRoutesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCountRoutesTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.GetCountRoutesTableAdapter();
            this.sumFuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumFuelTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.SumFuelTableAdapter();
            this.iNcomeAndExpensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNcomeAndExpensesTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.INcomeAndExpensesTableAdapter();
            this.countPassByDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countPassByDayTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.CountPassByDayTableAdapter();
            this.calendarToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCountRoutesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFuelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNcomeAndExpensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPassByDayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.queryComboBox);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(315, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Период";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Запрос";
            // 
            // queryComboBox
            // 
            this.queryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryComboBox.DropDownWidth = 300;
            this.queryComboBox.FormattingEnabled = true;
            this.queryComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.queryComboBox.Items.AddRange(new object[] {
            "Количество выполненных рейсов по каждому маршруту",
            "Расход топлива за указанный период",
            "Затраты и доходы в денежном выражении",
            "Количеству людей на рейсах относительно дня недели"});
            this.queryComboBox.Location = new System.Drawing.Point(12, 41);
            this.queryComboBox.Name = "queryComboBox";
            this.queryComboBox.Size = new System.Drawing.Size(164, 21);
            this.queryComboBox.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 97);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
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
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 27);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(296, 304);
            this.dataGridView.TabIndex = 2;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(430, 306);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Показать";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCountRoutesBindingSource
            // 
            this.getCountRoutesBindingSource.DataMember = "GetCountRoutes";
            this.getCountRoutesBindingSource.DataSource = this.demoDataSet;
            // 
            // getCountRoutesTableAdapter
            // 
            this.getCountRoutesTableAdapter.ClearBeforeFill = true;
            // 
            // sumFuelBindingSource
            // 
            this.sumFuelBindingSource.DataMember = "SumFuel";
            this.sumFuelBindingSource.DataSource = this.demoDataSet;
            // 
            // sumFuelTableAdapter
            // 
            this.sumFuelTableAdapter.ClearBeforeFill = true;
            // 
            // iNcomeAndExpensesBindingSource
            // 
            this.iNcomeAndExpensesBindingSource.DataMember = "INcomeAndExpenses";
            this.iNcomeAndExpensesBindingSource.DataSource = this.demoDataSet;
            // 
            // iNcomeAndExpensesTableAdapter
            // 
            this.iNcomeAndExpensesTableAdapter.ClearBeforeFill = true;
            // 
            // countPassByDayBindingSource
            // 
            this.countPassByDayBindingSource.DataMember = "CountPassByDay";
            this.countPassByDayBindingSource.DataSource = this.demoDataSet;
            // 
            // countPassByDayTableAdapter
            // 
            this.countPassByDayTableAdapter.ClearBeforeFill = true;
            // 
            // calendarToolTip
            // 
            this.calendarToolTip.AutoPopDelay = 6000;
            this.calendarToolTip.InitialDelay = 500;
            this.calendarToolTip.IsBalloon = true;
            this.calendarToolTip.ReshowDelay = 100;
            this.calendarToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.calendarToolTip.ToolTipTitle = "Выбор периода";
            // 
            // Queries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 341);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Queries";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запросы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Queries_FormClosed);
            this.Load += new System.EventHandler(this.Queries_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCountRoutesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFuelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNcomeAndExpensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPassByDayBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox queryComboBox;
        private demoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource getCountRoutesBindingSource;
        private demoDataSetTableAdapters.GetCountRoutesTableAdapter getCountRoutesTableAdapter;
        private System.Windows.Forms.BindingSource sumFuelBindingSource;
        private demoDataSetTableAdapters.SumFuelTableAdapter sumFuelTableAdapter;
        private System.Windows.Forms.BindingSource iNcomeAndExpensesBindingSource;
        private demoDataSetTableAdapters.INcomeAndExpensesTableAdapter iNcomeAndExpensesTableAdapter;
        private System.Windows.Forms.BindingSource countPassByDayBindingSource;
        private demoDataSetTableAdapters.CountPassByDayTableAdapter countPassByDayTableAdapter;
        private System.Windows.Forms.ToolTip calendarToolTip;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}