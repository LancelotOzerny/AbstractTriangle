using System;
using System.Windows.Forms;

namespace AbstractTriangle
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Метод, который срабатывает при нажатии на кнопку "Расчитать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            // Если поляпрошли проверку
            if (CheckTriangleFields())
            {
                // Создаем треугольник и присваиваем ему тип в зависимости от того, что выбрано в combobox
                Triangle triangle = SetTriangleType();
                 
                // Если он null (ну а вдруг?)
                if (triangle == null)
                {
                    MessageBox.Show("Ошибка при создании класса треугольника. Повторите попытку!");
                    return;
                }

                // Устанавливаем начальные значения
                SetStartValues(triangle);

                // И выводим результат
                SetResultValues(triangle);
            }
        }









        /// <summary>
        /// Метод, который позволяет проверить входные данные на корректность
        /// </summary>
        /// <returns></returns>
        private bool CheckTriangleFields()
        {
            // try - на случай если в полях будут буквы, точки (для дробей используем запятые)
            try
            {
                // проверяем стороны
                float aSide = float.Parse(input_aSide.Text);
                float bSide = float.Parse(input_bSide.Text);
                float cSide = float.Parse(input_cSide.Text);

                float angle = float.Parse(input_angle.Text);

                // Проверяем существование треугольника
                if ((aSide + bSide <= cSide) || (bSide + aSide <= cSide) || (cSide + bSide <= aSide))
                {
                    MessageBox.Show("Одна из сторон треугольника больше или равна сумме двух других!");
                    return false;
                }

                // и угла. Угол в трегольнике не может быть > 180. 180 - это уже линия...
                if (angle <= 0|| angle > 179)
                {
                    MessageBox.Show("Проверьте значение угла! Он должен быть больше 0 и меньше 180");
                    return false;
                }
            } catch (Exception)
            {
                MessageBox.Show("Проверьте формат введеных значений!");
                return false;
            }

            // Если все ок - возвращаем true
            return true;
        }

        /// <summary>
        /// Метод, который позволяет установить стартовые значения для треугольника
        /// </summary>
        /// <param name="triangle">треугольник, начальные значения которого нужно установить</param>
        private void SetStartValues(Triangle triangle)
        {
            triangle.SideA = double.Parse(input_aSide.Text);
            triangle.SideB = double.Parse(input_bSide.Text);
            triangle.SideC = double.Parse(input_cSide.Text);

            triangle.Angle = double.Parse(input_angle.Text);
        }

        /// <summary>
        /// Метод, который позволяет установить выходные значения
        /// </summary>
        /// <param name="triangle">треугольник, который содержит входные данные</param>
        private void SetResultValues(Triangle triangle)
        {
            // Вычисляем периметр и площадь треугольника
            double perimetr = triangle.Perimeter();
            double area = triangle.Area();

            // Выставляем значения на форму
            label_perimetrResult.Text = perimetr.ToString();
            label_areaResult.Text = area.ToString();
        }

        /// <summary>
        /// Метод, который позволяет установить тип треугольника, в зависимости от выбранного в comboBox типа
        /// </summary>
        /// <returns></returns>
        private Triangle SetTriangleType()
        {
            // Определяем треугольник по типу базового класса
            Triangle triangle = null;

            // Смотрим что за тип и реализуем его в виде этого типа (наследника)
            if (comboBox_triangleType.Text.ToLower() == "прямоугольный")
            {
                triangle = new RectangularTriangle();
            }

            if (comboBox_triangleType.Text.ToLower() == "равнобедренный")
            {
                triangle = new IsoscelesTriangle();
            }

            if (comboBox_triangleType.Text.ToLower() == "равносторонний")
            {
                triangle = new EquilateralTriangle();
            }

            return triangle;
        }










        // Взаимодействие с элементами формы


        // Инициализация формы
        public Form1()
        {
            InitializeComponent();
            comboBox_triangleType.SelectedIndex = 0;
        }

        /// <summary>
        /// Метод, который вызывается при изменении одного из трех полей ввода сторон. 
        /// Метод выставляет всем сторонам одни и те же значения, если треугольник равносторонний, а углу значение 60 (180 / 3)
        /// </summary>
        private void CheckEqualSides(object sender, EventArgs e)
        {
            if (comboBox_triangleType.Text.ToLower() == "равносторонний")
            {
                input_aSide.Text = ((TextBox)sender).Text;
                input_bSide.Text = ((TextBox)sender).Text;
                input_cSide.Text = ((TextBox)sender).Text;

                input_angle.Text = "60";
            }
        }

        /// <summary>
        /// Метод, который вызывается при изменении одного из двух полей ввода сторон.
        /// Если тип треугольника равнобедренный - то мы делаем стороны A и B равными
        /// </summary>\
        private void CheckIsoscelesSides(object sender, EventArgs e)
        {
            if (comboBox_triangleType.Text.ToLower() == "равнобедренный")
            {
                input_aSide.Text = ((TextBox)sender).Text;
                input_bSide.Text = ((TextBox)sender).Text;
            }
        }
        
        /// <summary>
        /// Метод, который вызывается при изменении угла. Если треугольник равносторонний, то угол = 180 / 3 = 60
        /// </summary>
        private void input_angle_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_triangleType.Text.ToLower() == "равносторонний")
            {
                input_angle.Text = "60";
            }
        }
        
        /// <summary>
        /// Метод, который вызывается при изменении выбранного поля в ComboBox. При выборе равнобедренного треугольника (равностороннего треугольника)
        /// сторона(ы) B (и C) меняют автоматически свое значение на сторону A (при равностороннем угол меняет значение на 60).
        /// </summary>
        private void comboBox_triangleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_triangleType.Text.ToLower() == "равносторонний")
            {
                input_bSide.Text = input_aSide.Text;
                input_cSide.Text = input_aSide.Text;

                input_angle.Text = "60";
            }

            if (comboBox_triangleType.Text.ToLower() == "равнобедренный")
            {
                input_bSide.Text = input_aSide.Text;
            }
        }
    }
}
