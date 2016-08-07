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
    public partial class VillageForm : Form
    {
        public int TownId { set; get; }

        public VillageForm(int townId)
        {
            this.TownId = townId;
            InitializeComponent();
        }

        private void VillageForm_Load(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                List<Village> villages = db.Villages.Where(x => x.TownId == TownId).ToList();
                dataGridView1.DataSource = villages;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "名称";
                dataGridView1.Columns[2].HeaderText = "编号";
                dataGridView1.Columns[3].HeaderText = "类型";
                dataGridView1.Columns[4].HeaderText = "镇编号";
            }
        }
    }
}
