using Day_29_Indian_State_Census_Analyser.DTO;
using Day_29_Indian_State_Census_Analyser.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_29_Indian_State_Census_Analyser
{
    public class CensusAnalyser
    {
        // enum Country Constant for diffrent country.
        public enum Country
        {
            INDIA, US
        }

        Dictionary<string, CensusDTO> dataMap;

        // Loads the census data.
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            dataMap = new CsvAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
