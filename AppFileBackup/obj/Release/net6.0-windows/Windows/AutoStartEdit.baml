   M S B A M L   `   `   `  ���� H  DAppFileBackup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AppFileBackup.WindowsAppFileBackup.Windows  )    #AppFileBackup.Windows.AutoStartEdit   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5local#clr-namespace:AppFileBackup.Windows     -     � Title$  AutoStartEdit��$	��184��$	��726��.��� $��	0,10,0,-6q�.+�� -    �Name$ GridEditAutoStart��$��0,10,0,0q�$��51��$	��Top=�$��Center=�$	��706�� � RowDefinitions �� $	��43* � � ColumnDefinitions �� $	��94* ��� $
��213* ��� $
��104* ��� $
��109* ��� $
��185* �.+��� -    ��Name$ TextBoxCurrentDate��$��Center=� �� TextWrapping$
 Wrap=�$��Center=�$	��170��$��1��$��30�� �� IsReadOnlyCaretVisible$
 True���� -    ��Name$ LabelCurrentDate��$��Текущая дата��$��Center=�$��Center=�$��26��$��93��(  "System.Windows.Controls.DatePicker  -     Name$ DatePickerNew��$��2��$��Center=�$��Center=�$��24��$	��100���� -   	 ��Name$	 
ButtonSave��$��3��$��Сохранить��$��Center=�$��Center=�$��30��$��76���� -   $	 ButtonCancel��$��4��$��Отмена��$��Center=�$��Center=�$��30��$��76��
 �� IsCancel$

 True��� $��10,66,10,10q� �� $
��102* ��� $
��441* ��� $
��163* � �� �� .+��� -   $ LabelDescription��$��Комментарий��$��Center=�$��Center=�$��26��$	��102���� -	   $ TextBoxDescription��$��1��$��Center=�$
 Wrap=�$��Center=�$	��420��$��30���� -
    ��Name$ CheckBoxIsActive��$��В работе��$
��Left=�$��10,0,0,0q�$��1��$��Center=�