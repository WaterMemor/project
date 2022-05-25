using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kursovaya_rabota
{
    public partial class supply_newspaper : Form
    {
        public supply_newspaper()
        {
            InitializeComponent();
        }

        private void supply_newspaper_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.pOST_OFFICEDataSet.View_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.pOST_OFFICEDataSet.View_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.supply_newspapers". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.pOST_OFFICEDataSet.View_1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            view1BindingSource.Filter = "code_publishing = '" + dataGridView1[1, bb].Value + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            view1BindingSource.Filter = "address_post_office = '" + dataGridView1[3, bb].Value + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            view1BindingSource.Filter = "supplied_newspapers =" + dataGridView1[2, bb].Value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filter_Click(object sender, EventArgs e)
        {
            string address = $"address_post_office = '{btn_address.Text}'"; //получаем адрес почтового отделения
            string code_publishing = $"code_publishing = '{btn_code.Text}'"; //получаем код издания
            string supplied_newspapers = $"supplied_newspapers = '{btn_sup.Text}'"; //получаем кол-во поставленных газет
            code_sup.Visible = true;
            string code_supply = $"code_supply = '{code_sup.Text}'"; //получаем код поставки
            code_sup.Visible = false;
            btn_code_post_office.Visible = true;
            string code_post_office = $"code_post_office = '{btn_code_post_office.Text}'"; //получаем код п. отделения
            btn_code_post_office.Visible = false;
            string commandsql = $"UPDATE post_office SET "
                + address + " WHERE "+code_post_office; //формируем первый запрос для изменения адреса п. отделения
            string commandsql2 = $"UPDATE supply_newspapers SET " + code_publishing + " " + supplied_newspapers +
                "WHERE "+code_supply;

            string connString = @"Data Source=DESKTOP-P6AQT1R\SQLEXPRESS;Initial Catalog=POST_OFFICE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlConnection = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = commandsql;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = sqlConnection;
            cmd2.CommandText = commandsql2;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();


        }
    }
}
