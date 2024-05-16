using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ges_scolaire
{
    public partial class Form1 : Form
    {
        gesscolaireEntities1 context = new gesscolaireEntities1();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = context.Classe.ToList();
        }

        private void btnenreg_Click(object sender, EventArgs e)
        {
            Classe classe = new Classe();
            classe.libelle = cmbniveau.Text + cmbspecialite.Text;
            classe.niveau = cmbniveau.Text;
            classe.specialite = cmbspecialite.Text;

            context.Classe.Add(classe);
            context.SaveChanges();

            MessageBox.Show("Ajout reussi...");
            dataGridView1.DataSource = context.Classe.ToList();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            var context = new gesscolaireEntities1();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                Classe personneToUpdate = context.Classe.Find(entityId);

                if (personneToUpdate != null)
                {
                    personneToUpdate.libelle = cmbniveau.Text + " " + cmbspecialite.Text;
                    personneToUpdate.niveau = cmbniveau.Text;
                    personneToUpdate.specialite = cmbspecialite.Text;
                    context.SaveChanges();
                    MessageBox.Show("Modification réussie...");
                    dataGridView1.DataSource = context.Classe.ToList();
                }
                else
                {
                    MessageBox.Show("Entité à mettre à jour non trouvée.");
                }
            }
            else
            {
                MessageBox.Show("ID invalide.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                cmbniveau.Text = row.Cells[2].Value.ToString();
                cmbspecialite.Text = row.Cells[3].Value.ToString();
                
            }
        }

        private void btneffacer_Click(object sender, EventArgs e)
        {
            cmbniveau.Text = "";
            cmbspecialite.Text = "";
        }

        private void btnsuprimer_Click(object sender, EventArgs e)
        {
            var context = new gesscolaireEntities1();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                Classe classeToDelete = context.Classe.Find(entityId);

                if (classeToDelete != null)
                {
                    context.Classe.Remove(classeToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Suppression réussie...");
                    dataGridView1.DataSource = context.Classe.ToList();
                }
                else
                {
                    MessageBox.Show("Entité à supprimer non trouvée.");
                }
            }
            else
            {
                MessageBox.Show("ID invalide.");
            }
        }


        private void btnrechercher_Click(object sender, EventArgs e)
        {
            var context = new gesscolaireEntities1();
            string searchTerm = txtrechercher.Text.Trim();
            var result = context.Classe
                                .Where(c => c.libelle.Contains(searchTerm) || c.niveau.Contains(searchTerm) || c.specialite.Contains(searchTerm))
                                .ToList();
            dataGridView1.DataSource = result;
        }
    }
}
