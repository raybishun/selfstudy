using System;
using System.IO;

namespace GraphServiceClientPrototype
{
    class ManageUserSecrets
    {
        public static string GetAccessToken(string path)
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
