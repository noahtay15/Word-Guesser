   M S B A M L   `   `   `  ����G  CWord Guesser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Word_GuesserWord_Guesser  5   	   %    Word_Guesser.PlayerNumberScreen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Word_Guesser     5   	     N� Title$  Word Guesser��5   	    N� 
Background �#004.��5
      (�  (� Stretch$ Uniform=�6   .��5   
   � -   5        $��PlayerNumberGrid��5      ���#004$	��400��69    � RowDefinitions 5      �� 5      $
��413* �6    �� 5      $��* �6    .+�5      �� $��Center=�5      $��0,23,0,0q�5      $
��Wrap=�5      $��How Many Players?��5      $	��Top=�5      $��56��5      $	��348��5      $��40(�5      
������ 
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6'      ShadowDepth$ 0Q�65      
BlurRadius$ 5Q�6E      Opacity$ 1Q�6T   5      �� 5      -   5        $��BackToTitleButton��5      $
��Back��5       $
��Left=�5!      $��Bottom=�5"      $��33��5#      $��60��5$      	 � Cursor$
	 Hand��5%      $��	-66,0,0,6q�5'      ��5*      �� 5+      
 �� 
TargetType"
 ��6&   .R�5,      � .+�5-      A�  A�Name$ BackToTitleButtonEllipse��6&   
����ح�$��60��6Y   $��30��6d   
���   �$��4��6   �� 5.       ��Name$' !BackToTitleButtonContentPresenter��6/   $��Center=�6Z   $��Center=�6w   5/      50      52      � 53      -   5        $��
ButtonGrid��53      
�������$	��250��6<   $	��400��6I   $��	0,82,0,81q�6U    54      �� 55      $	��125 �6$   �� 56      $	��125 �6$   .+�58      �� -   5        $��OnePlayerButton��58      $��1��59      $��60(�5:      $
��Left=�5;      $	��115��5<      $��5,0,0,0q�5=      $��Center=�5>      $	��190��5?      $
	 Hand��5A      ��5D      �� 5E      "
 ��6*   .R�5F      � .+�5G   "   �� $��OnePlayerButtonRectangle��6,   
����ح�
���   �$��3��6l   �� 5H   "   $%��OnePlayerButtonContentPresenter��63   $��Center=�6Z   $��Center=�6w   5I      5J      5L      �� 5M      -   5        $��ThreePlayerButton��5M      $��3��5N      $��60(�5O      $
��Left=�5P      $	��115��5Q      $��Center=�5R      $	��190��5S      $
	 Hand��5U      $��1��6   $��5,0,0,0q�6,   ��5X      �� 5Y      "
 ��6*   .R�5Z      � .+�5[   "   �� $ ��ThreePlayerButtonRectangle��6,   
����ح�
���   �$��3��6n   �� 5\   "   $'��!ThreePlayerButtonContentPresenter��63   $��Center=�6\   $��Center=�6y   5]      5^      5`      �� 5a      -   5        $��TwoPlayerButton��5a      $��2��5b      $��60(�5c      $
��Left=�5d      $	��115��5e      $��Center=�5f      $	��190��5g      $
	 Hand��5i      $��	204,0,0,0q�6   ��5l      �� 5m      "
 ��6*   .R�5n      � .+�5o   "   �� $��TwoPlayerButtonRectangle��6,   
����ح�
���   �$��3��6l   �� 5p   "   $%��TwoPlayerButtonContentPresenter��63   $��Center=�6Z   $��Center=�6w   5q      5r      5t      �� 5u      -   5        $��FourPlayerButton��5u      $��60(�5v      $��4��5w      $
��Left=�5x      $	��115��5y      $��Center=�5z      $	��190��5{      $
	 Hand��5}      $��	204,0,0,0q�5~      $��1��5      ��5�      �� 5�      "
 ��6*   .R�5�      � .+�5�   "   �� $��FourPlayerButtonRectangle��6,   
����ح�
���   �$��3��6m   �� 5�   "   $&�� FourPlayerButtonContentPresenter��63   $��Center=�6[   $��Center=�6x   5�      5�      5�      5�      5�      5�      5�      