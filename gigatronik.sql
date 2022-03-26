-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Client: localhost
-- Généré le: Sam 24 Octobre 2015 à 05:44
-- Version du serveur: 5.6.12-log
-- Version de PHP: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `gigatronik`
--
CREATE DATABASE IF NOT EXISTS `gigatronik` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `gigatronik`;

-- --------------------------------------------------------

--
-- Structure de la table `article`
--

CREATE TABLE IF NOT EXISTS `article` (
  `reference` varchar(10) NOT NULL,
  `designation` varchar(10) DEFAULT NULL,
  `type` varchar(10) DEFAULT NULL,
  `quantite` int(10) DEFAULT NULL,
  `description` longtext NOT NULL,
  PRIMARY KEY (`reference`),
  KEY `type` (`type`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `article`
--

INSERT INTO `article` (`reference`, `designation`, `type`, `quantite`, `description`) VALUES
('C1-1PF', 'Condensate', 'Condensate', 80, 'Condensateurs céramiques monocouches\nTension de service 50Vcc max, -25°C à +85°C.\nTolérance 20%, valeur en PicoFarad, pas de 5,08mm\nLecture en pF (PicoFarad) marqué avec 3 chiffres\nLe 3ème chiffre indique le nombre de 0.\nEx : 473 = 47+000 = 47000pF = 47nF\nEx : 100 = 10+_=10pF'),
('C19-1UF', 'Condensate', 'Condensate', 500, 'Condensateurs chimiques axiaux polarisés.\nTension de service 25Vcc/35Vcc/63Vcc.\nSorties axiales. -55°C à +85°C.\nAutres valeurs disponibles par lot de 10 pièces.'),
('C3-15PF', 'Condensate', 'Condensate', 160, 'Condensateurs céramiques hautes tensions.\nTension de service 3000Vcc max, -10°C à +85°C.\nTolérance 10%, pas de 10,1 mm.\nLecture en pF (PicoFarad) marqué avec 3 chiffres\nLe 3ème chiffre indique le nombre de 0.\nEx : 473 = 47+000 = 47000pF = 47nF\nEx : 101 = 10+0=100pF'),
('C4-1PF', 'Condensate', 'Condensate', 150, 'Condensateurs céramiques non polarisés CMS\nTension de service 50Vcc max, -25°C à +85°C.\nBoitier 1206 (Longueur = 3,2mm, largeur = 1,6mm)\nVendu par lot de 10 pièces.\nDisponible aussi en boitier 0603 et 0805 par lot de 100 pièces'),
('C6-10NF', 'Condensate', 'Condensate', 150, 'Condensateurs polyesters métallisés MKS4\nTension de service 250Vcc. Tolérance 10% à 20%.\nPour application en courant continu. -55°C à +100°C.\nPour by-pass, blocking, couplage, découplage, timing.\nSpécifi cations selon norme IEC60384-2 et EN130400.'),
('Condensate', 'C2-100PF', 'Condensate', 350, 'Condensateurs céramiques multicouches\nTension de service 50Vcc max, -10°C à +85°C.\nCondensateur à faible dissipation 5%max à 1KHz\nEncombrement réduit, application pour fi ltres\nTolérance 10%, pas de 5,08mm, type XR7.\nLecture en pF (PicoFarad) marqué avec 3 chiffres\nLe 3ème chiffre indique le nombre de 0.\nEx : 473 = 47+000 = 47000pF = 47nF\nEx : 101 = 10+0=100pF\nAutres valeurs disponible par sachet de 10 pièces.'),
('MAT7X5R', 'Matrice LE', 'a', 150, ''),
('RES10-0R', 'Lot de 10 ', 'Résistance', 75, 'Résistances 0 O et Straps.\n(Vendu par lot de 10)\nRésistance dimensions 2,5mm x 6,5mm.\nTension de service 250V max, -55°C à +155°C.'),
('RES10-STRA', 'Lot de 10 ', 'Résistance', 55, 'Résistances 0 O et Straps.\n(Vendu par lot de 10)\nRésistance dimensions 2,5mm x 6,5mm.\nTension de service 250V max, -55°C à +155°C.'),
('RES11-xxxx', 'Lot de 2 r', 'Résistance', 70, 'Résistances couche carbone 1/2W.\n(Vendues par lot de 2 pièces).\nTolérance 5% (3,8mm x 10,3mm) Série E12.\nTension de service 250V max, -55°C à +155°C'),
('RES12-1R', 'Résistance', 'Résistance', 50, 'Résistances couche carbone 1W.\n(Vendues par lot de 2 pièces).\nTolérance 5% (5,0mm x 10,5mm) Série E12.\nTension de service 250V max, -55°C à +155°C.\nDisponible également en 2W par lot de 100 pièces, (même tarifs)\n'),
('RES14-4R7', 'Résistance', 'Résistance', 200, 'Résistances couche métal 1/4W 1%.\nTolérance 1% (2,3mm x 5,7mm)\nTension de service 250V max, -65°C à +155°C.\nDisponible aussi en série E24 et E96 en sachet de 100 pièces.'),
('RES16-0R10', 'Résistance', 'Résistance', 150, 'Résistances bobinées vitrifi ées 3W (4W max).\nTolérance 10% (<1 O) et 5% (>=1 O).\nTension de service 125V max. Série E12.\nDimensions : 5,5mm x 12mm'),
('RES18-0R10', 'Résistance', 'Résistance', 250, 'Résistances bobinées cémentées 10W.\nBoitier céramique, tolérance 5%\nTension de service 250V max. Série E12.\nDimensions : 48mm x 9,5mm x 9mm'),
('RES19-0R10', 'Résistance', 'Résistance', 70, 'Résistances bobinées radiateurs 10W.\nBoitier aluminium, tolérance 1%\nTension de service 265V max.\nDimensions : 20mm x 11mm x 11mm.'),
('RES20-0R10', 'Résistance', 'Résistance', 60, 'Résistances bobinées radiateurs 25W.\nBoitier aluminium, tolérance 1%\nTension de service 550V max.\nDimensions : 27mm x 15mm x 15mm.'),
('RES21-0R10', 'Résistance', 'Résistance', 100, 'Résistances bobinées radiateurs 50W.\nBoitier aluminium, tolérance 1%\nTension de service 1250V max.\nDimensions : 50mm x 16mm x 16mm.'),
('RIT2', 'Lot de 480', 'Résistance', 20, 'Lot de 480 résistances couche carbone 1/4W\nTolérance 5%, Tension de service 250V max.\nTempérature de fonctionnement : -55°C à +155°C.\nSérie E3. 30 pièces par valeur.\n'),
('RIT3', 'Lot de 610', 'Résistance', 50, 'Lot de 610 résistances couche carbone 1/4W\nTolérance 5%, Tension de service 250V max.\nTempérature d’utilisation : -55°C à +155°C.\nSérie E12. 10 pièces par valeur.\n'),
('SEL1-0UH1', 'Selfs axia', 'Selfs', 70, 'Selfs axiales\nSérie E6, tolérance 10%, sorties axiales.\nAutres valeurs disponibles par lot de 10 pièces.'),
('SEL24', 'Quartz pou', 'Emissions-', 250, 'Quartz pour horloges ou divers, boitier HC26\nStabilité en fréquence +/-20ppm. Commande 1µW max.\nCapacité de chargement 6pF à l’infi ni.\nMini boitier HC26, entraxe 1,0mm, valeurs en KHz.'),
('SEL3', 'Selfs de c', 'Selfs', 60, 'Selfs de choc VK200\nSelf d’arret et de découpage, sortie axiale.\nImpédance 680 ohms à 50MHz. Fil 0,5mm.\n2,5 spires, 10µH, dimensions 6x14mm.'),
('SEL4', 'Selfs d’an', 'Selfs', 70, 'Selfs d’antiparasitage pour alimentation\nSelf pour fi ltres secteurs, alimentation à découpage.\nFils émaillé sur tore ferrite, sortie radiale.\nTolérance 20%. Courant 1A / 2,5A / 5A / 10A.');

-- --------------------------------------------------------

--
-- Structure de la table `articlecloturer`
--

CREATE TABLE IF NOT EXISTS `articlecloturer` (
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  `num_prestation` varchar(255) NOT NULL,
  `reference_cloturer` varchar(255) NOT NULL,
  `qte_cloturer` varchar(255) NOT NULL,
  `prixu_cloturer` varchar(255) NOT NULL,
  `produit_cloturer` varchar(255) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=25 ;

--
-- Contenu de la table `articlecloturer`
--

INSERT INTO `articlecloturer` (`numero`, `num_prestation`, `reference_cloturer`, `qte_cloturer`, `prixu_cloturer`, `produit_cloturer`) VALUES
(1, '15DEP004', 'aaaa', '4', '45', '180'),
(2, '15DEP004', 'aaaa', '4', '60', '240'),
(3, '15DEP004', 'kik', '5', '100', '500'),
(4, '15DEP004', 'aaaa', '4', '25', '100'),
(5, '15DEP004', 'aaaa', '4', '50', '200'),
(6, '15DEP004', 'kik', '5', '200', '1000'),
(7, '15DEP004', 'aaaa', '4', '25', '100'),
(8, '15DEP004', 'aaaa', '4', '50', '200'),
(9, '15DEP004', 'kik', '5', '200', '1000'),
(10, '15DEP004', 'aaaa', '4', '300', '1200'),
(11, '15DEP004', 'aaaa', '4', '500', '2000'),
(12, '15DEP004', 'kik', '5', '400', '2000'),
(13, '15DEP004', 'aaaa', '4', '500', '2000'),
(14, '15DEP004', 'aaaa', '4', '500', '2000'),
(15, '15DEP004', 'kik', '5', '500', '2500'),
(16, '15DEP004', 'aaaa', '4', '500', '2000'),
(17, '15DEP004', 'aaaa', '4', '500', '2000'),
(18, '15DEP004', 'kik', '5', '500', '2500'),
(19, '15DEP004', 'aaaa', '4', '200', '800'),
(20, '15DEP004', 'aaaa', '4', '200', '800'),
(21, '15DEP004', 'kik', '5', '200', '1000'),
(22, '15DEP004', 'aaaa', '4', '45', '180'),
(23, '15DEP004', 'aaaa', '4', '50', '200'),
(24, '15DEP004', 'kik', '5', '75', '375');

-- --------------------------------------------------------

--
-- Structure de la table `article_choisi`
--

CREATE TABLE IF NOT EXISTS `article_choisi` (
  `compteur` int(255) NOT NULL AUTO_INCREMENT,
  `numero` varchar(255) NOT NULL,
  `reference_demande` varchar(255) NOT NULL,
  `quantite_demande` int(100) NOT NULL,
  `quantite_commande` varchar(255) NOT NULL,
  PRIMARY KEY (`compteur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=37 ;

--
-- Contenu de la table `article_choisi`
--

INSERT INTO `article_choisi` (`compteur`, `numero`, `reference_demande`, `quantite_demande`, `quantite_commande`) VALUES
(1, '15DEV001', 'aaaa', 7, ''),
(2, '15DEV001', 'kik', 4, ''),
(3, '15DEV001', 'aaaa', 2, ''),
(4, '15DEV001', 'kik', 4, ''),
(5, '15DEV002', 'aaaa', 6, ''),
(6, '15DEV002', 'kik', 6, ''),
(7, '15DEV002', 'aaaa', 6, ''),
(8, '15COM001', 'aaaa', 3, ''),
(9, '15COM001', 'kik', 5, ''),
(10, '15DEV002', 'aaaa', 5, ''),
(11, '15DEV002', 'kik', 4, ''),
(12, '15DEV002', 'aaaa', 3, ''),
(13, '15DEV004', 'aaaa', 4, ''),
(14, '15DEV004', 'kik', 8, ''),
(15, '15DEV003', 'aaaa', 6, ''),
(16, '15DEV003', 'azzzzzze', 7, ''),
(17, '15DEV003', 'MAT7X5R', 4, ''),
(18, '15DEV004', 'RIT3', 5, ''),
(19, '15DEV004', 'RES19-0R10', 5, ''),
(20, '15DEV004', 'SEL4', 6, ''),
(21, '15DEV004', 'C1-1PF', 45, ''),
(22, '15DEV004', 'MAT7X5R', 67, ''),
(23, '15DEPV004', 'RIT3', 5, ''),
(24, '15DEPV004', 'RES10-STRA', 7, ''),
(25, '15DEPV004', 'RES20-0R10', 7, ''),
(26, '15DEPV004', 'SEL3', -6, ''),
(27, '15DEV005', 'RIT3', 4, ''),
(28, '15DEV005', 'SEL3', 5, ''),
(29, '15DEV005', 'RES11-xxxx', 45, ''),
(30, '15DEV005', 'RES19-0R10', 56, ''),
(31, '15DEV005', 'SEL4', -4, ''),
(32, '15DEV011', 'SEL3', 5, ''),
(33, '15DEV011', 'RES11-xxxx', 7, ''),
(34, '15DEV011', 'SEL1-0UH1', 8, ''),
(35, '15DEV011', 'SEL4', 34, ''),
(36, '15DEV011', 'RES10-0R', 90, '');

-- --------------------------------------------------------

--
-- Structure de la table `article_commande`
--

CREATE TABLE IF NOT EXISTS `article_commande` (
  `compteur` int(255) NOT NULL AUTO_INCREMENT,
  `numero_commande` varchar(255) NOT NULL,
  `reference_commande` varchar(255) NOT NULL,
  `quantite_demande` varchar(255) NOT NULL,
  `quantite_commande` varchar(255) NOT NULL,
  PRIMARY KEY (`compteur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Contenu de la table `article_commande`
--

INSERT INTO `article_commande` (`compteur`, `numero_commande`, `reference_commande`, `quantite_demande`, `quantite_commande`) VALUES
(1, '15COM001', 'aaaa', '6', '6'),
(2, '15COM001', 'kik', '2', '4'),
(3, '', 'aaaa', '0', '5'),
(4, '', 'kik', '0', '9'),
(5, '', 'djudshfd', '0', '3'),
(6, '', 'kik', '0', '45'),
(7, '15COM003', 'aaaa', '0', '3'),
(8, '15COM003', 'kik', '0', '56'),
(9, '15COM008', 'aaaa', '0', '23'),
(10, '15COM008', 'kik', '0', '45'),
(11, '15COM008', 'jhsjshfskj', '0', '12'),
(12, '15COM009', 'djudshfd', '0', '10'),
(13, '15COM009', 'kik', '0', '17'),
(14, '15COM011', 'djudshfd', '0', '6'),
(15, '15COM011', 'kik', '0', '90'),
(16, '15COM011', 'jhsjshfskj', '0', '80');

-- --------------------------------------------------------

--
-- Structure de la table `attribuer_cours`
--

CREATE TABLE IF NOT EXISTS `attribuer_cours` (
  `num_attribution` int(100) NOT NULL AUTO_INCREMENT,
  `numero_enseignant` varchar(255) NOT NULL,
  `code_formation` varchar(255) NOT NULL,
  `date_attribution` varchar(255) NOT NULL,
  PRIMARY KEY (`num_attribution`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Contenu de la table `attribuer_cours`
--

INSERT INTO `attribuer_cours` (`num_attribution`, `numero_enseignant`, `code_formation`, `date_attribution`) VALUES
(7, '15EN000', 'F003', '11/09/2015'),
(8, '15EN001', 'F001', '19/09/2015'),
(10, '15EN000', 'F001', '19/09/2015 10:36:12'),
(11, '15EN001', 'F003', '19/09/2015 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `numero_client` varchar(255) NOT NULL,
  `nom_clients` varchar(255) NOT NULL,
  `prenom_client` varchar(255) NOT NULL,
  `type_client` varchar(255) NOT NULL,
  `adresse_client` varchar(255) NOT NULL,
  `tel_client` varchar(255) NOT NULL,
  `email_client` varchar(255) NOT NULL,
  PRIMARY KEY (`numero_client`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `client`
--

INSERT INTO `client` (`numero_client`, `nom_clients`, `prenom_client`, `type_client`, `adresse_client`, `tel_client`, `email_client`) VALUES
('15CL000', 'NDE', 'RODRIGUE', 'Professionnel', 'NVOG ADA', '698292866', 'rodriguekongne@yahoo.fr'),
('15CL001', 'kongne', 'dfjojsdfjj', 'Occasionnel', 'fdofodfjo', '222222222', 'KFQDFJ@JJJJ.com'),
('15CL002', 'TCHOUOLA', 'Francklin', 'Elève', 'Dang', '671681139', 'qsdfgh@gmail.com'),
('15CL003', 'BAGONA', 'Leopold', 'Etudiant', 'DANG', '690234355', 'ertyuio@gmail.com'),
('15CL004', 'OMBANG-LILE', 'Christian', 'Etudiant', 'DANG', '678910930', 'egfhf@gmail.com'),
('15CL005', 'SONGUE TOKO', 'Arsene', 'Etudiant', 'DANG', '698347809', 'arsene@gmail.com'),
('15CL006', 'TENYEH', 'Romaric', 'Etudiant', 'DANG', '678993674', 'romaric@gmail.com'),
('15CL007', 'METHIE NDE', 'Garance', 'Elève', 'Essos', '678456638', 'etyeu@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

CREATE TABLE IF NOT EXISTS `commande` (
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  `numero_commande` varchar(255) NOT NULL,
  `date_commande` varchar(255) NOT NULL,
  `numero_devis` varchar(255) NOT NULL,
  `fournisseur` varchar(255) NOT NULL,
  `statut` varchar(255) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Contenu de la table `commande`
--

INSERT INTO `commande` (`numero`, `numero_commande`, `date_commande`, `numero_devis`, `fournisseur`, `statut`) VALUES
(1, '15COM001', '30/09/2015', '', '2', 'En cours'),
(7, '15COM003', 'mercredi 30 septembre 2015', '', '', 'En cours'),
(8, '15COM008', 'jeudi 1 octobre 2015', '', '1', 'En cours'),
(9, '15COM009', 'jeudi 1 octobre 2015', '', '', 'En cours'),
(10, '15COM010', 'jeudi 1 octobre 2015', '', '2', 'En cours'),
(11, '15COM011', 'jeudi 1 octobre 2015', '', '2', 'En cours');

-- --------------------------------------------------------

--
-- Structure de la table `demande_devis`
--

CREATE TABLE IF NOT EXISTS `demande_devis` (
  `num_devis` varchar(255) NOT NULL,
  `date` varchar(255) NOT NULL,
  PRIMARY KEY (`num_devis`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `demande_devis`
--

INSERT INTO `demande_devis` (`num_devis`, `date`) VALUES
('15DEPV004', '29/09/2015'),
('15DEV001', '23/09/2015'),
('15DEV002', '24/09/2015'),
('15DEV003', '07/10/2015'),
('15DEV004', '30/09/2015'),
('15DEV005', '30/09/2015'),
('15DEV011', '30/09/2015');

-- --------------------------------------------------------

--
-- Structure de la table `depannage`
--

CREATE TABLE IF NOT EXISTS `depannage` (
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  `num_depannage` varchar(255) NOT NULL,
  `num_client` varchar(255) DEFAULT NULL,
  `nom_client` varchar(255) NOT NULL,
  `num_employe` varchar(255) NOT NULL,
  `diagnostic` longtext NOT NULL,
  `date_enregistrer` varchar(255) NOT NULL,
  `statut_depannage` varchar(255) NOT NULL,
  `appareil_depannage` varchar(255) NOT NULL,
  `types_client` varchar(255) NOT NULL,
  PRIMARY KEY (`numero`),
  UNIQUE KEY `num_depannage` (`num_depannage`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Contenu de la table `depannage`
--

INSERT INTO `depannage` (`numero`, `num_depannage`, `num_client`, `nom_client`, `num_employe`, `diagnostic`, `date_enregistrer`, `statut_depannage`, `appareil_depannage`, `types_client`) VALUES
(4, '15DEP001', '15CL000', 'GH', '15EM001', 'FRFRYFFFC', '12/09/2015', 'En cours', 'chargeur pour pile rechargeable', ''),
(6, '15DEP002', '', '', '', 'KELKE CHOSE', '02/10/2015', 'Livré', '', ''),
(8, '15DEP000', 'NDE', 'NDE', 'Ndé Rodrigue', 'redsdrdghhhjhjuh', '20/10/2015', '', 'Télévision', ''),
(9, '15DEP003', 'kongne', 'kongne', '15EM001', 'zehhsqkiqujsjhhquqk', '21/10/2015', 'En cours', 'Télévision', 'Occasionnel'),
(10, '15DEP004', '15CL000', 'NDE', '15EM001', 'Tube en dommagé', '22/10/2015', 'En cours', 'Télévision', 'Professionnel'),
(11, '15DEP005', '15CL002', 'TCHOUOLA', '15EM001', '', '22/10/2015', 'En cours', 'Ordinateur', 'Elève'),
(12, '15DEP006', '15CL000', 'NDE', '15EM001', '', '21/10/2015', 'En cours', 'Télévision', 'Professionnel'),
(13, '15DEP007', '15CL000', 'NDE', '15EM001', '', '24/10/2015', 'En cours', 'Ordinateur', 'Professionnel');

-- --------------------------------------------------------

--
-- Structure de la table `employe`
--

CREATE TABLE IF NOT EXISTS `employe` (
  `compteur` int(255) NOT NULL AUTO_INCREMENT,
  `nom_employe` varchar(255) NOT NULL,
  `prenom_employe` varchar(255) NOT NULL,
  `telephone_employe` varchar(255) NOT NULL,
  `adresse_employe` varchar(255) NOT NULL,
  `email_employe` varchar(255) NOT NULL,
  `numero_employe` varchar(255) NOT NULL,
  `mdp` varchar(255) NOT NULL,
  PRIMARY KEY (`compteur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `employe`
--

INSERT INTO `employe` (`compteur`, `nom_employe`, `prenom_employe`, `telephone_employe`, `adresse_employe`, `email_employe`, `numero_employe`, `mdp`) VALUES
(1, 'Ndé', 'Rodrigue', '675849536', 'Essos', 'rodrigue@gmail.com', '15EM001', 'charlene'),
(2, 'Kongne', 'Rodrigue', '698292866', 'Nvog-Ada', 'kongne@yahoo.fr', '15EM002', 'charlene');

-- --------------------------------------------------------

--
-- Structure de la table `enseignant`
--

CREATE TABLE IF NOT EXISTS `enseignant` (
  `numero` varchar(255) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `profession` varchar(255) NOT NULL,
  `adresse` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `telephone` int(100) DEFAULT NULL,
  `cni` int(100) DEFAULT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `enseignant`
--

INSERT INTO `enseignant` (`numero`, `nom`, `prenom`, `profession`, `adresse`, `email`, `telephone`, `cni`) VALUES
('15EN000', 'Ndé', 'Rodrigue', 'Ingénieur', 'Nvog-Ada', 'rodrigue@yahoo.fr', 675849536, 111111111),
('15EN001', 'Kongne', 'Rodrigue', 'Ingénieur', 'Dang', 'kongne@yahoo.fr', 698292866, 222222222);

-- --------------------------------------------------------

--
-- Structure de la table `entree`
--

CREATE TABLE IF NOT EXISTS `entree` (
  `numero_entree` int(255) NOT NULL AUTO_INCREMENT,
  `quantite_entree` varchar(255) NOT NULL,
  `date_entree` varchar(255) NOT NULL,
  `provenance` varchar(255) NOT NULL,
  `reference_entree` varchar(255) NOT NULL,
  PRIMARY KEY (`numero_entree`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `fabrication`
--

CREATE TABLE IF NOT EXISTS `fabrication` (
  `numero` int(100) NOT NULL AUTO_INCREMENT,
  `num_fabrication` varchar(255) NOT NULL,
  `date_enregistrer` varchar(255) NOT NULL,
  `num_employe` varchar(255) NOT NULL,
  `conception` longtext NOT NULL,
  `statut_fabrication` varchar(255) NOT NULL,
  `appareil` varchar(255) NOT NULL,
  `quantite_fabrication` int(255) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `fabrication`
--

INSERT INTO `fabrication` (`numero`, `num_fabrication`, `date_enregistrer`, `num_employe`, `conception`, `statut_fabrication`, `appareil`, `quantite_fabrication`) VALUES
(1, '15FAB000', '01/10/2015', '15EM001', 'faire grande', 'En cours', 'Détecteur de métaux', 0),
(2, '15FAB001', '', '', 'devoir', 'non attribuée', 'Télévision', 0);

-- --------------------------------------------------------

--
-- Structure de la table `formation`
--

CREATE TABLE IF NOT EXISTS `formation` (
  `code` varchar(255) NOT NULL,
  `intitule` varchar(255) NOT NULL,
  `dure_min` int(100) NOT NULL,
  `dure_max` int(100) NOT NULL,
  `objectif` text NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `formation`
--

INSERT INTO `formation` (`code`, `intitule`, `dure_min`, `dure_max`, `objectif`) VALUES
('F001', 'Electronique analogique', 250, 200, 'SALMON RIVER – “Anyone get scared or nervous, that’s OK,” Kevin Yeates said as he pointed his boat’s bow straight into Devil’s Teeth Rapid. more\r\nSedar documents are in PDF format and require...\r\nStockWatch Front Page - 21 hrs ago\r\nSedar documents are in PDF format and require Adobe Reader to view them. You can also enable hit highlighting - Click here for instructions to enable...'),
('F003', 'Electronique de puissance', 300, 400, 'Permettre à chaque étudiant de pour pourvoir maitriser');

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

CREATE TABLE IF NOT EXISTS `fournisseur` (
  `numero_fournisseur` int(255) NOT NULL AUTO_INCREMENT,
  `nom_fournisseur` varchar(255) NOT NULL,
  `domaine` varchar(255) NOT NULL,
  `adresse` varchar(255) NOT NULL,
  `telephone` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  PRIMARY KEY (`numero_fournisseur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `fournisseur`
--

INSERT INTO `fournisseur` (`numero_fournisseur`, `nom_fournisseur`, `domaine`, `adresse`, `telephone`, `email`) VALUES
(1, 'ETS Ndé', 'Vente des composants électroniques', 'Nvog-Ada', '675 849 536', 'rodrigue@gmail.com'),
(2, 'ETS Kongne', 'Ventes des condensateurs', 'Essos', '675 849 536', 'kongne@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `prestationcloturer`
--

CREATE TABLE IF NOT EXISTS `prestationcloturer` (
  `num_cloturer` varchar(255) NOT NULL,
  `date_cloturer` varchar(255) DEFAULT NULL,
  `reduction_cloturer` varchar(255) DEFAULT NULL,
  `montant_cloturer` varchar(255) DEFAULT NULL,
  `main_cloturer` varchar(255) DEFAULT NULL,
  `temps_cloturer` varchar(255) DEFAULT NULL,
  `employer_cloturer` varchar(255) NOT NULL,
  PRIMARY KEY (`num_cloturer`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `prix`
--

CREATE TABLE IF NOT EXISTS `prix` (
  `prix_revient` float NOT NULL,
  `prix_recommande` float NOT NULL,
  `prix_minimal` float NOT NULL,
  `prix_maximal` float NOT NULL,
  `reference_prix` varchar(10) NOT NULL,
  `numero_prix` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`numero_prix`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=32 ;

--
-- Contenu de la table `prix`
--

INSERT INTO `prix` (`prix_revient`, `prix_recommande`, `prix_minimal`, `prix_maximal`, `reference_prix`, `numero_prix`) VALUES
(2000, 15, 10, 17, 'MAT7X5R', 6),
(250, 14, 10, 17, 'RIT2', 7),
(250, 20, 15, 25, 'RIT2', 8),
(100, 10, 8, 15, 'RIT3', 9),
(50, 15, 10, 20, 'RES10-0R', 10),
(45, 15, 10, 20, 'RES10-STRA', 11),
(25, 15, 10, 20, 'RES11-xxxx', 12),
(45, 15, 10, 20, 'RES12-1R', 13),
(60, 15, 10, 20, 'RES14-4R7', 14),
(345, 10, 9, 12, 'RES18-0R10', 15),
(45, 10, 8, 12, 'RES19-0R10', 16),
(215, 10, 8, 12, 'RES20-0R10', 17),
(90, 10, 8, 12, 'RES21-0R10', 18),
(115, 10, 8, 13, 'RES16-0R10', 19),
(45, 10, 8, 13, 'C1-1PF', 20),
(70, 10, 8, 12, 'C6-10NF', 21),
(65, 10, 8, 12, 'Condensate', 22),
(55, 10, 8, 13, 'C3-15PF', 23),
(35, 10, 8, 12, 'C3-15PF', 24),
(35, 10, 8, 13, 'C4-1PF', 25),
(25, 10, 8, 15, 'KIT4', 26),
(65, 10, 8, 17, 'C19-1UF', 27),
(75, 10, 8, 14, 'SEL1-0UH1', 28),
(195, 10, 8, 17, 'SEL3', 29),
(99, 10, 8, 17, 'SEL24', 30),
(65, 10, 8, 12, 'SEL4', 31);

-- --------------------------------------------------------

--
-- Structure de la table `qteprestation`
--

CREATE TABLE IF NOT EXISTS `qteprestation` (
  `numero` int(10) NOT NULL AUTO_INCREMENT,
  `num_prestation` varchar(255) NOT NULL,
  `reference_prestation` varchar(255) NOT NULL,
  `qte` int(100) NOT NULL,
  `qte_utilise` int(255) NOT NULL,
  `qte_retirer` int(255) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=57 ;

--
-- Contenu de la table `qteprestation`
--

INSERT INTO `qteprestation` (`numero`, `num_prestation`, `reference_prestation`, `qte`, `qte_utilise`, `qte_retirer`) VALUES
(1, '15DEP001', '2', 2, 0, 0),
(2, '15DEP001', '2', 2, 0, 0),
(3, '15DEP001', '3', 3, 0, 0),
(4, '15DEP001', '3', 3, 0, 0),
(5, '15DEP001', '3', 3, 0, 0),
(6, '15DEP001', '8', 8, 0, 0),
(7, '15DEP001', '4', 4, 0, 0),
(8, '15DEP001', '1', 1, 0, 0),
(9, '15DEP001', '', 0, 0, 0),
(10, '15DEP001', '', 0, 0, 0),
(11, '15DEP001', '', 0, 0, 0),
(12, '15DEP001', '', 0, 0, 0),
(13, '15DEP001', '', 0, 0, 0),
(14, '15DEP001', '3', 0, 0, 0),
(15, '15DEP001', 'aaaa', 0, 0, 0),
(17, '15DEP002', 'cvxcvxcvx', 0, 0, 0),
(22, '15FAB000', 'aaaa', 2, 55, 0),
(27, '15FAB000', 'djudshfd', 1, 0, 0),
(28, '15FAB000', 'jhsjshfskj', 2, 40, 0),
(29, '15FAB000', 'kik', 3, 0, 0),
(30, '15FAB000', 'jhsjshfskj', 9, 40, 0),
(31, '15DEP002', 'djudshfd', 3, 0, 0),
(32, '15DEP003', 'azzzzzze', 8, 0, 0),
(36, '15DEP003', 'MAT7X5R', 4, 0, 0),
(37, '15DEP003', 'kik', 6, 0, 0),
(38, '15DEP004', 'C19-1UF', 4, 0, 0),
(39, '15DEP004', 'MAT7X5R', -5, 0, 0),
(40, '15DEP004', 'C6-10NF', 4, 0, 0),
(41, '15DEP005', 'C19-1UF', 2, 0, 0),
(42, '15DEP005', 'C6-10NF', 4, 0, 0),
(43, '15DEP005', 'C19-1UF', 2, 0, 0),
(44, '15DEP005', 'C6-10NF', 4, 0, 0),
(45, '15DEP005', 'Condensate', -3, 0, 0),
(46, '15DEP006', 'C4-1PF', -3, 0, 0),
(47, '15DEP007', 'C4-1PF', 4, 3, 0),
(48, '15DEP007', 'C6-10NF', 3, 4, 0),
(49, '15DEP007', 'C3-15PF', 4, 4, 0),
(50, '15DEP007', 'MAT7X5R', 5, 5, 0),
(51, '15FAB001', 'C3-15PF', 65, 0, 0),
(52, '15FAB001', 'C6-10NF', 4, 0, 0),
(53, '15FAB001', 'MAT7X5R', 6, 0, 0),
(54, '15FAB001', 'C3-15PF', 5, 0, 0),
(55, '15FAB001', 'Condensate', 5, 0, 0),
(56, '15FAB001', 'C6-10NF', 6, 0, 0);

-- --------------------------------------------------------

--
-- Structure de la table `sortie`
--

CREATE TABLE IF NOT EXISTS `sortie` (
  `numero_sortie` int(255) NOT NULL AUTO_INCREMENT,
  `numero` varchar(255) NOT NULL,
  `reference_sortie` varchar(255) NOT NULL,
  `quantite_sortie` int(255) NOT NULL,
  `responsable` varchar(255) NOT NULL,
  `date_sortie` varchar(255) NOT NULL,
  `motif` varchar(255) NOT NULL,
  PRIMARY KEY (`numero_sortie`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Contenu de la table `sortie`
--

INSERT INTO `sortie` (`numero_sortie`, `numero`, `reference_sortie`, `quantite_sortie`, `responsable`, `date_sortie`, `motif`) VALUES
(1, '15FAB000', 'aaaa', 5, '15EM001', '02/10/2015 03:34:25', 'Fabrication numero 15FAB000'),
(2, '15FAB000', 'jhsjshfskj', 5, '15EM001', '02/10/2015 03:34:25', 'Fabrication numero 15FAB000'),
(3, '15DEP004', 'aaaa', 4, '15EM002', '02/10/2015 03:54:52', 'Fabrication numero 15DEP004'),
(4, '15DEP004', 'kik', 5, '15EM002', '02/10/2015 03:54:52', 'Fabrication numero 15DEP004'),
(5, '15FAC001', 'aaaa', 6, '15EM001', '03/10/2015 21:40:39', 'Vente facture numéro 15FAC001'),
(6, '15FAC001', 'kik', 5, '15EM001', '03/10/2015 21:40:39', 'Vente facture numéro 15FAC001'),
(7, '15FAC001', 'kik', 3, '15EM001', '03/10/2015 22:01:01', 'Vente facture numéro 15FAC001'),
(8, '15FAC001', 'aaaa', 30, '15EM001', '03/10/2015 22:07:51', 'Vente facture numéro 15FAC001'),
(9, '15FAC001', 'kik', 40, '15EM001', '03/10/2015 22:07:51', 'Vente facture numéro 15FAC001'),
(10, '15FAC002', 'aaaa', 5, '', '07/10/2015 09:44:32', 'Vente facture numéro 15FAC002'),
(11, '15FAC002', 'kik', 12, '', '07/10/2015 09:44:32', 'Vente facture numéro 15FAC002'),
(12, '15DEP007', 'C4-1PF', 3, '15EM002', '23/10/2015 04:10:27', 'Dépannage numéro 15DEP007'),
(13, '15DEP007', 'C6-10NF', 4, '15EM002', '23/10/2015 04:10:27', 'Dépannage numéro 15DEP007'),
(14, '15DEP007', 'C3-15PF', 4, '15EM002', '23/10/2015 04:10:27', 'Dépannage numéro 15DEP007'),
(15, '15DEP007', 'MAT7X5R', 5, '15EM002', '23/10/2015 04:10:27', 'Dépannage numéro 15DEP007');

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE IF NOT EXISTS `type` (
  `reference` varchar(10) NOT NULL,
  `designation` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`reference`),
  KEY `reference` (`reference`),
  KEY `reference_2` (`reference`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `type_client`
--

CREATE TABLE IF NOT EXISTS `type_client` (
  `numero` int(100) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `etoile` int(100) DEFAULT NULL,
  `reduction` varchar(255) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `type_client`
--

INSERT INTO `type_client` (`numero`, `nom`, `etoile`, `reduction`) VALUES
(1, 'Occasionnel', 0, '2'),
(2, 'Professionnel', 2, '5'),
(3, 'Professionnel ', 5, '5');

-- --------------------------------------------------------

--
-- Structure de la table `vente`
--

CREATE TABLE IF NOT EXISTS `vente` (
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  `numero_vente` varchar(255) NOT NULL,
  `numclient_vente` varchar(255) NOT NULL,
  `nomclient_vente` varchar(255) NOT NULL,
  `date_vente` varchar(255) NOT NULL,
  `num_employe` varchar(255) NOT NULL,
  `prixU` varchar(255) NOT NULL,
  `prixT` varchar(255) NOT NULL,
  `qte_vente` varchar(255) NOT NULL,
  `reference_vente` varchar(255) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Contenu de la table `vente`
--

INSERT INTO `vente` (`numero`, `numero_vente`, `numclient_vente`, `nomclient_vente`, `date_vente`, `num_employe`, `prixU`, `prixT`, `qte_vente`, `reference_vente`) VALUES
(1, '15FAC001', '', '', '03/10/2015 21:40:39', '', '25', '150', '0', 'aaaa'),
(2, '15FAC001', '', '', '03/10/2015 21:40:39', '', '20', '100', '0', 'kik'),
(3, '15FAC001', '', '', '03/10/2015 22:01:01', '', '30', '90', '0', 'kik'),
(4, '15FAC001', '15CL000', '', '03/10/2015 22:07:51', '', '10', '300', '0', 'aaaa'),
(5, '15FAC001', '15CL000', '', '03/10/2015 22:07:51', '', '25', '1000', '0', 'kik'),
(6, '15FAC002', '15CL000', '', '07/10/2015 09:44:32', '', '60', '300', '0', 'aaaa'),
(7, '15FAC002', '15CL000', '', '07/10/2015 09:44:32', '', '45', '540', '0', 'kik');

-- --------------------------------------------------------

--
-- Structure de la table `ventes`
--

CREATE TABLE IF NOT EXISTS `ventes` (
  `numero` int(255) NOT NULL AUTO_INCREMENT,
  `numero_fac` varchar(255) NOT NULL,
  `date_fac` varchar(255) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `ventes`
--

INSERT INTO `ventes` (`numero`, `numero_fac`, `date_fac`) VALUES
(1, '15FAC001', '03/10/2015 22:07:51'),
(2, '15FAC002', '07/10/2015 09:44:32');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
