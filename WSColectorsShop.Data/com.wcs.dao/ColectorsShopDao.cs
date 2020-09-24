using System;
using System.IO;

namespace WSColectorsShop.Data.com.wcs.dao
{
    public class ColectorsShopDao
    {
        private readonly string Directory = string.Empty;

        public ColectorsShopDao(string directory)
        {
            Directory = directory;
        }

        public bool GetDataOfRegistrados(string fileNameDatabase, string filenameAnime, string filenameComic)
        {
            try
            {
                StreamReader sr = new StreamReader(Directory + fileNameDatabase);
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (line.Contains("Valor"))
                    {
                        RegisterOnDat(line, filenameAnime);
                        RegisterOnDat(line, filenameComic);
                    }
                    else
                    {
                        if (line.Contains("V"))
                        {
                            //Anime
                            RegisterOnDat(line, filenameAnime);
                        }
                        else
                        {
                            //Comic
                            RegisterOnDat(line, filenameComic);
                        }
                    }                    
                    line = sr.ReadLine();
                }
                RegisterOnDat("", filenameAnime);
                RegisterOnDat("", filenameComic);
                sr.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                throw;
            }
        }

        public void RegisterOnDat(string data, string fileName)
        {
            try
            {
                File.AppendAllText(Directory + fileName, data + Environment.NewLine);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}