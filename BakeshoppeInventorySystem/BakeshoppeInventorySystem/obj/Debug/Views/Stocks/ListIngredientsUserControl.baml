   M S B A M L   `   `   `  ����T  PBakeshoppeInventorySystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:BakeshoppeInventorySystem.Views.Stocks&BakeshoppeInventorySystem.Views.Stocks  5      G    ABakeshoppeInventorySystem.Views.Stocks.ListIngredientsUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:BakeshoppeInventorySystem.Views.Stocks     5      .��5      � 
�������  � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      .+�5   
   �� $��0��6   $��3��5       
  header#��[  5      $��INGREDIENTS��5      � 5   
   $��1��6   $��3��5       5       �� 5!      �� 5"      $
��auto �6#   .+�5$      �� $��0��5%       �� Orientation$ 
Horizontal=�5&      .+�5'      ��  
 search#��[ 6   $��Search��6:   �� 5(      $��C��6   5*      �� 5+      $��1��6   $��Save Initial��5,        saveInitial#��[ 5-      5/      &   System.Windows.Controls.DataGrid  51   
   $��2��6   $��3��52         Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 55   %   ��  �� Path$ 
Model.Name�  56      $ Current Quantity��6%     57      $ Differential��6%     58      $ New Quantity��6%    . 6;   5:      �� 5<   
   $��3��5=      $��3��5>      $��0,0,0,20q�5?      $��Center=�5@      $ 
Horizontal=�5A      .+�5B      �� $��<��6   �� 5C      $��>��6   5D      � 5G   
   $��4��6   $��0��5H        5I      �� 5J      $
��auto �6    �� 5K      �� 5L      $
��auto �6     5N      �� 5O      $
��auto �6#   �� 5P      .+�5R      �� $��0��5S      $��2��5T        	subHeader#��[ 5U      $��RE-STOCK��5V      �� 5W      $��1��5X      $��0��5Y      $��Quantity��5Z      �� 5[      $��1��6   $��1��5\      �� 5]      $��2��5^      $��2��5_      $��0,10,0,0q�5`      $��Right=�5a      $ 
Horizontal=�5b      .+�5c      �� $
��Save��6   �� 5d      $��Cancel��6   5e      5f      � 5i   
   $��4��5j      $��1��5k        verticalLine#��[ 5l      � 5n   
   $��4��6   $��2��5o        5p      �� 5q      $
��auto �6    �� 5r      .+�5t      �� $��0��5u      #��[ 5v      $��RE-STOCK HISTORY��5w        5x      $��1��6   $��80��5y       5z        5{      $
 Date��6)     5|      $ Quantity��6)   5~      5      5�      5�      