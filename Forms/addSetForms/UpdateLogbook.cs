using Grishkova_vkr_PortApp.Controllers.OperationalData;
using Grishkova_vkr_PortApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    public partial class UpdateLogbook : Form
    {
        private Staff cap;
        private Ship ship;
        private long id;
        private demoDataSetTableAdapters.Вахтенный_журналTableAdapter v;
        private demoDataSet.Вахтенный_журналDataTable t;
        private List<Staff> capList;
        private List<Ship> shipList;

        public UpdateLogbook(Staff cap, Ship ship, 
            ComboBox.ObjectCollection caps, ComboBox.ObjectCollection ships,
            demoDataSetTableAdapters.Вахтенный_журналTableAdapter v, demoDataSet.Вахтенный_журналDataTable t, long id, List<Staff> capList, List<Ship> shipList)
        {
            InitializeComponent();
            this.v = v;
            this.t = t;
            this.id = id;
            this.cap = cap;
            this.ship = ship;
            this.capList = capList;
            this.shipList = shipList;

            foreach(Object o in caps)
                nameComboBox.Items.Add(o.ToString());

            nameComboBox.Items.Add(cap.getName());
            nameComboBox.SelectedItem = cap.getName();

            foreach (Object o in ships)
                vesselComboBox.Items.Add(o.ToString());

            vesselComboBox.Items.Add(ship.getName());
            vesselComboBox.SelectedItem = ship.getName();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            WorkingDayController.update(v, t, shipList.Find(x=>x.getName().Equals(vesselComboBox.SelectedItem.ToString())).getNum(),
                capList.Find(x=>x.getName().Equals(nameComboBox.SelectedItem.ToString())).getId(),id);
            this.Close();
        }
    }
}
