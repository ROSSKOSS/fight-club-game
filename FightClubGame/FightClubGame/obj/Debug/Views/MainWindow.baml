   M S B A M L   `   `   `  ����H  DFightClubGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FightClubGameFightClubGame  5   	   G CCustomButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:CustomButton;assembly=CustomButtonCustomButton 5   	   $    FightClubGame.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   'localclr-namespace:FightClubGame  5   	   CCustomButton0clr-namespace:CustomButton;assembly=CustomButton  5   	     � Title$  
Fight Club��5
   	   $	��799��6   $
��1200��6)    � WindowStyle$
 None=�66    � AllowsTransparency .  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      
BlurRadius$ 30Q�6      Opacity$
 0.98Q�6+   .��5      � ���	#FF8A8D91.+�5   
   �� -   5         ��Name$ image��5      $��117,68,115,0q�6   $��../Resources/title.png��65   $
��Fill=�6U   $	��228��6d   $	��Top=�6q    J� OpacityMask
 �����$��Center=�6�   $	��568��6�    5        5      $ 60Q�6#      ShadowDepth$ 0Q�63   	   Color$	 	#FF40382C��6C   5        CustomButton.Button  5   
   -   5        
  Name$
 
PlayButton��5         Font$ Arial)�62   $��Center=�6?   $��281,344,280,0q�6\   $	��Top=�6t   $	��239��6�      Text$
 Play��6�      RoundX$ 5��6�      RoundY$ 5��6�      	FillColor �	#FF40382C   
HoverColor �	#FF7C8100   	DownColor �	#FF343601   ForegroundColor �	#FFCDCDCD   SecondColor �	#FFACACAC   StrokeColor
 �   �$��58��6E  $��Franklin Gothic Medium)�6Q  $��22(�6u  ���	#FF40382C   StrokeThickness$ 2��6�   5        5      $ 50Q�6#   $ 0Q�63   $	 0.7Q�6C   $	 	#FF40382C��6Q   5        5   
   -   5        $
 OptionsButton��5      $ Arial)�65   $��Center=�6B   $��281,419,280,0q�6_   $	��Top=�6w   $	��239��6�   $ Options��6�   $ 5��6�   $ 5��6�    �	#FF40382C �	#FF7C8100 �	#FF343601 �	#FFCDCDCD �	#FFACACAC
 �   �$��58��6K  $��Franklin Gothic Medium)�6W  $��22(�6{  ���	#FF40382C$ 2��6�   5        5      $ 50Q�6#   $ 0Q�63   $	 0.7Q�6C   $	 	#FF40382C��6Q   5        5   
   -   5        $
 
ExitButton��5      $ Arial)�62   $��Center=�6?   $��281,494,280,0q�6\   $	��Top=�6t   $	��239��6�   $
 Exit��6�   $ 5��6�   $ 5��6�    �	#FF40382C �	#FF7C8100 �	#FF343601 �	#FFCDCDCD �	#FFACACAC
 �   �$��58��6E  $��Franklin Gothic Medium)�6Q  $��22(�6u  ���	#FF40382C$ 2��6�   5        5       $ 50Q�6#   $ 0Q�63   $	 0.7Q�6C   $	 	#FF40382C��6Q   .  (System.Windows.Interactivity.Interaction   Triggers 5"      /  )System.Windows.Interactivity.EventTrigger  5#         	EventName$ MouseLeftButtonUp��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5$      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *ExitCommand+5%      5'      � 5(   
   -   5         �Name$
 host��5(      $��Right=�6   $
��1200��69   $	��799��6F   $	��Top=�6S    5)        5*      $ 0Q�6#   $ 15Q�63   5,      �� 5-   
   -   5        ���	#FF565857$��37��5-   %   $	��Top=�61   6I     5.   
   $��Right=�6   $��	0,11,15,0q�6:   $	��Top=�6M   $��20��6e   $��20��6q   $ 10��6|   $ 10��6�   $  ��6�    �	#FF630000
 �   �$��Arial)�6�   $��10(�6�   
 �  �� �	#FF380000 5/        50      $ MouseLeftButtonUp��6!   . 51         6,   �� *ExitCommand+52      54      �� 55   
   -   5         ��Name$ label��55      $��
Fight Club��6   $
��Left=�64   $��10,0,0,0q�6O   $	��Top=�6a   $��20(�6y   58      59      