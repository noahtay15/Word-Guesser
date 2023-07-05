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
        private int numPlayers;
        public PlayersInitScreen(int numPlayers)
        {
            this.numPlayers = numPlayers;
            InitializeComponent();
            if (numPlayers > 0 && numPlayers < 5)
            {
                createPlayerInitBoxes(numPlayers, PlayerInitContainerGrid);
            }
            else
            {
                throw new Exception("Invalid input. Congrats, you shouldn't have been able to get here, yet here you are.");

            }

        }

        //creates the player initialization boxes. Calls other methods to fill the contents
        public void createPlayerInitBoxes(int number, Grid parentGrid)
        {

            if (number == 1)
            {
                Grid player1 = new Grid();//player 1 PlayerInitBox

                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                fillOutPlayerInitBox(1, player1); //put the stuff in the init box

                Grid.SetRow(player1, 1);
                Grid.SetColumn(player1, 1);

                parentGrid.Children.Add(player1); //put player1 into parentGrid with correct margins
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

                fillOutPlayerInitBox(1, player1);
                fillOutPlayerInitBox(2, player2);

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
                Grid.SetColumn(player2, 1);

                Grid.SetRow(player3 , 1);
                Grid.SetColumn(player3, 0);

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
        public void fillOutPlayerInitBox(int playerNum, Grid grid)
        {
            //create playerinitbox contents

            grid.Width = 250;
            grid.Height = 200;

            //give the box a title. EX: Player 1
            TextBlock playerText = new TextBlock();
            playerText.Text = "Player " + playerNum;
            playerText.HorizontalAlignment = HorizontalAlignment.Center;
            playerText.VerticalAlignment = VerticalAlignment.Center;
            playerText.TextWrapping = TextWrapping.Wrap;
            playerText.Width = 84;
            playerText.Height = 28;
            playerText.Margin = new Thickness(0, -150, 0, 0); //Good
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
            nameText.Margin = new Thickness(0, 40, 0, 0); //Good

            //Text Box
            TextBox textBox = new TextBox();
            textBox.FontSize = 10;
            textBox.Height = 15;
            textBox.Margin = new Thickness(50, -95, 50, 0); //Good

            //Color
            TextBlock colorText = new TextBlock();
            colorText.Text = "Color:";
            colorText.FontSize = 15;
            colorText.Margin = new Thickness(0, 80, 0, 0); //Good

            //Color Picker
            ComboBox colorPicker = new ComboBox();
            colorPicker.SelectedIndex = 0;

            DataTemplate itemTemplate = new DataTemplate();
            ComboBoxItem blue = new ComboBoxItem();
            blue.Content = "Blue";
            blue.Tag = "Blue";
            ComboBoxItem green = new ComboBoxItem();
            green.Content = "Green";
            green.Tag = "Green";
            ComboBoxItem red = new ComboBoxItem();
            red.Content = "Red";
            red.Tag = "Red";
            ComboBoxItem purple = new ComboBoxItem();
            purple.Content = "Purple";
            purple.Tag = "Purple";
            ComboBoxItem orange = new ComboBoxItem();
            orange.Content = "Orange";
            orange.Tag = "Orange";
            ComboBoxItem yellow = new ComboBoxItem();
            yellow.Content = "Yellow";
            yellow.Tag = "Yellow";
            ComboBoxItem pink = new ComboBoxItem();
            pink.Content = "Pink";
            pink.Tag = "Pink";

            colorPicker.Items.Add(blue);
            colorPicker.Items.Add(green);
            colorPicker.Items.Add(red);
            colorPicker.Items.Add(purple);
            colorPicker.Items.Add(orange);
            colorPicker.Items.Add(yellow);
            colorPicker.Items.Add(pink);
            colorPicker.Margin = new Thickness(50, 80, 135, 100); //Good
            colorPicker.ItemTemplate = itemTemplate;

            //add children
            grid.Children.Add(playerText);
            grid.Children.Add(nameText);
            grid.Children.Add(colorText);
            grid.Children.Add(textBox);
            grid.Children.Add(colorPicker);
        }

        private void BackToPlayerNumberButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.MainFrame.NavigationService?.GoBack();
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

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //not done

            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.MainFrame.Navigate(new QuestionsScreen(numPlayers));
        }

        private void SubmitButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = SubmitButton.Template.FindName("SubmitButtonEllipse", SubmitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.White);

            ContentPresenter? contentPresenter = SubmitButton.Template.FindName("SubmitButtonContentPresenter", SubmitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.White);
        }

        private void SubmitButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse? ellipse = SubmitButton.Template.FindName("SubmitButtonEllipse", SubmitButton) as Ellipse;
            ellipse?.SetValue(Shape.StrokeProperty, Brushes.Black);

            ContentPresenter? contentPresenter = SubmitButton.Template.FindName("SubmitButtonContentPresenter", SubmitButton) as ContentPresenter;
            contentPresenter?.SetValue(Control.ForegroundProperty, Brushes.Black);
        }
    }
}
