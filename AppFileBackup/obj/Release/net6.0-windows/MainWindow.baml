   M S B A M L   `   `   `  ���� H  DAppFileBackup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AppFileBackupAppFileBackup  ;"clr-namespace:AppFileBackup.ModelsAppFileBackup.Models      AppFileBackup.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:AppFileBackup     5Models"clr-namespace:AppFileBackup.Models     -     � Title$  
MainWindow��$	��536��$	��800��.��� .+��� $��Пути�� J� RenderTransformOrigin$ 0.498,0.482&�$��0,10,0,0q�.��� -    �Name$ GridPathSettings��$	��486��$ 0.498,0.502&�$��	10,0,-2,0q� � RowDefinitions �� $��71 ��� $��54 ��� $��50 ��� .+�� -   $ GridSourcePath��$	��Top=�$��Center=�$��53��$	��760�� � ColumnDefinitions �� $	��150 ��� �� $��94 �.+��� -    ��Name$ TextBoxPathTemp��$��1��$��10,11,10,12q� �� TextWrapping$
 Wrap=�$��30���� -    ��Name$ LabelPathTemp��$(��"Путь целевой папки��$��
10,10,0,10q��� -    ��Name$ ChangePathTemp��$��2��$��Выбрать��$��Center=�$��Center=�$��30��$��74��&   System.Windows.Controls.DataGrid  -   	  Name$	 GrigPathSource��$��3��$��
0,10,10,10q�
 � DataContext
 &    AppFileBackup.Models.PathSetting  � $��2��$��0,0,10,0q� �� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� �� $��68 �.+��� -   $ EditPath��$��Изменить��$
��Left=�$��10,0,0,0q�$��Center=�$��30��$��75���� -	   $ DeletePathSource��$��1��$��Удалить��$��Center=�$��Center=�$��76��$��30���� -
   $ 	AutoStart��$��2��$��Автозапуски��$
��Left=�$��10,0,0,0q�$��Center=�$��75��$��30���� -   $ buttonFiltres��$��3��$��Фильтры��$��Center=�$��Center=�$��76��$��30���� -   $ 
ButtonSave��$��4��$��Сохранить��$
��Left=�$��15,0,0,0q�$��Center=�$��75��$��30���� -   $ ButtonStartBackup��$��5��$��Запустить��$��Center=�$��Center=�$��76��$��30�����	#FFB3FFBF$��Segoe UI Black)�$��11(��� -   $ 
ButtonStop��$��6��$��Остановить��$
��Left=�$��10,0,0,0q�$��Center=�$��76��$��30�����	#FFFF8E8E�� -   $ ButtonRefresh��$��7��$�� ��$��Center=�$��Center=�$��40��$��30������  �� ImageSource$ /170990.png��� $��1�� �� $
��137* ��� $
��539* ��� $
��104* �.+��� -   $ LabelPathSource��$*��$Путь исходной папки��$
��Left=�$��	24,10,0,0q�$	��Top=�$��26��$	��127��$��2���� -   $ TextBoxPathSource��$��1��$
��Left=�$��34,0,0,0q�$
 Wrap=�$��Center=�$	��495��$��30���� -   $ AddPathSource��$��2��$��Добавить��$
��Left=�$	��Top=�$��75��$��30��$��	10,10,0,0q�