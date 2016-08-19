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
    public partial class LotteryForm : BaseForm
    {
        public LotteryForm()
        {
            base.Title = "抽奖";
            InitializeComponent();
        }

        private void LotteryForm_Load(object sender, EventArgs e)
        {
            lbResult.Text = "";
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            lbResult.Text = "正在抽奖";
            var firstPrize = txtFirstPrize.Text;
            var secondPrize = txtSecondPrize.Text;
            var thirdPrize = txtThirdPrize.Text;
            var noPrize = txtNoPrize.Text;

            if (string.IsNullOrEmpty(firstPrize) || string.IsNullOrEmpty(secondPrize) || string.IsNullOrEmpty(thirdPrize) || string.IsNullOrEmpty(noPrize))
            {
                MessageBox.Show("请填写完整比率");
                return;
            }

            var firstPrizeInt = Convert.ToInt16(firstPrize);
            var secondPrizeInt = Convert.ToInt16(secondPrize);
            var thirdPrizeInt = Convert.ToInt16(thirdPrize);
            var noPrizeInt = Convert.ToInt16(noPrize);

            List<string> seed = new List<string>();

            for (int i = 0; i < firstPrizeInt; i++)
            {
                seed.Add("1");
            }

            for (int i = 0; i < secondPrizeInt; i++)
            {
                seed.Add("2");
            }

            for (int i = 0; i < thirdPrizeInt; i++)
            {
                seed.Add("3");
            }

            for (int i = 0; i < noPrizeInt; i++)
            {
                seed.Add("未中奖");
            }

            string result = GetRandom(seed.ToArray());

            lbResult.Text = result;
        }

        public string GetRandom(string[] arr)
        {
            Random ran = new Random();
            int n = ran.Next(arr.Length - 1);
            return arr[n];
        }
    }
}
