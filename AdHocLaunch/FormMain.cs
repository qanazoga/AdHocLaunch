/*
    qanazoga's AdHocLauncher Version 1
    Copyright (C) 2015  qanazoga
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdHocLaunch
{
    public partial class AdHocGui : Form
    {
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        
                    
        public AdHocGui()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //This controls what happens when the button is pressed
        private void buttonStartStop_Click(object sender, EventArgs e)
        {   
            //This set of instructions will happen first, while the button says "START"
            if (buttonStartStop.Text.Equals("START"))
            {
                Regex rg = new Regex("[^a-zA-Z0-9]"); //This is used to check for non-alphanumeric characters.
                String ssid = textBoxSsid.Text;
                String key = textBoxPassword.Text;
                Boolean spacesReady = false; //This value is used to see if the guidelines for spaces are followed
                Boolean lengthReady = false; //This value is used to see if the guidelines for length are followed

                
               
                //Make sure there aren't any troublesome spaces or symbols
                if (ssid.Contains(" ") || key.Contains(" ") || rg.IsMatch(ssid) || rg.IsMatch(key))
                {
                    labelInfoSpaces.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    spacesReady = true;
                    labelInfoSpaces.ForeColor = System.Drawing.Color.Green;
                }

              
                //Make sure the password is a correct length
                if (textBoxPassword.Text.Length < 8 || textBoxPassword.Text.Length > 63)
                {
                    labelInfoLength.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lengthReady = true;
                    labelInfoLength.ForeColor = System.Drawing.Color.Green;
                }
              
                //netsh needs SSID, if you don't give it one I will.
                if (textBoxSsid.Text.Length == 0)
                    ssid = "CavemanCantNameNetworks";


                //Ready to run! :D
                if (spacesReady && lengthReady)
                {
                    //Network renewal
                    //Taking this code out likes to make the program inneffective. If it doesn't cause problems, leave it here.
                    String argumentsReset = "/renew";
                    ProcessStartInfo procReset = new ProcessStartInfo("ipconfig", argumentsReset);
                    procReset.RedirectStandardOutput = true;
                    procReset.UseShellExecute = false;
                    procReset.CreateNoWindow = true;

                    //Network Setup
                    String argumentsNetwork = "wlan set hostednetwork mode=allow ssid=" + ssid;
                    argumentsNetwork += " key=" + key;
             
                    ProcessStartInfo procStartSetup = new ProcessStartInfo("netsh", argumentsNetwork);

                    procStartSetup.RedirectStandardOutput = true;
                    procStartSetup.UseShellExecute = false;
                    procStartSetup.CreateNoWindow = true;

                    //This changes the SSID and Key for the hostednetwork.
                    Process.Start(procStartSetup);

                    buttonStartStop.Text = "STOP"; //Changing the text of the button allows the next set of operations to run.

                    System.Threading.Thread.Sleep(10); //Sleeping the thread is bad, but the program hates you if you don't do it.

                    //Network Launch
                    String argumentsLaunch = "wlan start hostednetwork";
                    ProcessStartInfo procStartLaunch = new ProcessStartInfo("netsh", argumentsLaunch);

                    procStartLaunch.RedirectStandardOutput = true;
                    procStartLaunch.UseShellExecute = false;
                    procStartLaunch.CreateNoWindow = true;

                    //This should launch the network.
                    Process.Start(procStartLaunch);

                    labelStatusActive.ForeColor = System.Drawing.Color.Green;
                   
                    labelStatusActive.Text = "On";
                }
            }

            else if (buttonStartStop.Text.Equals("STOP"))
            {

                //Network Close
                String argumentsClose = "wlan stop hostednetwork";
                ProcessStartInfo procStartClose = new ProcessStartInfo("netsh", argumentsClose);

                procStartClose.RedirectStandardOutput = true;
                procStartClose.UseShellExecute = false;
                procStartClose.CreateNoWindow = true;

                Process.Start(procStartClose);

                buttonStartStop.Text = "...";

                this.Close();
            }
           
        }

        //This can't be removed and doesn't seem to do anything. Just ignore it.
        private void labelInfoLength_Click(object sender, EventArgs e)
        {

        }
    }
}
