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
    public partial class Utilities : Form
    {
        private Calificative calificative;
        private DataGridView model;
        public Utilities(Calificative calificative)
        {
            InitializeComponent();
            this.calificative = calificative;
            this.model = calificative.getMatrix();

            calificative.fillDataGrid(matrice);

            fillUtilities();

        }
        public DataGridView getMatrix()
        {
            return this.matrice;
        }
        private int getMin(int col)
        {
            return Int32.Parse(model.Rows[model.Rows.Count - 2].Cells[col].Value.ToString());

        }
        private int getMax(int col)
        {
            return Int32.Parse(model.Rows[model.Rows.Count - 3].Cells[col].Value.ToString());
        }
        private int getDiff(int col)
        {
            return Int32.Parse(model.Rows[model.Rows.Count - 1].Cells[col].Value.ToString());
        }
        private void fillUtilities()
        {
            for (int rand = 0; rand < matrice.Rows.Count; rand++)
            {
                for (int col = 1; col < matrice.Columns.Count; col++)
                {
                    int currentValue = Int32.Parse (model.Rows[rand].Cells[col].Value.ToString());
                    matrice.Rows[rand].Cells[col].Value = (double)(currentValue - getMin(col)) / getDiff(col);
                }
            }
        }
        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
