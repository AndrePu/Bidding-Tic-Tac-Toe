   M S B A M L   `   `   `  ����N  JBidding Tic Tac Toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Bidding_Tic_Tac_ToeBidding_Tic_Tac_Toe  5   	   "    Bidding_Tic_Tac_Toe.MainMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Bidding_Tic_Tac_Toe     5   	   -   5          � Title$  MainMenu��5	   	   $	��480��6   $	��360��6'    � WindowStartupLocation$ CenterScreen=�63    � AllowsTransparency .  � WindowStyle$
 None=�6r   
������  � 	Resources 5
         BorderColor g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  Button.Static.Background
 �� ImageSource  Button.Static.Border �� Color  Button.Static.Foreground  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �� CornerRadius ��Name J� Effect3  -System.Windows.Media.Effects.DropShadowEffect �� Triggers P� Property P� Value �� 
TargetName��%�
  &	        &	 �    &	 �    &	 �    &	     &	 8    &	 [    &	 ~    &	 �    &		 �    &	
 �    '�� 
    7  7  7  7  7  7  7  7  7 	 7 
 �� 5   
   $ Forever��6)   .��5      U� $K E(Shape.Stroke).(GradientBrush.GradientStops)[0].(GradientStop.Offset)�6,   $ 	rectangle��6�   .\�5        $ 0:0:15��6'   $	 0.177Q�68   5      U� 5      $K E(Shape.Stroke).(GradientBrush.GradientStops)[1].(GradientStop.Offset)�6,   $ 	rectangle��6�   .\�5        $ 0:0:15��6'   $	 1Q�68   5      U� 5      $K E(Shape.Stroke).(GradientBrush.GradientStops)[2].(GradientStop.Offset)�6,   $ 	rectangle��6�   .\�5        $ 0:0:15��6'   $	 0.549Q�68   5      U� 5      $K E(Shape.Stroke).(GradientBrush.GradientStops)[3].(GradientStop.Offset)�6,   $ 	rectangle��6�   .\�5        $ 0:0:15��6'   $	 0.345Q�68   5      U� 5      $K E(Shape.Stroke).(GradientBrush.GradientStops)[4].(GradientStop.Offset)�6,   $ 	rectangle��6�   .\�5        $ 0:0:15��6'   $	 0.765Q�68   5      5      �� 5       $
 Resources/Background4.jpg��67   �� 5!   
   $ 	#FF16E500��67   �� 5"   
   $ 	#FF16E500��6;   �� 5#   
   $ #FFFFFF��6>   �� 5$   
   $ 	#FF16E500��6:   �� 5%   
   $ 	#FFA3FCB4��6<   �� 5&   
   $ 	#FF008E16��68   �� 5'   
   $ 	#FFF4F4F4��6=   �� 5(   
   $ 	#FFADB2B5��69   �� 5)   
   $ 	#FF838383��6=   �� 5,   
   " ��6   .�5-      ��  � ��$	 200��6&   �� 5.       � ��$ 50��6'   �� 5/       � ��$ Snap ITC)�6+   �� 50       � ��$ 24(�6)   �� 51       � ��8   6+   �� 52       � ��8  6,   �� 53       � ��8  6+   �� 54       � ��$ 3q�60   �� 55       � ��$ Center=�6;   �� 56       � ��$ Center=�69   �� 57       � �� 58      �� 59      " ��6&   .R�5:      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . $ 20��6�   ._�5;      �� $ contentPresenter��6/   #��z��6I   # z 6�   #��z��6�    5<   "     5=   &   5?      5@       5A      P� 5B       �@��IsDefaulted . . �5C   "   �� $ border��6@   # � ��6T    � ��5D      P� 5E       �@J�IsMouseOver . . �5F   "   �� $ border��6?   8   � ��6S   �� 5G   "   $ border��6@   8   � ��6T   5H      P� 5I       � �� . . �5J   "   �� $ border��6?   8   � ��6S   �� 5K   "   $ border��6@   8   � ��6T   5L      P� 5M       � {� .  . �5N   "   �� $ border��6?   8   � ��6S   �� 5O   "   $ border��6@   8   � ��6T   �� 5P   "   $ contentPresenter��6K   8 	  � ��6i   5Q      5S      5U      5V      5W       � Triggers 5Z      :� 5[   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5\      �� #��[  6   5]      .��5a      �  � ColumnDefinitions 5d   
   �� 5e      $	��77* �6   �� 5f      $
��200* �6   �� 5g      $	��77* �6    � RowDefinitions 5i   
   �� 5j      $
��160* �6   �� 5k      $	��53* �6   �� 5l      $	��27* �6   �� 5m      $��53.215 �6   �� 5n      $
��187* �6   .+�5r   
   �� -   5         ��Name$ 	rectangle��5r      $��3��6'   $��Right=�6;   $��478.4��6W   $��0,0,0,0q�6f    �� RadiusY$ 20��6w    �� RadiusX$ 20��6�   $��5��6�   $��2��6�   $	��Top=�6�   $��358.4��6�   ��5s      �� 5t        �� EndPoint$  0.5,1&�6&   ! � MappingMode$! RelativeToBoundingBox=�67   " �� 
StartPoint$" 0.5,0&�6[   .��5u      � # � Color$# 	#FF16E500��6#   $ � Offset$$ 0.823Q�65   � 5v      $# White��6#   � 5w      $# White��6#   $$ 0.451Q�61   � 5x      $# 	#FFC3F8BD��6#   $$ 0.655Q�65   � 5y      $# 	#FF16E500��6#   $$ 0.235Q�65   5z      ��5|      �� 5}      $
 Resources/Background2.jpg��6   5      �� 5�   
   $��3��6   $��Center=�6(   $	��100��6E   $��0,20,0,0q�6R   $
��Wrap=�6d   $	��Top=�6x   $	��275��6�   $��Bidding Tic Tac Toe��6�   $��36(�6�   $��Snap ITC)�6�   % �� TextAlignment$% Center=�6�    5�        5�      ��5�      �� 5�      $  0.5,1&�6&   $! RelativeToBoundingBox=�67   $" 0.5,0&�6[   .��5�      � $# 	#FF16E500��6#   $$ 0.241Q�65   � 5�      $# White��6#   $$ 1Q�61   5�      5�      �� 5�   
   -   5        & ��Name$& newGame_Button��5�      $��New Game��6)   $��1��6<   $��1��6J   6Z   �� 5�   
   -   5        $& exit_Button��5�      $
��EXIT��6&   $��3��65   $��1��6B   6S   5�      5�      