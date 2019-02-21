using System;

using System.Collections;
using System.Data.SqlServerCe;
using System.IO;

namespace PdaNet
{
    public class ResultsExtractor
    {
        public void getProductoBarra()
        {
            try
            {
                SqlCeCommand command = null;
                StreamReader reader = new StreamReader(new FileStream(@"\My Documents\productoBarra.txt", FileMode.Open, FileAccess.Read));
                ArrayList list = new ArrayList();
                int num = 0;
                while (true)
                {
                    if (reader.Peek() <= -1)
                    {
                        reader.Close();
                        break;
                    }
                    try
                    {
                        num++;
                        command = Connection.getConnection().CreateCommand();
                        command.CommandText = reader.ReadLine();
                        Console.WriteLine("insert -> " + num);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlCeException)
                    {
                    }
                    command.Dispose();
                }
            }
            catch (FileNotFoundException exception3)
            {
                throw exception3;
            }
        }

        public void getProductos()
        {
            try
            {
                SqlCeCommand command = null;
                StreamReader reader = new StreamReader(new FileStream(@"\My Documents\productos.txt", FileMode.Open, FileAccess.Read));
                ArrayList list = new ArrayList();
                int num = 0;
                while (true)
                {
                    if (reader.Peek() <= -1)
                    {
                        reader.Close();
                        break;
                    }
                    string str2 = reader.ReadLine();
                    num++;
                    try
                    {
                        command = Connection.getConnection().CreateCommand();
                        command.CommandText = str2;
                        Console.WriteLine("insert -> " + num);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlCeException)
                    {
                    }
                    command.Dispose();
                }
            }
            catch (FileNotFoundException exception3)
            {
                throw exception3;
            }
        }
    }
}
