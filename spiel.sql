-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 01. Jul 2024 um 09:51
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `spiel`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `antwort`
--

CREATE TABLE `antwort` (
  `id` int(11) NOT NULL,
  `antwort_text` varchar(255) NOT NULL,
  `richtige_antwort` tinyint(1) NOT NULL,
  `frage_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `antwort`
--

INSERT INTO `antwort` (`id`, `antwort_text`, `richtige_antwort`, `frage_id`) VALUES
(1, 'Kanada', 1, 1),
(2, 'USA', 0, 1),
(3, 'Mexiko', 0, 1),
(4, 'Kuba', 0, 1),
(5, 'USA', 1, 2),
(6, 'Kanada', 0, 2),
(7, 'Mexiko', 0, 2),
(8, 'Kuba', 0, 2),
(9, 'Kanada', 1, 3),
(10, 'USA', 0, 3),
(11, 'Mexiko', 0, 3),
(12, 'Panama', 0, 3),
(13, 'USA', 1, 4),
(14, 'Kanada', 0, 4),
(15, 'Mexiko', 0, 4),
(16, 'Costa Rica', 0, 4),
(17, 'Kanada', 1, 5),
(18, 'Haiti', 0, 5),
(19, 'USA', 0, 5),
(20, 'Mexiko', 0, 5),
(21, 'Mexiko', 1, 6),
(22, 'Guatemala', 0, 6),
(23, 'Belize', 0, 6),
(24, 'Honduras', 0, 6),
(25, 'Kanada', 1, 7),
(26, 'USA', 0, 7),
(27, 'Mexiko', 0, 7),
(28, 'Grönland', 0, 7),
(29, 'USA', 1, 8),
(30, 'Kanada', 0, 8),
(31, 'Grönland', 0, 8),
(32, 'Island', 0, 8),
(33, 'USA', 1, 9),
(34, 'Kanada', 0, 9),
(35, 'Frankreich', 0, 9),
(36, 'Mexiko', 0, 9),
(37, 'Kuba', 1, 10),
(38, 'Jamaika', 0, 10),
(39, 'Bahamas', 0, 10),
(40, 'Dominikanische Republik', 0, 10),
(41, 'Ottawa', 1, 11),
(42, 'Toronto', 0, 11),
(43, 'Montreal', 0, 11),
(44, 'Vancouver', 0, 11),
(45, 'Washington D.C.', 1, 12),
(46, 'New York', 0, 12),
(47, 'Los Angeles', 0, 12),
(48, 'Chicago', 0, 12),
(49, 'Mexiko-Stadt', 1, 13),
(50, 'Guadalajara', 0, 13),
(51, 'Monterrey', 0, 13),
(52, 'Cancún', 0, 13),
(53, 'Havanna', 1, 14),
(54, 'Santiago de Cuba', 0, 14),
(55, 'Camagüey', 0, 14),
(56, 'Holguín', 0, 14),
(57, 'Panama-Stadt', 1, 15),
(58, 'Colón', 0, 15),
(59, 'David', 0, 15),
(60, 'Santiago', 0, 15),
(61, 'San José', 1, 16),
(62, 'Liberia', 0, 16),
(63, 'Alajuela', 0, 16),
(64, 'Cartago', 0, 16),
(65, 'Kingston', 1, 17),
(66, 'Montego Bay', 0, 17),
(67, 'Ocho Rios', 0, 17),
(68, 'Negril', 0, 17),
(69, 'Port-au-Prince', 1, 18),
(70, 'Cap-Haïtien', 0, 18),
(71, 'Gonaïves', 0, 18),
(72, 'Les Cayes', 0, 18),
(73, 'Santo Domingo', 1, 19),
(74, 'Santiago', 0, 19),
(75, 'Punta Cana', 0, 19),
(76, 'Puerto Plata', 0, 19),
(77, 'Belmopan', 1, 20),
(78, 'Belize City', 0, 20),
(79, 'San Ignacio', 0, 20),
(80, 'Dangriga', 0, 20),
(81, 'Brasilien', 1, 21),
(82, 'Argentinien', 0, 21),
(83, 'Peru', 0, 21),
(84, 'Kolumbien', 0, 21),
(85, 'Brasilien', 1, 22),
(86, 'Peru', 0, 22),
(87, 'Kolumbien', 0, 22),
(88, 'Venezuela', 0, 22),
(89, 'Chile', 1, 23),
(90, 'Peru', 0, 23),
(91, 'Ecuador', 0, 23),
(92, 'Argentinien', 0, 23),
(93, 'Ecuador', 1, 24),
(94, 'Kolumbien', 0, 24),
(95, 'Venezuela', 0, 24),
(96, 'Peru', 0, 24),
(97, 'Peru und Bolivien', 1, 25),
(98, 'Bolivien', 0, 25),
(99, 'Peru', 0, 25),
(100, 'Ecuador', 0, 25),
(101, 'Suriname', 1, 26),
(102, 'Guyana', 0, 26),
(103, 'Französisch-Guayana', 0, 26),
(104, 'Venezuela', 0, 26),
(105, 'Brasilien', 1, 27),
(106, 'Argentinien', 0, 27),
(107, 'Kolumbien', 0, 27),
(108, 'Venezuela', 0, 27),
(109, 'Peru', 1, 28),
(110, 'Bolivien', 0, 28),
(111, 'Ecuador', 0, 28),
(112, 'Kolumbien', 0, 28),
(113, 'Chile', 1, 29),
(114, 'Argentinien', 0, 29),
(115, 'Peru', 0, 29),
(116, 'Kolumbien', 0, 29),
(117, 'Argentinien', 1, 30),
(118, 'Chile', 0, 30),
(119, 'Brasilien', 0, 30),
(120, 'Uruguay', 0, 30),
(121, 'Brasília', 1, 31),
(122, 'Rio de Janeiro', 0, 31),
(123, 'Sao Paulo', 0, 31),
(124, 'Salvador', 0, 31),
(125, 'Buenos Aires', 1, 32),
(126, 'Córdoba', 0, 32),
(127, 'Rosario', 0, 32),
(128, 'Mendoza', 0, 32),
(129, 'Lima', 1, 33),
(130, 'Cusco', 0, 33),
(131, 'Arequipa', 0, 33),
(132, 'Trujillo', 0, 33),
(133, 'Bogotá', 1, 34),
(134, 'Medellín', 0, 34),
(135, 'Cali', 0, 34),
(136, 'Cartagena', 0, 34),
(137, 'Caracas', 1, 35),
(138, 'Maracaibo', 0, 35),
(139, 'Valencia', 0, 35),
(140, 'Barquisimeto', 0, 35),
(141, 'Santiago', 1, 36),
(142, 'Valparaíso', 0, 36),
(143, 'Concepción', 0, 36),
(144, 'Antofagasta', 0, 36),
(145, 'Quito', 1, 37),
(146, 'Guayaquil', 0, 37),
(147, 'Cuenca', 0, 37),
(148, 'Santo Domingo', 0, 37),
(149, 'La Paz und Sucre', 1, 38),
(150, 'Santa Cruz', 0, 38),
(151, 'Cochabamba', 0, 38),
(152, 'Oruro', 0, 38),
(153, 'Asunción', 1, 39),
(154, 'Ciudad del Este', 0, 39),
(155, 'San Lorenzo', 0, 39),
(156, 'Luque', 0, 39),
(157, 'Montevideo', 1, 40),
(158, 'Salto', 0, 40),
(159, 'Ciudad de la Costa', 0, 40),
(160, 'Paysandú', 0, 40);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `ergebnis`
--

CREATE TABLE `ergebnis` (
  `id` int(11) NOT NULL,
  `ergebnis` int(11) NOT NULL,
  `spieler_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `ergebnis`
--

INSERT INTO `ergebnis` (`id`, `ergebnis`, `spieler_id`) VALUES
(1, 0, 55),
(2, 1, 56),
(3, 4, 57),
(4, 1, 58);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `frage`
--

CREATE TABLE `frage` (
  `id` int(11) NOT NULL,
  `frage_text` varchar(255) NOT NULL,
  `kontinent_id` int(11) NOT NULL,
  `typ` enum('land','capital') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `frage`
--

INSERT INTO `frage` (`id`, `frage_text`, `kontinent_id`, `typ`) VALUES
(1, 'Welches Land in Nordamerika ist für seinen Ahornsirup bekannt?', 1, 'land'),
(2, 'Welches ist das bevölkerungsreichste Land Nordamerikas?', 1, 'land'),
(3, 'Welches Land in Nordamerika grenzt sowohl an den Atlantik als auch an den Pazifik?', 1, 'land'),
(4, 'Welches Land ist bekannt für den Grand Canyon?', 1, 'land'),
(5, 'Welches nordamerikanische Land hat Französisch als Amtssprache?', 1, 'land'),
(6, 'Welches Land ist die Heimat der Maya-Ruinen von Chichen Itza?', 1, 'land'),
(7, 'Welches ist das flächenmäßig größte Land in Nordamerika?', 1, 'land'),
(8, 'Welches Land ist bekannt für seine Fjorde und Gletscher in Alaska?', 1, 'land'),
(9, 'In welchem Land befindet sich die Freiheitsstatue?', 1, 'land'),
(10, 'Welches Land ist für seine karibischen Strände und den Rum bekannt?', 1, 'land'),
(11, 'Was ist die Hauptstadt von Kanada?', 1, 'capital'),
(12, 'Was ist die Hauptstadt der Vereinigten Staaten?', 1, 'capital'),
(13, 'Was ist die Hauptstadt von Mexiko?', 1, 'capital'),
(14, 'Was ist die Hauptstadt von Kuba?', 1, 'capital'),
(15, 'Was ist die Hauptstadt von Panama?', 1, 'capital'),
(16, 'Was ist die Hauptstadt von Costa Rica?', 1, 'capital'),
(17, 'Was ist die Hauptstadt von Jamaica?', 1, 'capital'),
(18, 'Was ist die Hauptstadt von Haiti?', 1, 'capital'),
(19, 'Was ist die Hauptstadt der Dominikanischen Republik?', 1, 'capital'),
(20, 'Was ist die Hauptstadt von Belize?', 1, 'capital'),
(21, 'Welches südamerikanische Land hat die größte Fläche?', 2, 'land'),
(22, 'In welchem Land befindet sich der Amazonas-Regenwald hauptsächlich?', 2, 'land'),
(23, 'Welches Land in Südamerika ist bekannt für die Osterinseln?', 2, 'land'),
(24, 'Welches Land ist nach dem Äquator benannt?', 2, 'land'),
(25, 'In welchem Land befindet sich der Titicaca-See?', 2, 'land'),
(26, 'Welches Land in Südamerika hat Niederländisch als offizielle Sprache?', 2, 'land'),
(27, 'Welches Land ist bekannt für den Karneval in Rio?', 2, 'land'),
(28, 'In welchem Land liegt Machu Picchu?', 2, 'land'),
(29, 'Welches Land in Südamerika grenzt nicht an Brasilien?', 2, 'land'),
(30, 'Welches südamerikanische Land ist für seinen Wein bekannt?', 2, 'land'),
(31, 'Was ist die Hauptstadt von Brasilien?', 2, 'capital'),
(32, 'Was ist die Hauptstadt von Argentinien?', 2, 'capital'),
(33, 'Was ist die Hauptstadt von Peru?', 2, 'capital'),
(34, 'Was ist die Hauptstadt von Kolumbien?', 2, 'capital'),
(35, 'Was ist die Hauptstadt von Venezuela?', 2, 'capital'),
(36, 'Was ist die Hauptstadt von Chile?', 2, 'capital'),
(37, 'Was ist die Hauptstadt von Ecuador?', 2, 'capital'),
(38, 'Was ist die Hauptstadt von Bolivien?', 2, 'capital'),
(39, 'Was ist die Hauptstadt von Paraguay?', 2, 'capital'),
(40, 'Was ist die Hauptstadt von Uruguay?', 2, 'capital');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kontinent`
--

CREATE TABLE `kontinent` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `kontinent`
--

INSERT INTO `kontinent` (`id`, `name`) VALUES
(1, 'NordAmerika'),
(2, 'SudAmerika');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `spieler`
--

CREATE TABLE `spieler` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `spieler`
--

INSERT INTO `spieler` (`id`, `name`) VALUES
(1, 'ashraf'),
(2, 'pojjop'),
(3, 'kük'),
(4, 'üpküpk'),
(5, 'oijoij'),
(6, 'jpjop'),
(7, 'jpjop'),
(8, 'jpjop'),
(9, 'jpjop'),
(10, 'kopk'),
(11, 'ojpjop'),
(12, 'opjop'),
(13, 'hioho'),
(14, 'pokkop'),
(15, 'oji'),
(16, 'pojjop'),
(17, 'ükp'),
(18, 'ioj'),
(19, 'kljklj'),
(20, 'kopk'),
(21, 'opjop'),
(22, 'iou'),
(23, 'iojioj'),
(24, 'iohio'),
(25, 'kopk'),
(26, 'kjkl'),
(27, 'lkjkjl'),
(28, 'kljjkl'),
(29, 'jiojio'),
(30, 'joij'),
(31, 'kljlk'),
(32, 'kljjkl'),
(33, 'jpoj'),
(34, 'oijioj'),
(35, 'hjkhk'),
(36, 'okpo'),
(37, 'oijijo'),
(38, 'oijioj'),
(39, 'uoiuo'),
(40, 'oij'),
(41, 'ijojio'),
(42, 'opipoi'),
(43, 'jop'),
(44, 'ijoj'),
(45, 'uhoiu'),
(46, 'okop'),
(47, 'opkop'),
(48, 'pojp'),
(49, 'okpokp'),
(50, 'jpoj'),
(51, 'hioioh'),
(52, 'jopj'),
(53, 'iopi'),
(54, 'jpoj'),
(55, 'pojojp'),
(56, 'oihhio'),
(57, 'sa'),
(58, 'hussen');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `antwort`
--
ALTER TABLE `antwort`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_frage` (`frage_id`);

--
-- Indizes für die Tabelle `ergebnis`
--
ALTER TABLE `ergebnis`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_spieler` (`spieler_id`);

--
-- Indizes für die Tabelle `frage`
--
ALTER TABLE `frage`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_kontinent` (`kontinent_id`);

--
-- Indizes für die Tabelle `kontinent`
--
ALTER TABLE `kontinent`
  ADD PRIMARY KEY (`id`);

--
-- Indizes für die Tabelle `spieler`
--
ALTER TABLE `spieler`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `antwort`
--
ALTER TABLE `antwort`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=161;

--
-- AUTO_INCREMENT für Tabelle `ergebnis`
--
ALTER TABLE `ergebnis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT für Tabelle `frage`
--
ALTER TABLE `frage`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT für Tabelle `kontinent`
--
ALTER TABLE `kontinent`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT für Tabelle `spieler`
--
ALTER TABLE `spieler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `antwort`
--
ALTER TABLE `antwort`
  ADD CONSTRAINT `fk_frage` FOREIGN KEY (`frage_id`) REFERENCES `frage` (`id`);

--
-- Constraints der Tabelle `ergebnis`
--
ALTER TABLE `ergebnis`
  ADD CONSTRAINT `fk_spieler` FOREIGN KEY (`spieler_id`) REFERENCES `spieler` (`id`);

--
-- Constraints der Tabelle `frage`
--
ALTER TABLE `frage`
  ADD CONSTRAINT `fk_kontinent` FOREIGN KEY (`kontinent_id`) REFERENCES `kontinent` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
