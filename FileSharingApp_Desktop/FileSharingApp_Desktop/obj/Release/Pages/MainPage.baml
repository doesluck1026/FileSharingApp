   M S B A M L   `   `   `  ���� N  JBuggy File Transfer, Version=2.4.9.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FileSharingApp_Desktop.PagesFileSharingApp_Desktop.Pages  U/clr-namespace:FileSharingApp_Desktop.Properties!FileSharingApp_Desktop.Properties  +    %FileSharingApp_Desktop.Pages.MainPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:FileSharingApp_Desktop.Pages     =p/clr-namespace:FileSharingApp_Desktop.Properties     -     N� Title$  MainPage��.��� ���#353536$��5,5,5,5q� � RowDefinitions �� $��* ��� $��6* ��� $��2* �.+��� $��BC_logo_1.png��$��3�� J� Opacity$	 0.1Q��� $��0��$��0,0,0,2q�$
��10,0q�
����ح��� $��1��$��0,0,0,2q�$
��10,0q�
����ح�� $��0�� � ColumnDefinitions �� $��4* ��� $��5* ��� $��3* ��� $��4* ��� $��1* �.+��� $��0�� �� Orientation$ 
Horizontal=�.+��� 1   +FileSharingApp_Desktop.Properties.Resources   Setting_DeviceName#��Z $��25(�$
��Left=�$��center=�
��������� $��:��$��25(�$��Center=�$��Center=�
��������� -    ��Name$ txt_DeviceName��$��	bişeyler��$��1��$��25(�$
��Left=�$��center=�
�������$��0q� �� 
IsReadOnly . 
������ ��    YourIPAddress#��Z $��2��$��25(�$
��Left=�$��center=�
��������� -   	 ��Name$	 txt_DeviceIP��$��192.168.1.25��$��3��$��25(�$
��Left=�$��center=�
�������
������ �� -   
 ��Name$
 btn_Settings��$��50(�   Blue#��[  $��0q�$��4��$��0,5,5,5q�.���� -    ��Name$ icon_Options��$��25��$��/Icons/settings.png��� $��1��$��10q� �� $��* ��� $	��10* ��� $��* �.+��� $��1��$��3q�
������� �� CornerRadius$ 10��._�� -    J� 	AllowDrop .  � Cursor$
 Hand�� �� $��3* ��� $��* �.+��� -   $	 lbl_DragDrop��$��0��$��	    +    ��$��Center=�$��Center=�$	��150(�
�������$��0,0,0,0q��� -   $	 lbl_Info��   Main_DragInfo#��Z $��1��$��20(�$��Center=�
��������� -	    ��Name$ 
list_Files��$��0��$	��600��$	��200��$y�Hidden=�� -
    �Name$ grid_AddRemove��$��1��$y�Hidden=� �� $��* ��� $��* �.+��� -   $
 btn_AddFiles��$��18(�
�������#��[  $��50,10q�$��0��.��� $	��170��.+��� $��/Icons/add.png��$	�� 35��$��40��$
��Left=�$	��5,0q���    File_btnAdd#��Z $��WrapWithOverflow=�$��Center=�$��Right=�$	��5,0q� �� TextAlignment$ Center=� �� Padding$ 2q��� -   $
 btn_RemoveFiles��  Red#��[ $��50,10q�$��18(�
�������$��1��.���� $ 
Horizontal=�$	��170��.+��� $��/Icons/minus.png��$	�� 35��$��40��$
��Left=�$	��5,0q���    File_btnRemove#��Z $��WrapWithOverflow=�$��Center=�$��Right=�$	��5,0q�$ Center=�$ 2q��� $ 
Horizontal=�$��Center=�$��2��.+��� -   $
 btn_MainMenu��#��[  $��20q�$��25(�$��0��$��Center=�$
��Left=�$y�Hidden=�$��Stretch=�$��Stretch=�.���� $ 
Horizontal=�$	��200��.+��� $��/Icons/Home.png��$	��5,0q�$	�� 35��$��50��$
��Left=���    Done_btnHome#��Z $��WrapWithOverflow=�$	��5,0q�$��Center=�$��Right=��� -   $
 btn_Send��$	��200��$��25(� 	 Green#��[ $��Center=�$��Right=�$y�Hidden=�.���� $ 
Horizontal=�$	��175��.+��� $��/Icons/send.png��$	�� 35��$��50��$
��Left=�$	��5,0q���    File_btnConfirm#��Z $��WrapWithOverflow=�$��Center=�$��Right=�$	��5,0q�$ Center=�$ 2q��� -   $	 lbl_ReceiveInfo��$��25(�$��2��   Main_OrReceive#��Z $��Center=�$��center=�
�������
������ 