using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace AppointmentQueue
{
    class Appointment
    {
        public int id;
        public int piority;
        public DateTime startT;
        public DateTime duraT;
        public string patientHN;
        public int requestScan;
        public int paid;
        public DateTime birthDate;
        public int patientstatus;
        public int patientinsu;
        public int scan;
        public int scannum;

        public Appointment(DateTime startT, string HN, string req, string paid, DateTime birthDate, string pstatus, string pinsu, string scan, int scannum, DataTable dt)
        {
            this.startT = startT;
            this.duraT = startT;
            this.patientHN = HN;
            this.requestScan = getRequest(req);
            this.paid = getPaid(paid);
            this.birthDate = birthDate;
            this.patientstatus = getPatientStatus(pstatus);
            this.patientstatus = getPatientInsu(pinsu);
            this.scan = getScanner(scan);
            this.scannum = scannum;
            this.piority = getPiority(dt);
        }
        public int getScanner(string scan)
        {
            int r = 0;
            if (scan.StartsWith("MRI") == true)
                r = 1;
            else if (scan.StartsWith("CT") == true)
                r = 2;
            else if (scan.StartsWith("Ultrasound") == true)
                r = 3;
            return r;
        }
        public int getRequest(string req)
        {
            int r = 1;
            if (req.StartsWith("Brain") == true)
                r = 1;
            else if (req.StartsWith("Spine") == true)
                r = 2;
            else if (req.StartsWith("Joint") == true)
                r = 3;
            else if (req.StartsWith("Musculoskeletal") == true)
                r = 4;
            else if (req.StartsWith("Head&Nesk") == true)
                r = 5;
            else if (req.StartsWith("Orbit") == true)
                r = 6;
            else if (req.StartsWith("Chest") == true)
                r = 7;
            else if (req.StartsWith("Upper Abdomen") == true)
                r = 8;
            else if (req.StartsWith("Lower Abdomen&Pelvis") == true)
                r = 9;
            else if (req.StartsWith("Cardiovascular") == true)
                r = 10;
            else if (req.StartsWith("Heart") == true)
                r = 11;
            return r;
        }
        public int getPaid(string paid)
        {
            int p = 0;
            if (paid.Equals("VIP") == true)
                p = 1;
            else if (paid.Equals("Seepat") == true)
                p = 2;
            else if (paid.Equals("GMC") == true)
                p = 3;
            else if ((paid.Equals("Elective") == true))
                p = 4;
            
            return p;
        }
        public int getPatientStatus(string pstat)
        {
            int ps = 3;
            if (pstat.Equals("Emergency") == true)
                ps = 1;
            else if (pstat.Equals("RPD") == true)
                ps = 2;
            else if (pstat.Equals("OPD") == true)
                ps = 3;
            
            return ps;
        }
        public int getPatientInsu(string pinsu)
        {
            int ps = 1;
            if (pinsu.Equals("no") == true)
                ps = 1;
            else 
                ps = 2;
            return ps;
        }
        private int getPiority(DataTable table)
        {
            int pio = 1;
            foreach (DataRow row in table.Rows)
            {
                if(patientstatus==1 && patientstatus < Convert.ToInt32(row.ItemArray[7].ToString()))
                {//Patientstatus condition
                    pio = Convert.ToInt32(row.ItemArray[1].ToString());
                    break;
                }
                else
                { 
                    if (paid > Convert.ToInt32(row.ItemArray[6].ToString()))
                    {//Paid condition
                        pio = Convert.ToInt32(row.ItemArray[1].ToString()) + 1;
                    }
                    else if(paid == Convert.ToInt32(row.ItemArray[6].ToString()))
                    {//
                        if (patientinsu < Convert.ToInt32(row.ItemArray[8].ToString()))
                        {//Insurance condition
                            pio = Convert.ToInt32(row.ItemArray[1].ToString());
                            break;
                        }
                        else
                        {
                            pio = Convert.ToInt32(row.ItemArray[1].ToString()) + 1;
                        }
                    }
                    else
                    {
                        pio = Convert.ToInt32(row.ItemArray[1].ToString());
                        break;
                    }
               }
            }
            
            return pio;
        }
        private void showTable(DataTable table)
        {
            foreach (DataColumn col in table.Columns)
            {
                Console.Write("{0,-9}\t| ", col.ColumnName);
            }
            Console.WriteLine();

            foreach (DataRow row in table.Rows)
            {
                foreach (Object col in row.ItemArray)
                {
                    int temp = -1;
                    bool check = int.TryParse(col.ToString(), out temp);

                    if (!check) { 
                        Console.Write("{0,-9:dd}\t| ", col);
                    }
                    else
                        Console.Write("{0,-9}\t| ", col);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
