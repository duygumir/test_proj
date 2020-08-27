using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Web;
using System.Text;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Data;
using System.Net.Security;

namespace CommonLib
{
    /// <summary>
    /// Summary description for Helpers.
    /// </summary>
    public class Helpers
    {
        
        public Helpers()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        public static string Right(string param, int length)
        {
            if (param.Length > length)
            {
                string result = param.Substring(param.Length - length, length);
                return result;
            }
            else
            {
                return param;
            }
        }
        public static string Left(string param, int length)
        {
            if (param.Length > length)
            {
                string result = param.Substring(0, length);
                return result;
            }
            else
            {
                return param;
            }
        }

        public static int ConvertToInt(object stringNumber)
        {
            int retval = 0;
            try
            {
                retval = Convert.ToInt32(stringNumber);
            }
            catch
            {
            }
            return (retval);
        }


    }
}
