   M S B A M L   `   `   `  ����G  CExamTodoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ExamTodoListExamTodoList  5   	   ?$clr-namespace:ExamTodoList.ViewModelExamTodoList.ViewModel  62       ExamTodoList.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ExamTodoList     5   	   :	viewmodel$clr-namespace:ExamTodoList.ViewModel     62     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   ���#2196F3.+�5      �� $��Список дел��6   $��24(�6*   
�������68   5      � 5   
   $��1��6   $��20q�6   .+�5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��6[   ��6   �� *Tasks+ �� SelectedItem 65   �� *SelectedTask+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Title+  5      $ Срок��6)    67   �� *	DueDate+  5      $ Приоритет��6)    6<   �� *
Priority+  5      $ Комментарий��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>    6H   �� *	Comment+5      5      � 5"   
   $��2��6   $��20q�6    � ColumnDefinitions 5#      �� 5$      $��* �6#   �� 5%      $
��auto �6#   �� 5&      $
��auto �6#   �� 5'      $
��auto �6#    5*      �� 5+      6"   �� 5,      6"   .+�5/      �� -   5        	 ��Name$	 txtTitle��5/      $��0��6L   $��Center=�6\   ��6(   �� *Title+
 �� Mode$
 TwoWay=�6\   (  "System.Windows.Controls.DatePicker  50      -   5          Name$ 	dpDueDate��50      $��1��6Z   $��10q�6j   $��Center=�6v      SelectedDate 6,   �� *	DueDate+$
 TwoWay=�6v   �� 51      -   5         ��Name$ 
cbPriority��51      $��2��6+   $	��120��6;   $��Center=�6G   ��52      �� *PriorityCategories+ 6:   �� *SelectedPriorityCategory+�� 53      $��3��6   $��Добавить��6%   $��80��68   $��10,0,0,0q�6C   $��Center=�6U   ��54      �� *AddTaskCommand+�� 55      $��1��6   $
��Left=�6#    �� TextWrapping$
 Wrap=�6>   $	��Top=�6x   $	��500��6�   ��6R   �� *	Comment+$
 TwoWay=�6�   �� 56      $��1��6   $��2��6"   $	��120��63   ��6?   �� *
FileWriter+.��6^   В файл6f   �� 57      $��1��6   $��3��6"   $��80��62   $��10,0,0,0q�6=   ��6O   �� *
FileReader+.��6n   Считать6w   58      59      5:      