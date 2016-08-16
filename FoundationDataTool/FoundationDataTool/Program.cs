using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoundationDataTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Init()
        {
            EntityFramework.Container container = new EntityFramework.Container();
            EntityFramework.Locator.RegisterDefaults(container);
            container.Register<EntityFramework.Batch.IBatchRunner>(() => new EntityFramework.Batch.MySqlBatchRunner());
            EntityFramework.Locator.SetContainer(container);
        }
    }
}
