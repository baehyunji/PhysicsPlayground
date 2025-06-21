using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsPlayground
{
    public partial class CircuitForm: UserControl
    {
        public CircuitForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form mainForm = this.FindForm();
            if (mainForm is MainForm mForm)
            {
                mForm.Controls.Clear();

                mForm.LoadMainMenu();
            }
        }
    }
}
