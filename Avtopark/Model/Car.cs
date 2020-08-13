using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    public class Car
    {
        public string ParkNum { get; set; }

        public string CarMark { get; set; }

        public string CarModel { get; set; }

        public string YearCar { get; set; }

        public string VIN { get; set; }

        public string Mileage { get; set; }

        public string GosNumber { get; set; }

        public string SOR { get; set; }

        public string PTS { get; set; }

        public string TaxiLicense { get; set; }

        public string TaxiLicenseDate { get; set; }

        public string TaxiInsurance { get; set; }

        public string TaxiInsuranceDate { get; set; }

        public string CarPrice { get; set; }

        public string TODate { get; set; }

        public string FileTODate { get; set; }

        public void SetDate (string ParkNum, string CarMark, string CarModel, string YearCar, string VIN, string Mileage, string GosNumber,
            string SOR, string PTS, string TaxiLicense, DateTime TaxiLicenseDate, string TaxiInsurance, DateTime TaxiInsuranceDate,
            string CarPrice, DateTime TODate, string FileTO)
        {
            this.ParkNum = ParkNum;
            this.CarMark = CarMark;
            this.CarModel = CarModel;
            this.YearCar = YearCar;
            this.VIN = VIN;
            this.Mileage = Mileage;
            this.GosNumber = GosNumber;
            this.SOR = SOR;
            this.PTS = PTS;
            this.TaxiLicense = TaxiLicense;
            this.TaxiLicenseDate = TaxiLicenseDate.ToShortDateString();
            this.TaxiInsurance = TaxiInsurance;
            this.TaxiInsuranceDate = TaxiInsuranceDate.ToShortDateString();
            this.CarPrice = CarPrice;
            this.TODate = TODate.ToShortDateString();
            this.FileTODate = FileTO;
        }

        public void SetDate(string[] data)
        {
            this.ParkNum = data[0];
            this.CarMark = data[1];
            this.CarModel = data[2];
            this.YearCar = data[3];
            this.VIN = data[4];
            this.Mileage = data[5];
            this.GosNumber = data[6];
            this.SOR = data[7];
            this.PTS = data[8];
            this.TaxiLicense = data[9];
            this.TaxiLicenseDate = data[10];
            this.TaxiInsurance = data[11];
            this.TaxiInsuranceDate = data[12];
            this.CarPrice = data[13];
            this.TODate = data[14];            
        }
    }
}
