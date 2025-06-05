using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Next_Episode
{
    public partial class Form2 : Form
    {
        private List<string> listFromForm1;

        public Form2(List<string> passedList)
        {
            InitializeComponent();
            listFromForm1 = passedList;
            Startup();
        }

        private void RemainingEplist_MouseDoubleClick(object sender, MouseEventArgs e)//when the listbox gets doubleclicked, put that episode as the currentepisode, then return to the main form
        {
            Properties.Settings.Default.LastEpisode = RemainingEplist.SelectedItem as string;

            Form1 mainForm = new();
            mainForm.Show(); // Open the main form again
            this.Close();
        }
        void Startup()//fill the listbox with the remainingepisodes
        {
            foreach (var file in listFromForm1)
                if (RemainingEplist.Items.Count != listFromForm1.Count)
                {
                    RemainingEplist.Items.Add(file);
                }
        }

        private void button1_Click(object sender, EventArgs e)//return to the main form
        {
            Form1 mainForm = new();
            mainForm.Show(); // Open the main form again
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
