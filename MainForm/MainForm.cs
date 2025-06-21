using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsPlayground
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPendulum_Click(object sender, EventArgs e)
        {
           this.Controls.Clear();
            
            PendulumForm pendulumForm = new PendulumForm();


            pendulumForm.Dock = DockStyle.Fill;  
            this.Controls.Add(pendulumForm);
        }

        private void btnRefraction_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            RefractionForm refractionForm = new RefractionForm();

            refractionForm.Dock = DockStyle.Fill; 
            this.Controls.Add(refractionForm);
        }

        private void btnCircuit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            CircuitForm circuitForm = new CircuitForm();
            circuitForm.Dock = DockStyle.Fill; 
            this.Controls.Add(circuitForm);
        }

        private void btnBuoyancy_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            BuoyancyForm buoyancyForm = new BuoyancyForm();

            buoyancyForm.Dock = DockStyle.Fill; 
            this.Controls.Add(buoyancyForm);
        }

        public void LoadMainMenu()
        {
            InitializeComponent();
        }
    }
}
