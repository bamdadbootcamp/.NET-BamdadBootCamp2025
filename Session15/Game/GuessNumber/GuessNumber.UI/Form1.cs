using GuessNumber.Logic;
using GuessNumber.Logic.Enums;

namespace GuessNumber.UI
{
    public partial class Form1 : Form
    {
        private Game _game;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _game = new Game(GameLevel.Easy);
            MessageBox.Show("Start guessing number");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guessNumber = int.Parse(guessNumberTextBox.Text);
            GameHint hint = _game.CheckGuessNumber(guessNumber);
            switch (hint)
            {
                case GameHint.Up:
                    MessageBox.Show("Up");
                    break;
                case GameHint.Down:
                    MessageBox.Show("Down");
                    break;
                case GameHint.Correct:
                    MessageBox.Show($"Bingo! Duration:{_game.Duration}  Retry count: {_game.RetryCounter}");
                    break;
                default:
                    break;
            }
        }
    }
}