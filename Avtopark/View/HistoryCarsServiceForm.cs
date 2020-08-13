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
    public partial class HistoryTOCarsForm : UserControl
    {
        public HistoryTOCarsForm()
        {
            InitializeComponent();
        }

        public void AddDataToList(string date, string work, string totalAmount, int countItem)
        {
            for (int i = 0; i < countItem; i++)
            {
                ListViewItem newItem = carsHistoryServiceListView.Items.Add(date);
                newItem.SubItems.Add(work);
                newItem.SubItems.Add(totalAmount);
            }
        }

        public void ListIsEmpty()
        {
            ListViewItem newItem = carsHistoryServiceListView.Items.Add("");
            newItem.SubItems.Add("");
            newItem.SubItems.Add("");

            ListViewItem newItem1 = carsHistoryServiceListView.Items.Add("");
            newItem1.SubItems.Add("Автомобиль не проходил ТО или Ремонт.");
            newItem1.SubItems.Add("");
        }

        public void Clear()
        {
            carsHistoryServiceListView.Items.Clear();
        }
    }
}
