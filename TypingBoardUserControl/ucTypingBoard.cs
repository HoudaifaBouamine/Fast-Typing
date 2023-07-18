using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using ColoredLable;

namespace WindowsFormsControlLibrary1
{
    public partial class ucTypingBoard : UserControl
    {
        public ucTypingBoard()
        {
            InitializeComponent();
            this.typing_Board.Font = this.Font;
            typing_Board.clear();
            set("");
            typing_Board.set_tracing_index(0);

            this.Select();

        }

        public ucTypingBoard(string text)
        {
            InitializeComponent();
            this.typing_Board.Font = this.Font;
            typing_Board.clear();
            set(text);
            typing_Board.set_tracing_index(0);

            this.Select();

        }

        public string text = "";
        public string input = "";
        public string current_word = "";
        public Color colNoType = Color.Gray;
        public Color colCorrectType = Color.FromArgb(220, 220, 220);
        public Color colWrongType = Color.Red;
        public string[] words;
        public Stack<string> writed_words = new Stack<string>();

        public int cpt_CorrectChar = 0;
        public int cpt_WrongChar = 0;

        public int iRealTextIndex = 0;
        public int iWritingTextIndex = 0;
        public int iCurrent_word_index = 0;

        public void add(string new_word)
        {
            typing_Board.add_string(new_word + " ", colNoType);


        }
        public void set(string new_text)
        {
            clear_board();
            text = new_text;
            typing_Board.add_string(new_text, colNoType);

            words = new_text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] += ' ';

            }

            typing_Board.set_tracing_index(0);
        }

        public void set_tracer(int index)
        {
            typing_Board.set_tracing_index(index);
        }

        void clear_board()
        {
            typing_Board.clear();
        }


        public void clear()
        {
            //typing_Board.clear();

            text = "";
            input = "";

            cpt_WrongChar = 0;
            cpt_CorrectChar = 0;
            iRealTextIndex = 0;
            iWritingTextIndex = 0;
        }

        public void refreach()
        {


            System.Windows.Forms.Label lbl = typing_Board.tracer;

            List<character> list = new List<character>();
            foreach (Control control in typing_Board.Controls)
            {
                if (control is System.Windows.Forms.Label && control != lbl)
                {
                    list.Add(new character(control.Text[0], control.ForeColor));
                }
            }

            typing_Board.Controls.Clear();
            typing_Board.lables_clear();
            typing_Board.Controls.Add(lbl);

            foreach(character character in list)
            {
                typing_Board.add_char(character.ch, character.col);
            }

        }

        struct character
        {
            public 
            char ch;
            public Color col;

            public character(char ch,Color col)
            {
                this.ch = ch;
                this.col = col;
            }
        }

        bool stop       = false ;
        public bool isRunning  = false ;
        public void typing_Board_KeyDown(object sender, KeyEventArgs e)
        {
            if(stop) return ;


            if (!handle_additanal_inputs(e))
            {
                if (!read_char_in_valid_range(e))
                {
                    if (!handle_speachal_input(e))
                    {

                    }
                    else
                    {
                    }
                }

            }
            else
            {
            
            }

            typing_Board.set_tracing_index_with_animation(input.Length);


    
            if (current_word.Length + 1== words[words.Length - 1].Length && iCurrent_word_index == words.Length - 1)
            {
                stop = true;
                isFull = true;
                typing_Board.add_char(' ');
                typing_Board.set_tracing_index_with_animation(input.Length);

                // End Screen Here
            }

            this.Select();
            this.Focus();

            if (!isRunning)
            {
                isRunning = true;
            }
        }

        public bool isFull = false;
        private bool handle_additanal_inputs(KeyEventArgs e)
        {
 

            if(current_word.Length + 1 >= words[iCurrent_word_index].Length && char.IsLetterOrDigit((char)e.KeyValue) )
            {

                return true;

                // canceled

                char tmp = (char) e.KeyValue;

                if(char.IsLetter(tmp) && !isCapsLock())
                {
                    tmp = (char)(e.KeyValue + 32);
                }


                typing_Board.insert_char((short)(input.Length), tmp, colWrongType);
                

                current_word += (char)(e.KeyValue);
                input += (char)(e.KeyValue);

                return true;
            }
            else if (current_word.Length >= words[iCurrent_word_index].Length && e.KeyCode == Keys.Back && current_word[current_word.Length-1] != ' ')
            {
                return true;

                // canceled
                current_word = current_word.Remove(current_word.Length - 1, 1);
                input = input.Remove(input.Length - 1, 1);
                typing_Board.delete_char((short)input.Length);


                return true;

            }
            else if(current_word.Length  >= words[iCurrent_word_index].Length && (e.KeyCode == Keys.Space))
            {
                input += " ";

                

                
                iRealTextIndex += (current_word.Length-words[iCurrent_word_index].Length + 1);
                iWritingTextIndex += (current_word.Length-words[iCurrent_word_index].Length+1);
                writed_words.Push(current_word);
                current_word = "";
                iCurrent_word_index++;


                return true;
            }


            return false;
        }
        private bool read_char_in_valid_range(KeyEventArgs e)
        {

            if (current_word.Length <= words[iCurrent_word_index].Length) {

                if (char.IsLetter((char)e.KeyValue) && isCapsLock())
                {
                    add_new_Char((char)(e.KeyValue));
                    return true;
                }
                else if (char.IsLetter((char)e.KeyValue) && !isCapsLock())
                {
                    add_new_Char((char)(e.KeyValue + 32));
                    return true;
                }
                else if (char.IsDigit((char)e.KeyValue))
                {

                    add_new_Char((char)e.KeyValue);
                    return true;


                }
                else if (char.IsPunctuation((char)e.KeyValue))
                {
                    add_new_Char((char)e.KeyValue);
                    return true;

                }
                else if (e.KeyValue == 190)
                {
                    add_new_Char('.');
                    return true;

                }




            }
            return false;



            void add_new_Char(char ch1)
            {
                input += ch1;
                current_word += ch1;


                if (current_word.Length <= words[iCurrent_word_index].Length)
                {
                    if (current_word[current_word.Length - 1] == words[iCurrent_word_index][current_word.Length - 1])
                    {

                        typing_Board.set_color((short)(input.Length - 1), colCorrectType);
                        cpt_CorrectChar++;

                    }
                    else
                    {
                        typing_Board.set_color((short)(input.Length - 1), colWrongType);
                        cpt_WrongChar++;

                    }
                    iRealTextIndex++;
                    iWritingTextIndex++;

                    return;
                }

            }
        }
        private bool handle_speachal_input(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (current_word != "")
                {


                    typing_Board.set_color((short)(input.Length - 1), colNoType);
                    input = input.Remove(input.Length - 1, 1);
                    current_word = current_word.Remove(current_word.Length - 1, 1);

                    if (iRealTextIndex > 0)
                        iRealTextIndex--;

                    if (iWritingTextIndex > 0)
                        iWritingTextIndex--;

                    return true;


                }
                else if (iCurrent_word_index != 0)
                {
                    current_word = writed_words.Pop() + " ";

                    //for(int i = input.Length - 1;i>= 0; i--)
                    //{
                    //    if (input[i] != ' ')
                    //    {
                    //        input.Remove(i);

                    //    }
                    //}

                    int index = input.Length - 1;
                    bool not_complit = false;
                    while (input[index] == '\n' && index >= 0)
                    {
                        not_complit = true;
                        input = input.Remove(index, 1);index--;
                    }

                    if (not_complit)
                    {
                        current_word = current_word.Remove(current_word.Length - 1, 1);

                    }

                    if (iRealTextIndex > 0)
                        iRealTextIndex--;

                    if (iWritingTextIndex > 0)
                        iWritingTextIndex--;

                    if (iCurrent_word_index > 0)
                        iCurrent_word_index--;



                    return handle_speachal_input(e);

                }

            }
            else if (e.KeyCode == Keys.Space)
            {
                if (current_word.Length >= words[iCurrent_word_index].Length - 1)
                {
                    input += " ";
                    iRealTextIndex++;
                    iWritingTextIndex++;
                    iCurrent_word_index++;
                    writed_words.Push(current_word);
                    current_word = "";

                    return true;

                }
                else
                {
                    input += get_spaces(words[iCurrent_word_index].Length-current_word.Length );

                    iRealTextIndex = 0;

                    for(int i = 0; i <= iCurrent_word_index; i++)
                    {
                        iRealTextIndex += words[iCurrent_word_index].Length;
                    }
                    iRealTextIndex--;
                    iWritingTextIndex += words[iCurrent_word_index].Length - current_word.Length + 1;
                    writed_words.Push(current_word);
                    current_word = "";
                    iCurrent_word_index++;

                    return true;

                }




            }

            return false;

            string get_spaces(int count)
            {
                string spaces = "";
                for(int i = 0; i < count; i++)
                {
                    spaces+= "\n";
                }

                return spaces;
            }



        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        private bool isCapsLock()
        {
            return (((ushort)GetKeyState(0x14)) & 0xffff) != 0;

        }

        private void ucTypingBoard_Load(object sender, EventArgs e)
        {

            this.Select();
            this.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  typing_Board.set_tracing_index(3);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            refreach();
        }

        private void typing_Board_FontChanged(object sender, EventArgs e)
        {

        }

        private void ucTypingBoard_FontChanged(object sender, EventArgs e)
        {
            this.typing_Board.Font = this.Font;
        }


    }
}
