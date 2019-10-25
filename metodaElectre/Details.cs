using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace metodaElectre
{
    [Serializable]
    public partial class Details : Form
    {
        private List<Criterion> critList;
       
        public Details()
        {
            InitializeComponent();
        }

        public List<Criterion> getCritList()
        {
            return critList;
        }
        public int getPersNo()
        {
            return (int)pers_updown.Value;
        }
        public void testFill()
        {
            pers_updown.Value = 5;
            crit_updown.Value = 3;
            imp_textbox.Text = "0.4,0.4,0.2";
        }
        private List<double> criteriaImportance()
        {
            List<double> list = new List<double>();
            string text = imp_textbox.Text;
            double sum = 0;

            if (text == null || text == "") return null;


            list = text.Split(',').Select(double.Parse).ToList();
            foreach (double elem in list)
            {
                sum = sum + elem;
            }
            if (sum != 1) return null;
            return list;
        }

        private List<Criterion> createCriteria()
        {
            List<double> list = criteriaImportance();
            if (list == null) return null;
            List<Criterion> critList = new List<Criterion>();
            foreach (double elem in list)
            {
                critList.Add(new Criterion(elem));
            }

            return critList;
        } 


        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            this.critList = createCriteria();
            if (critList == null) return;
            if (critList.Count != crit_updown.Value)
            {
                MessageBox.Show("Numarul de criterii difera de numarul de coeficienti de importanta !");
                return;
            }
            Calificative calificative = new Calificative(this);
            calificative.Show();
            if (testValues_checkBox.Checked)
            {
                calificative.testFill();
            }

        }

        private void testValues_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (testValues_checkBox.Checked)
            {
                testFill();
            }
            else
            {
                pers_updown.Value = 0;
                crit_updown.Value = 0;
                imp_textbox.Text = "";
            }
        }



    }
}
