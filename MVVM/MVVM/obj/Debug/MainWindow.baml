   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MVVM.ViewModelMVVM.ViewModel  5   	   %clr-namespace:MVVM.View	MVVM.View  5   	       MVVM.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +vmclr-namespace:MVVM.ViewModel     5   	   %vclr-namespace:MVVM.View     5   	     � Title$  
MainWindow��5	   	   $	��600��6   $	��920��6)   
������  � AllowsTransparency .  � WindowStyle$
 None=�6h    � 	Resources 5       �� 
TargetType   
MenuButton �� BasedOn��%0   '	�       7   �� 5   
   " 	�6   8   6)   5      .��5      �� ���#272537 �� CornerRadius$ 20��6"   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��30 �6    �� 5      $��75 �6    �� 5      .+�5      � $��2��6   $��RightToLeft=�6-   .+�5      �� $
��Exit��6   ��6(   �� *	ExitCmd+5      �� 5        	tb_Search#��[ 6   $��1��69   $��1��6I   $
��Left=�6V   �� 5      $��2��6   .+�5      	� $
��Home��6   ��6-   �� *
OpenHome+	� 5       $��	Pdf merge��6   ��62   �� *OpenPdfMerge+	� 5!      $��Pdf --> Word��6   ��65   �� *OpenPdfToWord+5"      �� 5$      -   5        	 ��Name$	 	MainFrame��5$      $��1��60   $��2��6@   $��10q�6M   ��6Y   �� *CurrentView+ 5%      
 �� DataType"  MVVM.ViewModel.HomeViewModel   MVVM.View.HomeView&   MVVM.ViewModel.PdfMergeViewModel   MVVM.View.PdfMergeView'  !MVVM.ViewModel.PdfToWordViewModel   MVVM.View.PdfToWordView��%�   (��       5&   #   *, +)(�� 2     5)   #   *, +)(�� d     5,   #   *, +)�� 5&      "
  6#   .R�5'        5(      �� 5)      "
  6#   .R�5*        5+      �� 5,      "
  6#   .R�5-        5.      5/      50      51      52      53      