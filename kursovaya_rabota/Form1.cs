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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.post_office". При необходимости она может быть перемещена или удалена.
            this.post_officeTableAdapter.Fill(this.pOST_OFFICEDataSet.post_office);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.supply_newspapers". При необходимости она может быть перемещена или удалена.
            this.supply_newspapersTableAdapter.Fill(this.pOST_OFFICEDataSet.supply_newspapers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.publishing". При необходимости она может быть перемещена или удалена.
            this.publishingTableAdapter.Fill(this.pOST_OFFICEDataSet.publishing);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.publish_houses". При необходимости она может быть перемещена или удалена.
            this.publish_housesTableAdapter.Fill(this.pOST_OFFICEDataSet.publish_houses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.newspapers". При необходимости она может быть перемещена или удалена.
            this.newspapersTableAdapter.Fill(this.pOST_OFFICEDataSet.newspapers);

        }

        private void газетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newspapers myNewspapers = new newspapers();
            myNewspapers.Show();
        }

        private void типографииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            publish_house myPublishHouse = new publish_house();
            myPublishHouse.Show();
        }

        private void почтовыеОтделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            post_office myPostOffice = new post_office();
            myPostOffice.Show();   
        }

        private void изданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            publishing publishing = new publishing();
            publishing.Show();
        }

        private void поступленияГазетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supply_newspaper supply_Newspaper = new supply_newspaper();
            supply_Newspaper.Show();
        }

        private void получитьТипографииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recivePublishHouse myRecive = new recivePublishHouse();
            myRecive.Show();  
        }

        private void получитьГазетыВМеньшемКоличествеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reciveNewspaper reciveNewspaper = new reciveNewspaper();
            reciveNewspaper.Show();
        }

        private void получитьПочтовоеОтделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recivepostOffice recivepost = new recivepostOffice();
            recivepost.Show();
        }
    }
}
