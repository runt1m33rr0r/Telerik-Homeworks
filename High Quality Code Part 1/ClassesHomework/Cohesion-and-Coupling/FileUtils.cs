﻿namespace CohesionAndCoupling
{
    using System;

    public static class FileUtils
    {
        private const string Dot = ".";

        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(Dot, StringComparison.Ordinal);

            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);

            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(Dot, StringComparison.Ordinal);

            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);

            return extension;
        }
    }
}