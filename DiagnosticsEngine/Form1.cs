using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
using System.Numerics;
using System.Data.SqlClient;

namespace DiagnosticsEngine
{
    public partial class Form1 : Form
    {
        public int N;
        public Complex[][] fftResults;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
