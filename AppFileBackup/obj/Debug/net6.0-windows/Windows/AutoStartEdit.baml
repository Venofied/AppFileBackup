   M S B A M L   `   `   `  ����H  DAppFileBackup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AppFileBackup.WindowsAppFileBackup.Windows  5   	   )    #AppFileBackup.Windows.AutoStartEdit   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:AppFileBackup.Windows     5   	   -   5          � Title$  AutoStartEdit��5   	   $	��184��6   $	��726��6,   .��5	      � $��	0,10,0,-6q�6   .+�5
   
   � -   5         �Name$ GridEditAutoStart��5
      $��0,10,0,0q�6*   $��51��6<   $	��Top=�6H   $��Center=�6`   $	��706��6}    � RowDefinitions 5      �� 5      $	��43* �6     � ColumnDefinitions 5      �� 5      $	��94* �6#   �� 5      $
��213* �6#   �� 5      $
��104* �6#   �� 5      $
��109* �6#   �� 5      $
��185* �6#   .+�5      �� -   5         ��Name$ TextBoxCurrentDate��5      $��Center=�62    �� TextWrapping$
 Wrap=�6O   $��Center=�6c   $	��170��6~   $��1��6�   $��30��6�    �� IsReadOnlyCaretVisible$
 True��6�   �� 5      -   5         ��Name$ LabelCurrentDate��5      $��Текущая дата��6.   $��Center=�6E   $��Center=�6b   $��26��6}   $��93��6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DatePickerNew��5      $��2��60   $��Center=�6@   $��Center=�6]   $��24��6x   $	��100��6�   �� 5      -   5        	 ��Name$	 
ButtonSave��5      $��3��6)   $��Сохранить��69   $��Center=�6M   $��Center=�6j   $��30��6�   $��76��6�   6�   �� 5      -   5        $	 ButtonCancel��5      $��4��6+   $��Отмена��6;   $��Center=�6L   $��Center=�6i   $��30��6�   $��76��6�   
 �� IsCancel$

 True��6�   6�   5      � 5   
   $��10,66,10,10q�6    5      �� 5      $
��102* �6#   �� 5      $
��441* �6#   �� 5      $
��163* �6#    5!      �� 5"      �� 5#      .+�5%      �� -   5        $ LabelDescription��5%      $��Комментарий��6.   $��Center=�6D   $��Center=�6a   $��26��6|   $	��102��6�   �� 5&      -	   5        $ TextBoxDescription��5&      $��1��62   $��Center=�6B   $
 Wrap=�6_   $��Center=�6s   $	��420��6�   $��30��6�   �� 5'      -
   5         ��Name$ CheckBoxIsActive��5'      $��В работе��61   $
��Left=�6D   $��10,0,0,0q�6_   $��1��6q   $��Center=�6~   5(      5)      5*      