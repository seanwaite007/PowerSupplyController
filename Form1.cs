using NationalInstruments.Visa;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace Power_Supply_Challenge
{
    public partial class Form1 : Form
    {
        private MessageBasedSession mbSession;

        // variables for Power Supply functions
        private string readVoltage1 = "v1?\n";
        private string readCurrent1 = "i1?\n";
        private string readVoltage2 = "v2?\n";
        private string readCurrent2 = "i2?\n";
        private string selectedString = null;

        ResourceManager resourceManager = new ResourceManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var rmSession = new ResourceManager())
            {
                // iterates through al resources connected to the PC and displays them in a listbox
                var resources = rmSession.Find("(ASRL|GPIB|TCPIP|USB)?*");
                foreach (string resource in resources)
                {
                    availableResources.Items.Add(resource);
                }
            }
        }
        private void availableResources_DoubleClick_1(object sender, EventArgs e)
        {
            // allows the user to select the resource to connect with
            selectedString = (string)availableResources.SelectedItem;
            connectionResource.Text = selectedString;
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Opens the resource from the textbox
                mbSession = (MessageBasedSession)resourceManager.Open(connectionResource.Text);
                MessageBox.Show("Connection Successful");
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Resource selected must be a message-based session");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        // Output 1 On button
        private void button1_Click(object sender, EventArgs e)
        {
            // (OP1 1\n == on) (OP1 0\n == off)
            String outputOn1 = "OP1 1\n";
            mbSession.RawIO.Write(outputOn1);

            powerOn1.BackColor = Color.Green;
            powerOff1.BackColor = Color.Silver;

            // displays current voltage and current once output is turned on
            mbSession.RawIO.Write(readVoltage1);
            actualVoltage1.Text = (mbSession.RawIO.ReadString().Remove(0, 3) + " V ");

            mbSession.RawIO.Write(readCurrent1);
            actualCurrent1.Text = (mbSession.RawIO.ReadString().Remove(0, 3) + " A ");
        }

        // Output 1 Off button
        private void button2_Click(object sender, EventArgs e)
        {
            // turns off output and clears textboxes

            String outputOff1 = "OP1 0\n";
            mbSession.RawIO.Write(outputOff1);

            powerOff1.BackColor = Color.Red;
            powerOn1.BackColor = Color.Silver;

            actualVoltage1.Text = "";
            actualCurrent1.Text = "";
            setVoltage1.Text = "";
            setCurrent1.Text = "";
        }

        // Update Voltage for output 1
        private void submitBtn1_Click(object sender, EventArgs e)
        {
            String voltageChange1 = "v1 " + setVoltage1.Text + "\n";

            string voltageChange = setVoltage1.Text;
            int setVoltage;
            bool validInt = Int32.TryParse(voltageChange, out setVoltage);

            // updates the voltage
            // checks that voltage is between 0-60

            if (validInt)
            {
                if (setVoltage >= 0 && setVoltage <= 60)
                {
                    try
                    {
                        mbSession.RawIO.Write(voltageChange1);
                        mbSession.RawIO.Write(readVoltage1);
                        actualVoltage1.Text = (mbSession.RawIO.ReadString().Remove(0, 3) + " V ");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, please enter a valid voltage between 0-60.");
                }
            }

        }

        // updates the current limit for output 1
        private void changeCurrent1_Click(object sender, EventArgs e)
        {
            String currentChange1 = "i1 " + setCurrent1.Text + "\n";

            string currentChange = setCurrent1.Text;
            int setCurrent;
            bool validInt = Int32.TryParse(currentChange, out setCurrent);

            // changes the current limit 0-20 amps
            if (validInt)
            {
                if (setCurrent >= 0 && setCurrent <= 20)
                {
                    try
                    {
                        mbSession.RawIO.Write(currentChange1);
                        mbSession.RawIO.Write(readCurrent1);
                        actualCurrent1.Text = (mbSession.RawIO.ReadString().Remove(0, 3) + " A ");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                else 
                {
                    MessageBox.Show("Sorry, please enter a valid voltage between 0-20.");
                }
            }

        }

        // output 2 power On button
        private void powerOn2_Click(object sender, EventArgs e)
        {
            String outputOn2 = "OP2 1\n";
            mbSession.RawIO.Write(outputOn2);

            powerOn2.BackColor = Color.Green;
            powerOff2.BackColor = Color.Silver;


            mbSession.RawIO.Write(readVoltage2);
            actualVoltage2.Text = (mbSession.RawIO.ReadString().Remove(0, 3) + " V ");

            mbSession.RawIO.Write(readCurrent2);
            actualCurrent2.Text = (mbSession.RawIO.ReadString().Remove(0, 3) + " A ");
        }

        // Output 2 power off button
        private void powerOff2_Click(object sender, EventArgs e)
        {
            String outputOff2 = "OP2 0\n";
            mbSession.RawIO.Write(outputOff2);

            powerOff2.BackColor = Color.Red;
            powerOn2.BackColor = Color.Silver;

            actualVoltage2.Text = "";
            actualCurrent2.Text = "";
            setVoltage2.Text = "";
            setCurrent2.Text = "";
        }

        // Updates the voltage for output 2
        private void button2_Click_1(object sender, EventArgs e)
        {
            String voltageChange2 = "v2 " + setVoltage2.Text + "\n";

            string voltageChange = setVoltage2.Text;
            int setVoltage;
            bool validInt = Int32.TryParse(voltageChange, out setVoltage);

            // updates the voltage
            // 0-60 volts

            if (validInt)
            {
                if (setVoltage >= 0 && setVoltage <= 60)
                {
                    try
                    {
                        mbSession.RawIO.Write(voltageChange2);
                        mbSession.RawIO.Write(readVoltage2);
                        actualVoltage2.Text = (mbSession.RawIO.ReadString().Remove(0, 3) + " V ");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, please enter a valid voltage between 0-60.");
                }
            }
        }

        // Updates the current for output 2
        private void button1_Click_1(object sender, EventArgs e)
        {
            String currentChange2 = "i2 " + setCurrent2.Text + "\n";

            string currentChange = setCurrent2.Text;
            int setCurrent;
            bool validInt = Int32.TryParse(currentChange, out setCurrent);

            // changes the current limit 0-20 amps
            if (validInt)
            {
                if (setCurrent >= 0 && setCurrent <= 20)
                {
                    try
                    {
                        mbSession.RawIO.Write(currentChange2);
                        mbSession.RawIO.Write(readCurrent2);
                        actualCurrent2.Text = (mbSession.RawIO.ReadString().Remove(0, 3) + " A ");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, please enter a valid voltage between 0-20.");
                }
            }
        }
    }
}