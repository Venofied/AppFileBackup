   M S B A M L   `   `   `  ���� H  DAppFileBackup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AppFileBackup.WindowsAppFileBackup.Windows  1    +AppFileBackup.Windows.EditPathSettingWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5local#clr-namespace:AppFileBackup.Windows     -     � Title$  EditPathSettingWindow��$	��292��$	��800��.��� -    �Name$ GridSettingPath�� � RowDefinitions �� $��99 ��� .+�� $��	10,0,10,0q�.+��  �� ��  � ColumnDefinitions �� $
��142* ��� $
��441* ��� $
��103* ��� $	��94* �.+��� -    ��Name$ 	LabelPath��$*��$Путь исходной папки��$��Center=�$��0,10,0,0q�$	��Top=�$��26��$	��126���� -    ��Name$ TextBoxPath��$��1��$��Center=�$��0,10,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��385��$��26���� -    ��Name$ 
ButtonSave��$��2��$��Сохранить��$��Center=�$��0,10,0,0q�$	��Top=� J� RenderTransformOrigin$ 	0.51,0.56&�$��30��$��74���� -   $ ButtonClose��$��3��$��Закрыть��$��Center=�$	��Top=�$��30��$��74��$��0,10,0,0q��� -   $ LabelDescription��$��Комментарий��$
��Left=�$��10,0,0,0q�$��1��$��Center=��� -   $ TextBoxDescription��$��1��$��Center=�$��0,14,0,0q�$��1��$
 Wrap=�$	��Top=�$	��385��$��26��� -	   $ GridSetting��$��1��$��	10,0,10,0q� �� $	��27* ��� $
��103* �.+�� -
   $ GridInnerSettingPath�� �� $��50 ��� $��50 ��� $��50 ��� .+��� -   	 ��Name$	 CheckBoxSyncData��$ ��Синхронизация��$
��Left=�$��	10,10,0,0q�$	��Top=��� -   $	 CheckBoxIsActive��$��Активный��$
��Left=�$��10,0,0,0q�$��1��$��Center=��� -   
 ��Name$
 ComboBoxChangeSettingList��$
��Left=�$��10,0,0,0q�$��2��$��Center=�$	��120�� �� SelectedIndex$ 0��.@��� $��Автозапуск���� $��Фильтры��&   System.Windows.Controls.DataGrid  -     Name$ DataGridAdvanced��$��1��   
IsReadOnly$
 True��