using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattleCity2022
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        
        // Переменная для запоминания, выбранного режима
		static public int mode = 0;

        // Событие -  когда курсор мыши отводят от надписи "Начать игру"
        private void StartGame_MouseLeave(object sender, EventArgs e)
        {
            StartGame.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие -  когда курсор мыши отводят от надписи "Выход"
        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие - закрытие приложения
        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
			Application.Exit(); // Выход из приложения
		}

        // Событие - нажатие на надпись "Начать игру"
        private void StartGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (Single.Visible && Coop.Visible) // Если надписи "1 игрок" и "2 игрока" отображены
            {
                // Скрываем надписи
                Single.Visible = false; 
                Coop.Visible = false;
            }
            else // Если надписи "1 игрок" и "2 игрока" скрыты
            {
                // Отображаем надписи
                Single.Visible = true;
                Coop.Visible = true;
            }
        }

        // Событие -  наведение курсора мыши на надпись "Начать игру"
        private void StartGame_MouseMove(object sender, MouseEventArgs e)
        {
            StartGame.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие -  наведение курсора мыши на надпись "Выход"
        private void Exit_MouseMove(object sender, MouseEventArgs e)
        {
                Exit.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие - нажатие на надпись "1 игрок"
        private void Single_Click(object sender, EventArgs e)
        {
            mode = 1; // Присваеваем переменной то, что выбран первый режим
            Field Field = new Field();
            this.Hide(); // Закрытие текущей формы
            Field.Show(); // Открытие формы игры
        }

        // Событие - нажатие на надпись "2 игрока"
        private void Coop_Click(object sender, EventArgs e)
        {
            mode = 2;
            Field Field = new Field();
            this.Hide(); // Закрытие текущей формы
            Field.Show(); // Открытие формы игры
        }

        // Событие -  наведение курсора мыши на надпись "1 игрок"
        private void Single_MouseMove(object sender, MouseEventArgs e)
        {
            Single.ForeColor = Color.DarkRed; // Изменение цвета надписи
        }

        // Событие -  наведение курсора мыши на надпись "2 игрока"
        private void Coop_MouseMove(object sender, MouseEventArgs e)
        { 
            Coop.ForeColor = Color.DarkRed; // Изменение цвета надписи
        }

        // Событие -  когда курсор мыши отводят от надписи "2 игрока"
        private void Coop_MouseLeave(object sender, EventArgs e)
        {
            Coop.ForeColor = Color.DodgerBlue; // Изменение цвета надписи
        }

        // Событие -  когда курсор мыши отводят от надписи "1 игрок"
        private void Single_MouseLeave(object sender, EventArgs e)
        {
            Single.ForeColor = Color.Orange; // Изменение цвета надписи
        }

        // Событие - нажатие на надпись "Настройки"
        private void Options_MouseClick(object sender, MouseEventArgs e)
		{
			Options Options = new Options();
			this.Hide(); // Закрытие текущей формы
            Options.Show(); // Открытие формы "Настройки"
        }

        // Событие -  наведение курсора мыши на надпись "Инструкция"
        private void helpLabel_MouseMove(object sender, MouseEventArgs e)
		{
			helpLabel.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие -  когда курсор мыши отводят от надписи "Инструкция"
        private void helpLabel_MouseLeave(object sender, EventArgs e)
		{
			helpLabel.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи 
        }

        // Событие - нажатие на надпись "Инструкция"
        private void helpLabel_MouseClick(object sender, MouseEventArgs e)
		{
			Help Helps = new Help();
			this.Hide(); // Закрытие текущей формы
            Helps.Show(); // Открытие формы "Инструкция"
        }

        // Событие -  наведение курсора мыши на надпись "Настройки"
        private void Options_MouseMove(object sender, MouseEventArgs e)
		{
			Options.ForeColor = Color.Red; // Изменение цвета надписи
        }

        // Событие -  когда курсор мыши отводят от надписи "Настройки"
        private void Options_MouseLeave(object sender, EventArgs e)
		{
			Options.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие - нажатие на надпись "Справка"
        private void AboutGameLAbel_MouseClick(object sender, MouseEventArgs e)
		{
			AboutGame aboutTheGame = new AboutGame();
			this.Hide(); // Закрытие текущей формы
            aboutTheGame.Show(); // Открытие формы "Справка"
        }

        // Событие -  когда курсор мыши отводят от надписи "Справка"
        private void AboutGameLAbel_MouseLeave(object sender, EventArgs e)
		{
			AboutGameLAbel.ForeColor = Color.DarkSlateGray; // Изменение цвета надписи
        }

        // Событие -  наведение курсора мыши на надпись "Справка"
        private void AboutGameLAbel_MouseMove(object sender, MouseEventArgs e)
		{
			AboutGameLAbel.ForeColor = Color.Red; // Изменение цвета надписи
        }
	}
}