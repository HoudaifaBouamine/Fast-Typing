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
            this.typing_Board.Font = this.Font;
            typing_Board.clear();

            set("houdaifa bouamine @ gmail . com");
        }

        string text = "";
        string input = "";


        Color  colNoType = Color.Gray;
        Color  colCorrectType = Color.FromArgb(220,220,220);
        Color  colWrongType = Color.Red;


        int    iRealTextIndex    = 0;
        int    iWritingTextIndex = 0;

        public void set(string new_text)
        {
            clear();
            text = new_text;
            typing_Board.add_string(text, colNoType);
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
            read_char((char)e.KeyValue);

            handle_speachal_input(e);
        }

        private void read_char(char ch)
        {

            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
                input += ch;



                if (input[iWritingTextIndex] == text[iRealTextIndex])
                {
                    typing_Board.set_color((short)(iWritingTextIndex), colCorrectType);
                }
                else
                {
                    typing_Board.set_color((short)(iWritingTextIndex), colWrongType);

                }

                iRealTextIndex++;
                iWritingTextIndex++;
            }
            else if(ch >= '1' && ch <= '9')
            {
                input += ch;


                if (input[iWritingTextIndex] == text[iRealTextIndex])
                {

                    typing_Board.set_color((short)(input.Length - 1), colCorrectType);

                }
                else
                {
                    typing_Board.set_color((short)(input.Length - 1), colWrongType);

                }

                iRealTextIndex++;
                iWritingTextIndex++;
            }

        }

        private void handle_speachal_input(KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                if (input != "")
                {

                    typing_Board.set_color((short)(input.Length - 1), colNoType);
                    input = input.Remove(input.Length - 1, 1);

                    if(iRealTextIndex>0)
                    iRealTextIndex   --;

                    if(iWritingTextIndex>0)
                    iWritingTextIndex--;
                }

            }
            else if(e.KeyCode == Keys.Space)
            {
                input += " ";
                iRealTextIndex++;
                iWritingTextIndex++;
            }
            
        }

        private void ucTypingBoard_Load(object sender, EventArgs e)
        {
            this.Select();
        }
    }
}
