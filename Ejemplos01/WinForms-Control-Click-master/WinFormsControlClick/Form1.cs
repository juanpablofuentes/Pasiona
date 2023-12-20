using System;
using System.Windows.Forms;

namespace WinFormsControlClick
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void controlClick(object sender, EventArgs e)
        {
            var control = (Control)sender;
            MessageBox.Show("Clicked:" + control.Name);
        }

        #endregion
    }
}
