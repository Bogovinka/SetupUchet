   M S B A M L   `   `   `  ����O  KEquipment_Accounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Equipment_AccountingEquipment_Accounting  5   	        Equipment_Accounting.Table   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Equipment_Accounting     5   	     � Title$  Таблица��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��450��6>   $	��800��6K   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��46* �6   �� 5      $
��319* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5   S   $��1��6F   ��6   ��  �� ElementName$ sizeT�� �� Path$ Value�6�   �� 5   
   $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ 
searchText��5      $��10,0,0,0q�6*   $��Center=�6<   $	��200��6W   6h   �� 5      -   5         ��Name$ search��5      $��10,0,0,0q�6%   .��6L   
Найти6S   �� 5      -   5        	 ��Name$	 sizeT��5   *   $��20, 0, 0, 0q�6   $	��200��69   $��Center=�6H   
 �� TickFrequency$
 1Q�6c    � Minimum$ 14Q�6u    � Maximum$ 50Q�6�    � Value$ 16Q�6�   6�   5      5      5      