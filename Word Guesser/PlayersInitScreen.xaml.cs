using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Word_Guesser
{
    /// <summary>
    /// Interaction logic for PlayersInitScreen.xaml
    /// </summary>
    public partial class PlayersInitScreen : Page
    {
        private int numPlayers;
        private bool[] areAllInputsValid;
        Player[] players;
        Grid parentGrid;

        public PlayersInitScreen(int numPlayers)
        {
            this.numPlayers = numPlayers;
            InitializeComponent();
            if (numPlayers > 0 && numPlayers < 5)
            {
                createPlayerInitBoxes(numPlayers, PlayerInitContainerGrid);
            }
            else
            {
                throw new Exception("Invalid input. Congrats, you shouldn't have been able to get here, yet here you are.");
            }
        }

        //creates the player initialization boxes. Calls other methods to fill the contents
        public void createPlayerInitBoxes(int number, Grid parentGrid)
        {
            this.parentGrid = parentGrid;
            this.numPlayers = number;
            players = new Player[number];

            if (number == 1)
            {
                PlayerInitBox player1 = new PlayerInitBox(parentGrid, 1);//player 1 PlayerInitBox

                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                Grid.SetRow(player1, 1);
                Grid.SetColumn(player1, 1);

                player1.ValidationPassed += PlayerInitBox_ValidationPassed;
                player1.ValidationFailed += PlayerInitBox_ValidationFailed;
                player1.ButtonEnabler += ButtonEnabler;

                areAllInputsValid = new bool[1];
            }
            else if (number == 2)
            {
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                PlayerInitBox player1 = new PlayerInitBox(parentGrid, 1);
                PlayerInitBox player2 = new PlayerInitBox(parentGrid, 2);

                //put the boxes into the correct cells

                Grid.SetRow(player1, 1);
                Grid.SetColumn(player1, 0);

                Grid.SetRow(player2, 1);
                Grid.SetColumn(player2, 1);

                player1.ValidationPassed += PlayerInitBox_ValidationPassed;
                player1.ValidationFailed += PlayerInitBox_ValidationFailed;
                player1.ButtonEnabler += ButtonEnabler;
                player2.ValidationPassed += PlayerInitBox_ValidationPassed;
                player2.ValidationFailed += PlayerInitBox_ValidationFailed;
                player2.ButtonEnabler += ButtonEnabler;

                areAllInputsValid = new bool[2];
            }
            else if (number == 3)
            {
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                PlayerInitBox player1 = new PlayerInitBox(parentGrid, 1);
                PlayerInitBox player2 = new PlayerInitBox(parentGrid, 2);
                PlayerInitBox player3 = new PlayerInitBox(parentGrid, 3);

                //put the boxes into the correct cells
                Grid.SetRow(player1, 0);
                Grid.SetColumn(player1, 0);

                Grid.SetRow(player2, 0);
                Grid.SetColumn(player2, 1);

                Grid.SetRow(player3 , 1);
                Grid.SetColumn(player3, 0);

                player1.ValidationPassed += PlayerInitBox_ValidationPassed;
                player1.ValidationFailed += PlayerInitBox_ValidationFailed;
                player1.ButtonEnabler += ButtonEnabler;
                player2.ValidationPassed += PlayerInitBox_ValidationPassed;
                player2.ValidationFailed += PlayerInitBox_ValidationFailed;
                player2.ButtonEnabler += ButtonEnabler;
                player3.ValidationPassed += PlayerInitBox_ValidationPassed;
                player3.ValidationFailed += PlayerInitBox_ValidationFailed;
                player3.ButtonEnabler += ButtonEnabler;

                areAllInputsValid = new bool[3];
            }
            else
            {
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                PlayerInitBox player1 = new PlayerInitBox(parentGrid, 1);
                PlayerInitBox player2 = new PlayerInitBox(parentGrid, 2);
                PlayerInitBox player3 = new PlayerInitBox(parentGrid, 3);
                PlayerInitBox player4 = new PlayerInitBox(parentGrid, 4);

                //put the boxes into the correct cells
                Grid.SetRow(player1, 0);
                Grid.SetColumn(player1, 0);

                Grid.SetRow(player2, 0);
                Grid.SetColumn(player2, 1);

                Grid.SetRow(player3, 1);
                Grid.SetColumn(player3, 0);

                Grid.SetRow(player4 , 1);
                Grid.SetColumn(player4, 1);

                player1.ValidationPassed += PlayerInitBox_ValidationPassed;
                player1.ValidationFailed += PlayerInitBox_ValidationFailed;
                player1.ButtonEnabler += ButtonEnabler;
                player2.ValidationPassed += PlayerInitBox_ValidationPassed;
                player2.ValidationFailed += PlayerInitBox_ValidationFailed;
                player2.ButtonEnabler += ButtonEnabler;
                player3.ValidationPassed += PlayerInitBox_ValidationPassed;
                player3.ValidationFailed += PlayerInitBox_ValidationFailed;
                player3.ButtonEnabler += ButtonEnabler;
                player4.ValidationPassed += PlayerInitBox_ValidationPassed;
                player4.ValidationFailed += PlayerInitBox_ValidationFailed;
                player4.ButtonEnabler += ButtonEnabler;

                areAllInputsValid = new bool[4];
            }
        } 

        private String getPlayerName(PlayerInitBox player)
        {
            return player.getNewPlayerName();
        }

        private Color getPlayerColor(PlayerInitBox player)
        {
            return player.getPlayerColor();
        }

        private void BackToPlayerNumberButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.MainFrame.NavigationService?.GoBack();
        }

        private void BackToPlayerNumberButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = BackToPlayerNumberButton.Template.FindName("BackToPlayerNumberButtonEllipse", BackToPlayerNumberButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = BackToPlayerNumberButton.Template.FindName("BackToPlayerNumberButtonContentPresenter", BackToPlayerNumberButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void BackToPlayerNumberButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = BackToPlayerNumberButton.Template.FindName("BackToPlayerNumberButtonEllipse", BackToPlayerNumberButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);

            ContentPresenter? contentPresenter = BackToPlayerNumberButton.Template.FindName("BackToPlayerNumberButtonContentPresenter", BackToPlayerNumberButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //not done
            //need to send that stuff to instantiate player objects

            //take the submitted names and colors and put them in their respective arrays
            int i = 0;
            foreach (UIElement child in parentGrid.Children)
            {
                if (child is PlayerInitBox playerBox)
                {
                    players[i] = new Player(getPlayerName(playerBox), getPlayerColor(playerBox));
                    i++;
                }
            }

            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            QuestionsScreen questionsScreen = new QuestionsScreen(players);
            mainWindow?.setQuestionsScreen(questionsScreen);
            mainWindow?.MainFrame.Navigate(questionsScreen);
        }

        private void SubmitButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = SubmitButton.Template.FindName("SubmitButtonEllipse", SubmitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = SubmitButton.Template.FindName("SubmitButtonContentPresenter", SubmitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void SubmitButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = SubmitButton.Template.FindName("SubmitButtonEllipse", SubmitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);

            ContentPresenter? contentPresenter = SubmitButton.Template.FindName("SubmitButtonContentPresenter", SubmitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);
        }
        
        private void PlayerInitBox_ValidationPassed(object sender, EventArgs e)
        {
            PlayerInitBox box = (PlayerInitBox)sender;
            areAllInputsValid[box.GetPlayerNum() - 1] = true;
        }

        private void PlayerInitBox_ValidationFailed(object sender, EventArgs e)
        {
            PlayerInitBox box = (PlayerInitBox)sender;
            areAllInputsValid[box.GetPlayerNum() - 1] = false;
        }

        private void ButtonEnabler(object sender, EventArgs e)
        {
            if(areAllInputsValid.Contains(false)) 
            {
                SubmitButton.IsEnabled = false; 
            }
            else
            {
                SubmitButton.IsEnabled = true;
            }
        }
    }
}
