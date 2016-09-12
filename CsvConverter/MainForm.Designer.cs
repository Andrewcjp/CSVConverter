/*
 * Created by SharpDevelop.
 * User: TCAdmin
 * Date: 08/08/2016
 * Time: 12:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CsvConverter
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.CheckBox ExportGoogle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.ProgressBar MainProgressBar;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.ExportGoogle = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.WeekBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(218, 10);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(54, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(12, 12);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(200, 20);
            this.FilePathTextBox.TabIndex = 1;
            this.FilePathTextBox.TextChanged += new System.EventHandler(this.CheckValidInput);
            // 
            // ExportGoogle
            // 
            this.ExportGoogle.Checked = true;
            this.ExportGoogle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportGoogle.Location = new System.Drawing.Point(12, 72);
            this.ExportGoogle.Name = "ExportGoogle";
            this.ExportGoogle.Size = new System.Drawing.Size(151, 24);
            this.ExportGoogle.TabIndex = 2;
            this.ExportGoogle.Text = "Export to Google CSV";
            this.ExportGoogle.UseVisualStyleBackColor = true;
            this.ExportGoogle.CheckedChanged += new System.EventHandler(this.CheckValidInput);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(11, 131);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButtonClick);
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Location = new System.Drawing.Point(11, 102);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(259, 23);
            this.MainProgressBar.TabIndex = 5;
            // 
            // WeekBox
            // 
            this.WeekBox.Location = new System.Drawing.Point(82, 38);
            this.WeekBox.Name = "WeekBox";
            this.WeekBox.Size = new System.Drawing.Size(100, 20);
            this.WeekBox.TabIndex = 6;
            this.WeekBox.TextChanged += new System.EventHandler(this.CheckValidInput);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Week Prefix";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeekBox);
            this.Controls.Add(this.MainProgressBar);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ExportGoogle);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.LoadButton);
            this.Name = "MainForm";
            this.Text = "CsvConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox WeekBox;
        private System.Windows.Forms.Label label1;
    }
}
