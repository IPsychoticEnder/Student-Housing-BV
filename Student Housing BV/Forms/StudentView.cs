using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Housing_BV.Classes;

namespace Student_Housing_BV
{
    public partial class StudentView : Form
    {
        public User loggedInUser { get; set; }

        public StudentView(User loggedInUser)
        {
            InitializeComponent();
        }
    }
}
