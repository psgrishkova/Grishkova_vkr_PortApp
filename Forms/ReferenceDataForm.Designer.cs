
namespace Grishkova_vkr_PortApp.Forms
{
    partial class ReferenceDataForm
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
            this.referenceData_groupBox = new System.Windows.Forms.GroupBox();
            this.getBy_button = new System.Windows.Forms.Button();
            this.getBy_comboBox = new System.Windows.Forms.ComboBox();
            this.getBy_textBox = new System.Windows.Forms.TextBox();
            this.search_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.set_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceData_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапоследнегоТОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиесуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типсуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idкомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.судноBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet = new Grishkova_vkr_PortApp.demoDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.номернавигационногопериодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначаланавигацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазавершениянавигацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.навигацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.судноTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.СудноTableAdapter();
            this.навигацияTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.НавигацияTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.маршрутBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.МаршрутTableAdapter();
            this.названиемаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номермаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктотправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктприбытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниемаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceData_groupBox.SuspendLayout();
            this.menu.SuspendLayout();
            this.referenceData_tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.судноBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.навигацияBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // referenceData_groupBox
            // 
            this.referenceData_groupBox.Controls.Add(this.getBy_button);
            this.referenceData_groupBox.Controls.Add(this.getBy_comboBox);
            this.referenceData_groupBox.Controls.Add(this.getBy_textBox);
            this.referenceData_groupBox.Controls.Add(this.search_label);
            this.referenceData_groupBox.Controls.Add(this.cancel_button);
            this.referenceData_groupBox.Controls.Add(this.delete_button);
            this.referenceData_groupBox.Controls.Add(this.set_button);
            this.referenceData_groupBox.Controls.Add(this.add_button);
            this.referenceData_groupBox.Location = new System.Drawing.Point(12, 27);
            this.referenceData_groupBox.Name = "referenceData_groupBox";
            this.referenceData_groupBox.Size = new System.Drawing.Size(483, 86);
            this.referenceData_groupBox.TabIndex = 0;
            this.referenceData_groupBox.TabStop = false;
            this.referenceData_groupBox.Text = "Работа с данными";
            // 
            // getBy_button
            // 
            this.getBy_button.Location = new System.Drawing.Point(299, 47);
            this.getBy_button.Name = "getBy_button";
            this.getBy_button.Size = new System.Drawing.Size(75, 23);
            this.getBy_button.TabIndex = 7;
            this.getBy_button.Text = "Найти";
            this.getBy_button.UseVisualStyleBackColor = true;
            this.getBy_button.Click += new System.EventHandler(this.getBy_button_Click);
            // 
            // getBy_comboBox
            // 
            this.getBy_comboBox.FormattingEnabled = true;
            this.getBy_comboBox.Location = new System.Drawing.Point(66, 49);
            this.getBy_comboBox.Name = "getBy_comboBox";
            this.getBy_comboBox.Size = new System.Drawing.Size(121, 21);
            this.getBy_comboBox.TabIndex = 6;
            // 
            // getBy_textBox
            // 
            this.getBy_textBox.Location = new System.Drawing.Point(193, 49);
            this.getBy_textBox.Name = "getBy_textBox";
            this.getBy_textBox.Size = new System.Drawing.Size(100, 20);
            this.getBy_textBox.TabIndex = 5;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(6, 53);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(54, 13);
            this.search_label.TabIndex = 4;
            this.search_label.Text = "Поиск по";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(380, 46);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Сбросить";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(319, 19);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // set_button
            // 
            this.set_button.Location = new System.Drawing.Point(224, 19);
            this.set_button.Name = "set_button";
            this.set_button.Size = new System.Drawing.Size(75, 23);
            this.set_button.TabIndex = 1;
            this.set_button.Text = "Изменить";
            this.set_button.UseVisualStyleBackColor = true;
            this.set_button.Click += new System.EventHandler(this.set_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(134, 19);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(511, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip3";
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
            // referenceData_tabControl
            // 
            this.referenceData_tabControl.Controls.Add(this.tabPage1);
            this.referenceData_tabControl.Controls.Add(this.tabPage2);
            this.referenceData_tabControl.Controls.Add(this.tabPage3);
            this.referenceData_tabControl.Location = new System.Drawing.Point(12, 120);
            this.referenceData_tabControl.Name = "referenceData_tabControl";
            this.referenceData_tabControl.SelectedIndex = 0;
            this.referenceData_tabControl.Size = new System.Drawing.Size(487, 236);
            this.referenceData_tabControl.TabIndex = 2;
            this.referenceData_tabControl.SelectedIndexChanged += new System.EventHandler(this.referenceData_tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Судно";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn,
            this.датапоследнегоТОDataGridViewTextBoxColumn,
            this.названиесуднаDataGridViewTextBoxColumn,
            this.типсуднаDataGridViewTextBoxColumn,
            this.вместимостьDataGridViewTextBoxColumn,
            this.idкомпанииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.судноBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(466, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // регистрационныйномерсуднаDataGridViewTextBoxColumn
            // 
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.DataPropertyName = "Регистрационный_номер_судна";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.HeaderText = "Регистрационный_номер_судна";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.Name = "регистрационныйномерсуднаDataGridViewTextBoxColumn";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датапоследнегоТОDataGridViewTextBoxColumn
            // 
            this.датапоследнегоТОDataGridViewTextBoxColumn.DataPropertyName = "Дата_последнего_ТО";
            this.датапоследнегоТОDataGridViewTextBoxColumn.HeaderText = "Дата_последнего_ТО";
            this.датапоследнегоТОDataGridViewTextBoxColumn.Name = "датапоследнегоТОDataGridViewTextBoxColumn";
            this.датапоследнегоТОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиесуднаDataGridViewTextBoxColumn
            // 
            this.названиесуднаDataGridViewTextBoxColumn.DataPropertyName = "Название_судна";
            this.названиесуднаDataGridViewTextBoxColumn.HeaderText = "Название_судна";
            this.названиесуднаDataGridViewTextBoxColumn.Name = "названиесуднаDataGridViewTextBoxColumn";
            this.названиесуднаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типсуднаDataGridViewTextBoxColumn
            // 
            this.типсуднаDataGridViewTextBoxColumn.DataPropertyName = "Тип_судна";
            this.типсуднаDataGridViewTextBoxColumn.HeaderText = "Тип_судна";
            this.типсуднаDataGridViewTextBoxColumn.Name = "типсуднаDataGridViewTextBoxColumn";
            this.типсуднаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // вместимостьDataGridViewTextBoxColumn
            // 
            this.вместимостьDataGridViewTextBoxColumn.DataPropertyName = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.HeaderText = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.Name = "вместимостьDataGridViewTextBoxColumn";
            this.вместимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idкомпанииDataGridViewTextBoxColumn
            // 
            this.idкомпанииDataGridViewTextBoxColumn.DataPropertyName = "id_компании";
            this.idкомпанииDataGridViewTextBoxColumn.HeaderText = "id_компании";
            this.idкомпанииDataGridViewTextBoxColumn.Name = "idкомпанииDataGridViewTextBoxColumn";
            this.idкомпанииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // судноBindingSource
            // 
            this.судноBindingSource.DataMember = "Судно";
            this.судноBindingSource.DataSource = this.demoDataSet;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(479, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Навигация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номернавигационногопериодаDataGridViewTextBoxColumn,
            this.датаначаланавигацииDataGridViewTextBoxColumn,
            this.датазавершениянавигацииDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.навигацияBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(466, 197);
            this.dataGridView2.TabIndex = 1;
            // 
            // номернавигационногопериодаDataGridViewTextBoxColumn
            // 
            this.номернавигационногопериодаDataGridViewTextBoxColumn.DataPropertyName = "Номер_навигационного_периода";
            this.номернавигационногопериодаDataGridViewTextBoxColumn.HeaderText = "Номер_навигационного_периода";
            this.номернавигационногопериодаDataGridViewTextBoxColumn.Name = "номернавигационногопериодаDataGridViewTextBoxColumn";
            this.номернавигационногопериодаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаначаланавигацииDataGridViewTextBoxColumn
            // 
            this.датаначаланавигацииDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала_навигации";
            this.датаначаланавигацииDataGridViewTextBoxColumn.HeaderText = "Дата_начала_навигации";
            this.датаначаланавигацииDataGridViewTextBoxColumn.Name = "датаначаланавигацииDataGridViewTextBoxColumn";
            this.датаначаланавигацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датазавершениянавигацииDataGridViewTextBoxColumn
            // 
            this.датазавершениянавигацииDataGridViewTextBoxColumn.DataPropertyName = "Дата_завершения_навигации";
            this.датазавершениянавигацииDataGridViewTextBoxColumn.HeaderText = "Дата_завершения_навигации";
            this.датазавершениянавигацииDataGridViewTextBoxColumn.Name = "датазавершениянавигацииDataGridViewTextBoxColumn";
            this.датазавершениянавигацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // навигацияBindingSource
            // 
            this.навигацияBindingSource.DataMember = "Навигация";
            this.навигацияBindingSource.DataSource = this.demoDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(479, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Маршрут";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // судноTableAdapter
            // 
            this.судноTableAdapter.ClearBeforeFill = true;
            // 
            // навигацияTableAdapter
            // 
            this.навигацияTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиемаршрутаDataGridViewTextBoxColumn,
            this.номермаршрутаDataGridViewTextBoxColumn,
            this.пунктотправленияDataGridViewTextBoxColumn,
            this.пунктприбытияDataGridViewTextBoxColumn,
            this.описаниемаршрутаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.маршрутBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(7, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(466, 197);
            this.dataGridView3.TabIndex = 2;
            // 
            // маршрутBindingSource
            // 
            this.маршрутBindingSource.DataMember = "Маршрут";
            this.маршрутBindingSource.DataSource = this.demoDataSet;
            // 
            // маршрутTableAdapter
            // 
            this.маршрутTableAdapter.ClearBeforeFill = true;
            // 
            // названиемаршрутаDataGridViewTextBoxColumn
            // 
            this.названиемаршрутаDataGridViewTextBoxColumn.DataPropertyName = "Название_маршрута";
            this.названиемаршрутаDataGridViewTextBoxColumn.HeaderText = "Название_маршрута";
            this.названиемаршрутаDataGridViewTextBoxColumn.Name = "названиемаршрутаDataGridViewTextBoxColumn";
            this.названиемаршрутаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номермаршрутаDataGridViewTextBoxColumn
            // 
            this.номермаршрутаDataGridViewTextBoxColumn.DataPropertyName = "Номер_маршрута";
            this.номермаршрутаDataGridViewTextBoxColumn.HeaderText = "Номер_маршрута";
            this.номермаршрутаDataGridViewTextBoxColumn.Name = "номермаршрутаDataGridViewTextBoxColumn";
            this.номермаршрутаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пунктотправленияDataGridViewTextBoxColumn
            // 
            this.пунктотправленияDataGridViewTextBoxColumn.DataPropertyName = "Пункт_отправления";
            this.пунктотправленияDataGridViewTextBoxColumn.HeaderText = "Пункт_отправления";
            this.пунктотправленияDataGridViewTextBoxColumn.Name = "пунктотправленияDataGridViewTextBoxColumn";
            this.пунктотправленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пунктприбытияDataGridViewTextBoxColumn
            // 
            this.пунктприбытияDataGridViewTextBoxColumn.DataPropertyName = "Пункт_прибытия";
            this.пунктприбытияDataGridViewTextBoxColumn.HeaderText = "Пункт_прибытия";
            this.пунктприбытияDataGridViewTextBoxColumn.Name = "пунктприбытияDataGridViewTextBoxColumn";
            this.пунктприбытияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниемаршрутаDataGridViewTextBoxColumn
            // 
            this.описаниемаршрутаDataGridViewTextBoxColumn.DataPropertyName = "Описание_маршрута";
            this.описаниемаршрутаDataGridViewTextBoxColumn.HeaderText = "Описание_маршрута";
            this.описаниемаршрутаDataGridViewTextBoxColumn.Name = "описаниемаршрутаDataGridViewTextBoxColumn";
            this.описаниемаршрутаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReferenceDataForm
            // 
            this.ClientSize = new System.Drawing.Size(511, 368);
            this.Controls.Add(this.referenceData_tabControl);
            this.Controls.Add(this.referenceData_groupBox);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "ReferenceDataForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочные данные";
            this.Load += new System.EventHandler(this.ReferenceDataForm_Load_2);
            this.referenceData_groupBox.ResumeLayout(false);
            this.referenceData_groupBox.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.referenceData_tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.судноBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.навигацияBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.GroupBox referenceData_groupBox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button set_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button getBy_button;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ComboBox getBy_comboBox;
        private System.Windows.Forms.TextBox getBy_textBox;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TabControl referenceData_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private demoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource судноBindingSource;
        private demoDataSetTableAdapters.СудноTableAdapter судноTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйномерсуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапоследнегоТОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиесуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типсуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вместимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idкомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource навигацияBindingSource;
        private demoDataSetTableAdapters.НавигацияTableAdapter навигацияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номернавигационногопериодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначаланавигацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазавершениянавигацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource маршрутBindingSource;
        private demoDataSetTableAdapters.МаршрутTableAdapter маршрутTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиемаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номермаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктотправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктприбытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниемаршрутаDataGridViewTextBoxColumn;
    }
}