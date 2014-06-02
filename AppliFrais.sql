-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           5.5.24-log - MySQL Community Server (GPL)
-- Serveur OS:                   Win64
-- HeidiSQL Version:             8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Export de la structure de la base pour applifrais
CREATE DATABASE IF NOT EXISTS `applifrais` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `applifrais`;


-- Export de la structure de table applifrais. etat
CREATE TABLE IF NOT EXISTS `etat` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Export de données de la table applifrais.etat: ~4 rows (environ)
/*!40000 ALTER TABLE `etat` DISABLE KEYS */;
INSERT INTO `etat` (`id`, `libelle`) VALUES
	(1, 'Remboursée'),
	(2, 'Saisie clôturée'),
	(3, 'Fiche créée, saisie en cours'),
	(4, 'Validée et mise en paiement');
/*!40000 ALTER TABLE `etat` ENABLE KEYS */;


-- Export de la structure de table applifrais. fichefrais
CREATE TABLE IF NOT EXISTS `fichefrais` (
  `idVisiteur` int(11) NOT NULL,
  `mois` varchar(50) NOT NULL,
  `nbJustificatifs` int(11) DEFAULT NULL,
  `montantValide` double DEFAULT NULL,
  `dateModif` date DEFAULT NULL,
  `idEtat` int(11) DEFAULT NULL,
  `manqueJustificatif` int(11) DEFAULT '0',
  PRIMARY KEY (`idVisiteur`,`mois`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Export de données de la table applifrais.fichefrais: ~6 rows (environ)
/*!40000 ALTER TABLE `fichefrais` DISABLE KEYS */;
INSERT INTO `fichefrais` (`idVisiteur`, `mois`, `nbJustificatifs`, `montantValide`, `dateModif`, `idEtat`, `manqueJustificatif`) VALUES
	(1, '3/2014', NULL, NULL, '2014-04-15', 3, NULL),
	(1, '4/2014', NULL, NULL, '2014-04-14', 3, NULL),
	(1, '5/2014', NULL, NULL, '2014-05-30', 3, NULL),
	(2, '5/2014', 2, NULL, '2014-05-17', 1, 1),
	(2, '6/2014', NULL, NULL, '2014-06-02', 3, NULL),
	(5, '5/2014', NULL, NULL, '2014-06-02', 3, NULL);
/*!40000 ALTER TABLE `fichefrais` ENABLE KEYS */;


-- Export de la structure de table applifrais. fraisforfait
CREATE TABLE IF NOT EXISTS `fraisforfait` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(50) DEFAULT NULL,
  `montant` double DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Export de données de la table applifrais.fraisforfait: ~4 rows (environ)
/*!40000 ALTER TABLE `fraisforfait` DISABLE KEYS */;
INSERT INTO `fraisforfait` (`id`, `libelle`, `montant`) VALUES
	(1, 'Forfait Etape', 15),
	(2, 'Frais Kilométrique', 50),
	(3, 'Nuitée Hôtel', 80),
	(4, 'Repas Restaurant', 1.58);
/*!40000 ALTER TABLE `fraisforfait` ENABLE KEYS */;


-- Export de la structure de table applifrais. lignefraisforfait
CREATE TABLE IF NOT EXISTS `lignefraisforfait` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idVisiteur` int(11) NOT NULL,
  `mois` varchar(50) NOT NULL,
  `idFraisForfait` int(11) NOT NULL,
  `quantite` int(11) DEFAULT NULL,
  `idEtat` int(11) DEFAULT NULL,
  `dateOperation` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- Export de données de la table applifrais.lignefraisforfait: ~13 rows (environ)
/*!40000 ALTER TABLE `lignefraisforfait` DISABLE KEYS */;
INSERT INTO `lignefraisforfait` (`id`, `idVisiteur`, `mois`, `idFraisForfait`, `quantite`, `idEtat`, `dateOperation`) VALUES
	(1, 1, '4/2014', 1, 2, 3, NULL),
	(2, 1, '4/2014', 3, 5, 3, NULL),
	(3, 1, '3/2014', 1, 2, 3, NULL),
	(4, 2, '5/2014', 1, 5, 3, NULL),
	(5, 2, '5/2014', 2, 4, 3, NULL),
	(6, 2, '5/2014', 4, 254, 3, NULL),
	(7, 1, '5/2014', 1, 5, 3, NULL),
	(8, 2, '6/2014', 1, 6, 3, '2014-06-02'),
	(9, 2, '6/2014', 2, 3, 3, '2014-06-02'),
	(10, 5, '5/2014', 1, 1, 3, '2014-06-02'),
	(11, 5, '5/2014', 2, 1, 3, '2014-06-02'),
	(12, 5, '5/2014', 3, 1, 3, NULL),
	(13, 5, '5/2014', 4, 50, 3, '2014-06-02');
/*!40000 ALTER TABLE `lignefraisforfait` ENABLE KEYS */;


-- Export de la structure de table applifrais. lignefraishorsforfait
CREATE TABLE IF NOT EXISTS `lignefraishorsforfait` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idVisiteur` int(11) NOT NULL,
  `mois` varchar(50) NOT NULL,
  `libelle` varchar(100) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `montant` double DEFAULT NULL,
  `idEtat` int(11) DEFAULT NULL,
  `dateOperation` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Export de données de la table applifrais.lignefraishorsforfait: ~3 rows (environ)
/*!40000 ALTER TABLE `lignefraishorsforfait` DISABLE KEYS */;
INSERT INTO `lignefraishorsforfait` (`id`, `idVisiteur`, `mois`, `libelle`, `date`, `montant`, `idEtat`, `dateOperation`) VALUES
	(1, 1, '4/2014', 'nouveau', '2014-04-12', 15, 3, NULL),
	(2, 2, '5/2014', 'invite patron', '2014-04-12', 200, 4, NULL),
	(3, 1, '5/2014', 'salut', '2014-04-16', 45, 3, NULL);
/*!40000 ALTER TABLE `lignefraishorsforfait` ENABLE KEYS */;


-- Export de la structure de table applifrais. visiteur
CREATE TABLE IF NOT EXISTS `visiteur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `login` varchar(50) DEFAULT NULL,
  `mdp` varchar(50) DEFAULT NULL,
  `adresse` varchar(50) DEFAULT NULL,
  `cp` varchar(50) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `dateEmbauche` date DEFAULT NULL,
  `comptable` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Export de données de la table applifrais.visiteur: ~5 rows (environ)
/*!40000 ALTER TABLE `visiteur` DISABLE KEYS */;
INSERT INTO `visiteur` (`id`, `nom`, `prenom`, `login`, `mdp`, `adresse`, `cp`, `ville`, `dateEmbauche`, `comptable`) VALUES
	(1, 'Himeur', 'Sarah', 'admin', 'admin', 'Cours Albert Thomas', '69003', 'LYON', '2014-01-28', 1),
	(2, 'Martin', 'Philippe', 'p.martin', 'pmartin', 'une adresse', '6900', 'lyon', '2014-04-13', 0),
	(3, 'Nouveau', 'Test', 'nouveau', 'nouveau', 'nouveau', '69009', 'lyon', '2009-06-09', 1),
	(4, 'comptable', 'comptable', 'comptable', 'comptable', '', '', '', '2014-06-02', 1),
	(5, 'visiteur', 'visiteur', 'visiteur', 'visiteur', '', '', '', '2014-06-02', 0);
/*!40000 ALTER TABLE `visiteur` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
