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
            if(numPlayers == 1)
            {
                createPlayerInitBox("Player 1", 161, 88, 161, 88, PlayerInitContainerGrid);//middle
            }
            else if(numPlayers == 2)
            {
                createPlayerInitBox("Player 1", 10, 88, 213, 88, PlayerInitContainerGrid); //middle left
                createPlayerInitBox("Player 2", 312, 88, 10, 88, PlayerInitContainerGrid); //middle right
            }
            else if(numPlayers == 3)
            {
                createPlayerInitBox("Player 1", 10, 10, 312, 167, PlayerInitContainerGrid); //top left
                createPlayerInitBox("Player 2", 10, 167, 312, 10, PlayerInitContainerGrid); //top right
                createPlayerInitBox("Player 3", 161, 166, 161, 10, PlayerInitContainerGrid); //bottom middle
            }
            else if(numPlayers == 4)
            {
                createPlayerInitBox("Player 1", 10, 10, 312, 167, PlayerInitContainerGrid); //top left
                createPlayerInitBox("Player 2", 10, 167, 312, 10, PlayerInitContainerGrid); //top right
                createPlayerInitBox("Player 3", 312, 10, 167, 10, PlayerInitContainerGrid); //bottom left
                createPlayerInitBox("Player 4", 312, 167, 10, 10, PlayerInitContainerGrid); //bottom right
            }
            else
            {
                throw new Exception("Invalid input. Congrats, you shouldn't have been able to get here, yet here you are.");
            }

        }

        public void createPlayerInitBox(String title, double left, double top, double right, double bottom, Grid parentGrid)
        {
            Grid grid = new Grid();
            parentGrid.Children.Add(grid);

            grid.Margin = new Thickness(left, top, right, bottom);

            //Ex: Player 1
            TextBlock playerText = new TextBlock();
            playerText.Text = title;
            playerText.HorizontalAlignment = HorizontalAlignment.Center;
            playerText.VerticalAlignment = VerticalAlignment.Center;
            playerText.Margin = new Thickness(0, 6, 0, 0);
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
            nameText.Margin = new Thickness(65, 46, 194, 92);
            nameText.FontSize = 15;

            //Text Box
            TextBox textBox = new TextBox();
            textBox.Margin = new Thickness(126, 45, 21, 91);

            //Color
            TextBlock colorText = new TextBlock();
            textBox.Text = "Color:";
            textBox.Margin = new Thickness(65, 79, 194, 59);
            textBox.FontSize = 15;

            //Color Picker
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
