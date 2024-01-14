using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmStatistic : Form
    {
        private DataTable listGRN;
        private DataTable listOrder;
        public frmStatistic()
        {
            InitializeComponent();

            this.dtpkFrom.Value = DateTime.Parse(String.Format(
                "{0}/{1}/{2}",
                1,
                DateTime.Now.Month,
                DateTime.Now.Year
                ));
            this.dtpkTo.Value = DateTime.Parse(String.Format(
                "{0}/{1}/{2}",
                DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month),
                DateTime.Now.Month,
                DateTime.Now.Year
                ));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            int quantity = 0;

            dtgvStatistic.Columns[2].HeaderCell.Value = "SL nhập";

            listGRN = StatisticGRN(dtpkFrom.Value.ToString("yyyy/MM/dd"),
                dtpkTo.Value.ToString("yyyy/MM/dd"));

            dtgvStatistic.Rows.Clear();
            foreach (DataRow s in listGRN.Rows)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvStatistic.Rows[0].Clone(); ;
                row.Cells[0].Value = s["MaSanPham"];
                row.Cells[1].Value = s["TenSanPham"];
                row.Cells[2].Value = s["SoLuongNhap"];
                row.Cells[3].Value = s["GiaNhap"];
                dtgvStatistic.Rows.Add(row);

                total += (double)s["GiaNhap"] * (int)s["SoLuongNhap"];
                quantity += (int)s["SoLuongNhap"];
            }

            txtQuantity.Text = quantity.ToString();
            txtTotal.Text = total.ToString("0,###") + " VNĐ";

            dtgvStatistic.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = 0;
            int quantity = 0;

            dtgvStatistic.Columns[2].HeaderCell.Value = "SL bán";

            listOrder = StatisticOrder(
                dtpkFrom.Value.ToString("yyyy/MM/dd"),
                dtpkTo.Value.ToString("yyyy/MM/dd"));

            dtgvStatistic.Rows.Clear();

            foreach (DataRow s in listOrder.Rows)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvStatistic.Rows[0].Clone(); ;
                row.Cells[0].Value = s["MaSanPham"];
                row.Cells[1].Value = s["TenSanPham"];
                row.Cells[2].Value = s["SoLuongBan"];
                row.Cells[3].Value = s["GiaBan"];
                dtgvStatistic.Rows.Add(row);

                total += (double)s["GiaBan"] * (int)s["SoLuongBan"];
                quantity += (int)s["SoLuongBan"];
            }

            txtQuantity.Text = quantity.ToString();
            txtTotal.Text = total.ToString("0,###") + " VNĐ";

            dtgvStatistic.ClearSelection();
        }

        private DataTable StatisticOrder(string from, string to)
        {
            string query = "exec proc_Statistic_Order @from , @to";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {from, to});
            return data;
        }

        private DataTable StatisticGRN(string from, string to)
        {
            string query = "exec proc_Statistic_GRN @from , @to";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });
            return data;
        }
    }
}
