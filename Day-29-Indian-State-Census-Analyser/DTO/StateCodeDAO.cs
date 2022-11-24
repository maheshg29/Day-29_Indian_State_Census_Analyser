using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_29_Indian_State_Census_Analyser.DTO;
using Day_29_Indian_State_Census_Analyser.POCO;

namespace Day_29_Indian_State_Census_Analyser
{
    public class StateCodeDAO
    {
        public int serialNumber;
        public string stateName;
        public int pin;
        public string stateCode;
    }

    public StateCodeDAO(string v1, string v2, string v3, string v4)
    {
        this.serialNumber = Convert.ToInt32(v1);
        this.stateName = v2;
        this.pin = Convert.ToInt32(v3);
        this.stateCode = v4;
    }
}
