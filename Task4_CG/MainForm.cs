using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Task4_CG
{
    public partial class MainForm : Form
    {
        private Scene scene;
        private Camera camera;
        public MainForm()
        {
            InitializeComponent();
                scene = new Scene();
                camera = new Camera();

            scene.Models.Add(new Cylinder(new Vector3((float)TLFX.Value, (float)TLFY.Value, (float)TLFZ.Value), new Vector3((float)BRNX.Value, (float)BRNY.Value, (float)BRNZ.Value), 0.2f));

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = scene.DrawAll(camera, 
                new ClassLibrary1.Screen(Size,
                new RectangleF( -3f, -3f, 6, 6)));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }
        Point last = new Point();


        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
                last = e.Location;
        }
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
                last = new Point();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left) && !last.IsEmpty)
            {
                float dx = e.Location.X - last.X;
                float dy = e.Location.Y - last.Y;
                camera.View =
                    Matrix4.Rotate(1, dx * (float)Math.PI / 180) *
                    Matrix4.Rotate(0, dy * (float)Math.PI / 180) *
                    camera.View;
                Invalidate();   
                last = e.Location;
            }
            last = e.Location;
        }

        private void CylRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void ConusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            scene.Models.Clear();
            IModel m;
            if (ConusRadioButton.Checked)
            {
                m = new Conus(new Vector3((float)TLFX.Value, (float)TLFY.Value, (float)TLFZ.Value), new Vector3((float)BRNX.Value, (float)BRNY.Value, (float)BRNZ.Value), 0.2f);
            }
            else
            {
                m = new Cylinder(new Vector3((float)TLFX.Value, (float)TLFY.Value, (float)TLFZ.Value), new Vector3((float)BRNX.Value, (float)BRNY.Value, (float)BRNZ.Value), 0.2f);
            }
            scene.Models.Add(m);
            Invalidate();
        }

        private void TLFX_ValueChanged(object sender, EventArgs e)
        {
            Update();
            //if (CylRadioButton.Checked)
            //    CylRadioButton_CheckedChanged(sender, e);
            //if (ConusRadioButton.Checked)
            //    ConusRadioButton_CheckedChanged(sender, e);
        }
    }
}
