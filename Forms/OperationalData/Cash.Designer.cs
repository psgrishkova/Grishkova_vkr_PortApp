
namespace Grishkova_vkr_PortApp.Forms.OperationalData
{
    partial class Cash
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
            this.shipsComboBox = new System.Windows.Forms.ComboBox();
            this.routeComboBox = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.passDataGridView = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vesselGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cashGroupBox = new System.Windows.Forms.GroupBox();
            this.priceComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cashierComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.кассаTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.КассаTableAdapter();
            this.персоналTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.ПерсоналTableAdapter();
            this.прайс_листTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Прайс_листTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.судноTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.СудноTableAdapter();
            this.маршрутTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.МаршрутTableAdapter();
            this.категория_гражданTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Категория_гражданTableAdapter();
            this.рейсTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.РейсTableAdapter();
            this.demoDataSet1 = new Grishkova_vkr_PortApp.demoDataSet();
            this.вахтенный_журналTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.Вахтенный_журналTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.passDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.vesselGroupBox.SuspendLayout();
            this.cashGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // shipsComboBox
            // 
            this.shipsComboBox.FormattingEnabled = true;
            this.shipsComboBox.Location = new System.Drawing.Point(68, 44);
            this.shipsComboBox.Name = "shipsComboBox";
            this.shipsComboBox.Size = new System.Drawing.Size(110, 21);
            this.shipsComboBox.TabIndex = 0;
            // 
            // routeComboBox
            // 
            this.routeComboBox.FormattingEnabled = true;
            this.routeComboBox.Location = new System.Drawing.Point(68, 71);
            this.routeComboBox.Name = "routeComboBox";
            this.routeComboBox.Size = new System.Drawing.Size(110, 21);
            this.routeComboBox.TabIndex = 1;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(68, 18);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(110, 20);
            this.timePicker.TabIndex = 2;
            // 
            // passDataGridView
            // 
            this.passDataGridView.AllowUserToAddRows = false;
            this.passDataGridView.AllowUserToDeleteRows = false;
            this.passDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Count});
            this.passDataGridView.Location = new System.Drawing.Point(12, 27);
            this.passDataGridView.Name = "passDataGridView";
            this.passDataGridView.Size = new System.Drawing.Size(265, 240);
            this.passDataGridView.TabIndex = 3;
            // 
            // Category
            // 
            this.Category.Frozen = true;
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Category.Width = 120;
            // 
            // Count
            // 
            this.Count.Frozen = true;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // vesselGroupBox
            // 
            this.vesselGroupBox.Controls.Add(this.label4);
            this.vesselGroupBox.Controls.Add(this.routeComboBox);
            this.vesselGroupBox.Controls.Add(this.label2);
            this.vesselGroupBox.Controls.Add(this.label1);
            this.vesselGroupBox.Controls.Add(this.timePicker);
            this.vesselGroupBox.Controls.Add(this.shipsComboBox);
            this.vesselGroupBox.Location = new System.Drawing.Point(283, 135);
            this.vesselGroupBox.Name = "vesselGroupBox";
            this.vesselGroupBox.Size = new System.Drawing.Size(184, 103);
            this.vesselGroupBox.TabIndex = 5;
            this.vesselGroupBox.TabStop = false;
            this.vesselGroupBox.Text = "Рейс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Маршрут";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Судно";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время";
            // 
            // cashGroupBox
            // 
            this.cashGroupBox.Controls.Add(this.priceComboBox);
            this.cashGroupBox.Controls.Add(this.label5);
            this.cashGroupBox.Controls.Add(this.cashierComboBox);
            this.cashGroupBox.Controls.Add(this.label3);
            this.cashGroupBox.Location = new System.Drawing.Point(283, 27);
            this.cashGroupBox.Name = "cashGroupBox";
            this.cashGroupBox.Size = new System.Drawing.Size(184, 73);
            this.cashGroupBox.TabIndex = 6;
            this.cashGroupBox.TabStop = false;
            this.cashGroupBox.Text = "Касса";
            // 
            // priceComboBox
            // 
            this.priceComboBox.FormattingEnabled = true;
            this.priceComboBox.Location = new System.Drawing.Point(68, 44);
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(110, 21);
            this.priceComboBox.TabIndex = 8;
            this.priceComboBox.SelectedIndexChanged += new System.EventHandler(this.priceComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Прайс, №";
            // 
            // cashierComboBox
            // 
            this.cashierComboBox.FormattingEnabled = true;
            this.cashierComboBox.Location = new System.Drawing.Point(68, 16);
            this.cashierComboBox.Name = "cashierComboBox";
            this.cashierComboBox.Size = new System.Drawing.Size(110, 21);
            this.cashierComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Кассир";
            // 
            // кассаTableAdapter1
            // 
            this.кассаTableAdapter1.ClearBeforeFill = true;
            // 
            // персоналTableAdapter1
            // 
            this.персоналTableAdapter1.ClearBeforeFill = true;
            // 
            // прайс_листTableAdapter1
            // 
            this.прайс_листTableAdapter1.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(392, 244);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // судноTableAdapter1
            // 
            this.судноTableAdapter1.ClearBeforeFill = true;
            // 
            // маршрутTableAdapter1
            // 
            this.маршрутTableAdapter1.ClearBeforeFill = true;
            // 
            // категория_гражданTableAdapter1
            // 
            this.категория_гражданTableAdapter1.ClearBeforeFill = true;
            // 
            // рейсTableAdapter1
            // 
            this.рейсTableAdapter1.ClearBeforeFill = true;
            // 
            // demoDataSet1
            // 
            this.demoDataSet1.DataSetName = "demoDataSet";
            this.demoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вахтенный_журналTableAdapter1
            // 
            this.вахтенный_журналTableAdapter1.ClearBeforeFill = true;
            // 
            // Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 281);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cashGroupBox);
            this.Controls.Add(this.vesselGroupBox);
            this.Controls.Add(this.passDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Cash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Касса";
            this.Load += new System.EventHandler(this.Cash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.vesselGroupBox.ResumeLayout(false);
            this.vesselGroupBox.PerformLayout();
            this.cashGroupBox.ResumeLayout(false);
            this.cashGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox shipsComboBox;
        private System.Windows.Forms.ComboBox routeComboBox;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DataGridView passDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.GroupBox vesselGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox cashGroupBox;
        private System.Windows.Forms.ComboBox priceComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cashierComboBox;
        private System.Windows.Forms.Label label3;
        private demoDataSetTableAdapters.КассаTableAdapter кассаTableAdapter1;
        private demoDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter1;
        private demoDataSetTableAdapters.Прайс_листTableAdapter прайс_листTableAdapter1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button2;
        private demoDataSetTableAdapters.СудноTableAdapter судноTableAdapter1;
        private demoDataSetTableAdapters.МаршрутTableAdapter маршрутTableAdapter1;
        private demoDataSetTableAdapters.Категория_гражданTableAdapter категория_гражданTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private demoDataSetTableAdapters.РейсTableAdapter рейсTableAdapter1;
        private demoDataSet demoDataSet1;
        private demoDataSetTableAdapters.Вахтенный_журналTableAdapter вахтенный_журналTableAdapter1;
    }
}