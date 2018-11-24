using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapClicker
{
    public partial class MainForm : Form
    {
        private StringBuilder _coordinates = new StringBuilder();
        private uint _counter = 1;

        public MainForm()
        {
            InitializeComponent();

        }

        private void DrawGridButton_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(imagePictureBox.Image);
            for (int x = 0; x < int.Parse(xTextBox.Text); x++)
            {
                for (int y = 0; y < int.Parse(yTextBox.Text); y++)
                {
                    g.DrawRectangle(Pens.Black, x * int.Parse(zTextBox.Text), y * int.Parse(zTextBox.Text), int.Parse(zTextBox.Text), int.Parse(zTextBox.Text));
                }
            }

            imagePictureBox.Refresh();
        }


        private void loadImageButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Width = int.Parse(xTextBox.Text)* int.Parse(zTextBox.Text);
                imagePictureBox.Height = int.Parse(yTextBox.Text)* int.Parse(zTextBox.Text);
                using (Bitmap bitmap = new Bitmap(openFileDialog1.FileName))
                {
                    Size size = new Size(imagePictureBox.Width, imagePictureBox.Height);
                    Bitmap newBitmap = new Bitmap(bitmap, size);
                    imagePictureBox.Image = newBitmap;
                }

                drawGridButton.Enabled = true;
                coordinatesListBox.Items.Clear();
                _coordinates = new StringBuilder();
                _counter = 1;
            }
        }

        private void imagePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(imagePictureBox.Image);

            var startX = e.X / int.Parse(zTextBox.Text);
            var startY = e.Y / int.Parse(zTextBox.Text);

            _coordinates.AppendLine($"{_counter}:\t{startX + 1}\t{int.Parse(yTextBox.Text) - startY}");
            coordinatesTextBox.Text = _coordinates.ToString();
            coordinatesListBox.Items.Add($"{_counter}:\t{startX+1}\t{int.Parse(yTextBox.Text)-startY}");
            coordinatesTextBox.SelectionStart = coordinatesTextBox.Text.Length;
            coordinatesTextBox.ScrollToCaret();
            coordinatesListBox.SelectedIndex = coordinatesListBox.Items.Count - 1;
            coordinatesListBox.SelectedIndex = -1;


            g.FillRectangle(Pens.Black.Brush, startX * int.Parse(zTextBox.Text), startY * int.Parse(zTextBox.Text), int.Parse(zTextBox.Text), int.Parse(zTextBox.Text));

            imagePictureBox.Refresh();
            _counter++;

        }

        private void imagePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            var startX = e.X / int.Parse(zTextBox.Text);
            var startY = e.Y / int.Parse(zTextBox.Text);
            coordinatesDisplay.Text = $"{_counter}: {startX + 1} {int.Parse(yTextBox.Text) - startY}";
        }
    }
}
