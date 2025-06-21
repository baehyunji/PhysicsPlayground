﻿using System;
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
    public partial class RefractionForm: UserControl
    {
        private bool showMaterial = false;

        private Dictionary<string, double> materialIndex = new Dictionary<string, double>()
        {
            {"진공", 1.0},
            {"공기", 1.00029},
            {"물(20℃)", 1.33},
             {"설탕물(30%)", 1.38},
            {"설탕물(80%)", 1.49},
            {"얼음", 1.31},
            {"유리", 1.52},
            {"사파이어", 1.77},
            {"다이아몬드", 2.42}
        };
        private bool isDragging = false;
        private Point incidentEnd;
        private string selectedMaterial = "공기";

        public RefractionForm()
        {
            InitializeComponent();

            cmbMaterial.SelectedIndex = 1;
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;

            incidentEnd = new Point(panel1.Width / 2 - 100, panel1.Height / 2 - 100);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && Distance(e.Location, incidentEnd) < 20)
            {
                isDragging = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                incidentEnd = e.Location;
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMaterial = cmbMaterial.SelectedItem.ToString();
            showMaterial = true;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            int cx = panel1.Width / 2;
            int cy = panel1.Height / 2;

            if (showMaterial)
            {
                Brush materialBrush = GetMaterialBrush(selectedMaterial);
                Rectangle lowerMedium = new Rectangle(0, cy, panel1.Width, panel1.Height - cy);
                g.FillRectangle(materialBrush, lowerMedium);
            }
            else
            {
                Rectangle lowerMedium = new Rectangle(0, cy, panel1.Width, panel1.Height - cy);
                g.FillRectangle(new SolidBrush(Color.FromArgb(230, 230, 230)), lowerMedium);
            }

            Pen normalPen = new Pen(Color.Gray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            Pen incidentPen = new Pen(Color.Blue, 2);
            Pen refractedPen = new Pen(Color.Red, 2);
            Pen reflectedPen = new Pen(Color.Green, 2);

            g.DrawLine(normalPen, cx, 0, cx, panel1.Height);
            g.DrawLine(Pens.Black, 0, cy, panel1.Width, cy);
            g.DrawLine(incidentPen, incidentEnd, new Point(cx, cy));

            double dx = cx - incidentEnd.X;
            double dy = cy - incidentEnd.Y;
            double theta1 = Math.Atan2(dx, dy);
            double angleDeg = theta1 * 180 / Math.PI;

            double n1 = materialIndex["공기"];

            if (cmbMaterial.SelectedItem == null)
            {
                lblResult.Text = "굴절률을 선택해주세요.";
                return;
            }

            string mat2 = cmbMaterial.SelectedItem.ToString();
            double n2 = materialIndex[mat2];

            double sinTheta2 = n1 / n2 * Math.Sin(theta1);
            bool isTotalInternalReflection = sinTheta2 > 1.0;

            Font font = new Font("Arial", 10);
            Brush textBrush = Brushes.Black;
            Pen anglePen = new Pen(Color.Orange, 1);
            int radius = 40;
            int sweepAngle = (int)angleDeg;

            if (sinTheta2 > 1.0)
            {
                lblResult.Text = $"전반사 발생 (입사각: {angleDeg:F1}°, 반사각: {angleDeg:F1}°)";
                double reflectAngle = theta1;
                Point reflectEnd = new Point(cx + (int)(100 * Math.Sin(reflectAngle)), cy - (int)(100 * Math.Cos(reflectAngle)));
                g.DrawLine(reflectedPen, new Point(cx, cy), reflectEnd);
            }
            else
            {
                double theta2 = Math.Asin(sinTheta2);
                double angle2Deg = theta2 * 180 / Math.PI;
                lblResult.Text = $"입사각: {angleDeg:F1}°, 반사각: {angleDeg:F1}°, 굴절각: {angle2Deg:F1}°";

                Point refractEnd = new Point(cx + (int)(100 * Math.Sin(theta2)), cy + (int)(100 * Math.Cos(theta2)));
                g.DrawLine(refractedPen, new Point(cx, cy), refractEnd);

                Point reflectEnd = new Point(cx + (int)(100 * Math.Sin(theta1)), cy - (int)(100 * Math.Cos(theta1)));
                g.DrawLine(reflectedPen, new Point(cx, cy), reflectEnd);
            }

            g.FillEllipse(Brushes.Blue, incidentEnd.X - 5, incidentEnd.Y - 5, 10, 10);

        }

        private double Distance(Point a, Point b)
        {
            int dx = a.X - b.X;
            int dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        private Brush GetMaterialBrush(string material)
        {
            switch (material)
            {
                case "물(20℃)":
                case "설탕물(80%)":
                case "설탕물(30%)": return new SolidBrush(Color.LightSteelBlue);
                case "얼음": return new SolidBrush(Color.AliceBlue);
                case "유리": return new SolidBrush(Color.Honeydew);
                case "사파이어": return new SolidBrush(Color.Lavender);
                case "다이아몬드": return new SolidBrush(Color.LightGray);
                default: return Brushes.Transparent;
            }
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            showMaterial = !showMaterial;
            panel1.Invalidate();
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
