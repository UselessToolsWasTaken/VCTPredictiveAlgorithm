using System;
using System.IO;
using CsvHelper;
using System.Windows.Forms;
using System.Globalization;

namespace VCTWinnerPredictor
{
    internal class DataLoad
    {

        public int teamALifetimeWins;
        public int teamARecentWins;
        public int teamARosterChange;
        public int teamARanking;


        public int teamBLifetimeWins;
        public int teamBRecentWins;
        public int teamBRosterChange;
        public int teamBRanking;

        string executablePath;
        string aFilePath;
        string bFilePath;

        /*
            100_Thieves_Data.txt
            Cloud9_Data.txt
            Evil_Geniuses_Data.txt
            FURIA_Data.txt
            KRU_Esports_Data.txt
            Leviatan_Data.txt
            LOUD_Data.txt
            MIBR_Data.txt
            NRG_Esports_Data.txt
            Sentinels_Data.txt
            G2_Esports_Data.txt
        */ // Team Names

        //Team indexes go from 0 to 10

        public void executableManager()
        {
            Form1 form = new Form1();
            /*try
            {
                executablePath = Application.ExecutablePath;
                switch (form.aIndex)
                {
                    case 0:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "100_Thieves_Data.txt");
                        break;
                    case 1:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "Cloud9_Data.txt");
                        break;
                    case 2:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "Evil_Geniuses_Data.txt");
                        break;
                    case 3:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "FURIA_Data.txt");
                        break;
                    case 4:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "KRU_Esports_Data.txt");
                        break;
                    case 5:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "Leviatan_Data.txt");
                        break;
                    case 6:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "LOUD_Data.txt");
                        break;
                    case 7:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "MIBR_Data.txt");
                        break;
                    case 8:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "NRG_Esports_Data.txt");
                        break;
                    case 9:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "Sentinels_Data.txt");
                        break;
                    case 10:
                        aFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "G2_Esports_Data.txt");
                        break;
                }
                switch (form.bIndex)
                {
                    case 0:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "100_Thieves_Data.txt");
                        break;
                    case 1:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "Cloud9_Data.txt");
                        break;
                    case 2:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "Evil_Geniuses_Data.txt");
                        break;
                    case 3:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "FURIA_Data.txt");
                        break;
                    case 4:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "KRU_Esports_Data.txt");
                        break;
                    case 5:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "Leviatan_Data.txt");
                        break;
                    case 6:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "LOUD_Data.txt");
                        break;
                    case 7:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "MIBR_Data.txt");
                        break;
                    case 8:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "NRG_Esports_Data.txt");
                        break;
                    case 9:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "Sentinels_Data.txt");
                        break;
                    case 10:
                        bFilePath = Path.Combine(Path.GetDirectoryName(executablePath), "G2_Esports_Data.txt");
                        break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("There are no correct files in directory", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Does this even work? Wont this just crash out the app?
            }*/ //Keep this noted for now. I'm going to try and take the data from a CSV as it would be more convenient this way

            try
            {
                string csvFilePath = "yourfile.csv";
                var data = ReadCsvFile(csvFilePath);
            }catch (Exception ex)
            {
                MessageBox.Show("There are no correct files in directory", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //LoadTeamData(aFilePath, bFilePath); 
        }

        static double[][] ReadCsvFile(string filePath)
        {
            using(var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<dynamic>();

                int rowCount = 11;
                int colCount = 4;

                double[][] data = new double[rowCount][];
                for (int i = 0; 1< rowCount; i++)
                {
                    data[i] = new double[colCount];
                }

                int row = 0;
                foreach (var record in records)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        double value = Convert.ToDouble(record[col]);
                        data[row][col] = value;
                    }
                    row++;
                }
                return data;
            }
        }

        /*public void LoadTeamData(string teamAFilePath, string teamBFilePath)
        {
            string[] teamAData = File.ReadAllLines(teamAFilePath);
            if (teamAData.Length >= 4)
            {
                teamALifetimeWins = int.Parse(teamAData[0]);
                teamARecentWins = int.Parse(teamAData[1]);
                teamARosterChange = int.Parse(teamAData[2]);
                teamARanking = int.Parse(teamAData[3]);
            }
            else
            {
            }

            // Load data for Team B
            string[] teamBData = File.ReadAllLines(teamBFilePath);
            if (teamBData.Length >= 4)
            {
                teamBLifetimeWins = int.Parse(teamBData[0]);
                teamBRecentWins = int.Parse(teamBData[1]);
                teamBRosterChange = int.Parse(teamBData[2]);
                teamBRanking = int.Parse(teamBData[3]);
            }
            else
            {
            }
        }*/
    }
}
