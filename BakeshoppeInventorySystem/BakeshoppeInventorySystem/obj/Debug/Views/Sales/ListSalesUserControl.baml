   M S B A M L   `   `   `  ����T  PBakeshoppeInventorySystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:BakeshoppeInventorySystem.Views.Sales%BakeshoppeInventorySystem.Views.Sales  5      @    :BakeshoppeInventorySystem.Views.Sales.ListSalesUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:BakeshoppeInventorySystem.Views.Sales     5      .��5      � 
�������  � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � $��0��6   $��2��5      $��0 0 0 15q�5       5      �� 5       $
��auto �6#   �� 5!      .+�5#      �� $��SALES��6   $��0��5$       
  header#��[  5%      �� 5&      $��1��6    �� Orientation$ 
Horizontal=�5'      $��Right=�5(      .+�5)      �� $��Search��6    
 search#��[ 5*      �� 5+      $��C��6   5,      5-      � 50   
   $��1��6   $��2��51       52      �� 53      $
��auto �6#   �� 54      .+�56      �� $��0��6     mainSelectionCombobox#��[ 57      .@�58      ��  �� 
IsSelected . .��61   ALL66   59      �� 5:      $��1��6   $��Right=�5;      $ 
Horizontal=�5<      .+�5=      �� $��Save Initial��6     saveInitial#��[ 5>      5?      5@      &   System.Windows.Controls.DataGrid  5B   
   $��2��6   $��2��5C      $��Center=�5D         Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      
IsReadOnly . 5G   %     5H      $ Current Quantity��6%    . 5I   %     5J      $ Leftover��6%     5K      $ Pieces Sold��6%    . 5L   %     5M      $ Price��6%    . 5N   %     5O      $ Total��6%    . 5P   %     5Q      $ 
Adjustment��6%     5R      $ Overall Total��6%    . 5S   %     5T      $ Remarks��6%   5V      �� 5X   
   $��3��6   $��2��5Y      $ 
Horizontal=�5Z      $��Center=�5[      .+�5\      �� $��<��6   �� 5]      $��>��6   5^      5_      5`      