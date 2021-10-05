using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int boardSquares;
        PictureBox[,] pictureBox;
        string color = "r";
        string k = "";
        string b1 = "";
        string b2 = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            int left = 1;
            int top = 1;
            boardSquares = 8;
            pictureBox = new PictureBox[boardSquares, boardSquares];
            Color[] colors = new Color[] { Color.Black, Color.Red };
            for (int row = 0; row < boardSquares; row++)
            {
                left = 1;
                //change for if the player chooses black or white pieces.
                if (row % 2 == 0)
                {
                    colors[0] = Color.Black;
                    colors[1] = Color.Red;
                }
                else
                {
                    colors[0] = Color.Red;
                    colors[1] = Color.Black;
                }
                for (int col = 0; col < boardSquares; col++)
                {
                    pictureBox[row, col] = new PictureBox();
                    pictureBox[row, col].BackColor = colors[(col % 2 == 0) ? 1 : 0];
                    pictureBox[row, col].Location = new Point(left, top);
                    pictureBox[row, col].Size = new Size(50, 50);
                    left += 50;
                    pictureBox[row, col].MouseHover += (sender2, e2) =>
                    {
                        PictureBox pictureBoxHovered = sender2 as PictureBox;
                        if (pictureBoxHovered.BackColor == Color.Black)
                        {
                            pictureBoxHovered.BackColor = Color.Gray;
                        }
                    };
                    pictureBox[row, col].MouseLeave += (sender2, e2) =>
                    {
                        PictureBox pictureBoxLeave = sender2 as PictureBox;
                        if (pictureBoxLeave.BackColor == Color.Gray)
                        {
                            pictureBoxLeave.BackColor = Color.Black;
                        }
                    };

                    pictureBox[row, col].Click += (sender3, e3) =>
                    {
                        PictureBox pictureBoxClicked = sender3 as PictureBox;
                        int x = pictureBoxClicked.Location.X;
                        int y = pictureBoxClicked.Location.Y;
                        int countX = 1;
                        int countY = 1;
                        for (int squares = 0; squares < 8; squares++)
                        {
                            if (x > 50)
                            {
                                x -= 50;
                                ++countX;
                            }
                            if (y > 50)
                            {
                                y -= 50;
                                ++countY;
                            }
                        }
                        MessageBox.Show(string.Format("Row: {0} Column: {1}", countY, countX));
                    };

                    panel1.Controls.Add(pictureBox[row, col]);
                }
                top += 50;

            }
        }
    }
}