using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    /// <summary>
    /// Обслуживающий класс кнопок левой панели приложения.
    /// </summary>
    public class LeftPanelButtons
    {
        public bool AvtoButtonPressed { get; set; }
        public bool AutoRepairPressed { get; set; }
        public bool DriversButtonPressed { get; set; }
        public bool WorkingsDaysButtonPressed { get; set; }
        public bool IncomeButtonPressed { get; set; }

        internal void SetActiveButton(int i)
        {
            switch (i)
            {
                case 1:
                    AvtoButtonPressed = true;

                    AutoRepairPressed = false;
                    DriversButtonPressed = false;
                    WorkingsDaysButtonPressed = false;
                    IncomeButtonPressed = false;
                    break;

                case 2:
                    AutoRepairPressed = true;

                    AvtoButtonPressed = false;                    
                    DriversButtonPressed = false;
                    WorkingsDaysButtonPressed = false;
                    IncomeButtonPressed = false;
                    break;

                case 3:
                    DriversButtonPressed = true;

                    AvtoButtonPressed = false;
                    AutoRepairPressed = false;                    
                    WorkingsDaysButtonPressed = false;
                    IncomeButtonPressed = false;
                    break;

                case 4:
                    WorkingsDaysButtonPressed = true;

                    AvtoButtonPressed = false;
                    AutoRepairPressed = false;
                    DriversButtonPressed = false;                    
                    IncomeButtonPressed = false;
                    break;

                case 5:
                    IncomeButtonPressed = true;

                    AvtoButtonPressed = false;
                    AutoRepairPressed = false;
                    DriversButtonPressed = false;
                    WorkingsDaysButtonPressed = false;
                    break;

            }
        }

        internal int GetActiveButton()
        {            
            if (AvtoButtonPressed)
                return 1;

            if (AutoRepairPressed)
                return 2;

            if (DriversButtonPressed)
                return 3;

            if (WorkingsDaysButtonPressed)
                return 4;

            if (IncomeButtonPressed)
                return 5;

            return 0;
        }
    }
}
