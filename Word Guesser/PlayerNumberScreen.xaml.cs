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
    /// Interaction logic for PlayerNumberScreen.xaml
    /// </summary>
    public partial class PlayerNumberScreen : Page
    {
        private int numPlayers { get; set; }
        public int NumPlayers
        {
            get { return numPlayers; }
            set { numPlayers = value; }
        }

        public PlayerNumberScreen()
        {
            InitializeComponent();
        }

        private void OnePlayerButtonClick(object sender, RoutedEventArgs e)
        {
            NumPlayers = 1;
            LoadPlayerInit(NumPlayers);
        }

        private void TwoPlayerButtonClick(object sender, RoutedEventArgs e)
        {
            NumPlayers = 2;
            LoadPlayerInit(NumPlayers);
        }

        private void ThreePlayerButtonClick(object sender, RoutedEventArgs e)
        {
            NumPlayers = 3;
            LoadPlayerInit(NumPlayers);
        }

        private void FourPlayerButtonClick(object sender, RoutedEventArgs e)
        {
            NumPlayers = 4;
            LoadPlayerInit(NumPlayers);
        }

        private void LoadPlayerInit(int numPlayers)
        {
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.MainFrame.Navigate(new PlayersInitScreen(numPlayers));
        }

        private void BackToTitleButtonClick(object sender, RoutedEventArgs e) 
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.MainFrame.NavigationService?.GoBack();
        }

        private void BackToTitleButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = BackToTitleButton.Template.FindName("BackToTitleButtonEllipse", BackToTitleButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = BackToTitleButton.Template.FindName("BackToTitleButtonContentPresenter", BackToTitleButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void BackToTitleButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ContentPresenter? contentPresenter = BackToTitleButton.Template.FindName("BackToTitleButtonContentPresenter", BackToTitleButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);

            Ellipse? ellipse = BackToTitleButton.Template.FindName("BackToTitleButtonEllipse", BackToTitleButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);
        }

        private void OnePlayerButton_MouseEnter(object sender, MouseEventArgs e)
        {
            ContentPresenter? contentPresenter = OnePlayerButton.Template.FindName("OnePlayerButtonContentPresenter", OnePlayerButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);

            Rectangle? rectangle = OnePlayerButton.Template.FindName("OnePlayerButtonRectangle", OnePlayerButton) as Rectangle;
            rectangle?.SetValue(Shape.StrokeProperty, Brushes.White);
        }

        private void OnePlayerButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ContentPresenter? contentPresenter = OnePlayerButton.Template.FindName("OnePlayerButtonContentPresenter", OnePlayerButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);

            Rectangle? rectangle = OnePlayerButton.Template.FindName("OnePlayerButtonRectangle", OnePlayerButton) as Rectangle;
            rectangle?.SetValue(Shape.StrokeProperty, Brushes.Black);
        }

        private void TwoPlayerButton_MouseEnter(object sender, MouseEventArgs e)
        {
            ContentPresenter? contentPresenter = TwoPlayerButton.Template.FindName("TwoPlayerButtonContentPresenter", TwoPlayerButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);

            Rectangle? rectangle = TwoPlayerButton.Template.FindName("TwoPlayerButtonRectangle", TwoPlayerButton) as Rectangle;
            rectangle?.SetValue(Shape.StrokeProperty, Brushes.White);
        }

        private void TwoPlayerButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ContentPresenter? contentPresenter = TwoPlayerButton.Template.FindName("TwoPlayerButtonContentPresenter", TwoPlayerButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);

            Rectangle? rectangle = TwoPlayerButton.Template.FindName("TwoPlayerButtonRectangle", TwoPlayerButton) as Rectangle;
            rectangle?.SetValue(Shape.StrokeProperty, Brushes.Black);
        }

        private void ThreePlayerButton_MouseEnter(object sender, MouseEventArgs e)
        {
            ContentPresenter? contentPresenter = ThreePlayerButton.Template.FindName("ThreePlayerButtonContentPresenter", ThreePlayerButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);

            Rectangle? rectangle = ThreePlayerButton.Template.FindName("ThreePlayerButtonRectangle", ThreePlayerButton) as Rectangle;
            rectangle?.SetValue(Shape.StrokeProperty, Brushes.White);
        }

        private void ThreePlayerButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ContentPresenter? contentPresenter = ThreePlayerButton.Template.FindName("ThreePlayerButtonContentPresenter", ThreePlayerButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);

            Rectangle? rectangle = ThreePlayerButton.Template.FindName("ThreePlayerButtonRectangle", ThreePlayerButton) as Rectangle;
            rectangle?.SetValue(Shape.StrokeProperty, Brushes.Black);
        }

        private void FourPlayerButton_MouseEnter(object sender, MouseEventArgs e)
        {
            ContentPresenter? contentPresenter = FourPlayerButton.Template.FindName("FourPlayerButtonContentPresenter", FourPlayerButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);

            Rectangle? rectangle = FourPlayerButton.Template.FindName("FourPlayerButtonRectangle", FourPlayerButton) as Rectangle;
            rectangle?.SetValue(Shape.StrokeProperty, Brushes.White);
        }

        private void FourPlayerButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ContentPresenter? contentPresenter = FourPlayerButton.Template.FindName("FourPlayerButtonContentPresenter", FourPlayerButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);

            Rectangle? rectangle = FourPlayerButton.Template.FindName("FourPlayerButtonRectangle", FourPlayerButton) as Rectangle;
            rectangle?.SetValue(Shape.StrokeProperty, Brushes.Black);
        }
    }
}
