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
    public partial class TownForm : BaseForm
    {
        public int CountyId { set; get; }

        public TownForm(int countyId)
        {
            base.Title = "镇";
            this.CountyId = countyId;
            InitializeComponent();
        }


        private void TownForm_Load(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                List<Town> towns = db.Towns.Where(x => x.CountyId == CountyId).ToList();
                dataGridView1.DataSource = towns;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "名称";
                dataGridView1.Columns[2].HeaderText = "编号";
                dataGridView1.Columns[3].HeaderText = "区域编号";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            VillageForm villageForm = new VillageForm(Convert.ToInt32(value));
            villageForm.Show();
        }
    }
}
