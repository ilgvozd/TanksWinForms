using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattleCity2022
{
    enum direction : int { up = 0, down, left, right } // Перечисление сторон

    public delegate void PanzerEvent(object sender, MyEventArgs e); // Определение делегата PanzerEvent
    public delegate void BulletEvent(object sender, MyEventArgs e); // Определение делегата BulletEvent
    public delegate void Trigger(object sender, TriggerArgs e); // Определение делегата Trigger

    public partial class Field : Form
    {

        public Field()
        {
            Panzer.CheckCollis += Panzer_CheckCollis; // Добавление обработчик
            Bullet.CheckCollis += Bullet_CheckCollis; // Добавление обработчик
            IIPanzer.CheckCoords += IITrigger; // Добавление обработчик
            InitializeComponent();
        }


        #region// Переменные 
        Bullet[] shotsSolo = new Bullet[5]; // Массив снарядов в режиме "1 игрок"
        Panzer[] alltanksSolo = new Panzer[5]; // Массив танков в режиме "1 игрок"
        Bullet[] shotsDuo = new Bullet[2]; // Массив снарядов в режиме "2 игрока"
        Panzer[] alltanksDuo = new Panzer[2]; // Массив танков в режиме "2 игрока"
        Block[] blocks = new Block[200]; // Массив препятствий (блоков)
		Bonus[] bonuses = new Bonus[1]; // Массив усилений (бонусов)
        Keys direct1, direct2; // Поля, для задания кодов клавиш
        Random rand = new Random(DateTime.Now.Millisecond);
        int timeleft = 0; // Переменная для таймера
        public static int level = Properties.Settings.Default.ChooseLevel; // Поле level хранит в себе номер уровня, который выбрал пользователь в форме "Настройки"
        int count = 0, k = 0, tek = 0, kt = 0, helpX; // Вспомогательные переменные

        // Вспомогательные логические переменные
        bool isfire1 = false, Exit = false, isfire2 = false;
        bool top1 = false, bot1 = false, right1 = false, left1 = false;
        bool top2 = false, bot2 = false, right2 = false, left2 = false;
        bool defeat = false;
		bool baze1Destroyed = false;

        // Количество, танков противника в режиме "1 игрок"
        int frags = 20; 
        #endregion

        #region// Уровни 
        // Трехмерный массив - хранит уровни
        int[,,] levels = new int[,,] {
            {                // 1 уровень
            {0,0,0,0,0,0,0,0,0,0,1,6,1,0,0,0,0,0,0,0,0,0,0},
            {0,1,0,1,0,1,0,1,1,0,2,2,2,0,1,1,0,1,0,1,0,1,0},
            {0,1,0,1,0,1,0,0,1,0,0,0,0,0,1,0,0,1,0,1,0,1,0},
            {0,1,0,0,0,1,0,0,1,0,1,0,1,0,1,0,0,1,0,0,0,1,0},
            {0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
            {0,1,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,1,0},
            {0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
            {0,1,0,1,1,0,0,0,3,0,0,2,0,0,3,0,0,0,1,1,0,1,0},
            {0,0,0,0,0,0,0,0,4,0,0,0,0,0,4,0,0,0,0,0,0,0,0},
            {0,2,2,0,2,0,0,0,3,3,3,3,3,3,3,0,0,0,2,0,2,2,0},
            {0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0},
            {0,1,0,0,0,0,0,1,2,0,0,0,0,0,2,1,0,0,0,0,0,1,0},
            {0,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0},
            {3,1,0,0,0,0,0,0,2,0,0,0,0,0,2,0,0,0,0,0,0,1,3},
            {0,1,1,1,0,1,1,1,2,0,2,2,2,0,2,1,1,1,0,1,1,1,0},
            {0,0,0,0,0,0,0,0,0,0,1,5,1,0,0,0,0,0,0,0,0,0,0},
            },
            {                // 2 уровень
            {0,0,0,1,0,0,0,0,0,0,1,6,1,0,0,0,0,1,0,0,0,0,0},
            {4,0,0,1,0,1,0,1,4,0,2,2,2,0,2,1,0,1,0,1,0,0,0},
            {4,1,1,1,1,1,0,0,4,0,0,0,0,0,1,0,0,1,0,1,0,1,0},
            {4,4,4,0,0,1,0,0,1,0,1,0,1,0,1,0,0,1,0,0,0,0,0},
            {4,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,0,3,4,3},
            {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,1,0,0,0,0,0,0,1,1,1,1,1,0,0,1,0,0,0,0,0,0},
            {1,1,0,1,0,0,0,0,0,1,0,1,4,1,0,0,0,1,1,1,2,2,1},
            {0,0,0,2,0,0,0,0,2,0,4,4,4,4,4,4,0,0,0,0,0,0,0},
            {3,3,0,3,3,3,3,3,3,3,3,0,0,0,3,3,3,3,3,3,3,3,3},
            {4,4,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {4,4,0,0,0,2,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0},
            {4,0,1,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0},
            {4,2,1,0,0,0,0,2,0,0,0,0,0,1,0,0,0,2,1,1,0,2,0},
            {0,2,0,0,1,1,1,0,0,0,2,2,2,0,0,0,0,0,0,1,0,0,2},
            {0,0,0,0,0,0,0,0,0,0,1,5,1,0,0,0,1,0,0,0,0,1,0},
            },
            {               // 3 уровень
            {0,0,0,0,0,0,0,0,0,0,1,6,1,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,2,2,2,0,0,0,0,0,0,0,0,0,0},
            {0,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,0,1,1,1,1,1,0},
            {0,1,4,4,4,4,4,1,0,1,4,1,1,1,4,1,0,1,4,4,4,4,0},
            {0,1,1,1,4,1,1,1,0,1,4,4,4,4,4,1,0,1,1,1,1,1,0},
            {0,0,0,1,4,1,0,0,0,1,4,1,1,1,4,1,0,1,4,4,4,4,0},
            {0,0,0,1,1,1,0,0,0,1,1,1,0,1,1,1,0,1,1,1,1,1,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,1,1,1,1,1,0,1,1,4,4,1,1,0,1,1,1,1,1,0,0,0},
            {0,0,1,4,4,4,4,0,1,1,1,4,1,1,0,1,1,4,4,4,1,0,0},
            {0,0,1,1,1,1,1,0,1,1,1,1,1,1,0,1,1,4,3,4,1,0,0},
            {0,0,1,4,4,4,4,0,1,1,4,1,1,1,0,1,1,4,4,4,1,0,0},
            {0,0,1,1,1,1,1,0,1,1,4,4,1,1,0,1,1,1,1,1,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,2,2,2,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,1,5,1,0,0,0,0,0,0,0,0,0,0},
            }
        };
        #endregion

        #region // Загрузка карт
        // Метод загрузки карты
        public void Loadlvl()
        {
            for (int j = 0, y = 0; j < 16; j++, y += 40)
            {
                for (int i = 0, x = 0; i < 23; i++, x += 40)
                {
                    if (levels[level - 1, j, i] == 1) // Если элемент массива = 1
                    {
                        blocks[count++] = new Block(x, y, 40, Controls); // В массив блоков добавляется объект класса Block (Кирпичная стена)
                    }
                    if (levels[level - 1, j, i] == 2) // Если элемент массива = 2
                    {
                        blocks[count++] = new Steal(x, y, 40, Controls); // В массив блоков добавляется объект класса Steal (Стальная стена)
                    }
                    if (levels[level - 1, j, i] == 3) // Если элемент массива = 3
                    {
                        blocks[count++] = new Water(x, y, 40, Controls); // В массив блоков добавляется объект класса Water (Вода)
                    }
                    if (levels[level - 1, j, i] == 4) // Если элемент массива = 4
                    {
                        blocks[count++] = new Grass(x, y, 40, Controls); // В массив блоков добавляется объект класса Grass (Куст)
                    }
                    if (levels[level - 1, j, i] == 5) // Если элемент массива = 5
                    {
                        blocks[count++] = new Baze(x, y, 40, Controls); // В массив блоков добавляется объект класса Baze (База 1го игрока)
                    }
                    if (levels[level - 1, j, i] == 6) // Если элемент массива = 6
                    {
                        blocks[count++] = new Baze(x, y, 40, Controls); // В массив блоков добавляется объект класса Baze (База 2го игрока)
                        blocks[count-1].flag = true; // Флаг - истина, для различия баз
                    }
                }
            }
        }
        #endregion

        #region // Закрытие формы
        // Событие - закрытие формы
        private void Field_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Выход из приложения
        }
        #endregion

        // Метод для стрельбы врагов
        private bool Fire()
        {
            int value = rand.Next(0, 100);
            if (value == 20 || value == 60)
                return true;
            else return false;
        }

        #region // Таймер случайного появления бонусов
        private void Respawn_bonuses_Tick(object sender, EventArgs e)
		{
			bool may = false;

				int xtemp = 0, ytemp = 0; // Вспомогательные переменые

				Rectangle bounds = new Rectangle();

				while (!may)
				{
                    // Случайном образом получаем координаты x и y
					int x = rand.Next(0, 880); 
					int y = rand.Next(0, 600);

					may = true;

					bounds = new Rectangle(x, y, 40, 40);

                if (menu.mode == 1) // В режиме "1 игрок"
                {
                    for (int i = 0; i < k; i++)
                    {
                        if (alltanksSolo[i].GetBounds().IntersectsWith(bounds)) // Проверяем - пересекается ли координаты усиления с координатами танка 
                        {
                            may = false; // Мочь = ложь => выход из цикла
                        }
                    }
                    for (int i = 0; i < count; i++)
                    {
                        if (blocks[i].GetBounds().IntersectsWith(bounds)) // Проверяем - пересекается ли координаты усиления с координатами препятствий 
                        {
                            may = false; // Мочь = ложь => выход из цикла
                        }
                    }
                }
                if (menu.mode == 2) // В режиме "2 игрока"
                {
                    for (int i = 0; i < k; i++)
                    {
                        if (alltanksDuo[i].GetBounds().IntersectsWith(bounds))// Проверяем - пересекается ли координаты усиления с координатами танка
                        {
                            may = false; // Мочь = ложь => выход из цикла
                        }
                    }
                    for (int i = 0; i < count; i++)
                    {
                        if (blocks[i].GetBounds().IntersectsWith(bounds)) // Проверяем - пересекается ли координаты усиления с координатами препятствий
                        {
                            may = false; // Мочь = ложь => выход из цикла
                        }
                    }
                }

                xtemp = x;
				ytemp = y;

				bonuses[helpX].Replace(460, 0);
				}
				
				bonuses[helpX].Replace(1100, 0);
				bonuses[helpX] = new Bonus(xtemp, ytemp, 40, Controls); // Генерируем усиление на карте
        }
        #endregion

        // Событие - загрузка игровой формы
        private void Field_Load(object sender, EventArgs e)
        {
			this.BackColor = Properties.Settings.Default.BackColor_Field; // Применяем, выбранный цвет фона к форме игры
            Loadlvl(); // Вызываем метод загрузки карты
            
			if (menu.mode == 1) // Если режим "1 игрок"
			{
				bonuses[0] = new Bonus(440, 320, 40, Controls); // Создание объекта класса Bonus

                // Генерация танков
                alltanksSolo[k++] = new Panzer(360, 600, 40, Controls); 
				alltanksSolo[k++] = new IIPanzer(520, 0, 40, Controls);
				for (int i = 0; i < 3; i++)
				{
					if (i % 2 == 0)
						alltanksSolo[k++] = new LightPanzer(880, 0, 40, Controls);
					else
						alltanksSolo[k++] = new LightPanzer(0, 0, 40, Controls);
				}
				alltanksSolo[2].dead = true; alltanksSolo[2].Replace(1000, 1000);

				
				pictureBox1.Visible = true;
				Frags.Visible = true;
			}
            if (menu.mode == 2) // Если режим "1 игрок"
            {
				bonuses[0] = new Bonus(440, 320, 40, Controls);// Создание объекта класса Bonus

                // Генерация танков
                alltanksDuo[k] = new Panzer(360, 600, 40, Controls);
				alltanksDuo[++k] = new Panzer(520, 0, 40, Controls);
                alltanksDuo[k++].SecondPlayer(); // Вызов метода - появления второго игрока

                // Добавление разных надписей на панель информации
                HP_2.Visible = true;
                HP_2_Im.Visible = true;
                label6.Text = "SPACE / ENTER";
                label6.Font = new Font(label6.Font.Name, 15, label6.Font.Style);
                label6.Location = new Point(930, label6.Location.Y);
                label2.Text = "W/A/S/D\nUP/LEFT/DOWN/RIGHT";
                label2.Font = new Font(label2.Font.Name, 10, label6.Font.Style);
            }
            kt = k;
            if (menu.mode == 2) kt = k - 1;
        }

        private void Field_KeyDown(object sender, KeyEventArgs e)
        {
            #region Пауза 
            if (e.KeyCode == Keys.P && !Exit && !defeat) // Если нажали клавишу P и не конец игры  и не поражение
            {
                Exit = true;
                Pause.Visible = true;
                Pause.BringToFront();
                time.Stop(); // Ставим паузу
            }
            else if (e.KeyCode == Keys.P && !defeat) // Если пауза уже стоит
            {
                Exit = false;
                Pause.Visible = false;
                time.Start(); // Возобновление игры
            }
			#endregion
			
			#region Рестарт 
			// Если нажата клавиша R
			if (e.KeyCode == Keys.R) 
			{
				Application.Restart(); // Перезапуск приложения
			}
            #endregion

            if (!Exit) // Если не конец игры
            {
                #region Включение таймеров 
                if (timer.Enabled == false)
                {
					// Запуск таймеров
                    timer.Start(); 
                    time.Start();
                }
                #endregion

                #region 1 игрок направление 
                if (e.KeyCode == Keys.W) top1 = true; // Если нажата клавиша W - направление танка игрока 1 наверх
                if (e.KeyCode == Keys.S) bot1 = true; // Если нажата клавиша S - направление танка игрока 1 вниз
				if (e.KeyCode == Keys.A) left1 = true; // Если нажата клавиша A - направление танка игрока 1 налево
				if (e.KeyCode == Keys.D) right1 = true; // Если нажата клавиша D - направление танка игрока 1 направо
				if (e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.A || e.KeyCode == Keys.D) // Если нажата одна из клавиш, которая написана в условии
                    direct1 = e.KeyCode; // Присваивание кода клавиши
				#endregion

                #region 2 игрок направление     
                if (menu.mode == 2)
                {
                    if (e.KeyCode == Keys.Up) top2 = true; // Если нажата клавиша "Стрелка вверх" - направление танка игрока 2 наверх
					if (e.KeyCode == Keys.Down) bot2 = true; // Если нажата клавиша "Стрелка вниз" - направление танка игрока 2 вниз
					if (e.KeyCode == Keys.Left) left2 = true; // Если нажата клавиша "Стрелка влево" - направление танка игрока 2 налево
					if (e.KeyCode == Keys.Right) right2 = true; // Если нажата клавиша "Стрелка вправо" - направление танка игрока 2 направо
					if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right) // Если нажата одна из клавиш, которая написана в условии
						direct2 = e.KeyCode; // Присваивание кода клавиши
				}
				#endregion

				#region Игра в режиме "1 игрок" - выстрел
				// Если режим игры - "1 игрок"
				if (menu.mode == 1) 
				{	
					// Если игрок 1 не стреляет и нажал клавишу "Space"
					if (!isfire1 && e.KeyCode == Keys.Space) 
					{
						shotsSolo[0] = alltanksSolo[0].shoot(true); // Вызываем метод выстрела 
						shotsSolo[0].show(Controls); // Вызываем метод изображения снаряда
						isfire1 = true;
					}
				}
                    #endregion
					
				#region Игра в режиме "2 игрока" - выстрел 
				// Если режим игры - "2 игрок"
				if (menu.mode == 2) 
				{
					// Если нажата клавиша "Space" или "Enter"
					if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter) 
					{
						// Если игрок 1 не стреляет и нажал клавишу "Space"
						if (!isfire1 && e.KeyCode == Keys.Space)
						{
							shotsDuo[0] = alltanksDuo[0].shoot(true); // Вызываем метод выстрела
							shotsDuo[0].show(Controls); // Вызываем метод изображения снаряда
							isfire1 = true;			
						}
						// Если игрок 2 не стреляет и нажал клавишу "Enter"
						if (!isfire2 && e.KeyCode == Keys.Enter)
                        {
                            shotsDuo[1] = alltanksDuo[1].shoot(true); // Вызываем метод выстрела
							shotsDuo[1].show(Controls); // Вызываем метод изображения снаряда
							isfire2 = true;
                        }
                    }
				}
                #endregion
            }
        }

        private void Field_KeyUp(object sender, KeyEventArgs e)
        {   
			#region 1 игрок

            if (e.KeyCode == Keys.W) top1 = false; // Если клавишу W отпустили - направление сбрасывается
            if (e.KeyCode == Keys.S) bot1 = false; // Если клавишу S отпустили - направление сбрасывается
			if (e.KeyCode == Keys.A) left1 = false; // Если клавишу A отпустили - направление сбрасывается
			if (e.KeyCode == Keys.D) right1 = false; // Если клавишу D отпустили - направление сбрасывается
			if (top1) direct1 = Keys.W; // Присваивание кода клавиши
			if (bot1) direct1 = Keys.S;
            if (left1) direct1 = Keys.A;
            if (right1) direct1 = Keys.D;
            #endregion
        
			#region 2 игрок 
            if (menu.mode == 2)
            {
                if (e.KeyCode == Keys.Up) top2 = false; // Если клавишу "Стрелка вверх" отпустили - направление сбрасывается
				if (e.KeyCode == Keys.Down) bot2 = false; // Если клавишу "Стрелка вниз" отпустили - направление сбрасывается
				if (e.KeyCode == Keys.Left) left2 = false; // Если клавишу "Стрелка влево" отпустили - направление сбрасывается
				if (e.KeyCode == Keys.Right) right2 = false; // Если клавишу "Стрелка вправо" отпустили - направление сбрасывается
				if (top2) direct2 = Keys.Up; // Присваивание кода клавиши
				if (bot2) direct2 = Keys.Down;
                if (left2) direct2 = Keys.Left;
                if (right2) direct2 = Keys.Right;
            }
            #endregion
        }

        private void Field_Paint(object sender, PaintEventArgs e)
        {
			// На форме прорисовывается черная линия, чтобы разделить игровое поле от панели информации
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, 922, 0, 922, 1000);
        }

		// Таймер для движение снарядов
        private void Bullets_Tick(object sender, EventArgs e)
        {
            if (!Exit) // Если не конец игры
            {  
                #region Передвижение пуль
				// Если выбран режим - "1 игрок"
                if (menu.mode == 1)
                {
                    for (int i = 0; i < k; i++)
                    {
                        if (shotsSolo[i] != null && shotsSolo[i].go) // Если танк выстрелил
                        {
                            shotsSolo[i].move(); // Вызов метода движения снаряда
                        }
                        else // Если танк не выстрелил
                        {
                            if (i == 0) isfire1 = false;
                        }
                    }
				} // Если выбран режим - "2 игрока"
				else if(menu.mode == 2)
                {
                    for (int i = 0; i < k; i++)
                    {
                        if (shotsDuo[i] != null && shotsDuo[i].go) // Если танк выстрелил
						{
                            shotsDuo[i].move(); // Вызов метода движения снаряда
						}
                        else // Если танк не выстрелил
                        {
                            if (i == 0) isfire1 = false;
                            if (i == 1) isfire2 = false;
                        }
                    }


                }
				#endregion

				#region Выстрелы врагов 
				// Если выбран режим - "1 игрок"
				if (menu.mode == 1)
				{
					for (int i = 1; i < kt; i++)
					{
						bool fire = Fire(); // Вызов метода стрельбы врагов
						if (shotsSolo[i] == null || !shotsSolo[i].go && fire)
						{
							shotsSolo[i] = alltanksSolo[i].shoot(false);
							shotsSolo[i].show(Controls);
							fire = false;
						}
					}
				}
                #endregion
            }
        }

		// Таймер генерации противников
		private void Enemy_Respawn_Tick(object sender, EventArgs e)
        {
            {
                bool may = false;
                int side = 0;
                Rectangle bounds = new Rectangle(0, 0, 40, 40); 
                while (!may)
                {	
					// Случайный выбор одного из мест, где сгенерируется танк противника
                    side = rand.Next(0, 5);  
                    may = true;

                    if (side == 0)
                    {
                        bounds = new Rectangle(880, 0, 40, 40);
                    }
                    if (side == 1)
                    {
                        bounds = new Rectangle(0, 0, 40, 40);
                    }
                    if (side == 2)
                    {
                        bounds = new Rectangle(550, 0, 40, 40);
                    }
                    if (side == 3)
                    {
                        bounds = new Rectangle(760, 0, 40, 40);
                    }
                    if (side == 4)
                    {
                        bounds = new Rectangle(80, 0, 40, 40);
                    }
                    for (int i = 0; i < k; i++)
                    {
						// Если на месте генерации танка что-то есть
                        if (alltanksSolo[i].GetBounds().IntersectsWith(bounds))
                            may = false; // выйти из цикла
                    }
					alltanksSolo[tek].Replace(1100, 0);
				}
                alltanksSolo[tek].Replace(1100, 0);
                if (frags == 5 || frags == 4 || frags == 10) // Если осталось 5 или 4 или 10 противников
                {
					// Генерация супертанка в одном из мест
                    if (side == 0)
                        alltanksSolo[tek] = new SuperPanzer(880, 0, 40, Controls);
                    else if (side == 1)
                        alltanksSolo[tek] = new SuperPanzer(0, 0, 40, Controls);
                    else if (side == 2)
                        alltanksSolo[tek] = new SuperPanzer(550, 0, 40, Controls);
                    else if (side == 3)
                        alltanksSolo[tek] = new SuperPanzer(760, 0, 40, Controls);
                    else if (side == 4)
                        alltanksSolo[tek] = new SuperPanzer(80, 0, 40, Controls);
                }
                else // Иначе генерируются другие типы танков
                {
                    if (side == 0)
                        alltanksSolo[tek] = new LightPanzer(880, 0, 40, Controls);
                    else if (side == 1)
                        alltanksSolo[tek] = new LightPanzer(0, 0, 40, Controls);
                    else if (side == 2)
                        alltanksSolo[tek] = new IIPanzer(550, 0, 40, Controls);
                    else if (side == 3)
                        alltanksSolo[tek] = new LightPanzer(760, 0, 40, Controls);
                    else if (side == 4)
                        alltanksSolo[tek] = new IIPanzer(80, 0, 40, Controls);
                }
            }
            Enemy_Respawn.Stop(); // Остановка таймера генерации
        }

		// Таймер для отсчёта времени игры
        private void Time_Tick(object sender, EventArgs e)
        {            
            timeleft += 1; // Прибавлять по единице
            int min = timeleft / 60;
            int sec = timeleft % 60;
            if (sec < 10)
                 Ctime.Text = min + ":0" + sec;
            else
                 Ctime.Text = min + ":" + sec;         
        }

		// Главный таймер игры
        private void Timer_Tick(object sender, EventArgs e)
        {
			if (!Exit) //Если не конец игры
			{
                for (int i = 0; i < 1; i++)
                {
                    if (!Respawn_bonuses.Enabled)
                    {
                        helpX = i;
                        Respawn_bonuses.Interval = rand.Next(10000, 50000); // Генерация случайного интервала между появлениями бонусов
                        Respawn_bonuses.Start(); // Запуск таймера генерации усиления
                    }
                }

                // Запуск таймера для передвижения пуль 
                if (Bullets.Enabled == false)
					Bullets.Start();

				#region Передвижение в режиме "2 игрока" 
				if (menu.mode == 2)
				{
					// Движение танка игрока 1
					if (direct1 == Keys.W && top1) alltanksDuo[0].move(Keys.W); // Если нажата клавиша W и направление наверх = истина => вызов функции движения (наверх)
					if (direct1 == Keys.S && bot1) alltanksDuo[0].move(Keys.S); // Если нажата клавиша S и направление вниз = истина => вызов функции движения (вниз)
					if (direct1 == Keys.A && left1) alltanksDuo[0].move(Keys.A); // Если нажата клавиша A и направление налево = истина => вызов функции движения (налево)
					if (direct1 == Keys.D && right1) alltanksDuo[0].move(Keys.D); // Если нажата клавиша D и направление направо = истина => вызов функции движения (направо)

					// Движение танка игрока 2
					if (direct2 == Keys.Up && top2) alltanksDuo[1].move(Keys.W); // Если нажата клавиша "Стрелка вверх" и направление наверх = истина => вызов функции движения (наверх)
					if (direct2 == Keys.Down && bot2) alltanksDuo[1].move(Keys.S); // Если нажата клавиша "Стрелка вниз" и направление вниз = истина => вызов функции движения (вниз)
					if (direct2 == Keys.Left && left2) alltanksDuo[1].move(Keys.A); // Если нажата клавиша "Стрелка влево" и направление налево = истина => вызов функции движения (налево) 
					if (direct2 == Keys.Right && right2) alltanksDuo[1].move(Keys.D); // Если нажата клавиша "Стрелка вправо" и направление направо = истина => вызов функции движения (направо)
				}
				#endregion

				#region Передвижение в режиме "1 игрок" 
				if (menu.mode == 1) // Если выбран режим "1 игрок"
				{
					// Движение танка игрока
					if (direct1 == Keys.W && top1) alltanksSolo[0].move(Keys.W); // Если нажата клавиша W и направление наверх = истина => вызов функции движения (наверх)
					if (direct1 == Keys.S && bot1) alltanksSolo[0].move(Keys.S); // Если нажата клавиша S и направление вниз = истина => вызов функции движения (вниз)
					if (direct1 == Keys.A && left1) alltanksSolo[0].move(Keys.A); // Если нажата клавиша A и направление налево = истина => вызов функции движения (налево)
					if (direct1 == Keys.D && right1) alltanksSolo[0].move(Keys.D); // Если нажата клавиша D и направление направо = истина => вызов функции движения (направо)
				}
				#endregion

				#region Запуск таймера генерации врагов 
				if (menu.mode == 1)
				{
					for (int i = 1; i < kt; i++)
					{
						if (alltanksSolo[i].dead && frags > 3)
						{
							if (!Enemy_Respawn.Enabled)
							{
								tek = i;
								Enemy_Respawn.Start();
							}
						}
					}

                #endregion
                                                         
                    #region Передвижение врагов 

                    for (int i = 1; i < kt; i++)
					{
						alltanksSolo[i].move(direct1);
					}
					#endregion

					 
					Frags.Text = Convert.ToString(frags); // Надпись - количество оставшихся танков
					HP.Text = Convert.ToString(alltanksSolo[0].HP); // Надпись - количество жизней танка игрока
				}
                if (menu.mode == 2) // Если выбран режим "у игрока"
                {
					HP.Text = Convert.ToString(alltanksDuo[0].HP); // Надпись - количество жизней танка игрока 1

					HP_2.Text = Convert.ToString(alltanksDuo[1].HP); // Надпись - количество жизней танка игрока 2
				}
                

                #region// Победа или поражение в соло
                if (menu.mode == 1) // Если выбран режим "1 игрок"
                {
                    if (frags == 0 || baze1Destroyed) // Если все враги уничтожены или база противника уничтожена
                    {
                        Win.Visible = true; // Вывод сообщения о победе
                        Win.BringToFront();
						PrintTime.Text += (" " + Ctime.Text); // Вывод времени игры
						PrintTime.Visible = true;
						PrintTime.BringToFront();
                        timer.Stop(); // Остановка таймера
                        time.Stop(); // Остановка таймера
						Respawn_bonuses.Stop(); // Остановка таймера
						Exit = true;
					}
                
                    #region// Поражение 
                    if (defeat) // Если игрок проиграл
                    {
                        Lose.Visible = true; // Вывод сообщения о поражении
						Lose.BringToFront();
						PrintTime.Text += (" " + Ctime.Text); // Вывод времени игры
						PrintTime.Visible = true;
						PrintTime.BringToFront();
						timer.Stop(); // Остановка таймера
						time.Stop(); // Остановка таймера
						Respawn_bonuses.Stop(); // Остановка таймера
						Exit = true;
                    }
                    #endregion 
                }
                #endregion

                if (menu.mode == 2) // Если выбран режим "2 игрока"
				{
                    if (HP.Text == "0" || defeat) // Если жизни 1го игрока закончились или его база уничтожена
                    {
                        WinPlayer2.Visible = true; // Вывод сообщения о победе игрока 2
						WinPlayer2.BringToFront();
						PrintTime.Text += (" " + Ctime.Text); // Вывод времени игры
						PrintTime.Visible = true;
						PrintTime.BringToFront();
						timer.Stop(); // Остановка таймера
						time.Stop(); // Остановка таймера
						Respawn_bonuses.Stop(); // Остановка таймера
						Exit = true;
                    }
                    else if (HP_2.Text == "0" || baze1Destroyed) // Если жизни 2го игрока закончились или его база уничтожена
					{
                        WinPlayer1.Visible = true; // Вывод сообщения о победе игрока 1
						WinPlayer1.BringToFront();
						PrintTime.Text += (" " + Ctime.Text); // Вывод времени игры
						PrintTime.Visible = true;
						PrintTime.BringToFront();
						timer.Stop(); // Остановка таймера
						time.Stop(); // Остановка таймера
						Respawn_bonuses.Stop(); // Остановка таймера
						Exit = true;
                    }
                }
            }
        }

		// Метод проверки коллизии танка
        private void Panzer_CheckCollis(object sender, MyEventArgs e)
        {
			if (e.dy < 0 || e.dy > Height - 76 || e.dx < 0 || e.dx > Width - 196) // Если танк сталкивается с границей формы
			{
				e.collis = true; // Коллизия = истина (столкнуться)
				return;
			}

			for (int i = 0; i < count; i++)
			{
				if (e.bounds.IntersectsWith(blocks[i].GetBounds()) && !(blocks[i] is Grass)) // Если границы танка пересекаются с блоками любого вида кроме "Grass" (куст)
				{
					e.collis = true; // Коллизия = истина (столкнуться)
					break;
				}
			}

			// Если выбран режим "1 игрок"
			if (menu.mode == 1)
			{
				for (int i = 0; i < k; i++)
				{
					if (e.x == alltanksSolo[i].GetX() && e.y == alltanksSolo[i].GetY()) continue;
					if (e.bounds.IntersectsWith(alltanksSolo[i].GetBounds())) // Если границы танка пересекаются с границами другого танка
					{
						e.collis = true; // Коллизия = истина (столкнуться)
						break;
					}
				}
				for (int i = 0; i < 1; i++)
				{
					if (alltanksSolo[i].GetBounds().IntersectsWith(bonuses[i].GetBounds())) // Если границы танка пользователя пересекаются с границами усиления
					{
						bonuses[helpX].Replace(1100, 0);
						alltanksSolo[i].HP += 1; // Прибавление единицы здоровья танку
						break;
					}
				}

			}
			else if (menu.mode == 2) // Если выбран режим "2 игрок"
			{
				for (int i = 0; i < k; i++)
				{
					if (e.x == alltanksDuo[i].GetX() && e.y == alltanksDuo[i].GetY()) continue;
					if (e.bounds.IntersectsWith(alltanksDuo[i].GetBounds())) // Если границы танка пересекаются с границами другого танка
					{
						e.collis = true; // Коллизия = истина (столкнуться)
						break;
					}
				}
                for (int i = 0; i < k; i++)
                {
                    if (i == 0 && alltanksDuo[0].GetBounds().IntersectsWith(bonuses[0].GetBounds())) // Если границы танка игрока 1 пересекаются с границами усиления
					{
                        bonuses[helpX].Replace(1100, 0);
                        alltanksDuo[i].HP += 1; // Прибавление единицы здоровья танку игрока 1
						break;
                    }
                    else if (i == 1 && alltanksDuo[1].GetBounds().IntersectsWith(bonuses[0].GetBounds())) // Если границы танка игрока 2 пересекаются с границами усиления
					{
                        bonuses[helpX].Replace(1100, 0);
                        alltanksDuo[i].HP += 1; // Прибавление единицы здоровья танку игрока 2
						break;
                    }
                }
            }
		}

		// Метод проверки коллизии снаряда
		private void Bullet_CheckCollis(object sender, MyEventArgs e)
        {
			if (e.dy < 0 || e.dy > Height || e.dx < 0 || e.dx > Width - 155) // Если снаряд сталкивается с границей формы
			{
				e.collis = true; // Коллизия = истина (столкнуться)
				return;
			}

			for (int i = 0; i < count; i++)
			{
				if (e.bounds.IntersectsWith(blocks[i].GetBounds()) && !(blocks[i] is Grass) && !(blocks[i] is Water)) // Если снаряд сталкивается с границей не куста и не воды
				{
					e.collis = true; // Коллизия = истина (столкнуться)

					if (blocks[i] is Baze) // Если этот блок - База
					{
						if (blocks[i].flag && e.friendly) // Если это база игрока 2
						{
							baze1Destroyed = true; // База игрока 2 - уничтожена
						}
						else if (!blocks[i].flag) // Если это база игрока 1
						{
							defeat = true; // База игрока 1 - уничтожена
						}
					}
					else // Если это кирпичная стена
					{
						// Уничтожение части кирпичной стены
						if (e.dy - e.y > 0)
							blocks[i].destroy(Keys.S);
						if (e.dy - e.y < 0)
							blocks[i].destroy(Keys.W);
						if (e.dx - e.x > 0)
							blocks[i].destroy(Keys.D);
						if (e.dx - e.x < 0)
							blocks[i].destroy(Keys.A);
					}
					break;
				}
			}

			// Если выбран режим "1 игрок"
			if (menu.mode == 1)
			{
				for (int i = 0; i < k; i++)
				{
					if (e.bounds.IntersectsWith(alltanksSolo[i].GetBounds())) // Если снаряд пересекается с границами танка
					{
						e.collis = true; // Коллизия = истина (столкнуться)

						if (e.friendly) // Если выстрел пользователя
						{
                            if (!alltanksSolo[i].dead && alltanksSolo[i].strength == 1) // Если танк по которому попали не уничтожен и имеет 1 жизнь
                            {
                                alltanksSolo[i].destroy(); // Вызов метода уничтожения танка
                                frags--; // вычитание из общего количества оставшихся танков
                            }
							if (i != 0)
							{
								alltanksSolo[i].destroy(); // Вызов метода уничтожения танка
							}
						}
						else if (i == 0) // Если попали по танку пользователя
						{
    						if (alltanksSolo[i].HP != 0) // Если жизни танка не равно 0
							{
								alltanksSolo[i].HP--; // Вычесть единицу жизни
								alltanksSolo[i].Replace(360, 600); // Генерация танка в начальную точку
							}
							if (alltanksSolo[i].HP == 0) // Если жизни танка = 0
							{
								alltanksSolo[i].destroy(); // Вызов метода уничтожения
								alltanksSolo[i].Replace(1000, 1000); // Перемещение танка за карту
							}
							if (alltanksSolo[0].HP == 0) defeat = true; // Если у танка пользователя 0 жизней, то поражение = истина
						}
						break;
					}
				}
				for (int i = 0; i < k; i++)
				{
					if (shotsSolo[i] != null)
					{
						if (e.bounds.IntersectsWith(shotsSolo[i].GetBounds()) && e.friendly) // Если границы снаряда игрока пересекаются с границами снаряда противника
						{
							if (shotsSolo[i].friendly == false) 
							{
								shotsSolo[i].hide(); // Снаряд исчезает
								e.collis = true; // Коллизия = истина (столкнуться)
							}
						}
					}
				}
			}
			else if (menu.mode == 2) // Если выбран режим "2 игрока"
			{
				for (int i = 0; i < k; i++)
				{
					if (e.bounds.IntersectsWith(alltanksDuo[i].GetBounds())) // Если границы снаряда одного из игроков сталкиваются с танком другого игрока
					{
						e.collis = true; // Коллизия = истина (столкнуться)

						if (alltanksDuo[i].HP != 0) // Если жизни танка с котором столкнулся снаряд не равно 0
							alltanksDuo[i].HP--; // Уменьшаем количество жизней на 1
						if (i == 0) // Если это танк игрока 1
							alltanksDuo[i].Replace(360, 600); // Регенерируют на первоначальную позицию
						else alltanksDuo[i].Replace(520, 0); // Если танк игрока 2 - регенерируют на его исходную позицию
						if (alltanksDuo[i].HP == 0) // // Если жизни танка с котором столкнулся снаряд = 0
						{
							alltanksDuo[i].destroy(); // Вызов метода уничтожения
							alltanksDuo[i].Replace(1000, 1000); // Перемещение танка за карту
						}
						if (alltanksDuo[0].HP == 0) defeat = true; // Если у игрока 1 - 0 жизней, то поражение = истина
						else if (alltanksDuo[1].HP == 0) baze1Destroyed = true; // Если у игрока 2 - 0 жизней, то поражение = истина

						break;
					}
				}

				if (shotsDuo[0] != null && shotsDuo[1] != null)
				{
					if (shotsDuo[0].GetBounds().IntersectsWith(shotsDuo[1].GetBounds())) // Если границы снарядов двух игроков пересекаются
					{
						// Снаряды исчезают
						shotsDuo[0].hide();
						shotsDuo[1].hide();
                    }
				}
				
			}
        }

		// Метод для "умного" танка - проверка пересечений координат
		private void IITrigger(object sender, TriggerArgs e)
        {
            if (e.x == alltanksSolo[0].GetX() && e.y - alltanksSolo[0].GetY() > 0) e.S = true; // Если x танка пользователя =  x "Умного" танка и танк пользователя выше по координате y чем координата танка противника => Направление танка противника - наверх
            else if (e.x == alltanksSolo[0].GetX() && e.y - alltanksSolo[0].GetY() < 0) e.W = true; // Если x танка пользователя =  x "Умного" танка и танк пользователя ниже по координате y чем координата танка противника => Направление танка противника - вниз
			else if (e.y == alltanksSolo[0].GetY() && e.x - alltanksSolo[0].GetX() > 0) e.D = true; // Если y танка пользователя =  y "Умного" танка и танк пользователя левее чем танк противника => Направление танка противника - влево
			else if (e.y == alltanksSolo[0].GetY() && e.x - alltanksSolo[0].GetX() < 0) e.A = true; // Если y танка пользователя =  y "Умного" танка и танк пользователя правее чем танк противника => Направление танка противника - вправо
			else // Если координаты не пересекаются
            {
                e.W = false;
                e.D = false;
                e.S = false;
                e.A = false;
            }
        }
    }
}