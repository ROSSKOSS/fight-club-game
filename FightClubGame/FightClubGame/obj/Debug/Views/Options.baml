   M S B A M L   `   `   `  ����H  DFightClubGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FightClubGame.ViewsFightClubGame.Views  5      G CCustomButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:CustomButton;assembly=CustomButtonCustomButton 5      !    FightClubGame.Views.Options   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:FightClubGame.Views     5      ICustomButton0clr-namespace:CustomButton;assembly=CustomButton     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  6T   y�5	   7   �� *
Visibility+.��5
      � .+�5   
   � ���	#FF6F644E.+�5      �� ���	#FF40382C$��Center=�6)   $��10,43,10,225q�6F   $	��280��6\     �� RadiusX$  5��6h    �� RadiusY$ 5��6t   
���   �$��32��6�   $��Center=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 0Q�6'      
BlurRadius$ 15Q�67      Opacity$	 0.6Q�6G   5      �� 5      -   5         ��Name$ 	textBlock��5      $��Center=�6+   $��17,5,137,261q�6H   $
��Wrap=�6^   $��Player name:��6r   $��Center=�6�   $��25(�6�   ���	#FF252525$	��146��6�   �� 5      -   5         ��Name$ textBox��5      $��Center=�6'   $��32��6D   $��17,43,15,225q�6P    �� TextWrapping$
 Wrap=�6f   $��Center=�6�   $	��268��6�   	 �� SelectionBrush	 �	#FF21B400$��0q�6)  $��20(�6=  ���	#FFB90000��6z   �� *
PlayerName+
 �� UpdateSourceTrigger$
 PropertyChanged=���6�   Z� ��6�   Z� 6K  �� 5      -   5         ��Name$ comboBox��5   �   $��Center=�6�   $��10,80,10,193q�6�   $��Center=�6�   $	��280��6  $��27��6  
���   �
���   �$��0q�6J  4  .System.Windows.Automation.AutomationProperties   HelpText$ Choose the character��6^   �� Text$ 	fegthryhy��6�  
���   ���6   ��  �� Path$ 
Characters�$
 PropertyChanged=� �� SelectedValue 6c   �� *	Character+$
 PropertyChanged=�6�  �� 5      ���	#FF40382C$��Center=�6)   $��10,148,10,120q�6F   $	��280��6]   $  5��6i   $ 5��6u   
���   �$��32��6�   $��Center=�6�    5        5      $ 0Q�6'   $ 15Q�67   $	 0.6Q�6G   5      �� 5      -   5        $ roundDurationTextBlock��5      $��Center=�68   $��17,94,48,140q�6U   $
��Wrap=�6k   $��Round duration:��6   $��Center=�6�   $��25(�6�   ���	#FF252525$	��235��6�   �� 5      -   5        $ roundDurationTextBox��5      $��Center=�64   $��32��6Q   $��17,148,15,120q�6]   $
 Wrap=�6t   $��Center=�6�   $	��268��6�   	 �	#FF21B400$��0q�6;  $��20(�6O  ���	#FFB90000��6�   �� *RoundDuration+$
 PropertyChanged=���6�   Z� ��6	  Z� 6]    CustomButton.Button  5      -   5          Name$ 
SaveButton��5   "      Font$ Arial)�66   $��Center=�6C   $��17,230,156,22q�6`   $��Center=�6x   $	��127��6�      Text$
 Save��6�      RoundX$ 5��6�      RoundY$ 5��6�      	FillColor �	#FF40382C   
HoverColor �	#FF7C8100   	DownColor �	#FF343601   ForegroundColor �	#FFCDCDCD   SecondColor �	#FFACACAC   StrokeColor
 �   �$��48��6L  $��Franklin Gothic Medium)�6X  $��22(�6|  ���	#FF40382C   StrokeThickness$ 1��6�   5        5      $ 50Q�6'   $ 0Q�67   $	 0.7Q�6G      Color$ 	#FF40382C��6U   .  (System.Windows.Interactivity.Interaction   Triggers 5       /  )System.Windows.Interactivity.EventTrigger  5!         	EventName$ MouseLeftButtonUp��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5"      6  0System.Windows.Interactivity.InvokeCommandAction      Command  60   �� *SaveCommand+5#      5%      5&      5(      5)      