using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


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

        private void load()
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
            Visible = true;
            shpw_time_left(new TimeSpan (0,0,(int)round_time));
            //l.Show();
            
           
        }



        string get_test_text()
        {
            return "cat dog hat car run sun day pen bed cup red big fun top sit box win arm fly job jam lip bus key sad egg fan hat ice map net pig rat run tap van leg fox nut zoo flag gate hill jump kite lake moon nest rain star tree up van well yell zero lion boat duck frog gold hand milk neck pink soap tail vest wolf yawn apple beach chair dance fruit grass horse juice lemon music nurse orange party quiet river snake table uncle voice water";



        }

        private void ucTypingBoard1_Load(object sender, EventArgs e)
        {

        }

        float round_time = 15;
        int timer = 0;
        DateTime currentTime;
        DateTime end_time;
        public int wordsCounter = 0;

        
        public List<float> words_every_sec = new List<float>();
        private void timer_WPS_Tick(object sender, EventArgs e)
        {
            timer--;
            TimeSpan ts = new TimeSpan(0, 0, timer);
            shpw_time_left(ts);
            save_words_speed();

            if (timer == 0)
            {
                timer_WPS.Stop();
                show_resutls();
            }

        }

        float char_progress = 0;
        private void save_words_speed()
        {

            char_progress = (typingBoard.current_word.Trim()).Length;
            words_every_sec.Add(60f * (typingBoard.iCurrent_word_index - wordsCounter + char_progress / (float)(typingBoard.words[typingBoard.iCurrent_word_index].Trim()).Length));
            wordsCounter = typingBoard.iCurrent_word_index;
        }

        private void shpw_time_left(TimeSpan ts)
        {
            if (ts.TotalSeconds <= 60)
            {
                lbl_time_left.Text = (ts.TotalSeconds).ToString();

            }
            else
            {
                lbl_time_left.Text = (ts).ToString().Substring(3);

            }
        }


        private void show_resutls()
        {

            panel1.Visible = false;
            panel2.Visible = true;

            string[] words = typingBoard.words;
            string[] writed_words = new string[typingBoard.writed_words.Count];
            int cpt_words = typingBoard.writed_words.Count;
            set_wps();
            set_acc();
            set_characters();
            set_time();
            set_raw();


            List<float> wps_every_sec;
            set_wps_every_sec();
            Graph.init(wps_every_sec, 1,10);

























            void set_wps()
            {
              
                typingBoard.writed_words.CopyTo(writed_words, 0);
                float wps = 0;
                for (int i = 0; i < typingBoard.writed_words.Count; i++)
                {

                    string word_wr = writed_words[typingBoard.writed_words.Count - i - 1];
                    string word = words[i];
                    // if (words[i] == writed_words[typingBoard.writed_words.Count-i])

                    if (word_wr == word.Trim())
                    {
                        wps++;

                    }
                }

                wps = (60.0f / round_time) * wps;


                lbl_wpm.Text = ((int)wps).ToString();
            }
            void set_acc()
            {
                float acc = (float)typingBoard.cpt_CorrectChar /(float) (typingBoard.cpt_CorrectChar + typingBoard.cpt_WrongChar);
                acc *= 100;

                lbl_acc.Text = ((int)acc).ToString() + '%';
            }
            void set_characters()
            {
                int correct_chars = 0;
                int incorrect_chars = 0;
                int missed_chars = 0;
                int extra_chars = 0;

                

                for (int i = 0; i < cpt_words; i++)
                {
                    for(int j = 0; j < Math.Min(words[i].Trim().Length, writed_words[writed_words.Length - 1 - i].Length);j++)
                    {
                        if ((words[i].Trim())[j] == writed_words[writed_words.Length  - 1 -i][j])
                        {
                             correct_chars++;
                        }
                        else
                        {
                             incorrect_chars++;
                        }
                    }
                }

                    for (int i = 0; i < cpt_words; i++)
                {
                    if (words[i].Trim().Length > writed_words[i].Length)
                    {
                        missed_chars += words[i].Trim().Length - writed_words[i].Length;
                    }
                    else if (words[i].Trim().Length < writed_words[i].Length)
                    {
                        extra_chars += writed_words[i].Length - words[i].Trim().Length;
                    }
                }

                lbl_characters.Text = correct_chars.ToString() + "/" + incorrect_chars.ToString() + "/" + extra_chars.ToString() + "/" + missed_chars.ToString();
            }
            void set_time()
            {
                lbl_time.Text = round_time.ToString() + "s";
            }
            void set_raw()
            {
                // raw is the wps but with counting the incorrect words

                lbl_raw.Text = ((int)(((float)60 / (float)round_time) * (typingBoard.iCurrent_word_index))).ToString();
            }

            void set_wps_every_sec()
            {
                wps_every_sec = new List<float>();
                float dev = 0;
                float sum = 0;

                for(int i = 0;i < words_every_sec.Count; i++)
                {
                        dev = sum = 0;
                        if(i > 0)
                        {
                            sum += words_every_sec[i - 1] * 2;
                            dev+=2;
                        }

                        if(i < words_every_sec.Count - 1)
                        {
                            sum += words_every_sec[i + 1] * 2;
                            dev+=2;
                        }

                        sum += words_every_sec[i] * 3;
                        dev+=3;

                        wps_every_sec.Add(sum / dev);
                   // wps_every_sec.Add(words_every_sec[i]);

                }

            }
        }






        private void btn_Start_Or_Reset_Click(object sender, EventArgs e)
        {
            start_test();
        }

        private void start_test()
        {
            timer = (int)round_time;

            timer_WPS.Start();
            btn_Start_Or_Reset.Visible = false;
        }

        bool running = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
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

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
