﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AutoVote
{
    public class RasDialManger
    {
        public string entryname { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public RasDialManger()
        {

        }
        public RasDialManger(string entryname, string username, string password)
        {
            this.entryname = entryname;
            this.username = username;
            this.password = password;
        }

        public void Connection()
        {
            try
            {
                Console.WriteLine("連線中...");
                Connection(this.entryname, this.username, this.password);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }

        public void Disconnection()
        {
            try
            {
                Console.WriteLine("斷線中...");
                Disconnection(this.entryname);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }

        public void ReConnection()
        {
            try
            {
                Disconnection(this.entryname);
                Connection(this.entryname, this.username, this.password);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }

        public static void Connection(string entryname, string username, string password)
        {
            try
            {

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "rasdial.exe";
                startInfo.Arguments = string.Format("  {0} {1} {2} ", entryname, username, password);
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }
        public static void Disconnection(string entryname)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "rasdial.exe";
                startInfo.Arguments = string.Format(" {0} /D ", entryname);
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }
        public static void ReConnection(string entryname, string username, string password)
        {
            Disconnection(entryname);
            Connection(entryname, username, password);
        }

        public static string GetPublicIP()
        {
            string public_ip = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.ipify.org");
                //request.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.UTF8);
                    }

                    public_ip = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                public_ip = string.Empty;
            }
            return public_ip;
        }

    }
}
