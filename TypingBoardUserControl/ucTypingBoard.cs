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

namespace WindowsFormsControlLibrary1
{
    public partial class ucTypingBoard : UserControl
    {
        public ucTypingBoard()
        {
            InitializeComponent();

            this.words = new List<string>();
            // Note (Houdaifa) this is Only for testing , delete it next 

            this.words.Add("dad");
            this.words.Add("houdaifa");
            this.words.Add("bouamine");
            this.words.Add("hello");

            this.words.Add("dad");
            this.words.Add("houdaifa");
            this.words.Add("bouamine");
            this.words.Add("hello");

            //

            load_words();

            update_Output();

        }

        public ucTypingBoard(List<string> words)
        {
            InitializeComponent();
            this.words = words;

            // Note (Houdaifa) this is Only for testing , delete it next 
            this.words.Add("houdaifa");
            this.words.Add("bouamine");
            this.words.Add("hhhhhh");
            this.words.Add("wdoawmoda");
            this.words.Add("othaila");
            this.words.Add("dad");
            //
            load_words();

            update_Output();
        }

        private void load_words()
        {
            typing_Board.clear();

            foreach (string word in words)
            {
                typing_Board.add_string(word + " ");
            }
        }


        private void update_Output()
        {


        }
        private void ucTypingBoard_Load(object sender, EventArgs e)
        {
            this.Select();

        }

        string current_world = "";

        public void ucTypingBoard_KeyDown(object sender, KeyEventArgs e)
        { 

            if(current_word_index + 1 == words.Count && current_letter_index == words[words.Count-1].Length)
            {
                return;
            }

            bool speachial_input = Handle_Speachial_Inputs(e);

            if(!speachial_input)
                Update_TypeBoard((char)e.KeyCode);


           // typing_Board.add_string(current_world);
        }

        private bool Handle_Speachial_Inputs(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back && current_world != "")
            {
                if (current_world.Length > 0)
                {

                    current_total_letters_index--;


                    if (current_world.Length <= words[current_word_index].Length)
                    {
                        current_letter_index--;
                    }

                    else
                    {
                        typing_Board.delete_char(current_total_letters_index);
                        this.Focus();
                    }


                    current_world = current_world.Substring(0, current_world.Length - 1);

                    typing_Board.set_color((short)current_total_letters_index, colNoType);


                }

                return true;
            }
            else if (e.KeyCode == Keys.Back && current_world == "" && !isLastWordCorrect)
            {

                if (current_word_index <= 0)
                    return false;

                current_word_index--;

                current_total_letters_index -= 1 ;
                current_world = stk_WritedWords.Pop();
                current_letter_index = (short) (current_world.Length-1);
                if (current_word_index > 0)
                {
                    isLastWordCorrect = (stk_WritedWords.Peek() == words[current_word_index - 1]);
                }
                else
                {
                    isLastWordCorrect = false;
                }

                // this fix a bug that i do not know what is it
                Handle_Speachial_Inputs(e);
            }
            else if(e.KeyCode == Keys.Space && current_world!= "")
            {

                if (current_world.Length >= words[current_word_index].Length)
                {

                    current_total_letters_index++;

                    if(current_world == words[current_word_index])
                    {
                        isLastWordCorrect = true;
                    }
                    else
                    {
                        isLastWordCorrect = false;
                    }

                }
                else
                {

                    current_total_letters_index += (short) ((words[current_word_index].Length - current_world.Length)  + 1);
                    isLastWordCorrect = false;
                }

                stk_WritedWords.Push(current_world);
                current_world = "";

                current_word_index++;

                current_letter_index = 0;

                return true;
            }
            

            return false;
        }
        private bool Update_TypeBoard(char ch)
        {
            ch = (ch.ToString().ToLower())[0];
            // Note (Houdaifa) this must be deleted (replaced by inserting the wrong key)
            if (current_world.Length >= words[current_word_index].Length)
            {

                current_world += ch;
                typing_Board.insert_char(current_total_letters_index, ch, colTypedWrong);
                current_total_letters_index++;
                typing_Board.Select();

               // typing_Board.insert_char(current_total_letters_index, '@', Color.Blue);
               //current_total_letters_index++;
               //current_world += '@';
                return false;

            }

            if (ch >= '1' && ch <= '9')
            {
                current_world += ch;

                color_letter((char)(ch));

                current_letter_index++;

                if (current_world.Length > words[current_word_index].Length)
                    return true;

                current_total_letters_index++;

                return true;
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                current_world += (char)(ch);


                color_letter((char)(ch));

                current_letter_index++;

                if (current_world.Length > words[current_word_index].Length)
                    return true;

                current_total_letters_index++;

                return true;
            }

            return false;
        }

        private void color_letter(char ch)
        {

            if(current_world.Length > words[current_word_index].Length)
            {
                // Note (Houdaifa) you need to add "Insert" method on uc 

                return;
            }

            if (ch == this.words[current_word_index][current_letter_index])
            {
                typing_Board.set_color((short)current_total_letters_index, colTypedCorrect);
                correct++;
            }
            else
            {
                typing_Board.set_color((short)current_total_letters_index, colTypedWrong);
                errors++;
            }
        }

        private void ucColoredLabel1_Load(object sender, EventArgs e)
        {
            
        }



        List<string> words;
        short current_word_index = 0;
        short current_letter_index = 0;
        short current_total_letters_index = 0;
        short errors = 0;
        short correct = 0;

        Color colNoType = Color.Gray;
        Color colTypedCorrect = Color.FromArgb(230, 230, 230);
        Color colTypedWrong = Color.Red;

        bool isLastWordCorrect = false;

        Stack<string> stk_WritedWords = new Stack<string>();
        private void typing_Board_Click(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
