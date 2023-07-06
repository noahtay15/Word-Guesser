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
        public QuestionsScreen(int numPlayers)
        {
            InitializeComponent();
        }

        private void BackToPlayerInitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.MainFrame.NavigationService?.GoBack();

        }

        private void BackToPlayerInitButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = BackToPlayerInitButton.Template.FindName("BackToPlayerInitButtonEllipse", BackToPlayerInitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = BackToPlayerInitButton.Template.FindName("BackToPlayerInitButtonContentPresenter", BackToPlayerInitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void BackToPlayerInitButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = BackToPlayerInitButton.Template.FindName("BackToPlayerInitButtonEllipse", BackToPlayerInitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);

            ContentPresenter? contentPresenter = BackToPlayerInitButton.Template.FindName("BackToPlayerInitButtonContentPresenter", BackToPlayerInitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BorderBrush = Brushes.LightBlue;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BorderBrush = Brushes.Blue;
        }
    }
}
