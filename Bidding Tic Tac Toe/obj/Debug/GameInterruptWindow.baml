   M S B A M L   `   `   `  ����N  JBidding Tic Tac Toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Bidding_Tic_Tac_ToeBidding_Tic_Tac_Toe  5   	   '    !Bidding_Tic_Tac_Toe.GameInterrupt   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Bidding_Tic_Tac_Toe     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5	   	   c _Microsoft.Expression.Effects, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35?ee4http://schemas.microsoft.com/expression/2010/effects   5
   	   -   5          � Title$  Closing_Form��5      
������  � WindowStyle$
 None=�66   $	��120��6I   $	��300��6V    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6|    � 	Resources 5         BorderColor g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value��%�  &	        �� 5   
   $ Forever��6)   .��5      U� $K E(Shape.Stroke).(GradientBrush.GradientStops)[0].(GradientStop.Offset)�6,   $ 	rectangle��6�   .\�5        $ 0:0:15��6'   $	 1Q�68   5      U� 5      $K E(Shape.Stroke).(GradientBrush.GradientStops)[1].(GradientStop.Offset)�6,   $ 	rectangle��6�   .\�5        $ 0:0:15��6'   $	 0Q�68   5      5      5      
 � Triggers
 5      :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      .��5      � .+�5   
   �� -   5         ��Name$ 	rectangle��5      $
��Left=�6'   $	��120��6B   $��0,0,0,0q�6O   $	��Top=�6`   $	��298��6x    � UseLayoutRounding .  �� RadiusX$ 10��6�    �� RadiusY$ 10��6�   $��2��6�   ��5       �� 5!       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5"      �  � Color$ 	#FF18FD00��6#    � Offset$ 0Q�65   � 5#      $ White��6#   $ 1Q�61   � 5$      $ 	#FFC3FEBD��6#   $ 0.281Q�65   � 5%      $ 	#FF43FD2F��6#   $ 0.699Q�65   5&      ��5(      �� 5)       �� ImageSource$ Resources/Background2.jpg��6   5+      �� 5-   
   $��Center=�6   $��0,10,0,0q�61   $
��Wrap=�6C   $	��Top=�6W   $	��280��6o   $��65��6{   $"��Do you want to end the game?��6�   $��24(�6�   $��Snap ITC)�6�    �� TextAlignment$ Center=�6�   ���	#FF18FD00 J� Effect 5.      3  -System.Windows.Media.Effects.DropShadowEffect  5/      51      �� 53   
   -   5         ��Name$ 	No_button��53      $��	0,78,75,0q�6'   $
��Wrap=�6:   $	��Top=�6N   $��Right=�6g   $��30��6�   $��60��6�   ���	#FF18FD00$��24(�6�   $��Snap ITC)�6�   $ Center=�6�   $��No��6�    � Cursor$
 Hand��6   54        55      .  (System.Windows.Interactivity.Interaction   Triggers 57      /  )System.Windows.Interactivity.EventTrigger  58         	EventName$ 
MouseEnter��6!   3  -System.Windows.Interactivity.EventTriggerBase   
SourceName$ 	No_button��68   .  (System.Windows.Interactivity.TriggerBase   Actions. 59      B  <Microsoft.Expression.Interactivity.Core.ChangePropertyAction     PropertyName$ Effect��6.      Value 5:      7  1Microsoft.Expression.Media.Effects.PixelateEffect  5;      5=      5>        5?      $ 
MouseLeave��6!   $ 	No_button��68   . 5@        $ Effect��6.   5A      5C      �� 5E   
   -   5        $ 
Yes_button��5E      $��	75,78,0,0q�6(   $
��Wrap=�6;   $	��Top=�6O   $
��Left=�6g   $��30��6�   $��60��6�   $��24(�6�   $��Snap ITC)�6�   $ Center=�6�   $	��Yes��6�   $
 Hand��6   ���	#FF18FD00 5F        5G       5I        5J      $ 
MouseEnter��6!   $ 
Yes_button��68   . 5K        $ Effect��6.    5L        5M      5O      5P        5Q      $ 
MouseLeave��6!   $ 
Yes_button��68   . 5R        $ Effect��6.   5S      5U      5V      5W      