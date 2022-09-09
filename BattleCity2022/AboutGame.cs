using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattleCity2022
{
	public partial class AboutGame : Form
	{
		public AboutGame()
		{
			InitializeComponent();
		}

        // Событие - закрытие приложения
        private void AboutGame_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
        

        // Событие - нажатие на надпись "Назад в меню"
        private void BackMenu_MouseClick(object sender, MouseEventArgs e)
		{
			menu Menu = new menu();
			this.Hide(); // Закрытие текущей формы
			Menu.Show(); // Открытие формы "Меню"
		}

        // Событие -  когда курсор мыши отводят от надписи "Назад в меню"
        private void BackMenu_MouseLeave(object sender, EventArgs e)
		{
			BackMenu.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
		}

        // Событие -  наведение курсора мыши на надпись "Назад в меню"
        private void BackMenu_MouseMove(object sender, MouseEventArgs e)
		{
			BackMenu.ForeColor = Color.Red; // Изменение цвета надписи
        }
	}
}