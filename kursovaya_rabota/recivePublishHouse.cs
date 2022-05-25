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
    public partial class recivePublishHouse : Form
    {
        public recivePublishHouse()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            sqlCommand1.Parameters["@title"].Value = textBox_title.Text;
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            result = (string)sqlCommand1.Parameters["@RETURN_VALUE"].Value;
            textBox_result.Text = result[0].ToString();
        }
    }
}
