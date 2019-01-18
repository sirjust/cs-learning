using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqLibrary;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = ListManager.LoadSampleData();

        public Dashboard()
        {
            InitializeComponent();

            InitializeBindings();
        }

        private void InitializeBindings()
        {
            allPeopleDropDown.DataSource = people;
            allPeopleDropDown.DisplayMember = "FullName";

            filteredPeopleList.DataSource = people.Where(x => x.YearsExperience >= 5).OrderBy(x=>x.LastName).ThenBy(x=>x.FirstName).ToList();

            filteredPeopleList.DisplayMember = "FullName";
        }

        private void UpdateBindings()
        {
            filteredPeopleList.DataSource = people.Where(x => x.YearsExperience >= 5).OrderBy(x=>x.LastName).ThenBy(x=>x.FirstName).ToList();
        }

        private void allPeopleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)allPeopleDropdown.SelectedItem;

            yearsExperiencePicker.Value = selectedPerson.YearsExperience;
        }

        private void updatePersonButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)allPeopleDropdown.SelectedItem;

            selectedPerson.YearsExperience = Convert.ToInt32(yearsExperiencePicker.Value);

            UpdateBindings();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
