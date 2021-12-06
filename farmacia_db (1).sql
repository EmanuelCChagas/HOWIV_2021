-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 06-Dez-2021 às 01:18
-- Versão do servidor: 10.4.19-MariaDB
-- versão do PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `farmacia_db`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `cliente_id` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Idade` int(2) NOT NULL,
  `Telefone` varchar(13) NOT NULL,
  `Endereço` varchar(100) NOT NULL,
  `CPF` bigint(11) NOT NULL,
  `Data_Criação_Usuario` date NOT NULL DEFAULT current_timestamp(),
  `ativo_cliente` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`cliente_id`, `Nome`, `Email`, `Idade`, `Telefone`, `Endereço`, `CPF`, `Data_Criação_Usuario`, `ativo_cliente`) VALUES
(1, 'Lucas Silveira', 'Lucas_Silveira@gmail.com', 22, '47 99193-9787', 'Rua Jose Juvenal Mafra 232', 7416244578, '2021-11-05', 1),
(2, 'Arnaldo Da Silva', 'Arnaldo.Silva1@gmail.com', 42, '47 99598-7778', 'Rua Salvador da Luz N 53', 8575741425, '2021-11-05', 1),
(3, 'Silvio Machado', 'Silvio1Machado@outlook.com', 48, '47 99784-7754', 'Rua Francisco Couto Prestes', 17515142394, '2021-11-05', 1),
(4, 'Teste06', 'Teste@testado.com', 50, '47 95151-7845', 'Rua Gilberto Vieira N°50', 8786850405, '2021-11-06', 1),
(5, 'Teste06', 'TesteEmail2@gmail.com', 20, '47 96345-4848', 'Rua Boboalegre N°532', 78945678574, '2021-11-07', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `produtos_id` int(11) NOT NULL,
  `Nome_produtos` varchar(100) NOT NULL,
  `Codigo_De_Barras` bigint(13) UNSIGNED NOT NULL,
  `Data_Criação_Produtos` date NOT NULL DEFAULT current_timestamp(),
  `ativo_produtos` tinyint(1) DEFAULT 1,
  `Preço_Produtos` decimal(7,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`produtos_id`, `Nome_produtos`, `Codigo_De_Barras`, `Data_Criação_Produtos`, `ativo_produtos`, `Preço_Produtos`) VALUES
(1, 'Remedio 4', 2147483647, '2021-11-07', 0, '0.00'),
(4, 'Remedio 1 ', 7895545405005, '2021-11-14', 0, '49.99'),
(5, 'Remedio 2', 7879907999790, '2021-11-14', 1, '19.99'),
(6, 'Remedio 3', 5546677337722, '2021-11-14', 1, '29.99');

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendas`
--

CREATE TABLE `vendas` (
  `venda_id` int(11) NOT NULL,
  `venda_data` timestamp NOT NULL DEFAULT current_timestamp(),
  `Valor_total` decimal(7,2) NOT NULL,
  `Pagamento_Forma` varchar(8) NOT NULL,
  `cliente_venda_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `vendas`
--

INSERT INTO `vendas` (`venda_id`, `venda_data`, `Valor_total`, `Pagamento_Forma`, `cliente_venda_id`) VALUES
(28, '2021-12-04 06:07:35', '19.99', 'cartão', 2),
(33, '2021-12-05 19:34:04', '89.97', 'Dinheiro', 2),
(35, '2021-12-05 19:36:02', '509.83', 'Dinheiro', 5),
(38, '2021-12-05 19:44:56', '19.99', 'Dinheiro', 2),
(39, '2021-12-05 21:02:11', '289.87', 'Dinheiro', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendas_info`
--

CREATE TABLE `vendas_info` (
  `venda_info_id` int(11) NOT NULL,
  `produtos_venda_info_id` int(11) DEFAULT NULL,
  `cliente_venda_info_id` int(11) DEFAULT NULL,
  `venda_total_id` int(11) DEFAULT NULL,
  `valor_unit` decimal(7,2) NOT NULL,
  `quantidade` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `vendas_info`
--

INSERT INTO `vendas_info` (`venda_info_id`, `produtos_venda_info_id`, `cliente_venda_info_id`, `venda_total_id`, `valor_unit`, `quantidade`) VALUES
(1, 5, 2, 28, '19.00', 1),
(8, 6, 2, 33, '29.00', 3),
(10, 6, 5, 35, '29.00', 17),
(13, 5, 2, 38, '19.00', 1),
(14, 6, 2, 39, '29.00', 3),
(15, 5, 2, 39, '19.00', 10);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`cliente_id`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD UNIQUE KEY `Telefone` (`Telefone`),
  ADD UNIQUE KEY `CPF` (`CPF`);

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`produtos_id`),
  ADD UNIQUE KEY `Codigo_De_Barras` (`Codigo_De_Barras`);

--
-- Índices para tabela `vendas`
--
ALTER TABLE `vendas`
  ADD PRIMARY KEY (`venda_id`),
  ADD KEY `cliente_venda_id` (`cliente_venda_id`);

--
-- Índices para tabela `vendas_info`
--
ALTER TABLE `vendas_info`
  ADD PRIMARY KEY (`venda_info_id`),
  ADD KEY `venda_total_id` (`venda_total_id`),
  ADD KEY `produtos_venda_info_id` (`produtos_venda_info_id`),
  ADD KEY `cliente_venda_info_id` (`cliente_venda_info_id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `cliente_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `produtos_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `vendas`
--
ALTER TABLE `vendas`
  MODIFY `venda_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT de tabela `vendas_info`
--
ALTER TABLE `vendas_info`
  MODIFY `venda_info_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `vendas`
--
ALTER TABLE `vendas`
  ADD CONSTRAINT `vendas_ibfk_1` FOREIGN KEY (`cliente_venda_id`) REFERENCES `clientes` (`cliente_id`);

--
-- Limitadores para a tabela `vendas_info`
--
ALTER TABLE `vendas_info`
  ADD CONSTRAINT `vendas_info_ibfk_1` FOREIGN KEY (`venda_total_id`) REFERENCES `vendas` (`venda_id`),
  ADD CONSTRAINT `vendas_info_ibfk_2` FOREIGN KEY (`produtos_venda_info_id`) REFERENCES `produtos` (`produtos_id`),
  ADD CONSTRAINT `vendas_info_ibfk_3` FOREIGN KEY (`cliente_venda_info_id`) REFERENCES `clientes` (`cliente_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
