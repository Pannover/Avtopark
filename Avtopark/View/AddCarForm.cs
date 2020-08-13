using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtopark
{
    public partial class AddCarForm : UserControl
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        /// <summary>
        /// Возвращает все данные из формы.
        /// </summary>
        /// <returns>Массив строк с данными из формы.</returns>
        public string[] GetAllDataFromForm()
        {
            string[] allDataInForm = new string[]
            {
                ParkNTextBox.Text,
                CarMarkTextBox.Text,
                CarModelTextBox.Text,
                YearCarTextBox.Text,
                VINTextBox.Text,
                MileageTextBox.Text,
                GosNumberTextBox.Text,
                SORTextBox.Text,
                PTSTextBox.Text,
                TaxiLicenseTextBox.Text,
                TaxiLicenseDateTextBox.Text,
                TaxiInsuranceTextBox.Text,
                TODateTextBox.Text,
                CarPriceTextBox.Text,
                TaxiInsuranceDateTextBox.Text 
            };
                
            return allDataInForm;
        }

        /// <summary>
        /// Отчищает форму ввода данных.
        /// </summary>
        public void ClearForm()
        {
            ParkNTextBox.Text = "";
            CarMarkTextBox.Text = "";
            CarModelTextBox.Text = "";
            YearCarTextBox.Text = "";
            VINTextBox.Text = "";
            MileageTextBox.Text = "";
            GosNumberTextBox.Text = "";
            SORTextBox.Text = "";
            PTSTextBox.Text = "";
            TaxiLicenseTextBox.Text = "";
            TaxiLicenseDateTextBox.Text = "";
            TaxiInsuranceTextBox.Text = "";
            TODateTextBox.Text = "";
            CarPriceTextBox.Text = "";
            TaxiInsuranceDateTextBox.Text = "";
        }

        /// <summary>
        /// Проверка корректности ввода паркового номера автомобиля.
        /// </summary>
        /// <param name="carList">Список объектов класса Car.</param>
        /// <returns>true если проверка прошла успешна, иначе false.</returns>
        public bool CheckingInputParkNumber(List<Car> carList)
        {
            if (string.IsNullOrEmpty(ParkNTextBox.Text) &&
                string.IsNullOrWhiteSpace(ParkNTextBox.Text))
            {
                MessageBox.Show("Введите парковый номер автомобиля", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i < carList.Count(); i++)
            {
                if (ParkNTextBox.Text == carList[i].ParkNum)
                {
                    MessageBox.Show("Автомобиль с таким парковым номером уже существует", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Проверка данных введенных пользователем в форму addCarsForm.
        /// </summary>
        /// <returns>true если проверка прошла успешна, иначе false.</returns>
        public bool ValidationOfEnteredValues()
        {
            if (string.IsNullOrEmpty(CarMarkTextBox.Text) &&
                string.IsNullOrWhiteSpace(CarMarkTextBox.Text))
            {
                MessageBox.Show("Введите марку автомобиля", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(CarModelTextBox.Text) &&
                string.IsNullOrWhiteSpace(CarModelTextBox.Text))
            {
                MessageBox.Show("Введите модель автомобиля", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(YearCarTextBox.Text) &&
                string.IsNullOrWhiteSpace(YearCarTextBox.Text))
            {
                MessageBox.Show("Введите год выпуска автомобиля", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(VINTextBox.Text) &&
                string.IsNullOrWhiteSpace(VINTextBox.Text))
            {
                MessageBox.Show("Введите VIN номер автомобиля", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(MileageTextBox.Text) &&
                string.IsNullOrWhiteSpace(MileageTextBox.Text))
            {
                MessageBox.Show("Введите пробег автомобиля", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(GosNumberTextBox.Text) &&
                string.IsNullOrWhiteSpace(GosNumberTextBox.Text))
            {
                MessageBox.Show("Введите пробег автомобиля", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(SORTextBox.Text) &&
                string.IsNullOrWhiteSpace(SORTextBox.Text))
            {
                MessageBox.Show("Введите серию и номер свидетельства о регистрации ТС", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(PTSTextBox.Text) &&
                string.IsNullOrWhiteSpace(PTSTextBox.Text))
            {
                MessageBox.Show("Введите серию и номер ПТС", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(CarPriceTextBox.Text) &&
                string.IsNullOrWhiteSpace(CarPriceTextBox.Text))
            {
                MessageBox.Show("Введите стоимость покупки автомобиля", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int i;

            if (!Int32.TryParse(ParkNTextBox.Text, out i))
            {
                MessageBox.Show("Некорректное значение поля 'Парковый №'", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Int32.TryParse(YearCarTextBox.Text, out i))
            {
                MessageBox.Show("Некорректное значение поля 'Год выпуска ТС'", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (i > DateTime.Now.Year)
            {
                MessageBox.Show("Некорректное значение поля 'Год выпуска ТС', год выпуска не может быть больше текущего года", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Int32.TryParse(MileageTextBox.Text, out i))
            {
                MessageBox.Show("Некорректное значение поля 'Пробег'", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
