-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 09-11-2021 a las 00:05:29
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyecto`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Direccion` varchar(200) NOT NULL,
  `Contacto` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`ID`, `Nombre`, `Direccion`, `Contacto`) VALUES
(50, 'santiago', 'fdsfs', '32674'),
(63, 'Juan Carlos', 'pintos', '09983363');

--
-- Disparadores `cliente`
--
DELIMITER $$
CREATE TRIGGER `controlborrar` BEFORE DELETE ON `cliente` FOR EACH ROW INSERT INTO control (Suceso,Tabla,FechaHora) VALUES ('Se elimino un cliente','Cliente',NOW())
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `controlingreso` BEFORE INSERT ON `cliente` FOR EACH ROW INSERT INTO control (Suceso,Tabla,FechaHora) VALUES ('Se ingreso un nuevo cliente','Cliente',NOW())
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `controlmodificar` BEFORE UPDATE ON `cliente` FOR EACH ROW INSERT INTO control (Suceso,Tabla,FechaHora) VALUES ('Se modifico un cliente','Cliente',NOW())
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `control`
--

CREATE TABLE `control` (
  `ID` int(11) NOT NULL,
  `Usuario` varchar(30) NOT NULL,
  `Suceso` varchar(33) NOT NULL,
  `Tabla` varchar(22) NOT NULL,
  `FechaHora` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `control`
--

INSERT INTO `control` (`ID`, `Usuario`, `Suceso`, `Tabla`, `FechaHora`) VALUES
(68, 'admin', 'Se ingreso un nuevo cliente', 'Cliente', '2021-11-08'),
(69, 'admin', 'Se ingreso una Venta', 'Venta', '2021-11-08'),
(70, 'admin', 'Se modifico una Venta', 'Venta', '2021-11-08'),
(71, 'admin', 'Se elimino una Venta ', 'Venta', '2021-11-08'),
(72, 'admin', 'Se elimino un producto', 'Producto', '2021-11-08'),
(73, 'admin', 'Se elimino un producto', 'Producto', '2021-11-08'),
(74, 'admin', 'Se modifico un producto', 'Producto', '2021-11-08'),
(75, 'admin', 'Se ingreso un nuevo producto', 'Producto', '2021-11-08');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `ID` int(11) NOT NULL,
  `nombre_producto` varchar(35) NOT NULL,
  `Fecha` varchar(45) NOT NULL,
  `precio` int(30) NOT NULL,
  `Tipo_de_Pago` varchar(100) NOT NULL,
  `Tipo_de_Envio` varchar(50) NOT NULL,
  `Total` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Disparadores `factura`
--
DELIMITER $$
CREATE TRIGGER `controlborrar3` BEFORE DELETE ON `factura` FOR EACH ROW INSERT INTO control (Suceso,Tabla,FechaHora) VALUES ('Se elimino una Venta ','Venta',NOW())
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `controlingreso3` BEFORE INSERT ON `factura` FOR EACH ROW INSERT INTO control (Suceso,Tabla,FechaHora) VALUES ('Se ingreso una Venta','Venta',NOW())
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `controlmodificar3` BEFORE UPDATE ON `factura` FOR EACH ROW INSERT INTO control (Suceso,Tabla,FechaHora) VALUES ('Se modifico una Venta','Venta',NOW())
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Stock` int(100) NOT NULL,
  `Precio` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`ID`, `Nombre`, `Stock`, `Precio`) VALUES
(11, 'Papa', 12, 1240),
(16, 'Colet', 5, 35),
(17, 'Colet', 5, 35),
(18, 'Lactolate', 44, 87),
(19, 'Lactolate', 44, 87),
(20, 'Arroz', 25, 250);

--
-- Disparadores `producto`
--
DELIMITER $$
CREATE TRIGGER `controlborrar2` BEFORE DELETE ON `producto` FOR EACH ROW INSERT INTO control (Suceso,Tabla,FechaHora) VALUES ('Se elimino un producto','Producto',NOW())
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `controlingreso2` BEFORE INSERT ON `producto` FOR EACH ROW INSERT INTO control (Suceso,Tabla,FechaHora) VALUES ('Se ingreso un nuevo producto','Producto',NOW())
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `controlmodificar2` BEFORE UPDATE ON `producto` FOR EACH ROW INSERT INTO control (Suceso,Tabla,FechaHora) VALUES ('Se modifico un producto','Producto',NOW())
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profactura`
--

CREATE TABLE `profactura` (
  `ID` int(11) NOT NULL,
  `ID_Producto` int(11) NOT NULL,
  `Cantidad` varchar(50) NOT NULL,
  `Importe` varchar(200) NOT NULL,
  `ID_factura` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Contacto` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`ID`, `Nombre`, `Contacto`) VALUES
(1, 'conaprole', '44759273'),
(2, 'Aromacos', '44759273');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `TipodeUsuario` varchar(20) NOT NULL,
  `usuario` varchar(35) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `password` varchar(65) NOT NULL,
  `token` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id`, `TipodeUsuario`, `usuario`, `correo`, `password`, `token`) VALUES
(66, 'Administrador', 'admin', 'admin2021@gmail.com', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', '');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `control`
--
ALTER TABLE `control`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `profactura`
--
ALTER TABLE `profactura`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=64;

--
-- AUTO_INCREMENT de la tabla `control`
--
ALTER TABLE `control`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=76;

--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
