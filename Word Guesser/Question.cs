using System;
using System.Windows.Controls;
using System.Windows.Media;

internal class Question : Button
{
	private String hint;
	private String answer;

	public Question(string hint, string answer, String questionNum, int row, int col)
    {
        this.hint = hint;
        this.answer = answer;

        this.Width = 50;
        this.Height = 35;
        this.Background = new SolidColorBrush(Colors.DarkBlue);
        this.BorderBrush = new SolidColorBrush(Colors.Blue);
        Grid.SetRow(this, row);
        Grid.SetColumn(this, col);



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
