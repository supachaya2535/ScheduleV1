using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduleCT1
{
    public class Person
    {
        #region Private Members
        private string _name = "";
        private string _lastname = "";
        private int _age;
        private bool _gender;
        #endregion Private Members

        public Person()
        {

        }
    }

    class Patient : Person
    {
        #region Private Members

        private string _hn = "";
        private int _status;
        private int _insurance;

        #endregion Private Members

        public Patient()
        {


        }
    }
    
    class Doctor : Person
    {
        #region Private Members

        private int _specific;
        
        #endregion Private Members

        public Doctor()
        {


        }
    }
}
