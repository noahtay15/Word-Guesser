   M S B A M L   `   `   `  ����G  CWord Guesser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Word_GuesserWord_Guesser  5   	   "    Word_Guesser.AnsweringScreen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Word_Guesser     5   	     N� Title$  AnsweringScreen��5   	    N� 
Background �#004.��5	      � .+�5
   
   �� $��[Category Name]��5      $��Center=�5      $	��Top=�5      $��59��5      $	��302��5      $��40(�5      
������  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6#      ShadowDepth$ 0Q�61      
BlurRadius$ 5Q�6A      Opacity$ 1Q�6P   ��5      �� 5       �� Color$ White��6"   5      � 5   
   .+�5      �� 
�������$��4q�6(   $	��250��6=   $	��100��6I   $��84,71,84,37q�6V   ._�5      � -   5         �Name$ PlayerInitContainerGrid��5      
�������5      5      5      �� 5   
   $&�� [Player Name] enter your answer.��5       $��Center=�5!      $	��Top=�5"      $��19��5#      $	��218��5$      $��15(�5%      
������ $��	0,178,0,0q�5&   *    5'        5(      $ Black��6#   $ 0Q�61   $ 5Q�6A   $ 1Q�6P   ��5*      �� 5+      $ White��6"   5-      �� 5.   
   $��58,203,58,-5q�6   .��6(   50      �� 51   
   -   5        $��SubmitButton��51      $��Submit��52      $
��Left=�53      $��Bottom=�54      $��26��55      $��51��56      	 � Cursor$
	 Hand��57      $��
365,0,0,-9q�58      ��59      �� 5:      
 �� 
TargetType"
 ��6"   .R�5;      � .+�5<      A�  A�Name$# BackToPlayerInitButtonEllipse��6"   
����ح�
���   �$��3��6i   �� 5=       ��Name$, &BackToPlayerInitButtonContentPresenter��6+   $��Center=�6[   $��Center=�6x   5>      5?      5A      5B      5C      