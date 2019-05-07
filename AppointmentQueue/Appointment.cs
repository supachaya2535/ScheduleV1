using System;
using System.Collections.Generic;
 
using System.Text;
using System.Data;
using System.Globalization;

namespace AppointmentQueue
{
    public class Appointment
    {
        public int id;
        public DateTime startT;
        public string patientHN;
        public int requestScan;
        public string period;
        public string appstatus;
        public int scan;
 
        public Appointment(DateTime startT, string HN, string req, string period, string scan)
        {
            this.startT = startT;
            this.patientHN = HN;
            this.requestScan = getRequest(req);
            this.period = period;
            this.appstatus = "Waiting";
            this.scan = getScanner(scan);
           
        }
        
        public static int getScanner(string scan)
        {
            int r = 1;
            if (scan.StartsWith("MRI") == true)
                r = 1;
            else if (scan.StartsWith("CT") == true)
                r = 3;
            else if (scan.StartsWith("Ultrasound") == true)
                r = 4;
            return r;
        }
        public static int getRequest(string req)
        {
            int r = 4;
            if (req.StartsWith("Brain") == true)
                r = 4;
            else if (req.StartsWith("Spine") == true)
                r = 5;
            else if (req.StartsWith("Joint") == true)
                r = 6;
            else if (req.StartsWith("Musculoskeletal") == true)
                r = 7;
            else if (req.StartsWith("Head&Nesk") == true)
                r = 8;
            else if (req.StartsWith("Orbit") == true)
                r = 9;
            else if (req.StartsWith("Chest") == true)
                r = 10;
            else if (req.StartsWith("Upper Abdomen") == true)
                r = 11;
            else if (req.StartsWith("Lower Abdomen&Pelvis") == true)
                r = 12;
            else if (req.StartsWith("Cardiovascular") == true)
                r = 13;
            else if (req.StartsWith("Heart") == true)
                r = 14;
            else if (req.StartsWith("BrainMRA") == true)
                r = 15;
            else if (req.StartsWith("Liver") == true)
                r = 16;
            else if (req.StartsWith("Prostable") == true)
                r = 18;
            else if (req.StartsWith("MRCP") == true)
                r = 19;
            else if (req.StartsWith("Child") == true)
                r = 20;
            else if (req.StartsWith("Pelvis") == true)
                r = 21;
            return r;
        }
        

    }
}
