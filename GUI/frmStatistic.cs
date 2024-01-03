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

        private DataTable listGR;
        private DataTable listOrder;


        private void button1_Click(object sender, EventArgs e)
        {
            dtgvStatistic.Columns[0].HeaderCell.Value = "Mã phiếu nhập";
            dtgvStatistic.Columns[2].HeaderCell.Value = "Đơn vị nhập";
            dtgvStatistic.Columns[3].HeaderCell.Value = "Ngày nhập";

            /*listGRN = StatisticGRN(dtpkFrom.Value.ToString("yyyy/MM/dd"),
                dtpkTo.Value.ToString("yyyy/MM/dd"));

            dtgvStatistic.Rows.Clear();
            foreach (GRN s in listGRN)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvStatistic.Rows[0].Clone(); ;
                row.Cells[0].Value = s.GRNID;
                row.Cells[2].Value = s.Unit;
                row.Cells[3].Value = s.Date.ToString("dd/MM/yyyy");
                row.Cells[4].Value = s.Total.ToString("#,###");
                row.Cells[1].Value = StaffDAL.Instance.GetStaff(s.StaffID).StaffName;
                dtgvStatistic.Rows.Add(row);
            }

            txtQuantity.Text = listGRN.Count.ToString();
            txtTotal.Text = SumGRNTotal(listGRN).ToString("#,###");
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgvStatistic.Columns[0].HeaderCell.Value = "Mã sản phẩm";
            dtgvStatistic.Columns[2].HeaderCell.Value = "Số lượng bán";
            dtgvStatistic.Columns[3].HeaderCell.Value = "Giá bán";

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

               // row.Cells[1].Value = StaffDAL.Instance.GetStaff(s.StaffID).StaffName;
                
                dtgvStatistic.Rows.Add(row);
            }

            //.Text = listOrder.Count.ToString();
            //txtTotal.Text = SumOrderTotal(listOrder).ToString("#,###");
        }

        private DataTable StatisticOrder(string from, string to)
        {
            string query = "exec proc_Statistic_Order @from , @to";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {from, to});
            return data;
        }

        private List<GRN> StatisticGRN(string from, string to)
        {
            if (GRNDAL.Instance.SearchGRN(from, to).Count > 0)
                return GRNDAL.Instance.SearchGRN(from, to);
            else
                return [];
        }

        private Double SumOrderTotal(List<Order> list)
        {
            Double total = 0;
            foreach (Order o in list)
            {
                total += o.Total; ; 
            }
            return total;
        }
        private Double SumGRNTotal(List<GRN> list)
        {
            Double total = 0;
            foreach (GRN o in list)
            {
                total += o.Total; ;
            }
            return total;
        }
    }
}
