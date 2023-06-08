﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataCorrectnessNamespace
{
    public class DataCorrectness
    {
        public static bool isCheckLogin(string loginUser)
        {
            string patternIsCyrillic = @"^[a-zA-Z0-9]";
            if (string.IsNullOrEmpty(loginUser)) return false;
            if(!Regex.IsMatch(loginUser, patternIsCyrillic)) return false;

            return true;
        }
        public static bool isCheckPassword(string passwordUser)
        {
            if (string.IsNullOrEmpty(passwordUser)) return false;
            if (Regex.IsMatch(passwordUser, @"\p{IsCyrillic}") || passwordUser.Length < 8) return false;

            return true;
        }
    }
}
