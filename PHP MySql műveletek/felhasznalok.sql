-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Jún 17. 21:50
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
-- Adatbázis: `felhasznalok`
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
  `stat` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `adatok`
--

INSERT INTO `adatok` (`id`, `nev`, `email`, `tel`, `password`, `stat`) VALUES
(3, 'istvan', 'saht@met.com', '123134', 'sajt', 0),
(4, 'Hello', 'hello@asd.hu', '2134', 'sajt', 0),
(5, 'istike', 'isti@isti.hu', '1234523', 'sajt', 0),
(6, 'helloka', 'asdj@sajt.hu', '12354', '21e5ca51a2be2264ef4d41f5fd5eb325f9556f56', 0),
(7, 'sajtika', 'sajtika@saieif.hu', 'asdadqew', '21e5ca51a2be2264ef4d41f5fd5eb325f9556f56', 0),
(8, 'tibir', 'tibor@soterline.hu', 'Nem adott meg számot', '21e5ca51a2be2264ef4d41f5fd5eb325f9556f56', 0),
(9, 'szilard', 'szilard@asd.hu', 'Nem adott meg számot', '21e5ca51a2be2264ef4d41f5fd5eb325f9556f56', 0),
(10, 'szilárd', 'szi@szi.hu', 'Nem adott meg számot', '21e5ca51a2be2264ef4d41f5fd5eb325f9556f56', 0),
(11, 'gábor', 'gabor@gabor.hu', 'Nem adott meg számot', '21e5ca51a2be2264ef4d41f5fd5eb325f9556f56', 0),
(12, 'gabor', 'astf@lala.hu', 'Nem adott meg számot', 'a703740edbe06cf970816857e6dd79e196c23096', 0),
(13, 'sajti', 'sajti@sajf.hu', 'Nem adott meg számot', 'f10e2821bbbea527ea02200352313bc059445190', 0),
(14, 'sajtika', 'asdfe@asd.hu', 'Nem adott meg számot', '21e5ca51a2be2264ef4d41f5fd5eb325f9556f56', 0),
(15, 'isti', 'isti@ist.hu', 'Nem adott meg számot', '3362c30394dd952843b4b110b26e5e4b18bc3b38', 0),
(16, 'valaki', 'valaki10@valami.hu', 'Nem adott meg számot', 'd959f3c8ae2b91a357d442010414129cf466ad0d', 0),
(17, 'valamike1235', 'saht@okp.hu', 'Nem adott meg számot', '12aefb57032b932587e3c7624c7d7c39c3a16376', 0),
(18, 'vege', 'vege@asd.hu', 'Nem adott meg számot', '21e5ca51a2be2264ef4d41f5fd5eb325f9556f56', 0),
(19, 'Isti', 'isti@isti.hu', 'Nem adott meg számot', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 0);

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
  MODIFY `id` int(250) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
