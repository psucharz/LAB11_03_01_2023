using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB11_03_01_2023
{

    public partial class TripleTester : Form
    {
        private List<string> dataTypes = new List<string> { "Integers", "Real Numbers", "People" };
        List<Person> people = new List<Person>();
        Triple<int> tripleInt; Triple<double> tripleDouble; Triple<Person> triplePerson;
        public TripleTester()
        {
            InitializeComponent();
            DataTypeComboBox.DataSource = dataTypes;
            DataTypeComboBox.SelectedIndex = 0;
            BirthDateTimePicker.MaxDate = DateTime.Today;
        }

        private void InputTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            IntegerInputPanel.Visible = false;
            DoubleInputPanel.Visible = false;
            PeopleInputPanel.Visible = false;
            if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[0])
                IntegerInputPanel.Visible = true;
            if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[1])
                DoubleInputPanel.Visible = true;
            if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[2])
                PeopleInputPanel.Visible = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[0])
            {
                try
                { tripleInt = new Triple<int>(int.Parse(Int0TextBox.Text), int.Parse(Int1TextBox.Text), int.Parse(Int2TextBox.Text)); }
                catch (ArgumentNullException)
                { MessageBox.Show("There has to be three integers.", "Cannot save a triplet of integers", MessageBoxButtons.OK); }
                catch (FormatException)
                { MessageBox.Show("Check if integers are typed correctly.", "Cannot save a triplet of integers", MessageBoxButtons.OK); }
            }
            if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[1])
            {
                try
                { tripleDouble = new Triple<double>(double.Parse(Double0TextBox.Text), double.Parse(Double1TextBox.Text), double.Parse(Double2TextBox.Text)); }
                catch (ArgumentNullException)
                { MessageBox.Show("There has to be three real numbers.", "Cannot save a triplet of real numbers", MessageBoxButtons.OK); }
                catch (FormatException)
                { MessageBox.Show("Check if numbers are typed correctly.", "Cannot save a triplet of real numbers", MessageBoxButtons.OK); }
            }
            if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[2])
            {
                try
                {
                    triplePerson = new Triple<Person>(people[0], people[1], people[2]);
                }
                catch
                {
                    MessageBox.Show("Cannot save data of people", "Cannot save data of people", MessageBoxButtons.OK);
                }
            }
        }

        private void PeopleComboBox_SelectedItemChanged(object sender, EventArgs e)
        {
            NameTextBox.Text = people[PeopleComboBox.SelectedIndex].Name;
            SurnameTextBox.Text = people[PeopleComboBox.SelectedIndex].Surname;
            BirthDateTimePicker.Value = people[PeopleComboBox.SelectedIndex].Birthday;
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            if (people.Count() < 3)
            {
                if (NameTextBox.Text != String.Empty && SurnameTextBox.Text != String.Empty)
                {
                    people.Add(new Person(NameTextBox.Text, SurnameTextBox.Text, BirthDateTimePicker.Value));
                    PeopleComboBox.Items.Add(people.Last());
                    PeopleComboBox.SelectedIndex = people.Count() - 1;
                    if (people.Count() == 3)
                        AddPersonButton.Enabled = false;
                }
                else
                    MessageBox.Show("Name and surname of people is required", "Cannot save persons data", MessageBoxButtons.OK);
            }
        }

        private void EditPersonButton_Click(object sender, EventArgs e)
        {
            if (PeopleComboBox.SelectedIndex != -1)
            {
                if (NameTextBox.Text != String.Empty && SurnameTextBox.Text != String.Empty)
                {
                    people[PeopleComboBox.SelectedIndex] = (new Person(NameTextBox.Text, SurnameTextBox.Text, BirthDateTimePicker.Value));
                    PeopleComboBox.Items.Clear();
                    PeopleComboBox.Items.AddRange(people.ToArray());
                }
                else
                    MessageBox.Show("Name and surname of people is required", "Cannot edit persons data", MessageBoxButtons.OK);
            }
        }

        private void ClearPeopleButton_Click(object sender, EventArgs e)
        {
            people = new List<Person>();
            PeopleComboBox.Items.Clear();
            NameTextBox.Text = String.Empty;
            SurnameTextBox.Text = String.Empty;
            AddPersonButton.Enabled = true;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[0])
                    tripleInt.Sort();
                if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[1])
                    tripleDouble.Sort();
                if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[2])
                    triplePerson.Sort();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Triplets haven't been created yet.", "Cannot output metod tests of triplets", MessageBoxButtons.OK);
            }
        }

        private void ToStringButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[0])
                    MethodsTestTextBox.Text = tripleInt.ToString();
                if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[1])
                    MethodsTestTextBox.Text = tripleDouble.ToString();
                if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[2])
                    MethodsTestTextBox.Text = triplePerson.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Triplets haven't been created yet.", "Cannot output metod tests of triplets", MessageBoxButtons.OK);
            }
        }

        private void Indexer0Button_Click(object sender, EventArgs e)
        {
            IndexerButton_Click(0);
        }

        private void Indexer1Button_Click(object sender, EventArgs e)
        {
            IndexerButton_Click(1);
        }

        private void Indexer2Button_Click(object sender, EventArgs e)
        {
            IndexerButton_Click(2);
        }

        private void IndexerButton_Click(int id)
        {
            try
            {
                if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[0])
                    MethodsTestTextBox.Text = tripleInt[id].ToString();
                if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[1])
                    MethodsTestTextBox.Text = tripleDouble[id].ToString();
                if (DataTypeComboBox.SelectedItem.ToString() == dataTypes[2])
                    MethodsTestTextBox.Text = triplePerson[id].ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Triplets haven't been created yet.", "Cannot output metod tests of triplets", MessageBoxButtons.OK);
            }
        }
    }
}
