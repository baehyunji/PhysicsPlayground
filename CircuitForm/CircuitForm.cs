using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pendulum;

namespace PhysicsPlayground
{

    public partial class CircuitForm: UserControl
    {
        private CircuitCanvas canvas;
        public CircuitForm()
        {
            InitializeComponent();

            canvas = new CircuitCanvas
            {
                Location = new Point(150, 0),
                Size = new Size(580, 510),
                BackColor = Color.White
            };
            this.Controls.Add(canvas);
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
        private void addResistorButton_Click(object sender, EventArgs e)
        {
            canvas.StartPlacing("Resistor");
        }

        private void addVoltageButton_Click(object sender, EventArgs e)
        {
            canvas.StartPlacing("Voltage");
        }

        private void bulbButton_Click(object sender, EventArgs e)
        {
            canvas.StartPlacing("Bulb");
        }

        private void sliderButton_Click(object sender, EventArgs e)
        {
            canvas.StartPlacing("SliderResistor");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            canvas.StartPlacing("Switch");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (canvas.IsCircuitClosed())
                statusLabel.Text = "회로가 이미 닫혔다";

            else
                statusLabel.Text = "회로가 닫히지 않았다";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            canvas.ClearAll();
        }
    }
}
