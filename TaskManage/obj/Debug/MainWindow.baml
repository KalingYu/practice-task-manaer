   M S B A M L   `   `   `  ����E  ATaskManage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TaskManage
TaskManage  5   	       TaskManage.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TaskManage     5   	     � Title$  任务管理器��5   	   $	��850��6   $	��900��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��300 �6   �� 5      $	��300 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $	��600 �6   .+�5   
   �� -   5         ��Name$ 	textBlock��5       �� Padding$ 10q�6'   $��0��64   $��Stretch=�6A   $��24(�6_    �� TextAlignment$ Center=�6m   $
��Wrap=�6�   $��任务管理器��6�   $	��Top=�6�   ���	#FF03A9F4
�������$��3��6�   $��0,0,0,0q�6�   �� 5   
   -   5         ��Name$ 	btn_Close��5      $��关闭进程��6:   $��Stretch=�6I   $	��Top=�6h   $��50��6�   $��24(�6�   ���	#FFCCCCCC
�������$��2��6�   $��0q�6�   $��1��6�   $��0q�6�   �� 5   
   -   5        $ 
btn_Browse��5      $��1��6;   $��浏览进程��6H   $��Stretch=�6W   $	��Top=�6v   $��50��6�   $��24(�6�   ���	#FFCCCCCC
�������$��1��6�   $��0q�6�   $��2��6�   $��0q�6�   �� 5   
   -   5        $ btn_Add��5      $��添加进程��68   $��Stretch=�6G   $	��Top=�6f   $��50��6~   $��24(�6�   ���	#FFCCCCCC
�������$��0��6�   $��0q�6�   $��1��6�   $��0q�6�   � 5   
   $��0��6   $��3��6    $��4��64   $��Stretch=�6A   $��Stretch=�6_   $��0q�6{    5      �� 5      $
��103* �6#   �� 5      $
��498* �6#   .+�5!       � -   5          �Name$ frame��5!        � NavigationUIVisibility$ Hidden=�6#   $��Stretch=�6C   $��0,0,0,-72.75q�6a   $��2��6w   5#      5%      5&      