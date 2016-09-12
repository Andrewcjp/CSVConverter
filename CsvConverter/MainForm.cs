/*
 * Created by SharpDevelop.
 * User: TCAdmin
 * Date: 08/08/2016
 * Time: 12:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CsvConverter
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        CSVConverter _converter;
        string _filePath = "";
        string _fileName = "";
        bool _hadLoadedFile = false;
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.    
            InitializeComponent();
            _converter = new CSVConverter();
            openFileDialog = new OpenFileDialog();
            ConvertButton.Enabled = false;
            openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            openFileDialog.Filter = "Comma Seperated Value files (*.CSV)|*.CSV";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
        }

        void LoadButtonClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _filePath = Path.GetDirectoryName(openFileDialog.FileName);
                    _fileName = openFileDialog.FileName;
                    _hadLoadedFile = true;
                }
                catch (IOException)
                {
                    _filePath = "";
                    _hadLoadedFile = false;
                }
                FilePathTextBox.Text = Path.GetFullPath(openFileDialog.FileName);
                //todo: deal with file in use error
            }

        }

        void CheckValidInput(object sender, EventArgs e)
        {
            if (ExportGoogle.CheckState == CheckState.Checked && _filePath != null && _hadLoadedFile == true && WeekBox.Text != "")
            {
                ConvertButton.Enabled = true;
            }
            else
            {
                ConvertButton.Enabled = false;
            }
        }
        void ConvertButtonClick(object sender, EventArgs e)
        {
            MainProgressBar.Value = 0;
            if (ExportGoogle.CheckState == CheckState.Checked)
            {
                _converter._weekPrefix = WeekBox.Text;
                _converter.ConvertCSV(_filePath, _fileName);
            }
            ConvertButton.Enabled = false;
            MainProgressBar.Value = 100;
            MessageBox.Show("Export Complete");
            MainProgressBar.Value = 0;
            CheckValidInput(sender, e);
        }

    }
}
