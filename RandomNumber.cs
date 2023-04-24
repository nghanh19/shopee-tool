using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopeeTool
{
    public partial class RandomNumber : DevExpress.XtraEditors.XtraForm
    {
        public Action<int> FormSubmit = (number) => { };
        public RandomNumber()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotal.Text))
                return;
            FormSubmit(Convert.ToInt32(txtTotal.Text));
            this.Close();
        }
    }
}
