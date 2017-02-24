using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using myworkout.model.domain;
using myworkout.model.business;

namespace MyWorkoutApp
{
    public partial class Form1 : Form
    {
        User user;
        UserMgr userMgr = new UserMgr();
        WorkoutMgr workoutMgr = new WorkoutMgr();
        IList<Exercise> exerciseList;
        Message message;


        public Form1()
        {
            InitializeComponent();
            nextDayButton.Hide();
            completeDay.Show();
            getUser();
            setDayWeek();
            exerciseList = workoutMgr.getExercises(user);
            setExercises();
        }

        private void getUser()
        {
            int userId = 1;
            user = userMgr.getUser(userId);
            if (user == null)
            {
                user = userMgr.createUser();
            }
        }

        private void setDayWeek()
        {
            foreach(Week wk in user.Weeks)
            {
                if(wk.WeekOrderNumber == user.CurrentWeek)
                {
                    weekNumber.Text = wk.WeekNumber.ToString();

                    foreach(myworkout.model.domain.Day day in wk.Days)
                    {
                        if(day.DayOrderNumber == user.CurrentDay)
                        {
                            dayNumber.Text = day.DayNumber.ToString();
                        }
                    }
                }
            }
        }

        private void setExercises()
        {
            Exercise ex1 = null;
            Exercise ex2 = null;
            Exercise ex3 = null;
            try
            {
                ex1 = exerciseList[0];
                ex2 = exerciseList[1];
                ex3 = exerciseList[2];
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            ex1Name.Text = ex1.Name;
            ex1Weight.Text = ex1.Weight.ToString();
            ex1Sets.Text = ex1.Sets.ToString();
            ex1Reps.Text = ex1.Reps.ToString();

            ex2Name.Text = ex2.Name;
            ex2Weight.Text = ex2.Weight.ToString();
            ex2Sets.Text = ex2.Sets.ToString();
            ex2Reps.Text = ex2.Reps.ToString();

            ex3Name.Text = ex3.Name;
            ex3Weight.Text = ex3.Weight.ToString();
            ex3Sets.Text = ex3.Sets.ToString();
            ex3Reps.Text = ex3.Reps.ToString();
        }

        private void completeDay_Click(object sender, EventArgs e)
        {

            if (ex1LastReps.Text != "" && ex2LastReps.Text != "" &&
                ex3LastReps.Text != "")
            {
                Hashtable hashTable = new Hashtable();
                try
                {
                    int ex1Reps = Convert.ToInt32(ex1LastReps.Text);
                    int ex2Reps = Convert.ToInt32(ex2LastReps.Text);
                    int ex3Reps = Convert.ToInt32(ex3LastReps.Text);
                    hashTable.Add((exerciseList[0].ExerciseNumber), ex1Reps);
                    hashTable.Add((exerciseList[1].ExerciseNumber), ex2Reps);
                    hashTable.Add((exerciseList[2].ExerciseNumber), ex3Reps);
                    user = workoutMgr.completeDay(user, hashTable);                
                    message = new Message("Successfully Completed Day");
                    completeDay.Hide();
                    nextDayButton.Show();
                }
                catch(Exception ex)
                {
                    message = new Message(ex.Message);
                }
            }else
            {
                message = new Message("Please Enter Your Last Reps");
            }
        }


        private void saveUSerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = userMgr.saveUser(user);
            message = new Message("User Saved");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message = new Message("Not Implemented Yet");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            message = new Message("Starting next day!");
            setDayWeek();
            exerciseList = null;
            exerciseList = workoutMgr.getExercises(user);
            setExercises();
            ex1LastReps.Text = "";
            ex2LastReps.Text = "";
            ex3LastReps.Text = "";
            completeDay.Show();
            nextDayButton.Hide();
        }

        private void workoutInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkoutInfoForm workoutInfoForm = new WorkoutInfoForm();
        }
    }
}
