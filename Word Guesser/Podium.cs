using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Word_Guesser
{
    internal class Podium : Grid
    {
        string name;
        System.Windows.Media.Color color;

        public Podium(string name, System.Windows.Media.Color color, double leftMargin, double topMargin, double rightMargin, double bottomMargin, Grid parentGrid)
        {
            this.name = name;
            this.color = color;
            this.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);

            System.Windows.Shapes.Rectangle rectangle = new System.Windows.Shapes.Rectangle();
            System.Windows.Shapes.Ellipse ellipse = new System.Windows.Shapes.Ellipse();
            TextBlock playerScoreBlock = new TextBlock();
            TextBlock playerNameBlock = new TextBlock();

            rectangle.Fill = new SolidColorBrush(color);
            rectangle.Stroke = Brushes.Black;
            rectangle.StrokeThickness = 1.5;
            rectangle.Margin = new System.Windows.Thickness(3, 14, 3, 0);
            this.Children.Add(rectangle);

            ellipse.Fill = new SolidColorBrush(color);
            ellipse.Stroke = Brushes.Black;
            ellipse.StrokeThickness = 1.5;
            ellipse.Margin = new System.Windows.Thickness(3, 0, 3, 65);
            this.Children.Add(ellipse);

            playerScoreBlock.Name = "PlayerScorePodium1";
            playerScoreBlock.Background = Brushes.Black;
            playerScoreBlock.FontFamily = new FontFamily("Verdana");
            playerScoreBlock.Foreground = Brushes.Gold;
            playerScoreBlock.FontSize = 14;
            playerScoreBlock.TextAlignment = TextAlignment.Center;
            playerScoreBlock.Margin = new System.Windows.Thickness(18, 44, 18, 31);
            playerScoreBlock.Text = "0";
            this.Children.Add(playerScoreBlock);

            playerNameBlock.Name = "PlayerNamePodium1";
            playerNameBlock.Foreground = Brushes.White;
            playerNameBlock.FontSize = 10;
            playerNameBlock.Text = name;
            playerNameBlock.TextAlignment = TextAlignment.Center;
            playerNameBlock.Margin = new System.Windows.Thickness(14, 6, 14, 71);
            Panel.SetZIndex(playerNameBlock, 1);
            this.Children.Add(playerNameBlock);

            parentGrid.Children.Add(this);
        }
    }
}
