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
    public partial class ConcDisco : Form
    {
        private Calificative calificative;
        private Utilities utilities;
        private DataGridView model;
        public ConcDisco(Calificative calificative, Utilities utilities)
        {
            InitializeComponent();
            this.calificative = calificative;
            this.utilities = utilities;
            this.model = utilities.getMatrix();
            this.fillDataGrid();
            this.fillConcordante();
            this.fillDiscordante();
            this.fillMinC(1);
            this.fillMaxD(1);
            this.fillFinalCol(1);
            this.chooseBestPerson();
        }
        private double getCriteriaImportance(int criteria)
        {
            return calificative.getCriteria()[criteria-1].getImportanceCoefficient();
        }
        private void setPersoanaConcordanta(int persoana1, int persoana2, double val)
        {
            if (persoana1 == persoana2) val = 1;

            int linie = persoana1;
            int col = 2 * persoana2 - 1;

            matrice.Rows[linie].Cells[col].Value = val;
        }
        private double getPersoanaUtilitati(int persoana, int criteriu)
        {
            return (double)model.Rows[persoana-1].Cells[criteriu].Value;
        }
        private double getDiscordanta(int persoana1, int persoana2)
        {
            int linie = persoana1;
            int col = 2 * persoana2;
            return (double)matrice.Rows[linie].Cells[col].Value;
        }
        private double getConcordanta(int persoana1, int persoana2)
        {
            int linie = persoana1;
            int col = 2 * persoana2 - 1;
            double conc = (double)matrice.Rows[linie].Cells[col].Value;

            return conc;
        }
        private double getMaxDiscordanta(int persoana)
        {
            int pers = calificative.getPers();
            double min = getDiscordanta(1, 2);
            for (int p = 1; p <= pers; p++)
            {
                if (getConcordanta(persoana, p) > min)
                    min = getDiscordanta(persoana, p);
            }
            return min;
        }
        private double getMinConcordanta(int persoana)
        {  
            int pers = calificative.getPers();
            double min = getConcordanta(1, 2);
            for (int p = 1; p <= pers; p++)
            {
              if (getConcordanta(persoana, p) < min)
                min = getConcordanta(persoana, p);
            }
            return min;
        }
        private void fillConcordante()
        {
            int pers = calificative.getPers();
            int nrCrit = calificative.getCriteria().Count;
            for (int persoana1 = 1; persoana1 <= pers; persoana1++)
            {
                for (int persoana2 = 1; persoana2 <= pers; persoana2++)
                {
                    double sum = 0;
                    for (int criteriu = 1; criteriu <= nrCrit; criteriu++)
                    {
                        if (getPersoanaUtilitati(persoana1, criteriu) >= getPersoanaUtilitati(persoana2, criteriu))
                        {
                            sum = sum + getCriteriaImportance(criteriu);
                        }
                    }
                    setPersoanaConcordanta(persoana1, persoana2, sum);
                }
            }
            
        }
        private void setPersoanaDiscordanta(int persoana1, int persoana2, double val)
        {
            if (persoana1 == persoana2) val = 0;

            int linie = persoana1;
            int col = 2 * persoana2;

            matrice.Rows[linie].Cells[col].Value = val;
            matrice.Rows[linie].Cells[col].Style.BackColor = Color.OrangeRed;
        }
        private void fillDiscordante()
        {
            int pers = calificative.getPers();
            int nrCrit = calificative.getCriteria().Count;
            for (int persoana1 = 1; persoana1 <= pers; persoana1++)
            {
                for (int persoana2 = 1; persoana2 <= pers; persoana2++)
                {
                    double max = getPersoanaUtilitati(persoana2, 1) - getPersoanaUtilitati(persoana1, 1);
                    for (int criteriu = 1; criteriu <= nrCrit; criteriu++)
                    {
                        double diff = getPersoanaUtilitati(persoana2, criteriu) - getPersoanaUtilitati(persoana1, criteriu);
                        if (diff < 0) diff = 0;
                        if (diff > max) max = diff;
                    }
                    setPersoanaDiscordanta(persoana1, persoana2, max);
                }
            }
        }
        private void fillMinC(int offset)
        {
            matrice.Columns.Add("", "");
            matrice.Rows[0].Cells[matrice.Columns.Count - offset].Value = "Min C";
            for (int rand = 1; rand < matrice.Rows.Count; rand++)
            {
                matrice.Rows[rand].Cells[matrice.Columns.Count - offset].Value = getMinConcordanta(rand);
                matrice.Rows[rand].Cells[matrice.Columns.Count - offset].Style.BackColor = Color.CadetBlue;
            }
        }
        private void fillMaxD(int offset)
        {
            matrice.Columns.Add("", "");
            matrice.Rows[0].Cells[matrice.Columns.Count - offset].Value = "Max D";
            for (int rand = 1; rand < matrice.Rows.Count; rand++)
            {
                matrice.Rows[rand].Cells[matrice.Columns.Count - offset].Value = getMaxDiscordanta(rand);
                matrice.Rows[rand].Cells[matrice.Columns.Count - offset].Style.BackColor = Color.CadetBlue;
            }
        }
        
        private void fillFinalCol(int offset)
        {
            matrice.Columns.Add("", "");
            matrice.Rows[0].Cells[matrice.Columns.Count - offset].Value = "min(minC, 1 - maxD)";
            for (int rand = 1; rand < matrice.Rows.Count; rand++)
            {
                matrice.Rows[rand].Cells[matrice.Columns.Count - offset].Value = Math.Min(getMinConcordanta(rand), 1 - getMaxDiscordanta(rand));
                matrice.Rows[rand].Cells[matrice.Columns.Count - offset].Style.BackColor = Color.CadetBlue;
            }
        }
        private void chooseBestPerson()
        {
            double max = (double)matrice.Rows[1].Cells[matrice.Columns.Count - 1].Value;
            int currentRow = 1;
            for (int rand = 1; rand < matrice.Rows.Count; rand++)
            {
                double current = (double)matrice.Rows[rand].Cells[matrice.Columns.Count - 1].Value;
                if (current > max)
                {
                    max = current;
                    currentRow = rand;
                }
            }
            for (int cell = 0; cell < matrice.Columns.Count; cell++ )
                matrice.Rows[currentRow].Cells[cell].Style.BackColor = Color.DarkSeaGreen;
        }
        private void fillDataGrid()
        {
            int pers = calificative.getPers();
            matrice.Columns.Add("", "");

            for (int i = 1; i <= pers; i++)
            {
                matrice.Columns.Add("Persoana " + i, "Persoana " + i);
                matrice.Columns.Add("Persoana " + i, "Persoana " + i);

            }
            matrice.Rows.Add("");
            for (int i = 1, j = 2; i <= pers * 2; i += 2, j += 2)
            {
                matrice.Rows[0].Cells[i].Value = "Concordanta";
                matrice.Rows[0].Cells[j].Value = "Discordanta";
            }
            for (int i = 2; i <= pers + 1; i++)
            {
                matrice.Rows.Add("Persoana" + (i - 1));
            }
        }
    }
}
