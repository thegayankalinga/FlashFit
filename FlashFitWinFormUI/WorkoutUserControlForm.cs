using FlashFitClassLibrary.Models;
using FlashFitClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlashFitWinFormUI
{
    public partial class WorkoutUserControlForm : UserControl
    {
        public WorkoutUserControlForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addWorkoutFormButton_Click(object sender, EventArgs e)
        {
            AddWorkoutForm addWorkoutForm = new AddWorkoutForm();
            addWorkoutForm.ShowDialog();
        }

        private void WorkoutUserControlForm_Enter(object sender, EventArgs e)
        {
            List<WorkoutModel> list = TemporaryDataStore.workoutModels;

            //HashSet<UserProfileModel> userList = TemporaryDataStore.userProfiles;
            string[] item = new string[4];
            ListViewItem listItem;
            listView1.Items.Clear();

            foreach (var i in list)
            {
                item[0] = i.WorkoutID.ToString();
                item[1] = i.WorkoutName;
                item[2] = i.WorkoutType.ToString();
                item[3] = i.CaloryBurnRate.ToString();


                listItem = new ListViewItem(item);
                listView1.Items.Add(listItem);
            }
        }
    }
}
