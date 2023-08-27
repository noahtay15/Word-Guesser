using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Word_Guesser
{
    /// <summary>
    /// Interaction logic for QuestionsScreen.xaml
    /// </summary>
    public partial class QuestionsScreen : Page
    {
        private int numPlayers, numQuestionsSelected = 0;
        Player[] players;
        private Question[,] questions;
        private Podium[] podiums;
        private bool allQuestionsSelected = false;

        public QuestionsScreen(Player[] players)
        {
            InitializeComponent();

            this.numPlayers = players.Length;
            this.players = players;

            Border container = new Border();
            container.CornerRadius = new CornerRadius(5);
			container.Margin = new Thickness(28, 30, 28, 92);
			ContainingGrid.Children.Add(container);

            //Creating questions container
            Grid parentGrid = new Grid();
            parentGrid.Background = new SolidColorBrush(Colors.LightGray);
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
            headerOne.Background = new SolidColorBrush(Colors.Silver);
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
            headerTwo.Background = new SolidColorBrush(Colors.Silver);
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
            headerThree.Background = new SolidColorBrush(Colors.Silver);
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
            headerFour.Background = new SolidColorBrush(Colors.Silver);
            headerFour.CornerRadius = new CornerRadius(5);
            headerFour.BorderBrush = new SolidColorBrush(Colors.Black);
            headerFour.BorderThickness = new Thickness(1);
            TextBlock headerFourTitle = new TextBlock();
            headerFourTitle.FontSize = 10;
            headerFourTitle.HorizontalAlignment = HorizontalAlignment.Center;
            headerFourTitle.VerticalAlignment = VerticalAlignment.Center;
            headerFourTitle.Text = "Fruits";
            headerFour.Child = headerFourTitle;
            Grid.SetRow(headerFour, 0);
            Grid.SetColumn(headerFour, 3);
            parentGrid.Children.Add(headerFour);

            Border headerFive = new Border();
            headerFive.Background = new SolidColorBrush(Colors.Silver);
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
            FileHandler fileHandler = new FileHandler("cities.txt", "fruits.txt", "sports.txt", "drinks.txt", "animals.txt");
            string[,] cities = fileHandler.getCities();
            string[,] fruits = fileHandler.getFruits();
            string[,] sports = fileHandler.getSports();
            string[,] drinks = fileHandler.getDrinks();
            string[,] animals = fileHandler.getAnimals();
            questions = new Question[4, 5];

            //animals sports drinks fruits cities
            for (int i = 0; i < 4; i++) //rows
            {
                for(int j = 0; j < 5; j++) //cols
                {
                    if(j == 0)
                    {
                        questions[i, j] = new Question(animals[i, 0], animals[i, 1], "Animals", i + 1, i + 1, j, parentGrid);
                    }
                    if (j == 1)
                    {
                        questions[i, j] = new Question(sports[i, 0], sports[i, 1], "Sports", i + 1, i + 1, j, parentGrid);
                    }
                    if (j == 2)
                    {
                        questions[i, j] = new Question(drinks[i, 0], drinks[i, 1], "Drinks", i + 1, i + 1, j, parentGrid);
                    }
                    if (j == 3)
                    {
                        questions[i, j] = new Question(fruits[i, 0], fruits[i, 1], "Fruits", i + 1, i + 1, j, parentGrid);
                    }
                    if(j == 4)
                    {
                        questions[i, j] = new Question(cities[i, 0], cities[i, 1], "Cities", i + 1, i + 1, j, parentGrid);
                    }
                }
            }

            foreach(Question question in questions)
            {
                question.MouseEnter += QuestionButton_MouseEnter;
                question.MouseLeave += QuestionButton_MouseLeave;
                question.Click += QuestionButton_Click;
            }

            //Instantiate all of the podiums
            if(numPlayers == 1)
            {
                Podium player1Podium = new Podium(players[0], 359, 359, 359, 0, ContainingGrid); //name, color, margin, parentGrid
                podiums = new Podium[] {player1Podium};
            }
            else if(numPlayers == 2)
            {
                Podium player1Podium = new Podium(players[0], 249, 359, 469, 0, ContainingGrid);
                Podium player2Podium = new Podium(players[1], 469, 359, 249, 0, ContainingGrid);
                podiums = new Podium[] {player1Podium, player2Podium};
                
            }
            else if(numPlayers == 3)
            {
                Podium player1Podium = new Podium(players[0], 152, 359, 566, 0, ContainingGrid);
                Podium player2Podium = new Podium(players[1], 359, 359, 359, 0, ContainingGrid);
                Podium player3Podium = new Podium(players[2], 566, 359, 152, 0, ContainingGrid);
                podiums = new Podium[] {player1Podium, player2Podium, player3Podium};
            }
            else if(numPlayers == 4)
            {
                Podium player1Podium = new Podium(players[0], 111, 359, 607, 0, ContainingGrid);
                Podium player2Podium = new Podium(players[1], 265, 359, 453, 0, ContainingGrid);
                Podium player3Podium = new Podium(players[2], 457, 359, 261, 0, ContainingGrid);
                Podium player4Podium = new Podium(players[3], 610, 359, 108, 0, ContainingGrid);
                podiums = new Podium[] {player1Podium, player2Podium, player3Podium, player4Podium};
            }
            else
            {
                throw new Exception("Once again, congrats. You should have not been able to get here either");
            }
            for(int i = 0; i < numPlayers; i++)
            {
                players[i].setPodium(podiums[i]);
            }
        }

        private void QuestionButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Question question = (Question)sender;
            question.setBorderColor(Brushes.LightBlue);
        }

        private void QuestionButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Question question = (Question)sender;
            if (!question.getHasBeenClicked()) //if it has not been clicked
            {
                question.setBorderColor(Brushes.Blue);
            }
        }

        private void QuestionButton_Click(object sender, RoutedEventArgs e)
        {
            numQuestionsSelected++;
            if (numQuestionsSelected == 20) 
            {
                allQuestionsSelected = true;
            }
            Question question = (Question)sender;
            question.setHasBeenClicked(true);
            Dispatcher.InvokeAsync(() =>
            {
                question.IsEnabled = false;
                question.setBorderColor(Brushes.DarkGray);
                question.setTextColor(Brushes.Black);
            });

            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.setAnsweringScreen(new AnsweringScreen(question.getHint(), question.getAnswer(), question.getCategory(), players, allQuestionsSelected));
            mainWindow?.MainFrame.Navigate(mainWindow.GetAnsweringScreen());
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.setWinnerScreen(new WinnerScreen(players));
            mainWindow?.MainFrame.Navigate(mainWindow.getWinnerScreen());
        }

        private void QuitButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = QuitButton.Template.FindName("QuitButtonEllipse", QuitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = QuitButton.Template.FindName("QuitButtonEllipse", QuitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void QuitButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = QuitButton.Template.FindName("QuitButtonEllipse", QuitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);

            ContentPresenter? contentPresenter = QuitButton.Template.FindName("QuitButtonEllipse", QuitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);
        }
    }
}