
namespace Grishkova_vkr_PortApp.Forms.OperationalData
{
    partial class WorkingDay
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
            this.label1 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cashierComboBox = new System.Windows.Forms.ComboBox();
            this.навигацияTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.НавигацияTableAdapter();
            this.персоналTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.ПерсоналTableAdapter();
            this.кассаTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.КассаTableAdapter();
            this.demoDataSet = new Grishkova_vkr_PortApp.demoDataSet();
            this.кассирBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кассирTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.КассирTableAdapter();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассирBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Кассир: ";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(29, 36);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(33, 13);
            this.date_label.TabIndex = 20;
            this.date_label.Text = "Дата";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(68, 33);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Продолжить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashierComboBox
            // 
            this.cashierComboBox.FormattingEnabled = true;
            this.cashierComboBox.Location = new System.Drawing.Point(68, 65);
            this.cashierComboBox.Name = "cashierComboBox";
            this.cashierComboBox.Size = new System.Drawing.Size(125, 21);
            this.cashierComboBox.TabIndex = 23;
            // 
            // навигацияTableAdapter1
            // 
            this.навигацияTableAdapter1.ClearBeforeFill = true;
            // 
            // персоналTableAdapter1
            // 
            this.персоналTableAdapter1.ClearBeforeFill = true;
            // 
            // кассаTableAdapter1
            // 
            this.кассаTableAdapter1.ClearBeforeFill = true;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кассирBindingSource
            // 
            this.кассирBindingSource.DataMember = "Кассир";
            this.кассирBindingSource.DataSource = this.demoDataSet;
            // 
            // кассирTableAdapter
            // 
            this.кассирTableAdapter.ClearBeforeFill = true;
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.demoDataSet;
            // 
            // WorkingDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 132);
            this.Controls.Add(this.cashierComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "WorkingDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена";
            this.Load += new System.EventHandler(this.WorkingDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассирBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cashierComboBox;
        private demoDataSetTableAdapters.НавигацияTableAdapter навигацияTableAdapter1;
        private demoDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter1;
        private demoDataSetTableAdapters.КассаTableAdapter кассаTableAdapter1;
        private demoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource кассирBindingSource;
        private demoDataSetTableAdapters.КассирTableAdapter кассирTableAdapter;
        private System.Windows.Forms.BindingSource персоналBindingSource;
    }
}