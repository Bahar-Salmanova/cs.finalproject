   M S B A M L   `   `   `  ����J  Fcs finalproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:cs_finalproject.Windowscs_finalproject.Windows  5   	   -    'cs_finalproject.Windows.DashboardWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:cs_finalproject.Windows     5   	     � Title$  DashboardWindow��5   	   $	��450��6!   $	��772��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��41* �6   �� 5      $
��345* �6   .+�5   
   �� -   5         ��Name$ BtnBookWindowOpen��5      $��Books��6,   $
��Left=�6<   $��
24,145,0,0q�6W   $	��Top=�6k   $��36��6�    J� RenderTransformOrigin$ 9.236,0.256&�6�   $	��130��6�   $��2��6�   �� 5   
   -   5        $ BtnCustomerWindowOpen��5      $��Customer��60   $
��Left=�6C   $��	24,88,0,0q�6^   $	��Top=�6q   $	��130��6�   $��38��6�   $��2��6�   �� 5   
   -   5        $ BtnManegerWindowsOpen��5      $��Maneger��60   $
��Left=�6B   $��	24,32,0,0q�6]   $	��Top=�6p   $��35��6�   $	��130��6�   $��2��6�   �� 5   
   -   5        $ BtnCreateOrder��5      $��Sifaris yarat��6)   $
��Left=�6A   $��24,0,0,0q�6\   $��Center=�6n   $��35��6�   $	��126��6�   $��2��6�   �� 5   
   -   5        $ BtbBookBack��5      $��Kitab Qaytar��6&   $
��Left=�6=   $��
24,256,0,0q�6X   $	��Top=�6l   $��38��6�   $	��126��6�   $��2��6�   �� 5   
   -   5        $��1��5      $��	107,0,0,0q�6&   .@�5      �� -   5         ��Name$ tabToday��5      $��Bugun��6)   $��
-2,-2,-2,0q�68   $��20��6L   $	��Top=�6X   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ DgvToday��5         AutoGenerateColumns$ False��6-      CanUserAddRows$ False��6I      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 0.15* 6-   
   Header$
 Id��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *Id+  5      $	 0.15* 6-   $
 Musteri Adi��6;    6P   �� *Customer.Name+  5      $	 0.15* 6-   $
 Kitab Id��6;    6M   �� *BookId+  5      $	 0.15* 6-   $
 Baslama Vaxti��6;    6R   �� *
startDay+ �� StringFormat$ {0:dd.MM.yyyy }��  5      $	 0.15* 6-   $
 Bitme Vaxti��6;    6P   �� *endDay+$ {0:dd.MM.yyyy }��  5      $	 0.15* 6-   $
 
Idareci Id��6;    6O   �� *	ManegerId+5!      5"      �� 5#      $��Sabah��6   .��5$        -	   5        $ DgvTomorrow��5$      $ False��61   $ False��6M    5%        5&      $	 0.15* 6-   $
 Id��6;    6G   �� *Id+  5'      $	 0.15* 6-   $
 Musteri Adi��6;    6P   �� *Customer.Name+  5(      $	 0.15* 6-   $
 Kitab Id��6;    6M   �� *BookId+  5)      $	 0.15* 6-   $
 Baslama Vaxti��6;    6R   �� *
startDay+$ {0:dd.MM.yyyy }��  5*      $	 0.15* 6-   $
 Bitme Vaxti��6;    6P   �� *endDay+$ {0:dd.MM.yyyy }��  5,      $	 0.15* 6-   $
 
Idareci Id��6;    6O   �� *	ManegerId+5.      5/      �� 50      $��
Gecikenler��6   $��
-2,-2,-2,2q�6*   .��51        -
   5        $ DgvLate��51      $ False��6.   $ False��6J    52        53      $	 0.15* 6-   $
 Id��6;    6G   �� *Id+  54      $	 0.15* 6-   $
 Musteri Adi��6;    6P   �� *Customer.Name+  55      $	 0.15* 6-   $
 Kitab Id��6;    6M   �� *BookId+  56      $	 0.15* 6-   $
 Baslama Vaxti��6;    6R   �� *
startDay+$ {0:dd.MM.yyyy }��  57      $	 0.15* 6-   $
 Bitme Vaxti��6;    6P   �� *endDay+$ {0:dd.MM.yyyy }��  58      $	 0.15* 6-   $
 
Idareci Id��6;    6O   �� *	ManegerId+5:      5;      5<      5@      5A      