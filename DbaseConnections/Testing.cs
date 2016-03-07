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

namespace DbaseConnections
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDbase dbase = new MySqlDbase("root", "", "localhost", "blog");

            label1.Text = dbase.connect();
            
        }
    }
}
