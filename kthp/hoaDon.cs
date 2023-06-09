﻿using BLLQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kthp
{
    public partial class hoaDon : Form
    {
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOHoaDon sp = null;
        DTOChiTietHoaDon sp2 = null;

        private string maHoaDon;
        private string maKhachHang;
        private string ngayHoaDon;
        private string gioHoaDon;
        private int donGia;

        public hoaDon()
        {
            InitializeComponent();
        }

        public void ConfigureSP()
        {
            dgwHoaDon.Columns[0].HeaderText = "Mã hoá đơn";
            dgwHoaDon.Columns[1].HeaderText = "Mã khách hàng";
            dgwHoaDon.Columns[2].HeaderText = "Tên khách hàng";
            dgwHoaDon.Columns[3].HeaderText = "Ngày lập hoá đơn";
            dgwHoaDon.Columns[4].HeaderText = "Giờ lập hóa đơn";
            dgwHoaDon.Columns[5].HeaderText = "Đơn giá";

            dgwHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwHoaDon.Columns[0].Width = 100;
            dgwHoaDon.Columns[1].Width = 100;
            dgwHoaDon.Columns[2].Width = 200;
            dgwHoaDon.Columns[3].Width = 150;
            dgwHoaDon.Columns[4].Width = 150;
            dgwHoaDon.Columns[5].Width = 200;

            dgwHoaDon.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwHoaDon.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void hoaDon_Load(object sender, EventArgs e)
        {
            dcKTHPDataContext data = new dcKTHPDataContext();

            var listHoaDon = from hd in data.HoaDons
                             join kh in data.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                             select new
                             {
                                 hd.MaHoaDon,
                                 hd.MaKhachHang,
                                 kh.TenKhachHang,
                                 hd.NgayHoaDon,
                                 hd.GioHoaDon,
                                 hd.DonGia,
                             };
            
            dgwHoaDon.DataSource = listHoaDon;
            ConfigureSP();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            if (cbTimKiemTheo.SelectedIndex == 1)
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var query = from hd in data.HoaDons
                            join kh in data.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                            where Convert.ToBoolean(hd.MaHoaDon.IndexOf(txtTimKiem.Text))
                            select new
                            {
                                hd.MaHoaDon,
                                hd.MaKhachHang,
                                kh.TenKhachHang,
                                hd.NgayHoaDon,
                                hd.GioHoaDon,
                                hd.DonGia,
                            };
                dgwHoaDon.DataSource = query;
                dgwHoaDon.Refresh();
                ConfigureSP();
            }
            else if (cbTimKiemTheo.SelectedIndex == 2)
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var query = from hd in data.HoaDons
                            join kh in data.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                            where Convert.ToBoolean(kh.TenKhachHang.IndexOf(txtTimKiem.Text))
                            select new
                            {
                                hd.MaHoaDon,
                                hd.MaKhachHang,
                                kh.TenKhachHang,
                                hd.NgayHoaDon,
                                hd.GioHoaDon,
                                hd.DonGia,
                            };

                dgwHoaDon.DataSource = query;
                dgwHoaDon.Refresh();
                ConfigureSP();
            }
            else if (cbTimKiemTheo.SelectedIndex == 3)
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var query = from hd in data.HoaDons
                            join kh in data.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                            where Convert.ToBoolean(hd.NgayHoaDon.IndexOf(txtTimKiem.Text))
                            select new
                            {
                                hd.MaHoaDon,
                                hd.MaKhachHang,
                                kh.TenKhachHang,
                                hd.NgayHoaDon,
                                hd.GioHoaDon,
                                hd.DonGia,
                            };
                dgwHoaDon.DataSource = query;
                dgwHoaDon.Refresh();
                ConfigureSP();
            }
            else if ((cbTimKiemTheo.SelectedIndex == 0 && txtTimKiem.Text == "") || (cbTimKiemTheo.Text == "" && txtTimKiem.Text == ""))
            {
                if (cbBoLoc.SelectedIndex == 1)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = from hd in data.HoaDons
                                   join kh in data.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                                   where hd.DonGia.Equals(data.HoaDons.Max(t => t.DonGia))
                                   select new
                                   {
                                       hd.MaHoaDon,
                                       hd.MaKhachHang,
                                       kh.TenKhachHang,
                                       hd.NgayHoaDon,
                                       hd.GioHoaDon,
                                       hd.DonGia,
                                   };

                    dgwHoaDon.DataSource = query;
                    dgwHoaDon.Refresh();
                    ConfigureSP();
                }

                else if (cbBoLoc.SelectedIndex == 2)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = from hd in data.HoaDons
                                 join kh in data.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                                 where hd.DonGia.Equals(data.HoaDons.Min(t => t.DonGia))
                                 select new
                                 {
                                     hd.MaHoaDon,
                                     hd.MaKhachHang,
                                     kh.TenKhachHang,
                                     hd.NgayHoaDon,
                                     hd.GioHoaDon,
                                     hd.DonGia,
                                 };

                    dgwHoaDon.DataSource = query;
                    dgwHoaDon.Refresh();
                    ConfigureSP();
                }
                else if (cbBoLoc.SelectedIndex == 3)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    // Neu tach ten ra thi cuc lam 
                    var query = from hd in data.HoaDons
                                join kh in data.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                                orderby hd.MaKhachHang ascending
                                select new
                                {
                                    hd.MaHoaDon,
                                    hd.MaKhachHang,
                                    kh.TenKhachHang,
                                    hd.NgayHoaDon,
                                    hd.GioHoaDon,
                                    hd.DonGia,
                                };

                    dgwHoaDon.DataSource = query;
                    dgwHoaDon.Refresh();
                    ConfigureSP();
                }
                else if (cbBoLoc.SelectedIndex == 4)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = from hd in data.HoaDons
                                join kh in data.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                                orderby hd.DonGia ascending
                                select new
                                {
                                    hd.MaHoaDon,
                                    hd.MaKhachHang,
                                    kh.TenKhachHang,
                                    hd.NgayHoaDon,
                                    hd.GioHoaDon,
                                    hd.DonGia,
                                };

                    dgwHoaDon.DataSource = query;
                    dgwHoaDon.Refresh();
                    ConfigureSP();
                }
                else if (cbBoLoc.SelectedIndex == 5)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = from hd in data.HoaDons
                                join kh in data.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                                orderby hd.DonGia descending
                                select new
                                {
                                    hd.MaHoaDon,
                                    hd.MaKhachHang,
                                    kh.TenKhachHang,
                                    hd.NgayHoaDon,
                                    hd.GioHoaDon,
                                    hd.DonGia,
                                };

                    dgwHoaDon.DataSource = query;
                    dgwHoaDon.Refresh();
                    ConfigureSP();
                }
            }

            if ((cbTimKiemTheo.Text == "" && cbBoLoc.Text == "") ||
                (cbTimKiemTheo.Text == "(Lựa chọn)" && cbBoLoc.Text == "") ||
                (cbBoLoc.Text == "(Lựa chọn)" && cbTimKiemTheo.Text == "") ||
                (cbTimKiemTheo.Text == "(Lựa chọn)" && cbBoLoc.Text == "(Lựa chọn)"))
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var listHoaDon = from hd in data.HoaDons
                            join kh in data.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                            select new
                            {
                                hd.MaHoaDon,
                                hd.MaKhachHang,
                                kh.TenKhachHang,
                                hd.NgayHoaDon,
                                hd.GioHoaDon,
                                hd.DonGia,
                            };

                dgwHoaDon.DataSource = listHoaDon;
                ConfigureSP();
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDonThemMoi frmHoaDonThemMoi = new frmHoaDonThemMoi();
            frmHoaDonThemMoi.ShowDialog();

            dcKTHPDataContext data = new dcKTHPDataContext();

            var listHoaDon = from hoadon in data.HoaDons
                             join khachhang in data.KhachHangs on hoadon.MaKhachHang equals khachhang.MaKhachHang
                             select new { hoadon.MaHoaDon, hoadon.MaKhachHang, khachhang.TenKhachHang, hoadon.NgayHoaDon, hoadon.GioHoaDon, hoadon.DonGia};

            dgwHoaDon.DataSource = listHoaDon;
            ConfigureSP();
        }

        private void chiTietHoaĐonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwHoaDon.CurrentCell.RowIndex;

            maHoaDon = dgwHoaDon.Rows[rowIndex].Cells[0].Value.ToString().Trim();

            hoaDonChiTiet hoaDonChiTiet = new hoaDonChiTiet(maHoaDon);
            hoaDonChiTiet.ShowDialog();
        }

        private void chinhSuaThongTinHoaĐonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwHoaDon.CurrentCell.RowIndex;

            maHoaDon = dgwHoaDon.Rows[rowIndex].Cells[0].Value.ToString().Trim();
            maKhachHang = dgwHoaDon.Rows[rowIndex].Cells[1].Value.ToString().Trim();
            ngayHoaDon = dgwHoaDon.Rows[rowIndex].Cells[3].Value.ToString().Trim();
            gioHoaDon = dgwHoaDon.Rows[rowIndex].Cells[4].Value.ToString().Trim();
            donGia = int.Parse(dgwHoaDon.Rows[rowIndex].Cells[5].Value.ToString().Trim());

            hoaDonCapNhat frmHoaDonCapNhat = new hoaDonCapNhat(maHoaDon, maKhachHang, ngayHoaDon, gioHoaDon, donGia);
            frmHoaDonCapNhat.ShowDialog();

            dcKTHPDataContext data = new dcKTHPDataContext();

            var listHoaDon = from hoadon in data.HoaDons
                             join khachhang in data.KhachHangs on hoadon.MaKhachHang equals khachhang.MaKhachHang
                             select new { hoadon.MaHoaDon, khachhang.MaKhachHang, khachhang.TenKhachHang, hoadon.NgayHoaDon, hoadon.GioHoaDon, hoadon.DonGia };

            dgwHoaDon.DataSource = listHoaDon;
            ConfigureSP();
        }

        private void xoaThongTinHoaĐonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwHoaDon.CurrentCell.RowIndex;

            maHoaDon = dgwHoaDon.Rows[rowIndex].Cells[0].Value.ToString().Trim();

            var res = MessageBox.Show("Bạn có chắc chắn muốn xoá thông tin hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                sp = new DTOHoaDon(maHoaDon, "", "", "", 0);
                sp2 = new DTOChiTietHoaDon(maHoaDon, "", "", 0);
                if (bLLHoaDon.DeleteChiTietHoaDonAll(sp2) && bLLHoaDon.DeleteHoaDon(sp))
                {
                    var res1 = MessageBox.Show("Xóa thông tin hóa đơn thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var listHoaDon = from hoadon in data.HoaDons
                                     join khachhang in data.KhachHangs on hoadon.MaKhachHang equals khachhang.MaKhachHang
                                     select new { hoadon.MaHoaDon, khachhang.MaKhachHang, khachhang.TenKhachHang, hoadon.NgayHoaDon, hoadon.GioHoaDon, hoadon.DonGia };

                    dgwHoaDon.DataSource = listHoaDon;
                    ConfigureSP();
                }
                else
                {
                    var res3 = MessageBox.Show("Xóa thông tin hóa đơn thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }
            }
        }
    }
}
