   M S B A M L   `   `   `  ����J  Fcs finalproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:cs_finalproject.Windowscs_finalproject.Windows  5   	   ,    &cs_finalproject.Windows.CustomerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:cs_finalproject.Windows     5   	     � Title$  CustomerWindow��5   	   $	��450��6    $	��784��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ LblCustomerName��5      $��Ad��6)   $
��Left=�66   $��	34,23,0,0q�6Q   $	��Top=�6d   $��99��6|   $��26��6�   �� 5   
   -   5         ��Name$ TxtCustomerName��5      $
��Left=�6+   $��	34,73,0,0q�6F    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��26��6�   �� 5   
   -   5        $ LblCustomerPhone��5      $��Telefon nomresi��6*   $
��Left=�6D   $��
34,131,0,0q�6_   $	��Top=�6s   $��26��6�   $��94��6�   �� 5   
   -   5        $ TxtCustomerPhone��5      $
��Left=�6,   $��
34,184,0,0q�6G   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   $��26��6�   �� 5   
   -   5         ��Name$ BtnCustomerAdd��5      $��
Əlavə et��6)   $
��Left=�6<   $��
34,248,0,0q�6W   $	��Top=�6k   $	��120��6�   $��20��6�   �� 5   
   -   5        $ BtnCustomerUpdate��5      $��Yenilə��6,   $
��Left=�6=   $��
34,304,0,0q�6X   $	��Top=�6l   $	��120��6�   $��20��6�   6�   �� 5   
   -   5        $ BtnCustomerDelete��5      $	��Sil��6,   $
��Left=�6:   $��
34,359,0,0q�6U   $	��Top=�6i   $	��120��6�   $��22��6�   6�   � 5   
   $��	253,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DgvCustomer��5         AutoGenerateColumns$ False��6,      CanUserAddRows$ False��6H   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.20* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $
 0.25* 6)   $ Ad��67    6C   �� *Name+  5      $
 0.25* 6)   $ Telefon nomresi��67    6P   �� *Phone+5      5      5"      5#      