using System;
using WSColectorsShop.com.wcs.conf;
using WSColectorsShop.Core.com.wcs.deal;

namespace WSColectorsShop
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        private static void Main()
        {
            try
            {
                ColectorsShopDeal colectorsShopDeal = new ColectorsShopDeal(Connection.GetValueOfAppSettings("directory"));
                colectorsShopDeal.RegisterOnDat(Connection.GetValueOfAppSettings("fileNameDatabase"), Connection.GetValueOfAppSettings("filenameAnime"),
                    Connection.GetValueOfAppSettings("filenameComic"));
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}