using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CAL_FinalProject
{
    public partial class AlarmClockApp : Form
    {
        private SerialPort serialPort;
        private Timer timer;
        private List<DateTime> alarms;
        private DateTime userSetTime = DateTime.MinValue;
        private DateTime currentTime;

        public AlarmClockApp()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

            alarms = new List<DateTime>();

            serialPort = new SerialPort();
            serialPort.BaudRate = 115200;
            serialPort.DataReceived += serialPort_DataReceived;
        }

        private void AlarmClockApp_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = "COM5";
                serialPort.BaudRate = 115200;
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void SendCurrentTimeToESP32(DateTime currentTime)
        {
            if (serialPort.IsOpen)
            {
                string formattedTime = currentTime.ToString("dd/MM/yyyy HH:mm:ss");
                serialPort.Write($"T:{formattedTime}\n");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;

            if (userSetTime != DateTime.MinValue)
            {
                userSetTime = userSetTime.AddSeconds(1);
                lblClock.Text = userSetTime.ToString("HH:mm:ss dd/MM/yyyy");
            }
            else
            {
                lblClock.Text = currentTime.ToString("HH:mm:ss dd/MM/yyyy");
            }

            CheckAlarms();
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            var setAlarmForm = new SetAlarmForm();
            if (setAlarmForm.ShowDialog() == DialogResult.OK)
            {
                alarms.Add(setAlarmForm.SelectedDateTime);
                UpdateAlarmsListBox();
            }
        }

        private void btnDeleteAlarm_Click(object sender, EventArgs e)
        {
            if (lstAlarms.SelectedIndex != -1)
            {
                alarms.RemoveAt(lstAlarms.SelectedIndex);
                UpdateAlarmsListBox();
            }
        }

        private void UpdateAlarmsListBox()
        {
            lstAlarms.Items.Clear();
            foreach (var alarm in alarms)
            {
                lstAlarms.Items.Add(alarm.ToString("HH:mm:ss dd/MM/yyyy"));
            }
        }

        private void CheckAlarms()
        {
            DateTime currentTime = DateTime.Now;

            foreach (var alarm in alarms.ToList())
            {
                DateTime comparisonTime = (userSetTime != DateTime.MinValue) ? userSetTime : currentTime;

                if (comparisonTime >= alarm && comparisonTime < alarm.AddSeconds(5)) // 5-second window for the alarm
                {
                    serialPort.Write("A");
                    alarms.Remove(alarm);
                    UpdateAlarmsListBox();
                    return;
                }
            }
        }

        private void AlarmClockApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            if (data.StartsWith("T:"))
            {
                string temperatureString = data.Substring(2);
                float temperature;
                if (float.TryParse(temperatureString, out temperature))
                {
                    Invoke(new Action(() => lblTemperature.Text = $"Temperature: {temperature} C"));
                }
            }
        }

        private void btnSnooze_Click(object sender, EventArgs e)
        {
            serialPort.Write("B");
        }

        private void btnOffAlarm_Click(object sender, EventArgs e)
        {
            serialPort.Write("C");
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            var setTimeForm = new SetTimeForm();
            if (setTimeForm.ShowDialog() == DialogResult.OK)
            {
                userSetTime = setTimeForm.SelectedDateTime;
                SendCurrentTimeToESP32(userSetTime);
            }
        }
    }
}
