using A_DAL.A_DAL.Models;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI
{
    public partial class frmtaisan : Form
    {
        private TaiSanServices taiSanServices = new TaiSanServices();
        public frmtaisan()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            Type type = typeof(TaiSan);
            int sl = type.GetProperties().Length;
            dataGridView1.ColumnCount = sl;
            dataGridView1.Columns[0].Name = "Ten";
            dataGridView1.Columns[1].Name = "Giá";
            dataGridView1.Columns[2].Name = "Tình trạng";
            dataGridView1.Columns[3].Name = "Trạng thái";
            dataGridView1.Rows.Clear();
            foreach (var x in taiSanServices.GetData())
            {
                dataGridView1.Rows.Add(x.TenTaiSan, x.GiaMua, x.TinhTrang,x.TrangThaiSd);
            }
        }
    }
}
