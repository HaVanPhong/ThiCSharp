using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Thi3.Models;
namespace Thi3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBHContext qlbh= new QLBHContext();
        public MainWindow()
        {
            InitializeComponent();
            renderCBNhomHang();
            renderDataGrid();
        }

        private void renderDataGrid()
        {
            var query = from N in qlbh.NhomHangs
                        join S in qlbh.SanPhams on N.MaNhomHang equals S.MaNhomHang
                        orderby S.SoLuongBan descending
                        select new
                        {
                            S.MaSp,
                            S.TenSanPham,
                            S.DonGia,
                            S.SoLuongBan,
                            N.TenNhomHang,
                            TienBan = S.DonGia * S.SoLuongBan
                        };
            dataList.ItemsSource = query.ToList();

        }

        private void renderCBNhomHang()
        {
            var query = from K in qlbh.NhomHangs
                        select K.TenNhomHang;
            cbNhomHang.ItemsSource = query.ToList();
            cbNhomHang.SelectedIndex = 0;
        }

        private void dataList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = dataList.SelectedItem;
            if (item!= null)
            {
                string nhomHang = (dataList.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;

                cbNhomHang.SelectedItem = nhomHang;
            }
            
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int maSP = int.Parse(txtMaSP.Text);
                string tenSP = txtTenSP.Text;
                int donGia = int.Parse(txtDonGia.Text);
                int slBan = int.Parse(txtSoLuong.Text);
                string nhomHang = cbNhomHang.Text;

                if (slBan < 1)
                {
                    throw new Exception("Số lượng bán phải >=1");
                }

                var checkMaSP = (from K in qlbh.SanPhams
                                 where K.MaSp == maSP
                                 select K.MaSp).SingleOrDefault();

                if (checkMaSP != 0)
                {
                    throw new Exception("Mã sản phẩm đã tồn tại");
                }

                SanPham sanPham = new SanPham();
                sanPham.MaSp= maSP;
                sanPham.TenSanPham = tenSP;
                sanPham.DonGia = donGia;
                sanPham.SoLuongBan = slBan;
                sanPham.MaNhomHang = (from K in qlbh.NhomHangs
                                      where K.TenNhomHang == nhomHang
                                      select K.MaNhomHang).Single();
                qlbh.SanPhams.Add(sanPham);
                qlbh.SaveChanges();
                renderDataGrid();

                txtMaSP.Text = "";
                txtMaSP.Focus();
                txtTenSP.Text = "";
                txtSoLuong.Text = "";
                txtDonGia.Text = "";
            } catch(FormatException err)
            {
                MessageBox.Show("Đơn giá và số lượng phải nhập số");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            

            Window1 wd = new Window1();
            wd.Show();
        }
    }
}
