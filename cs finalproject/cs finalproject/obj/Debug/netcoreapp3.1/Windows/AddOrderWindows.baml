   M S B A M L   `   `   `  ����J  Fcs finalproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:cs_finalproject.Windowscs_finalproject.Windows  5   	   -    'cs_finalproject.Windows.AddOrderWindows   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:cs_finalproject.Windows     5   	     � Title$  AddOrderWindows��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ LblCustomerName��5
      $��Musteri Adi��6)   $
��Left=�6?   $��	72,10,0,0q�6Z   $	��Top=�6m   �� 5   
   -   5         ��Name$ TxtCustomerName��5      $
��Left=�6+   $��	46,41,0,0q�6F    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��123��6�   $��28��6�   6�   �� 5   
   -   5        $ TxtBookName��5      $
��Left=�6'   $��
47,100,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   $��29��6�   �� 5   
   -   5        $ LblBookName��5      $��	Kitab Adi��6%   $
��Left=�69   $��	78,74,0,0q�6T   $	��Top=�6g   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	DtpEndDay��5      $
��Left=�6(   $��
51,230,0,0q�6C   $	��Top=�6W   $	��183��6o      FirstDayOfWeek$ Monday=�6{   �� 5   
   -   5         ��Name$ BtnNewOrder��5      $��Yarat��6&   $
��Left=�66   $��
63,322,0,0q�6Q   $	��Top=�6e   $	��106��6}   $��33��6�   6�   � 5   
   $��	253,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DgvOrder��5         AutoGenerateColumns$ False��6)   	   CanUserAddRows$	 False��6E   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.15* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $ 0.15* 6)   $ Musteri Adi��67    6L   �� *Customer.Name+  5      $ 0.15* 6)   $ Kitab Id��67    6I   �� *BookId+  5      $ 0.15* 6)   $ Baslama Vaxti��67    6N   �� *
startDay+ �� StringFormat$ {0:dd.MM.yyyy }��  5      $ 0.15* 6)   $ Bitme Vaxti��67    6L   �� *endDay+$ {0:dd.MM.yyyy }��  5      $ 0.15* 6)   $ Idareci Adi��67    6L   �� *	ManegerId+5      5      �� 5    
   -   5        $ LblReturnBookTime��5       $��Bitme Tarixi��6+   $
��Left=�6B   $��
55,199,0,0q�6]   $	��Top=�6q    J� RenderTransformOrigin$ -0.723,0.196&�6�   �� 5!   
   -	   5        $ LblManegerName��5!      $��Idareci Adi��6(   $
��Left=�6>   $��
55,259,0,0q�6Y   $	��Top=�6m   $ 0.544,3.098&�6�   �� 5"   
   -
   5        $ TxtManegerName��5"      $
��Left=�6*   $��
55,290,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��132��6�   $��27��6�     5#   
   -   5        $ DtpStartDay��5#      $
��Left=�6*   $��
51,165,0,0q�6E   $	��Top=�6Y   �� 5$   
   -   5        $ LblStart��5$      $��Baslama vaxti��6"   $
��Left=�6:   $��
55,134,0,0q�6U   $	��Top=�6i   �� 5%   
   -   5        $ BtnOrderUpdates��5%      $��Yenile��6*   $
��Left=�6;   $��
63,375,0,0q�6V   $	��Top=�6j   $��34��6�   $	��106��6�   6�   5'      5(      