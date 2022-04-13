
namespace Grishkova_vkr_PortApp.Forms.Reports
{
    partial class SetDatesForReport
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.demoDataSet = new Grishkova_vkr_PortApp.demoDataSet();
            this.reportAboutShiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportAboutShiftsTableAdapter = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.ReportAboutShiftsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportProfitTableAdapter1 = new Grishkova_vkr_PortApp.demoDataSetTableAdapters.ReportProfitTableAdapter();
            this.reportProfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportAboutShiftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportProfitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(367, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(624, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начало периода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Конец периода";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 36);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(936, 673);
            this.crystalReportViewer1.TabIndex = 5;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportAboutShiftsBindingSource
            // 
            this.reportAboutShiftsBindingSource.DataMember = "ReportAboutShifts";
            this.reportAboutShiftsBindingSource.DataSource = this.demoDataSet;
            // 
            // reportAboutShiftsTableAdapter
            // 
            this.reportAboutShiftsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 450;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "График сменности капитанов за указанный период",
            "Отчет о доходах и расходах в денежном выражении по судам за указанный период"});
            this.comboBox1.Location = new System.Drawing.Point(12, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // reportProfitTableAdapter1
            // 
            this.reportProfitTableAdapter1.ClearBeforeFill = true;
            // 
            // reportProfitBindingSource
            // 
            this.reportProfitBindingSource.DataMember = "ReportProfit";
            this.reportProfitBindingSource.DataSource = this.demoDataSet;
            // 
            // SetDatesForReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 721);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SetDatesForReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetDatesForReport";
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportAboutShiftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportProfitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private demoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource reportAboutShiftsBindingSource;
        private demoDataSetTableAdapters.ReportAboutShiftsTableAdapter reportAboutShiftsTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private demoDataSetTableAdapters.ReportProfitTableAdapter reportProfitTableAdapter1;
        private System.Windows.Forms.BindingSource reportProfitBindingSource;
    }
}