using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
namespace GUI
{
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {
            DataProvider dataProvider = new();

            string query = "select * from ThongTinPhieuNhap";
            int result = dataProvider.ExecuteNonQuery(query);

            if (result == 0)
            {
                MessageBox.Show("Kết nối thất bại");
            }
            else
            {
                MessageBox.Show("Kết nối thành công");
            }
        }
    }
}
