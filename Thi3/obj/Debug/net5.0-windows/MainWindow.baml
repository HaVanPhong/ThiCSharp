   M S B A M L   `   `   `  ����?  ;Thi3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Thi3Thi3  5   	       Thi3.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Thi3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 	Resources��%�  '��       '  z     '�� �     �� 5
   
   " ��6   .�5      ��  � ��$ Time New Roman)�6+   �� 5       � ��
 ��  �6+   5      �� 5   
   "  6   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ Center=�6;   5      �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$	 100��65   5      5      .�5      ��  � �� �#6666+   �� 5       � ��$
 Bold"�6+   5      5      .��5      � .+�5   
   �� $��Mã sản phẩm��6   $
��Left=�6&   $��30��6A   $��	45,10,0,0q�6M   $	��Top=�6`   $	��207��6x   �� 5   
   -   5         ��Name$ txtMaSP��5   Y   $
��Left=�6j   $��30��6�   $��
284,10,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��340��6�   ��6   �� *SelectedItem.MaSp+ �� ElementName$ dataList��	 �� Mode$	 OneWay=�6�   �� 5   
   $��Tên sản phẩm��6   $
��Left=�6'   $��30��6B   $��	45,45,0,0q�6N   $	��Top=�6a   $	��207��6y   �� 5    
   -   5        $ txtTenSP��5    ^   $
��Left=�6p   $��30��6�   $��
284,45,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��340��6�   ��6   �� *SelectedItem.TenSanPham+$ dataList��$	 OneWay=�6�   �� 5!   
   $��
Đơn giá��6   $
��Left=�6"   $��30��6=   $��	45,80,0,0q�6I   $	��Top=�6\   $	��207��6t   �� 5"   
   -   5        $ 	txtDonGia��5"   Z   $
��Left=�6m   $��30��6�   $��
284,80,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��340��6�   ��6   �� *SelectedItem.DonGia+$ dataList��$	 OneWay=�6�   �� 5#   
   $��Số lượng��6   $
��Left=�6#   $��30��6>   $��
45,115,0,0q�6J   $	��Top=�6^   $	��207��6v   �� 5$   
   -   5        $ 
txtSoLuong��5$   ^   $
��Left=�6r   $��30��6�   $��284,115,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��340��6�   ��6   �� *SelectedItem.SoLuongBan+$ dataList��$	 OneWay=�6�   �� 5%   
   $��Nhóm hàng��6   $
��Left=�6$   $��30��6?   $��
45,145,0,0q�6K   $	��Top=�6_   $	��207��6w   �� 5&   
   -   5        
 ��Name$
 
cbNhomHang��5&      $
��Left=�6'   $��25��6B   $��284,150,0,0q�6N   $	��Top=�6c   $	��340��6{   &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ dataList��5'   /      AutoGenerateColumns$ False��6   $	��600��6A   $��100,180,100,95q�6M      Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sản phẩm��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *MaSp+  5*      $ Tên sản phẩm��6%   $	 100 6;    6H   �� *
TenSanPham+  5+      $ 
Đơn giá��6%   $	 100 66    6B   �� *DonGia+  5,      $ Số lượng bán��6%   $	 100 6;    6G   �� *
SoLuongBan+  5-      $ Nhóm hàng��6%   $	 100 68    6D   �� *TenNhomHang+  5.      $ Tiền bán��6%   $	 100 67    6C   �� *	TienBan+52      �� 53   
   -   5         ��Name$ btnThem��53      $��Thêm��6"   $
��Left=�61   $��39��6L   $��148,361,0,0q�6X   $	��Top=�6m   $	��156��6�   6�   �� 54   
   -   5        $ 
btnTimKiem��54      $
��TÌm��6%   $
��Left=�63   $��39��6N   $��494,361,0,0q�6Z   $	��Top=�6o   $	��156��6�   6�   55      56      