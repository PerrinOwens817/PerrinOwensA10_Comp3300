using PerrinOwensA10.Model.Address;
using PerrinOwensA10.Model.Person;
using System.Text;

namespace Assignment10.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Demo();
        }

        private void Demo()
        {
            var student = new Student("Perrin", "Owens", 1, new Address("123 Some Lane", "Atlanta", "GA", 12345), "Computing");
            student.Minor = "None";

            var teacher = new Teacher("Joseph", "Martinez", 2, new Address("456 Some Road", "Carrollton", "GA", 67890), "Computing");

            var staff = new Staff("Alexandra", "Young", 3, new Address("789 Some Street", "Carrollton", "GA", 67890), "Advisor");

            var people = new List<Person> { student, teacher, staff };

            var details = new StringBuilder();
            foreach (var person in people)
            {
                details.AppendLine(person.Details);
                details.AppendLine();
            }

            outputTextBox.Text = details.ToString();
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}