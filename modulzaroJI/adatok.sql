-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Jún 07. 21:45
-- Kiszolgáló verziója: 10.4.24-MariaDB
-- PHP verzió: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `modulzaroji`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `adatok`
--

CREATE TABLE `adatok` (
  `id` int(250) NOT NULL,
  `nev` varchar(250) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL,
  `email` varchar(40) NOT NULL,
  `tel` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `stat` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- A tábla adatainak kiíratása `adatok`
--

INSERT INTO `adatok` (`id`, `nev`, `email`, `tel`, `password`, `stat`) VALUES
(19, 'Kertelek', 'egykettoharom@kertelek.com', 'Nem adott meg számot', 'a497b9765b087a918fa18421ac222f2ab79d18ed', 0),
(20, 'Tesztuser', 'tesztuser@testuser.com', '+361526358', '5fb6dfa00b3cb9a754c6bc1a075b822a032e48b3', 0);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `adatok`
--
ALTER TABLE `adatok`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `adatok`
--
ALTER TABLE `adatok`
  MODIFY `id` int(250) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
