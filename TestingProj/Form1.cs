using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbaseConnections;


namespace TestingProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDbase dbase = new MySqlDbase("root", "", "localhost", "blog");

            label1.Text = dbase.connect();

            String sql = "INSERT INTO article(title,author) Values('This is a sample Title','Alex Nana')";

            String status=dbase.insertData(sql);
            MessageBox.Show(status);
            
        }
    }
}
