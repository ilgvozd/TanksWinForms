using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace BattleCity2022
{
	public partial class Options : Form
	{

		List<string> levels = new List<string>(); // Список для хранения уровней
		List<string> ColorTanks = new List<string>(); // Список для хранения цветов танка
        List<string> ShortFileNameTanks = new List<string>(); // Список для названия цветов танка

        string aPathlvl, aPathColorTank, shortNameTank;
		int i = 0, j = 0, l = 0; // Вспомогательные переменные

		public Options()
		{
			InitializeComponent();
		}

		// Событие - нажатие на надпись "Изменение цвета поля"
		private void ColorField_MouseClick(object sender, MouseEventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK) // Если в диалоговом окне нажать кнопку "ОК"
			{
				Properties.Settings.Default.BackColor_Field = colorDialog1.Color; // Сохраняем в параметр выбранный цвет
				LabelColor.BackColor = Properties.Settings.Default.BackColor_Field; // Изменяем цвет квадрата стоящий рядом с надписью
            }
			else // Если нажата кнопка "Отмена" или диалоговое окно закрыто неправильно
			{
				Properties.Settings.Default.BackColor_Field = Color.DarkSlateGray; // Сохраняем в параметр цвет по умолчанию
                LabelColor.BackColor = Properties.Settings.Default.BackColor_Field; // Изменяем цвет квадрата стоящий рядом с надписью на по умолчанию
            }

		}

        // Событие -  когда курсор мыши отводят от надписи "Изменение цвета поля"
        private void ColorField_MouseLeave(object sender, EventArgs e)
		{
			ColorField.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие -  наведение курсора мыши на надпись "Изменение цвета поля"
        private void ColorField_MouseMove(object sender, MouseEventArgs e)
		{
			ColorField.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие - нажатие на надпись "Назад в меню"
        private void BackMenu_MouseClick(object sender, MouseEventArgs e)
		{
			menu Menu = new menu();
			this.Hide(); // Закрытие текущей формы
            Menu.Show(); // Открытие формы "Меню"
        }

        // Событие -  когда курсор мыши отводят от надписи "Изменение цвета поля"
        private void BackMenu_MouseLeave(object sender, EventArgs e)
		{
			BackMenu.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие -  наведение курсора мыши на надпись "Назад в меню"
        private void BackMenu_MouseMove(object sender, MouseEventArgs e)
		{
			BackMenu.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие - закрытие формы
		private void Options_FormClosed(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.Save(); // Сохраняем параметры
            Application.Exit(); // Выход из приложения
		}

		private void Options_Load(object sender, EventArgs e)
		{
			LabelColor.BackColor = Properties.Settings.Default.BackColor_Field; // Сохраняем в параметр, выбранный цвет игрового поля

			aPathlvl = Application.StartupPath + "\\Levels\\";  // Путь к изображениям
			DirectoryInfo di = new DirectoryInfo(aPathlvl);   // Получение директории
			FileInfo[] fi = di.GetFiles("*.png");  // Поиск графических файлов

			foreach (FileInfo fc in fi)
			{
				levels.Add(fc.Name); // Добавление названий файлов с уровнями в список
			}

			pictureBoxMap.Image = Image.FromFile("Levels/" + levels[i]);

			aPathColorTank = Application.StartupPath + "\\ColorsOfTanks\\";  // Путь к изображениям
			DirectoryInfo di2 = new DirectoryInfo(aPathColorTank);   // Получение директории
			FileInfo[] fi2 = di2.GetFiles("*.png");  // Поиск графических файлов

			foreach (FileInfo fc in fi2)
			{
				int pos = fc.Name.IndexOf('.');

				shortNameTank = fc.Name.Remove(pos);

				ShortFileNameTanks.Add(shortNameTank);

				ColorTanks.Add(fc.Name);
			}

			pictureBoxColorTank1.Image = Image.FromFile("ColorsOfTanks/" + ColorTanks[j]);
			pictureBoxColorTank2.Image = Image.FromFile("ColorsOfTanks/" + ColorTanks[l]);

		}


		#region //Кнопка "Подтвердить"
		private void label1_MouseClick(object sender, MouseEventArgs e)
		{
			Properties.Settings.Default.ChooseLevel = i + 1; // Сохраняем в параметр номер, выбранного уровня

			for (int k = 0; k < ColorTanks.Count; k++)
			{
				int pos = ColorTanks[k].IndexOf(".");

				if (ColorTanks[k].Remove(pos) == ShortFileNameTanks[j])
				{
					Properties.Settings.Default.ColorPlayer1 = ColorTanks[j];
				}

				if (ColorTanks[k].Remove(pos) == ShortFileNameTanks[l])
				{
					Properties.Settings.Default.ColorPlayer2 = ColorTanks[l];
				}
			}
		}

        // Событие -  когда курсор мыши отводят от надписи "Подтвердить"
        private void label1_MouseLeave(object sender, EventArgs e)
		{
			label1.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие -  наведение курсора мыши на надпись "Подтвердить"
        private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			label1.ForeColor = Color.Red; // Изменение цвета надписи
        }
		#endregion

		#region //Выбор карты
        // Событие - нажатие стрелки влево
		private void leftMap_MouseClick(object sender, MouseEventArgs e)
		{
			i--;
			if (i < 0)
			{
				pictureBoxMap.Image = Image.FromFile("Levels/" + levels[levels.Count - 1]);
				i = levels.Count - 1;
			}
			else
			{
				pictureBoxMap.Image = Image.FromFile("Levels/" + levels[i]);
			}
			

		}

        // Событие - нажатие стрелки вправо
        private void rightMap_MouseClick(object sender, MouseEventArgs e)
		{
			i++;
			if (i > levels.Count - 1)
			{
				pictureBoxMap.Image = Image.FromFile("Levels/" + levels[0]);
				i = 0;
			}
			else
			{
				pictureBoxMap.Image = Image.FromFile("Levels/" + levels[i]);
			}
		}
        #endregion

        #region// Выбор цвета танка 1
        // Событие - нажатие стрелки вправо
        private void leftTank1Color_MouseClick(object sender, MouseEventArgs e)
		{
			j--;
			if (j < 0)
			{
				pictureBoxColorTank1.Image = Image.FromFile("ColorsOfTanks/" + ColorTanks[ColorTanks.Count - 1]);
				j = ColorTanks.Count - 1;
			}
			else
			{
				pictureBoxColorTank1.Image = Image.FromFile("ColorsOfTanks/" + ColorTanks[j]);
			}
		}

        // Событие - нажатие стрелки влево
        private void rightTank1Color_MouseClick(object sender, MouseEventArgs e)
		{
			j++;
			if (j > ColorTanks.Count - 1)
			{
				pictureBoxColorTank1.Image = Image.FromFile("ColorsOfTanks/" + ColorTanks[0]);
				j = 0;
			}
			else
			{
				pictureBoxColorTank1.Image = Image.FromFile("ColorsOfTanks/" + ColorTanks[j]);
			}
		}
        #endregion

        #region// Выбор цвета танка 2

        // Событие - нажатие стрелки влево
        private void leftTank2Color_MouseClick(object sender, MouseEventArgs e)
		{
			l--;
			if (l < 0)
			{
				pictureBoxColorTank2.Image = Image.FromFile("ColorsOfTanks/" + ColorTanks[ColorTanks.Count - 1]);
				l = ColorTanks.Count - 1;
			}
			else
			{
				pictureBoxColorTank2.Image = Image.FromFile("ColorsOfTanks/" + ColorTanks[l]);
			}
		}

        // Событие - нажатие стрелки вправо
        private void rightTank2Color_MouseClick(object sender, MouseEventArgs e)
		{
			l++;
			if (l > ColorTanks.Count - 1)
			{
				pictureBoxColorTank2.Image = Image.FromFile("ColorsOfTanks/" + ColorTanks[0]);
				l = 0;
			}
			else
			{
				pictureBoxColorTank2.Image = Image.FromFile("ColorsOfTanks/" + ColorTanks[l]);
			}
		}
		#endregion
	}
}