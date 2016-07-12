using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 酒水寄存.Models;

namespace 酒水寄存
{
   public class AppUtil
    {
        public static DbUser DbUser { get; set; }

        public static void SetCommonInitForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public static void SetDataGridView(DataGridView gridView)
        {
            gridView.AutoGenerateColumns = false;
            gridView.MultiSelect = false;
            gridView.RowHeadersVisible = false;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
