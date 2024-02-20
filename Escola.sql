-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Tempo de geração: 03/02/2023 às 01:31
-- Versão do servidor: 10.4.24-MariaDB
-- Versão do PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `Escola`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `Alunos`
--

CREATE TABLE `Alunos` (
  `IdAluno` int(11) NOT NULL,
  `Nome` varchar(255) DEFAULT NULL,
  `Usuario` varchar(255) DEFAULT NULL,
  `Senha` varchar(255) DEFAULT NULL,
  `DataNasc` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `Alunos`
--

INSERT INTO `Alunos` (`IdAluno`, `Nome`, `Usuario`, `Senha`, `DataNasc`) VALUES
(2, 'Daniel', 'Daniel', '12345', '2023-02-02 21:30:43'),
(3, 'Daniel', 'Daniel', '12345', '2023-02-02 21:30:49');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `Alunos`
--
ALTER TABLE `Alunos`
  ADD PRIMARY KEY (`IdAluno`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `Alunos`
--
ALTER TABLE `Alunos`
  MODIFY `IdAluno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
