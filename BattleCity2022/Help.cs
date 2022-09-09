using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattleCity2022
{
	public partial class Help : Form
	{
		public Help()
		{
			InitializeComponent();
		}

        // Событие - закрытие формы
        private void Help_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Выход из приложения
        }

        // Событие - наведение курсора мыши на надпись "Назад в меню"
        private void BackMenu_MouseMove(object sender, MouseEventArgs e)
        {
            BackMenu.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие -  когда курсор мыши отводят от надписи "Назад в меню"
        private void BackMenu_MouseLeave(object sender, EventArgs e)
        {
            BackMenu.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие - нажатие на надпись "Назад в меню"
        private void BackMenu_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            this.Hide(); // Закрытие текущей формы
            Menu.Show(); // Открытие формы "Меню"
        }

        // Событие - нажатие на надпись "Назад в меню"
        private void label1_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            this.Hide(); // Закрытие текущей формы
            Menu.Show(); // Открытие формы "Меню"
        }

        // Событие -  когда курсор мыши отводят от надписи "Назад в меню"
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие - наведение курсора мыши на надпись "Назад в меню"
        private void label1_MouseMove(object sender, MouseEventArgs e)
        { 
            label1.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие - нажатие на надпись "Назад в меню"
        private void label2_Click(object sender, EventArgs e)
		{
			menu Menu = new menu();
			this.Hide(); // Закрытие текущей формы
            Menu.Show(); // Открытие формы "Меню"
		}

        // Событие - наведение курсора мыши на надпись "Назад в меню"
        private void label2_MouseMove(object sender, MouseEventArgs e)
		{
			label2.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие -  когда курсор мыши отводят от надписи "Назад в меню"
        private void label2_MouseLeave(object sender, EventArgs e)
		{
			label2.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие - нажатие на надпись "Назад в меню"
        private void label3_MouseClick(object sender, MouseEventArgs e)
		{
			menu Menu = new menu();
			this.Hide(); // Закрытие текущей формы
            Menu.Show(); // Открытие формы "Меню"
		}

        // Событие -  когда курсор мыши отводят от надписи "Назад в меню"
        private void label3_MouseLeave(object sender, EventArgs e)
		{
			label3.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие - наведение курсора мыши на надпись "Назад в меню"
        private void label3_MouseMove(object sender, MouseEventArgs e)
		{
			label3.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие - нажатие на надпись "Назад в меню"
        private void label4_MouseClick(object sender, MouseEventArgs e)
		{
			menu Menu = new menu();
			this.Hide(); // Закрытие текущей формы
            Menu.Show(); // Открытие формы "Меню"
        }

        // Событие -  когда курсор мыши отводят от надписи "Назад в меню"
        private void label4_MouseLeave(object sender, EventArgs e)
		{
			label4.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие - наведение курсора мыши на надпись "Назад в меню"
        private void label4_MouseMove(object sender, MouseEventArgs e)
		{
			label4.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие - нажатие на надпись "Назад в меню"
        private void label5_MouseClick(object sender, MouseEventArgs e)
		{
			menu Menu = new menu();
			this.Hide(); // Закрытие текущей формы
            Menu.Show(); // Открытие формы "Меню"
        }

        // Событие -  когда курсор мыши отводят от надписи "Назад в меню"
        private void label5_MouseLeave(object sender, EventArgs e)
		{
			label5.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие - наведение курсора мыши на надпись "Назад в меню"
        private void label5_MouseMove(object sender, MouseEventArgs e)
		{
			label5.ForeColor = Color.Red; // Изменение цвета надписи
        }
	}
}