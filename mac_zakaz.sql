-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Июн 23 2020 г., 06:23
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `mac_zakaz`
--

-- --------------------------------------------------------

--
-- Структура таблицы `burger`
--

CREATE TABLE IF NOT EXISTS `burger` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=11 ;

--
-- Дамп данных таблицы `burger`
--

INSERT INTO `burger` (`id`, `name`) VALUES
(1, 'Двойной Биг Тейсти'),
(2, 'Тройной чизбургер'),
(3, 'Биг Тейсти Джуниор'),
(4, 'Двойной Биг Мак'),
(5, 'Биг Мак'),
(6, 'Биг Тейсти'),
(7, 'Роял Де Люкс'),
(8, 'Двойной Роял'),
(9, 'Роял'),
(10, 'Двойной чизбургер');

-- --------------------------------------------------------

--
-- Структура таблицы `desert`
--

CREATE TABLE IF NOT EXISTS `desert` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Дамп данных таблицы `desert`
--

INSERT INTO `desert` (`id`, `name`) VALUES
(1, 'Донаты'),
(2, 'Пирожок'),
(3, 'Чизкейк'),
(4, 'Мусс'),
(5, 'Мороженое');

-- --------------------------------------------------------

--
-- Структура таблицы `free_potato`
--

CREATE TABLE IF NOT EXISTS `free_potato` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Дамп данных таблицы `free_potato`
--

INSERT INTO `free_potato` (`id`, `name`) VALUES
(1, 'Фри маленькая'),
(2, 'Фри средняя'),
(3, 'Фри большая'),
(4, 'По-деревенски маленькая'),
(5, 'По-деревенски средняя'),
(6, 'По-деревенски большая');

-- --------------------------------------------------------

--
-- Структура таблицы `myaso`
--

CREATE TABLE IF NOT EXISTS `myaso` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Дамп данных таблицы `myaso`
--

INSERT INTO `myaso` (`id`, `name`) VALUES
(1, 'Чикен Макнаггетс'),
(2, 'Куриные крылышки'),
(3, 'Наггетс бокс'),
(4, 'Креветки'),
(5, 'Куриные ножки');

-- --------------------------------------------------------

--
-- Структура таблицы `napitok`
--

CREATE TABLE IF NOT EXISTS `napitok` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=11 ;

--
-- Дамп данных таблицы `napitok`
--

INSERT INTO `napitok` (`id`, `name`) VALUES
(1, 'Чай в ассортименте'),
(2, 'Эспрессо'),
(3, 'Латте'),
(4, 'Капучино'),
(5, 'Пепси/Спрайт/Фанта 0,2'),
(6, 'Пепси/Спрайт/Фанта 0,5'),
(7, 'Пепси/Спрайт/Фанта 1л'),
(8, 'Коктейли в ассортименте'),
(9, 'Холодный чай'),
(10, 'Натуральные соки в ассорт.');

-- --------------------------------------------------------

--
-- Структура таблицы `soyses`
--

CREATE TABLE IF NOT EXISTS `soyses` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=11 ;

--
-- Дамп данных таблицы `soyses`
--

INSERT INTO `soyses` (`id`, `name`) VALUES
(1, 'Кетчуп'),
(2, 'Сырный'),
(3, 'Кисло-сладкий'),
(4, 'Чесночный'),
(5, '1000 островов'),
(6, 'Чили'),
(7, 'Терияки'),
(8, 'Барбекю'),
(9, 'Горчичный'),
(10, 'Майонез');

-- --------------------------------------------------------

--
-- Структура таблицы `zakaz`
--

CREATE TABLE IF NOT EXISTS `zakaz` (
  `id_zakaza` int(10) NOT NULL AUTO_INCREMENT,
  `burger` varchar(30) NOT NULL,
  `free_potato` varchar(30) NOT NULL,
  `myaso` varchar(30) NOT NULL,
  `soyses` varchar(30) NOT NULL,
  `desert` varchar(30) NOT NULL,
  `napitok` varchar(30) NOT NULL,
  PRIMARY KEY (`id_zakaza`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
