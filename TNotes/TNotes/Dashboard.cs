﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotes
{
    public partial class Dashboard : Form
    {
        User user;
        List<string> noteString;
        int note_id;
        String note_title;
        int note_chapter;
        int note_section;
        String note_summary;
        string course;
        string subject;
        string prof;
        string semester;
        int year;
        int course_id = -1;
        string note_date;
        string y, z;
        public Dashboard(User x)
        {
            this.user = x;
            InitializeComponent();
            this.Hide();

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Courses_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            object[] arr = new object[dataGridView1.Columns.Count];
            string sent = e.ToString();

        }

        private void dataGridView1_Click(object sender, System.EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }
                int x = Convert.ToInt32(sb.ToString());
                if (x < 0)
                    return;
                
                try {  this.y = dataGridView1.Rows[x].Cells["Note ID"].Value.ToString(); }
                catch
                {
                };
                try {  this.z = dataGridView1.Rows[x].Cells["Course ID"].Value.ToString(); }
                catch { };
                if(z!=null)
                     this.course_id = Convert.ToInt32(z);
                if(y!=null)
                    this.note_id = Convert.ToInt32(y);
            }
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            DataTable courses = user.dtCourses();

            DataTable courses_copy = courses;

            courses.Columns["course_id"].ColumnName = "Course ID";
            courses.Columns.Remove("user_id");
            courses.Columns.Remove("note_id");
            courses.Columns["course_name"].ColumnName = "Courses";
            courses.Columns["subject"].ColumnName = "Subject";
            courses.Columns["prof"].ColumnName = "Professor";
            courses.Columns["semester"].ColumnName = "Semester";
            courses.Columns["year"].ColumnName = "Year";
            dataGridView1.DataSource = courses;
            gridResize(dataGridView1);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            user.deleteNote(note_id);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new UserSettings(user)); });
            myThread.Start();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new Form1(newUser)); });
            myThread.Start();
            this.Close();
        }

        private void searchStart_Click(object sender, EventArgs e)
        {
            Console.Write(this.txtSearch.Text);
            string keywords = this.txtSearch.Text;
            Console.Write(keywords);
            string[] keywordsArray = keywords.Split(',');
            List<string> keywordsList = new List<string>();
            foreach (string s in keywordsArray)
            {
                keywordsList.Add(s);
            }
            if (keywordsList.Count != 0)
            {
                DataTable notes = user.searchByKeyword(keywordsList);
                dataGridView1.DataSource = notes;
            }
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search") & sender == txtSearch)
                txtSearch.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSearch.Text) & sender == txtSearch)
            {
                txtSearch.Text = "Search";
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            User result = Task.Factory.StartNew(() =>
            {
                UserSettings settings = new UserSettings(user);
                Application.Run(settings);

                return user;
            }).Result;
            if (user.login(user.getUsername(), user.getPassword()) < 0)
            {
                User newUser = new User();
                Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new Form1(newUser)); });
                myThread.Start();
                this.Close();
            } else
            {
                this.BringToFront();
            }      
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new Form1(newUser)); });
            myThread.Start();
            this.Close();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            string year = Prompt.ShowDialog("Year?", "Year");
            DataTable courses = user.dtCourses();

            courses.DefaultView.RowFilter = "Convert(year,'System.String') LIKE '%" + year + "%'";

            courses.Columns["course_id"].ColumnName = "Course ID";
            courses.Columns.Remove("user_id");
            courses.Columns.Remove("note_id");
            courses.Columns["course_name"].ColumnName = "Courses";
            courses.Columns["subject"].ColumnName = "Subject";
            courses.Columns["prof"].ColumnName = "Professor";
            courses.Columns["semester"].ColumnName = "Semester";
            courses.Columns["year"].ColumnName = "Year";
            dataGridView1.DataSource = courses;
            gridResize(dataGridView1);


        }

        private void btnSemester_Click(object sender, EventArgs e)
        {
            string semester = Prompt.ShowDialog("Semester?", "Semester");
            DataTable courses = user.dtCourses();

            courses.DefaultView.RowFilter = "Convert(semester,'System.String') LIKE '%" + semester + "%'";

            courses.Columns["course_id"].ColumnName = "Course ID";
            courses.Columns.Remove("user_id");
            courses.Columns.Remove("note_id");
            courses.Columns["course_name"].ColumnName = "Courses";
            courses.Columns["subject"].ColumnName = "Subject";
            courses.Columns["prof"].ColumnName = "Professor";
            courses.Columns["semester"].ColumnName = "Semester";
            courses.Columns["year"].ColumnName = "Year";
            dataGridView1.DataSource = courses;
            gridResize(dataGridView1);


        }
        private void btnProfessor_Click(object sender, EventArgs e)
        {
            string prof = Prompt.ShowDialog("Professor?", "Professor");
            DataTable courses = user.dtCourses();

            courses.DefaultView.RowFilter = "Convert(prof,'System.String') LIKE '%" + prof + "%'";

            courses.Columns["course_id"].ColumnName = "Course ID";
            courses.Columns.Remove("user_id");
            courses.Columns.Remove("note_id");
            courses.Columns["course_name"].ColumnName = "Courses";
            courses.Columns["subject"].ColumnName = "Subject";
            courses.Columns["prof"].ColumnName = "Professor";
            courses.Columns["semester"].ColumnName = "Semester";
            courses.Columns["year"].ColumnName = "Year";
            dataGridView1.DataSource = courses;
            gridResize(dataGridView1);


        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {

            this.note_title = Prompt.ShowDialog("What's The Title?", "Title");
            this.note_chapter = Convert.ToInt32(Prompt.ShowDialog("Chapter?", "Chapter"));
            this.note_section = Convert.ToInt32(Prompt.ShowDialog("Section?", "Section"));
            this.note_summary = Prompt.ShowDialog("Short Summary?", "Summary");
            

            using (var courseForm = new SelectCourse(user))
            {
                var result = courseForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.course = courseForm.course;
                    this.subject = courseForm.subj;
                    this.prof = courseForm.prof;
                    this.semester = courseForm.semester;
                    this.year = Convert.ToInt32(courseForm.year);
                    if (courseForm.course_id == -5)
                        this.course_id = user.addCourse(this.course, this.subject, this.prof, this.semester, this.year);
                    else
                        this.course_id = courseForm.course_id;
                }
            }
            if(course_id > -1)
                this.note_id = user.addNotes(note_title, note_chapter, note_section, note_summary, "placeholder", course_id);
            richTextBox1.Clear();
            noteString = user.openNote(this.note_id);
            richTextBox1.Text = noteString.ElementAt(6);
            richTextBox1.Clear();
        }

        private void gridResize(DataGridView dgv)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dataGridView1.Width = 447;
            richTextBox1.Show();
            buttonModify.Show();
            buttonSave.Show();
            buttonClose.Show();
            CreateYourNote.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            object[] arr = new object[dataGridView1.Columns.Count];
            dataGridView1.Columns.CopyTo(arr, 0);
            String x = arr[0].ToString();
            x = x.Substring(33, x.IndexOf(',') - 33);
            switch (x)
            {
                case "Note ID":

                    noteString = user.openNote(this.note_id);
                    richTextBox1.Text = noteString.ElementAt(6);
                    dataGridView1.Width = 447;
                    richTextBox1.Show();
                    buttonModify.Show();
                    buttonSave.Show();
                    buttonClose.Show();
                    CreateYourNote.Show();
                    break;
                case "Course ID":
                    DataTable notes = user.getNotesByCourse(this.course_id);
                    dataGridView1.DataSource = notes;
                    dataGridView1.Refresh();
                    break;
            }
                       
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            user.updateBody(this.note_id, richTextBox1.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
          DialogResult result = MessageBox.Show("Are you sure?", "Close Note", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Yes)
            {
                dataGridView1.Width = 873;
                richTextBox1.Hide();
                buttonModify.Hide();
                buttonSave.Hide();
                buttonClose.Hide();
                CreateYourNote.Hide();
                richTextBox1.Clear();
            }
        }
    }

    internal class Prompt
    {
        internal static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "T-Notes | "+caption,
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = false,
                ShowInTaskbar = false
        };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
