using FoundationDataTool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoundationDataTool.Forms
{
    public partial class CityForm : Form
    {
        public int ProvinceId { set; get; }

        public CityForm(int provinceId)
        {
            this.ProvinceId = provinceId;
            InitializeComponent();
        }

        private void City_Load(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                List<City> cities = db.Cities.Where(x=>x.ProvinceId == ProvinceId).ToList();
                dataGridView1.DataSource = cities;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "城市";
                dataGridView1.Columns[2].HeaderText = "编号";
                dataGridView1.Columns[3].HeaderText = "省份";
            }
        }


        /// <summary>
        ///  点击行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CountyForm countyForm = new CountyForm(Convert.ToInt32(value));
            countyForm.Show();
        }
    }
}
