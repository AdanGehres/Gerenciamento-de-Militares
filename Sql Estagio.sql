-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.28-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para gerenciamento militar
CREATE DATABASE IF NOT EXISTS `gerenciamento militar` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `gerenciamento militar`;

-- Copiando estrutura para tabela gerenciamento militar.gerenciamento
CREATE TABLE IF NOT EXISTS `gerenciamento` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `id_militar` int(11) NOT NULL DEFAULT '0',
  `Data` date NOT NULL,
  `Saida` date NOT NULL,
  `Retorno` date NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `id_militar` (`id_militar`),
  CONSTRAINT `id_militar` FOREIGN KEY (`id_militar`) REFERENCES `militar` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela gerenciamento militar.gerenciamento: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `gerenciamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `gerenciamento` ENABLE KEYS */;

-- Copiando estrutura para tabela gerenciamento militar.militar
CREATE TABLE IF NOT EXISTS `militar` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Graduacao` varchar(50) NOT NULL DEFAULT '0',
  `Nome` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela gerenciamento militar.militar: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `militar` DISABLE KEYS */;
/*!40000 ALTER TABLE `militar` ENABLE KEYS */;

-- Copiando estrutura para tabela gerenciamento militar.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(50) NOT NULL DEFAULT '0',`gerenciamento militar`
  `Senha` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela gerenciamento militar.usuario: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`ID`, `Usuario`, `Senha`) VALUES
	(1, 'Adan', '123');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
