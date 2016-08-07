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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void Area_Load(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                //List<City> cities = db.Cities.ToList();
                //dataGridView1.DataSource = cities;
                //dataGridView1.Columns[0].HeaderText = "Id";
                //dataGridView1.Columns[1].HeaderText = "城市";
                //dataGridView1.Columns[2].HeaderText = "编号";
                //dataGridView1.Columns[3].HeaderText = "省份";
                List<Province> provinces = new List<Province>();
                provinces = db.Provinces.ToList();
                dataGridView1.DataSource = provinces;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "省份";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 当行点击内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Test");
        }

        /// <summary>
        /// 当行点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CityForm cityForm = new CityForm(Convert.ToInt32(value));
            cityForm.Show();
        }



    }
}
