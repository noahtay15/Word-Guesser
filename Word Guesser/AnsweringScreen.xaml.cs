using System;
using System.Windows;
using System.Windows.Controls;

namespace Word_Guesser
{
    /// <summary>
    /// Interaction logic for AnsweringScreen.xaml
    /// </summary>
    public partial class AnsweringScreen : Page
    {
        private string hint;
        private string answer;
        private string category;
        private Player[] players;
        private static string[] playerGuesses;
        private static int position = 0;
        private static bool[] arePlayerGuessesCorrect;

        public AnsweringScreen(string hint, string answer, string category, Player[] players)
        {
            InitializeComponent();

            this.hint = hint;
            this.answer = answer;
            this.category = category;
            this.players = players;
            playerGuesses = new string[players.Length]; //figure out how to not lose past values
            CategoryHeader.Text = category;
            HintTextBlock.Text = hint;
            arePlayerGuessesCorrect = new bool[players.Length]; //figure out how to not lose past values
            EnterYourAnswerTextBlock.Text = players[position].getName() + " enter your answer.";
        }

        public bool isGuessCorrect(string guess)
        {
            if(guess.Trim().Equals(this.answer, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void collectAnswer(int i)
        {
            playerGuesses[i] = AnswerBox.Text;
        }

        private void SubmitButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            collectAnswer(position);
            bool isCorrect = isGuessCorrect(playerGuesses[position]);
            arePlayerGuessesCorrect[position] = isCorrect;

            if (position < players.Length -1)
            {
                position++;

                MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow?.MainFrame.Navigate(new AnsweringScreen(this.hint, this.answer, this.category, this.players));
            }
            else
            {
                MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow?.MainFrame.Navigate(new AwardedPointsScreen(players, arePlayerGuessesCorrect, answer, playerGuesses));
            }


        }
    }
}
