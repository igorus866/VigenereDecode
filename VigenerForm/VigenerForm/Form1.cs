using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VigenerForm
{
    public partial class Form1 : Form
    {
        string em;
        string dm;
        string k;
        string m;
        public Form1()
        {
            InitializeComponent();
        }

        // Encrypt
        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            int d;
            int g, j;
            int t = 0;
            char[] message = m.ToCharArray();
            char[] key = k.ToCharArray();
            char[] alphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', '_' };
            for (int i=0; i < message.Length; i++)
            {
                for (j=0; j < alphabet.Length; j++)
                {
                    if (message[i] == alphabet[j])
                    {
                        break;
                    }
                }
                if (j != alphabet.Length)
                {
                    n = j;
                    if (t>key.Length - 1)
                    {
                        t = 0;
                    }
                    for (g = 0; g < alphabet.Length; g++)
                    {
                        if (key[t] == alphabet[g])
                        {
                            break;
                        }
                    }
                    t++;
                    if (g != alphabet.Length)
                    {
                        d = n + g;
                    }
                    else
                    {
                        d = n;
                    }
                    if (d > alphabet.Length - 1)
                    {
                        d = d - alphabet.Length;
                    }
                    message[i] = alphabet[d];
                }
               
            }
            em = new string(message);
            richTextBox3.Text = em;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            k = Convert.ToString(richTextBox1.Text);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            m = Convert.ToString(richTextBox2.Text);
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            int n;
            int d;
            int g, j;
            int t = 0;
            char[] message = m.ToCharArray();
            char[] key = k.ToCharArray();
            char[] alphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', '_' };
            for (int i = 0; i < message.Length; i++)
            {
                for (j = 0; j < alphabet.Length; j++)
                {
                    if (message[i] == alphabet[j])
                    {
                        break;
                    }
                }
                if (j != alphabet.Length)
                {
                    n = j;
                    if (t > key.Length - 1)
                    {
                        t = 0;
                    }
                    for (g = 0; g < alphabet.Length; g++)
                    {
                        if (key[t] == alphabet[g])
                        {
                            break;
                        }
                    }
                    t++;
                    if (g != alphabet.Length)
                    {
                        d = n - g + alphabet.Length;
                    }
                    else
                    {
                        d = n;
                    }
                    if (d > alphabet.Length - 1)
                    {
                        d = d - alphabet.Length;
                    }
                    message[i] = alphabet[d];
                }

            }
            dm = new string(message);
            richTextBox3.Text = dm;
        }
    }
}
