   M S B A M L   `   `   `  ���� H  DAppFileBackup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AppFileBackup.WindowsAppFileBackup.Windows  (    "AppFileBackup.Windows.FilterWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5local#clr-namespace:AppFileBackup.Windows       � Title$  FilterWindow��$	��450��$	��733��.��� .+�� -    �Name$ 
FilterGrid�� � RowDefinitions �� $	��100 ��� .+�&   System.Windows.Controls.DataGrid  -     Name$ DataGridFiltres��$��1��� -   $ FilterSetting�� � ColumnDefinitions �� $
��119* ��� $
��401* ��� $
��118* ��� $��162.009 � �� �� �� .+��� -    ��Name$ 	LabelName��$��Фильтр��$
��Left=�$��10,0,0,0q�$��Center=�$��26��$��50���� -    ��Name$ TextBoxFilter��$��1��$��Center=� �� TextWrapping$
 Wrap=�$��Center=�$	��339��$��25���� -    ��Name$ 	ButtonAdd��$��2��$��Добавить��$
��Left=�$��10,0,0,0q�$��Center=�$��75��$��25���� -   $ 	ButtonDel��$��Удалить��$
��Left=�$��2��$��Center=�$��74��$��25��$��10,0,0,0q��� -   $ LabelDescription��$��Комментарий��$
��Left=�$��1��$��Center=�$��10,0,0,0q�$��26��$��86���� -	   $ TextBoxDescription��$��1��$��Center=�$��1��$
 Wrap=�$��Center=�$	��339��$��25���� -
   $ ButtonClose��$��3��$��Закрыть��$
��Left=�$��22,0,0,0q�$��Center=�$��25��$��74��