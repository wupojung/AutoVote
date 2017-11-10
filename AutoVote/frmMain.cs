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

        public frmMain()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            InitializeComponent();
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
                tsslStatus.Text = "Disconnecting...";

                ppoe.Disconnection();


                if (count_current > count_total)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    return;
                }
                count_current++;

                tsslStatus.Text = "Connecting...";
                ppoe.Connection();

                GetRequest(tbURL.Text.Trim());

                timer.Start();
                lbInfo.Text = count_current.ToString() + "/" + count_total.ToString();


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

                    /// Encoding.UTF8.GetString()
                    Console.WriteLine(data);

                    response.Close();
                    readStream.Close();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());

            }
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

        private void tbURL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}