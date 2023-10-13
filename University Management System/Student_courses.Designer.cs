namespace University_Management_System
{
    partial class Student_courses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_courses));
            this.buttonlogout = new System.Windows.Forms.Button();
            this.buttonCourses = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonlogout
            // 
            this.buttonlogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonlogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonlogout.BackgroundImage")));
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonlogout.Location = new System.Drawing.Point(16, 184);
            this.buttonlogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(313, 57);
            this.buttonlogout.TabIndex = 9;
            this.buttonlogout.Text = "Back";
            this.buttonlogout.UseVisualStyleBackColor = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // buttonCourses
            // 
            this.buttonCourses.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCourses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCourses.BackgroundImage")));
            this.buttonCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCourses.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCourses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCourses.Location = new System.Drawing.Point(16, 98);
            this.buttonCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Size = new System.Drawing.Size(313, 57);
            this.buttonCourses.TabIndex = 6;
            this.buttonCourses.Text = "Courses";
            this.buttonCourses.UseVisualStyleBackColor = false;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProfile.BackgroundImage")));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProfile.Location = new System.Drawing.Point(16, 15);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(313, 57);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // Student_courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1301, 773);
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.buttonCourses);
            this.Controls.Add(this.buttonProfile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Student_courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_courses";
            this.Load += new System.EventHandler(this.Student_courses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Button buttonCourses;
        private System.Windows.Forms.Button buttonProfile;
    }
}