using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Effects;
using System.Windows.Media;
using System.Text.RegularExpressions;

namespace Word_Guesser
{
    internal class PlayerInitBox : Grid
    {
        private TextBlock playerText = new TextBlock(); //EX: "Player 1"
        private TextBlock nameText = new TextBlock(); //"Name:"
        private TextBox textBox = new TextBox(); //Player input textbox
        private TextBlock colorText = new TextBlock(); //"Color:"
        private ComboBox colorPicker = new ComboBox(); //Color Picker box
        private TextBlock errorMessage = new TextBlock(); //Error message if user input name is invalid
        private int playerNum;

        public PlayerInitBox(Grid parentGrid, int playerNum) 
        {
            this.playerNum = playerNum;
            //add as child of parent grid
            parentGrid.Children.Add(this);

            this.Width = 250;
            this.Height = 200;

            //give the box its title
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
            nameText.Text = "Name:";
            nameText.FontSize = 15;
            nameText.Margin = new Thickness(0, 40, 0, 0);

            //Name input text box
            textBox.FontSize = 10;
            textBox.Height = 15;
            textBox.Margin = new Thickness(50, -95, 50, 0);
            textBox.TextChanged += Validate_Name;

            //Color
            colorText.Text = "Color:";
            colorText.FontSize = 15;
            colorText.Margin = new Thickness(0, 80, 0, 0);

            //Color picker
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
            colorPicker.Margin = new Thickness(50, 80, 135, 100);
            colorPicker.ItemTemplate = itemTemplate;

            //error message
            errorMessage.Text = "";
            errorMessage.Foreground = Brushes.Red;
            errorMessage.Margin = new Thickness(40, 60, 10, 122);
            errorMessage.Visibility = Visibility.Visible;
            errorMessage.FontSize = 9;
            errorMessage.Name = "Error";

            //add children
            this.Children.Add(playerText);
            this.Children.Add(nameText);
            this.Children.Add(colorText);
            this.Children.Add(textBox);
            this.Children.Add(colorPicker);
            this.Children.Add(errorMessage);
        }

        public event EventHandler ValidationPassed;
        public event EventHandler ValidationFailed;
        public event EventHandler ButtonEnabler;

        public void Validate_Name(object sender, TextChangedEventArgs e)
        {
            this.textBox = (TextBox)sender;
            Regex alphaNumeric = new Regex("^[a-zA-Z0-9]*$");
            if (textBox.Text.Length > 12 && !errorMessage.Text.Contains(" Name is too long."))
            {
                errorMessage.Text += " Name is too long.";
                ValidationFailed.Invoke(this, new EventArgs());
            }
            else if (!alphaNumeric.IsMatch(textBox.Text) && !errorMessage.Text.Contains(" Alphanumeric characters only."))
            {
                errorMessage.Text += " Alphanumeric characters only.";
                ValidationFailed.Invoke(this, new EventArgs());
            }
            else if (textBox.Text.Length < 12 && errorMessage.Text.Contains(" Name is too long."))
            {
                errorMessage.Text = errorMessage.Text.Replace(" Name is too long.", "");
            }
            else if (alphaNumeric.IsMatch(textBox.Text) && errorMessage.Text.Contains(" Alphanumeric characters only."))
            {
                errorMessage.Text = errorMessage.Text.Replace(" Alphanumeric characters only.", "");
            }
            else if (errorMessage.Text == "" && textBox.Text != "")
            {
                ValidationPassed.Invoke(this, new EventArgs());
            }
            ButtonEnabler.Invoke(this, new EventArgs());
        }

        public int GetPlayerNum() 
        {
            return playerNum; 
        }

        public String getNewPlayerName()
        {
            return textBox.Text;
        }
    }
}
