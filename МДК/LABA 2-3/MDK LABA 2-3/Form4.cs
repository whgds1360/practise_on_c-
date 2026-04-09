using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace MDK_LABA_2_3
{
    public partial class Form4 : Form
    {
        private System.Windows.Forms.Timer TimerAnimation;
        private int dx = 5, dy = 5; // Шаг сдвига по пикселям (По скрипту скорость)

        public Form4()
        {
            InitializeComponent();
        }

        private void StartHandler(object sender, EventArgs e)
        {
            ButtonStart.Visible = false;

            TimerAnimation = new System.Windows.Forms.Timer
            {
                Interval = 30  // мс
            };
            TimerAnimation.Tick += Timer_Tick;
            TimerAnimation.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Обновление часиков
            LabelTime.Text = DateTime.Now.ToString("HH:mm:ss");

            // Получаем текущую позицию
            int x = LabelTime.Location.X;
            int y = LabelTime.Location.Y;

            // Обновляем позицию
            x += dx;
            y += dy;

            // Проверяем столкновение с границами формы
            if (x <= 0 || x + LabelTime.Width >= this.ClientSize.Width)
            {
                dx = -dx;  // Меняем направление по X
            }

            if (y <= 0 || y + LabelTime.Height >= this.ClientSize.Height)
            {
                dy = -dy;  // Меняем направление по Y
            }

            // Применяем новую позицию
            LabelTime.Location = new Point(x, y);
        }
    }
}
