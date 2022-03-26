using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appli
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            

            //connexion doc = new connexion();
            //doc.MdiParent = this;
            //doc.WindowState = FormWindowState.Maximized;
            //doc.Show();
            //doc.Update();
            this.ribbon.Enabled = false;
            //connexion
            this.connecter.Click += new System.EventHandler(this.connecter_Executed);

            //Ajouter article
            this.ajoutArt.Command = this.AppCommandNew;
            this.AppCommandNew.Name = "AppCommandNew";
            this.AppCommandNew.Executed += new System.EventHandler(this.AppCommandNew_Executed);

            //Modifier un article
            this.BModifierArticle.Command = this.EditArticleCommand;
            this.BModifierArticle.Name = "EditAticleCommand";
            this.EditArticleCommand.Executed += new System.EventHandler(this.EditArticleCommand_Executed);

            //Supprimer un article
            this.BSupprimerArticle.Command = this.listeArticleCommand;
            this.listeArticleCommand.Name = "DeleteArticleCommand";
            this.listeArticleCommand.Executed += new System.EventHandler(this.listeArticleCommand_Executed);

            //Liste des article
            this.BListeArticle.Command = this.listeArticleCommands;
            this.listeArticleCommands.Executed += new System.EventHandler(this.listeArticleCommands_Executed);

            //nouvelle commande
            this.BNewCommand.Command = this.NewCommandeCommand;
            this.NewCommandeCommand.Executed += new System.EventHandler(this.NewCommandeCommand_Executed);

            //demande dévis
            this.BDemandeDevis.Command = this.NewDemandeCommand;
            this.NewDemandeCommand.Executed += new System.EventHandler(this.NewDemandeCommand_Executed);

            //modifier commande
            this.BModifCommand.Command = this.ModifierCommandeCommand;
            this.ModifierCommandeCommand.Executed += new System.EventHandler(this.ModifierCommandeCommand_Executed);

            //nouvelle entrée
            this.Blivraison.Command = this.commandEntrerLivraison;
            this.commandEntrerLivraison.Executed += new System.EventHandler(this.entrerLivraison_Executed);

            this.Batelier.Command = this.NewEntreCommand;
            this.NewEntreCommand.Executed += new System.EventHandler(this.entrerAchat_Executed);

            this.Bachat.Command = this.commandEntrerAutre;
            this.commandEntrerAutre.Executed += new System.EventHandler(this.entrerAtelier_Executed);

            //nouvelle vente
            this.Bvente.Command = this.NewVenteCommand;
            this.NewVenteCommand.Executed += new System.EventHandler(this.NewVenteCommand_Executed);
            
            //Sortie pour fabrication
            this.Bfabrication.Command = this.FabricationCommand;
            this.FabricationCommand.Executed += new System.EventHandler(this.FabricationCommand_Executed);

            //Sortie pour depannage
            this.Bdepannage.Command = this.DepannageCommand;
            this.DepannageCommand.Executed += new System.EventHandler(this.DepannageCommand_Executed);

            //consulter entrée
            this.BConsulterEntres.Command = this.ConsulterEntreCommand;
            this.ConsulterEntreCommand.Executed += new System.EventHandler(this.ConsulterEntreComand_Executed);


            //Consulter Sortie
            this.BConsulterSortie.Command = this.ConsulterSortieCommand;
            this.ConsulterSortieCommand.Executed += new System.EventHandler(this.ConsulterSortieCommand_Executed);

            //Nouvelle prestation
            this.BAjoutDepannage.Command = this.AjoutDepaCommand;
            this.AjoutDepaCommand.Executed += new System.EventHandler(this.AjoutDepaCommand_Executed);

            this.BAjoutFabrication.Command = this.AjoutFabriCommand;
            this.AjoutFabriCommand.Executed += new System.EventHandler(this.AjoutFabriCommand_Executed);

            //Modifier prestation
            this.BModDepannage.Command = this.ModiferDepaCommand;
            this.ModiferDepaCommand.Executed += new System.EventHandler(this.ModifierDepaCommand_Executed);

            this.BModFabrication.Command = this.ModifierFabriCommand;
            this.ModifierFabriCommand.Executed += new System.EventHandler(this.ModifierFabriCommand_Executed);

            //Supprimer prestation
            this.BSupDepannage.Command = this.SupDepaCommand;
            this.SupDepaCommand.Executed += new System.EventHandler(this.SupDepaCommand_Executed);

            this.BSupFabrication.Command = this.SupFabriCommand;
            this.SupFabriCommand.Executed += new System.EventHandler(this.SupFabriCommand_Executed);

            //cloture prestation
            //this.BEnregCloture.Command = this.CloturePresCommand;
            //this.CloturePresCommand.Executed += new System.EventHandler(this.CloturePresCommand_Executed);

            this.clotureDepannage.Command = this.CloturePresCommand;
            this.CloturePresCommand.Executed += new System.EventHandler(this.CloturePresCommand_Executed);

            this.clotureFabrication.Command = this.clotureFabCommand;
            this.clotureFabCommand.Executed += new System.EventHandler(this.clotureFabCommand_Executed);

            this.BModifCloture.Command = this.ModifClotureCommand;
            this.ModifClotureCommand.Executed += new System.EventHandler(this.ModifClotureCommand_Executed);
            //
            //Gestion client
            //Ajout client
            this.BAjouterClients.Command = this.AjoutClientCommand;
            this.AjoutClientCommand.Executed += new System.EventHandler(this.AjoutClientCommand_Executed);
            //modifier client
            this.BModClient.Command = this.ModifierClientCommand;
            this.ModifierClientCommand.Executed += new System.EventHandler(this.ModifierClientCommand_Executed);
            //supprimer client
            this.BSupClient.Command = this.SupprimerClientCommand;
            this.SupprimerClientCommand.Executed += new System.EventHandler(this.SupprimerClientCommand_Exeuted);
           
            //modifier statut client
            this.BModStatutClient.Command = this.ModifierStatutClientCommand;
            this.ModifierStatutClientCommand.Executed += new System.EventHandler(this.ModifierStatutClientCommand_Executed);
            //
            //Formation
            //
            //Ajout formation
            this.nouvelFormation.Command = this.nouvelFormationCommand;
            this.nouvelFormationCommand.Executed += new System.EventHandler(this.nouvelFormationCommand_Executed);

            //Modifier formation
            this.modifierFormation.Command = this.modiForamtionCommand;
            this.modiForamtionCommand.Executed += new System.EventHandler(this.modiFormationCommand_Executed);

            //supprimer formation
            this.supFormation.Command = this.supFormationCommand;
            this.supFormationCommand.Executed += new System.EventHandler(this.supFormationCommand_Executed);
            //
            //Enseignant
            //
            //Nouveau enseignant
            this.nouveauEnseignant.Command = this.NouveauEnseignantCommand;
            this.NouveauEnseignantCommand.Executed += new System.EventHandler(this.nouveauEnseignantCommand_Executed);

            //modifier enseignant
            this.modifEnseignant.Command = this.modifierEnseignantCommand;
            this.modifierEnseignantCommand.Executed += new System.EventHandler(this.modifierEnseignantCommand_Executed);

            //Supprimer enseignant
            this.supEnseignant.Command = this.supprimerEnseignantCommand;
            this.supprimerEnseignantCommand.Executed += new System.EventHandler(this.supprimerEnseignantCommand_Excuted);

            //attribuer cours
            this.attribCours.Command = this.attribuerCoursCommand;
            this.attribuerCoursCommand.Executed += new System.EventHandler(this.attribuerCoursCommand_Executed);

            //retirer enseignant
            this.retirerCours.Command = this.retirerCoursCommand;
            this.retirerCoursCommand.Executed += new System.EventHandler(this.retirerCoursCommand_Executed);

            //test
            this.inscriEleve.Command = this.inscrireEleve;
            //this.inscrireEleve.Executed += new System.EventHandler(this.inscriEleve_Executed);

            //Attribuer prestation
            this.attribDep.Command = this.attribDepCommand;
            this.attribDepCommand.Executed += new System.EventHandler(this.attribDep_Executed);

            this.attribFab.Command = this.attribFabCommand;
            this.attribFabCommand.Executed += new System.EventHandler(this.attribFab_Executed);

            //liiste prestation
            this.listeDep.Command = this.listeDepCommand;
            this.listeDepCommand.Executed += new System.EventHandler(this.listeDep_Executed);

            this.listeFab.Command = this.listeFabCommand;
            this.listeFabCommand.Executed += new System.EventHandler(this.listeFab_Executed);

            //Etat vente
            this.BCorbeille.Command = this.commandEtatVente;
            this.commandEtatVente.Executed += new System.EventHandler(this.etatVente_Executed);

            //valider facture
            this.validerFacture.Command = this.commandValiderFac;
            this.commandValiderFac.Executed += new System.EventHandler(validerFacture_Executed);
        }

        public void visible()
        {
            this.gestock.Enabled = true;
            this.prestarib.Enabled = true;
            this.gestclient.Enabled = true;
            this.gestforma.Enabled = true;
            this.ajoutArt.Enabled = true;
        }
        //connexion
        public void connecter_Executed(object sender, object e)
        {
            ConnexionDB c = new ConnexionDB();

            string query = "Select mdp from employe where type_employe = '" + this.fonction.Text + "' and login = '" + this.login.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mdp.Text = reader.GetString("mdp");
                }
                reader.Close();
                c.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (pwd.Text == mdp.Text)
            {      
                this.authentification.Visible= false;
                this.panelAuthentification.Visible = false;
                this.ribbon.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Appel du formulaire d'ajout d'un article
        private void AppCommandNew_Executed(object sender, EventArgs e)
        {
            // Close Application Menu
            buttonFile.Expanded = false;

            EnregistrerArticle doc = new EnregistrerArticle();
            //doc.Text = "New Document " + (this.MdiChildren.Length + 1);
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel du formulaire de modification d'un article
        private void EditArticleCommand_Executed(object sender, EventArgs e)
        {
            buttonFile.Expanded = false;
            modifierArticle doc = new modifierArticle();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        //Appel du formulaire de suppression d'un atticle
        private void listeArticleCommand_Executed(object sender, EventArgs e)
        {
            buttonFile.Expanded = false;
            SupprimerArticle doc = new SupprimerArticle();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        //Appel du formulaire liste
        private void listeArticleCommands_Executed(object sender, EventArgs e)
        {
            buttonFile.Expanded = false;
            listeArticle doc = new listeArticle();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        //Appel formulaire nouvelle commande
        private void NewCommandeCommand_Executed(object sender, EventArgs e)
        {
            nouvelleCommande doc = new nouvelleCommande();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        //Appel formulaire demande dévis
        private void NewDemandeCommand_Executed(object sender, EventArgs e)
        {
            demandeDevis doc = new demandeDevis();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire modification de la commande
        private void ModifierCommandeCommand_Executed(object sender, EventArgs e)
        {
            modifierCommande doc = new modifierCommande();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire entrer en stock
        private void entrerAtelier_Executed(object sender, EventArgs e)
        {
            EnregistrerEntree doc = new EnregistrerEntree();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire entrer en stock pour achat
        private void entrerAchat_Executed(object sender, EventArgs e)
        {
            EnregistrerEntree doc = new EnregistrerEntree();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire entrer en stock
        private void entrerLivraison_Executed(object sender, EventArgs e)
        {
            entrerLivraison doc = new entrerLivraison();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire vente
        private void NewVenteCommand_Executed(object sender, EventArgs e)
        {
            SortieVente doc = new SortieVente();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire sortie pour fabrication
        private void FabricationCommand_Executed(object sender, EventArgs e)
        {
            SortieFabrication doc = new SortieFabrication();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire sortie pour depannage
        private void DepannageCommand_Executed(object sender, EventArgs e)
        {
            SortieDepannage doc = new SortieDepannage();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire consulterentrée
        private void ConsulterEntreComand_Executed(object sender, EventArgs e)
        {
            ConsulterEntre doc = new ConsulterEntre();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire Consuter sortie
        private void ConsulterSortieCommand_Executed(object sender, EventArgs e)
        {
            ConsulterSortie  doc =new ConsulterSortie();
            doc.MdiParent=this;
            doc.WindowState=FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire ajout depannage
        private void AjoutDepaCommand_Executed(object sender, EventArgs e)
        {
            AjoutDepannage doc = new AjoutDepannage();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            
        }
        //Appel formulaire ajout fabrication
        private void AjoutFabriCommand_Executed(object sender, EventArgs e)
        {
            ajoutFabrication doc = new ajoutFabrication();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire modifier depannage
        private void ModifierDepaCommand_Executed(object sender, EventArgs e)
        {
            ModifierDepannage doc = new ModifierDepannage();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire modifier fabrication
        private void ModifierFabriCommand_Executed(object sender, EventArgs e)
        {
            ModifierFabrication doc = new ModifierFabrication();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire supprimer depannage
        private void SupDepaCommand_Executed(object sender, EventArgs e)
        {
            SupprimerDepannage doc = new SupprimerDepannage();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formualire supprimer fabrication
        private void SupFabriCommand_Executed(object sender, EventArgs e)
        {
            SupprimerFabrication doc = new SupprimerFabrication();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire cloture prestation
        private void CloturePresCommand_Executed(object sender, EventArgs e)
        {
            CloturerPrestattion doc = new CloturerPrestattion();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        private void clotureFabCommand_Executed(object sender, EventArgs e)
        {
            cloturerFabrication doc = new cloturerFabrication();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire modifier cloture
        private void ModifClotureCommand_Executed(object sender, EventArgs e)
        {
            ModifierCloture doc = new ModifierCloture();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //
        //Gestion client
        //
        //Appel formulaire ajout client
        private void AjoutClientCommand_Executed(object sender, EventArgs e)
        {
            AjoutClient doc = new AjoutClient();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire modifier client
        private void ModifierClientCommand_Executed(object sender, EventArgs e)
        {
            ModifierClient doc = new ModifierClient();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire supprimer client
        private void SupprimerClientCommand_Exeuted(object sender, EventArgs e)
        {
            SupprimerClient doc = new SupprimerClient();
            doc.MdiParent = this;
            doc.WindowState= FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire modifier statut client
        private void ModifierStatutClientCommand_Executed(object sender, EventArgs e)
        {
            ModifierStatutClient doc = new ModifierStatutClient();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire liste client
        private void ListeClientCommand_Executed(object sender, EventArgs e)
        {
            ListeClient doc = new ListeClient();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire ajout formation
        private void nouvelFormationCommand_Executed(object sender, EventArgs e)
        {
            ajoutFormation doc = new ajoutFormation();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire modifier formation
        private void modiFormationCommand_Executed(object sender, EventArgs e)
        {
            modifierFormation doc = new modifierFormation();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire supprimer formation
        private void supFormationCommand_Executed(object sender, EventArgs e)
        {
            supFormation doc = new supFormation();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire ajout enseignant
        private void nouveauEnseignantCommand_Executed(object sender, EventArgs e)
        {
            ajoutEnseignant doc = new ajoutEnseignant();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire modifier ennseignant
        private void supprimerEnseignantCommand_Excuted(object sender, EventArgs e)
        {
            supEnseignant doc = new supEnseignant();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire supprimer enseignant
        private void modifierEnseignantCommand_Executed(object sender, EventArgs e)
        {
            modifierEnseignant doc = new modifierEnseignant();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire attribuer cours
        private void attribuerCoursCommand_Executed(object sender, EventArgs e)
        {
            attribuerCours doc = new attribuerCours();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }
        //Appel formulaire retirer cours
        private void retirerCoursCommand_Executed(object sender, EventArgs e)
        {
            retirerCours doc = new retirerCours();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

      //Appel insricre élève
        //private void inscriEleve_Executed(object sender, EventArgs e)
        //{
        //    test doc = new test();
        //    doc.MdiParent = this;
        //    doc.WindowState = FormWindowState.Maximized;
        //    doc.Show();
        //    doc.Update();
        //}

        //Appel 
        
        //Attribuer un dépannage
        private void attribDep_Executed(object sender, EventArgs e)
        {
            attribuerPrestation doc = new attribuerPrestation();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        //attribuer une fabrication
        private void attribFab_Executed(object sender, EventArgs e)
        {
            attribuerFabrication doc = new attribuerFabrication();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        //liste depannage
        private void listeDep_Executed(object sender, EventArgs e)
        {
            listeDepannage doc = new listeDepannage();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        //liste fabrication
        private void listeFab_Executed(object sender, EventArgs e)
        {
            listeFabrication doc = new listeFabrication();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        //etat des ventes
        private void etatVente_Executed(object sender, EventArgs e)
        {
            etatVente doc = new etatVente();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        //valider facture
        private void validerFacture_Executed(object sender, EventArgs e)
        {
            validerSortie doc= new validerSortie();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        public void activer()
        {
            this.gestock.Enabled = true;
            this.prestarib.Enabled = true;
            this.gestclient.Enabled = true;
            this.gestforma.Enabled = true;
        }
    }
}
