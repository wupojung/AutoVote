using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Windows.Forms;

namespace AutoVote
{
    public partial class frmMain : Form
    {
        RasDialManger ppoe = new RasDialManger();

        Timer timer = new Timer();

        int count_total = 0;
        int count_current = 0;
        int count_hit = 0;

        public string last_ip = string.Empty;

        public frmMain()
        {

            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            tsslStatus.Text = "Ready";
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (timer != null) { timer.Stop(); timer = null; }
                count_total = int.Parse(tbCount.Text);
                if (count_total > 0)
                {
                    tsslStatus.Text = "Creating PPPoE Config ...";
                    System.Threading.Thread.Sleep(1000);

                    ppoe = new RasDialManger(tbEntryName.Text.Trim(), tbUsername.Text.Trim(), tbPassword.Text.Trim());


                    timer = new Timer();
                    timer.Interval = int.Parse(tbInterval.Text);
                    timer.Tick += Timer_Tick;
                    timer.Start();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                timer.Stop();

                if (count_current > count_total)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    return;
                }
                ChangeIP();

                count_current++;

                GetRequest(tbURL.Text.Trim());

                timer.Start();
                lbInfo.Text = count_current.ToString() + "/" + count_total.ToString();

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }
        
        private void ChangeIP(int max_retry_count = 10)
        {
            try
            {
                string new_ip = string.Empty;
                int counter = 0;

                if (string.IsNullOrEmpty(last_ip)) { last_ip = RasDialManger.GetPublicIP(); }


                do
                {
                    tsslStatus.Text = "Disconnecting...";
                    ppoe.Disconnection();

                    tsslStatus.Text = "Waiting for 5 second ...";
                    System.Threading.Thread.Sleep(5000);
                    tsslStatus.Text = "Connecting...";
                    ppoe.Connection();

                    new_ip = RasDialManger.GetPublicIP();
                    tssl_ip.Text = new_ip;

                    Console.WriteLine("new ip:" + new_ip);
                    Console.WriteLine("last ip:" + last_ip);

                    counter++;
                    if (counter >= max_retry_count) { break; }

                } while (last_ip.Equals(new_ip));

                last_ip = new_ip;

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }

        private void GetRequest(string urlAddress)
        {
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                request.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);

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
                    string data = readStream.ReadToEnd();

                    if (data.IndexOf("完成") > 0)
                    {
                        count_hit++;
                    }
                    lbHit.Text = string.Format("{0}/{1}", count_hit, count_current);
                    /// Encoding.UTF8.GetString()
                    Console.WriteLine(data);
                    //lbHit

                    response.Close();
                    readStream.Close();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());

            }
        }
        
    }
}