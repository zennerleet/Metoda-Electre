using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace metodaElectre
{
    public partial class Calificative : Form
    {
        private Details details;
        private bool submited = false;
        private int pers;
        private List<Criterion> critList;
        private Dictionary<Criterion, int> listOfCriteria;
       
        public Calificative(Details details)
        {
            InitializeComponent();
            this.details = details;

            pers = details.getPersNo();
            critList = details.getCritList();


            fillDataGrid(matrice);
        }
        public int getPers()
        {
            return pers;
        }
        public List<Criterion> getCriteria()
        {
            return critList;
        }
        public DataGridView getMatrix()
        {   
            return matrice;
        }
        private List<Person> createPeople()
        {
            List<Person> list = new List<Person>();
            listOfCriteria = new Dictionary<Criterion, int>();
            for (int rand = 0; rand < matrice.Rows.Count; rand++)
            {
                listOfCriteria = new Dictionary<Criterion, int>();
                for (int coloana = 1, randNo = 0; coloana < matrice.Columns.Count && randNo < critList.Count; randNo++, coloana++)
                {
                    listOfCriteria.Add(critList[randNo],  Int32.Parse(matrice.Rows[rand].Cells[coloana].Value.ToString()));
                }
                list.Add(new Person(listOfCriteria));
            }
            return list;
        }
        public void fillDataGrid(DataGridView matrice)
        {
            matrice.Columns.Add("", "");
            for (int i = 1; i <= critList.Count; i++)
            {
                matrice.Columns.Add("Criteriul " + i, "Criteriul " + i);
            }
            for (int i = 1; i <= pers; i++)
            {
                matrice.Rows.Add("Persoana " + i);
            } 
        }
        private int getMin(int column)
        {
            int min = Int32.Parse(matrice.Rows[0].Cells[column].Value.ToString());
            for (int i = 0; i < matrice.Rows.Count; i++)
            {
                if (Int32.Parse(matrice.Rows[i].Cells[column].Value.ToString()) < min)
                    min = Int32.Parse(matrice.Rows[i].Cells[column].Value.ToString());
            }
            return min;
        }
        private int getMax(int column)
        {
            int min = Int32.Parse(matrice.Rows[0].Cells[column].Value.ToString());
            for (int i = 0; i < matrice.Rows.Count; i++)
            {
                if (Int32.Parse(matrice.Rows[i].Cells[column].Value.ToString()) > min)
                    min = Int32.Parse(matrice.Rows[i].Cells[column].Value.ToString());
            }
            return min;
        }
        private void setMinMax()
        {
            List<int> maxes = new List<int>(); 
            List<int> mins = new List<int>();

            for (int coloana = 1; coloana < matrice.Columns.Count; coloana++)
            {
                mins.Add(getMin(coloana));
                maxes.Add(getMax(coloana));
            }
            if (submited)
            {
                matrice.Rows.RemoveAt(matrice.Rows.Count - 3);
                matrice.Rows.RemoveAt(matrice.Rows.Count - 2);
                matrice.Rows.RemoveAt(matrice.Rows.Count - 1);
            }
            matrice.Rows.Add();
            matrice.Rows.Add();
            matrice.Rows.Add();
            matrice.Rows[matrice.Rows.Count - 3].Cells[0].Value = "Maxim";
            matrice.Rows[matrice.Rows.Count - 3].DefaultCellStyle.BackColor = Color.CadetBlue;
            matrice.Rows[matrice.Rows.Count - 2].Cells[0].Value = "Minim";
            matrice.Rows[matrice.Rows.Count - 2].DefaultCellStyle.BackColor = Color.CadetBlue;
            matrice.Rows[matrice.Rows.Count - 1].Cells[0].Value = "Diferenta";
            matrice.Rows[matrice.Rows.Count - 1].DefaultCellStyle.BackColor = Color.CadetBlue;
            for (int coloana = 1; coloana < matrice.Columns.Count; coloana++)
            {
                matrice.Rows[matrice.Rows.Count - 3].Cells[coloana].Value = maxes[coloana - 1];
                matrice.Rows[matrice.Rows.Count - 2].Cells[coloana].Value = mins[coloana - 1];
                matrice.Rows[matrice.Rows.Count - 1].Cells[coloana].Value = maxes[coloana - 1] - mins[coloana-1];
            }

            
        }
        public void testFill()
        {
            matrice.Rows[0].Cells[1].Value = 2;
            matrice.Rows[0].Cells[2].Value = 2;
            matrice.Rows[0].Cells[3].Value = 3;


            matrice.Rows[1].Cells[1].Value = 3;
            matrice.Rows[1].Cells[2].Value = 1;
            matrice.Rows[1].Cells[3].Value = 2;


            matrice.Rows[2].Cells[1].Value = 1;
            matrice.Rows[2].Cells[2].Value = 3;
            matrice.Rows[2].Cells[3].Value = 2;


            matrice.Rows[3].Cells[1].Value = 3;
            matrice.Rows[3].Cells[2].Value = 2;
            matrice.Rows[3].Cells[3].Value = 1;


            matrice.Rows[4].Cells[1].Value = 3;
            matrice.Rows[4].Cells[2].Value = 1;
            matrice.Rows[4].Cells[3].Value = 2;

        }
        private bool checkValues()
        {
            for (int rand = 0; rand < matrice.Rows.Count; rand++)
            {
                for (int coloana = 1; coloana < matrice.Columns.Count; coloana++)
                {
                    if (matrice.Rows[rand].Cells[coloana].Value == null) return false;
                }
            }

            return true;
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            if (!checkValues()) return;
            List<Person> list = createPeople();
            setMinMax();
            submited = true;

            Utilities utilities = new Utilities(this);
            utilities.Show();

            ConcDisco cd = new ConcDisco(this, utilities);
            cd.Show();
        }
        
        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
