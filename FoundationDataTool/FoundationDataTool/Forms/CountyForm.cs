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
    public partial class CountyForm : Form
    {

        public int CityId { set; get; }

        public CountyForm(int cityId)
        {
            this.CityId = cityId;
            InitializeComponent();
        }

        private void CountyForm_Load(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                List<County> counties = db.Counties.Where(x => x.CityId == CityId).ToList();
                dataGridView1.DataSource = counties;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "区域名称";
                dataGridView1.Columns[2].HeaderText = "编号";
                dataGridView1.Columns[3].HeaderText = "城市编号";
            }
        }
    }
}
