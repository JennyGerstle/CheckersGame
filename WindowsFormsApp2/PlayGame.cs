using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PlayGame : Form
    {
        const int BOARD_SIZE = 8;
        const int SQUARE_SIZE = 50;
        int difficulty = 0;
        PictureBox[,] squares;
        String startingPlayer = "computer";
        public PlayGame()
        {
            InitializeComponent();
            squares = setUpBoard();
        }
        private void startGame(object sender, EventArgs e)
        {
            populateBoard(squares);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void makePlayerGoFirst(object sender, EventArgs e)
        {
            this.startingPlayer = "user";
        }
        private void selectDifficulty(object sender, EventArgs e)
        {
            //this.difficulty = Convert.ToInt32(cbDifficulty.SelectedItem.ToString());
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //populateBoard();
        }
        public void populateBoard(PictureBox[,] squares)
        {
            Player player;
            for (int row = 0; row < BOARD_SIZE; row++)
            {
                if (!checkBoxColor.Checked)
                {
                    player = Player.PURPLE;
                }
                else
                {
                    player = Player.BLUE;
                }
                for (int col = 0; col < BOARD_SIZE; col++)
                {
                    if (player == Player.PURPLE)
                    {
                        if (row < (BOARD_SIZE / 2) - 1 && squares[row, col].BackColor == Color.Black)
                        {
                            squares[row, col].Image = Properties.Resources.Blue2;
                            squares[row, col].Name = ("Blue2");
                        }
                        else if (row > (BOARD_SIZE / 2) && squares[row, col].BackColor == Color.Black)
                        {
                            squares[row, col].Image = Properties.Resources.Purple1;
                            squares[row, col].Name = ("Purple1");
                        }
                    }
                    else
                    {
                        if (row < (BOARD_SIZE / 2) - 1 && squares[row, col].BackColor == Color.Black)
                        {
                            squares[row, col].Image = Properties.Resources.Purple1;
                            squares[row, col].Name = ("Purple1");
                        }
                        else if (row > (BOARD_SIZE / 2) && squares[row, col].BackColor == Color.Black)
                        {
                            squares[row, col].Image = Properties.Resources.Blue2;
                            squares[row, col].Name = ("Blue2");
                        }
                    }
                    squares[row, col].SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
        public PictureBox[,] setUpBoard()
        {
            cbDifficulty.SelectedIndex = 0;
            int left = 1;
            int top = 1;
            PictureBox[,] squares = new PictureBox[BOARD_SIZE, BOARD_SIZE];
            Color[] colors = new Color[] { Color.Black, Color.Red };
            int row = 0;
            int col = 0;
            try
            {
                for (row = 0; row < BOARD_SIZE; row++)
                {
                    left = 1;
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
                    for (col = 0; col < BOARD_SIZE; col++)
                    {
                        squares[row, col] = new PictureBox();
                        panel1.Controls.Add(squares[row, col]);
                        squares[row, col].BackColor = colors[(col % 2 == 0) ? 1 : 0];
                        squares[row, col].Location = new Point(left, top);
                        squares[row, col].Size = new Size(SQUARE_SIZE, SQUARE_SIZE);
                        left += SQUARE_SIZE;
                        squares[row, col].MouseHover += (sender2, e2) =>
                        {
                            PictureBox pictureBoxHovered = sender2 as PictureBox;
                            if (pictureBoxHovered.BackColor == Color.Black)
                            {
                                pictureBoxHovered.BackColor = Color.Gray;
                            }
                        };
                        squares[row, col].MouseLeave += (sender2, e2) =>
                        {
                            PictureBox pictureBoxLeave = sender2 as PictureBox;
                            if (pictureBoxLeave.BackColor == Color.Gray)
                            {
                                pictureBoxLeave.BackColor = Color.Black;
                            }
                        };

                        squares[row, col].Click += (sender3, e3) =>
                        {
                            PictureBox pictureBoxClicked = sender3 as PictureBox;
                            int x = pictureBoxClicked.Location.X;
                            int y = pictureBoxClicked.Location.Y;
                            MessageBox.Show(string.Format("x: {0} y: {1}", y, x));
                            int countX = 1;
                            int countY = 1;
                            for (int square = 0; square < 8; square++)
                            {
                                if (x > SQUARE_SIZE)
                                {
                                    x -= SQUARE_SIZE;
                                    ++countX;
                                }
                                if (y > SQUARE_SIZE)
                                {
                                    y -= SQUARE_SIZE;
                                    ++countY;
                                }
                            }
                            MessageBox.Show(string.Format("Row: {0} Column: {1}", countY, countX));
                        };

                        panel1.Controls.Add(squares[row, col]);
                    }
                    top += SQUARE_SIZE;
                }
            }
            catch
            {
                MessageBox.Show($" {row},{col}");
            }
            return squares;
        }

        

        
    }
}