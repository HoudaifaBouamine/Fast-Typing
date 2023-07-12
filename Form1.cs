using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace FastTyping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            typingBoard.Visible = false;

            typingBoard.set(get_test_text());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm_Loading l = new frm_Loading();
            Visible = false;
            typingBoard.Visible = true;

            l.ShowDialog();
            Visible = false;

            //l.Show();
            //Visible = false;

        }



        string get_test_text()
        {
            return "cat dog hat car run sun day pen bed cup red big fun top sit box win arm fly job jam lip bus key sad egg fan hat ice map net pig rat run tap van leg fox nut zoo flag gate hill jump kite lake moon nest rain star tree up van well yell zero lion boat duck frog gold hand milk neck pink soap tail vest wolf yawn apple beach chair dance fruit grass horse juice lemon music nurse orange party quiet river snake table uncle voice water";



        }

        private void ucTypingBoard1_Load(object sender, EventArgs e)
        {

        }

        float round_time = 8;
        int timer = 0;
        DateTime currentTime;
        DateTime end_time;
        public int wordsCounter = 0;

        public List<int> words_every_tick = new List<int>();
        private void timer_WPS_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;
            if (end_time >= currentTime)
            {
                timer = (int)((end_time - currentTime).TotalSeconds) + 1;
                lbl_time_left.Text = (new TimeSpan(0, 0, timer)).ToString();
                timer--;
                words_every_tick.Add(typingBoard.iCurrent_word_index - wordsCounter);
                wordsCounter = typingBoard.iCurrent_word_index;
            }
            else
            {
                timer_WPS.Stop();
                show_resutls();

            }
        }

        private void show_resutls()
        {

            panel1.Visible = false;
            panel2.Visible = true;

            string[] words = typingBoard.words;
            string[] writed_words = new string[typingBoard.writed_words.Count];
            typingBoard.writed_words.CopyTo(writed_words,0);
            float wps = 0;
            for (int i = 0; i < typingBoard.writed_words.Count; i++)
            {

                string word_wr = writed_words[typingBoard.writed_words.Count - i - 1];
                string word = words[i];
               // if (words[i] == writed_words[typingBoard.writed_words.Count-i])
                
                if(word_wr == word.Trim())
                {
                    wps++;

                }
            }

            wps = (60.0f / round_time) * wps;
            lbl_wpm.Text = ((int)wps).ToString();

        }

        private void btn_Start_Or_Reset_Click(object sender, EventArgs e)
        {
            start_test();
        }

        private void start_test()
        {
            timer = (int)round_time;

            currentTime = DateTime.Now;
            end_time = DateTime.Now + new TimeSpan(0, 0, timer);

            timer_WPS.Start();
            btn_Start_Or_Reset.Visible = false;
        }

        bool running = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!running)
            {
                running = true;
                start_test();
            }
            
            typingBoard.typing_Board_KeyDown(sender, e);
        }

        private void check_if_first_click_Tick(object sender, EventArgs e)
        {
            if (typingBoard.isRunning) 
            {
                check_if_first_click.Stop();
                start_test();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
