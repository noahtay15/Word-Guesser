   M S B A M L   `   `   `  ����G  CWord Guesser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Word_GuesserWord_Guesser  5   	       Word_Guesser.TitleScreen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Word_Guesser     5   	     N� Title$  TitleScreen��5   	    N� 
Background �#004.��5
      (�  (� Stretch$ Uniform=�6   .��5   
   � -   5         �Name$ TitleScreenGrid��5      $y�Visible=�6(   $	��186��6=   .+�5      � -   5        $ 	TitleGrid��5       � 	Resources 5         CustomShape��%[   &	        �5      95M10,0 L30,0 L40,10 L40,30 L30,40 L10,40 L0,30 L0,10 Z�5      5      5      �� 5      
�������
���   �$��2q�6;    �� CornerRadius$ 10��6O   $��
0,58,0,153q�6a   ._�5      �� $��Word Guesser��6   $��Center=�60   $��Center=�6M   $��20(�6h    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6+      ShadowDepth$ 0Q�69   	   
BlurRadius$	 5Q�6I   
   Opacity$
 1Q�6X   ��5      �� 5       �� Color$ 	LightBlue��6*   5      5      �� 5      -   5         ��Name$ 
PlayButton��5      $
��Play��5      $��Center=�5!      $	��Top=�5"      $��	0,133,0,0q�5#       � Cursor$
 Hand��5$      $��16(�5'      ��5)      �� 5*       �� 
TargetType" ��6&   .R�5+      � .+�5,      A� $��PlayButtonEllipse��6&   
����ح�$	��100��6P   $��50��6\   
���   �$��4��6w   �� 5-       ��Name$  PlayButtonContentPresenter��6/   $��Center=�6S   $��Center=�6p   5.      5/      51      �� 53      -   5        $ 
QuitButton��53      $
��Quit��54      $��Center=�56      $	��Top=�57      $��50��58      $	��100��59      $
 Hand��5:      $��	0,190,0,0q�5;      $��16(�5>      ��5?      �� 5@      " ��6&   .R�5A      � .+�5B      A�  A�Name$ QuitButtonEllipse��6&   
����ح�$	��100��6R   $��50��6^   
���   �$��4��6y   �� 5C      $  QuitButtonContentPresenter��6/   $��Center=�6S   $��Center=�6p   5D      5E      5G      5H      5I      5J      