using System.Diagnostics;
using System.Text.RegularExpressions;


namespace Next_Episode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Loadfiles();

        }

        string Selecteditem = "";
        string currentepisode = "";
        string fileformat = "";
        string vlcpath = "";
        List<string> remainingEpisodes;



        private void BtChooseFilePath_Click(object sender, EventArgs e) //choose Series file path
        {   
            FolderBrowserDialog FBD = new();
            FBD.InitialDirectory = @"C:\Users\guusv\Desktop\One piece";
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                AllEpisodesView.Items.Clear();
                Selecteditem = FBD.SelectedPath;
                UpdateListBox(Selecteditem);
                Savefiles();
            }


        }
        private void BTvlcpath_Click(object sender, EventArgs e) //choose vlc file path
        {
            // Create an OpenFileDialog to select the VLC executable
            OpenFileDialog OFD = new();
            OFD.Filter = "Executable Files (*.exe)|*.exe"; // Filter to only show .exe files
            OFD.InitialDirectory = @"C:\Program Files\VideoLAN\VLC"; // Default directory where VLC is usually installed

            // Show the dialog and check if the user selected a file
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                // Store the selected path to vlcpath
                vlcpath = OFD.FileName;
            }
            Savefiles();
        }
        private void BtPlayNextEp_Click(object sender, EventArgs e)//Play the current episode, sets the next episode as current episode., 
        {
            if (LblCurEp.Text == "No More Episodes")
            {
                MessageBox.Show("End of Season");
            }
            if (remainingEpisodes.Count >= 0)
            {
                string currentpath = Getfilepath();
                RunFile(currentpath);
                if (string.IsNullOrEmpty(currentpath) || !File.Exists(currentpath))
                {
                    MessageBox.Show($"File path is invalid or file does not exist: {currentpath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (remainingEpisodes.Count != 0)
                {
                    currentepisode = remainingEpisodes[0];
                    remainingEpisodes.Remove(currentepisode);

                    LblCurEp.Text = currentepisode;
                    

                }
                else LblCurEp.Text = "No More Episodes";
                UpdateListBox(Selecteditem);
                Savefiles();
            }
           
           

        }


        private int GetEpisodeNumber(string selecteditem)//Get the episodenumber to order to episodes
        {
            var Match = Regex.Match(selecteditem, @" - (\d{1,4}) ");
            if (Match.Success)
            {
                int episodenumber = int.Parse(Match.Groups[1].Value);
                return episodenumber;
            }
            return int.MaxValue;

        }

        private void AllEpisodesView_MouseClick(object sender, MouseEventArgs e)//set the episode clicked in the listbox as the current item
        {
            if (AllEpisodesView.SelectedItem != null)
            {
                currentepisode = (string)AllEpisodesView.SelectedItem;
                LblCurEp.Text = currentepisode;
                UpdateListBox(Selecteditem);
                Savefiles();
            }
        }
        private void Loadfiles()//load the files on startup and add them to the listbox
        {
            remainingEpisodes = new List<string>();

            if (AllEpisodesView.Items.Count == 0 && Properties.Settings.Default.FilePath != null)
            {

                Selecteditem = Properties.Settings.Default.FilePath;
                currentepisode = Properties.Settings.Default.LastEpisode;
                fileformat = Properties.Settings.Default.FileFormat;
                vlcpath = Properties.Settings.Default.vlcpath;
                LblCurEp.Text = currentepisode;
                comboBox1.SelectedItem = fileformat;
                UpdateListBox(Properties.Settings.Default.FilePath);
            }

        }
        private void Savefiles()//save the files when they get changed
        {

            Properties.Settings.Default.vlcpath = vlcpath;
            Properties.Settings.Default.FilePath = Selecteditem;
            Properties.Settings.Default.LastEpisode = currentepisode;
            Properties.Settings.Default.FileFormat = fileformat;
            Properties.Settings.Default.Save();

        }
        private void UpdateListBox(string path)//add episodes to listbox up to the current episode, add the remaining episodes to the remaining ep list
        {
            bool currentepisodefound = false;

            remainingEpisodes.Clear();
            AllEpisodesView.Items.Clear();
            var files = Directory.GetFiles(path, $"*.{fileformat}").OrderBy(file => GetEpisodeNumber(Path.GetFileName(file))).ToList();


            if (files.Count <= 0)
            {
                MessageBox.Show("no allowed files found inside the folder");

            }
            else
            {

                foreach (var file in files)
                {

                    if (file.Contains(currentepisode))
                    {
                        AllEpisodesView.Items.Add(Path.GetFileName(file));
                        currentepisodefound = true;
                        break;
                    }
                    else AllEpisodesView.Items.Add(Path.GetFileName(file));


                }

            }
            if (currentepisodefound)
            {
                foreach (var file in files.SkipWhile(f => !Path.GetFileName(f).Contains(currentepisode)).Skip(1))
                {
                    remainingEpisodes.Add(Path.GetFileName(file));

                }
            }

        }
        string Getfilepath()//combine the currentepisode with the filepath to create the currentepisodefilepath
        {
            return Path.Combine(Selecteditem, currentepisode);
        }
        void RunFile(string episode)//run the current episode via vlc
        {
            if (!AllEpisodesView.Items.Contains(currentepisode))
            {
                AllEpisodesView.Items.Add(currentepisode);
            }
            ProcessStartInfo startInfo = new()
            {
                FileName = $@"{vlcpath}",
                Arguments = $"\"{episode}\"",
                UseShellExecute = true // UseShellExecute = true to use the system shell (required for running applications like VLC)

            };
            Process.Start(startInfo);


        }
      



        private void BtChoosecurrentep_Click(object sender, EventArgs e)//go to the other form to skip to a later episode
        {
            this.Hide();
            Form2 mainForm = new(remainingEpisodes);
            mainForm.Show(); // Open the main form again

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                fileformat = comboBox1.SelectedItem as string;
            }
        }
    }
}

