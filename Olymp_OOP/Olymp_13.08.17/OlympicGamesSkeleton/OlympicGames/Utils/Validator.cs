﻿using System;

namespace OlympicGames.Utils
{
    public static class Validator
    {
        public static void ValidateIfNull(this object value, string msg = null)
        {
            if (msg == null)
            {
                msg = $"{value} cannot be null!";
            }

            if (value == null)
            {
                throw new ArgumentNullException(msg);
            }
        }


        public static void ValidateMinAndMaxNumber(this int value, int min, int max = int.MaxValue - 1, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format($"{value} must be between {0} and {1}!", min, max);
            }

            if (value < min || value > max)
            {
                throw new ArgumentException(msg);
            }
        }

        public static void ValidateMinAndMaxLength(this string value, int min, int max = int.MaxValue - 1, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format($"{value} must be between {0} and {1} characters long!", min, max);
            }

            if (value.Length < min || value.Length > max)
            {
                throw new ArgumentException(msg);
            }
        }
    }
}
