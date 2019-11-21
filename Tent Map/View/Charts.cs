using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tent_Map.Function;

namespace Tent_Map.View
{
    public partial class formCharts : Form
    {
        private TentMap tentMap;

        public formCharts(TentMap tentMap)
        {
            InitializeComponent();
            this.tentMap = tentMap;
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            chartTest.Series[0].Points.Clear();

            for (int i = 0; i < tentMap.CoordsX.Count; i++)
            {
                chartTest.Series[0].Points.AddXY(tentMap.CoordsY[i], tentMap.CoordsX[i]);
            }
        }
    }
}
