CREATE TABLE `alumnos` (
  `noControl` varchar(50) NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `apellidoPaterno` varchar(100) DEFAULT NULL,
  `apellidoMaterno` varchar(100) DEFAULT NULL,
  `genero` varchar(10) DEFAULT NULL,
  `fechadeNacimiento` varchar(10) DEFAULT NULL,
  `correoElectronico` varchar(250) DEFAULT NULL,
  `telefonodeContacto` int(11) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `municipio` int(11) DEFAULT NULL,
  `domicilio` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`noControl`),
  KEY `estado` (`estado`),
  KEY `municipio` (`municipio`),
  CONSTRAINT `alumnos_ibfk_1` FOREIGN KEY (`estado`) REFERENCES `estados` (`codigo`),
  CONSTRAINT `alumnos_ibfk_2` FOREIGN KEY (`municipio`) REFERENCES `municipios` (`idMunicipio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `estados` (
  `codigo` varchar(10) NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `maestros` (
  `noControlM` varchar(50) NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `apellidoPaterno` varchar(100) DEFAULT NULL,
  `apellidoMaterno` varchar(100) DEFAULT NULL,
  `genero` varchar(10) DEFAULT NULL,
  `fechadeNacimiento` varchar(10) DEFAULT NULL,
  `correoElectronico` varchar(250) DEFAULT NULL,
  `nocuenta` int(11) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `licenciatura` varchar(250) DEFAULT NULL,
  `maestria` varchar(250) DEFAULT NULL,
  `doctorado` varchar(250) DEFAULT NULL,
  `municipio` int(11) DEFAULT NULL,
  `licenciaturadoc` varchar(250) DEFAULT NULL,
  `maestriadoc` varchar(250) DEFAULT NULL,
  `doctoradodoc` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`noControlM`),
  KEY `estado` (`estado`),
  KEY `municipio` (`municipio`),
  CONSTRAINT `maestros_ibfk_1` FOREIGN KEY (`estado`) REFERENCES `estados` (`codigo`),
  CONSTRAINT `maestros_ibfk_2` FOREIGN KEY (`municipio`) REFERENCES `municipios` (`idMunicipio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `municipios` (
  `idMunicipio` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `fkEstado` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idMunicipio`),
  KEY `fkEstado` (`fkEstado`),
  CONSTRAINT `municipios_ibfk_1` FOREIGN KEY (`fkEstado`) REFERENCES `estados` (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=4917 DEFAULT CHARSET=latin1;

