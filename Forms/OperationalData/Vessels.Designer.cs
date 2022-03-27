
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.demoDataSet = new Grishkova_vkr_PortApp.demoDataSet();
            this.рейсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рейсTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.РейсTableAdapter();
            this.времярейсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеррейсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номермаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доходзарейсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.капитанDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.времярейсаDataGridViewTextBoxColumn,
            this.номеррейсаDataGridViewTextBoxColumn,
            this.номермаршрутаDataGridViewTextBoxColumn,
            this.доходзарейсDataGridViewTextBoxColumn,
            this.капитанDataGridViewTextBoxColumn,
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.рейсBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рейсBindingSource
            // 
            this.рейсBindingSource.DataMember = "Рейс";
            this.рейсBindingSource.DataSource = this.demoDataSet;
            // 
            // рейсTableAdapter
            // 
            this.рейсTableAdapter.ClearBeforeFill = true;
            // 
            // времярейсаDataGridViewTextBoxColumn
            // 
            this.времярейсаDataGridViewTextBoxColumn.DataPropertyName = "Время_рейса";
            this.времярейсаDataGridViewTextBoxColumn.HeaderText = "Время_рейса";
            this.времярейсаDataGridViewTextBoxColumn.Name = "времярейсаDataGridViewTextBoxColumn";
            // 
            // номеррейсаDataGridViewTextBoxColumn
            // 
            this.номеррейсаDataGridViewTextBoxColumn.DataPropertyName = "Номер_рейса";
            this.номеррейсаDataGridViewTextBoxColumn.HeaderText = "Номер_рейса";
            this.номеррейсаDataGridViewTextBoxColumn.Name = "номеррейсаDataGridViewTextBoxColumn";
            // 
            // номермаршрутаDataGridViewTextBoxColumn
            // 
            this.номермаршрутаDataGridViewTextBoxColumn.DataPropertyName = "Номер_маршрута";
            this.номермаршрутаDataGridViewTextBoxColumn.HeaderText = "Номер_маршрута";
            this.номермаршрутаDataGridViewTextBoxColumn.Name = "номермаршрутаDataGridViewTextBoxColumn";
            // 
            // доходзарейсDataGridViewTextBoxColumn
            // 
            this.доходзарейсDataGridViewTextBoxColumn.DataPropertyName = "Доход_за_рейс";
            this.доходзарейсDataGridViewTextBoxColumn.HeaderText = "Доход_за_рейс";
            this.доходзарейсDataGridViewTextBoxColumn.Name = "доходзарейсDataGridViewTextBoxColumn";
            // 
            // капитанDataGridViewTextBoxColumn
            // 
            this.капитанDataGridViewTextBoxColumn.DataPropertyName = "капитан";
            this.капитанDataGridViewTextBoxColumn.HeaderText = "капитан";
            this.капитанDataGridViewTextBoxColumn.Name = "капитанDataGridViewTextBoxColumn";
            // 
            // регистрационныйномерсуднаDataGridViewTextBoxColumn
            // 
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.DataPropertyName = "Регистрационный_номер_судна";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.HeaderText = "Регистрационный_номер_судна";
            this.регистрационныйномерсуднаDataGridViewTextBoxColumn.Name = "регистрационныйномерсуднаDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Vessels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Vessels";
            this.Text = "Vessels";
            this.Load += new System.EventHandler(this.Vessels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private demoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource рейсBindingSource;
        private demoDataSetTableAdapters.РейсTableAdapter рейсTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn времярейсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеррейсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номермаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn доходзарейсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn капитанDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйномерсуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}