   M S B A M L   `   `   `  ����H  DSnowRunnerFix, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SnowRunnerFixSnowRunnerFix  5   	       SnowRunnerFix.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:SnowRunnerFix     5   	   -   5          � Title$  SnowRunnerFix��5   	   $	��250��6   $	��500��6,   $	��500��68   $	��200��6G   .��5	      � ��5
   
   �� 5       �� ImageSource$ /Resources/Background.jpg��6    j� Stretch$
 Fill=�6A    j� TileMode$
 None=�6P    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��150* �6   �� 5      $
��150* �6   .+�5   
   �� -   5         ��Name$ CloseExp_Button��5   G      MyButtonStyle#��[  6   $��35��68   $��Close Explorer.exe��6`   
���   �$��Center=�6�   $��Center=�6�   ��5      �� 5      $ Resources/Close.jpg��6   5      �� 5   
   -   5        $ StartExp_Button��5   G   #��[  6   $��35��68   $��1��6`   $��Start Explorer.exe��6p   $��Center=�6�   $��Center=�6�   ��5      �� 5      $ Resources/Open.jpg��6   5      � 5   
   $��1��6   $��2��6   .+�5       �� -   5         ��Name$ Clocks��5       $��00:00:00��6$   ���	#FF1F1D1D
�������$��Right=�6a   $��Bottom=�6}   5!      5"      5#      