using System;
using System.IO;
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
    public partial class ProfilesDialog : Form
    {
        public ProfilesDialog()
        {
            InitializeComponent();
        }

        private void addNewSaveProfileButton_Click(object sender, EventArgs e)
        {
            AddSaveCurrentProfile();
        }

        private void AddSaveCurrentProfile()
        {
            HeatProfile profile = new HeatProfile();
            for (int i = 0; i < profileTable.RowCount - 1; i++)
            {
                try
                {
                    int temp = Int32.Parse(profileTable.Rows[i].Cells[0].Value.ToString());
                    int seconds = Int32.Parse(profileTable.Rows[i].Cells[1].Value.ToString());

                    profile.AddPhase(seconds, temp);
                }
                catch
                {
                    MessageBox.Show("Each phase of the profile must have a duration and temperature.", "Incomplete profile!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if(profile.NumPhases == 0)
            {
                MessageBox.Show("Profile must have at least one phase.", "Incomplete profile!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (String.IsNullOrWhiteSpace(profileNameEdit.Text))
            {
                MessageBox.Show("Profile must have a name before saving.", "Incomplete profile!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                SaveProfileToFile(profile, profileNameEdit.Text);
            }
        }

        private void SaveProfileToFile(HeatProfile profile, String profileName)
        {
            String filepath = profileName + ".txt";
            if(!File.Exists(filepath) || DialogResult.Yes == MessageBox.Show("Profile exists. Overwrite?", "Profile Exists", MessageBoxButtons.YesNo))
            {
                profile.SaveToFile(filepath);
            }
        }
    }
}
