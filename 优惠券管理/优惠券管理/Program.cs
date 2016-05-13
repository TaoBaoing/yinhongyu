using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 优惠券管理
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (DateTime.Now > new DateTime(2015, 5, 20))
            {
                MessageBox.Show("试用过期");
                Application.Exit();
                return;
            }
            Application.Run(new MainForm());
        }
    }
}
