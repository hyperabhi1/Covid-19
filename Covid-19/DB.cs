using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Covid_19.DAL;

namespace Covid_19
{
    public partial class DB : Form
    {
        public DB()
        {
            InitializeComponent();
        }

        private void DB_Load(object sender, EventArgs e)
        {
            dataGridViewUserReadings.DataSource = UserStatsData.Get().OrderBy(x=>x.Time).ToList();
        }
    }
}
