using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMFW
{
    public class Coder
    {
        private static string RemoveFillLetters(string sInputTemp)
        {
            string sOutputTemp = "";

            if (sInputTemp.Substring(0, 1) == "0")
            {
                sInputTemp = sInputTemp.Substring(1, sInputTemp.Length - 1);
                if (sInputTemp.Substring(1, 2) == "%g")
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1);
                        i += 2;
                    }
                }
                else
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1);
                        i += 4;
                    }
                }
            }
            else if (sInputTemp.Substring(0, 1) == "1")
            {
                sInputTemp = sInputTemp.Substring(1, sInputTemp.Length - 1);
                if (sInputTemp.Substring(1, 2) == "§!")
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1);
                        i += 2;
                    }
                }
                else
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1);
                        i += 4;
                    }
                }
            }
            else if (sInputTemp.Substring(0, 1) == "2")
            {
                sInputTemp = sInputTemp.Substring(1, sInputTemp.Length - 1);
                if (sInputTemp.Substring(1, 2) == "b*")
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1);
                        i += 2;
                    }
                }
                else
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1);
                        i += 4;
                    }
                }
            }
            else if (sInputTemp.Substring(0, 1) == "3")
            {
                sInputTemp = sInputTemp.Substring(1, sInputTemp.Length - 1);
                if (sInputTemp.Substring(1, 2) == "1[")
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1);
                        i += 2;
                    }
                }
                else
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1);
                        i += 4;
                    }
                }
            }
            else
            {
                sInputTemp = sInputTemp.Substring(1, sInputTemp.Length - 1);
                if (sInputTemp.Substring(1, 2) == "l/")
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1);
                        i += 2;
                    }
                }
                else
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1);
                        i += 4;
                    }
                }
            }

            return sOutputTemp;
        }
        private static string PasteFillLetters(string sInputTemp, bool bShort = false)
        {
            string sOutputTemp = "";
            Random rnd = new Random();
            int iRandomTemp = rnd.Next(0, 5);
            if (iRandomTemp == 0)
            {
                if (bShort)
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1) + "%g";
                    }
                }
                else
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1) + "b%k§";
                    }
                }
                sOutputTemp = "0" + sOutputTemp;
            }
            else if (iRandomTemp == 1)
            {
                if (bShort)
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1) + "§!";
                    }
                }
                else
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1) + "#!%?";
                    }
                }
                sOutputTemp = "1" + sOutputTemp;
            }
            else if (iRandomTemp == 2)
            {
                if (bShort)
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1) + "b*";
                    }
                }
                else
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1) + "$=#:";
                    }
                }
                sOutputTemp = "2" + sOutputTemp;
            }
            else if (iRandomTemp == 3)
            {
                if (bShort)
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1) + "1[";
                    }
                }
                else
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1) + "%&$§";
                    }
                }
                sOutputTemp = "3" + sOutputTemp;
            }
            else
            {
                if (bShort)
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1) + "l/";
                    }
                }
                else
                {
                    for (int i = 0; i < sInputTemp.Length; i++)
                    {
                        sOutputTemp += sInputTemp.Substring(i, 1) + "-Ä#?";
                    }
                }
                sOutputTemp = "4" + sOutputTemp;
            }

            return sOutputTemp;
        }
        private static string FlipTextOrder(string sInputTemp)
        {
            string sOutputTemp = "";
            for (int i = sInputTemp.Length; i > 0; i--)
            {
                string sTemp = sInputTemp.Substring(i - 1, 1);
                sOutputTemp += sTemp;
            }
            return sOutputTemp;
        }

        private static string SplitnSwitch(string sInputTemp, bool bEncrypt)
        {
            string sOutputTemp = "";
            if ((sInputTemp.Length % 2 == 0) && bEncrypt)
            {
                string sTemp = sInputTemp.Substring(sInputTemp.Length / 2, sInputTemp.Length / 2);
                sOutputTemp += sTemp;
                sTemp = sInputTemp.Substring(0, sInputTemp.Length / 2);
                sOutputTemp += sTemp;
            }
            else if (bEncrypt)
            {
                sInputTemp = "§" + sInputTemp;

                string sTemp = sInputTemp.Substring(sInputTemp.Length / 2, sInputTemp.Length / 2);
                sOutputTemp += sTemp;
                sTemp = sInputTemp.Substring(0, sInputTemp.Length / 2);
                sOutputTemp += sTemp;
            }
            else
            {
                string sTemp = sInputTemp.Substring(sInputTemp.Length / 2, sInputTemp.Length / 2);
                sOutputTemp += sTemp;
                sTemp = sInputTemp.Substring(0, sInputTemp.Length / 2);
                sOutputTemp += sTemp;
                if (sOutputTemp.Substring(0, 1) == "§")
                {
                    sOutputTemp = sOutputTemp.Substring(1, sOutputTemp.Length - 1);

                }
            }
            return sOutputTemp;
        }

        public static string Encrypt(string text)
        {
            bool bEncrypt = true;
            string sOutput = FlipTextOrder(text);
            sOutput = SplitnSwitch(sOutput, bEncrypt);
            sOutput = PasteFillLetters(sOutput);
            sOutput = FlipTextOrder(sOutput);
            return sOutput;
        }

        public static string Decrypt(string text)
        {
            bool bEncrypt = false;
            string sOutput = FlipTextOrder(text);
            sOutput = RemoveFillLetters(sOutput);
            sOutput = SplitnSwitch(sOutput, bEncrypt);
            sOutput = FlipTextOrder(sOutput);
            return sOutput;
        }
    }
}
