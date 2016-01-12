using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GAD_HW2
{
    public partial class open : Form
    {
        public open(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Open File";
            d.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            d.RestoreDirectory = true;
            d.Filter = "CSV Files (*.csv)|*.csv";
            if(d.ShowDialog() == DialogResult.OK && Path.GetExtension(d.FileName) == ".csv")
            {
                try
                {
                    graph g = new graph(this.MdiParent, d.FileName);
                    g.Show();
                }
                catch { }
            }
        }
    }
}
