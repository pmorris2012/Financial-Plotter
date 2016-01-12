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
    public partial class graph : Form
    {
        public DataSet set;
        public Bitmap bmp = new Bitmap(1, 1);
        public Graphics g;
        public int rangex, rangey;
        public float ratioX, ratioY;
        public int minX, maxX;
        public double minY, maxY;
        public DataSet.DrawingModes mode;
        public List<Label> yAxisLabels = null;

        public graph(Form parent, string filename)
        {
            InitializeComponent();
            this.MdiParent = parent;
            this.Text = Path.GetFileNameWithoutExtension(filename);
            set = new DataSet(filename);

            startYear.Minimum = endYear.Minimum = set.smallestDate.Year;
            startYear.Maximum = endYear.Maximum = set.largestDate.Year;
            startYear.Value = set.smallestDate.Year;
            endYear.Value = set.largestDate.Year;
            startMonth.SelectedIndex = set.smallestDate.Month - 1;
            endMonth.SelectedIndex = set.largestDate.Month - 1;
            MonthYear_SelectedIndexChanged(null, null);
            startDay.Value = set.smallestDate.Day;
            endDay.Value = set.largestDate.Day;

            startYear.ValueChanged += LoadGraph;
            endYear.ValueChanged += LoadGraph;
            startMonth.SelectedIndexChanged += LoadGraph;
            endMonth.SelectedIndexChanged += LoadGraph;
            startDay.ValueChanged += LoadGraph;
            endDay.ValueChanged += LoadGraph;

            avg1Num.Maximum = avg2Num.Maximum = avg3Num.Maximum = set.largestDay - set.smallestDay;

            mode = DataSet.DrawingModes.Close;

            LoadGraph(null, null);
        }

        private void graph_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 10);
        }

        private void MonthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                startDay.Maximum = DateTime.DaysInMonth((int)startYear.Value, startMonth.SelectedIndex + 1);
                endDay.Maximum = DateTime.DaysInMonth((int)endYear.Value, endMonth.SelectedIndex + 1);
            }
            catch { }
        }

        private void LoadGraph(object sender, EventArgs e)
        {
            if (yAxisLabels != null)
            {
                foreach (Label l in yAxisLabels)
                {
                    this.Controls.Remove(l);
                }
            }

            bmp = new Bitmap(450, 405);
            g = Graphics.FromImage(bmp);

            minX = DataPoint.DateTimeToInt(new DateTime((int)startYear.Value, startMonth.SelectedIndex + 1, (int)startDay.Value));
            maxX = DataPoint.DateTimeToInt(new DateTime((int)endYear.Value, endMonth.SelectedIndex + 1, (int)endDay.Value));
            minY = set.GetSmallestInRange(minX, maxX);
            maxY = set.GetLargestInRange(minX, maxX);

            g.TranslateTransform(45, bmp.Height - 1);
            g.ScaleTransform(1, -1);

            yAxisLabels = set.PrintValuesInRange(g, minX, maxX, mode);
            if (yAxisLabels != null)
            {
                this.Controls.AddRange(yAxisLabels.ToArray());
            }

            if(avg1.Checked)
            {
                set.PrintMovingAvg(g, minX, maxX, (int)avg1Num.Value, Color.Green);
            }
            if (avg2.Checked)
            {
                set.PrintMovingAvg(g, minX, maxX, (int)avg2Num.Value, Color.Orange);
            }
            if (avg3.Checked)
            {
                set.PrintMovingAvg(g, minX, maxX, (int)avg3Num.Value, Color.Purple);
            }

            Refresh();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            mode = DataSet.DrawingModes.Close;
            button_Close.Enabled = false;
            button_CandleSticks.Enabled = button_HiLoOpenClose.Enabled = true;
            LoadGraph(sender, e);
        }

        private void button_HiLoOpenClose_Click(object sender, EventArgs e)
        {
            mode = DataSet.DrawingModes.HiLoOpenClose;
            button_HiLoOpenClose.Enabled = false;
            button_CandleSticks.Enabled = button_Close.Enabled = true;
            LoadGraph(sender, e);
        }

        private void button_CandleSticks_Click(object sender, EventArgs e)
        {
            mode = DataSet.DrawingModes.CandleSticks;
            button_CandleSticks.Enabled = false;
            button_Close.Enabled = button_HiLoOpenClose.Enabled = true;
            LoadGraph(sender, e);
        }

        private void avg3Num_ValueChanged(object sender, EventArgs e)
        {
            if(avg3.Checked)
            {
                LoadGraph(sender, e);
            }
        }

        private void avg1Num_ValueChanged(object sender, EventArgs e)
        {
            if (avg1.Checked)
            {
                LoadGraph(sender, e);
            }
        }

        private void avg2Num_ValueChanged(object sender, EventArgs e)
        {
            if (avg2.Checked)
            {
                LoadGraph(sender, e);
            }
        }
    }
}
