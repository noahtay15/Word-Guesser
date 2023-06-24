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
    /// Interaction logic for PlayersInitScreen.xaml
    /// </summary>
    public partial class PlayersInitScreen : Page
    {
        public PlayersInitScreen(int numPlayers)
        {
            InitializeComponent();
            if(numPlayers == 1)
            {
                PlayerInitBox box1 = new PlayerInitBox("Player 1");
                //SET THE MARGIN TO THE MIDDLE OF THE GRID
            }
            else if(numPlayers == 2)
            {
                PlayerInitBox box1 = new PlayerInitBox("Player 1");
                //SET THE MARGIN TO LEFT SIDE
                PlayerInitBox box2 = new PlayerInitBox("Player 2");
                //SET THE MARGIN TO RIGHT SIDE
            }
            else if(numPlayers == 3)
            {
                PlayerInitBox box1 = new PlayerInitBox("Player 1");
                //SET THE MARGIN TO THE TOP LEFT CORNER
                PlayerInitBox box2 = new PlayerInitBox("Player 2");
                //SET THE MARGIN TO THE TOP RIGHT CORNER
                PlayerInitBox box3 = new PlayerInitBox("Player 3");
                //SET THE MARGIN TO THE BOTTOM CENTER
            }
            else if(numPlayers == 4)
            {
                PlayerInitBox box1 = new PlayerInitBox("Player 1");
                //SET THE MARGIN TO THE TOP LEFT CORNER
                PlayerInitBox box2 = new PlayerInitBox("Player 2");
                //SET THE MARGIN TO THE TOP RIGHT CORNER
                PlayerInitBox box3 = new PlayerInitBox("Player 3");
                //SET THE MARGIN TO THE BOTTOM RIGHT CORNER
                PlayerInitBox box4 = new PlayerInitBox("Player 4");
                //SET THE MARGIN TO THE BOTTOM RIGHT CORNER
            }
            else
            {
                throw new Exception("Invalid input. Congrats, you shouldn't have been able to get here, yet here you are.");
            }


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
