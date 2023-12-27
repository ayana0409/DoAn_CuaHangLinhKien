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

        private List<GRN> listGRN = [];
        private List<Order> listOrder = [];


        private void button1_Click(object sender, EventArgs e)
        {
            dtgvStatistic.Columns[0].HeaderCell.Value = "Mã phiếu nhập";
            dtgvStatistic.Columns[2].HeaderCell.Value = "Đơn vị nhập";
            dtgvStatistic.Columns[3].HeaderCell.Value = "Ngày nhập";

            listGRN = StatisticGRN(dtpkFrom.Value.ToString("yyyy/MM/dd"),
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgvStatistic.Columns[0].HeaderCell.Value = "Mã đơn hàng";
            dtgvStatistic.Columns[2].HeaderCell.Value = "SDT khách hàng";
            dtgvStatistic.Columns[3].HeaderCell.Value = "Ngày thanh toán";

            listOrder = StatisticOrder(
                dtpkFrom.Value.ToString("yyyy/MM/dd"),
                dtpkTo.Value.ToString("yyyy/MM/dd"));

            dtgvStatistic.Rows.Clear();
            foreach (Order s in listOrder)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvStatistic.Rows[0].Clone(); ;
                row.Cells[0].Value = s.OrderID;
                row.Cells[2].Value = s.CustomerNumberPhone;
                row.Cells[3].Value = s.Date.ToString("dd/MM/yyyy");
                row.Cells[4].Value = s.Total.ToString("#,###");

                row.Cells[1].Value = StaffDAL.Instance.GetStaff(s.StaffID).StaffName;
                
                dtgvStatistic.Rows.Add(row);
            }

            txtQuantity.Text = listOrder.Count.ToString();
            txtTotal.Text = SumOrderTotal(listOrder).ToString("#,###");
        }

        private List<Order> StatisticOrder(string from, string to)
        {
            if (OrderDAL.Instance.SearchOrder(from, to).Count > 0)
                return OrderDAL.Instance.SearchOrder(from, to);
            else
                return [];
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
