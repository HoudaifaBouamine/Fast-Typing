using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace ucGraphDrawer
{
    public partial class usGraph: UserControl
    {
        public usGraph()
        {
            InitializeComponent();
        }

        Graphics gfx;
        Pen pen = new Pen(Color.Black,1);
        float step_size_x;
        float step_size_y;
        int number_of_steps_for_unit_x;
        int number_of_steps_for_unit_y;
        List<float> list_y;

        private void usGraph_Load(object sender, EventArgs e)
        {
           
        }

        //List <int> 


        public void init(List<float> list_y,int number_of_steps_for_unit_x,int number_of_steps_for_unit_y)
        {
            init_Graphics();
            this.list_y = list_y;
            nomalize();
            this.number_of_steps_for_unit_x = number_of_steps_for_unit_x;
            this.number_of_steps_for_unit_y = number_of_steps_for_unit_y;
            calc_steps();
            draw_Dimantions();
            draw_Graph();

            // Note (Houdaifa) next lines must be deleted
            label1.Text = "";
            for (int i = 0; i < list_y.Count; i += number_of_steps_for_unit_x)
            {
                label1.Text += (list_y[i]).ToString() + ", ";
            }

            label1.Text += "max :" + (list_y.Max()).ToString();
        }

        private void nomalize()
        {
            float ratio  = (float)pictureBox1.Height / (float) list_y.Max();

            for(int i = 0; i < list_y.Count; i++)
            {
                list_y[i] *= ratio;
            }
        }

        private void calc_steps()
        {

            step_size_x =  (float)number_of_steps_for_unit_x * ((float)pictureBox1.Width - 2) / (float) (list_y.Count-1);
            step_size_y = (float)number_of_steps_for_unit_y * ((float)pictureBox1.Height);
        }
        private void init_Graphics()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(pictureBox1.Image);
        }

        private void draw_Dimantions()
        {

            // Drawing vertical lines
            for (int i = 0; i <  list_y.Count / number_of_steps_for_unit_x; i++)
            {
                gfx.DrawLine(pen, i * step_size_x, 0, i * step_size_x, pictureBox1.Height);
            }

            // Drawing horizontal lines
            for (int i = 0; i <= pictureBox1.Height; i++)
            {
                gfx.DrawLine(pen, 0, Converting(i * number_of_steps_for_unit_y), pictureBox1.Width, Converting(i * number_of_steps_for_unit_y));
            }
        }

        private float Converting(float x)
        {
            return pictureBox1.Height - x - 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void draw_Graph()
        {

            for(int i = 0; i < list_y.Count;i += number_of_steps_for_unit_x)
            {
                gfx.DrawEllipse(new Pen(Color.FromArgb(212, 171, 23), 1), new Rectangle((int)(i * step_size_x), (int) (Converting(list_y[i])), 6, 6));

                if(i < list_y.Count - number_of_steps_for_unit_x)
                    gfx.DrawLine(new Pen(Color.FromArgb(212, 171, 23), 2), (int)(i * step_size_x) + 3,(int)(Converting(list_y[i])) + 3, (int)((i+1)* step_size_x) + 3, (int)(Converting(list_y[i+1])) + 3);
            }

        }
    }
}
