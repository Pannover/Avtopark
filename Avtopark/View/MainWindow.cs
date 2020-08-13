using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Avtopark
{
    public partial class MainWindow : Form
    {
        private SqlConnection sqlConnection = null;
        List<Car> carList;
        List<CarService> carServices;
        int SelectedItem;                       // Выделенный элемент в списке ListView полсе закрытия вкладки "Изменить" 
        LeftPanelButtons leftPanelButtons;

        public MainWindow()
        {
            InitializeComponent();

            YellowPanel.Visible = true;
            YellowPanel.Height = AvtoButton.Height;
            YellowPanel.Top = AvtoButton.Top;
            addCarForm.Hide();
            historyTOCarsForm.Hide();
            addCarServiceRecord.Hide();
            leftPanelButtons = new LeftPanelButtons();
            leftPanelButtons.SetActiveButton(1);
            HideButton();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {            
            LoadCarsData();            
        }

        private async void LoadCarsData()
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Denis\Source\Repos\Avtopark\Avtopark\Database1.mdf; Integrated Security = True; MultipleActiveResultSets = True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Cars]", sqlConnection);

            carList = new List<Car>();          

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    Car car = new Car();

                    car.SetDate(Convert.ToString(sqlReader["ParkNum"]),
                    Convert.ToString(sqlReader["CarMark"]),
                    Convert.ToString(sqlReader["CarModel"]),
                    Convert.ToString(sqlReader["YearCar"]),
                    Convert.ToString(sqlReader["VIN"]),
                    Convert.ToString(sqlReader["Mileage"]),
                    Convert.ToString(sqlReader["GosNumber"]),
                    Convert.ToString(sqlReader["SOR"]),
                    Convert.ToString(sqlReader["PTS"]),
                    Convert.ToString(sqlReader["TaxiLicense"]),
                    Convert.ToDateTime(sqlReader["TaxiLicenseDate"]),
                    Convert.ToString(sqlReader["TaxiInsurance"]),
                    Convert.ToDateTime(sqlReader["TaxiInsuranceDate"]),
                    Convert.ToString(sqlReader["CarPrice"]),
                    Convert.ToDateTime(sqlReader["TODate"]),
                    Convert.ToString(sqlReader["FileTODate"]));                    

                    ListViewItem newItem = CarsListView.Items.Add(car.ParkNum);
                    newItem.SubItems.Add(car.CarMark);
                    newItem.SubItems.Add(car.CarModel);                    
                    newItem.SubItems.Add(car.GosNumber);
                    newItem.SubItems.Add(car.YearCar);
                    newItem.SubItems.Add(car.Mileage);
                    newItem.SubItems.Add(car.TODate);

                    carList.Add(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (CarsListView.Items.Count != 0)
                {
                    CarsListView.Items[0].Focused = true;
                    CarsListView.Items[0].Selected = true;
                }

                if (sqlReader != null)
                    sqlReader.Close();
            }            
        }

        private async void UpdateDataInCarsListView()
        {
            CarsListView.Items.Clear();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Cars]", sqlConnection);

            carList.Clear();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    Car car = new Car();

                    car.SetDate(Convert.ToString(sqlReader["ParkNum"]),
                    Convert.ToString(sqlReader["CarMark"]),
                    Convert.ToString(sqlReader["CarModel"]),
                    Convert.ToString(sqlReader["YearCar"]),
                    Convert.ToString(sqlReader["VIN"]),
                    Convert.ToString(sqlReader["Mileage"]),
                    Convert.ToString(sqlReader["GosNumber"]),
                    Convert.ToString(sqlReader["SOR"]),
                    Convert.ToString(sqlReader["PTS"]),
                    Convert.ToString(sqlReader["TaxiLicense"]),
                    Convert.ToDateTime(sqlReader["TaxiLicenseDate"]),
                    Convert.ToString(sqlReader["TaxiInsurance"]),
                    Convert.ToDateTime(sqlReader["TaxiInsuranceDate"]),
                    Convert.ToString(sqlReader["CarPrice"]),
                    Convert.ToDateTime(sqlReader["TODate"]),
                    Convert.ToString(sqlReader["FileTODate"]));

                    carList.Add(car);

                    ListViewItem newItem = CarsListView.Items.Add(car.ParkNum);
                    newItem.SubItems.Add(car.CarMark);
                    newItem.SubItems.Add(car.CarModel);
                    newItem.SubItems.Add(car.GosNumber);
                    newItem.SubItems.Add(car.YearCar);
                    newItem.SubItems.Add(car.Mileage);
                    newItem.SubItems.Add(car.TODate);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (CarsListView.Items.Count != 0)
                {
                    CarsListView.Items[SelectedItem].Focused = true;
                    CarsListView.Items[SelectedItem].Selected = true;
                }

                if (sqlReader != null)
                    sqlReader.Close();
            }        
        }

        public async void AddCarDataOnDB()
        {

            SqlCommand command = new SqlCommand("INSERT INTO [Cars] (ParkNum, CarMark, CarModel, YearCar, VIN, Mileage, GosNumber, SOR, PTS, TaxiLicense, TaxiLicenseDate, TaxiInsurance, TaxiInsuranceDate, CarPrice, TODate) " +
                            "VALUES(@ParkNum, @CarMark, @CarModel, @YearCar, @VIN, @Mileage, @GosNumber, @SOR, @PTS, @TaxiLicense, @TaxiLicenseDate, @TaxiInsurance, @TaxiInsuranceDate, @CarPrice, @TODate)", sqlConnection);

            command.Parameters.AddWithValue("ParkNum", Convert.ToInt32(addCarForm.ParkNTextBox.Text));
            command.Parameters.AddWithValue("CarMark", addCarForm.CarMarkTextBox.Text);
            command.Parameters.AddWithValue("CarModel", addCarForm.CarModelTextBox.Text);
            command.Parameters.AddWithValue("YearCar", Convert.ToInt32(addCarForm.YearCarTextBox.Text));
            command.Parameters.AddWithValue("VIN", addCarForm.VINTextBox.Text);
            command.Parameters.AddWithValue("Mileage", Convert.ToInt32(addCarForm.MileageTextBox.Text));
            command.Parameters.AddWithValue("GosNumber", addCarForm.GosNumberTextBox.Text);
            command.Parameters.AddWithValue("SOR", addCarForm.SORTextBox.Text);
            command.Parameters.AddWithValue("PTS", addCarForm.PTSTextBox.Text);
            command.Parameters.AddWithValue("TaxiLicense", addCarForm.TaxiLicenseTextBox.Text);
            command.Parameters.AddWithValue("TaxiLicenseDate", Convert.ToDateTime(addCarForm.TaxiLicenseDateTextBox.Text));
            command.Parameters.AddWithValue("TaxiInsurance", addCarForm.TaxiInsuranceTextBox.Text);
            command.Parameters.AddWithValue("TaxiInsuranceDate", Convert.ToDateTime(addCarForm.TaxiInsuranceDateTextBox.Text));
            command.Parameters.AddWithValue("CarPrice", Convert.ToInt32(addCarForm.CarPriceTextBox.Text));
            command.Parameters.AddWithValue("TODate", Convert.ToDateTime(addCarForm.TODateTextBox.Text));

            await command.ExecuteNonQueryAsync();

            addCarForm.ClearForm();
        }

        private async void RenameItemCarInDB()
        {
            if (addCarForm.ValidationOfEnteredValues())
            {
                ListViewItem item = CarsListView.SelectedItems[0];

                int i = item.Index;
                SelectedItem = i;               // Индекс выделенного элемента в CarsListView после операций Добавить/Изменить/Удалить

                carList[i].SetDate(addCarForm.GetAllDataFromForm()); // Из формы addCarForm все данные копируем в объект car.

                SqlCommand command = new SqlCommand("UPDATE [Cars] SET [ParkNum] = @ParkNum, [CarMark] = @CarMark, [CarModel] = @CarModel, " +
                    "[YearCar] = @YearCar, [VIN] = @VIN, [Mileage] = @Mileage, [GosNumber] = @GosNumber, [SOR] = SOR, [PTS] = @PTS, " +
                    "[TaxiLicense] = @TaxiLicense, [TaxiLicenseDate] = @TaxiLicenseDate, [TaxiInsurance] = @TaxiInsurance, " +
                    "[TaxiInsuranceDate] = @TaxiInsuranceDate, [CarPrice] = @CarPrice, [TODate] = @TODate WHERE [ParkNum] = @ParkNum", sqlConnection);

                command.Parameters.AddWithValue("ParkNum", Convert.ToInt32(carList[i].ParkNum));
                command.Parameters.AddWithValue("CarMark", carList[i].CarMark);
                command.Parameters.AddWithValue("CarModel", carList[i].CarModel);
                command.Parameters.AddWithValue("YearCar", Convert.ToInt32(carList[i].YearCar));
                command.Parameters.AddWithValue("VIN", carList[i].VIN);
                command.Parameters.AddWithValue("Mileage", Convert.ToInt32(carList[i].Mileage));
                command.Parameters.AddWithValue("GosNumber", carList[i].GosNumber);
                command.Parameters.AddWithValue("SOR", carList[i].SOR);
                command.Parameters.AddWithValue("PTS", carList[i].PTS);
                command.Parameters.AddWithValue("TaxiLicense", carList[i].TaxiLicense);
                command.Parameters.AddWithValue("TaxiLicenseDate", Convert.ToDateTime(carList[i].TaxiLicenseDate));
                command.Parameters.AddWithValue("TaxiInsurance", carList[i].TaxiInsurance);
                command.Parameters.AddWithValue("TaxiInsuranceDate", Convert.ToDateTime(carList[i].TaxiInsuranceDate));
                command.Parameters.AddWithValue("CarPrice", Convert.ToInt32(carList[i].CarPrice));
                command.Parameters.AddWithValue("TODate", Convert.ToDateTime(carList[i].TODate));

                await command.ExecuteNonQueryAsync();

                addCarForm.ParkNTextBox.Enabled = true;                
            }
        }

        private async void DeleteCarInDB()
        {
            if (CarsListView.SelectedItems.Count != 0)
            {
                string message = "Вы уверенны что хотите удалить автомобиль из базы данных?";
                string caption = "Удаление автомобиля из базы данных";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ListViewItem item = CarsListView.SelectedItems[0];
                    int i = item.Index;

                    SqlCommand command = new SqlCommand("DELETE FROM [Cars] WHERE [ParkNum] = @ParkNum", sqlConnection);
                    command.Parameters.AddWithValue("ParkNum", Convert.ToInt32(carList[i].ParkNum));
                    await command.ExecuteNonQueryAsync();

                    UpdateDataInCarsListView();
                }
            }
        }               

        #region Кнопки        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();

            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }        

        /// <summary>
        /// Обработчик кнопки 'Автомобили' на левой панели.
        /// </summary>        
        private void AvtoButton_Click(object sender, EventArgs e)
        {            
            YellowPanel.Height = AvtoButton.Height;
            YellowPanel.Top = AvtoButton.Top;

            if (leftPanelButtons.GetActiveButton() == 2)
            {
                historyTOCarsForm.Hide();
                panel5.Show();
                OpenCarServiceRecordForm_Button.Visible = false;
            }

            leftPanelButtons.SetActiveButton(1);

        }

        /// <summary>
        /// Обработчик кнопки 'ТО / Ремонт' на левой панели.
        /// </summary>        
        private void AutoRepairButton_Click(object sender, EventArgs e)
        {
            YellowPanel.Height = AutoRepairButton.Height;
            YellowPanel.Top = AutoRepairButton.Top;

            leftPanelButtons.SetActiveButton(2);
            historyTOCarsForm.Show();

            carServices = new List<CarService>();
            if (carServices.Count == 0)
            {
                historyTOCarsForm.Clear();
                historyTOCarsForm.ListIsEmpty();
                OpenCarServiceRecordForm_Button.Visible = true;
                OpenCarServiceRecordForm_Button.BringToFront();
            }

            if (addCarServiceRecord.Visible)
                OpenCarServiceRecordForm_Button.Visible = false;

            panel5.Hide();
        }

        /// <summary>
        /// Обработчик кнопки 'Водители' на левой панели.
        /// </summary>        
        private void DriversButton_Click(object sender, EventArgs e)
        {
            YellowPanel.Height = DriversButton.Height;
            YellowPanel.Top = DriversButton.Top;

            if (leftPanelButtons.GetActiveButton() == 2)
            {
                historyTOCarsForm.Hide();
                panel5.Show();
                OpenCarServiceRecordForm_Button.Visible = false;
            }

            leftPanelButtons.SetActiveButton(3);
        }

        /// <summary>
        /// Обработчик кнопки 'Смены' на левой панели.
        /// </summary>        
        private void WorkingsDaysButton_Click(object sender, EventArgs e)
        {
            YellowPanel.Height = WorkingsDaysButton.Height;
            YellowPanel.Top = WorkingsDaysButton.Top;

            if (leftPanelButtons.GetActiveButton() == 2)
            {
                historyTOCarsForm.Hide();
                panel5.Show();
                OpenCarServiceRecordForm_Button.Visible = false;
            }

            leftPanelButtons.SetActiveButton(4);
        }

        /// <summary>
        /// Обработчик кнопки 'Доход' на левой панели.
        /// </summary>        
        private void IncomeButton_Click(object sender, EventArgs e)
        {
            YellowPanel.Height = IncomeButton.Height;
            YellowPanel.Top = IncomeButton.Top;

            if (leftPanelButtons.GetActiveButton() == 2)
            {
                historyTOCarsForm.Hide();
                panel5.Show();
                OpenCarServiceRecordForm_Button.Visible = false;
            }

            leftPanelButtons.SetActiveButton(5);
        }

        #endregion

        private void CarsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarsListView.SelectedItems.Count != 0)
            {
                if (leftPanelButtons.GetActiveButton() == 1)                // Вкладка 'Автомобили'
                {
                    ListViewItem item = CarsListView.SelectedItems[0];

                    int i = item.Index;

                    SORLabel.Text = carList[i].SOR;
                    PTSLabel.Text = carList[i].PTS;
                    CarPriceLabel.Text = carList[i].CarPrice;
                    LicenseLabel.Text = carList[i].TaxiLicense;
                    LicenseDateLabel.Text = carList[i].TaxiLicenseDate;
                    InsLabel.Text = carList[i].TaxiInsurance;
                    InsDateLabel.Text = carList[i].TaxiInsuranceDate;
                }
            }            
        }

        #region Кнопки на главной форме: 'Добавить', 'Изменить', 'Удалить'.
        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCarButton.Hide();
            RenameCarButton.Hide();
            DelCarButton.Hide();

            addCarForm.Show();

            AddCarOnDBbutton.Visible = true;
            NoSaveOnDBbutton.Visible = true;
        }

        private void RenameCarButton_Click(object sender, EventArgs e)
        {
            if (CarsListView.Items.Count != 0)
            {
                if (CarsListView.SelectedItems.Count != 0)
                {
                    AddCarButton.Hide();
                    RenameCarButton.Hide();
                    DelCarButton.Hide();

                    addCarForm.label1.Text = "Изменить данные";
                    addCarForm.Show();
                    addCarForm.ParkNTextBox.Enabled = false;

                    AddCarOnDBbutton.Text = "Изменить";
                    AddCarOnDBbutton.Visible = true;
                    NoSaveOnDBbutton.Visible = true;

                    ListViewItem item = CarsListView.SelectedItems[0];

                    int i = item.Index;

                    addCarForm.ParkNTextBox.Text = carList[i].ParkNum;
                    addCarForm.CarMarkTextBox.Text = carList[i].CarMark;
                    addCarForm.CarModelTextBox.Text = carList[i].CarModel;
                    addCarForm.YearCarTextBox.Text = carList[i].YearCar;
                    addCarForm.VINTextBox.Text = carList[i].VIN;
                    addCarForm.MileageTextBox.Text = carList[i].Mileage;
                    addCarForm.GosNumberTextBox.Text = carList[i].GosNumber;
                    addCarForm.SORTextBox.Text = carList[i].SOR;
                    addCarForm.PTSTextBox.Text = carList[i].PTS;
                    addCarForm.TaxiLicenseTextBox.Text = carList[i].TaxiLicense;
                    addCarForm.TaxiLicenseDateTextBox.Text = carList[i].TaxiLicenseDate;
                    addCarForm.TaxiInsuranceTextBox.Text = carList[i].TaxiInsurance;
                    addCarForm.TaxiInsuranceDateTextBox.Text = carList[i].TaxiInsuranceDate;
                    addCarForm.CarPriceTextBox.Text = carList[i].CarPrice;
                    addCarForm.TODateTextBox.Text = carList[i].TODate;                    
                }
                else
                    MessageBox.Show("Укажите какой элемент из списка вы хотите изменить.", "Элемент списка не выделен!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DelCarButton_Click(object sender, EventArgs e)
        {
            DeleteCarInDB();
        }

        #endregion
                
        private void addCarForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!addCarForm.Visible)
            {
                AddCarButton.Visible = true;
                RenameCarButton.Visible = true;
                DelCarButton.Visible = true;
            }
        }

        #region Кнопки на форме addCarForm
        private void AddCarOnDB_Button_Click(object sender, EventArgs e)
        {
            if (AddCarOnDBbutton.Text == "Изменить")
            {
                RenameItemCarInDB();
                UpdateDataInCarsListView();
                                
                addCarForm.Hide();

                AddCarOnDBbutton.Text = "Сохранить";
                addCarForm.label1.Text = "Добавить автомобиль";

                AddCarOnDBbutton.Visible = false;
                NoSaveOnDBbutton.Visible = false;
                addCarForm.ParkNTextBox.Enabled = true;
            }

            else
            {
                if (addCarForm.CheckingInputParkNumber(carList) && addCarForm.ValidationOfEnteredValues())
                {
                    AddCarDataOnDB();
                    UpdateDataInCarsListView();

                    addCarForm.Hide();

                    AddCarOnDBbutton.Visible = false;
                    NoSaveOnDBbutton.Visible = false;
                }
            }
        }        

        private void NoSaveOnDBbutton_Click(object sender, EventArgs e)
        {
            switch (AddCarOnDBbutton.Text)
            {
                case "Сохранить":
                        addCarForm.Hide();

                        AddCarOnDBbutton.Visible = false;
                        NoSaveOnDBbutton.Visible = false;

                        addCarForm.ClearForm();
                        break;
                    
                case "Изменить":                    
                        addCarForm.Hide();

                        AddCarOnDBbutton.Visible = false;
                        NoSaveOnDBbutton.Visible = false;

                        AddCarOnDBbutton.Text = "Сохранить";
                        addCarForm.label1.Text = "Добавить автомобиль";

                        addCarForm.ClearForm();

                        addCarForm.ParkNTextBox.Enabled = true;
                        break;                                 
            }
        }
        #endregion

        /// <summary>
        /// Обработчик кнопки 'Добавить' открывающей форму 'Добавить запись о ТО / ремонте автомобиля'.
        /// </summary>       
        private void OpenCarServiceRecordForm_Button_Click(object sender, EventArgs e)
        {
            OpenCarServiceRecordForm_Button.Visible = false;
            addCarServiceRecord.Show();
            addCarServiceRecord.BringToFront();            
            ShowButton();
        }

        private void addCarServiceRecord_VisibleChanged(object sender, EventArgs e)
        {
            HideButton();
        }

        /// <summary>
        /// Обрадотчик кнопки 'Добавить' на форме 'Добавить запись о ТО / ремонте автомобиля'.
        /// </summary>        
        private void AddServiceRecordInFileButton_Click(object sender, EventArgs e)
        {
            addCarServiceRecord.Hide();

            OpenCarServiceRecordForm_Button.Visible = true;
            OpenCarServiceRecordForm_Button.BringToFront();
        }

        /// <summary>
        /// Обрадотчик кнопки 'Отмена' на форме 'Добавить запись о ТО / ремонте автомобиля'.
        /// </summary>    
        private void NonServiceRecordSaveButton_Click(object sender, EventArgs e)
        {
            addCarServiceRecord.Hide();

            OpenCarServiceRecordForm_Button.Visible = true;
            OpenCarServiceRecordForm_Button.BringToFront();
        }
    }
}
