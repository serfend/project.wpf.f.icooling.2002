   M S B A M L   `   `   `  ����K  GPanuon.UI.Silver, Version=1.1.1.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.SilverPanuon.UI.Silver  5      V Rproject.wpf.f.icooling.2002, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:project.wpf.f.icooling._2002.Properties'project.wpf.f.icooling._2002.Properties 5      4   .project.wpf.f.icooling._2002.View.CalendarView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Gpu8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.Silver     5      K	localized5clr-namespace:project.wpf.f.icooling._2002.Properties     5      .��5      � .+�5      �� -   5          ��Name$  RectBackground��5      � 5      $��Center=�6	   .+�5      �� -   5         ��Name$ GrpCode��5      $��Center=�5      $��Bottom=�5      ��5      �� *ActualWidth+ �� ElementName$ 
GrpPalette��.��5      � .+�5      �� -   5         ��Name$ TbCode��5      $	��100��5       �� AcceptsReturn . $	��Top=�5      $��5q�5      " �� VerticalScrollBarVisibility$
 Auto=�5      $ �� HorizontalScrollBarVisibility$
 Auto=�5       �� 
IsReadOnly . .��5   0    � ContextMenu 5      �� 5   	   .@�5   
   m� -   5        7  1project.wpf.f.icooling._2002.Properties.Resources	   CopyCode#��Z	 5      
 m� Icon$	
 ��5   +   5   +   5    
   .��5!      5"      5#      5$      �� 5%      -   5        $ 
GrpPalette��5%      $��Center=�5&         Palette#��Z 5'      $	��300��5(      %   Panuon.UI.Silver.GroupBoxHelper   ExtendControl 5)      �� 5*      -   5         ��Name$ BtnViewCode��5*      $��0,0,5,0q�5+      $��Center=�5,      #   Panuon.UI.Silver.ButtonHelper   ButtonStyle$
 Link=�5-      ���	#AA57A2E0   
HoverBrush �#57A2E0   ViewCode#��Z 50      51      .��54      �  � ColumnDefinitions 55      �� 56      �� 57      .+�59         Panuon.UI.Silver.Calendar  -   5          Name$ 	CdrCustom��59      
�������$��1q�5;   "   $	��300��5<   "   $	��300��5=   "   $��13(�5>   "   � 5?      $��1��6   $��10,0,0,0q�5@      $	��320��5A       5B      �� 5C   	   $
��Auto �6   �� 5D   	   $
��Auto �6    � RowDefinitions 5F      �� 5G   	   $��40 �6   �� 5H   	   $��40 �6   �� 5I   	   $��40 �6   �� 5J   	   $��40 �6   �� 5K   	   $��40 �6   .+�5M      ��    CalendarMode#��Z 6   $��Center=�5N   $   �� 5O      $��1��6    �� Orientation$ 
Horizontal=�5P   %   $
��10,0q�5Q   %   .+�5R   	   	� -   5        $
��Date��5R       d� 	IsChecked$
 TrueY�5S   *   5T   *   	� 5U   	   -	   5        $��5,0,0,0q�5U      $
��Year��5V   *   5W   *   	� 5X   	   -
   5        $��5,0,0,0q�5X      $��	YearMonth��5Y   *   5Z   *   5[   	   �� 5\      $��1��6      
ThemeBrush#��Z 5]   $   $��Center=�5^   $   �� 5_      -   5         ��Name$ SldTheme��5_      #   Panuon.UI.Silver.SliderHelper   IsTickValueVisible .     SliderStyle$ Classic=�5a   !      
ThemeBrush
 ����  �� IsMoveToPointEnabled . $��Center=�5d   !   $	��9,0q�5e   !   $��1��5f   !   $��1��5g   !   $	��200��5h   !    � Minimum$ 0Q�5i   !    � Maximum$ 7Q�5j   !    � Value$
 6.65Q�5k   !     �� IsSnapToTickEnabled  . ! �� TickFrequency$
! 0.01Q�5m   !   $	��5,0q�5n   !      ColorSelectorBrush#��[  5o   !   5q   	   �� 5r      $��2��6   "   LimitMaxDateTime#��Z" 5s   $   $��Center=�5t   $   �� 5u      -   5        # ��Name$# ChbLimitMax��5u      %   Panuon.UI.Silver.CheckBoxHelper$   CheckBoxStyle$$ Switch=�5v   #   %   	BoxHeight$% 25Q�5w   #   &   BoxWidth$& 35Q�5x   #   '   CheckedBackground
' �����$��2��5z   #   $��1��5{   #   $��Center=�5|   #   $��Center=�5}   #   5   #   �� 5�      $��3��6   (   LimitMinDateTime#��Z( 5�   $   $��Center=�5�   $   �� 5�      -   5        $# ChbLimitMin��5�      $$ Switch=�5�   #   $% 25Q�5�   #   $& 35Q�5�   #   
' �����$��3��5�   #   $��1��5�   #   $��Center=�5�   #   $��Center=�5�   #   5�   #   �� 5�      $��4��6   )   IsSundayFirst#��Z) 5�   $   $��Center=�5�   $   �� 5�      -   5        $# ChbSundayFirst��5�      $
 TrueY�5�   #   $$ Switch=�5�   #   $% 25Q�5�   #   $& 35Q�5�   #   
' �����$��4��5�   #   $��1��5�   #   $��Center=�5�   #   $��Center=�5�   #   5�   #   5�      5�      5�      5�      5�      5�      