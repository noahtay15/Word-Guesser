using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Word_Guesser
{
    /// <summary>
    /// Interaction logic for PlayersInitScreen.xaml
    /// </summary>
    public partial class PlayersInitScreen : Page
    {
        public PlayersInitScreen(int numPlayers)
        {
            InitializeComponent();
            if (numPlayers > 0 && numPlayers < 5)
            {
                createPlayerInitBoxes(numPlayers, PlayerInitContainerGrid);
            }
            else
            {
                throw new Exception("Invalid input. Congrats, you shouldn't have been able to get here, yet here you are.");

            }


            /**
            if (numPlayers == 1)
            {
                //createPlayerInitBox("Player 1", 161, 88, 161, 88, PlayerInitContainerGrid);//middle
                createPlayerInitBoxes(1, PlayerInitContainerGrid);
            }
            else if(numPlayers == 2)
            {
                //createPlayerInitBox("Player 1", 10, 88, 213, 88, PlayerInitContainerGrid); //middle left
                //createPlayerInitBox("Player 2", 312, 88, 10, 88, PlayerInitContainerGrid); //middle right
                createPlayerInitBoxes(2, PlayerInitContainerGrid);
            }
            else if(numPlayers == 3)
            {
                //createPlayerInitBox("Player 1", 10, 10, 312, 167, PlayerInitContainerGrid); //top left
                //createPlayerInitBox("Player 2", 10, 167, 312, 10, PlayerInitContainerGrid); //top right
                //createPlayerInitBox("Player 3", 161, 166, 161, 10, PlayerInitContainerGrid); //bottom middle
                createPlayerInitBoxes(3, PlayerInitContainerGrid);
            }
            else if(numPlayers == 4)
            {
                //createPlayerInitBox("Player 1", 10, 10, 312, 167, PlayerInitContainerGrid); //top left
                //createPlayerInitBox("Player 2", 10, 10, 312, 10, PlayerInitContainerGrid); //top right
                //createPlayerInitBox("Player 3", 312, 10, 167, 10, PlayerInitContainerGrid); //bottom left
                //createPlayerInitBox("Player 4", 312, 167, 10, 10, PlayerInitContainerGrid); //bottom right
                createPlayerInitBoxes(4, PlayerInitContainerGrid);
            }
            else
            {
                throw new Exception("Invalid input. Congrats, you shouldn't have been able to get here, yet here you are.");
            }*/

        }

        //creates the player initialization boxes. Calls other methods to fill the contents
        public void createPlayerInitBoxes(int number, Grid parentGrid)
        {

            if (number == 1)
            {
                Grid player1 = new Grid();//player 1 PlayerInitBox

                fillOutPlayerInitBox(1, player1); //put the stuff in the init box

                parentGrid.Children.Add(player1); //put player1 into parentGrid with correct margins
                player1.Margin = new Thickness(161, 88, 161, 88);
            }
            else if (number == 2)
            {
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                Grid player1 = new Grid();
                Grid player2 = new Grid();

                player1 = fillOutPlayerInitBox(1, player1);
                player2 = fillOutPlayerInitBox(2, player2);

                //put the boxes into the correct cells
                Grid.SetRow(player1, 1);
                Grid.SetColumn(player1, 0);

                Grid.SetRow(player2, 1);
                Grid.SetColumn(player2, 1);

                //add playerinitboxes to parentgrid children
                parentGrid.Children.Add(player1);
                parentGrid.Children.Add(player2);

            }
            else if (number == 3)
            {
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                Grid player1 = new Grid();
                Grid player2 = new Grid();
                Grid player3 = new Grid();

                fillOutPlayerInitBox(1, player1);
                fillOutPlayerInitBox(2, player2);
                fillOutPlayerInitBox(3, player3);

                //put the boxes into the correct cells
                Grid.SetRow(player1, 0);
                Grid.SetColumn(player1, 0);

                Grid.SetRow(player2, 0);
                Grid.SetColumn(player2, 2);

                Grid.SetRow(player3 , 1);
                Grid.SetColumn(player3, 2);

                //add playerinitboxes to parentgrid children
                parentGrid.Children.Add(player1);
                parentGrid.Children.Add(player2);
                parentGrid.Children.Add(player3);
            }
            else
            {
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                Grid player1 = new Grid();
                Grid player2 = new Grid();
                Grid player3 = new Grid();
                Grid player4 = new Grid();

                fillOutPlayerInitBox(1, player1);
                fillOutPlayerInitBox(2, player2);
                fillOutPlayerInitBox(3, player3);
                fillOutPlayerInitBox(3, player4);

                //put the boxes into the correct cells
                Grid.SetRow(player1, 0);
                Grid.SetColumn(player1, 0);

                Grid.SetRow(player2, 0);
                Grid.SetColumn(player2, 1);

                Grid.SetRow(player3, 1);
                Grid.SetColumn(player3, 0);

                Grid.SetRow(player4 , 1);
                Grid.SetColumn(player4, 1);

                //add playerinitboxes to parentgrid children
                parentGrid.Children.Add(player1);
                parentGrid.Children.Add(player2);
                parentGrid.Children.Add(player3);
                parentGrid.Children.Add(player4);

            }
        } 

        //gives the playerinitbox its contents
        public Grid fillOutPlayerInitBox(int playerNum, Grid grid)
        {
            //create playerinitbox contents
            //assign them to the correct cells

            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());


            //give the box a title. EX: Player 1
            TextBlock playerText = new TextBlock();
            playerText.Text = "Player " + playerNum;
            playerText.HorizontalAlignment = HorizontalAlignment.Center;
            playerText.VerticalAlignment = VerticalAlignment.Center;
            playerText.TextWrapping = TextWrapping.Wrap;
            playerText.Width = 84;
            playerText.Height = 24;
            playerText.FontSize = 20;
            playerText.Effect = new DropShadowEffect
            {
                Color = Colors.Black,
                ShadowDepth = 0,
                BlurRadius = 5,
                Opacity = 10  
            };
            playerText.Foreground = new SolidColorBrush(Colors.White);

            //Name
            TextBlock nameText = new TextBlock();
            nameText.Text = "Name:";
            nameText.FontSize = 15;

            //Text Box
            TextBox textBox = new TextBox();

            //Color
            TextBlock colorText = new TextBlock();
            colorText.Text = "Color:";
            colorText.FontSize = 15;

            //Color Picker

            //put them in the right cells
            Grid.SetRow(playerText, 0);
            Grid.SetColumn(playerText, 1);

            Grid.SetRow(nameText, 1);
            Grid.SetColumn(nameText, 0);

            Grid.SetRow(textBox, 1);
            Grid.SetColumn(textBox, 2);

            Grid.SetRow(colorText, 2);
            Grid.SetColumn(colorText, 0);


            //add children
            grid.Children.Add(playerText);
            grid.Children.Add(nameText);
            grid.Children.Add(colorText);
            grid.Children.Add(textBox);


            return grid;
        }

        private void BackToPlayerNumberButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.MainFrame.Navigate(new PlayerNumberScreen());
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
    }
}
