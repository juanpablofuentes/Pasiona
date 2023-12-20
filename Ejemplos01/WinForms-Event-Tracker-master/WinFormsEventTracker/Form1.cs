using System;
using System.Windows.Forms;

namespace WinFormsEventTracker
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Events

        private void textBoxKeyboard_KeyDown(object sender, KeyEventArgs e)
        {
            this.Log("Key Down: " + e.KeyCode + e.KeyValue);
        }

        private void textBoxKeyboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Log("Key Press: " + e.KeyChar);
        }

        private void textBoxKeyboard_KeyUp(object sender, KeyEventArgs e)
        {
            this.Log("Key Up: " + e.KeyCode + e.KeyValue + " Text is: " + this.textBoxKeyboard.Text);
        }

        private void textBoxKeyboard_TextChanged(object sender, EventArgs e)
        {
            this.Log("Changed: " + " Text is: " + this.textBoxKeyboard.Text);
        }

        private void pictureBoxMouse_MouseEnter(object sender, EventArgs e)
        {
            this.Log("Mouse Enter");
        }

        private void pictureBoxMouse_MouseHover(object sender, EventArgs e)
        {
            this.Log("Mouse Hover");
        }

        private void pictureBoxMouse_MouseDown(object sender, MouseEventArgs e)
        {
            this.Log("Mouse Down: X=" + e.X + "Y=" + e.Y+ " Button=" + e.Button);
        }

        private void pictureBoxMouse_MouseUp(object sender, MouseEventArgs e)
        {
            this.Log("Mouse Down: X=" + e.X + "Y=" + e.Y + " Button=" + e.Button);
        }

        private void pictureBoxMouse_Click(object sender, EventArgs e)
        {
            this.Log("Click");
        }

        private void pictureBoxMouse_DoubleClick(object sender, EventArgs e)
        {
            this.Log("Double Click");
        }

        private void pictureBoxMouse_MouseLeave(object sender, EventArgs e)
        {
            this.Log("Mouse Leave");
        }

        #endregion

        #region Methods

        private void Log(string data)
        {
            this.listBoxLog.Items.Add(data);
            int itemsPerPage = (int)(this.listBoxLog.Height / this.listBoxLog.ItemHeight);
            this.listBoxLog.TopIndex = this.listBoxLog.Items.Count - itemsPerPage;
        }

        #endregion
    }
}
