﻿namespace TaskDev1_1
{
    /// <summary>
    /// Class for calculating maximum number of different consecutive symbols
    /// </summary>
    public class SelectorOfMaximumDifferentSymbols
    {
        /// <summary>
        /// Calculates number of different consecutive symbols
        /// </summary>
        /// <param Input string = "consoleString"></param>
        /// <returns>Maximum number of different consecutive symbols</returns>
        public int MaximumNumberOfDifferentSymbols(string consoleString)
        {
            int maxCount = 1;
            int currentCount = 1;

            if (consoleString == null)
            {
                throw new System.NullReferenceException("Console string must be initialized");
            }

            if (consoleString.Length <= 1)
            {
                return consoleString.Length;
            }

            for (int i = 1; i < consoleString.Length; i++)
            {
                if (consoleString[i] != consoleString[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }

                    currentCount = 1;
                }
            }
            return maxCount > currentCount ? maxCount : currentCount;
        }
    }
}