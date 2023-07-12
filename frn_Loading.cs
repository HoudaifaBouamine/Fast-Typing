using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTyping
{
    public partial class frm_Loading : Form
    {
        public frm_Loading()
        {
            InitializeComponent();
        }

        private void frn_Loading_Load(object sender, EventArgs e)
        {
            Location = new Point(System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width / 2 - this.Width / 2, System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height / 2 - this.Height / 2);

            progressBar1.Value = 0;
            timer1.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);

            if(progressBar1.Value >= progressBar1.Maximum) { timer1.Stop(); this.Close(); }
        }
    }
}
