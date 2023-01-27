namespace Checkerboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //The method by which we create the buttons
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];

            //Coordinates of the buttons
            int top = 2;
            int left = 2;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = 65;
                    buttons[i, j].Width = 65;
                    buttons[i, j].Top = top;
                    buttons[i, j].Left = left;

                    //The method where we determine whether the button will be black or white
                    Colors(buttons, i, j);

                    left += 65;
                    this.Controls.Add(buttons[i, j]);
                }
                top += 65;
                left = 2;
            }
        }

        private static void Colors(Button[,] buttons, int i, int j)
        {
            //If i+j is even, we made the button black, if odd, white
            if ((i + j) % 2 == 0)
            {
                buttons[i, j].BackColor = Color.Black;
            }
            else
            {
                buttons[i, j].BackColor = Color.White;
            }
        }
    }
}