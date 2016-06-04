using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToastTest
{
    public partial class TimerSetupForm : Form
    {
        public int SecondsOnTimer { get; set; }

        public TimerSetupForm()
        {
            InitializeComponent();
        }

        private void timeEntryBox_ValueChanged(object sender, EventArgs e)
        {
            SecondsOnTimer = timeEntryBox.Value.Minute * 60 + timeEntryBox.Value.Second;
        }
    }
}
