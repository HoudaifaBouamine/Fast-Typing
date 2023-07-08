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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        string example = ("cat dog hat car run sun day pen bed cup red big fun top sit box win arm fly job jam lip bus key sad egg fan hat ice map net pig rat run tap van leg fox nut zoo flag gate hill jump kite lake moon nest rain star tree up van well yell zero lion boat duck frog gold hand milk neck pink soap tail vest wolf yawn apple beach chair dance fruit grass horse juice lemon music nurse orange party quiet river snake table uncle voice water xylophone yogurt zebra airplane banana camera dinosaur elephant flower guitar");
        private void ucTypingBoard1_Load(object sender, EventArgs e)
        {
            ucTypingBoard1.set(example);
        }
    }
}
