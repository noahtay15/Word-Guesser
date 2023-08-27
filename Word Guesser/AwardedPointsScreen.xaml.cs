using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Shapes;

namespace Word_Guesser
{
    /// <summary>
    /// Interaction logic for AwardedPointsScreen.xaml
    /// </summary>
    public partial class AwardedPointsScreen : Page
    {
        private Player[] players;
        private bool[] areGuessesCorrect;
        private string answer;
        private string[] playerGuesses;
        private TextBlock[,] textBlocks;
        private bool allQuestionsSelected;
        public AwardedPointsScreen(Player[] players, bool[] areGuessesCorrect, string answer, string[] playerGuesses, bool allQuestionsSelected)
        {
            InitializeComponent();
            this.allQuestionsSelected = allQuestionsSelected;
            this.players = players;
            this.areGuessesCorrect = areGuessesCorrect;
            this.playerGuesses = playerGuesses;
            this.answer = answer;
            textBlocks = new TextBlock[players.Length, 2];

            AnswerTextBlock.Text += answer;
            
            //awarding points
            for(int i = 0; i < players.Length; i++)
            {
                if (areGuessesCorrect[i] == true) 
                {
                    players[i].addPoints(100);
                    players[i].getPodium().addPoints(100);
                }
            }

            PointsContainerGrid.ColumnDefinitions.Add(new ColumnDefinition());
            PointsContainerGrid.ColumnDefinitions.Add(new ColumnDefinition());

            for (int i = 0; i < players.Length;i++)
            {
                PointsContainerGrid.RowDefinitions.Add(new RowDefinition());

                //name
                textBlocks[i, 0] = new TextBlock();
                textBlocks[i, 0].Text = players[i].getName() + ": ";
                textBlocks[i, 0].Foreground = Brushes.White;
                textBlocks[i, 0].FontSize = 15;
                textBlocks[i, 0].TextAlignment = TextAlignment.Right;
                textBlocks[i, 0].Effect = new DropShadowEffect
                {
                    Color = Colors.Black,
                    ShadowDepth = 0,
                    BlurRadius = 5,
                    Opacity = 10
                };
                Grid.SetRow(textBlocks[i, 0], i);
                Grid.SetColumn(textBlocks[i, 0], 0);
                PointsContainerGrid.Children.Add(textBlocks[i, 0]);

                //points
                textBlocks[i, 1] = new TextBlock();
                textBlocks[i, 1].FontSize = 15;
                textBlocks[i, 1].TextAlignment = TextAlignment.Left;
                Grid.SetRow(textBlocks[i, 1], i);
                Grid.SetColumn(textBlocks[i, 1], 1);
                if (areGuessesCorrect[i] == true)
                {
                    textBlocks[i, 1].Text = "100";
                    textBlocks[i, 1].Foreground = Brushes.Green;
                }
                else
                {
                    textBlocks[i, 1].Text = "0";
                    textBlocks[i, 1].Foreground = Brushes.Red;
                }
                PointsContainerGrid.Children.Add(textBlocks[i, 1]);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(allQuestionsSelected)
            {
                MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow?.setWinnerScreen(new WinnerScreen(players));
                mainWindow?.MainFrame.Navigate(mainWindow.getWinnerScreen());
            }
            else
            {
                MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow?.MainFrame.Navigate(mainWindow.getQuestionsScreen());
            }
        }

        private void NextButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = NextButton.Template.FindName("NextButtonEllipse", NextButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = NextButton.Template.FindName("NextButtonEllipse", NextButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void NextButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = NextButton.Template.FindName("NextButtonEllipse", NextButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);

            ContentPresenter? contentPresenter = NextButton.Template.FindName("NextButtonEllipse", NextButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);
        }
    }
}
