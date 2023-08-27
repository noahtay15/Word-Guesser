using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Word_Guesser
{
    /// <summary>
    /// Interaction logic for TitleScreen.xaml
    /// </summary>
    public partial class TitleScreen : Page
    {
        public TitleScreen()
        {
            InitializeComponent();
        }
        /**
         * Event handler for when a player clicks the Play button on the Title Screen.
         * It closes the Title Screen and opens the Player Number Screen
         */
        private void PlayButtonMouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = PlayButton.Template.FindName("PlayButtonEllipse", PlayButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = PlayButton.Template.FindName("PlayButtonContentPresenter", PlayButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void PlayButtonMouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = PlayButton.Template.FindName("PlayButtonEllipse", PlayButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);

            ContentPresenter? contentPresenter = PlayButton.Template.FindName("PlayButtonContentPresenter", PlayButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);
        }

        private void QuitButtonMouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = QuitButton.Template.FindName("QuitButtonEllipse", QuitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = QuitButton.Template.FindName("QuitButtonContentPresenter", QuitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void QuitButtonMouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = QuitButton.Template.FindName("QuitButtonEllipse", QuitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);

            ContentPresenter? contentPresenter = QuitButton.Template.FindName("QuitButtonContentPresenter", QuitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);
        }

        private void QuitButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PlayButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.setPlayerNumberScreen(new PlayerNumberScreen());
            mainWindow?.MainFrame.Navigate(mainWindow.getPlayerNumberScreen());
        }
    } 
}
