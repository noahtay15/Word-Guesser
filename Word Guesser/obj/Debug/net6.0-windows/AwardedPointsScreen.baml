   M S B A M L   `   `   `  ����G  CWord Guesser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Word_GuesserWord_Guesser  5      &     Word_Guesser.AwardedPointsScreen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Word_Guesser     5        N� Title$  AwardedPoints��5       N� 
Background �#004.��5
      (�  (� Stretch$ Uniform=�6   .��5   
   � -   5         �Name$ ContainerGrid��5      $	��473��6&   $	��737��63   .+�5      � -   5        $��
AnswerGrid��5      $��	0,0,0,420q�6%   .+�5      �� -   5        $��AnswerTextBlock��5      $��Answer: ��5      
�������$��30(�5       �� TextAlignment$ Center=�5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6+      ShadowDepth$ 0Q�69      
BlurRadius$ 5Q�6I   	   Opacity$	 1Q�6X   5      5      � 5      -   5        $��
HeaderGrid��5      $��0,104,0,309q�6%   .+�5      �� -   5        
 ��Name$
 HeaderTextBlock��5      $��Points Awarded To:��5      $ Center=�5      $��30(�5      $��196,0,195,0q�6*   
������� 5        5      $ Black��6+   $ 0Q�69   $ 5Q�6I   $	 1Q�6X   5       5!      � 5"      -   5        $ PointsContainerGrid��5"      $��178,181,178,10q�60   5#      �� 5$      -   5        $��
NextButton��5$      $
��Next��5%      $
��Left=�5&      $��Bottom=�5'      $��30��5(      $��50��5)       � Cursor$
 Hand��5*      $��
640,0,0,10q�5+      ��5/      �� 50       �� 
TargetType" ��6&   .R�51      � .+�52      A�  A�Name$ NextButtonEllipse��6&   
����ح�
���   �$��3��6a   �� 53       ��Name$&  NextButtonButtonContentPresenter��6/   $��Center=�6Y   $��Center=�6v   54      55      57      58      59      5:      