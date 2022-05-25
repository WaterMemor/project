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
    public partial class newspapers : Form
    {
        public newspapers()
        {
            InitializeComponent();
        }

        private void newspapers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.newspapers". При необходимости она может быть перемещена или удалена.
            this.newspapersTableAdapter.Fill(this.pOST_OFFICEDataSet.newspapers);

        }

        private void filter_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.newspapersBindingSource.EndEdit();
            this.newspapersTableAdapter.Update(this.pOST_OFFICEDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            newspapersBindingSource.Filter = "title = '"+dataGridView1[1,bb].Value+"'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            newspapersBindingSource.Filter = "price = " + dataGridView1[2, bb].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            newspapersBindingSource.Filter = "full_name_editor = '" + dataGridView1[3, bb].Value+"'";
        }
    }
}
