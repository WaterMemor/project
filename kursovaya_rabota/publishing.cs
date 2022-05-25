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
    public partial class publishing : Form
    {
        public publishing()
        {
            InitializeComponent();
        }

        private void publishing_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.newspapers". При необходимости она может быть перемещена или удалена.
            this.newspapersTableAdapter.Fill(this.pOST_OFFICEDataSet.newspapers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pOST_OFFICEDataSet.View_2". При необходимости она может быть перемещена или удалена.
            this.view_2TableAdapter.Fill(this.pOST_OFFICEDataSet.View_2);
            btn_title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; //запрет на ввод в combobox

        }

        private void filter_Click(object sender, EventArgs e)
        {
            string title = $"title = '{btn_title.Text}'";
            string address = $"address_house = '{btn_address.Text}'";
            string printed_newspapers = $"printed_newspapers = '{printed_news.Text}'";
            code_news.Visible = true;
            string code_newspaper = $"code_newspaper = '{code_news.Text}'";
            code_news.Visible = false;
            code_pub.Visible = true;
            string code_publish_house = $"code_publish_house = '{code_pub.Text}'";
            code_pub.Visible = false;

            string commandsql = $"UPDATE publish_houses SET "
                + address + " WHERE " + code_publish_house; //изменить адрес типографии
            string commandsql2 = $"UPDATE newspapers SET " + title +
                "WHERE " + code_newspaper; //изменить название газеты
            

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
