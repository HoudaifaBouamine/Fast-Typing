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

namespace WindowsFormsControlLibrary1
{
    public partial class ucTypingBoard : UserControl
    {
        public ucTypingBoard()
        {
            InitializeComponent();
            this.typing_Board.Font = this.Font;
            typing_Board.clear();

            set("houdaifa bouamine @ gmail . com");
            
        }

        string text = "";
        string input = "";
        string current_word;

        Color  colNoType = Color.Gray;
        Color  colCorrectType = Color.FromArgb(220,220,220);
        Color  colWrongType = Color.Red;

        string[] words;
        Stack<string> writed_words = new Stack<string>();


        int iRealTextIndex    = 0;
        int iWritingTextIndex = 0;
        int iCurrent_word_index= 0;

        public void add(string new_word)
        {
            typing_Board.add_string(new_word + " ", colNoType);

            
        }
        public void set(string new_text)
        {
            clear();
            text = new_text;
            typing_Board.add_string(new_text, colNoType);

            words = new_text.Split(' ');
            
            for(int i = 0; i <  words.Length; i++)
            {
                words[i] += ' ';
            }
        }
        public void clear()
        {
            typing_Board.clear();

            text = "";
            input = "";


            iRealTextIndex = 0;
            iWritingTextIndex = 0;
        }
        private void typing_Board_KeyDown(object sender, KeyEventArgs e)
        {
            read_char(e);

            handle_speachal_input(e);

            label1.Text = input;

            label2.Text = current_word;
            label3.Text = iCurrent_word_index.ToString();
            label4.Text = words[iCurrent_word_index];
        }

        private void read_char(KeyEventArgs e)
        {

            if (char.IsLetter((char)e.KeyValue) && isCapsLock())
            {
                add_new_Char((char)(e.KeyValue));
            }
            if (char.IsLetter((char)e.KeyValue) && !isCapsLock())
            {
                add_new_Char((char)(e.KeyValue + 32));
            }
            else if(char.IsDigit((char)e.KeyValue))
            {

                add_new_Char((char)e.KeyValue);


            }
            else if(char.IsPunctuation((char)e.KeyValue) )
            {
                add_new_Char((char)e.KeyValue);

            }
            else if (e.KeyValue == 190)
            {
                add_new_Char('.');
            }
            void add_new_Char(char ch1)
            {
                input += ch1;
                current_word += ch1;


                if (current_word.Length <= words[iCurrent_word_index].Length)
                {
                    if (current_word[current_word.Length - 1] == words[iCurrent_word_index][current_word.Length - 1])
                    {

                        typing_Board.set_color((short)(input.Length - 1), colCorrectType);

                    }
                    else
                    {
                        typing_Board.set_color((short)(input.Length - 1), colWrongType);

                    }
                    iRealTextIndex++;
                    iWritingTextIndex++;

                    return;
                }

            }

        }
        private void handle_speachal_input(KeyEventArgs e)
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

                }




            }

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
        }
    }
}
