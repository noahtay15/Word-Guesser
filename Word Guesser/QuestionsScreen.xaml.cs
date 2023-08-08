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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Word_Guesser
{
    /// <summary>
    /// Interaction logic for QuestionsScreen.xaml
    /// </summary>
    public partial class QuestionsScreen : Page
    {
        private bool isButtonClicked = false;
        private int numPlayers;
        private string[] playerNames;
        private Color[] playerColors;


        public QuestionsScreen(int numPlayers, string[] playerNames, Color[] playerColors)
        {
            InitializeComponent();

            this.numPlayers = numPlayers;
            this.playerNames = playerNames;
            this.playerColors = playerColors;

            Border container = new Border();
            container.CornerRadius = new CornerRadius(5);
			container.Margin = new Thickness(28, 30, 28, 92);
            container.Background = new SolidColorBrush(Colors.Yellow); //temp remove later
			ContainingGrid.Children.Add(container);

            //Creating questions container
            Grid parentGrid = new Grid();
            parentGrid.Background = new SolidColorBrush(Colors.Gray);
            for (int i = 0; i < 5; i++)
            {
                parentGrid.RowDefinitions.Add(new RowDefinition()); //give parent grid 5 rows
            }
            for (int i = 0; i < 5; i++)
            {
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition()); //give parent grid 5 columns
            }
            parentGrid.Name = "QuestionBoxGrid";
            container.Child = parentGrid;

            //Instantiate all of the category headers
            Border headerOne = new Border();
            headerOne.Background = new SolidColorBrush(Colors.White);
            headerOne.CornerRadius = new CornerRadius(5);
            headerOne.BorderBrush = new SolidColorBrush(Colors.Black);
            headerOne.BorderThickness = new Thickness(1);
            TextBlock headerOneTitle = new TextBlock();
            headerOneTitle.Text = "Animals";
            headerOneTitle.FontSize = 10;
            headerOneTitle.HorizontalAlignment = HorizontalAlignment.Center;
            headerOneTitle.VerticalAlignment = VerticalAlignment.Center;
            headerOne.Child = headerOneTitle;
            Grid.SetRow(headerOne, 0);
            Grid.SetColumn(headerOne, 0);
            parentGrid.Children.Add(headerOne);

            Border headerTwo = new Border();
            headerTwo.Background = new SolidColorBrush(Colors.White);
            headerTwo.CornerRadius = new CornerRadius(5);
            headerTwo.BorderBrush = new SolidColorBrush(Colors.Black);
            headerTwo.BorderThickness = new Thickness(1);
            TextBlock headerTwoTitle = new TextBlock();
            headerTwoTitle.Text = "Sports";
            headerTwoTitle.FontSize = 10;
            headerTwoTitle.HorizontalAlignment = HorizontalAlignment.Center;
            headerTwoTitle.VerticalAlignment = VerticalAlignment.Center;
            headerTwo.Child = headerTwoTitle;
            Grid.SetRow(headerTwo, 0);
            Grid.SetColumn(headerTwo, 1);
            parentGrid.Children.Add(headerTwo);

            Border headerThree = new Border();
            headerThree.Background = new SolidColorBrush(Colors.White);
            headerThree.CornerRadius = new CornerRadius(5);
            headerThree.BorderBrush = new SolidColorBrush(Colors.Black);
            headerThree.BorderThickness = new Thickness(1);
            TextBlock headerThreeTitle = new TextBlock();
            headerThreeTitle.Text = "Drinks";
            headerThreeTitle.FontSize = 10;
            headerThreeTitle.HorizontalAlignment = HorizontalAlignment.Center;
            headerThreeTitle.VerticalAlignment = VerticalAlignment.Center;
            headerThree.Child = headerThreeTitle;
            Grid.SetRow(headerThree, 0);
            Grid.SetColumn(headerThree, 2);
            parentGrid.Children.Add(headerThree);

            Border headerFour = new Border();
            headerFour.Background = new SolidColorBrush(Colors.White);
            headerFour.CornerRadius = new CornerRadius(5);
            headerFour.BorderBrush = new SolidColorBrush(Colors.Black);
            headerFour.BorderThickness = new Thickness(1);
            TextBlock headerFourTitle = new TextBlock();
            headerFourTitle.FontSize = 10;
            headerFourTitle.HorizontalAlignment = HorizontalAlignment.Center;
            headerFourTitle.VerticalAlignment = VerticalAlignment.Center;
            headerFourTitle.Text = "Flowers";
            headerFour.Child = headerFourTitle;
            Grid.SetRow(headerFour, 0);
            Grid.SetColumn(headerFour, 3);
            parentGrid.Children.Add(headerFour);

            Border headerFive = new Border();
            headerFive.Background = new SolidColorBrush(Colors.White);
            headerFive.CornerRadius = new CornerRadius(5);
            headerFive.BorderBrush = new SolidColorBrush(Colors.Black);
            headerFive.BorderThickness = new Thickness(1);
            TextBlock headerFiveTitle = new TextBlock();
            headerFiveTitle.Text = "Cities";
            headerFiveTitle.FontSize = 10;
            headerFiveTitle.HorizontalAlignment = HorizontalAlignment.Center;
            headerFiveTitle.VerticalAlignment = VerticalAlignment.Center;
            headerFive.Child = headerFiveTitle;
            Grid.SetRow(headerFive, 0);
            Grid.SetColumn(headerFive, 4);
            parentGrid.Children.Add(headerFive);

            //Instantiate all of the questions
            

            //Instantiate all of the podiums
            if(numPlayers == 1)
            {
                Podium player1Podium = new Podium(playerNames[0], playerColors[0], 249, 359, 469, 0, ContainingGrid); //name, color, margin, parentGrid
            }
            else if(numPlayers == 2)
            {
                Podium player1Podium = new Podium(playerNames[0], playerColors[0], 249, 359, 469, 0, ContainingGrid);
                Podium player2Podium = new Podium(playerNames[1], playerColors[1], 469, 359, 249, 0, ContainingGrid);
            }
            else if(numPlayers == 3)
            {
                Podium player1Podium = new Podium(playerNames[0], playerColors[0], 152, 359, 566, 0, ContainingGrid);
                Podium player2Podium = new Podium(playerNames[1], playerColors[1], 359, 359, 359, 0, ContainingGrid);
                Podium player3Podium = new Podium(playerNames[2], playerColors[2], 566, 359, 152, 0, ContainingGrid);
            }
            else if(numPlayers == 4)
            {
                Podium player1Podium = new Podium(playerNames[0], playerColors[0], 111, 359, 607, 0, ContainingGrid);
                Podium player2Podium = new Podium(playerNames[1], playerColors[1], 265, 359, 453, 0, ContainingGrid);
                Podium player3Podium = new Podium(playerNames[2], playerColors[2], 457, 359, 261, 0, ContainingGrid);
                Podium player4Podium = new Podium(playerNames[3], playerColors[3], 610, 359, 108, 0, ContainingGrid);
            }
            else
            {
                throw new Exception("Once again, congrats. You should have not been able to get here either");
            }
        }

        private void QuestionButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BorderBrush = Brushes.LightBlue;
        }

        private void QuestionButton_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isButtonClicked == false)
            {
                Button button = (Button)sender;
                button.BorderBrush = Brushes.Blue;
            }
        }

        private void QuestionButton_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.InvokeAsync(() =>
            {
                // retrieve the parent grid
                Button button = (Button)sender;
                Grid parentGrid = button.Parent as Grid;

                // retrieve the row and column of the button to be replaced
                int row = Grid.GetRow(button);
                int col = Grid.GetColumn(button);

                // create the border to go inside the grid
                Border border = new Border();
                border.CornerRadius = new CornerRadius(5);
                border.Background = Brushes.Gray;
                border.BorderBrush = Brushes.DarkGray;
                border.BorderThickness = new Thickness(1);
                border.Height = 35;
                border.Width = 50;

                // create the textbox to go inside the border
                TextBlock textBlock = new TextBlock();
                textBlock.Text = "Question 1";
                textBlock.FontSize = 9;
                textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                textBlock.VerticalAlignment = VerticalAlignment.Center;

                // add the textbox to children of the new border
                border.Child = textBlock;

                // remove the button from the parent grid
                parentGrid.Children.Remove(button);

                // put the new grid into the parent grid at the correct place 
                parentGrid.Children.Add(border);
                Grid.SetColumn(border, col);
                Grid.SetRow(border, row);
            });

            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.MainFrame.Navigate(new AnsweringScreen());
        }

        private void BackToPlayerInitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.MainFrame.NavigationService?.GoBack();
        }
    }
}