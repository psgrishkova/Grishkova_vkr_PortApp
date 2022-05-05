
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.названиесуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типсуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапоследнегоТОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.судноBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet = new Grishkova_vkr_PortApp.demoDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.номернавигационногопериодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначаланавигацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазавершениянавигацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.навигацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.названиемаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номермаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктотправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктприбытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниемаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маршрутBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аккаунтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.названиекомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.юридическийадресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.физическийадресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компанияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категориягражданBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.фИОсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.судноTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.СудноTableAdapter();
            this.навигацияTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.НавигацияTableAdapter();
            this.маршрутTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.МаршрутTableAdapter();
            this.аккаунтTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.АккаунтTableAdapter();
            this.компанияTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.КомпанияTableAdapter();
            this.категория_гражданTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Категория_гражданTableAdapter();
            this.персоналTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.ПерсоналTableAdapter();
            this.прайслистBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.прайс_листTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Прайс_листTableAdapter();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.прайслистBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.датасоставленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпрайслистаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номермаршрутаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьбилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аккаунтBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.компанияBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категориягражданBindingSource)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайслистBindingSource)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайслистBindingSource1)).BeginInit();
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
            this.getBy_button.Location = new System.Drawing.Point(299, 49);
            this.getBy_button.Name = "getBy_button";
            this.getBy_button.Size = new System.Drawing.Size(75, 21);
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
            this.cancel_button.Location = new System.Drawing.Point(380, 49);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 21);
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
            // referenceData_tabControl
            // 
            this.referenceData_tabControl.Controls.Add(this.tabPage1);
            this.referenceData_tabControl.Controls.Add(this.tabPage2);
            this.referenceData_tabControl.Controls.Add(this.tabPage3);
            this.referenceData_tabControl.Controls.Add(this.tabPage4);
            this.referenceData_tabControl.Controls.Add(this.tabPage5);
            this.referenceData_tabControl.Controls.Add(this.tabPage6);
            this.referenceData_tabControl.Controls.Add(this.tabPage7);
            this.referenceData_tabControl.Controls.Add(this.tabPage8);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn,
            this.названиесуднаDataGridViewTextBoxColumn,
            this.типсуднаDataGridViewTextBoxColumn,
            this.вместимостьDataGridViewTextBoxColumn,
            this.датапоследнегоТОDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.судноBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(466, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // регистрационныйномерсуднаDataGridViewTextBoxColumn
            // 
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.DataPropertyName = "Регистрационный_номер_судна";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.FillWeight = 83.75635F;
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.HeaderText = "Регистрационный номер";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.Name = "регистрационныйномерсуднаDataGridViewTextBoxColumn";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.ReadOnly = true;
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // названиесуднаDataGridViewTextBoxColumn
            // 
            this.названиесуднаDataGridViewTextBoxColumn.DataPropertyName = "Название_судна";
            this.названиесуднаDataGridViewTextBoxColumn.FillWeight = 83.75635F;
            this.названиесуднаDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиесуднаDataGridViewTextBoxColumn.Name = "названиесуднаDataGridViewTextBoxColumn";
            this.названиесуднаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типсуднаDataGridViewTextBoxColumn
            // 
            this.типсуднаDataGridViewTextBoxColumn.DataPropertyName = "Тип_судна";
            this.типсуднаDataGridViewTextBoxColumn.FillWeight = 83.75635F;
            this.типсуднаDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типсуднаDataGridViewTextBoxColumn.Name = "типсуднаDataGridViewTextBoxColumn";
            this.типсуднаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // вместимостьDataGridViewTextBoxColumn
            // 
            this.вместимостьDataGridViewTextBoxColumn.DataPropertyName = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.FillWeight = 164.9746F;
            this.вместимостьDataGridViewTextBoxColumn.HeaderText = "Вмест.";
            this.вместимостьDataGridViewTextBoxColumn.Name = "вместимостьDataGridViewTextBoxColumn";
            this.вместимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.вместимостьDataGridViewTextBoxColumn.Width = 60;
            // 
            // датапоследнегоТОDataGridViewTextBoxColumn
            // 
            this.датапоследнегоТОDataGridViewTextBoxColumn.DataPropertyName = "Дата_последнего_ТО";
            this.датапоследнегоТОDataGridViewTextBoxColumn.FillWeight = 83.75635F;
            this.датапоследнегоТОDataGridViewTextBoxColumn.HeaderText = "ТО";
            this.датапоследнегоТОDataGridViewTextBoxColumn.Name = "датапоследнегоТОDataGridViewTextBoxColumn";
            this.датапоследнегоТОDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(466, 197);
            this.dataGridView2.TabIndex = 1;
            // 
            // номернавигационногопериодаDataGridViewTextBoxColumn
            // 
            this.номернавигационногопериодаDataGridViewTextBoxColumn.DataPropertyName = "Номер_навигационного_периода";
            this.номернавигационногопериодаDataGridViewTextBoxColumn.HeaderText = "Номер навигационного периода";
            this.номернавигационногопериодаDataGridViewTextBoxColumn.Name = "номернавигационногопериодаDataGridViewTextBoxColumn";
            this.номернавигационногопериодаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаначаланавигацииDataGridViewTextBoxColumn
            // 
            this.датаначаланавигацииDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала_навигации";
            this.датаначаланавигацииDataGridViewTextBoxColumn.HeaderText = "Дата начала навигации";
            this.датаначаланавигацииDataGridViewTextBoxColumn.Name = "датаначаланавигацииDataGridViewTextBoxColumn";
            this.датаначаланавигацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаначаланавигацииDataGridViewTextBoxColumn.Width = 160;
            // 
            // датазавершениянавигацииDataGridViewTextBoxColumn
            // 
            this.датазавершениянавигацииDataGridViewTextBoxColumn.DataPropertyName = "Дата_завершения_навигации";
            this.датазавершениянавигацииDataGridViewTextBoxColumn.HeaderText = "Дата завершения навигации";
            this.датазавершениянавигацииDataGridViewTextBoxColumn.Name = "датазавершениянавигацииDataGridViewTextBoxColumn";
            this.датазавершениянавигацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.датазавершениянавигацииDataGridViewTextBoxColumn.Width = 160;
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
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(466, 197);
            this.dataGridView3.TabIndex = 2;
            // 
            // названиемаршрутаDataGridViewTextBoxColumn
            // 
            this.названиемаршрутаDataGridViewTextBoxColumn.DataPropertyName = "Название_маршрута";
            this.названиемаршрутаDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиемаршрутаDataGridViewTextBoxColumn.Name = "названиемаршрутаDataGridViewTextBoxColumn";
            this.названиемаршрутаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номермаршрутаDataGridViewTextBoxColumn
            // 
            this.номермаршрутаDataGridViewTextBoxColumn.DataPropertyName = "Номер_маршрута";
            this.номермаршрутаDataGridViewTextBoxColumn.HeaderText = "№";
            this.номермаршрутаDataGridViewTextBoxColumn.Name = "номермаршрутаDataGridViewTextBoxColumn";
            this.номермаршрутаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номермаршрутаDataGridViewTextBoxColumn.Width = 30;
            // 
            // пунктотправленияDataGridViewTextBoxColumn
            // 
            this.пунктотправленияDataGridViewTextBoxColumn.DataPropertyName = "Пункт_отправления";
            this.пунктотправленияDataGridViewTextBoxColumn.HeaderText = "Пункт отправления";
            this.пунктотправленияDataGridViewTextBoxColumn.Name = "пунктотправленияDataGridViewTextBoxColumn";
            this.пунктотправленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пунктприбытияDataGridViewTextBoxColumn
            // 
            this.пунктприбытияDataGridViewTextBoxColumn.DataPropertyName = "Пункт_прибытия";
            this.пунктприбытияDataGridViewTextBoxColumn.HeaderText = "Пункт прибытия";
            this.пунктприбытияDataGridViewTextBoxColumn.Name = "пунктприбытияDataGridViewTextBoxColumn";
            this.пунктприбытияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниемаршрутаDataGridViewTextBoxColumn
            // 
            this.описаниемаршрутаDataGridViewTextBoxColumn.DataPropertyName = "Описание_маршрута";
            this.описаниемаршрутаDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниемаршрутаDataGridViewTextBoxColumn.Name = "описаниемаршрутаDataGridViewTextBoxColumn";
            this.описаниемаршрутаDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниемаршрутаDataGridViewTextBoxColumn.Width = 90;
            // 
            // маршрутBindingSource
            // 
            this.маршрутBindingSource.DataMember = "Маршрут";
            this.маршрутBindingSource.DataSource = this.demoDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(479, 210);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Аккаунт";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.рольDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.аккаунтBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(7, 7);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(466, 197);
            this.dataGridView4.TabIndex = 3;
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            this.логинDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // рольDataGridViewTextBoxColumn
            // 
            this.рольDataGridViewTextBoxColumn.DataPropertyName = "Роль";
            this.рольDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.рольDataGridViewTextBoxColumn.Name = "рольDataGridViewTextBoxColumn";
            this.рольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // аккаунтBindingSource
            // 
            this.аккаунтBindingSource.DataMember = "Аккаунт";
            this.аккаунтBindingSource.DataSource = this.demoDataSet;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(479, 210);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Компания";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToResizeColumns = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиекомпанииDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn,
            this.юридическийадресDataGridViewTextBoxColumn,
            this.физическийадресDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.компанияBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(7, 7);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(466, 197);
            this.dataGridView5.TabIndex = 4;
            // 
            // названиекомпанииDataGridViewTextBoxColumn
            // 
            this.названиекомпанииDataGridViewTextBoxColumn.DataPropertyName = "Название_компании";
            this.названиекомпанииDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиекомпанииDataGridViewTextBoxColumn.Name = "названиекомпанииDataGridViewTextBoxColumn";
            this.названиекомпанииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            this.иННDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            this.номертелефонаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // юридическийадресDataGridViewTextBoxColumn
            // 
            this.юридическийадресDataGridViewTextBoxColumn.DataPropertyName = "Юридический_адрес";
            this.юридическийадресDataGridViewTextBoxColumn.HeaderText = "Юридический адрес";
            this.юридическийадресDataGridViewTextBoxColumn.Name = "юридическийадресDataGridViewTextBoxColumn";
            this.юридическийадресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // физическийадресDataGridViewTextBoxColumn
            // 
            this.физическийадресDataGridViewTextBoxColumn.DataPropertyName = "Физический_адрес";
            this.физическийадресDataGridViewTextBoxColumn.HeaderText = "Физический адрес";
            this.физическийадресDataGridViewTextBoxColumn.Name = "физическийадресDataGridViewTextBoxColumn";
            this.физическийадресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // компанияBindingSource
            // 
            this.компанияBindingSource.DataMember = "Компания";
            this.компанияBindingSource.DataSource = this.demoDataSet;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(479, 210);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Категории граждан";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.категорияDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.категориягражданBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(7, 7);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(466, 197);
            this.dataGridView6.TabIndex = 5;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // категориягражданBindingSource
            // 
            this.категориягражданBindingSource.DataMember = "Категория_граждан";
            this.категориягражданBindingSource.DataSource = this.demoDataSet;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridView7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(479, 210);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Персонал";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОсотрудникаDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn1,
            this.датарожденияDataGridViewTextBoxColumn});
            this.dataGridView7.DataSource = this.персоналBindingSource;
            this.dataGridView7.Location = new System.Drawing.Point(7, 7);
            this.dataGridView7.MultiSelect = false;
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView7.Size = new System.Drawing.Size(466, 197);
            this.dataGridView7.TabIndex = 6;
            // 
            // фИОсотрудникаDataGridViewTextBoxColumn
            // 
            this.фИОсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn.HeaderText = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn.Name = "фИОсотрудникаDataGridViewTextBoxColumn";
            this.фИОсотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номертелефонаDataGridViewTextBoxColumn1
            // 
            this.номертелефонаDataGridViewTextBoxColumn1.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn1.HeaderText = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn1.Name = "номертелефонаDataGridViewTextBoxColumn1";
            this.номертелефонаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            this.датарожденияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.demoDataSet;
            // 
            // судноTableAdapter
            // 
            this.судноTableAdapter.ClearBeforeFill = true;
            // 
            // навигацияTableAdapter
            // 
            this.навигацияTableAdapter.ClearBeforeFill = true;
            // 
            // маршрутTableAdapter
            // 
            this.маршрутTableAdapter.ClearBeforeFill = true;
            // 
            // аккаунтTableAdapter
            // 
            this.аккаунтTableAdapter.ClearBeforeFill = true;
            // 
            // компанияTableAdapter
            // 
            this.компанияTableAdapter.ClearBeforeFill = true;
            // 
            // категория_гражданTableAdapter
            // 
            this.категория_гражданTableAdapter.ClearBeforeFill = true;
            // 
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // прайслистBindingSource
            // 
            this.прайслистBindingSource.DataMember = "Прайс_лист";
            this.прайслистBindingSource.DataSource = this.demoDataSet;
            // 
            // прайс_листTableAdapter
            // 
            this.прайс_листTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dataGridView8);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(479, 210);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Цены";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            this.dataGridView8.AllowUserToAddRows = false;
            this.dataGridView8.AllowUserToDeleteRows = false;
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датасоставленияDataGridViewTextBoxColumn,
            this.кодпрайслистаDataGridViewTextBoxColumn,
            this.номермаршрутаDataGridViewTextBoxColumn1,
            this.стоимостьбилетаDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn1});
            this.dataGridView8.DataSource = this.прайслистBindingSource1;
            this.dataGridView8.Location = new System.Drawing.Point(6, 7);
            this.dataGridView8.MultiSelect = false;
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.ReadOnly = true;
            this.dataGridView8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView8.Size = new System.Drawing.Size(466, 197);
            this.dataGridView8.TabIndex = 7;
            // 
            // прайслистBindingSource1
            // 
            this.прайслистBindingSource1.DataMember = "Прайс_лист";
            this.прайслистBindingSource1.DataSource = this.demoDataSet;
            // 
            // датасоставленияDataGridViewTextBoxColumn
            // 
            this.датасоставленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_составления";
            this.датасоставленияDataGridViewTextBoxColumn.HeaderText = "Дата составления";
            this.датасоставленияDataGridViewTextBoxColumn.Name = "датасоставленияDataGridViewTextBoxColumn";
            this.датасоставленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодпрайслистаDataGridViewTextBoxColumn
            // 
            this.кодпрайслистаDataGridViewTextBoxColumn.DataPropertyName = "Код_прайс_листа";
            this.кодпрайслистаDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодпрайслистаDataGridViewTextBoxColumn.Name = "кодпрайслистаDataGridViewTextBoxColumn";
            this.кодпрайслистаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номермаршрутаDataGridViewTextBoxColumn1
            // 
            this.номермаршрутаDataGridViewTextBoxColumn1.DataPropertyName = "Номер_маршрута";
            this.номермаршрутаDataGridViewTextBoxColumn1.HeaderText = "№ маршрута";
            this.номермаршрутаDataGridViewTextBoxColumn1.Name = "номермаршрутаDataGridViewTextBoxColumn1";
            this.номермаршрутаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // стоимостьбилетаDataGridViewTextBoxColumn
            // 
            this.стоимостьбилетаDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_билета";
            this.стоимостьбилетаDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьбилетаDataGridViewTextBoxColumn.Name = "стоимостьбилетаDataGridViewTextBoxColumn";
            this.стоимостьбилетаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // категорияDataGridViewTextBoxColumn1
            // 
            this.категорияDataGridViewTextBoxColumn1.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn1.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn1.Name = "категорияDataGridViewTextBoxColumn1";
            this.категорияDataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReferenceDataForm_FormClosed);
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
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аккаунтBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.компанияBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категориягражданBindingSource)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайслистBindingSource)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайслистBindingSource1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource навигацияBindingSource;
        private demoDataSetTableAdapters.НавигацияTableAdapter навигацияTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource маршрутBindingSource;
        private demoDataSetTableAdapters.МаршрутTableAdapter маршрутTableAdapter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource аккаунтBindingSource;
        private demoDataSetTableAdapters.АккаунтTableAdapter аккаунтTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource компанияBindingSource;
        private demoDataSetTableAdapters.КомпанияTableAdapter компанияTableAdapter;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingSource категориягражданBindingSource;
        private demoDataSetTableAdapters.Категория_гражданTableAdapter категория_гражданTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private demoDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номернавигационногопериодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначаланавигацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазавершениянавигацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиемаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номермаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктотправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктприбытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниемаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйномерсуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиесуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типсуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вместимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапоследнегоТОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиекомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn юридическийадресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn физическийадресDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource прайслистBindingSource;
        private demoDataSetTableAdapters.Прайс_листTableAdapter прайс_листTableAdapter;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасоставленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпрайслистаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номермаршрутаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьбилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource прайслистBindingSource1;
    }
}