using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

public enum typeOfScanners: int
{
    CT_1,CT_2,MRI,US
}



namespace scheduleCT1
{
    class Appointments
    {
        #region static color
        public static string CT_1 = "#FFDFD991";
        public static string CT_2 = "#99ff33";
        public static string MRI = "#FFDF1111";
        public static string ULTRASOUND = "#0066ff";
        #endregion

        public Calendar.Appointment appt;

        //Use for return appointment
        public Calendar.Appointment getAppointment { get { return appt; }  }

        public Appointments()
        {
            

        }

       

        public bool CreateAppointment(string person, typeOfScanners _typeOfScanners, DateTime dateStart,DateTime dateEnd,string nameTypeOfScanner)
        {
            //Check start time will not greater than or equal end time
            if (dateStart.CompareTo(dateEnd) >= 0 )
            {
                return false;
            }


            this.appt = new Calendar.Appointment();
            this.appt.AllDayEvent = false;
            this.appt.Object = person;
            this.appt.Color = (Color)ColorTranslator.FromHtml(this.getColorScanners (_typeOfScanners));
            this.appt.StartDate = dateStart;
            this.appt.EndDate = dateEnd;
            this.appt.Title = String.Format("ผู้รับบริการ {0} ที่เครื่อง {1}",person, nameTypeOfScanner);
            
            return true;
        }

        public Calendar.Appointment test(int day,Random rnd,int i)
        {
            Calendar.Appointment appt = new Calendar.Appointment();
            appt.Object = "wewewe";
            appt.Color = Color.BlanchedAlmond;
            DateTime date2 = DateTime.Now.Date.AddDays(day).AddHours(rnd.Next(10, 17));
            appt.StartDate = date2;
            appt.EndDate = date2.AddMinutes(i * 15);
            appt.Title = String.Format("Test Appointment {0}", i);
            return appt;
        }


        private string getColorScanners(typeOfScanners scanner)
        {
            switch (scanner.GetHashCode()) {
                case 0 :
                    return CT_1;
                case 1:
                    return CT_2;
                case 2:
                    return MRI;
                case 3:
                    return ULTRASOUND;
                default:
                    return CT_1;

            }
        }

        
    }
}
