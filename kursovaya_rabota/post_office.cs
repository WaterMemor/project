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
    public partial class post_office : Form
    {
        public post_office()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void post_office_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.post_office". При необходимости она может быть перемещена или удалена.
            this.post_officeTableAdapter.Fill(this.pOST_OFFICEDataSet.post_office);

        }

        private void btn_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void filter_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postofficeBindingSource.EndEdit();
            this.post_officeTableAdapter.Update(this.pOST_OFFICEDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            postofficeBindingSource.Filter = "address_post_office = '" + dataGridView1[1, bb].Value + "'";
        }
    }
}
