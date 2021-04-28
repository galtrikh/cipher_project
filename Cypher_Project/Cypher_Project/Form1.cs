using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Cypher_Project
{
	public partial class Form1 : Form
	{

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

		public static string Key = "";

		public Form1()
		{
			InitializeComponent();
		}

		#region Cipher

		private void button3_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "";
			openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Word Документы (*.doc)|*.doc|Word Документы (*.docx)|*.docx";
			openFileDialog1.ShowDialog();
			Path_textBox_c.Text = openFileDialog1.FileName;
		}

		private void cypher_button_Click(object sender, EventArgs e)
		{

			string TextFromFile = File.ReadAllText(Path_textBox_c.Text);

			Random rand = new Random();

			int Move1 = rand.Next(1, 8);
			int Move2 = rand.Next(1, 8);
			int Move3 = rand.Next(1, 8);

			Key = $"F{Move1}S{Move2}T{Move3}";

			string CiferedCezarText = "";

			if (betterCipher_checkBox.Checked)
			{
				for(int i = 0; i < TextFromFile.Length; i++)
				{
					for (int j = 0; j < Alphabet.Length; j++)
					{
						if (Alphabet.Contains(TextFromFile[i]))
						{
							if (TextFromFile[i] == Alphabet[j])
							{
								try
								{
									CiferedCezarText += Alphabet[Alphabet.Length - j].ToString();
								}
								catch
								{
									CiferedCezarText += Alphabet[Alphabet.Length - 1 - j].ToString();
								}
								break;
							}
						}
						else
						{
							if (TextFromFile[i] == ' ')
							{
								CiferedCezarText += " ";
							}
							else if (TextFromFile[i] == '\n')
							{
								CiferedCezarText += '\n';
							}
							else
							{
								CiferedCezarText += TextFromFile[i];
							}
							break;
						}
					}
				}
				Key += "B";
			}
			else
			{
				for (int i = 0; i < TextFromFile.Length; i++)
				{
					for (int j = 0; j < Alphabet.Length; j++)
					{
						if (Alphabet.Contains(TextFromFile[i]))
						{
							if (TextFromFile[i] == Alphabet[j])
							{
								CiferedCezarText += Alphabet[j + Move1];
								break;
							}
						}
						else
						{
							if (TextFromFile[i] == ' ')
							{
								CiferedCezarText += " ";
							}
							else if (TextFromFile[i] == '\n')
							{
								CiferedCezarText += '\n';
							}
							else
							{
								CiferedCezarText += TextFromFile[i];
							}
							break;
						}
					}
				}
				Key += "N";
			}

			saveFileDialog1.ShowDialog();
			if(saveFileDialog1.FileName.Contains(".txt")) File.WriteAllText(saveFileDialog1.FileName, CiferedCezarText);
			else File.WriteAllText(saveFileDialog1.FileName + ".txt", CiferedCezarText);
			Key_textBox_c.Text = Key;
		}

		#endregion

		#region Decipher

		private void Dicipher_openFile_button_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "";
			openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Word Документы (*.doc)|*.doc|Word Документы (*.docx)|*.docx";
			openFileDialog1.ShowDialog();
			Path_textBox_dec.Text = openFileDialog1.FileName;
		}

		private void Decipher_button_Click(object sender, EventArgs e)
		{
			Key = Key_textBox_dec.Text;
			string TextFromFile = File.ReadAllText(Path_textBox_dec.Text);
			string DeciferedCezarText = "";
			if (Key[6] == 'B')
			{
				for (int i = 0; i < TextFromFile.Length; i++)
				{
					for (int j = 0; j < Alphabet.Length; j++)
					{
						if (Alphabet.Contains(TextFromFile[i]))
						{
							if (TextFromFile[i] == Alphabet[j])
							{
								DeciferedCezarText += Alphabet[Alphabet.Length - j].ToString();
								break;
							}
						}
						else
						{
							if (TextFromFile[i] == ' ')
							{
								DeciferedCezarText += " ";
							}
							else if (TextFromFile[i] == '\n')
							{
								DeciferedCezarText += '\n';
							}
							else
							{
								DeciferedCezarText += TextFromFile[i];
							}
							break;
						}
					}
				}
			}
			else
			{
				for (int i = 0; i < TextFromFile.Length; i++)
				{
					for (int j = 0; j < Alphabet.Length; j++)
					{
						if (Alphabet.Contains(TextFromFile[i]))
						{
							if (TextFromFile[i] == Alphabet[j])
							{
								DeciferedCezarText += Alphabet[j - Convert.ToInt32(Key[1]) + 48];
								break;
							}
						}
						else
						{
							if (TextFromFile[i] == ' ')
							{
								DeciferedCezarText += " ";
							}
							else if (TextFromFile[i] == '\n')
							{
								DeciferedCezarText += '\n';
							}
							else
							{
								DeciferedCezarText += TextFromFile[i];
							}
							break;
						}
					}
				}
			}
			saveFileDialog1.ShowDialog();
			File.WriteAllText(saveFileDialog1.FileName, DeciferedCezarText);
		}

		#endregion

		private void help_button_Click(object sender, EventArgs e)
		{
			Form Help_Form = new Form();
			Label Help_label = new Label();
			Help_Form.Text = "Помощь";
			Help_label.Location = new Point(10, 10);
			Help_Form.Controls.Add(Help_label);
			Help_label.AutoSize = true;
			Help_label.Text = global::Cypher_Project.Properties.Resources.help; //Help text set's at here <<<
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
