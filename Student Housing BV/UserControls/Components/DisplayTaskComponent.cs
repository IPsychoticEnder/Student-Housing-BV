

namespace Student_Housing_BV.UserControls.Components
{
    public partial class DisplayTaskComponent : UserControl
    {
        Classes.Tasks.Task ActiveTask { get; set; }

        public DisplayTaskComponent(Classes.Tasks.Task task)
        {
            InitializeComponent();
            ActiveTask = task;
            lblDisplayTaskName.Text = $"{task.Name}";
            lblDisplayTaskDescription.Text = $"{task.Description}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 116, 109);
            this.button1.Hide();
        }
    }
}
