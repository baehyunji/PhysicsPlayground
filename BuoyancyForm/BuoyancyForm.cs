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
    public partial class BuoyancyForm: UserControl
    {
        public BuoyancyForm()
        {
            InitializeComponent();



            pictureBox2.SendToBack();
            timer1.Start();
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


        private void BuoyancyForm_Load(object sender, EventArgs e)
        {

        }

        private void timeStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timeRestart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private float force = 0;
        private static float speed = 0;
        private const float gravity = -0.5f;
        private static float position = 0;

        private static float delta_time = 0.3f;

        private const float line = 300;
        private const float friction_공기 = 0.01f;
        private const float friction_물 = 0.1f;
        private const float _V = 2f;
        private const float size = 30;

        private bool onClick;
        private float click_force = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (position < 0 && speed < 0)
            {
                speed *= -1;
            }

            force = 0;

            force += gravity;
            force += Force_Click();
            force += Force_buoyancy();
            force += speed * Friction();

            

            

            speed += force * delta_time;
            position = position + speed * delta_time;

           // Print();

            pictureBox1.Location = new Point(pictureBox1.Location.X, 500 - (int)position);
        }

        private float Force_Click()
        {
            if (!onClick) return 0;

            float mouse_pos = 500 - PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y)).Y;

            if (mouse_pos - position > 100) return 1;
            else if(mouse_pos - position < 100) return -1;
            else
            {
                return (mouse_pos - position) / 100;
            }


            
        }


        private float Force_buoyancy()
        {
            float d = line - position;
            float force = 0;

            if (d > size / 2)
            {
                force = _V;
            }
            else if (d < size / 2)
            {

            }
            else
            {
                force = _V * (d + size / 2);
            }

            return force;
        }



        private float Friction()
        {
            float friction;
            if (position + size / 2 < line)
            {
                friction = friction_물;
            }
            else if (position - size / 2 > line)
            {
                friction = friction_공기;
            }
            else if (speed > 0)
            {
                friction = friction_공기;
            }
            else
            {
                friction = friction_물;
            }

            return -friction;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            onClick = true;
            pictureBox1.Image = global::PhysicsPlayground.Properties.Resources.New_Piskel__4_;
        }



        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            onClick = false;
            pictureBox1.Image = global::PhysicsPlayground.Properties.Resources.New_Piskel__2_;
        }
    }
}
