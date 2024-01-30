using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure.Support.Algoritma
{
    public static class GuidCodeGeneration
    {
        private static int sayac = 0;
        public static string GuidCode()
        {

            string charList = "ACDEFGHKLMNPRTXYZ234579";
            int lenght = 8;
            string guidCode = GenerateCodeMethod(charList, lenght);
            return guidCode;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="charList"></param>
        /// <param name="lenght"></param>
        /// <returns></returns>
        private static string GenerateCodeMethod(string charList, int lenght)
        {
            using (RNGCryptoServiceProvider rNGCrypto = new RNGCryptoServiceProvider())
            {
                //RNGCryptoServiceProvider  kriptografik güvenli sayılar üretmeye yardımcı olan bir sınıftır. 
                //nu sınıfı kullanmasam random sınıfını kullanmak durumunda kalacaktım 
                byte[] rndBytes = new byte[lenght];
                rNGCrypto.GetBytes(rndBytes);

                char[] chars = new char[lenght];
                for (int i = 0; i < lenght; i++)
                {
                    int index = rndBytes[i] % (charList.Length - 2);

                    if (charList.Contains(charList[index]))
                    {
                        chars[i] = charList[index];
                    }
                }
                return new string(chars);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="charList">Üretilen kod hangi karakterlerini içereceğini temsil eder</param>
        /// <param name="lenght">Kullanıcın ürettiği kodun uzunluğunu içerir</param>
        /// <param name="quantity">Kullanıcının kaç adet sayı üreteceğini belirttiği değişkeni temsil eder</param>
        /// <returns></returns>
        private static List<string> GenerateCodeList(string charList, int lenght, int quantity)
        {
            string gCode = string.Empty;
            List<string> codelist = new List<string>();
            string guidCode= Guid.NewGuid().ToString("N");
            while (codelist.Count < quantity) {
                for (int i = 0; i < guidCode.Length; i++)
                {
                    while (gCode.Length == lenght)
                    {
                        if (charList.Contains(guidCode[i]))
                        {
                            gCode += guidCode[i];
                        }
                    }
                }
                codelist.Add(gCode);
            }
            return codelist;
        }

    }
}
