   M S B A M L   `   `   `  ����E  ADiReCT_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DiReCT_wpf.ViewDiReCT_wpf.View  5      G(clr-namespace:DiReCT_wpf.ScreenInterfaceDiReCT_wpf.ScreenInterface  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	      ;"clr-namespace:DiReCT_wpf.ViewModelDiReCT_wpf.ViewModel  5
      d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5      X TXceed.Wpf.Toolkit, Version=3.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit 5          DiReCT_wpf.View.OtherView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:DiReCT_wpf.View     5      8src(clr-namespace:DiReCT_wpf.ScreenInterface     5      6sys&clr-namespace:System;assembly=mscorlib     5	      1vm"clr-namespace:DiReCT_wpf.ViewModel     5
      `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5      4xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      Y UXceed.Wpf.DataGrid, Version=3.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f45xcdg*http://schemas.xceed.com/wpf/xaml/datagrid  5      Dxwt:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit  5      .��5      � 
�����F�.+�5   
   ��   �� CornerRadius$  20��6   
�������._�5      � $��20q�6    � RowDefinitions 5      �� 5      $��2* �6$   �� 5      $��3* �6$   .+�5      � $��0��6    � 	Resources 5      )   #DiReCT_wpf.ViewModel.OtherViewModel 
  LMapVM��%   &	          5      6,   5      .+�5      '  !Microsoft.Maps.MapControl.WPF.Map  -   5          Name$ mapView��5      +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$r lKEEEDTBMuatP82T0lBaz~LyodepcBdLJbXPBIPbavGQ~An_AVM9YZUJmROHUkFUGL2ujCmxsUDNCpps94i5ACIJYMuB9I-Ex3jihxTYdpj1x 6-   $	��300��5         	ZoomLevel$ 17Q�6Y      Center 6)   �� *CurrentLocation+ �� Mode$ TwoWay=�   Children. 5       +  %Microsoft.Maps.MapControl.WPF.Pushpin  -   5        	  Name$	 pushpin��5    $   
   Location
 65   ��  �� Source# [   �� Path$ CurrentLocation�$ TwoWay=�6�   5!      5"      �� 5#      $��Visible=�5$      ��.  $��1��5&      .��5'      �� .+�5(      �� $  10��6!   
�������$��10q�6O   ._�5)      � -   5         �Name$ 
background��5)   #    � ColumnDefinitions 5*   "   �� 5+   &   �� 5,   &   �� 5-   &   .+�5/   "   � $��0��6'   .+�50   &   ��  �� Orientation$ 
Horizontal=�61   $
��Left=�6J   .+�51   *   �� -   5         ��Name$ TimeTextBlock��51   4   $
��Left=�6K   $��10,10,10,10q�6f   $
��Wrap=�6{   $��Current timestamp: ��6�   $
��Bold"�6�   
����  �6�   �� 52   *   -   5        $ TimeTextBox��52   4   $
��Left=�6I   $��
0,10,10,10q�6d   $
��Wrap=�6x   ��6�   �� *currentTimeStamp+53   '   54   #   � 55   "   $��1��6'   .+�56   &   �� $ 
Horizontal=�61   $
��Left=�6J   .+�57   *   �� -   5        $ 
Coordinate��57   4   $
��Left=�6H   $
��Wrap=�6d   $��Current coordinate: ��6x   $��10,10,10,10q�6�   $
��Bold"�6�   
����  �6�   �� 58   *   -   5        $ LatitudeTextBlock��58   4   $��23��6O   $
��Wrap=�6[   $��50��6�   $
��Left=�6�   $��
0,10,10,10q�6�   ��6o   �� *currentLatitude+6�   �� 59   *   $��23��64   $
��Wrap=�6@   $��,��6T   $
��Left=�6]   $��
0,10,10,10q�6x   �� 5:   *   -   5        $ LongitudeTextBlock��5:   4   $��23��6P   $
��Wrap=�6\   $��50��6�   $
��Left=�6�   $��
0,10,10,10q�6�   ��6p   �� *currentLongitude+6�   5;   '   5<   #   � 5=   "   $��2��6'   .+�5>   &   �� $ 
Horizontal=�61   $
��Left=�6J   .+�5?   *   �� $
��Left=�64   $��Cause of the disaster: ��6O   $
��Wrap=�6n   $��10,10,10,10q�6�   $
��Bold"�6�   
����  �6�   �� 5@   *   $
��Left=�64   $��Typhoon��6O   $
��Wrap=�6^   $��
0,10,10,10q�6r   6�   5A   '   5B   #   5C      5D      � 5E      .+�5F      � .+�5G   "   �� $ 
Horizontal=�6-   $
��Left=�6F   .+�5H   &   �� $
��Left=�60   $ ��The landslide occured at: ��6K   $
��Wrap=�6m   $��10,10,10,10q�6�   $
��Bold"�6�   6�   &   Xceed.Wpf.Toolkit.DateTimePicker  5I   &   $
��Left=�6:   $��10,10,10,10q�6U   $	��180��6j   $��20��6v   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�6�      FormatString$ yyyy-MM-dd hh:mm tt��6�   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 6�   �� *currentDateTime+6�   5J   #   5K      5L      �� 5M      $
��Left=�6%   .+�5N      �� $
��Left=�6(   $��10,10,10,10q�6C   $
��Wrap=�6X   $�� ��6l   $	��Top=�6t   �� 5O      $ 
Horizontal=�6)   .+�5P   "   �� $
��Left=�6,   $��10,10,10,10q�6G   $
��Wrap=�6\   $��(1) Landslide condition: ��6p   $	��Top=�6�   $
��Bold"�6�   �� 5Q   "   $
��Left=�6+   $��10,10,10,10q�6F    d� 	IsChecked 6[   �� *conditions[0]+$ TwoWay=�.��6�   House was buried6�   �� 5R   "   $
��Left=�6+   $��10,10,10,10q�6F    6[   �� *conditions[1]+$ TwoWay=�.��6�   Farm was buried6�   �� 5S   "   $
��Left=�6+   $��10,10,10,10q�6F    6[   �� *conditions[2]+$ TwoWay=�.��6�   Road was buried6�   �� 5T   "   $
��Left=�6+   $��10,10,10,10q�6F    6[   �� *conditions[3]+$ TwoWay=�.��6�   River siltation6�   �� 5U   "   $
��Left=�6+   $��10,10,10,10q�6F    6[   �� *conditions[4]+$ TwoWay=�.��6�   Ground cracked6�   5V      �� 5W      $ 
Horizontal=�6)   .+�5X   "   �� $
��Left=�6,   $��10,10,10,10q�6G   $
��Wrap=�6\   $��(2) River siltation: ��6p   $	��Top=�6�   $
��Bold"�6�   �� 5Y   "   $
��Left=�6+   $��10,10,10,10q�6F   .@�5Z   &   ��  �� 
IsSelected . .��6E   Severe6M   �� 5[   &   .��63   
Moderate6=   �� 5\   &   .��63   Light6:   5]   #   5^      �� 5_      $ 
Horizontal=�6)   .+�5`   "   �� $
��Left=�6,   $��10,10,10,10q�6G   $
��Wrap=�6\   $��(3) Building Damage: ��6p   $	��Top=�6�   $
��Bold"�6�   �� 5a   "   $
��Left=�6+   $��10,10,10,10q�6F   .@�5b   &   ��  . .��6E    More than 5 houses were buried6e   �� 5c   &   .��63   1~4 houses were buried6K   �� 5d   &   .��63   No house was buried6H   5e   #   5f      5g      �� 5h      $ 
Horizontal=�6%   $
��Left=�6>   .+�5i      �� $
��Left=�6(   $��10,10,10,10q�6C   $
��Wrap=�6X   $��(4) Casualties: ��6l   $	��Top=�6�   $
��Bold"�6�   6�   �� 5j      $
��Left=�6(   $��10,10,10,10q�6C   $
��Wrap=�6X   $��Injury troll��6l   $	��Top=�6�   6�   %	  Xceed.Wpf.Toolkit.IntegerUpDown	  5k      �
  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]] 
  Minimum$ 0X�6O    
  Value 61   �� *injuryTroll+6O   �� 5l      $
��Left=�6(   $��10,10,10,10q�6C   $
��Wrap=�6X   $��Death troll��6l   $	��Top=�6   6�   	  5m      $ 0X�6N    61   �� *
deathTroll+6N   5n      �� 5o      $
��Left=�6$   $��10,10,10,10q�6?   $
��Wrap=�6T   $��(5) Disaster image: ��6h   $	��Top=�6�   $
��Bold"�6�   6�   � 5p       5q      �� 5r   "   $	��30* �63   �� 5s   "   $
��349* �63   �� 5t   "   $	��30* �63   .+�5v      �� -	   5        $��imgPhoto��5v   9   $��12,12,16,71q�6$   $
��Fill=�6j   $��1��6y   ��6I   �� *photoUploaded+6y   �� 5w      -
   5        $��btnLoad��5w   _   $��23��6%   $
��Left=�61   $��	12,0,0,34q�6L   $��Bottom=�6n   $��75��6�   $��1��6�   ��6�   �� *UploadCommand+.��6�   Load6�   5x      �� 5y      -   5         ��Name$ Save_Button��5y   !   $
��Save��66   $
��Left=�6f   $��10,10,10,10q�6�   $	��Top=�6�   $��75��6�   ��6E   �� *SaveCommand+6�   5z      5{      5|      5}      5~      5�      