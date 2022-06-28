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
using System.Windows.Shapes;
using Thi3.Models;
namespace Thi3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    
    public partial class Window1 : Window
    {

        public QLBHContext qlbh = new QLBHContext();
        public Window1()
        {
            InitializeComponent();
            render();
        }

        private void render()
        {
            var query = from N in qlbh.NhomHangs
                        join S in qlbh.SanPhams on N.MaNhomHang equals S.MaNhomHang
                        where N.MaNhomHang == 1
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
            dataList2.ItemsSource = query.ToList();
        }

        
    }
}
