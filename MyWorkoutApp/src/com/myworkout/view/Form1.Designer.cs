namespace MyWorkoutApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayLabel = new System.Windows.Forms.Label();
            this.dayNumber = new System.Windows.Forms.Label();
            this.weekLabel = new System.Windows.Forms.Label();
            this.weekNumber = new System.Windows.Forms.Label();
            this.ex1Name = new System.Windows.Forms.Label();
            this.ex1WeightLabel = new System.Windows.Forms.Label();
            this.ex1SetsLabel = new System.Windows.Forms.Label();
            this.ex1RepsLabel = new System.Windows.Forms.Label();
            this.ex1LastReps = new System.Windows.Forms.TextBox();
            this.ex1Weight = new System.Windows.Forms.Label();
            this.ex1Sets = new System.Windows.Forms.Label();
            this.ex1Reps = new System.Windows.Forms.Label();
            this.ex1LastRepsLabel = new System.Windows.Forms.Label();
            this.ex2LastRepsLabel = new System.Windows.Forms.Label();
            this.ex2Reps = new System.Windows.Forms.Label();
            this.ex2Sets = new System.Windows.Forms.Label();
            this.ex2Weight = new System.Windows.Forms.Label();
            this.ex2LastReps = new System.Windows.Forms.TextBox();
            this.ex2RepsLabel = new System.Windows.Forms.Label();
            this.ex2SetsLabel = new System.Windows.Forms.Label();
            this.ex2WeightLabel = new System.Windows.Forms.Label();
            this.ex2Name = new System.Windows.Forms.Label();
            this.ex3LastRepsLabel = new System.Windows.Forms.Label();
            this.ex3Reps = new System.Windows.Forms.Label();
            this.ex3Sets = new System.Windows.Forms.Label();
            this.ex3Weight = new System.Windows.Forms.Label();
            this.ex3LastReps = new System.Windows.Forms.TextBox();
            this.ex3RepsLabel = new System.Windows.Forms.Label();
            this.ex3SetsLabel = new System.Windows.Forms.Label();
            this.ex3WeightLabel = new System.Windows.Forms.Label();
            this.ex3Name = new System.Windows.Forms.Label();
            this.completeDay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUSerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(11, 45);
            this.dayLabel.MinimumSize = new System.Drawing.Size(60, 25);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(177, 25);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Text = "Current Day Number:";
            // 
            // dayNumber
            // 
            this.dayNumber.AutoSize = true;
            this.dayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNumber.Location = new System.Drawing.Point(182, 46);
            this.dayNumber.MaximumSize = new System.Drawing.Size(30, 20);
            this.dayNumber.MinimumSize = new System.Drawing.Size(20, 5);
            this.dayNumber.Name = "dayNumber";
            this.dayNumber.Size = new System.Drawing.Size(20, 20);
            this.dayNumber.TabIndex = 1;
            this.dayNumber.Text = "1";
            // 
            // weekLabel
            // 
            this.weekLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weekLabel.AutoSize = true;
            this.weekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekLabel.Location = new System.Drawing.Point(317, 45);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(191, 20);
            this.weekLabel.TabIndex = 2;
            this.weekLabel.Text = "Current Week Number:";
            // 
            // weekNumber
            // 
            this.weekNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weekNumber.AutoSize = true;
            this.weekNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekNumber.Location = new System.Drawing.Point(502, 45);
            this.weekNumber.Name = "weekNumber";
            this.weekNumber.Size = new System.Drawing.Size(18, 20);
            this.weekNumber.TabIndex = 3;
            this.weekNumber.Text = "1";
            // 
            // ex1Name
            // 
            this.ex1Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex1Name.Location = new System.Drawing.Point(142, 25);
            this.ex1Name.Name = "ex1Name";
            this.ex1Name.Size = new System.Drawing.Size(235, 24);
            this.ex1Name.TabIndex = 5;
            this.ex1Name.Text = "Name";
            this.ex1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ex1WeightLabel
            // 
            this.ex1WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex1WeightLabel.AutoSize = true;
            this.ex1WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex1WeightLabel.Location = new System.Drawing.Point(6, 58);
            this.ex1WeightLabel.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.ex1WeightLabel.Name = "ex1WeightLabel";
            this.ex1WeightLabel.Size = new System.Drawing.Size(70, 20);
            this.ex1WeightLabel.TabIndex = 6;
            this.ex1WeightLabel.Text = "Weight:";
            // 
            // ex1SetsLabel
            // 
            this.ex1SetsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex1SetsLabel.AutoSize = true;
            this.ex1SetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex1SetsLabel.Location = new System.Drawing.Point(138, 60);
            this.ex1SetsLabel.Name = "ex1SetsLabel";
            this.ex1SetsLabel.Size = new System.Drawing.Size(51, 20);
            this.ex1SetsLabel.TabIndex = 7;
            this.ex1SetsLabel.Text = "Sets:";
            // 
            // ex1RepsLabel
            // 
            this.ex1RepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex1RepsLabel.AutoSize = true;
            this.ex1RepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex1RepsLabel.Location = new System.Drawing.Point(228, 58);
            this.ex1RepsLabel.Name = "ex1RepsLabel";
            this.ex1RepsLabel.Size = new System.Drawing.Size(56, 20);
            this.ex1RepsLabel.TabIndex = 8;
            this.ex1RepsLabel.Text = "Reps:";
            // 
            // ex1LastReps
            // 
            this.ex1LastReps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex1LastReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex1LastReps.Location = new System.Drawing.Point(449, 55);
            this.ex1LastReps.Name = "ex1LastReps";
            this.ex1LastReps.Size = new System.Drawing.Size(51, 26);
            this.ex1LastReps.TabIndex = 9;
            // 
            // ex1Weight
            // 
            this.ex1Weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex1Weight.AutoSize = true;
            this.ex1Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex1Weight.Location = new System.Drawing.Point(74, 58);
            this.ex1Weight.Name = "ex1Weight";
            this.ex1Weight.Size = new System.Drawing.Size(49, 20);
            this.ex1Weight.TabIndex = 10;
            this.ex1Weight.Text = "150.5";
            this.ex1Weight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ex1Sets
            // 
            this.ex1Sets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex1Sets.AutoSize = true;
            this.ex1Sets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex1Sets.Location = new System.Drawing.Point(186, 60);
            this.ex1Sets.Name = "ex1Sets";
            this.ex1Sets.Size = new System.Drawing.Size(18, 20);
            this.ex1Sets.TabIndex = 11;
            this.ex1Sets.Text = "3";
            // 
            // ex1Reps
            // 
            this.ex1Reps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex1Reps.AutoSize = true;
            this.ex1Reps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex1Reps.Location = new System.Drawing.Point(282, 58);
            this.ex1Reps.Name = "ex1Reps";
            this.ex1Reps.Size = new System.Drawing.Size(18, 20);
            this.ex1Reps.TabIndex = 12;
            this.ex1Reps.Text = "5";
            // 
            // ex1LastRepsLabel
            // 
            this.ex1LastRepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex1LastRepsLabel.AutoSize = true;
            this.ex1LastRepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex1LastRepsLabel.Location = new System.Drawing.Point(318, 58);
            this.ex1LastRepsLabel.Name = "ex1LastRepsLabel";
            this.ex1LastRepsLabel.Size = new System.Drawing.Size(129, 20);
            this.ex1LastRepsLabel.TabIndex = 13;
            this.ex1LastRepsLabel.Text = "Last Set Reps:";
            // 
            // ex2LastRepsLabel
            // 
            this.ex2LastRepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex2LastRepsLabel.AutoSize = true;
            this.ex2LastRepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex2LastRepsLabel.Location = new System.Drawing.Point(318, 61);
            this.ex2LastRepsLabel.Name = "ex2LastRepsLabel";
            this.ex2LastRepsLabel.Size = new System.Drawing.Size(129, 20);
            this.ex2LastRepsLabel.TabIndex = 23;
            this.ex2LastRepsLabel.Text = "Last Set Reps:";
            // 
            // ex2Reps
            // 
            this.ex2Reps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex2Reps.AutoSize = true;
            this.ex2Reps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex2Reps.Location = new System.Drawing.Point(282, 60);
            this.ex2Reps.Name = "ex2Reps";
            this.ex2Reps.Size = new System.Drawing.Size(18, 20);
            this.ex2Reps.TabIndex = 22;
            this.ex2Reps.Text = "5";
            // 
            // ex2Sets
            // 
            this.ex2Sets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex2Sets.AutoSize = true;
            this.ex2Sets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex2Sets.Location = new System.Drawing.Point(186, 61);
            this.ex2Sets.Name = "ex2Sets";
            this.ex2Sets.Size = new System.Drawing.Size(18, 20);
            this.ex2Sets.TabIndex = 21;
            this.ex2Sets.Text = "3";
            // 
            // ex2Weight
            // 
            this.ex2Weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex2Weight.AutoSize = true;
            this.ex2Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex2Weight.Location = new System.Drawing.Point(74, 60);
            this.ex2Weight.Name = "ex2Weight";
            this.ex2Weight.Size = new System.Drawing.Size(18, 20);
            this.ex2Weight.TabIndex = 20;
            this.ex2Weight.Text = "0";
            // 
            // ex2LastReps
            // 
            this.ex2LastReps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex2LastReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex2LastReps.Location = new System.Drawing.Point(449, 57);
            this.ex2LastReps.Name = "ex2LastReps";
            this.ex2LastReps.Size = new System.Drawing.Size(51, 26);
            this.ex2LastReps.TabIndex = 19;
            // 
            // ex2RepsLabel
            // 
            this.ex2RepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex2RepsLabel.AutoSize = true;
            this.ex2RepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex2RepsLabel.Location = new System.Drawing.Point(228, 60);
            this.ex2RepsLabel.Name = "ex2RepsLabel";
            this.ex2RepsLabel.Size = new System.Drawing.Size(56, 20);
            this.ex2RepsLabel.TabIndex = 18;
            this.ex2RepsLabel.Text = "Reps:";
            // 
            // ex2SetsLabel
            // 
            this.ex2SetsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex2SetsLabel.AutoSize = true;
            this.ex2SetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex2SetsLabel.Location = new System.Drawing.Point(138, 63);
            this.ex2SetsLabel.Name = "ex2SetsLabel";
            this.ex2SetsLabel.Size = new System.Drawing.Size(51, 20);
            this.ex2SetsLabel.TabIndex = 17;
            this.ex2SetsLabel.Text = "Sets:";
            // 
            // ex2WeightLabel
            // 
            this.ex2WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex2WeightLabel.AutoSize = true;
            this.ex2WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex2WeightLabel.Location = new System.Drawing.Point(6, 60);
            this.ex2WeightLabel.Name = "ex2WeightLabel";
            this.ex2WeightLabel.Size = new System.Drawing.Size(70, 20);
            this.ex2WeightLabel.TabIndex = 16;
            this.ex2WeightLabel.Text = "Weight:";
            // 
            // ex2Name
            // 
            this.ex2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex2Name.Location = new System.Drawing.Point(142, 25);
            this.ex2Name.Name = "ex2Name";
            this.ex2Name.Size = new System.Drawing.Size(235, 24);
            this.ex2Name.TabIndex = 15;
            this.ex2Name.Text = "Name";
            this.ex2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ex3LastRepsLabel
            // 
            this.ex3LastRepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex3LastRepsLabel.AutoSize = true;
            this.ex3LastRepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex3LastRepsLabel.Location = new System.Drawing.Point(318, 57);
            this.ex3LastRepsLabel.Name = "ex3LastRepsLabel";
            this.ex3LastRepsLabel.Size = new System.Drawing.Size(129, 20);
            this.ex3LastRepsLabel.TabIndex = 33;
            this.ex3LastRepsLabel.Text = "Last Set Reps:";
            // 
            // ex3Reps
            // 
            this.ex3Reps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex3Reps.AutoSize = true;
            this.ex3Reps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex3Reps.Location = new System.Drawing.Point(282, 57);
            this.ex3Reps.Name = "ex3Reps";
            this.ex3Reps.Size = new System.Drawing.Size(18, 20);
            this.ex3Reps.TabIndex = 32;
            this.ex3Reps.Text = "5";
            // 
            // ex3Sets
            // 
            this.ex3Sets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex3Sets.AutoSize = true;
            this.ex3Sets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex3Sets.Location = new System.Drawing.Point(186, 58);
            this.ex3Sets.Name = "ex3Sets";
            this.ex3Sets.Size = new System.Drawing.Size(18, 20);
            this.ex3Sets.TabIndex = 31;
            this.ex3Sets.Text = "3";
            // 
            // ex3Weight
            // 
            this.ex3Weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex3Weight.AutoSize = true;
            this.ex3Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex3Weight.Location = new System.Drawing.Point(74, 58);
            this.ex3Weight.Name = "ex3Weight";
            this.ex3Weight.Size = new System.Drawing.Size(18, 20);
            this.ex3Weight.TabIndex = 30;
            this.ex3Weight.Text = "0";
            // 
            // ex3LastReps
            // 
            this.ex3LastReps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex3LastReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex3LastReps.Location = new System.Drawing.Point(449, 54);
            this.ex3LastReps.Name = "ex3LastReps";
            this.ex3LastReps.Size = new System.Drawing.Size(51, 26);
            this.ex3LastReps.TabIndex = 29;
            // 
            // ex3RepsLabel
            // 
            this.ex3RepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex3RepsLabel.AutoSize = true;
            this.ex3RepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex3RepsLabel.Location = new System.Drawing.Point(228, 58);
            this.ex3RepsLabel.Name = "ex3RepsLabel";
            this.ex3RepsLabel.Size = new System.Drawing.Size(56, 20);
            this.ex3RepsLabel.TabIndex = 28;
            this.ex3RepsLabel.Text = "Reps:";
            // 
            // ex3SetsLabel
            // 
            this.ex3SetsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex3SetsLabel.AutoSize = true;
            this.ex3SetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex3SetsLabel.Location = new System.Drawing.Point(138, 58);
            this.ex3SetsLabel.Name = "ex3SetsLabel";
            this.ex3SetsLabel.Size = new System.Drawing.Size(51, 20);
            this.ex3SetsLabel.TabIndex = 27;
            this.ex3SetsLabel.Text = "Sets:";
            // 
            // ex3WeightLabel
            // 
            this.ex3WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex3WeightLabel.AutoSize = true;
            this.ex3WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex3WeightLabel.Location = new System.Drawing.Point(6, 58);
            this.ex3WeightLabel.Name = "ex3WeightLabel";
            this.ex3WeightLabel.Size = new System.Drawing.Size(70, 20);
            this.ex3WeightLabel.TabIndex = 26;
            this.ex3WeightLabel.Text = "Weight:";
            // 
            // ex3Name
            // 
            this.ex3Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ex3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex3Name.Location = new System.Drawing.Point(142, 25);
            this.ex3Name.Name = "ex3Name";
            this.ex3Name.Size = new System.Drawing.Size(235, 24);
            this.ex3Name.TabIndex = 25;
            this.ex3Name.Text = "Name";
            this.ex3Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completeDay
            // 
            this.completeDay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.completeDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeDay.Location = new System.Drawing.Point(181, 441);
            this.completeDay.Name = "completeDay";
            this.completeDay.Size = new System.Drawing.Size(163, 33);
            this.completeDay.TabIndex = 34;
            this.completeDay.Text = "Complete Day";
            this.completeDay.UseVisualStyleBackColor = true;
            this.completeDay.Click += new System.EventHandler(this.completeDay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveUSerToolStripMenuItem,
            this.workoutInfoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveUSerToolStripMenuItem
            // 
            this.saveUSerToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.saveUSerToolStripMenuItem.Name = "saveUSerToolStripMenuItem";
            this.saveUSerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveUSerToolStripMenuItem.Text = "&Save User";
            this.saveUSerToolStripMenuItem.Click += new System.EventHandler(this.saveUSerToolStripMenuItem_Click);
            // 
            // workoutInfoToolStripMenuItem
            // 
            this.workoutInfoToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.workoutInfoToolStripMenuItem.Name = "workoutInfoToolStripMenuItem";
            this.workoutInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.workoutInfoToolStripMenuItem.Text = "Workout Info";
            this.workoutInfoToolStripMenuItem.Click += new System.EventHandler(this.workoutInfoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.userToolStripMenuItem.Text = "Edit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editToolStripMenuItem.Text = "Exercise Weight";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.ex1Name);
            this.groupBox1.Controls.Add(this.ex1WeightLabel);
            this.groupBox1.Controls.Add(this.ex1SetsLabel);
            this.groupBox1.Controls.Add(this.ex1RepsLabel);
            this.groupBox1.Controls.Add(this.ex1LastReps);
            this.groupBox1.Controls.Add(this.ex1Weight);
            this.groupBox1.Controls.Add(this.ex1Sets);
            this.groupBox1.Controls.Add(this.ex1Reps);
            this.groupBox1.Controls.Add(this.ex1LastRepsLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 100);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exercise 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.ex2Name);
            this.groupBox2.Controls.Add(this.ex2WeightLabel);
            this.groupBox2.Controls.Add(this.ex2SetsLabel);
            this.groupBox2.Controls.Add(this.ex2RepsLabel);
            this.groupBox2.Controls.Add(this.ex2LastReps);
            this.groupBox2.Controls.Add(this.ex2Weight);
            this.groupBox2.Controls.Add(this.ex2Sets);
            this.groupBox2.Controls.Add(this.ex2Reps);
            this.groupBox2.Controls.Add(this.ex2LastRepsLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 100);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exercise 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.Color.Wheat;
            this.groupBox3.Controls.Add(this.ex3Name);
            this.groupBox3.Controls.Add(this.ex3WeightLabel);
            this.groupBox3.Controls.Add(this.ex3LastRepsLabel);
            this.groupBox3.Controls.Add(this.ex3SetsLabel);
            this.groupBox3.Controls.Add(this.ex3Reps);
            this.groupBox3.Controls.Add(this.ex3RepsLabel);
            this.groupBox3.Controls.Add(this.ex3Sets);
            this.groupBox3.Controls.Add(this.ex3LastReps);
            this.groupBox3.Controls.Add(this.ex3Weight);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 100);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exercise 3";
            // 
            // nextDayButton
            // 
            this.nextDayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextDayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDayButton.Location = new System.Drawing.Point(181, 441);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(163, 33);
            this.nextDayButton.TabIndex = 40;
            this.nextDayButton.Text = "Start Next Day";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(549, 491);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.completeDay);
            this.Controls.Add(this.weekNumber);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.dayNumber);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.nextDayButton);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyWorkout";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label dayNumber;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.Label weekNumber;
        private System.Windows.Forms.Label ex1Name;
        private System.Windows.Forms.Label ex1WeightLabel;
        private System.Windows.Forms.Label ex1SetsLabel;
        private System.Windows.Forms.Label ex1RepsLabel;
        private System.Windows.Forms.TextBox ex1LastReps;
        private System.Windows.Forms.Label ex1Weight;
        private System.Windows.Forms.Label ex1Sets;
        private System.Windows.Forms.Label ex1Reps;
        private System.Windows.Forms.Label ex1LastRepsLabel;
        private System.Windows.Forms.Label ex2LastRepsLabel;
        private System.Windows.Forms.Label ex2Reps;
        private System.Windows.Forms.Label ex2Sets;
        private System.Windows.Forms.Label ex2Weight;
        private System.Windows.Forms.TextBox ex2LastReps;
        private System.Windows.Forms.Label ex2RepsLabel;
        private System.Windows.Forms.Label ex2SetsLabel;
        private System.Windows.Forms.Label ex2WeightLabel;
        private System.Windows.Forms.Label ex2Name;
        private System.Windows.Forms.Label ex3LastRepsLabel;
        private System.Windows.Forms.Label ex3Reps;
        private System.Windows.Forms.Label ex3Sets;
        private System.Windows.Forms.Label ex3Weight;
        private System.Windows.Forms.TextBox ex3LastReps;
        private System.Windows.Forms.Label ex3RepsLabel;
        private System.Windows.Forms.Label ex3SetsLabel;
        private System.Windows.Forms.Label ex3WeightLabel;
        private System.Windows.Forms.Label ex3Name;
        private System.Windows.Forms.Button completeDay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveUSerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button nextDayButton;
        private System.Windows.Forms.ToolStripMenuItem workoutInfoToolStripMenuItem;
    }
}

