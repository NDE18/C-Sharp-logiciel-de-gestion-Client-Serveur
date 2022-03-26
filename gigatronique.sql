-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 28, 2016 at 02:15 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `gigatronique`
--

-- --------------------------------------------------------

--
-- Table structure for table `article`
--

CREATE TABLE IF NOT EXISTS `article` (
  `reference` varchar(255) NOT NULL,
  `designation` varchar(255) NOT NULL,
  `quantite` int(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL,
  PRIMARY KEY (`reference`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `article`
--

INSERT INTO `article` (`reference`, `designation`, `quantite`, `description`, `type`) VALUES
('C14-4UF7', 'Condensateurs chimiques radiaux 35V', 4, 'Tension de service 35Vcc. -55°C à +85°C.\nSorties axiales. Polarisés.\nDisponibles aussi en 105°C par lot de 10 pièces.', 'Condensateur'),
('C20-220MF', 'Condensateurs de sauvegarde polarisés', 44, 'Pour le maintien des données lors des coupures\r\nd’alimentation. Capacité élevée. Charge rapide.\r\nSe connecte en parallèle sur l’alimentation du composant.\r\n0,22F : pas de 5,08mm, tension 5,5V, diam 12mm, hauteur 7mm.\r\n1,00F : pas de 21mm, tension 5,0V, di', 'Condensateur'),
('KIT4', 'Lot de 120 condensateurs électrochimiques', 1, 'Condensateurs polarisés de type radiaux (verticaux).\nTolérance 20%, température +85°C', 'Condensateur'),
('RES24-11V', 'Thermistances C.T.N', 33, 'Coeffi cient de température négatif.\nDiamètre 5mm, Puissance 0,5W. Tolérance 5%.\nComposant dont la résistance diminue\navec l’élévation de la température.\nAutres valeurs disponibles par sachet de 10 pièces', 'Résistance'),
('RES26-0R8 ', 'Thermistances C.T.P.', 3, 'Thermistances C.T.P.\nCoeffi cient de température positif.\nComposant dont la résistance augmente\navec l’élevation de la température.', 'Résistance'),
('RES34-100R', 'Potentiomètre rotatif mono 10 tours lin', 17, 'Axe 6,35mm métal. Percage 10,3mm. Linéaire.\nTolérance 5%, puissance 2W, Tension de service 250V', 'Résistance');

-- --------------------------------------------------------

--
-- Table structure for table `articlecloturer`
--

CREATE TABLE IF NOT EXISTS `articlecloturer` (
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  `num_prestation` varchar(255) NOT NULL,
  `prixu_cloturer` varchar(255) NOT NULL,
  `produit_cloturer` varchar(255) NOT NULL,
  `qte_cloturer` int(255) NOT NULL,
  `reference_cloturer` varchar(255) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `article_choisi`
--

CREATE TABLE IF NOT EXISTS `article_choisi` (
  `compteur` int(255) NOT NULL AUTO_INCREMENT,
  `numero` varchar(255) NOT NULL,
  `quantite_commande` int(255) NOT NULL,
  `quantite_demande` int(255) NOT NULL,
  `reference_demande` varchar(255) NOT NULL,
  PRIMARY KEY (`compteur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `article_choisi`
--

INSERT INTO `article_choisi` (`compteur`, `numero`, `quantite_commande`, `quantite_demande`, `reference_demande`) VALUES
(1, '15DEV000', 0, 7, 'RES26-0R8 '),
(2, '15DEV001', 0, 12, 'RES34-100R'),
(3, '15DEV001', 0, 23, 'C14-4UF7'),
(4, '15DEV001', 0, 34, 'RES24-11V'),
(5, '15DEV001', 0, 45, 'KIT4');

-- --------------------------------------------------------

--
-- Table structure for table `article_commande`
--

CREATE TABLE IF NOT EXISTS `article_commande` (
  `compteur` int(255) NOT NULL AUTO_INCREMENT,
  `numero_commande` varchar(255) NOT NULL,
  `quantite_commande` int(255) NOT NULL,
  `quantite_demande` int(255) NOT NULL,
  `reference_commande` varchar(255) NOT NULL,
  `quantite_livraison` int(255) NOT NULL,
  PRIMARY KEY (`compteur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=30 ;

--
-- Dumping data for table `article_commande`
--

INSERT INTO `article_commande` (`compteur`, `numero_commande`, `quantite_commande`, `quantite_demande`, `reference_commande`, `quantite_livraison`) VALUES
(1, '15COM001', 3, 0, 'KIT4', 3),
(4, '15COM001', 5, 0, 'RES24-11V', 5),
(5, '15COM001', 7, 0, 'RES26-0R8 ', 7),
(11, '15COM001', 23, 0, 'C20-220MF', 23),
(18, '15COM001', 12, 12, 'RES34-100R', 12),
(29, '15COM001', 5, 23, 'C14-4UF7', 5);

-- --------------------------------------------------------

--
-- Table structure for table `attribuer_cours`
--

CREATE TABLE IF NOT EXISTS `attribuer_cours` (
  `code_formation` varchar(255) NOT NULL,
  `date_attribution` varchar(255) NOT NULL,
  `numero_enseignant` varchar(255) NOT NULL,
  `num_attribution` varchar(255) NOT NULL,
  PRIMARY KEY (`code_formation`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `adresse_client` varchar(255) NOT NULL,
  `email_client` varchar(255) NOT NULL,
  `nom_clients` varchar(255) NOT NULL,
  `numero_client` varchar(255) NOT NULL,
  `prenom_client` varchar(255) NOT NULL,
  `tel_client` varchar(255) NOT NULL,
  `type_client` varchar(255) NOT NULL,
  `quartier_client` varchar(255) NOT NULL,
  PRIMARY KEY (`numero_client`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`adresse_client`, `email_client`, `nom_clients`, `numero_client`, `prenom_client`, `tel_client`, `type_client`, `quartier_client`) VALUES
('Dang', 'tchouolafranklin@gmail.com', 'TCHOUOLA ', '15CL001', 'Franklin', '699291517', 'Occasionnel', ''),
('BP 125 Ndéré', 'christian@gmail.com', 'OMBANG-LILE', '15CL002', 'Christian', '675673491', 'Etudiant', '');

-- --------------------------------------------------------

--
-- Table structure for table `commande`
--

CREATE TABLE IF NOT EXISTS `commande` (
  `date_commande` varchar(255) NOT NULL,
  `fournisseur` varchar(255) NOT NULL,
  `numero` int(255) NOT NULL,
  `numero_devis` varchar(255) NOT NULL,
  `statut` varchar(255) NOT NULL,
  `numero_commande` varchar(255) NOT NULL,
  PRIMARY KEY (`numero_commande`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `commande`
--

INSERT INTO `commande` (`date_commande`, `fournisseur`, `numero`, `numero_devis`, `statut`, `numero_commande`) VALUES
('jeudi 5 novembre 2015', '15FO001', 0, '', 'Complète', '15COM001'),
('jeudi 5 novembre 2015', '15FO001', 0, '', 'En cours', '15COM002'),
('mardi 15 mars 2016', '15FO001', 0, '', 'Incomplète', '16COM003');

-- --------------------------------------------------------

--
-- Table structure for table `demande_devis`
--

CREATE TABLE IF NOT EXISTS `demande_devis` (
  `date` varchar(255) NOT NULL,
  `num_devis` varchar(255) NOT NULL,
  `fournisseur` varchar(255) NOT NULL,
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `demande_devis`
--

INSERT INTO `demande_devis` (`date`, `num_devis`, `fournisseur`, `numero`) VALUES
('16/10/2015', '15DEV000', '', 1),
('05/11/2015', '15DEV001', '15FO001', 2);

-- --------------------------------------------------------

--
-- Table structure for table `depannage`
--

CREATE TABLE IF NOT EXISTS `depannage` (
  `appareil_depannage` varchar(255) NOT NULL,
  `attribution_depannage` varchar(255) NOT NULL,
  `date_enregistrer` varchar(255) NOT NULL,
  `diagnostic` varchar(255) NOT NULL,
  `nom_client` varchar(255) NOT NULL,
  `numero` varchar(255) NOT NULL,
  `num_client` varchar(255) NOT NULL,
  `num_depannage` varchar(255) NOT NULL,
  `num_employe` varchar(255) NOT NULL,
  `statut_depannage` varchar(255) NOT NULL,
  `types_client` varchar(255) NOT NULL,
  PRIMARY KEY (`num_depannage`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `depannage`
--

INSERT INTO `depannage` (`appareil_depannage`, `attribution_depannage`, `date_enregistrer`, `diagnostic`, `nom_client`, `numero`, `num_client`, `num_depannage`, `num_employe`, `statut_depannage`, `types_client`) VALUES
('Ordinateur portable', '', '26/10/2015', '', '', '', '15CL001', '15DEP000', '15EM001', 'Clôturé', 'Elève'),
('Télévision', '', '26/10/2015', 'Très délicat', 'TCHOUOLA ', '', '15CL001', '15DEP001', '15EM001', 'En cours', 'Occasionnel'),
('Radio', '', '26/10/2015', 'faire une maintenance', 'Kongne', '', '15CL000', '15DEP002', '15EM001', 'En cours', 'Elève'),
('Ordinateur', '', '13/10/2015', 'faire une maintenance', 'Kongne', '', '15CL000', '15DEP004', '15EM001', 'Clôturé', 'Elève'),
('Ordinateur', '', '30/10/2015', 'tester', 'Kongne', '', '15CL000', '15DEP005', '15EM001', 'Clôturé', 'Elève');

-- --------------------------------------------------------

--
-- Table structure for table `employe`
--

CREATE TABLE IF NOT EXISTS `employe` (
  `adresse_employe` varchar(255) NOT NULL,
  `compteur` int(255) NOT NULL,
  `email_employe` varchar(255) NOT NULL,
  `mdp` varchar(255) NOT NULL,
  `nom_employe` varchar(255) NOT NULL,
  `numero_employe` varchar(255) NOT NULL,
  `prenom_employe` varchar(255) NOT NULL,
  `telephone_employe` varchar(255) NOT NULL,
  `login` varchar(255) NOT NULL,
  `type_employe` varchar(255) NOT NULL,
  PRIMARY KEY (`numero_employe`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employe`
--

INSERT INTO `employe` (`adresse_employe`, `compteur`, `email_employe`, `mdp`, `nom_employe`, `numero_employe`, `prenom_employe`, `telephone_employe`, `login`, `type_employe`) VALUES
('Yaoundé', 0, 'denis@gamil.cm', 'merci', 'TCHANDJOU', '15EM001', 'Denis', '678643478', 'tchandjou', 'Directeur');

-- --------------------------------------------------------

--
-- Table structure for table `enseignant`
--

CREATE TABLE IF NOT EXISTS `enseignant` (
  `adresse` varchar(255) NOT NULL,
  `cni` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `profession` varchar(255) NOT NULL,
  `telephone` varchar(255) NOT NULL,
  `numero` varchar(255) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `enseignant`
--

INSERT INTO `enseignant` (`adresse`, `cni`, `email`, `nom`, `prenom`, `profession`, `telephone`, `numero`) VALUES
('Yaoundé ', '108985345', 'rodriguekongne@yahoo.fr', 'TCHANDJOU', 'DENIS', 'Enseignant', '675849536', '15EN000');

-- --------------------------------------------------------

--
-- Table structure for table `entree`
--

CREATE TABLE IF NOT EXISTS `entree` (
  `date_entree` varchar(255) NOT NULL,
  `numero_entree` int(255) NOT NULL AUTO_INCREMENT,
  `provenance` varchar(255) NOT NULL,
  `quantite_entree` varchar(255) NOT NULL,
  `reference_entree` varchar(255) NOT NULL,
  PRIMARY KEY (`numero_entree`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `fabrication`
--

CREATE TABLE IF NOT EXISTS `fabrication` (
  `appareil` varchar(255) NOT NULL,
  `attribuerA` varchar(255) NOT NULL,
  `conception` varchar(255) NOT NULL,
  `date_enregistrer` varchar(255) NOT NULL,
  `numero` int(255) NOT NULL,
  `num_employe` varchar(255) NOT NULL,
  `num_fabrication` varchar(255) NOT NULL,
  `quantite_fabrication` int(255) NOT NULL,
  `statut_fabrication` varchar(255) NOT NULL,
  `quantite_entrer` int(255) NOT NULL,
  PRIMARY KEY (`num_fabrication`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fabrication`
--

INSERT INTO `fabrication` (`appareil`, `attribuerA`, `conception`, `date_enregistrer`, `numero`, `num_employe`, `num_fabrication`, `quantite_fabrication`, `statut_fabrication`, `quantite_entrer`) VALUES
('C14-4UF7', '', 'faire une conception', '21/10/2015', 0, '', '15FAB000', 5, 'non attribuée', 0);

-- --------------------------------------------------------

--
-- Table structure for table `formation`
--

CREATE TABLE IF NOT EXISTS `formation` (
  `code` varchar(255) NOT NULL,
  `dure_max` varchar(255) NOT NULL,
  `dure_min` varchar(255) NOT NULL,
  `intitule` varchar(255) NOT NULL,
  `objectif` varchar(255) NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `formation`
--

INSERT INTO `formation` (`code`, `dure_max`, `dure_min`, `intitule`, `objectif`) VALUES
('EL002', '500', '500', 'ELECTRONIQUE', 'Spécialiser'),
('EL101', '300', '500', 'ELECTRONIQUE GENERAL', 'mise à niveau');

-- --------------------------------------------------------

--
-- Table structure for table `fournisseur`
--

CREATE TABLE IF NOT EXISTS `fournisseur` (
  `adresse` varchar(255) NOT NULL,
  `domaine` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `nom_fournisseur` varchar(255) NOT NULL,
  `numero_fournisseur` varchar(255) NOT NULL,
  `telephone` varchar(255) NOT NULL,
  PRIMARY KEY (`numero_fournisseur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fournisseur`
--

INSERT INTO `fournisseur` (`adresse`, `domaine`, `email`, `nom_fournisseur`, `numero_fournisseur`, `telephone`) VALUES
('BP 145 Yaoundé', 'COMMERCE ELECTRONIQUE', 'electrotech@gmail.com', 'Electrotech', '15FO001', '694567280'),
('BP 100 Douala', 'VENTE DES COMPOSANTS ELECTRONIQUE', 'troniq@gmail.com', 'Troniqcom', '15FO002', '242679468');

-- --------------------------------------------------------

--
-- Table structure for table `prestationcloturer`
--

CREATE TABLE IF NOT EXISTS `prestationcloturer` (
  `date_cloturer` varchar(255) NOT NULL,
  `employer_cloturer` varchar(255) NOT NULL,
  `main_cloturer` varchar(255) NOT NULL,
  `montant_cloturer` varchar(255) NOT NULL,
  `num_cloturer` varchar(255) NOT NULL,
  `reduction_cloturer` varchar(255) NOT NULL,
  `temps_cloturer` varchar(255) NOT NULL,
  PRIMARY KEY (`num_cloturer`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `prestationcloturer`
--

INSERT INTO `prestationcloturer` (`date_cloturer`, `employer_cloturer`, `main_cloturer`, `montant_cloturer`, `num_cloturer`, `reduction_cloturer`, `temps_cloturer`) VALUES
('18/12/2015', '', '50,00', '98 F CFA', '15DEP000', '2', '2'),
('', '', '', '0 F CFA', '15DEP004', '0', '0'),
('31/10/2015', '', '250,00', '487,5 F CFA', '15DEP005', '2,5', '2');

-- --------------------------------------------------------

--
-- Table structure for table `prix`
--

CREATE TABLE IF NOT EXISTS `prix` (
  `numero_prix` int(255) DEFAULT NULL,
  `prix_maximal` decimal(55,0) NOT NULL,
  `prix_minimal` decimal(55,0) NOT NULL,
  `prix_recommande` decimal(55,0) NOT NULL,
  `prix_revient` decimal(55,0) NOT NULL,
  `reference_prix` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `prix`
--

INSERT INTO `prix` (`numero_prix`, `prix_maximal`, `prix_minimal`, `prix_recommande`, `prix_revient`, `reference_prix`) VALUES
(NULL, '17', '17', '15', '25', 'RES26-0R8 '),
(NULL, '18', '18', '15', '38', 'RES24-11V'),
(NULL, '24', '24', '20', '95', 'RES34-100R'),
(NULL, '23', '23', '20', '45', 'KIT4'),
(NULL, '33', '33', '29', '37', 'C14-4UF7'),
(NULL, '25', '25', '23', '50', 'C20-220MF');

-- --------------------------------------------------------

--
-- Table structure for table `qteprestation`
--

CREATE TABLE IF NOT EXISTS `qteprestation` (
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  `num_prestation` varchar(255) NOT NULL,
  `qte` int(255) NOT NULL,
  `qte_retirer` int(255) NOT NULL,
  `qte_utilise` int(255) NOT NULL,
  `reference_prestation` varchar(255) NOT NULL,
  PRIMARY KEY (`numero`,`num_prestation`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Dumping data for table `qteprestation`
--

INSERT INTO `qteprestation` (`numero`, `num_prestation`, `qte`, `qte_retirer`, `qte_utilise`, `reference_prestation`) VALUES
(3, '15DEP004', 3, 0, 0, 'C14-4UF7'),
(4, '15DEP004', 6, 0, 0, 'RES34-100R'),
(5, '15DEP004', 9, 0, 0, 'KIT4'),
(6, '15FAB000', 3, 0, 0, 'RES34-100R'),
(7, '15FAB000', 5, 0, 0, 'RES24-11V'),
(8, '15FAB000', 3, 0, 0, 'C20-220MF'),
(9, '15FAB000', 5, 0, 0, 'KIT4'),
(10, '15DEP005', 45, 0, 0, 'RES26-0R8 '),
(11, '15DEP005', 5, 0, 0, 'RES24-11V'),
(12, '15DEP005', 5, 0, 0, 'C20-220MF');

-- --------------------------------------------------------

--
-- Table structure for table `sortie`
--

CREATE TABLE IF NOT EXISTS `sortie` (
  `date_sortie` varchar(255) NOT NULL,
  `motif` varchar(255) NOT NULL,
  `quantite_sortie` int(255) NOT NULL,
  `reference_sortie` varchar(255) NOT NULL,
  `responsable` varchar(255) NOT NULL,
  `numero` varchar(255) NOT NULL,
  `numero_sortie` int(255) NOT NULL AUTO_INCREMENT,
  `nom_destinataire` varchar(255) NOT NULL,
  `statut_sortie` varchar(255) NOT NULL,
  PRIMARY KEY (`numero_sortie`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=117 ;

--
-- Dumping data for table `sortie`
--

INSERT INTO `sortie` (`date_sortie`, `motif`, `quantite_sortie`, `reference_sortie`, `responsable`, `numero`, `numero_sortie`, `nom_destinataire`, `statut_sortie`) VALUES
('23/03/2016 02:51:01', 'Vente facture numéro 16FAC056', 1, 'RES24-11V', '15EM001', '16FAC056', 80, ' ', 'Validée'),
('23/03/2016 02:51:01', 'Vente facture numéro 16FAC056', 2, 'RES34-100R', '15EM001', '16FAC056', 81, ' ', 'Validée'),
('23/03/2016 02:51:01', 'Vente facture numéro 16FAC056', 4, 'C20-220MF', '15EM001', '16FAC056', 82, ' ', 'Validée'),
('23/03/2016 03:13:55', 'Vente facture numéro 16FAC057', 2000, 'C20-220MF', '15EM001', '16FAC057', 83, ' ', 'Validée'),
('23/03/2016 03:13:55', 'Vente facture numéro 16FAC057', 2, 'RES24-11V', '15EM001', '16FAC057', 84, ' ', 'Validée'),
('23/03/2016 03:13:55', 'Vente facture numéro 16FAC057', 45, 'RES34-100R', '15EM001', '16FAC057', 85, ' ', 'Validée'),
('23/03/2016 03:19:54', 'Vente facture numéro 16FAC058', 12, 'RES24-11V', '15EM001', '16FAC058', 86, ' ', 'Validée'),
('23/03/2016 03:19:54', 'Vente facture numéro 16FAC058', 10, 'RES34-100R', '15EM001', '16FAC058', 87, ' ', 'Validée'),
('23/03/2016 03:19:54', 'Vente facture numéro 16FAC058', 40, 'C20-220MF', '15EM001', '16FAC058', 88, ' ', 'Validée'),
('23/03/2016 03:21:59', 'Vente facture numéro 16FAC059', 34, 'RES24-11V', '15EM001', '16FAC059', 89, ' ', 'Validée'),
('23/03/2016 03:21:59', 'Vente facture numéro 16FAC059', 44, 'RES34-100R', '15EM001', '16FAC059', 90, ' ', 'Validée'),
('23/03/2016 03:21:59', 'Vente facture numéro 16FAC059', 100, 'C20-220MF', '15EM001', '16FAC059', 91, ' ', 'Validée'),
('23/03/2016 03:25:01', 'Vente facture numéro 16FAC060', 45, 'RES24-11V', '15EM001', '16FAC060', 92, ' ', 'Validée'),
('23/03/2016 03:25:01', 'Vente facture numéro 16FAC060', 44, 'RES34-100R', '15EM001', '16FAC060', 93, ' ', 'Validée'),
('23/03/2016 03:25:01', 'Vente facture numéro 16FAC060', 2000, 'C20-220MF', '15EM001', '16FAC060', 94, ' ', 'Validée'),
('23/03/2016 03:27:34', 'Vente facture numéro 16FAC061', 4, 'RES24-11V', '15EM001', '16FAC061', 95, ' ', 'Non validée'),
('23/03/2016 03:27:34', 'Vente facture numéro 16FAC061', 4, 'RES34-100R', '15EM001', '16FAC061', 96, ' ', 'Non validée'),
('23/03/2016 03:27:34', 'Vente facture numéro 16FAC061', 96, 'C20-220MF', '15EM001', '16FAC061', 97, ' ', 'Non validée'),
('23/03/2016 04:36:45', 'Vente facture numéro 16FAC062', 10, 'RES24-11V', '15EM001', '16FAC062', 98, ' ', 'Validée'),
('23/03/2016 04:36:45', 'Vente facture numéro 16FAC062', 12, 'RES34-100R', '15EM001', '16FAC062', 99, ' ', 'Validée'),
('23/03/2016 04:36:45', 'Vente facture numéro 16FAC062', 43, 'C20-220MF', '15EM001', '16FAC062', 100, ' ', 'Validée'),
('23/03/2016 04:42:41', 'Vente facture numéro 16FAC063', 6, 'RES24-11V', '15EM001', '16FAC063', 101, ' ', 'Validée'),
('23/03/2016 04:42:41', 'Vente facture numéro 16FAC063', 2, 'RES34-100R', '15EM001', '16FAC063', 102, ' ', 'Validée'),
('23/03/2016 04:58:58', 'Vente facture numéro 16FAC064', 4, 'RES24-11V', '15EM001', '16FAC064', 103, ' ', 'Validée'),
('23/03/2016 04:58:58', 'Vente facture numéro 16FAC064', 4, 'RES34-100R', '15EM001', '16FAC064', 104, ' ', 'Validée'),
('23/03/2016 04:58:58', 'Vente facture numéro 16FAC064', 7, 'C20-220MF', '15EM001', '16FAC064', 105, ' ', 'Validée'),
('23/03/2016 05:15:37', 'Vente facture numéro 16FAC065', 6, 'RES24-11V', '15EM001', '16FAC065', 106, ' ', 'Validée'),
('23/03/2016 05:15:37', 'Vente facture numéro 16FAC065', 5, 'RES34-100R', '15EM001', '16FAC065', 107, ' ', 'Validée'),
('23/03/2016 13:45:10', 'Vente facture numéro 16FAC066', 4, 'RES24-11V', '15EM001', '16FAC066', 108, ' ', 'Validée'),
('23/03/2016 13:45:10', 'Vente facture numéro 16FAC066', 3, 'RES34-100R', '15EM001', '16FAC066', 109, ' ', 'Validée'),
('23/03/2016 13:45:10', 'Vente facture numéro 16FAC066', 5, 'C20-220MF', '15EM001', '16FAC066', 110, ' ', 'Validée'),
('23/03/2016 16:17:18', 'Vente facture numéro 16FAC067', 3, 'RES24-11V', '15EM001', '16FAC067', 111, 'met NDE', 'Validée'),
('23/03/2016 16:17:18', 'Vente facture numéro 16FAC067', 3, 'RES34-100R', '15EM001', '16FAC067', 112, 'met NDE', 'Validée'),
('23/03/2016 16:17:18', 'Vente facture numéro 16FAC067', 1, 'C20-220MF', '15EM001', '16FAC067', 113, 'met NDE', 'Validée'),
('23/03/2016 16:35:36', 'Vente facture numéro 16FAC068', 1, 'RES26-0R8 ', '15EM001', '16FAC068', 114, 'OMBANG-LILE Christian', 'Non validée'),
('23/03/2016 16:35:36', 'Vente facture numéro 16FAC068', 3, 'RES24-11V', '15EM001', '16FAC068', 115, 'OMBANG-LILE Christian', 'Non validée'),
('23/03/2016 16:35:36', 'Vente facture numéro 16FAC068', 5, 'RES34-100R', '15EM001', '16FAC068', 116, 'OMBANG-LILE Christian', 'Non validée');

-- --------------------------------------------------------

--
-- Table structure for table `type`
--

CREATE TABLE IF NOT EXISTS `type` (
  `designation` varchar(255) NOT NULL,
  `reference` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `type`
--

INSERT INTO `type` (`designation`, `reference`) VALUES
('Résistance', 'Résistance'),
('Condensateur', 'Condensateur'),
('Selfs', 'Selfs');

-- --------------------------------------------------------

--
-- Table structure for table `type_client`
--

CREATE TABLE IF NOT EXISTS `type_client` (
  `etoile` varchar(255) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `reduction` varchar(255) NOT NULL,
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `type_client`
--

INSERT INTO `type_client` (`etoile`, `nom`, `reduction`, `numero`) VALUES
('', 'Occasionnel', '1', 1),
('', 'Elève', '2,5', 2),
('', 'Professionnel', '4', 3),
('', 'Etudiant', '3', 4);

-- --------------------------------------------------------

--
-- Table structure for table `vente`
--

CREATE TABLE IF NOT EXISTS `vente` (
  `date_vente` varchar(255) NOT NULL,
  `nomclient_vente` varchar(255) NOT NULL,
  `numclient_vente` varchar(255) NOT NULL,
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  `numero_vente` varchar(255) NOT NULL,
  `num_employe` varchar(255) NOT NULL,
  `prixT` decimal(55,0) NOT NULL,
  `prixU` decimal(55,0) NOT NULL,
  `qte_vente` int(255) NOT NULL,
  `reference_vente` varchar(255) NOT NULL,
  `statut_vente` varchar(255) NOT NULL,
  PRIMARY KEY (`numero`,`numero_vente`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=135 ;

--
-- Dumping data for table `vente`
--

INSERT INTO `vente` (`date_vente`, `nomclient_vente`, `numclient_vente`, `numero`, `numero_vente`, `num_employe`, `prixT`, `prixU`, `qte_vente`, `reference_vente`, `statut_vente`) VALUES
('23/03/2016 02:51:01', '', '', 98, '16FAC056', '', '100', '100', 1, 'RES24-11V', 'Validée'),
('23/03/2016 02:51:01', '', '', 99, '16FAC056', '', '90', '45', 2, 'RES34-100R', 'Validée'),
('23/03/2016 02:51:01', '', '', 100, '16FAC056', '', '2800', '700', 4, 'C20-220MF', 'Validée'),
('23/03/2016 03:13:55', '', '', 101, '16FAC057', '', '200000', '100', 2000, 'C20-220MF', 'Validée'),
('23/03/2016 03:13:55', '', '', 102, '16FAC057', '', '900', '450', 2, 'RES24-11V', 'Validée'),
('23/03/2016 03:13:55', '', '', 103, '16FAC057', '', '2250', '50', 45, 'RES34-100R', 'Validée'),
('23/03/2016 03:19:54', '', '', 104, '16FAC058', '', '5400', '450', 12, 'RES24-11V', 'Validée'),
('23/03/2016 03:19:54', '', '', 105, '16FAC058', '', '400', '40', 10, 'RES34-100R', 'Validée'),
('23/03/2016 03:19:54', '', '', 106, '16FAC058', '', '6000', '150', 40, 'C20-220MF', 'Validée'),
('23/03/2016 03:21:59', '', '', 107, '16FAC059', '', '15300', '450', 34, 'RES24-11V', 'Validée'),
('23/03/2016 03:21:59', '', '', 108, '16FAC059', '', '6600', '150', 44, 'RES34-100R', 'Validée'),
('23/03/2016 03:21:59', '', '', 109, '16FAC059', '', '15000', '150', 100, 'C20-220MF', 'Validée'),
('23/03/2016 03:25:01', '', '', 110, '16FAC060', '', '4500', '100', 45, 'RES24-11V', 'Validée'),
('23/03/2016 03:25:01', '', '', 111, '16FAC060', '', '4400', '100', 44, 'RES34-100R', 'Validée'),
('23/03/2016 03:25:01', '', '', 112, '16FAC060', '', '200000', '100', 2000, 'C20-220MF', 'Validée'),
('23/03/2016 03:27:34', '', '', 113, '16FAC061', '', '16000', '4000', 4, 'RES24-11V', 'Non validée'),
('23/03/2016 03:27:34', '', '', 114, '16FAC061', '', '2000', '500', 4, 'RES34-100R', 'Non validée'),
('23/03/2016 03:27:34', '', '', 115, '16FAC061', '', '960', '10', 96, 'C20-220MF', 'Non validée'),
('23/03/2016 00:00:00', '', '', 116, '16FAC062', '', '1000', '100', 10, 'RES24-11V', 'Validée'),
('23/03/2016 00:00:00', '', '', 117, '16FAC062', '', '4800', '400', 12, 'RES34-100R', 'Validée'),
('23/03/2016 00:00:00', '', '', 118, '16FAC062', '', '19350', '450', 43, 'C20-220MF', 'Validée'),
('23/03/2016', '', '', 119, '16FAC063', '', '300', '50', 6, 'RES24-11V', 'Validée'),
('23/03/2016', '', '', 120, '16FAC063', '', '800', '400', 2, 'RES34-100R', 'Validée'),
('23/03/2016', '', '', 121, '16FAC064', '', '1600', '400', 4, 'RES24-11V', 'Validée'),
('23/03/2016', '', '', 122, '16FAC064', '', '2000', '500', 4, 'RES34-100R', 'Validée'),
('23/03/2016', '', '', 123, '16FAC064', '', '3500', '500', 7, 'C20-220MF', 'Validée'),
('23/03/2016', '', '', 124, '16FAC065', '', '3000', '500', 6, 'RES24-11V', 'Validée'),
('23/03/2016', '', '', 125, '16FAC065', '', '375', '75', 5, 'RES34-100R', 'Validée'),
('23/03/2016', '', '', 126, '16FAC066', '', '140', '35', 4, 'RES24-11V', 'Validée'),
('23/03/2016', '', '', 127, '16FAC066', '', '1200', '400', 3, 'RES34-100R', 'Validée'),
('23/03/2016', '', '', 128, '16FAC066', '', '2000', '400', 5, 'C20-220MF', 'Validée'),
('23/03/2016', '', '', 129, '16FAC067', '', '600', '200', 3, 'RES24-11V', 'Validée'),
('23/03/2016', '', '', 130, '16FAC067', '', '600', '200', 3, 'RES34-100R', 'Validée'),
('23/03/2016', '', '', 131, '16FAC067', '', '200', '200', 1, 'C20-220MF', 'Validée'),
('23/03/2016', '', '15CL002', 132, '16FAC068', '', '255', '255', 1, 'RES26-0R8 ', 'Non validée'),
('23/03/2016', '', '15CL002', 133, '16FAC068', '', '2100', '700', 3, 'RES24-11V', 'Non validée'),
('23/03/2016', '', '15CL002', 134, '16FAC068', '', '500', '100', 5, 'RES34-100R', 'Non validée');

-- --------------------------------------------------------

--
-- Table structure for table `ventes`
--

CREATE TABLE IF NOT EXISTS `ventes` (
  `date_fac` varchar(255) NOT NULL,
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  `numero_fac` varchar(255) NOT NULL,
  `facture` varchar(255) NOT NULL,
  `chemin` varchar(255) NOT NULL,
  `statut_fac` varchar(255) NOT NULL,
  `montant` float NOT NULL,
  `reduction` double NOT NULL,
  PRIMARY KEY (`numero`,`numero_fac`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=69 ;

--
-- Dumping data for table `ventes`
--

INSERT INTO `ventes` (`date_fac`, `numero`, `numero_fac`, `facture`, `chemin`, `statut_fac`, `montant`, `reduction`) VALUES
('22/03/2016 20:58:04', 55, '16FAC055', '16FAC055.pdf', '16FAC055.pdf', 'Validée', 0, 0),
('23/03/2016 02:51:01', 56, '16FAC056', '16FAC056.pdf', '16FAC056.pdf', 'Validée', 0, 0),
('23/03/2016 03:13:55', 57, '16FAC057', '16FAC057.pdf', '16FAC057.pdf', 'Validée', 0, 0),
('23/03/2016 03:19:54', 58, '16FAC058', '16FAC058.pdf', '16FAC058.pdf', 'Validée', 11800, 0),
('23/03/2016 03:21:59', 59, '16FAC059', '16FAC059.pdf', '16FAC059.pdf', 'Validée', 36900, 0),
('23/03/2016 03:25:01', 60, '16FAC060', '16FAC060.pdf', '16FAC060.pdf', 'Validée', 208900, 0),
('23/03/2016 03:27:34', 61, '16FAC061', '16FAC061.pdf', '16FAC061.pdf', 'Non validée', 0, 0),
('23/03/2016 00:00:00', 62, '16FAC062', '16FAC062.pdf', '16FAC062.pdf', 'Validée', 25150, 0),
('23/03/2016', 63, '16FAC063', '16FAC063.pdf', '16FAC063.pdf', 'Validée', 1100, 0),
('23/03/2016', 64, '16FAC064', '16FAC064.pdf', '16FAC064.pdf', 'Validée', 7100, 0),
('23/03/2016', 65, '16FAC065', '16FAC065.pdf', '16FAC065.pdf', 'Validée', 3273, 3),
('23/03/2016', 66, '16FAC066', '16FAC066.pdf', '16FAC066.pdf', 'Validée', 3239, 3),
('23/03/2016', 67, '16FAC067', '16FAC067.pdf', '16FAC067.pdf', 'Validée', 1358, 3),
('23/03/2016', 68, '16FAC068', '16FAC068.pdf', '16FAC068.pdf', 'Non validée', 0, 3);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
