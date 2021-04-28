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

namespace Cypher_Project
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public static char[] Alphabet = {
			'A',
			'B',
			'C',
			'D',
			'E',
			'F',
			'G',
			'H',
			'I',
			'J',
			'K',
			'L',
			'M',
			'N',
			'O',
			'P',
			'Q',
			'R',
			'S',
			'T',
			'U',
			'V',
			'W',
			'X',
			'Y',
			'Z',
			'a',
			'b',
			'c',
			'd',
			'e',
			'f',
			'g',
			'h',
			'i',
			'j',
			'k',
			'l',
			'm',
			'n',
			'o',
			'p',
			'q',
			'r',
			's',
			't',
			'u',
			'v',
			'w',
			'x',
			'y',
			'z',

			'А',
			'Б',
			'В',
			'Г',
			'Д',
			'Е',
			'Ё',
			'Ж',
			'З',
			'И',
			'Й',
			'К',
			'Л',
			'М',
			'Н',
			'О',
			'П',
			'Р',
			'С',
			'Т',
			'У',
			'Ф',
			'Х',
			'Ц',
			'Ч',
			'Ш',
			'Щ',
			'Ъ',
			'Ы',
			'Ь',
			'Э',
			'Ю',
			'Я',
			'а',
			'б',
			'в',
			'г',
			'д',
			'е',
			'ё',
			'ж',
			'з',
			'и',
			'й',
			'к',
			'л',
			'м',
			'н',
			'о',
			'п',
			'р',
			'с',
			'т',
			'у',
			'ф',
			'х',
			'ц',
			'ч',
			'ш',
			'щ',
			'ъ',
			'ы',
			'ь',
			'э',
			'ю',
			'я',

			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'0',
		};

		public static string[] binaryCodes = {
			"00000000",
			"00000001",
			"00000010",
			"00000011",
			"00000100",
			"00000101",
			"00000110",
			"00000111",
			"00001000",
			"00001001",
			"00001010",
			"00001011",
			"00001100",
			"00001101",
			"00001110",
			"00001111",
			"00010000",
			"00010001",
			"00010010",
			"00010011",
			"00010100",
			"00010101",
			"00010110",
			"00010111",
			"00011000",
			"00011001",

			"00011010",
			"00011011",
			"00011100",
			"00011101",
			"00011110",
			"00011111",
			"00100000",
			"00100001",
			"00100010",
			"00100011",
			"00100100",
			"00100101",
			"00100110",
			"00100111",
			"00101000",
			"00101001",
			"00101010",
			"00101011",
			"00101100",
			"00101101",
			"00101110",
			"00101111",
			"00110000",
			"00110001",
			"00110010",
			"00110011",
			
			"00110100",
			"00110101",
			"00110110",
			"00110111",
			"00111000",
			"00111001",
			"00111010",
			"00111011",
			"00111100",
			"00111101",
			"00111110",
			"00111111",
			"01000000",
			"01000001",
			"01000010",
			"01000011",
			"01000100",
			"01000101",
			"01000110",
			"01000111",
			"01001000",
			"01001001",
			"01001010",
			"01001011",
			"01001100",
			"01001101",
			"01001110",
			"01001111",
			"01010000",
			"01010001",
			"01010010",
			"01010011",
			"01010100",

			"01010101",
			"01010110",
			"01010111",
			"01011000",
			"01011001",
			"01011010",
			"01011011",
			"01011100",
			"01011101",
			"01011110",
			"01011111",
			"01100000",
			"01100001",
			"01100010",
			"01100011",
			"01100100",
			"01100101",
			"01100110",
			"01100111",
			"01101000",
			"01101001",
			"01101010",
			"01101011",
			"01101100",
			"01101101",
			"01101110",
			"01101111",
			"01110000",
			"01110001",
			"01110010",
			"01110011",
			"01110100",
			"01110101",

			"01110110",
			"01110111",
			"01111000",
			"01111001",
			"01111010",
			"01111011",
			"01111100",
			"01111101",
			"01111110",
			"01111111"
		};

		public static string CypheredBinaryEnum = "";
		private void button3_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "";
			openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Word Документы (*.doc)|*.doc|Word Документы (*.docx)|*.docx";
			openFileDialog1.ShowDialog();
			Path_textBox_c.Text = openFileDialog1.FileName;
			Key_textBox_c.Text = $"{File.ReadAllText(Path_textBox_c.Text).Length}";
		}

		private void cypher_button_Click(object sender, EventArgs e)
		{
			string TextFromFile = File.ReadAllText(Path_textBox_c.Text);

			Form Form2 = new Form();
			Form2.Text = "TEXT";
			Form2.Show();
			Label label1 = new Label();
			label1.Location = new Point(10, 10);
			Form2.Controls.Add(label1);
			label1.AutoSize = true;
			label1.Text = TextFromFile;

			for (int i = 0; i < TextFromFile.Length; i++)
			{
				for (int j = 0; j < Alphabet.Length; j++)
				{
					if (TextFromFile[i] == Alphabet[j])
					{
						CypheredBinaryEnum += binaryCodes[j];
					}
				}
				
			}
			label1.Text = CypheredBinaryEnum;
		}

		private void help_button_Click(object sender, EventArgs e)
		{
			Form Help_Form = new Form();
			Label Help_label = new Label();
			Help_Form.Text = "Помощь";
			Help_label.Location = new Point(10, 10);
			Help_Form.Controls.Add(Help_label);
			Help_label.AutoSize = true;
			Help_label.Text = File.ReadAllText("help.txt"); //Help text set's at here <<<
			Help_Form.ShowIcon = false;
			Help_Form.MinimumSize = new Size(200, 100);
			Help_Form.MinimizeBox = false;
			Help_Form.MaximizeBox = false;
			Help_Form.Size = Help_label.Size + new Size(40, 60);
			Help_Form.FormBorderStyle = FormBorderStyle.FixedDialog;
			Help_Form.StartPosition = FormStartPosition.CenterParent;
			Help_Form.ShowDialog();
		}

	}
}
