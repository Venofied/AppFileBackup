   M S B A M L   `   `   `  ����H  DAppFileBackup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AppFileBackup.WindowsAppFileBackup.Windows  5   	   1    +AppFileBackup.Windows.EditPathSettingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:AppFileBackup.Windows     5   	   -   5          � Title$  EditPathSettingWindow��5   	   $	��292��6'   $	��800��64   .��5	      � -   5         �Name$ GridSettingPath��5	       � RowDefinitions 5
   
   �� 5      $��99 �6   �� 5      .+�5   
   � $��	10,0,10,0q�6   .+�5      �  5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      $
��142* �6'   �� 5      $
��441* �6'   �� 5      $
��103* �6'   �� 5      $	��94* �6'   .+�5      �� -   5         ��Name$ 	LabelPath��5      $*��$Путь исходной папки��6+   $��Center=�6I   $��0,10,0,0q�6f   $	��Top=�6x   $��26��6�   $	��126��6�   �� 5      -   5         ��Name$ TextBoxPath��5      $��1��6/   $��Center=�6?   $��0,10,0,0q�6\    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��385��6�   $��26��6�   �� 5      -   5         ��Name$ 
ButtonSave��5      $��2��6-   $��Сохранить��6=   $��Center=�6Q   $��0,10,0,0q�6n   $	��Top=�6�    J� RenderTransformOrigin$ 	0.51,0.56&�6�   $��30��6�   $��74��6�   6�   �� 5      -   5        $ ButtonClose��5      $��3��6.   $��Закрыть��6>   $��Center=�6P   $	��Top=�6m   $��30��6�   $��74��6�   $��0,10,0,0q�6�   �� 5      -   5        $ LabelDescription��5      $��Комментарий��62   $
��Left=�6H   $��10,0,0,0q�6c   $��1��6u   $��Center=�6�   �� 5      -   5        $ TextBoxDescription��5      $��1��66   $��Center=�6F   $��0,14,0,0q�6c   $��1��6u   $
 Wrap=�6�   $	��Top=�6�   $	��385��6�   $��26��6�   5       5!      � 5"   
   -	   5        $ GridSetting��5"      $��1��6$   $��	10,0,10,0q�61    5#      �� 5$      $	��27* �6#   �� 5%      $
��103* �6#   .+�5'      � -
   5        $ GridInnerSettingPath��5'       5(      �� 5)      $��50 �6$   �� 5*      $��50 �6$   �� 5+      $��50 �6$   �� 5,      .+�5.      �� -   5        	 ��Name$	 CheckBoxSyncData��5.      $ ��Синхронизация��65   $
��Left=�6M   $��	10,10,0,0q�6h   $	��Top=�6{   �� 5/      -   5        $	 CheckBoxIsActive��5/      $��Активный��65   $
��Left=�6H   $��10,0,0,0q�6c   $��1��6u   $��Center=�6�   �� 50      -   5        
 ��Name$
 ComboBoxChangeSettingList��50      $
��Left=�6>   $��10,0,0,0q�6Y   $��2��6k   $��Center=�6x   $	��120��6�    �� SelectedIndex$ 0��6�   .@�51      �� $��Автозапуск��6#   �� 52      $��Фильтры��6#   53      54      &   System.Windows.Controls.DataGrid  55      -   5          Name$ DataGridAdvanced��55      $��1��61      
IsReadOnly$
 True��6l   56      58      59      