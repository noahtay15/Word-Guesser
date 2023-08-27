using System.Windows;

namespace Word_Guesser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TitleScreen titleScreen;
        PlayerNumberScreen PlayerNumberScreen;
        PlayersInitScreen PlayersInitScreen;
        QuestionsScreen QuestionsScreen;
        AnsweringScreen AnsweringScreen;
        AwardedPointsScreen AwardedPointsScreen;
        WinnerScreen WinnerScreen;

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new TitleScreen());
        }

        public void setTitleScreen(TitleScreen titleScreen)
        { 
            this.titleScreen = titleScreen; 
        }

        public TitleScreen getTitleScreen()
        {
            return this.titleScreen;
        }
    
        public void setPlayerNumberScreen(PlayerNumberScreen playerNumberScreen)
        {
            this.PlayerNumberScreen = playerNumberScreen;
        }

        public PlayerNumberScreen getPlayerNumberScreen() 
        {  
            return this.PlayerNumberScreen; 
        }

        public void setPlayersInitScreen(PlayersInitScreen playersInitScreen)
        {
            this.PlayersInitScreen = playersInitScreen;
        }

        public PlayersInitScreen getPlayersInitScreen()
        {
            return this.PlayersInitScreen;
        }

        public void setQuestionsScreen( QuestionsScreen questionsScreen)
        {
            QuestionsScreen = questionsScreen;
        }

        public QuestionsScreen getQuestionsScreen()
        {
            return QuestionsScreen;
        }

        public void setAnsweringScreen( AnsweringScreen answeringScreen)
        {
            this.AnsweringScreen = answeringScreen;
        }

        public AnsweringScreen GetAnsweringScreen()
        {
            return this.AnsweringScreen;
        }

        public void setAwardedPointsScreen( AwardedPointsScreen awardedPointsScreen)
        {
            this.AwardedPointsScreen = awardedPointsScreen;
        }

        public AwardedPointsScreen getAwardedPointsScreen()
        {
            return this.AwardedPointsScreen;
        }

        public void setWinnerScreen(WinnerScreen winnerScreen)
        {
            this.WinnerScreen = winnerScreen;
        }

        public WinnerScreen getWinnerScreen()
        {
            return this.WinnerScreen;
        }
    }
}
