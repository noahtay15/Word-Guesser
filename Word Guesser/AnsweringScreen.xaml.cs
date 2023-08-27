using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

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
        private string[] playerGuesses;
        private int position = 0;
        private bool[] arePlayerGuessesCorrect;
        private bool allQuestionsSelected;

        public AnsweringScreen(string hint, string answer, string category, Player[] players, bool allQuestionsSelected)
        {
            InitializeComponent();
            this.allQuestionsSelected = allQuestionsSelected;
            this.hint = hint;
            this.answer = answer;
            this.category = category;
            this.players = players;
            CategoryHeader.Text = category;
            HintTextBlock.Text = hint;
            playerGuesses = new string[players.Length];
            arePlayerGuessesCorrect = new bool[players.Length];
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

                EnterYourAnswerTextBlock.Text = players[position].getName() + " enter your answer.";
                AnswerBox.Text = "";
            }
            else
            {
                MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow?.setAwardedPointsScreen(new AwardedPointsScreen(players, arePlayerGuessesCorrect, answer, playerGuesses, allQuestionsSelected));
                mainWindow?.MainFrame.Navigate(mainWindow.getAwardedPointsScreen());


            }


        }

        private void SubmitButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Ellipse? ellipse = SubmitButton.Template.FindName("SubmitButtonEllipse", SubmitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = SubmitButton.Template.FindName("SubmitButtonEllipse", SubmitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void SubmitButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Ellipse? ellipse = SubmitButton.Template.FindName("SubmitButtonEllipse", SubmitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);

            ContentPresenter? contentPresenter = SubmitButton.Template.FindName("SubmitButtonEllipse", SubmitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);
        }
    }
}
