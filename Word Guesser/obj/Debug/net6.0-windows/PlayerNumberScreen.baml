   M S B A M L   `   `   `  ����G  CWord Guesser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Word_GuesserWord_Guesser  5   	   %    Word_Guesser.PlayerNumberScreen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Word_Guesser     5   	     N� Title$  Word Guesser��5   	    N� 
Background �#004.��5
      (�  (� Stretch$ Uniform=�6   .��5   
   � -   5        $��PlayerNumberGrid��5      ���#004$	��400��69    � RowDefinitions 5      �� 5      $
��413* �6    �� 5      $��* �6    .+�5      �� $��Center=�5      $��0,23,0,0q�5      $
��Wrap=�5      $��How Many Players?��5      $	��Top=�5      $��56��5      $	��348��5      $��40(�5      
������  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6'      ShadowDepth$ 0Q�65      
BlurRadius$ 5Q�6E      Opacity$ 1Q�6T   ��5      �� 5      	 �� Color$	 White��6&   5       �� 5!      -   5        $��BackToTitleButton��5!      $
��Back��5"      $
��Left=�5#      $��Bottom=�5$      $��33��5%      $��60��5&      
 � Cursor$

 Hand��5'      $��	-66,0,0,6q�5)      ��5,      �� 5-       �� 
TargetType" ��6&   .R�5.      � .+�5/      A�  A�Name$ BackToTitleButtonEllipse��6&   
����ح�$��60��6Y   $��30��6d   
���   �$��4��6   �� 50       ��Name$' !BackToTitleButtonContentPresenter��6/   $��Center=�6Z   $��Center=�6w   51      52      54      � 55      -   5        $��
ButtonGrid��55      
�������$	��250��6<   $	��400��6I   $��	0,82,0,81q�6U    56      �� 57      $	��125 �6$   �� 58      $	��125 �6$   .+�5:      �� -   5        $��OnePlayerButton��5:      $��1��5;      $��60(�5<      $
��Left=�5=      $	��115��5>      $��5,0,0,0q�5?      $��Center=�5@      $	��190��5A      $

 Hand��5C      ��5F      �� 5G      " ��6*   .R�5H      � .+�5I   "   �� $��OnePlayerButtonRectangle��6,   
����ح�
���   �$��3��6l   �� 5J   "   $%��OnePlayerButtonContentPresenter��63   $��Center=�6Z   $��Center=�6w   5K      5L      5N      �� 5O      -   5        $��ThreePlayerButton��5O      $��3��5P      $��60(�5Q      $
��Left=�5R      $	��115��5S      $��Center=�5T      $	��190��5U      $

 Hand��5W      $��1��6   $��5,0,0,0q�6,   ��5Z      �� 5[      " ��6*   .R�5\      � .+�5]   "   �� $ ��ThreePlayerButtonRectangle��6,   
����ح�
���   �$��3��6n   �� 5^   "   $'��!ThreePlayerButtonContentPresenter��63   $��Center=�6\   $��Center=�6y   5_      5`      5b      �� 5c      -   5        $��TwoPlayerButton��5c      $��2��5d      $��60(�5e      $
��Left=�5f      $	��115��5g      $��Center=�5h      $	��190��5i      $

 Hand��5k      $��	204,0,0,0q�6   ��5n      �� 5o      " ��6*   .R�5p      � .+�5q   "   �� $��TwoPlayerButtonRectangle��6,   
����ح�
���   �$��3��6l   �� 5r   "   $%��TwoPlayerButtonContentPresenter��63   $��Center=�6Z   $��Center=�6w   5s      5t      5v      �� 5w      -   5        $��FourPlayerButton��5w      $��60(�5x      $��4��5y      $
��Left=�5z      $	��115��5{      $��Center=�5|      $	��190��5}      $

 Hand��5      $��	204,0,0,0q�5�      $��1��5�      ��5�      �� 5�      " ��6*   .R�5�      � .+�5�   "   �� $��FourPlayerButtonRectangle��6,   
����ح�
���   �$��3��6m   �� 5�   "   $&�� FourPlayerButtonContentPresenter��63   $��Center=�6[   $��Center=�6x   5�      5�      5�      5�      5�      5�      5�      