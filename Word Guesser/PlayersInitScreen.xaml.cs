﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private bool[] areAllInputsValid;
        string[] playerNames;
        Color[] playerColors;

        public PlayersInitScreen(int numPlayers)
        {
            this.numPlayers = numPlayers;
            InitializeComponent();
            if (numPlayers > 0 && numPlayers < 5)
            {
                createPlayerInitBoxes(numPlayers, PlayerInitContainerGrid);
                /** This will replace all of the if statement
                 * Grid parentGrid = PlayerInitContainerGrid;
                 * 
                 * if(numPlayers == 1)
                 * {
                 *      parentGrid.RowDefinitions.Add(new RowDefinition());
                        parentGrid.RowDefinitions.Add(new RowDefinition());
                        parentGrid.RowDefinitions.Add(new RowDefinition());
                        parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                        parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                        parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                        PlayerInitBox player1InitBox = new PlayerInitBox(parentGrid, "1");

                        Grid.SetRow(player1InitBox, 1);
                        Grid.SetColumn(player1InitBox, 1);
                 * }
                 * else if(numPlayers == 2)
                 * {
                 *      parentGrid.RowDefinitions.Add(new RowDefinition());
                        parentGrid.RowDefinitions.Add(new RowDefinition());
                        parentGrid.RowDefinitions.Add(new RowDefinition());
                        parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                        parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                        PlayerInitBox player1InitBox = new PlayerInitBox(parentGrid, "1");
                 *      PlayerInitBox player2InitBox = new PlayerInitBox(parentGrid, "2");

                        Grid.SetRow(player1InitBox, 1);
                        Grid.SetColumn(player1InitBox, 0);

                        Grid.SetRow(player2InitBox, 1);
                        Grid.SetColumn(player2InitBox, 1);
                 * }
                 * else if(numPlayers == 3)
                 * {
                 *      parentGrid.RowDefinitions.Add(new RowDefinition());
                        parentGrid.RowDefinitions.Add(new RowDefinition());
                        parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                        parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                        PlayerInitBox player1InitBox = new PlayerInitBox(parentGrid, "1");
                 *      PlayerInitBox player2InitBox = new PlayerInitBox(parentGrid, "2");
                 *      PlayerInitBox player3InitBox = new PlayerInitBox(parentGrid, "3");

                        Grid.SetRow(player1, 0);
                        Grid.SetColumn(player1, 0);

                        Grid.SetRow(player2, 0);
                        Grid.SetColumn(player2, 1);

                        Grid.SetRow(player3 , 1);
                        Grid.SetColumn(player3, 0);
                 *      
                 * }
                 * else if(numPlayers == 4)
                 * {
                 *      parentGrid.RowDefinitions.Add(new RowDefinition());
                        parentGrid.RowDefinitions.Add(new RowDefinition());
                        parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                        parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                        PlayerInitBox player1InitBox = new PlayerInitBox(parentGrid, "1");
                 *      PlayerInitBox player2InitBox = new PlayerInitBox(parentGrid, "2");
                 *      PlayerInitBox player3InitBox = new PlayerInitBox(parentGrid, "3");
                 *      PlayerInitBox player4InitBox = new PlayerInitBox(parentGrid, "4");

                        Grid.SetRow(player1, 0);
                        Grid.SetColumn(player1, 0);

                        Grid.SetRow(player2, 0);
                        Grid.SetColumn(player2, 1);

                        Grid.SetRow(player3, 1);
                        Grid.SetColumn(player3, 0);

                        Grid.SetRow(player4 , 1);
                        Grid.SetColumn(player4, 1);
                 * }
                 * else
                 * {
                 *      throw new Exception("Invalid input. Congrats, you shouldn't have been able to get here, yet here you are.");
                 * }
                 */
            }
            else
            {
                throw new Exception("Invalid input. Congrats, you shouldn't have been able to get here, yet here you are.");
            }
        }

        //creates the player initialization boxes. Calls other methods to fill the contents
        public void createPlayerInitBoxes(int number, Grid parentGrid)
        {
            this.numPlayers = number;

            if (number == 1)
            {
                PlayerInitBox player1 = new PlayerInitBox(parentGrid, 1);//player 1 PlayerInitBox
                playerNames = new string[] {player1.getNewPlayerName()};
                playerColors = new Color[] { player1.getPlayerColor };

                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                Grid.SetRow(player1, 1);
                Grid.SetColumn(player1, 1);

                player1.ValidationPassed += PlayerInitBox_ValidationPassed;
                player1.ValidationFailed += PlayerInitBox_ValidationFailed;
                player1.ButtonEnabler += ButtonEnabler;

                areAllInputsValid = new bool[1];
            }
            else if (number == 2)
            {
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                PlayerInitBox player1 = new PlayerInitBox(parentGrid, 1);
                PlayerInitBox player2 = new PlayerInitBox(parentGrid, 2);

                //put the boxes into the correct cells

                Grid.SetRow(player1, 1);
                Grid.SetColumn(player1, 0);

                Grid.SetRow(player2, 1);
                Grid.SetColumn(player2, 1);

                player1.ValidationPassed += PlayerInitBox_ValidationPassed;
                player1.ValidationFailed += PlayerInitBox_ValidationFailed;
                player1.ButtonEnabler += ButtonEnabler;
                player2.ValidationPassed += PlayerInitBox_ValidationPassed;
                player2.ValidationFailed += PlayerInitBox_ValidationFailed;
                player2.ButtonEnabler += ButtonEnabler;

                areAllInputsValid = new bool[2];
            }
            else if (number == 3)
            {
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                PlayerInitBox player1 = new PlayerInitBox(parentGrid, 1);
                PlayerInitBox player2 = new PlayerInitBox(parentGrid, 2);
                PlayerInitBox player3 = new PlayerInitBox(parentGrid, 3);

                //put the boxes into the correct cells
                Grid.SetRow(player1, 0);
                Grid.SetColumn(player1, 0);

                Grid.SetRow(player2, 0);
                Grid.SetColumn(player2, 1);

                Grid.SetRow(player3 , 1);
                Grid.SetColumn(player3, 0);

                player1.ValidationPassed += PlayerInitBox_ValidationPassed;
                player1.ValidationFailed += PlayerInitBox_ValidationFailed;
                player1.ButtonEnabler += ButtonEnabler;
                player2.ValidationPassed += PlayerInitBox_ValidationPassed;
                player2.ValidationFailed += PlayerInitBox_ValidationFailed;
                player2.ButtonEnabler += ButtonEnabler;
                player3.ValidationPassed += PlayerInitBox_ValidationPassed;
                player3.ValidationFailed += PlayerInitBox_ValidationFailed;
                player3.ButtonEnabler += ButtonEnabler;

                areAllInputsValid = new bool[3];
            }
            else
            {
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.RowDefinitions.Add(new RowDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());
                parentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                PlayerInitBox player1 = new PlayerInitBox(parentGrid, 1);
                PlayerInitBox player2 = new PlayerInitBox(parentGrid, 2);
                PlayerInitBox player3 = new PlayerInitBox(parentGrid, 3);
                PlayerInitBox player4 = new PlayerInitBox(parentGrid, 4);

                //put the boxes into the correct cells
                Grid.SetRow(player1, 0);
                Grid.SetColumn(player1, 0);

                Grid.SetRow(player2, 0);
                Grid.SetColumn(player2, 1);

                Grid.SetRow(player3, 1);
                Grid.SetColumn(player3, 0);

                Grid.SetRow(player4 , 1);
                Grid.SetColumn(player4, 1);

                player1.ValidationPassed += PlayerInitBox_ValidationPassed;
                player1.ValidationFailed += PlayerInitBox_ValidationFailed;
                player1.ButtonEnabler += ButtonEnabler;
                player2.ValidationPassed += PlayerInitBox_ValidationPassed;
                player2.ValidationFailed += PlayerInitBox_ValidationFailed;
                player2.ButtonEnabler += ButtonEnabler;
                player3.ValidationPassed += PlayerInitBox_ValidationPassed;
                player3.ValidationFailed += PlayerInitBox_ValidationFailed;
                player3.ButtonEnabler += ButtonEnabler;
                player4.ValidationPassed += PlayerInitBox_ValidationPassed;
                player4.ValidationFailed += PlayerInitBox_ValidationFailed;
                player4.ButtonEnabler += ButtonEnabler;

                areAllInputsValid = new bool[4];
            }
        } 

        private void BackToPlayerNumberButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
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
            //need send that stuff to instantiate player objects

            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.MainFrame.Navigate(new QuestionsScreen(numPlayers, playerNames, playerColors));
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
        
        private void PlayerInitBox_ValidationPassed(object sender, EventArgs e)
        {
            PlayerInitBox box = (PlayerInitBox)sender;
            areAllInputsValid[box.GetPlayerNum() - 1] = true;
        }

        private void PlayerInitBox_ValidationFailed(object sender, EventArgs e)
        {
            PlayerInitBox box = (PlayerInitBox)sender;
            areAllInputsValid[box.GetPlayerNum() - 1] = false;
        }

        private void ButtonEnabler(object sender, EventArgs e)
        {
            if(areAllInputsValid.Contains(false)) 
            {
                SubmitButton.IsEnabled = false; 
            }
            else
            {
                SubmitButton.IsEnabled = true;
            }
        }
    }
}
