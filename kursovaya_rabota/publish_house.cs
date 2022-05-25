using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya_rabota
{
    public partial class publish_house : Form
    {
        public publish_house()
        {
            InitializeComponent();
        }

        private void publish_house_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.publish_houses". При необходимости она может быть перемещена или удалена.
            this.publish_housesTableAdapter.Fill(this.pOST_OFFICEDataSet.publish_houses);

        }

        private void filter_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.publishhousesBindingSource.EndEdit();
            this.publish_housesTableAdapter.Update(this.pOST_OFFICEDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            publishhousesBindingSource.Filter = "address_house = '" + dataGridView1[1, bb].Value + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            publishhousesBindingSource.Filter = "status = '" + dataGridView1[2, bb].Value + "'";
        }
    }
}
