using System;
using WSColectorsShop.Data.com.wcs.dao;

namespace WSColectorsShop.Core.com.wcs.deal
{
    public class ColectorsShopDeal
    {
        private readonly string Directory = string.Empty;

        public ColectorsShopDeal(string directory)
        {
            Directory = directory;
        }

        public bool RegisterOnDat(string fileNameDatabase, string filenameAnime, string filenameComic)
        {
            try
            {
                ColectorsShopDao colectorsShopDao = new ColectorsShopDao(Directory);
                return colectorsShopDao.GetDataOfRegistrados(fileNameDatabase, filenameAnime, filenameComic);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}