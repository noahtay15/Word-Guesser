   M S B A M L   `   `   `  ����G  CWord Guesser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Word_GuesserWord_Guesser  5   	       Word_Guesser.WinnerScreen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Word_Guesser     5   	     N� Title$  WinnerScreen��5   	    N� 
Background �#004.��5	      (�  (� Stretch$ Uniform=�6   .��5
   
   � -   5        $��ContainerGrid��5
      $	��600��6$   $	��730��60   .+�5      � -   5        $��CongratsGrid��5      $��	0,0,0,682q�6'   .+�5      �� -   5        $��CongratsTextBlock��5      $��CONGRATULATIONS!!!��5       
��� ���$��40(�5        �� TextAlignment$ Center=�5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	Goldenrod��6+      ShadowDepth$ 2Q�6=      
BlurRadius$ 1Q�6M   5      5      � 5      -   5        $��
WinnerGrid��5      $��
0,89,0,607q�6%   .+�5      �� -   5         ��Name$ WinnerTextBlock��5      $�� ��5      
�������$��25(�5      $ Center=�5      5      5      � 5      -   5        	 �Name$	 
ScoresGrid��5      $��0,176,0,156q�6'   5      �� 5       -   5        $��MainMenuButton��5       $
��Menu��5!      $
��Left=�5"      $��Bottom=�5#      $��33��5$      $��60��5%      
 � Cursor$

 Hand��5&      $��
530,0,0,10q�5*      ��5+      �� 5,       �� 
TargetType" ��6&   .R�5-      � .+�5.      A�  A�Name$ MainMenuButtonEllipse��6&   
����ح�$��60��6V   $��30��6a   
���   �$��4��6|   �� 5/       ��Name$$ MainMenuButtonContentPresenter��6/   $��Center=�6W   $��Center=�6t   50      51      53      54      55      56      