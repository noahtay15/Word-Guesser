using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

internal class Question : Button
{
	private string hint;
	private string answer;
    private string category;
    private Border border;
    private bool hasBeenClicked = false;
    private TextBlock textBlock;


    public Question(string answer, string hint, string category, int questionNum, int row, int col, Grid parentGrid)
    {
        this.hint = hint;
        this.answer = answer;
        this.category = category;

        Border border = new Border();
        border.CornerRadius = new CornerRadius(5);
        this.border = border;

        Style borderStyle = new Style();
        borderStyle.Setters.Add(new Setter(Border.CornerRadiusProperty, new CornerRadius(5)));
        border.Style = borderStyle;

        this.Background = new SolidColorBrush(Colors.DarkBlue);
        this.BorderBrush = new SolidColorBrush(Colors.Blue);
        Grid.SetRow(border, row);
        Grid.SetColumn(border, col);


        //design textblock
        textBlock = new TextBlock();
        textBlock.Text = "Question " + questionNum;
        textBlock.Foreground = Brushes.Gold;
        textBlock.FontSize = 9;
        textBlock.Background = Brushes.Transparent;
        this.AddChild(textBlock);

        border.Child = this;
        parentGrid.Children.Add(border);
    }

    public void setBorderColor(Brush borderColor)
    {
        this.border.BorderBrush = borderColor;
    }

    public void setTextColor(Brush textColor)
    {
        this.textBlock.Foreground = textColor;
    }

    public void setBackgroundColor(Brush backgroundColor)
    {
        this.Background = backgroundColor;
    }

    public string getHint()
    {
        return this.hint;
    }

    public string getAnswer()
    {
        return this.answer;
    }

    public string getCategory()
    {
        return this.category;
    }

    public void setHasBeenClicked(bool wasClicked)
    {
        this.hasBeenClicked = wasClicked;
    }

    public bool getHasBeenClicked()
    {
        return hasBeenClicked;
    }
}
