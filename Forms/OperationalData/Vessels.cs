using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.OperationalData
{
    public partial class Vessels : Form
    {
        public Vessels()
        {
            InitializeComponent();
        }

        private void Vessels_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoDataSet.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.demoDataSet.Рейс);

        }
    }
}
