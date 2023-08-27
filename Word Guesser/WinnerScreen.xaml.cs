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
    /// Interaction logic for WinnerScreen.xaml
    /// </summary>
    public partial class WinnerScreen : Page
    {
        Player[] players;
        TextBlock[,] textBlocks;

        public WinnerScreen(Player[] players)
        {
            InitializeComponent();
            this.players = players;
            this.textBlocks = new TextBlock[players.Length, 2];

            //sort by scores highest to lowest
            //max n is 4 so no need for efficient sorting algo
            if(players.Length > 1) 
            {
                for(int i = 0; i < players.Length; i++)
                {
                    for(int j = 0; j < players.Length; j++)
                    {
                        if (players[j].getPoints() < players[i].getPoints())
                        {
                            Player temp = players[j];
                            players[j] = players[i];
                            players[i] = temp;
                        }
                    }
                }
            }

            ScoresGrid.ColumnDefinitions.Add(new ColumnDefinition());
            ScoresGrid.ColumnDefinitions.Add(new ColumnDefinition());
            for(int i = 0; i < players.Length; i++)
            {
                ScoresGrid.RowDefinitions.Add(new RowDefinition());

                textBlocks[i, 0] = new TextBlock();
                textBlocks[i, 0].Text = players[i].getName() + ":";
                textBlocks[i, 0].Foreground = Brushes.White;
                textBlocks[i, 0].TextAlignment = TextAlignment.Left;
                textBlocks[i, 0].FontSize = 15;
                Grid.SetColumn(textBlocks[i, 0], 0);
                Grid.SetRow(textBlocks[i, 0], i);
                ScoresGrid.Children.Add(textBlocks[i, 0]);

                textBlocks[i, 1] = new TextBlock();
                textBlocks[i, 1].Text = players[i].getPoints().ToString();
                textBlocks[i, 1].Foreground = Brushes.Gold;
                textBlocks[i, 1].FontFamily = new FontFamily("Verdana");
                textBlocks[i, 1].TextAlignment = TextAlignment.Left;
                textBlocks[i, 1].FontSize = 15;
                Grid.SetColumn(textBlocks[i, 1], 1);
                Grid.SetRow(textBlocks[i, 1], i);
                ScoresGrid.Children.Add(textBlocks[i, 1]);
            }

            if (players.Length > 1 && players[0].getPoints() == players[1].getPoints())
            {
                WinnerTextBlock.Text = "It's a Tie!";
            }
            else
            {
                WinnerTextBlock.Text = players[0].getName() + " wins!";
            }
            WinnerTextBlock.Effect = new DropShadowEffect
            {
                Color = Colors.Black,
                ShadowDepth = 0,
                BlurRadius = 5,
                Opacity = 10
            };
        }

        public void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.setTitleScreen(new TitleScreen());
            mainWindow?.MainFrame.Navigate(mainWindow.getTitleScreen());
        }

        private void MainMenuButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = MainMenuButton.Template.FindName("MainMenuButtonEllipse", MainMenuButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = MainMenuButton.Template.FindName("MainMenuButtonContentPresenter", MainMenuButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void MainMenuButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = MainMenuButton.Template.FindName("MainMenuButtonEllipse", MainMenuButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);

            ContentPresenter? contentPresenter = MainMenuButton.Template.FindName("MainMenuButtonContentPresenter", MainMenuButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);
        }
    }
}
