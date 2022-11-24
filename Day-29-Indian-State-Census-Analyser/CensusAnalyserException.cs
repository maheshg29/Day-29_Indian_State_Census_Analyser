﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_29_Indian_State_Census_Analyser
{
    public class CensusAnalyserException : Exception
    {

        public ExceptionType exception;

        // enum ExceptionType for diffrent exception which is constant
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_HEADER, INCORRECT_DELIMITER, NO_SUCH_COUNTRY
        }

        // Parametrized Constructor Initializes a new instance of the class.
        public CensusAnalyserException(string message, ExceptionType exception) : base(message)
        {
            this.exception = exception;
        }
    }
}
