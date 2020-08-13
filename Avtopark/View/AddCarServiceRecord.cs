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
    public partial class AddCarServiceRecord : UserControl
    {
        /// <summary>
        /// Класс формы - добавления записи о прохождении автомобилем ТО или Ремонта.
        /// </summary>
        public AddCarServiceRecord()
        {
            InitializeComponent();
        }

        public bool VerificationOfInputData()
        {
            if (string.IsNullOrEmpty(ServiceWork1TextBox.Text) &&
                string.IsNullOrWhiteSpace(ServiceWork1TextBox.Text))
            {
                MessageBox.Show("Введите в строки 'Произведенные работы', работы по ремонту/ТО автомобиля", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(ServiceDataTextBox.Text) &&
                string.IsNullOrWhiteSpace(ServiceDataTextBox.Text))
            {
                MessageBox.Show("Введите в строки 'Произведенные работы', работы по ремонту/ТО автомобиля", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParse(ServiceDataTextBox.Text, out DateTime date))
            {
                MessageBox.Show("Введите дату ТО/ремонта в формате дд.мм.гггг", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(TotalAmountTextBox.Text) &&
                string.IsNullOrWhiteSpace(TotalAmountTextBox.Text))
            {
                MessageBox.Show("Введите общую стоимость работ", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Int32.TryParse(TotalAmountTextBox.Text, out int amount))
            {
                MessageBox.Show("Введите общую стоимость работ", "Ошибка при вводе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }       
    }
}
