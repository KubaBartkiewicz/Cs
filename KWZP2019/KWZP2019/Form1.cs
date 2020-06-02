using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class StartForm : Form
    {
      private RoofingCompanyEntities db;

        public StartForm()
        {
            InitializeComponent();
            db = new RoofingCompanyEntities();

        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            FinancesAndHR finanseIHR = new FinancesAndHR(db, this);
            finanseIHR.Show();
        }
    }
}
