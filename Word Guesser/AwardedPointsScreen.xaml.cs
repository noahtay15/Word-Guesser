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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Word_Guesser
{
    /// <summary>
    /// Interaction logic for AwardedPointsScreen.xaml
    /// </summary>
    public partial class AwardedPointsScreen : Page
    {
        private Player[] players;
        private bool[] areGuessesCorrect;
        private string answer;
        private string[] playerGuesses;
        private TextBlock[] textBlocks;
        public AwardedPointsScreen(Player[] players, bool[] areGuessesCorrect, string answer, string[] playerGuesses)
        {
            InitializeComponent();
            this.players = players;
            this.areGuessesCorrect = areGuessesCorrect;
            textBlocks = new TextBlock[players.Length * 2];
            
            //awarding points
            for(int i = 0; i < players.Length; i++)
            {
                if (areGuessesCorrect[i] == true) 
                {
                    players[i].addPoints(100);
                }
            }

            PointsContainerGrid.ColumnDefinitions.Add(new ColumnDefinition());
            PointsContainerGrid.ColumnDefinitions.Add(new ColumnDefinition());
            for (int i = 0; i < players.Length;i+=2)
            {
                PointsContainerGrid.RowDefinitions.Add(new RowDefinition());

                //name
                textBlocks[i] = new TextBlock();
                textBlocks[i].Text = players[i].getName() + ":";
                Grid.SetRow(textBlocks[i], i);
                Grid.SetColumn(textBlocks[i], 0);

                //points
                textBlocks[i+1] = new TextBlock();
                Grid.SetRow(textBlocks[i+1], i);
                Grid.SetColumn(textBlocks[i + 1], 1);
                if (areGuessesCorrect[i] == true)
                {
                    textBlocks[i + 1].Text = "100";
                }
                else
                {
                    textBlocks[i + 1].Text = "0";
                }
            }
        }
    }
}
