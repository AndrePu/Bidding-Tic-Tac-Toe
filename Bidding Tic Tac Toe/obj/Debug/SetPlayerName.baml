   M S B A M L   `   `   `  ����N  JBidding Tic Tac Toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Bidding_Tic_Tac_ToeBidding_Tic_Tac_Toe  5   	   '    !Bidding_Tic_Tac_Toe.SetPlayerName   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Bidding_Tic_Tac_Toe     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5
   	   c _Microsoft.Expression.Effects, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35?ee4http://schemas.microsoft.com/expression/2010/effects   5   	   -   5          � Title$  Closing_Form��5      
������  � WindowStyle$
 None=�66   $	��120��6I   $	��350��6V    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6|    � 	Resources 5         BorderColor g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value��%�  &	        �� 5   
   $ Forever��6)   .��5      U� $K E(Shape.Stroke).(GradientBrush.GradientStops)[0].(GradientStop.Offset)�6,   $ 	rectangle��6�   .\�5        $ 0:0:15��6'   $	 1Q�68   5      U� 5      $K E(Shape.Stroke).(GradientBrush.GradientStops)[1].(GradientStop.Offset)�6,   $ 	rectangle��6�   .\�5        $ 0:0:15��6'   $	 0Q�68   5      5      5      
 � Triggers
 5      :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      .��5       � .+�5!   
   �� -   5         ��Name$ 	rectangle��5!      $
��Left=�6'   $	��120��6B   $	��Top=�6O   $	��350��6g    � UseLayoutRounding .  �� RadiusX$ 10��6�    �� RadiusY$ 10��6�   $��2��6�   ��5"      �� 5#       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5$      �  � Color$ 	#FF18FD00��6#    � Offset$ 0Q�65   � 5%      $ White��6#   $ 1Q�61   � 5&      $ 	#FFC3FEBD��6#   $ 0.281Q�65   � 5'      $ 	#FF43FD2F��6#   $ 0.699Q�65   5(      ��5*      �� 5+       �� ImageSource$ Resources/Background2.jpg��6   5-      �� 5/   
   -   5         ��Name$ textBlock_name��5/      $��Center=�6,   $��
10,10,10,0q�6I   $
��Wrap=�6]   $	��Top=�6q   $	��280��6�   $��26.067��6�   $��Please enter your name:��6�   $��18(�6�   $��Snap ITC)�6�    �� TextAlignment$ Center=�6�   ���	#FF18FD00 J� Effect 50      3  -System.Windows.Media.Effects.DropShadowEffect  51      53      �� 55   
   -   5        $ enter_button��55      $��0,78,0,0q�6*   $
��Wrap=�6<   $	��Top=�6P   $��Center=�6i   $��30��6�   $��90��6�   ���	#FF18FD00$��18(�6�   $��Snap ITC)�6�   $ Center=�6�   $��Enter��6�    � Cursor$
 Hand��6   56        57      .  (System.Windows.Interactivity.Interaction   Triggers 59      /  )System.Windows.Interactivity.EventTrigger  5:         	EventName$ 
MouseEnter��6!   3  -System.Windows.Interactivity.EventTriggerBase   
SourceName$ enter_button��68   .  (System.Windows.Interactivity.TriggerBase   Actions. 5;      B  <Microsoft.Expression.Interactivity.Core.ChangePropertyAction     PropertyName$ Effect��6.      Value 5<      7  1Microsoft.Expression.Media.Effects.PixelateEffect  5=      5?      5@        5A      $ 
MouseLeave��6!   $ enter_button��68   . 5B        $ Effect��6.   5C      5E      �� 5F   
   -   5         ��Name$ textBox��5F      |�. $��40,53,35.4,0q�65     �� TextWrapping$
  Wrap=�6K   $
��Left=�6_   $	��Top=�6z   $	��275��6�   $��20��6�   $��14(�6�   $��Elephant)�6�   
���   ����	#FF18FD006�   5G      5H      