   M S B A M L   `   `   `  ����T  PBakeshoppeInventorySystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:BakeshoppeInventorySystem.Views.Items%BakeshoppeInventorySystem.Views.Items  5      G    ABakeshoppeInventorySystem.Views.Items.ListProductItemsUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:BakeshoppeInventorySystem.Views.Items     5      .��5
      � 
�������  � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��0��6    
  header#��[  5      $��LIST OF PRODUCTS��5      � 5)   
   $��1��6   $��3��6    � ColumnDefinitions 5*      �� 5+      $
��auto �6#   �� 5,      $
��auto �6#   �� 5-      .+�5/      �� $��0��50       �� Orientation$ 
Horizontal=�51      .+�52      ��  
 search#��[ 6   $��Search��6:   �� 53      $��C��6   55      �� 56      $��1��6     mainSelectionCombobox#��[ 57      .@�58      ��  �� 
IsSelected . .��61   ALL66   59      �� 5:      $��2��5;      $��Right=�5<      $ 
Horizontal=�5=      .+�5>      �� $	��Add��6C   ��6   ��  �� Path$ AddNetworkWindow�6C   �� 5@      $��Delete��6G   ��6   �� $ DeleteNetworkCommand�6G   5B      5D      &   System.Windows.Controls.DataGrid  5J   
   $��2��6      AutoGenerateColumns .  ��5L      �� $ IngredientList� �� SelectedItem 5M      �� $ SelectedIngredientModel�   Columns 5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   	   
IsReadOnly	 . 63     5P      $ Selling Price��6%   	 . 6<   5R      � 5X   
   $��3��5Y      $��0��5Z        5[      �� 5\      $
��auto �6    �� 5]      $
��auto �6    �� 5^      $
��auto �6    �� 5_      $
��auto �6    �� 5`      $
��auto �6     5b      �� 5c      $
��auto �6#   �� 5d      .+�5f      �� $��0��5g      $��2��5h        	subHeader#��[ 5i      $��EDIT PRODUCT DETAILS��5j      �� 5k      $��1��5l      $��0��5m      $
��Name��5n      �� 5o      $��2��5p      $��0��5q      $��Selling Price��5r      �� 5s      $��3��5t      $��0��5u      $��Category��5v      �� 5w      $��1��5x      $��1��5y      � 5z      $��2��6   $��1��5{       5|      �� 5}      �� 5~      $
��auto �6'   .+�5�      �� $��0��5�      �� 5�      $��+��6   $��1��5�      5�      �� 5�      $��3��5�      $��1��5�      $
��Left=�5�      �� 5�      $��4��5�      $��1��5�      $��0,10,0,0q�5�      $��Right=�5�      $
��Save��5�      5�      5�      5�      