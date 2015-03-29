using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeditationHelper
{
    public partial class FormMain : Form
    {
        SqlConnection _sqlConnection;
        
        Stopwatch _stopWatch = new Stopwatch();
        double _sessionTime;
        
        //sounds
        SoundPlayer _zenBell = new SoundPlayer(Properties.Resources.zenBell);
        SoundPlayer _gong = new SoundPlayer(Properties.Resources.gong);
        

        public FormMain()
        {
            InitializeComponent();

            _sqlConnection = new SqlConnection(
                "user id=meditationHelper;" +
                "password=meditationHelper;" +
                "server=YOHOSUFF-PC\\SQLEXPRESS;" +
                "Trusted_Connection=yes;" +
                "database=MeditationHelper;" +
                "connection timeout=30");
        }

        private void timerStopWatch_Tick(object sender, EventArgs e)
        {
            labelTimeElapsed.Text = _stopWatch.Elapsed.ToString(@"mm\:ss\.f");

            if (_stopWatch.Elapsed.TotalSeconds >= _sessionTime)
            {
                _gong.Play();

                timerStopWatch.Enabled = false;
                _stopWatch.Stop();

                saveSession();

                this.meditationSessionTableAdapter.Fill(this.meditationHelperDataSet.MeditationSession);
            }
        }

        private void saveSession()
        {
            var now = DateTimeOffset.Now;
            var commandText = string.Format("INSERT INTO MeditationSession (Duration,Date) VALUES ({0} ,{1})", _sessionTime, now.Ticks);
            var command = new SqlCommand(commandText, _sqlConnection);
            
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'meditationHelperDataSet.MeditationSession' table. You can move, or remove it, as needed.
            this.meditationSessionTableAdapter.Fill(this.meditationHelperDataSet.MeditationSession);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //extract session time
            var minutes = (int)numericUpDownMinutes.Value;
            var seconds = (int)numericUpDownSeconds.Value;

            var intervalChimeMinutes = (int)numericUpDownIntervalTimeMinutes.Value;
            var intervalChimeSeconds = (int)numericUpDownIntervalTimeSeconds.Value;
            var intervalChimeTime = (intervalChimeMinutes * 60 + intervalChimeSeconds) * 1000;

            _sessionTime = minutes * 60 + seconds;
            _stopWatch.Reset();

            if (checkBoxPlayIntervalChime.Checked)
            {
                timerProgressChimer.Interval = intervalChimeTime;
                timerProgressChimer.Enabled = true;
            }
                
            timerStopWatch.Enabled = true;
            _stopWatch.Start();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "date")
            {
                e.Value = new DateTime((long)e.Value).ToString();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "duration")
            {
                var t = TimeSpan.FromSeconds((long)e.Value);
                e.Value = string.Format("{0:D2}m {1:D2}s", t.Minutes, t.Seconds);
            }
        }

        private void timerProgressChimer_Tick(object sender, EventArgs e)
        {
            _zenBell.Play();

            //don't play the last time
            var msLeft = (_sessionTime - _stopWatch.Elapsed.TotalSeconds) * 1000;
            if (msLeft <= timerProgressChimer.Interval)
                timerProgressChimer.Enabled = false;
        }

        private void checkBoxPlayIntervalChime_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxIntervalChime.Enabled = checkBoxPlayIntervalChime.Checked;
        }
    }
}
