using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Word_Guesser
{
    public class Podium : Grid
    {
        string name;
        Color color;
        int points;
        private TextBlock playerScoreBlock;

        public Podium(Player player, double leftMargin, double topMargin, double rightMargin, double bottomMargin, Grid parentGrid)
        {
            this.name = player.getName();
            this.color = player.getPlayerColor();
            this.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);
            this.points = player.getPoints();

            System.Windows.Shapes.Rectangle rectangle = new System.Windows.Shapes.Rectangle();
            System.Windows.Shapes.Ellipse ellipse = new System.Windows.Shapes.Ellipse();
            playerScoreBlock = new TextBlock();
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
            playerScoreBlock.Text = this.points.ToString();
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

        public void addPoints(int num)
        {
            this.points += num;
            this.playerScoreBlock.Text = this.points.ToString();
        }
    }
}
