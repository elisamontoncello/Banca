﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    internal class Json
    {
        public static string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dati.json");

        public static void EliminaFileJson()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante l'eliminazione del file: {ex.Message}");
            }
        }
    }
}