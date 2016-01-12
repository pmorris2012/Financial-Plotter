using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace GAD_HW2
{
    public class DataPoint
    {
        public int date;
        public double open;
        public double close;
        public double high;
        public double low;
        public int volume;
        public double adjClose;
        public DateTime dateTime;

        public DataPoint(String[] values)
        {
            dateTime = Convert.ToDateTime(values[0]);
            date = DateTimeToInt(dateTime);
            open = Convert.ToDouble(values[1]);
            high = Convert.ToDouble(values[2]);
            low = Convert.ToDouble(values[3]);
            close = Convert.ToDouble(values[4]);
            volume = Convert.ToInt32(values[5]);
            adjClose = Convert.ToDouble(values[6]);
        }

        //returns number of days since Jan 1, 1900
        public static int DateTimeToInt(DateTime t)
        {
            return ((t.Year - 1900) * 365) + t.DayOfYear;
        }
    }

    public class DataSet
    {
        public enum DrawingModes { Close, HiLoOpenClose, CandleSticks };

        public SortedList<int, DataPoint> set = new SortedList<int, DataPoint>();
        public int smallestDay = 10000000;
        public double smallestClose = 10000000;
        public int largestDay = -10000000;
        public double largestClose = -10000000;
        public DateTime smallestDate = new DateTime(9999,1,1);
        public DateTime largestDate = new DateTime(1,1,1);
        public int unitX = 0, unitY = 0;

        public DataSet(string file)
        {
            String[] lines = File.ReadAllLines(file);
            for(int i = 1; i < lines.Length; ++i)
            {
                DataPoint p = new DataPoint(lines[i].Split(','));
                smallestDay = Math.Min(p.date, smallestDay);
                smallestClose = Math.Min(p.close, smallestClose);
                largestDay = Math.Max(p.date, largestDay);
                largestClose = Math.Max(p.close, largestClose);
                smallestDate = smallestDate > p.dateTime ? p.dateTime : smallestDate;
                largestDate = largestDate < p.dateTime ? p.dateTime : largestDate;
                set.Add(p.date, p);
            }
        }

        private List<Label> DrawGridLines(Graphics g, int x1, int x2, int y1, int y2)
        {
            unitX = (int)Math.Pow(10, Math.Floor(Math.Log(x2 - x1, 10.0)));
            unitY = (int)Math.Pow(10, Math.Floor(Math.Log(y2 - y1, 10.0)));
            int x = 0;
            while(x < (x2 - x1))
            {
                double normalized = x * 400 / (float)(x2 - x1);
                Pen p = x % unitX == 0 ? Pens.Blue : Pens.LightBlue;
                g.DrawLine(p, (float)normalized, 0.0f, (float)normalized, 405.0f);
                x += Math.Max((int)(unitX / (float)10), 1);
            }
            int y = 0;
            List<Label> labels = new List<Label>();
            while (y < (y2 - y1))
            {
                double normalized = y * 400 / (float)(y2 - y1);
                Pen p = y % unitY == 0 ? Pens.Blue : Pens.LightBlue;
                g.DrawLine(p, 0.0f, (float)normalized, 405.0f, (float)normalized);
                if (y % unitY == 0)
                {
                    Label l = new Label();
                    l.Height = 25;
                    l.Location = new Point(1, 425 - (int)normalized - l.Height);
                    l.Text = (y + y1).ToString();
                    l.TextAlign = ContentAlignment.MiddleRight;
                    l.Width = 40;
                    labels.Add(l);
                }
                y += Math.Max((int)(unitY / (float)10), 1);
            }
            return labels;
        }

        public List<Label> PrintValuesInRange(Graphics g, int x1, int x2, DrawingModes m)
        {
            List<Label> labels;
            int i, j;
            if(!FitRangeToData(x1, x2, out i, out j))
            {
                return null;
            }

            double smallest = GetSmallestInRange(i, j);
            double range = GetLargestInRange(i, j) - smallest;
            labels = DrawGridLines(g, i, j, (int)smallest, (int)(smallest + range));

            switch(m)
            {
                case DrawingModes.Close:
                    List<PointF> points = new List<PointF>();
                    for(int idx = set.IndexOfKey(i); idx <= set.IndexOfKey(j); ++idx)
                    {
                        double x = (set.Values[idx].date - i) * 400 / (j - i);
                        double y = (set.Values[idx].close - smallest) * 400 / range;
                        points.Add(new PointF((float)x, (float)y));
                    }
                    g.DrawLines(Pens.Red, points.ToArray());
                    break;
                case DrawingModes.HiLoOpenClose:
                    double len = Math.Min(8, Math.Floor(400 / (double)(j - i)));
                    len += len < 5 && len > 0.25 ? 1 : 0;
                    for(int idx = set.IndexOfKey(i); idx <= set.IndexOfKey(j); ++idx)
                    {
                        double x = (set.Values[idx].date - i) * 400 / (j - i);
                        double hi = (set.Values[idx].high - smallest) * 400 / range;
                        double lo = (set.Values[idx].low - smallest) * 400 / range;
                        double open = (set.Values[idx].open - smallest) * 400 / range;
                        double close = (set.Values[idx].close - smallest) * 400 / range;
                        g.DrawLine(Pens.Red, (float)x, (float)lo, (float)x, (float)hi);
                        g.DrawLine(Pens.Red, (float)x, (float)open, (float)(x - len), (float)open);
                        g.DrawLine(Pens.Red, (float)x, (float)close, (float)(x + len), (float)close);
                    }
                    break;
                case DrawingModes.CandleSticks:
                    double width = Math.Min(8, Math.Ceiling(400 / (double)(j - i)));
                    width += width < 5 ? 1 : 0;
                    for (int idx = set.IndexOfKey(i); idx <= set.IndexOfKey(j); ++idx)
                    {
                        double x = (set.Values[idx].date - i) * 400 / (j - i);
                        double hi = (set.Values[idx].high - smallest) * 400 / range;
                        double lo = (set.Values[idx].low - smallest) * 400 / range;
                        double open = (set.Values[idx].open - smallest) * 400 / range;
                        double close = (set.Values[idx].close - smallest) * 400 / range;
                        Pen p = open <= close ? Pens.Red : Pens.Black;
                        g.DrawLine(p, (float)x, (float)lo, (float)x, (float)hi);
                        if(open <= close)
                        {
                            g.FillRectangle(Brushes.Red, (float)(x - (width / 2)), (float)open, (float)width, (float)(close - open));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.Black, (float)(x - (width / 2)), (float)close, (float)width, (float)(open - close));
                        }
                    }
                    break;
                default:
                    break;
            }
            return labels;
        }

        public void PrintMovingAvg(Graphics g, int x1, int x2, int n, Color c)
        {
            int i, j;
            FitRangeToData(x1, x2, out i, out j);
            double smallest = GetSmallestInRange(i, j);
            double range = GetLargestInRange(i, j) - smallest;
            List<PointF> points = new List<PointF>();
            for (int idx = set.IndexOfKey(i); idx <= set.IndexOfKey(j); ++idx)
            {
                double x = (set.Values[idx].date - i) * 400 / (j - i);
                double y = (AvgOfLastN(idx, n) - smallest) * 400 / range;
                points.Add(new PointF((float)x, (float)y));
            }
            g.DrawLines(new Pen(c, 1), points.ToArray());
        }

        private double AvgOfLastN(int index, int n)
        {
            double avg = 0;
            int counter = 0;
            while(counter < n && index >= 0)
            {
                avg += set.Values[index].close;
                ++counter;
                --index;
            }
            if (counter > 0)
            {
                avg = avg / counter;
            }
            return avg;
        }

        public bool FitRangeToData(int x1, int x2, out int i, out int j)
        {
            i = x1;
            while (!set.ContainsKey(i))
            {
                ++i;
                if (i > largestDay)
                {
                    j = x2;
                    return false;
                }
            }
            j = x2;
            while (!set.ContainsKey(j))
            {
                --j;
                if (j < smallestDay)
                {
                    return false;
                }
            }
            if (j - i < 1)
            {
                return false;
            }
            return true;
        }

        public double GetSmallestInRange(int x1, int x2)
        {
            var filter = set.Keys.ToList().FindAll(delegate(int i) { return i <= x2 && i >= x1; });
            double min = 10000000;
            foreach(int i in filter)
            {
                min = Math.Min((int)set[i].low, min);
            }
            return min;
        }

        public double GetLargestInRange(int x1, int x2)
        {
            var filter = set.Keys.ToList().FindAll(delegate(int i) { return i <= x2 && i >= x1; });
            double max = -10000000;
            foreach (int i in filter)
            {
                max = Math.Max((int)set[i].high, max);
            }
            return max;
        }
    }
}