using System;
using System.IO;

namespace dotnetcore31_security_unittest
{
    class SecureStoreReader
    {
        internal static string GetCreds(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    return sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
