   M S B A M L   `   `   `  ����E  ADiReCT_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DiReCT_wpf.ViewDiReCT_wpf.View  5      G(clr-namespace:DiReCT_wpf.ScreenInterfaceDiReCT_wpf.ScreenInterface  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      ;"clr-namespace:DiReCT_wpf.ViewModelDiReCT_wpf.ViewModel  5	      d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5           DiReCT_wpf.View.RecordView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:DiReCT_wpf.View     5      8src(clr-namespace:DiReCT_wpf.ScreenInterface     5      6sys&clr-namespace:System;assembly=mscorlib     5      1vm"clr-namespace:DiReCT_wpf.ViewModel     5	      X TXceed.Wpf.Toolkit, Version=3.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5
      ZmRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF  5        � 	Resources  5         SliderRepeatButton �� 
TargetType �� Property �� Value �� 
TargetType  SliderRepeatButton1 J� SnapsToDevicePixels  SliderThumb �� Triggers P� Property P� Value 
 Slider	 � ColumnDefinitions
 ]�Name ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton  Vertical_Slider��%}  &	        &	 d    &	 �    &	 v    7  7  7   &	 �    7  �� 5   
   " ��6+   .�5      ��  �@J�SnapsToDevicePixels . 64   �� 5       �@�OverridesDefaultStyle . 66   �� 5       � �� .  6*   �� 5       � |� .  6*   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��1q�6"   
�������
�������$��3��6[   5      5      5      �� 5   
   " ��6,   .�5      ��  �@J�SnapsToDevicePixels . 64   �� 5        �@�OverridesDefaultStyle . 66   �� 5!       � �� 5"      �� 5#      " ��6&   .R�5$      ��  . ���	#FF0074FF$��1q�6T   ���	#FF4B96F0$��3��6�   5%      5'      5(      �� 5+   
   " n�6$   .�5,      ��  �@J�SnapsToDevicePixels . 64   �� 5-       �@�OverridesDefaultStyle . 66   �� 5.       � �� 5/      �� 50      " n�6&   .R�51      A� $��10��6"   $��10��6.   ���	#FF0074FF52      53      55       56      P� 57       �@J�IsMouseOver . . �58      ��  � �� 59      �� 5:      " n�6.   .R�5;   "   A� $��10��6*   $��10��66   ���	#FF0074FF$��1��6R   ���	#FF58CAFF6{   5<      5>      5?      P� 5@       �@J�IsMouseCaptured . . �5A      ��  � �� 5B      �� 5C      " n�6.   .R�5D   "   A� $��10��6*   $��10��66   ���	#FF58CAFF6T   5E      5G      5H      5J      �� 5M   
   " ��6*   .R�5N      � $��Center=�6   	 5O      �� 5P      $
��Auto �6'   #��z��64   .+�5R      ]� $
 
PART_Track��6    5S      �� 5T      8��  $��Slider.DecreaseLarge��6U    5V      n� 5W      8�� 6     5Y      �� 5Z      8�� $��Slider.IncreaseLarge��6S   5\      5]      5^      �� 5a   
   " ��6(   .�5b      ��  � |� .  6*   �� 5c       �@J�SnapsToDevicePixels . 64   �� 5d       �@�OverridesDefaultStyle . 66    5e      P� 5f       �@��Orientation$ Vertical=�61   . �5g      ��  � ��$	 104��62   �� 5h       � ��$ 21��61   �� 5i       � ��8   61   5j      5l      5m      .��5n      � 
�����F�.+�5o   
   ��  �� CornerRadius$ 20��6   
�������._�5p      � $��20q�6    � RowDefinitions 5q      �� 5r      $��2* �6$   �� 5s      $��3* �6$   .+�5u      � $��0��6     5v      *   $DiReCT_wpf.ViewModel.RecordViewModel 	 MapVM��%   &	         5w      6-   5x      .+�5y      '  !Microsoft.Maps.MapControl.WPF.Map  -   5          Name$ mapView��5y      +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$r lKEEEDTBMuatP82T0lBaz~LyodepcBdLJbXPBIPbavGQ~An_AVM9YZUJmROHUkFUGL2ujCmxsUDNCpps94i5ACIJYMuB9I-Ex3jihxTYdpj1x 6-   $	��300��5z         	ZoomLevel$ 17Q�6Y      Center 6)   �� *CurrentLocation+ �� Mode$ TwoWay=�   Children. 5{      +  %Microsoft.Maps.MapControl.WPF.Pushpin  -   5          Name$ pushpin��5{   $      Location 65   ��  �� Source# [  �� Path$ CurrentLocation�$ TwoWay=�6�   5|      5}      �� 5~      $��Visible=�5      ��.  $��1��5�      .��5�      �� .+�5�      �� $ 10��6!   
�������$��10q�6O   ._�5�      � -   5         �Name$ 
background��5�   #   	 5�   "   �� 5�   &   �� 5�   &   .+�5�   "   � $��0��6'   .+�5�   &   ��  �� Orientation$ 
Horizontal=�61   $
��Left=�6J   .+�5�   *   �� -   5         ��Name$ TimeTextBlock��5�   4   $
��Left=�6K   $��10,10,10,10q�6f   $
��Wrap=�6{   $��Current timestamp: ��6�   $
��Bold"�6�   
����  �6�   �� 5�   *   -   5        $ TimeTextBox��5�   4   $
��Left=�6I   $��
0,10,10,10q�6d   $
��Wrap=�6x   ��6�   �� *currentTimeStamp+5�   '   5�   #   � 5�   "   $��1��6'   .+�5�   &   �� $ 
Horizontal=�61   $
��Left=�6J   .+�5�   *   �� -   5        $ 
Coordinate��5�   4   $
��Left=�6H   $
��Wrap=�6d   $��Current coordinate: ��6x   $��10,10,10,10q�6�   $
��Bold"�6�   
����  �6�   �� 5�   *   -   5        $ LatitudeTextBlock��5�   4   $��23��6O   $
��Wrap=�6[   $��50��6�   $
��Left=�6�   $��
0,10,10,10q�6�   ��6o   �� *currentLatitude+6�   �� 5�   *   $��23��64   $
��Wrap=�6@   $��,��6T   $
��Left=�6]   $��
0,10,10,10q�6x   �� 5�   *   -   5        $ LongitudeTextBlock��5�   4   $��23��6P   $
��Wrap=�6\   $��50��6�   $
��Left=�6�   $��
0,10,10,10q�6�   ��6p   �� *currentLongitude+6�   5�   '   5�   #   5�      5�      �� 5�      -	   5         ��Name$ 
waterlevel��5�   %   $ 
Horizontal=�69   $
��Left=�6R   $	��500��6m   .+�5�      �� -
   5        $ WaterLevelTextBlock��5�   (   $
��Left=�6E   $��10,10,10,10q�6`   $
��Wrap=�6u   $��WaterLevel: ��6�   $	��Top=�6�   $��0��6�   $
��Bold"�6�   �� 5�      $A��;C:\Users\Ashley\Desktop\DiReCT\DiReCT_wpf\Resource\body.jpg��6$   $	��150��6i   $	��230��6u   6�   �� 5�      -   5         ��Name$ WaterLevelSlider��5�   %   #��[ 6?   $��Center=�6h    � Minimum$ 0Q�6�     � Maximum$	  100Q�6�   $	��230��6�   ! �� Orientation$! Vertical=�6�   " � Value" 6�   �� *
waterLevel+6�   5�      �� 5�      $��Causes of the flood��6$   $
��Bold"�6?   6S   �� 5�      -   5        # ��Name$# listbox��5�   "   $ �� SelectionMode$$ Multiple=�6z   $	��180��6�   ��63   �� $" AvailablePresentationObjects�$ TwoWay=���5�      �� 5�   "   .R�5�   &   �� ��6/   �� *Name+% d� 	IsChecked% 6H   �� *	IsChecked+$ TwoWay=�6w   5�   #   5�      �� 5�      -   5        & ��Name$& Save_Button��5�   !   $
��Save��6V   $
��Left=�6e   $��10,10,10,10q�6�   $	��Top=�6�   $��75��6�   ��66   �� *SaveCommand+6�   5�      5�      5�      5�      5�      5�      