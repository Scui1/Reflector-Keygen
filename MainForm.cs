using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflector_Keygen
{
    public partial class MainForm : Form
    {
        private SerialGenerator serialGenerator = new SerialGenerator();
        private ResponseGenerator responseGenerator = new ResponseGenerator();

        public MainForm()
        {
            InitializeComponent();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            serialTextbox.Text = serialGenerator.GenerateSerial();
        }

        private void requestTextbox_TextChanged(object sender, EventArgs e)
        {
            string text = requestTextbox.Text;
            if (string.IsNullOrEmpty(text))
            {
                requestTextbox.Text = "";
                return;
            }

            try
            {
                responseTextbox.Text = responseGenerator.GenerateResponse(text);
            } catch (Exception ex)
            {
                responseTextbox.Text = "";
                MessageBox.Show("Parsing request failed: " + ex.Message, "Error parsing request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // stuff to make form moveable 

        private bool mouseDown;
        private Point lastLocation;
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
