   M S B A M L   `   `   `  ����G  CWord Guesser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Word_GuesserWord_Guesser  5   	   "    Word_Guesser.AnsweringScreen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Word_Guesser     5   	     N� Title$  AnsweringScreen��5   	    N� 
Background �#004.��5	      (�  (� Stretch$ Uniform=�6   .��5
   
   � .+�5      �� 
�������$��4q�6(   $��84,71,84,104q�6<   $	��200��6R   $	��100��6^   ._�5      � -   5         �Name$ HintGrid��5      
�������.+�5      �� -   5         ��Name$ HintTextBlock��5      $�� ��5      $
��Wrap=�5      $��4,4,4,4q�5       �� TextAlignment$ Center=�5      5      5      � 5      -   5        $ CategoryHeaderGrid��5      $��84,10,84,203q�5      .+�5      �� -   5        $ CategoryHeader��5      $�� ��5      $��Center=�5      $	��Top=�5      $��40(�5      
������  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5          Color$ Black��6+      ShadowDepth$ 0Q�69   	   
BlurRadius$	 5Q�6I   
   Opacity$
 1Q�6X   ��5"      �� 5#       �� Color$ White��6*   5%      5&      � 5'      -   5        $ EnterYourAnswerTextGrid��5'   )   $��84,180,84,71q�6   .+�5(      �� -   5        $ EnterYourAnswerTextBlock��5(      $�� ��5)      $��Center=�5*      $��Center=�5+      $��24��5,      $	��293��5-      $��15(�5.      
������ $ Center=�50       51        52      $ Black��6+   $ 0Q�69   $	 5Q�6I   $
 1Q�6X   ��54      �� 55      $ White��6*   57      58      � 59      -   5        $ AnswerBoxGrid��59      $��140,204,140,41q�6+   $	��150��6C   $��20��6O   .+�5:      �� -   5         ��Name$ 	AnswerBox��5:      5;      �� 5<      -	   5        $��SubmitButton��5<      $��Submit��5=      $
��Left=�5>      $��Bottom=�5?      $��26��5@      $��51��5A       � Cursor$
 Hand��5B      $��
400,0,0,10q�5C      ��5G      �� 5H       �� 
TargetType" ��6&   .R�5I      � .+�5J      A�  A�Name$ SubmitButtonEllipse��6&   
����ح�
���   �$��3��6c   �� 5K       ��Name$" SubmitButtonContentPresenter��6/   $��Center=�6U   $��Center=�6r   5L      5M      5O      5P      5Q      5R      