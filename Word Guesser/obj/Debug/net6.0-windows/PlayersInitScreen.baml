   M S B A M L   `   `   `  ����G  CWord Guesser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Word_GuesserWord_Guesser  5   	   $    Word_Guesser.PlayersInitScreen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Word_Guesser     5   	     N� Title$  Word Guesser��5   	    N� 
Background �#004.��5
      (�  (� Stretch$ Uniform=�6   .��5   
   � -   5        $��PlayerInitGrid��5      ���#004$	��800��67   $	��450��6C    � RowDefinitions 5      �� 5      $	��450 �6    �� 5      $��* �6    .+�5      �� $ ��Choose Your Name and Color��5      $��Center=�5      $	��Top=�5      $��52��5      $	��528��5      $��40(�5      
������  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6'      ShadowDepth$ 0Q�65      
BlurRadius$ 5Q�6E      Opacity$ 1Q�6T   ��5      �� 5      	 �� Color$	 White��6&   5      � 5      .+�5       �� 
�������$��4q�6,   $��84,54,84,54q�6@   ._�5!      � -   5        
 �Name$
 PlayerInitContainerGrid��5!      
�������5"      5#      5$      �� 5%      -   5        $��BackToPlayerNumberButton��5%      $
��Back��5&      $
��Left=�5'      $��Bottom=�5(      $��33��5)      $��60��5*       � Cursor$
 Hand��5+      $��10,0,0,6q�5-      ��50      �� 51       �� 
TargetType" ��6&   .R�52      � .+�53      A�  A�Name$% BackToPlayerNumberButtonEllipse��6&   
����ح�$��60��6`   $��30��6k   
���   �$��4��6�   �� 54       ��Name$. (BackToPlayerNumberButtonContentPresenter��6/   $��Center=�6a   $��Center=�6~   55      56      58      �� 59      -   5         ��Name$ SubmitButton��59      $��Submit��5:      $
��Left=�5;      $��Bottom=�5<      $��33��5=      $��60��5>      $
 Hand��5?      $��	730,0,0,6q�5A      ${�False��5D      ��5E      �� 5F      " ��6&   .R�5G      � .+�5H      A� $ SubmitButtonEllipse��6&   
����ح�$��60��6T   $��30��6_   
���   �$��4��6z   �� 5I      $" SubmitButtonContentPresenter��6/   $��Center=�6U   $��Center=�6r   5J      5K      5M      5N      5O      5P      