using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

internal class Question : Button
{
	private String hint;
	private String answer;

	public Question(string answer, string hint, int questionNum, int row, int col, Grid parentGrid)
    {
        this.hint = hint;
        this.answer = answer;

        this.Width = 50;
        this.Height = 35;
        this.Background = new SolidColorBrush(Colors.DarkBlue);
        this.BorderBrush = new SolidColorBrush(Colors.Blue);
        Grid.SetRow(this, row);
        Grid.SetColumn(this, col);

        //style to stop highlight on mouse over
        Style noMouseOverColorButtonStyle = new Style(typeof(Button));
        ControlTemplate template = new ControlTemplate(typeof(Button));
        FrameworkElementFactory borderFactory = new FrameworkElementFactory(typeof(Border));
        borderFactory.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(Button.BackgroundProperty));
        borderFactory.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(Button.BorderBrushProperty));
        borderFactory.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(Button.BorderThicknessProperty));

        FrameworkElementFactory contentPresenterFactory = new FrameworkElementFactory(typeof(ContentPresenter));
        contentPresenterFactory.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
        contentPresenterFactory.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);

        borderFactory.AppendChild(contentPresenterFactory);
        template.VisualTree = borderFactory;

        noMouseOverColorButtonStyle.Setters.Add(new Setter(Button.TemplateProperty, template));
        this.Style = noMouseOverColorButtonStyle;

        //design button
        DataTemplate contentTemplate = new DataTemplate(typeof(Button));
        FrameworkElementFactory textBlockFactory = new FrameworkElementFactory(typeof(TextBlock));
        textBlockFactory.SetValue(TextBlock.TextProperty, "Question " + questionNum);
        textBlockFactory.SetValue(TextBlock.ForegroundProperty, Brushes.Gold);
        textBlockFactory.SetValue(TextBlock.FontSizeProperty, 9.0);
        textBlockFactory.SetValue(TextBlock.BackgroundProperty, Brushes.Transparent);
        contentTemplate.VisualTree = textBlockFactory;
        this.ContentTemplate = contentTemplate;

        parentGrid.Children.Add(this);
        


        /**
         * <Button 
                    Grid.Row="1" 
                    Grid.Column="0" 
                    Width="50" 
                    Height="35" 
                    Background="DarkBlue" 
                    BorderBrush="Blue" 
                    x:Name="Button01" 
                    MouseEnter="QuestionButton_MouseEnter" 
                    MouseLeave="QuestionButton_MouseLeave"
                    Click="QuestionButton_Click"
                    Style="{StaticResource NoMouseOverColorButton}">
                    <Button.Resources>
                        <Style TargetType="Border">
                            <Setter Property="CornerRadius" Value="5"/>
                        </Style>
                    </Button.Resources>
                    <Button.ContentTemplate>
                        <DataTemplate>
                            <TextBlock Text="Question 1" Foreground="Gold" FontSize="9" Background="Transparent"/>
                        </DataTemplate>
                    </Button.ContentTemplate>
                </Button>
        **/


        //this.Style = "{StaticResource NoMouseOverColorButton}"
        //do event handlers later
    }

    
}
