using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLC_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void table1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tourist_AttractionsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourist_AttractionsDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.tourist_AttractionsDataSet.Table1);
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            S_button.Visible = false;
            string c1 = att_comboBox.SelectedItem.ToString();
            string c2 = LOC_comboBox.SelectedItem.ToString();
            string c3 = ava_comboBox.SelectedItem.ToString();
            string c4 = Cost_comboBox.SelectedItem.ToString();
            string c5 = Rating_comboBox.SelectedItem.ToString();

            //LINQ Example:
            //connection string  
            // Query database  
            var contactDetails =
               from c in tourist_AttractionsDataSet.Table1
               where c.attraction == c1
               where c.location == c2
               where c.availability == c3
               where c.cost == c4
               where c.ratings == c5
               select c;
            table1DataGridView.DataSource = contactDetails.AsDataView();

            if (contactDetails.Count()==0)
            {
                groupBox1.Visible = true;
                name_textBox.Text = "Sorry we could not find anything that fits your description";
                groupBox2.Visible = false;
            }
            foreach (Tourist_AttractionsDataSet.Table1Row item in contactDetails)
            {
                name_textBox.Clear();
                name_textBox.Text += item._name + "\n";
                groupBox1.Visible = true;
                number_label.Visible = true;
                label8.Visible = true;
                number_label.Text = contactDetails.Count().ToString();
                label0.Visible = false;
                groupBox2.Visible = false;
            }





            //comboBox3.Text = attractionTextBox.Text;
            //comboBox1.Text = locationTextBox.Text;
            //comboBox2.Text = availabilityTextBox.Text;
            //comboBox4.Text = costTextBox.Text;
            //comboBox5.Text = ratingsTextBox.Text;
            //comboBox5.Text = ratingsTextBox.Text;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void _nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void go_back_button_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            reset();
        }




        private void att_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOC_comboBox.Visible = true;

        }

        private void LOC_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ava_comboBox.Visible = true;
        }

        private void ava_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cost_comboBox.Visible = true;
        }

        private void Cost_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rating_comboBox.Visible = true;
        }

        private void Rating_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            S_button.Visible = true;
        }

        void reset()
        {
            att_comboBox.SelectedIndex = -1;

            LOC_comboBox.SelectedIndex = -1;
            LOC_comboBox.Visible = false;

            ava_comboBox.SelectedIndex = -1;
            ava_comboBox.Visible = false;

            Cost_comboBox.SelectedIndex = -1;
            Cost_comboBox.Visible = false;

            Rating_comboBox.SelectedIndex = -1;
            Rating_comboBox.Visible = false;
            

            S_button.Visible = false;

            groupBox2.Visible = true;

            /////////////////////////////

            number_label.Visible = false;
            label8.Visible = false;
            label0.Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lol_button.Visible = true;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lol_button.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
