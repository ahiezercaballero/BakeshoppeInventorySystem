   M S B A M L   `   `   `  ����T  PBakeshoppeInventorySystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:BakeshoppeInventorySystem.Views.Network'BakeshoppeInventorySystem.Views.Network  5      H    BBakeshoppeInventorySystem.Views.Network.LoadTransactionUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:BakeshoppeInventorySystem.Views.Network     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � DataContext  5
      ��  �� Path$ LoadTransactionModule�   Locator �� Source# [  .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      �� 5       .+�5"      �� $��0��5#      $
��Left=�5$        	subHeader#��[ 5%      $��ACTIVITY HISTORY��5&      �� 5'      -   5        $��SyncTextBlock��5(      $��1��5)      $��Right=�5*       �� Orientation$ 
Horizontal=�5+      .+�5,      �� 
���  ����5.      �� $ NetworkModule.TextSync� �� UpdateSourceTrigger$ PropertyChanged=�# [  y�5/      �� $ NetworkModule.TextSync�   BooleanToVisibilityConverter �� 	Converter# [  �� ConverterParameter$
 true��$ PropertyChanged=�# [  �� 50      $��Right=�51      $��Refresh��53      ��52      �� $ RefreshCommand�53      54      55      &   System.Windows.Controls.DataGrid  56   
   $��1��57      	   AutoGenerateColumns	 .  ��59      �� $ LoadTransactionList�
   Columns
 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��5=         
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5<      �� $ 
Model.Date�5>        5?      $ Amount Beginning��5A       .  5@      �� $ Model.AmountBeginning�5B        5C      $ Action��5E       .  5D      �� $ LoadProfile.Remarks�5F        5G      $ Load / Reload Amount��5I       .  5H      �� $ Model.LoadAmount�5J        5K      $ Current Balance��5M       .  5L      �� $ Model.CurrentBalance�5N       � ContextMenu 5P      �� 5Q      .@�5R      m� $��Filter by Load��6L    m� Command 6   �� $ FilterByLoadCommand�6L   m� 5S      $��Filter by Reload��6N    6   �� $ FilterByReloadCommand�6N   m� 5T      $��Filter by All��6K    6   �� $ FilterByAllCommand�6K   5U      5W      � 5[   
   $��2��6   $��0,15,0,0q�6    5\      �� 5]      $
��Auto �6    �� 5^      $
��Auto �6    �� 5_      $
��Auto �6    �� 5`      $
��Auto �6    �� 5a      $
��Auto �6     5c      �� 5d      $
��Auto �6#   �� 5e      $��* �6#   .+�5g      �� $��0��5h      $��2��5i      #��[ 5j      $��CREATE ACTIVITY��5k      � 5l      $��1��5m      $��0��5n      $��2��5o      $��0,10,0,5q�5p      $��Center=�5q        5r      �� $ LoadTransactionModule�# [   5s      �� 5t      �� 5u      .+�5w      	� -   5        $��RadioButtonLoad��5x      $��0��5y      $
��Load��5z       d� 	IsChecked 5{      �� $ IsCheckedLoad�	� 5|      -   5        $��RadioButtonReload��5}      $��1��5~      $��20,0,0,0q�5      $��Reload��5�       5�      �� $ IsCheckedReLoad�5�      �� 5�      $��2��5�      $��0��5�      $��Network��5�      �� 5�      $��3��5�      $��0��5�      $��Amount��5�      �� 5�      $��4��5�      $��0��5�      $��Current Balance��5�      �� 5�      -   5        $��NetworkComboBox��5�      $��2��5�      $��1��5�       �� 
IsReadOnly .  �� SelectedIndex$ 0��5�      ��5�      �� $ NetworkList� �� SelectedItem 5�      �� $ SelectedNetworkModel���5�      �� 5�      .R�5�      �� ��6$   �� $ 
Model.Name�5�      5�      �� 5�      $��3��5�      $��1��5�      ��5�      �� $) #LoadTransactionModule.TextBoxAmount�# [  $ PropertyChanged=�� 5�      $��4��6   $��1��6     5�      �� 5�      $��* �6'   �� 5�      $
��Auto �6'   .+�5�      �� $��0��5�      {�.  ��5�      �� $ CurrentBalance��� 5�      $��1��5�      $��Right=�5�      $
��Save��5�      ��5�      �� $ AddLoadTransactionCommand�5�      5�      5�      5�      5�      