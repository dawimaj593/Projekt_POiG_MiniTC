   M S B A M L   `   `   `  ����A  =MiniTC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MiniTCMiniTC  5   	   3clr-namespace:MiniTC.ViewModelMiniTC.ViewModel  5   	       MiniTC.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MiniTC     5   	   -vmclr-namespace:MiniTC.ViewModel     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	     � Title$  MiniTC��5
   	   $	��800��6   $
��1000��6%   
������� � DataContext 5         MiniTC.ViewModel.ViewModel  5   
   6    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ 30��6'   64   �� 5       � ��$ 80��6&   63   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,    � RowDefinitions 5   
   �� 5      $��9* �6   6*   �� 5      $��1* �6   6*   .+�5!   
      MiniTC.PanelTC  $��0��5"      $��0��5#         CurrentPath 5$      �� *Left+	 �� Mode$	 TwoWay=�
   	AllDrives
 5%      ��  �� Path$ CurrentDrives�   AllFiles 5&      �� $ CurrentLeftFiles�   CurrentFile 5'      �� $ SelectedFile�$	 TwoWay=�.  (System.Windows.Interactivity.Interaction   Triggers 5(      /  )System.Windows.Interactivity.EventTrigger  5)         	EventName$ MouseDoubleClick��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5*      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *
LeftChceck+5+      5-        5/   
   $��1��50      $��0��51       52      �� *Right+$	 TwoWay=�
 53      �� $ CurrentDrives� 54      �� $ CurrentRightFiles� 55      �� $ SelectedFile�$	 TwoWay=� 56        57      $ MouseDoubleClick��6!   . 58         6,   �� *
RightCheck+59      5;      �� 5=   
   $��1��5>      $��2��5?      $��Copy>>��5@       5A        5B      $ Click��6!   . 5C         6,   �� *Copy+5D      5F      5H      5I      