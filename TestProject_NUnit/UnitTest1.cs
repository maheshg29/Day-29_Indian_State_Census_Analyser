using Day_29_Indian_State_Census_Analyser;
using Day_29_Indian_State_Census_Analyser.DTO;
using Day_29_Indian_State_Census_Analyser.POCO;
using static Day_29_Indian_State_Census_Analyser.CensusAnalyser;

namespace TestProject_NUnit
{
    public class UnitTest1
    {

        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";

        static string indianStateCensusFilePath = @"C:\Users\DELL\source\repos\DLS-RPF-213\Day-29-Indian-State-Census-Analyser\TestProject_NUnit\CSVFiles\IndianPopulation.csv";

        static string indianStateCodeFilePath = @"C:\Users\DELL\source\repos\DLS-RPF-213\Day-29-Indian-State-Census-Analyser\TestProject_NUnit\CSVFiles\IndianState.csv";
        //file path for wrong header csv file
        static string wrongHeaderIndianStateCensusFilePath = @"C:\Users\DELL\source\repos\DLS-RPF-213\Day-29-Indian-State-Census-Analyser\TestProject_NUnit\CSVFiles\CensusWrongStateData.csv";
        //file path for wrong header csv file
        static string wrongHeaderIndianStateCodeFilePath = @"C:\Users\DELL\source\repos\DLS-RPF-213\Day-29-Indian-State-Census-Analyser\TestProject_NUnit\CSVFiles\CensusWrongStateData.csv";
        //file path for wrong delimitercsv file
        static string wrongDelimiterIndianStateCensusFilePath = @"C:\Users\DELL\source\repos\DLS-RPF-213\Day-29-Indian-State-Census-Analyser\TestProject_NUnit\CSVFiles\DelimeIndiaStateCen.csv";
        //file path for wrong delimeter csv file
        static string wrongDelimiterIndianStateCodeFilePath = @"C:\Users\DELL\source\repos\DLS-RPF-213\Day-29-Indian-State-Census-Analyser\TestProject_NUnit\CSVFiles\DelimeIndiaStateCode.csv";
        //file path for wrong state census csv file
        static string wrongIndianStateCensusFilePath = @"C:\Users\DELL\source\repos\DLS-RPF-213\Day-29-Indian-State-Census-Analyser\TestProject_NUnit\CSVFiles\CensusWrongStateData.csv";
        //file path for wrong state code csv file
        static string wrongIndianStateCodeFilePath = @"C:\Users\DELL\source\repos\DLS-RPF-213\Day-29-Indian-State-Census-Analyser\TestProject_NUnit\CSVFiles\WrongIndiaStateCodeData.csv";
        //file path for wrong state file type
        static string wrongIndianStateCensusFileType = @"C:\Users\DELL\source\repos\DLS-RPF-213\Day-29-Indian-State-Census-Analyser\TestProject_NUnit\CSVFiles\IndianState.txt";
        //file path for wrong state code file type
        static string wrongIndianStateCodeFileType = @"C:\Users\DELL\source\repos\DLS-RPF-213\Day-29-Indian-State-Census-Analyser\TestProject_NUnit\CSVFiles\IndianState.txt";

        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;
        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

        // TC 1.1
        // Given the indian census data file when read should return census data count.

        [Test]
        public void GivenIndianCensusDataFile_WhenRead_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }

        // TC 1.2
        // Given wrong census data file path should return file not found exception

        [Test]
        public void GivenWrongIndianCensusDataFile_WhenRead_ShouldReturnCustomException()
        {

            var censusException = Assert.Throws<CensusException>(() => censusAnalyser.LoadCensusData(Country.INDIA, wrongIndianStateCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusException.ExceptionType.FILE_NOT_FOUND, censusException.eType);
        }

        // TC 1.3
        // Given wrong census data file type should re
        // turn custom exception invalid file type

        [Test]
        public void GivenWrongIndianCensusDataFileType_WhenRead_ShouldReturnCustomException()
        {
            var censusException = Assert.Throws<CensusException>(() => censusAnalyser.LoadCensusData(Country.INDIA, wrongIndianStateCensusFileType, indianStateCensusHeaders));
            Assert.AreEqual(CensusException.ExceptionType.INVALID_FILE_TYPE, censusException.eType);
        }

        // TC 1.4
        // Given  census data file  wrong delimiter should return custom exception incorrect delimiter exception

        [Test]
        public void GivenIndianCensusDataFile_WhenNotProper_ShouldReturnException()
        {
            var censusException = Assert.Throws<CensusException>(() => censusAnalyser.LoadCensusData(Country.INDIA, wrongDelimiterIndianStateCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusException.ExceptionType.FILE_NOT_FOUND, censusException.eType);
        }

        // TC 1.5
        // Givens the indian census data file when header not proper should return exception.

        [Test]
        public void GivenIndianCensusDataFile_WhenHeaderNotProper_ShouldReturnException()
        {
            var censusException = Assert.Throws<CensusException>(() => censusAnalyser.LoadCensusData(Country.INDIA, wrongHeaderIndianStateCensusFilePath, indianStateCensusHeaders));

            Assert.AreEqual(CensusException.ExceptionType.INCORRECT_HEADER, censusException.eType);

        }
    }
}