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

        public QuestionsScreen(int numPlayers)
        {
            InitializeComponent();

            //Creating questions container
            Grid parentGrid = new Grid();
            for (int i = 0; i < 5; i++)
            {
                parentGrid.RowDefinitions.Add(new RowDefinition()); //give parent grid 5 rows
            }
            for (int i = 0; i < 5; i++)
            {
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition()); //give parent grid 5 columns
            }
            parentGrid.Margin = new Thickness(28, 30, 28, 92);
            parentGrid.Name = "QuestionBoxGrid";

            //Instantiate all of the category headers
            Border headerOne = new Border();
            TextBlock headerOneTitle = new TextBlock();
            headerOneTitle.Text = "Animals";
            Grid.SetRow(headerOne, 0);
            Grid.SetColumn(headerOne, 0);
            parentGrid.Children.Add(headerOne);

            Border headerTwo = new Border();
            TextBlock headerTwoTitle = new TextBlock();
            headerTwoTitle.Text = "Sports";
            Grid.SetRow(headerTwo, 0);
            Grid.SetColumn(headerTwo, 1);
            parentGrid.Children.Add(headerTwo);

            Border headerThree = new Border();
            TextBlock headerThreeTitle = new TextBlock();
            headerThreeTitle.Text = "Drinks";
            Grid.SetRow(headerThree, 0);
            Grid.SetColumn(headerThree, 2);
            parentGrid.Children.Add(headerThree);

            Border headerFour = new Border();
            TextBlock headerFourTitle = new TextBlock();
            headerFourTitle.Text = "Flowers";
            Grid.SetRow(headerFour, 0);
            Grid.SetColumn(headerFour, 3);
            parentGrid.Children.Add(headerFour);

            Border headerFive = new Border();
            TextBlock headerFiveTitle = new TextBlock();
            headerFiveTitle.Text = "Cities";
            Grid.SetRow(headerFive, 0);
            Grid.SetColumn(headerFive, 4);
            parentGrid.Children.Add(headerFive);

            //Instantiate all of the questions


            //Instantiate all of the podiums

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
