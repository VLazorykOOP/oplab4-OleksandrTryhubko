using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Form5 : Form
    {
        Form2 f;
        public Form5(Form2 f2)
        {
            InitializeComponent();
            f = f2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = f.GetMySqlConnection();
            string sql = "select * from bread_products";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
