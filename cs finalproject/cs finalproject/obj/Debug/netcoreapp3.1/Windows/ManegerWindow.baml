   M S B A M L   `   `   `  ����J  Fcs finalproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:cs_finalproject.Windowscs_finalproject.Windows  5   	   +    %cs_finalproject.Windows.ManegerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:cs_finalproject.Windows     5   	     � Title$  ManegerWindow��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ LblManegerName��5
      $��Ad��6(   $
��Left=�65   $��	54,23,0,0q�6P   $	��Top=�6c   �� 5   
   -   5         ��Name$ TxtManegerName��5      $
��Left=�6*   $��	54,54,0,0q�6E    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��120��6�   �� 5   
   -   5        $ LblManegerPassword��5      $��Şifrə��6,   $
��Left=�6<   $��	54,91,0,0q�6W   $	��Top=�6j   G� 5   
   -   5         G�Name$ TxtManegerPassword��5      $
��Left=�62   $��
54,122,0,0q�6M   $	��Top=�6a   $	��120��6y   �� 5   
   -   5         ��Name$ BtnManegerAdd��5      $��
Əlavə et��6(   $
��Left=�6;   $��
54,198,0,0q�6V   $	��Top=�6j   $��33��6�   $	��120��6�   6�   �� 5   
   -   5        $ BtnManegerUpdate��5      $��Yenilə��6+   $
��Left=�6<   $��
54,250,0,0q�6W   $	��Top=�6k   $��30��6�   $	��120��6�   6�   �� 5   
   -   5        $ BtnManegerDelete��5      $	��Sil��6+   $
��Left=�69   $��
54,305,0,0q�6T   $	��Top=�6h    J� RenderTransformOrigin$ 0.162,0.491&�6�   $	��120��6�   $��27��6�   6�   � 5   
   $��	271,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
DgvManeger��5         AutoGenerateColumns$ False��6+   	   CanUserAddRows$	 False��6G   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.20* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $ 0.25* 6)   $ Ad��67    6C   �� *Name+  5      $ 0.25* 6)   $ Şifrə��67    6F   �� *
Password+5      5      5      5      