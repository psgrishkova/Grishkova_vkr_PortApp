
namespace Grishkova_vkr_PortApp.Forms
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceData_button = new System.Windows.Forms.Button();
            this.work_button = new System.Windows.Forms.Button();
            this.report_button = new System.Windows.Forms.Button();
            this.queries_button = new System.Windows.Forms.Button();
            this.menu_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(277, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // referenceData_button
            // 
            this.referenceData_button.Location = new System.Drawing.Point(60, 88);
            this.referenceData_button.Name = "referenceData_button";
            this.referenceData_button.Size = new System.Drawing.Size(155, 33);
            this.referenceData_button.TabIndex = 1;
            this.referenceData_button.Text = "Справочные данные";
            this.referenceData_button.UseVisualStyleBackColor = true;
            // 
            // work_button
            // 
            this.work_button.Location = new System.Drawing.Point(60, 138);
            this.work_button.Name = "work_button";
            this.work_button.Size = new System.Drawing.Size(155, 33);
            this.work_button.TabIndex = 2;
            this.work_button.Text = "Учет работы компании";
            this.work_button.UseVisualStyleBackColor = true;
            // 
            // report_button
            // 
            this.report_button.Location = new System.Drawing.Point(60, 188);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(155, 33);
            this.report_button.TabIndex = 3;
            this.report_button.Text = "Отчеты";
            this.report_button.UseVisualStyleBackColor = true;
            // 
            // queries_button
            // 
            this.queries_button.Location = new System.Drawing.Point(60, 238);
            this.queries_button.Name = "queries_button";
            this.queries_button.Size = new System.Drawing.Size(155, 33);
            this.queries_button.TabIndex = 4;
            this.queries_button.Text = "Запросы";
            this.queries_button.UseVisualStyleBackColor = true;
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(203)));
            this.menu_label.Location = new System.Drawing.Point(105, 49);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(62, 24);
            this.menu_label.TabIndex = 5;
            this.menu_label.Text = "Меню";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 291);
            this.Controls.Add(this.menu_label);
            this.Controls.Add(this.queries_button);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.work_button);
            this.Controls.Add(this.referenceData_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button referenceData_button;
        private System.Windows.Forms.Button work_button;
        private System.Windows.Forms.Button report_button;
        private System.Windows.Forms.Button queries_button;
        private System.Windows.Forms.Label menu_label;
    }
}