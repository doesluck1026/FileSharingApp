   M S B A M L   `   `   `  ���� N  JBuggy File Transfer, Version=2.4.9.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FileSharingApp_Desktop.PagesFileSharingApp_Desktop.Pages  U/clr-namespace:FileSharingApp_Desktop.Properties!FileSharingApp_Desktop.Properties  .    (FileSharingApp_Desktop.Pages.OptionsPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:FileSharingApp_Desktop.Pages     =p/clr-namespace:FileSharingApp_Desktop.Properties     -     N� Title$  OptionsPage��.��� ���#353536$��5,5,5,5q� � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��2* �.+��� $��BC_logo_1.png��$��10��$��10�� J� Opacity$	 0.1Q��� $��0��$��0,0,0,2q�$
��10,0q�
����ح��� $��2��$��0,0,0,2q�$
��10,0q�
����ح���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� 1   +FileSharingApp_Desktop.Properties.Resources   Options_Title#��Z $��40(�$
��Bold"�
����İ�$��0��� $��1�� � ColumnDefinitions �� $��* ��� $��3* �.+���    Setting_DeviceName#��Z $��0��$��25(�$
��Left=�$��10,0,0,0q�$��center=�
��������� -    ��Name$ txt_DeviceName��$��Device Name��$��1��$��0,0,0,2q�$��25(�$��10q�$��Stretch=�$��center=�
������� �� 
IsReadOnly .  
������ � $��2�� �� $��* ��� $��3* �.+��� 	   Setting_Language#��Z	 $��0��$��25(�$
��Left=�$��10,0,0,0q�$��center=�
��������� -   $��Combo_Languages��$	��200��$��1��$��50��
 �� Text$
 English��$
��Left=�$��Center=�
������ 
���  ��$��25(�� $��3�� �� $��3* ��� $��8* ��� $��* �.+���    Setting_OutputFolder#��Z $��0��$��25(�$��10,0,0,0q�$
��Left=�$��center=�
��������� -   $ txt_OutputFolder��$��	bişeyler��$��1��$��25(�$��0,0,0,2q�$
��Left=�$��center=�
�������$��5q� .  
������ $	��500���� -    ��Name$ btn_SelectFolder��$�� ... ��   Blue#��[  $��28(�$��2��$��Center=�$��Center=�� $��4�� �� $��* ��� $��* ��� $��* �.+��� -   $ btn_MainMenu��#��[  $��30q�$��25(�$��0��$��Center=�$��Stretch=�$��Stretch=�$��Stretch=�.���� $ 
Horizontal=�$	��200��.+��� $��/Icons/Home.png��$	��5,0q�$	�� 35��$��50��$
��Left=���    Done_btnHome#��Z $��WrapWithOverflow=�$	��5,0q�$��Center=�$��Right=��� -   $ btn_Save��$��25(� 	 Green#��[ $��30q�$��2��$��Center=�$��Stretch=�$��Center=�.���� $ 
Horizontal=�$	��150��.+��� $��/Icons/save.png��$	�� 35��$��50��$
��Left=�$	��5,0q���    Setting_btnSave#��Z $	��5,0q�$��Center=�$��Right=�