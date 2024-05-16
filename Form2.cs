using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ges_scolaire
{
    public partial class Form2 : Form
    {
        gesscolaireEntities1 context = new gesscolaireEntities1();
        public Form2()
        {
            InitializeComponent();
            cmbclasse.DataSource = context.Classe.ToList();
            //cmbclasse.DataSource = context.Classe.ToList();
            cmbclasse.DisplayMember = "libelle";
            cmbclasse.ValueMember = "id";
            dGV1.DataSource = context.Etudiant.ToList();

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            Etudiant etudiants = new Etudiant();
            etudiants.prenom = txtprenom.Text;
            etudiants.nom = txtnom.Text;
            etudiants.credit = int.Parse(txtcredit.Text);
            etudiants.versement = int.Parse(txtreglement.Text);
            etudiants.annescolaire = txtanne.Text;
            etudiants.idClasse = Convert.ToInt32(cmbclasse.SelectedValue);
            context.Etudiant.Add(etudiants);
            context.SaveChanges();

            MessageBox.Show("Ajout reussi...");
            dGV1.DataSource = context.Etudiant.ToList();
            effacer();
        }

        private void dGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dGV1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtprenom.Text = row.Cells[1].Value.ToString();
                txtnom.Text = row.Cells[2].Value.ToString();
                txtcredit.Text = row.Cells[3].Value.ToString();
                txtreglement.Text = row.Cells[4].Value.ToString();
                txtanne.Text = row.Cells[5].Value.ToString();
                cmbclasse.Text = row.Cells[6].Value.ToString();

            }
        }

        void effacer()
        {
            txtprenom.Text = "";
            txtnom.Text = "";
            txtcredit.Text = "";
            txtreglement.Text = "";
            txtanne.Text = "";
            cmbclasse.Text = "";
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            var context = new gesscolaireEntities1();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                Etudiant personneToUpdate = context.Etudiant.Find(entityId);

                if (personneToUpdate != null)
                {
                    personneToUpdate.prenom = txtprenom.Text;
                    personneToUpdate.nom = txtnom.Text;
                    personneToUpdate.credit = int.Parse(txtcredit.Text);
                    personneToUpdate.versement = int.Parse(txtreglement.Text);
                    personneToUpdate.annescolaire = txtanne.Text;
                    personneToUpdate.idClasse = Convert.ToInt32(cmbclasse.SelectedValue);
                    context.SaveChanges();
                    MessageBox.Show("Modification réussie...");
                    dGV1.DataSource = context.Etudiant.ToList();
                    effacer();
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

        private void btnsuprimer_Click(object sender, EventArgs e)
        {
            var context = new gesscolaireEntities1();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                Etudiant etudiantToDelete = context.Etudiant.Find(entityId);

                if (etudiantToDelete != null)
                {
                    context.Etudiant.Remove(etudiantToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Suppression réussie...");
                    dGV1.DataSource = context.Etudiant.ToList();
                    effacer();
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
            string searchText = txtrechercher.Text.Trim();
            string libelleClasse = cmbclasse.Text.Trim();

            var etudiants = context.Etudiant.AsQueryable();

            if (!string.IsNullOrEmpty(searchText))
            {
                etudiants = etudiants.Where(etudiant => etudiant.annescolaire.StartsWith(searchText));
            }

            if (!string.IsNullOrEmpty(libelleClasse))
            {
                etudiants = etudiants.Where(etudiant => etudiant.Classe.libelle.Contains(libelleClasse));
            }

            dGV1.DataSource = etudiants.ToList();

        }
    }
}
