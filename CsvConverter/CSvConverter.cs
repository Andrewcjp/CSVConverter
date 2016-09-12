using System;
using System.IO;
namespace CsvConverter
{

    public class CSVConverter
    {
        public string _weekPrefix = "Week0";
        string _savePath;
        public void ConvertCsvFromStream(Stream stream)
        {
            string fileLoad = LoadFile(stream);
            string[] lines = fileLoad.Split('\n');
            string output = "";
            foreach (string line in lines)
            {
                output += FormatSingleContact(line);
            }
            SaveFile(output);

        }
        //todo validation of the output CSV	
        public void ConvertCSV(string path, string filename)
        {
            string fileLoad = LoadFile(path, filename);
            string[] lines = fileLoad.Split('\n');
            string output = "";
            foreach (string line in lines)
            {
                output += FormatSingleContact(line);
            }
            SaveFile(output);

        }

        bool CheckInput(string fileLoad)
        {
            return true;
        }

        bool ValidateOutput(string fileLoad)
        {
            return true;
        }

        string LoadFile(string path, string fileName)
        {
            _savePath = path;
            StreamReader sr = new StreamReader(fileName);
            string output = sr.ReadToEnd();
            sr.Close();
            return output;
        }

        string LoadFile(Stream fileStream)
        {
            StreamReader streamReader = new StreamReader(fileStream);
            string output = streamReader.ReadToEnd();

            streamReader.Close();
            return output;
        }

        void SaveFile(string data)
        {
            StreamWriter streamWriter = new StreamWriter(_savePath + "/output.csv");
            streamWriter.Write("Name,Given Name,Additional Name,Family Name,Yomi Name,Given Name Yomi,Additional Name Yomi,Family Name Yomi,Name Prefix,Name Suffix,Initials,Nickname,Short Name,Maiden Name,Birthday,Gender,Location,Billing Information,Directory Server,Mileage,Occupation,Hobby,Sensitivity,Priority,Subject,Notes,Group Membership,E-mail 1 - Type,E-mail 1 - Value\n");
            streamWriter.Write(data);
            streamWriter.Close();
        }

        string FormatSingleContact(string dataline)
        {
            if (dataline == "")
            {
                return "";
            }
            string[] delimt = dataline.Split(',');
            string firstName = delimt[2];
            string secondName = delimt[0];
            string course = delimt[3];
            string courseTutor = delimt[4];
            string course2 = delimt[5];
            string courseTutor2 = delimt[6];
            string email = delimt[7];
            //custom rules here

            if (course == "Game Design")
            {
                course += " AM";
            }
            if (course2 == "Game Design")
            {
                course2 += " PM";
            }
            //insert here course am and pm
            string output = string.Format("{0},,,,,,,,,,,,,,,,,,,,,,,,,,* My Contacts ::: {1}({2}) ::: {3}({4}),,{5}\n", firstName + " " + secondName, _weekPrefix + " " + course, courseTutor, _weekPrefix + " " + course2, courseTutor2, email);
            Console.WriteLine(output);
            //Name,Given Name,Additional Name,Family Name,Yomi Name,Given Name Yomi,Additional Name Yomi,Family Name Yomi,Name Prefix,Name Suffix,Initials,Nickname,Short Name,Maiden Name,Birthday,Gender,Location,Billing Information,Directory Server,Mileage,Occupation,Hobby,Sensitivity,Priority,Subject,Notes,Group Membership,E-mail 1 - Type,E-mail 1 - Value
            return output;

        }
    }
}

