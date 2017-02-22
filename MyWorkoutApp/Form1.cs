using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

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


        public Form1()
        {
            InitializeComponent();
            user = userMgr.createUser();
            setDayWeek();
            exerciseList = workoutMgr.getExercises(user);
            setExercises();
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
            Exercise ex1 = exerciseList[0];
            Exercise ex2 = exerciseList[1];
            Exercise ex3 = exerciseList[2];

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



    }
}
