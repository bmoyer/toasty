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
        String PROFILES_DIRECTORY = "profiles";
        public ProfilesDialog()
        {
            InitializeComponent();
            InitDialog();
        }

        private void InitDialog()
        {
            Directory.CreateDirectory(PROFILES_DIRECTORY);
            LoadProfileList();
        }

        private void addNewSaveProfileButton_Click(object sender, EventArgs e)
        {
            AddSaveCurrentProfile();
        }

        private void AddSaveCurrentProfile()
        {
            // Create a profile object from the table data
            HeatProfile profile = new HeatProfile();
            for (int i = 0; i < profileTable.RowCount - 1; i++)
            {
                try
                {
                    object durationCell = profileTable.Rows[i].Cells[0].Value;
                    object tempCell = profileTable.Rows[i].Cells[1].Value;
                    if (durationCell != null && tempCell != null)
                    {
                        String durationStr = durationCell.ToString();
                        String tempStr = tempCell.ToString();
                        if (!String.IsNullOrWhiteSpace(durationStr) && !String.IsNullOrWhiteSpace(tempStr))
                        {
                            int temp = Int32.Parse(tempStr);
                            int seconds = Int32.Parse(durationStr);

                            profile.AddPhase(seconds, temp);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Each phase of the profile must have a duration and temperature.", "Incomplete profile!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            // Validate data before saving profile
            if (profile.NumPhases == 0)
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
            String filepath = GetProfilePath(profileName);
            if (!File.Exists(filepath) || DialogResult.Yes == MessageBox.Show("Profile exists. Overwrite?", "Profile Exists", MessageBoxButtons.YesNo))
            {
                profile.SaveToFile(filepath);
                ClearProfileInfo();
                LoadProfileList();
            }
        }

        private void DeleteProfile(String profileName)
        {
            String filepath = GetProfilePath(profileName);
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
                LoadProfileList();
            }
        }

        private void LoadProfileList()
        {
            profileList.Items.Clear();

            DirectoryInfo directory = new DirectoryInfo(PROFILES_DIRECTORY);
            foreach (var file in directory.GetFiles("*.txt"))
            {
                String profileName = file.Name.Replace(".txt", "");
                profileList.Items.Add(profileName);
            }
        }

        private void ClearProfileInfo()
        {
            profileNameEdit.Clear();
            profileTable.Rows.Clear();
        }

        private void removeProfileButton_Click(object sender, EventArgs e)
        {
            if (profileList.SelectedIndex != -1)
            {
                DeleteProfile(profileList.SelectedItem.ToString());
                ClearProfileInfo();
            }
        }

        private void profileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            profileTable.Rows.Clear();
            if (profileList.SelectedIndex != -1)
            {
                String profileName = profileList.SelectedItem.ToString();
                String filepath = GetProfilePath(profileName);
                HeatProfile profile = HeatProfile.LoadFromFile(filepath);

                profileNameEdit.Text = profileName;
                List<Tuple<int, int>> durationsAndTemps = profile.GetDurationsAndTemps();
                for (int i = 0; i < durationsAndTemps.Count; i++)
                {
                    profileTable.Rows.Add(durationsAndTemps[i].Item1, durationsAndTemps[i].Item2);
                }
            }
        }

        private void renameProfileButton_Click(object sender, EventArgs e)
        {
            String oldFilepath = GetProfilePath(profileList.SelectedItem.ToString());
            String newFilepath = GetProfilePath(profileNameEdit.Text);

            HeatProfile profile = HeatProfile.LoadFromFile(oldFilepath);

            if (!File.Exists(newFilepath) || DialogResult.Yes == MessageBox.Show("Profile exists. Overwrite?", "Profile Exists", MessageBoxButtons.YesNo))
            {
                if(File.Exists(newFilepath))
                {
                    File.Delete(newFilepath);
                }
                System.IO.File.Move(oldFilepath, newFilepath);
                ClearProfileInfo();
                LoadProfileList();
            }
        }

        private String GetProfilePath(String profileName)
        {
            return PROFILES_DIRECTORY + Path.DirectorySeparatorChar +
                profileName + ".txt";
        }
    }
}
