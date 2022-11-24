using Day_29_Indian_State_Census_Analyser.DTO;
using Day_29_Indian_State_Census_Analyser.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_29_Indian_State_Census_Analyser
{
    public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int pin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;
    }

    public CensusDTO(StateCodeDAO stateCodeDao)
    {
        this.serialNumber = stateCodeDao.serialNumber;
        this.stateName = stateCodeDao.stateName;
        this.pin = stateCodeDao.pin;
        this.stateCode = stateCodeDao.stateCode;
    }

    public CensusDTO(CensusDataDAO censusDataDao)
    {
        this.state = censusDataDao.state;
        this.population = censusDataDao.population;
        this.area = censusDataDao.area;
        this.density = censusDataDao.density;
    }

    //public CensusDTO(UCCensusDAO usCensusDAO)
    //{
    //    this.stateCode = usCensusDAO.stateId;
    //    this.stateName = usCensusDAO.stateName;
    //    this.population = usCensusDAO.population;
    //    this.housingUnits = usCensusDAO.housingUnits;
    //    this.totalArea = usCensusDAO.totalArea;
    //    this.waterArea = usCensusDAO.waterArea;
    //    this.landArea = usCensusDAO.landArea;
    //    this.populationDensity = usCensusDAO.populationDensity;
    //    this.housingDensity = usCensusDAO.housingDensity;
    //}
}
