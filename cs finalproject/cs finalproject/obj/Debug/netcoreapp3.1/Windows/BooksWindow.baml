   M S B A M L   `   `   `  ����J  Fcs finalproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:cs_finalproject.Windowscs_finalproject.Windows  5   	   )    #cs_finalproject.Windows.BooksWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:cs_finalproject.Windows     5   	     � Title$  BooksWindow��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ LbtBookName��5
      $��Kitabın Adı��6%   $
��Left=�6;   $��	33,34,0,0q�6V   $	��Top=�6i   �� 5   
   -   5         ��Name$ TxtBookName��5      $
��Left=�6'   $��	33,73,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��120��6�    J� RenderTransformOrigin$ -0.313,0.625&�6�   �� 5   
   -   5        $ LblBookPrice��5      $��Kitabin Qiyməti��6&   $
��Left=�6@   $��	33,96,0,0q�6[   $	��Top=�6n   $ -0.73,0.559&�6�   �� 5   
   -   5        $ TxtBookPrice��5      $
��Left=�6(   $��
33,122,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��120��6�   $ -0.272,0.731&�6�   �� 5   
   -   5         ��Name$ 	BtnSearch��5      $��Axtar��6$   $
��Left=�64   $��
33,171,0,0q�6O   $	��Top=�6c   $ 
1.652,0.26&�6|   $��22��6�   $	��120��6�   6�   �� 5   
   -   5        $ BtnAdd��5      $��
Əlavə et��6!   $
��Left=�64   $��
33,217,0,0q�6O   $	��Top=�6c   $��22��6{   $	��120��6�   6�   �� 5   
   -   5        $ 	BtnUpdate��5      $��Yenilə��6$   $
��Left=�65   $��
33,267,0,0q�6P   $	��Top=�6d   $	��120��6|   $ 0.505,-1.334&�6�   6�   �� 5   
   -   5        $ 	BtnDelete��5      $	��Sil��6$   $
��Left=�62   $��
33,324,0,0q�6M   $	��Top=�6a   $	��120��6y   6�   � 5   
   $��	320,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -	   5          Name$ DgvBooks��5         AutoGenerateColumns$ False��6)      CanUserAddRows$ False��6E   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.20* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $
 0.25* 6)   $ Ad��67    6C   �� *Name+  5      $
 0.25* 6)   $ Qiyməti��67    6H   �� *Price+5      5      5      5      