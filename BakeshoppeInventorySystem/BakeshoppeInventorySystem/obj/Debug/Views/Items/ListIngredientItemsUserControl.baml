   M S B A M L   `   `   `  ����T  PBakeshoppeInventorySystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:BakeshoppeInventorySystem.Views.Items%BakeshoppeInventorySystem.Views.Items  5      J    DBakeshoppeInventorySystem.Views.Items.ListIngredientItemsUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:BakeshoppeInventorySystem.Views.Items     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � DataContext  5
      ��  �� Path$ IngredientModule�   Locator �� Source# [  .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��0��5       
 header#��[ 5      $��LIST OF INGREDIENTS��5      � 5   
   $��1��6   $��3��6    � ColumnDefinitions 5      �� 5      �� 5      $
��auto �6#   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6)   .+�5       ��  
 search#��[ 6   $��Search��6:   �� 5!      $��C��6   5#      �� 5%      $��1��5&      $��Right=�5'      $ 
Horizontal=�5(      .+�5)      �� $	��Add��6C   ��6   �� $ AddNetworkWindow�6C   �� 5+      $��Delete��6G   ��6   �� $ DeleteNetworkCommand�6G   5-      5/      &   System.Windows.Controls.DataGrid  55   
   $��2��56         AutoGenerateColumns .   �� SelectedIndex$ 0��59      ��58      �� $ IngredientList� �� SelectedItem 5:      �� $ SelectedIngredientModel�	   Columns	 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��5>         
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5=      �� $ 
Model.Name�5?        5@      $

 Unit��5B       .  5A      �� $ Unit.Symbol�5C      5E      � 5K   
   $��3��5L      $��0��5M        5N      �� $8 2IngredientModule.SelectedIngredientModel.EditModel�# [   5O      �� 5P      $
��auto �6    �� 5Q      $
��auto �6    �� 5R      $
��auto �6    �� 5S      $
��auto �6     5U      �� 5V      $
��auto �6#   �� 5W      .+�5Y      �� $��0��5Z      $��2��5[        	subHeader#��[ 5\      $��EDIT INGREDIENT DETAILS��5]      �� 5^      $��1��5_      $��0��5`      $
��Name��5a      �� 5b      $��2��5c      $��0��5d      $
��Unit��5e      �� 5f      $��1��5g      $��1��5h      ��5i      �� $
 Name� �� UpdateSourceTrigger$ PropertyChanged=��� 5j      $��3��5k      $��1��5l      ��5m      �� $ UnitId�$ PropertyChanged=�� 5n      $��2��5o      $��1��5p        5q      �� $ IngredientModule�# [   5r      �� 5s      �� 5t      $
��auto �6'   .+�5v      �� $��0��5w      ��5x      �� $ IngredientModule.UnitList�# [   5y      �� $' !SelectedIngredientModel.IndexUnit���5z      �� 5{      .R�5|      �� ��6(   �� $ Model.Symbol�5}      5      �� 5�      $��1��6   $��+��6)   5�      �� 5�      $��3��5�      $��1��5�      $��0,10,0,0q�5�      $��Right=�5�      $
��Save��5�      ��5�      �� $8 2NetworkModule.SelectedNetworkModel.SaveEditCommand�# [  5�      5�      5�      5�      