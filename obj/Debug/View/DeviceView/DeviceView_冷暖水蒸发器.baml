   M S B A M L   `   `   `  ����V  Rproject.wpf.f.icooling.2002, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:project.wpf.f.icooling._2002.View!project.wpf.f.icooling._2002.View  5      e7clr-namespace:project.wpf.f.icooling._2002.View.Control)project.wpf.f.icooling._2002.View.Control  5      K GPanuon.UI.Silver, Version=1.1.1.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.SilverPanuon.UI.Silver 5      D    >project.wpf.f.icooling._2002.View.DeviceView冷暖水蒸发器   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:project.wpf.f.icooling._2002.View     5      Kcontrol7clr-namespace:project.wpf.f.icooling._2002.View.Control     5      Gpu8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.Silver     5      .��5      � .+�5      �� -   5          ��Name$  RectBackground��5      �� 5      .��5      �  � RowDefinitions 5      �� 5      $	��120 �6   6$   �� 5      $	��300 �6   6$   �� 5      $	��400 �6   6$   �� 5      $	��400 �6   6$   �� 5      $	��400 �6   6$   .+�5      �� $��1、选择空调功率��5      $��0��5      %  Panuon.UI.Silver.GroupBoxHelper   CornerRadius$ 1��5         IsSplitLineVisible . .��5      �    
DropShadow J� Effect# [  6   .+�5      � $
��Left=�6    � 	Resources 5   	    �� 
TargetType �� Property �� Value��%T   '��       �� 5   
   " ��6   .�5      ��  � ��$
 50 0q�6$   5       5!   
   .+�5"   	   � 	 � Orientation$	 Vertical=�6   $��Center=�6*    5#   
   
 �� BasedOn��%   '	�       7	��� 5$      " 	�6   8
   .�5%      ��  � ��$ 20q�6%   �� 5&       � ��$ 20(�6'   5'      5(      .+�5)   
   	� -   5        
 � Tag$ 1��5*   
    	� 	GroupName$ DevicePower��5,      $��空调功率1000W以下��6&   (  "Panuon.UI.Silver.RadioButtonHelper   RadioButtonStyle$ Switch=�5-      5.      	� 5/   
   -   5        $ 2��50   
   $ DevicePower��52      $��空调功率2500W以下��6&   $ Switch=�53      54      	� 55   
   -   5        $ 3��56   
   $ DevicePower��58      $��空调功率3000W以上��6&   $ Switch=�59      5:      5;   
   5<   	   5=      5>      �� 5?      $��1��5@      $��2、安装方式��5A      $ 1��5B       . .��5D      � # [  6   .+�5E      � $
��Left=�6    5F   	   ��%T   '��       �� 5G   
   " ��6   .�5H      ��  � ��$
 50 0q�6$   5I      5J   
   .+�5K   	   � $	 Vertical=�6   $��Center=�6*    5L   
   ��%   '	�       7	��� 5M      " 	�6   8
   .�5N      ��  � ��$ 20q�6%   �� 5O       � ��$ 20(�6'   5P      5Q      .+�5R   
   	� -   5        $ 3f9etp��5S      $��标准安装（B）��6!    d� 	IsChecked$
 TrueY�5U   
   $ Switch=�5V      5W      5b   
   �� 5c   	   $4��./Resources/冷暖水交换器_installdemo1.png��6   �� 5d   	   $4��./Resources/冷暖水交换器_installdemo2.png��6   5e   	   5f      5g      �� 5h      $��4、计算结果��5i      $��2��5j      $ 1��5k       . .��5m      �  � ColumnDefinitions 5n      �� 5o   	   $	��200 �6   6(   �� 5p   	   6   .+�5r      �� $��0��6   .+�5s   	   �� $��10 20q�5t      $��Center=�5u      $  Panuon.UI.Silver.TextBoxHelper   Header$ 选定的型号是 ��5w      ��5v      �� * Device.ModuleSelect.MoudleName+5w      5x   	   �� 5y      $��1��6   .+�5z   	   �� -   5         ��Name$ image1��5z      $<��6/Resources/冷暖水交换器_selector_for_client1.png��6   6S   5}   	   5~      5      5�      5�      5�      5�      