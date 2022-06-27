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
using Thi.Models;

namespace Thi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLyBenhNhanDBContext qlbn = new QuanLyBenhNhanDBContext();
        public MainWindow()
        {
            InitializeComponent();
            renderKhoa();
            renderDataList();

        }

        private void renderDataList()
        {
            var query = from K in qlbn.BenhNhans
                        select new
                        {
                            K.MaBn,
                            K.HoTen,
                            K.MaKhoa, 
                            K.SoNgayNamVien,
                            K.VienPhi
                        };
            dataList.ItemsSource = query.ToList();
        }

        private void renderKhoa()
        {

            var query = from K in qlbn.Khoas 
                        select K.BenhNhan;
            cbKhoaKham.SelectedIndex = 0;
            cbKhoaKham.ItemsSource = query.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int maBN = int.Parse(txtMaBn.Text);
                string tenBN = txtTenBn.Text;
                int sNNV = int.Parse(txtSNNV.Text);
                var maKhoa = (from K in qlbn.Khoas
                            where K.BenhNhan == cbKhoaKham.Text
                            select K.MaKhoa).Single();
                BenhNhan benhNhan = new BenhNhan();
                benhNhan.MaBn = maBN;
                benhNhan.HoTen = tenBN;
                benhNhan.MaKhoa = maKhoa;
                benhNhan.SoNgayNamVien = sNNV;
                benhNhan.VienPhi = sNNV * 200000;
                qlbn.BenhNhans.Add(benhNhan);
                qlbn.SaveChanges();
                renderDataList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = dataList.SelectedItem;
            if (item != null)
            {
                int maKhoa = int.Parse((dataList.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text);

                var tenKhoa = (from K in qlbn.Khoas
                               where K.MaKhoa == maKhoa
                               select K.BenhNhan).Single();
                cbKhoaKham.SelectedItem = tenKhoa;
            }
            
        }
    }
}
