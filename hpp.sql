-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 27, 2020 at 02:38 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hpp`
--

-- --------------------------------------------------------

--
-- Table structure for table `bahan_baku`
--

CREATE TABLE `bahan_baku` (
  `id_bb` varchar(15) NOT NULL,
  `nama_bb` varchar(30) NOT NULL,
  `stok` int(10) NOT NULL,
  `satuan` varchar(15) NOT NULL,
  `harga_satuan` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bahan_baku`
--

INSERT INTO `bahan_baku` (`id_bb`, `nama_bb`, `stok`, `satuan`, `harga_satuan`) VALUES
('BB0001', 'Gula', 10, 'KG', 12000),
('BB0002', 'Tepung', 20, 'KG', 10000);

-- --------------------------------------------------------

--
-- Table structure for table `detail_bahanbaku`
--

CREATE TABLE `detail_bahanbaku` (
  `id_detailbb` varchar(15) NOT NULL,
  `id_bb` varchar(15) NOT NULL,
  `nama_bb` varchar(30) NOT NULL,
  `satuan` varchar(15) NOT NULL,
  `jml_pemakaian` int(15) NOT NULL,
  `harga_satuan` int(15) NOT NULL,
  `subtotal_bb` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `detail_overhead`
--

CREATE TABLE `detail_overhead` (
  `id_detailoverhead` varchar(15) NOT NULL,
  `id_overhead` varchar(15) NOT NULL,
  `nama_overhead` varchar(40) NOT NULL,
  `satuan` varchar(20) NOT NULL,
  `jml_overhead` int(20) NOT NULL,
  `biaya_satuan` int(20) NOT NULL,
  `subtotal_overhead` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `detail_tenagakerja`
--

CREATE TABLE `detail_tenagakerja` (
  `id_detailpekerja` varchar(15) NOT NULL,
  `id_pekerjaan` varchar(15) NOT NULL,
  `nama_pekerjaan` varchar(30) NOT NULL,
  `satuan` varchar(20) NOT NULL,
  `biaya_pekerja` int(20) NOT NULL,
  `subtotal_pekerja` int(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `harga_jual`
--

CREATE TABLE `harga_jual` (
  `id_hargajual` varchar(15) NOT NULL,
  `tanggal` date NOT NULL,
  `id_hpp` varchar(15) NOT NULL,
  `id_produk` varchar(15) NOT NULL,
  `nama_produk` varchar(40) NOT NULL,
  `jml_produksi` int(20) NOT NULL,
  `hpp` int(30) NOT NULL,
  `profit` int(10) NOT NULL,
  `harga_jual` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `hpp`
--

CREATE TABLE `hpp` (
  `id_hpp` varchar(15) NOT NULL,
  `id_produksi` varchar(15) NOT NULL,
  `tgl_produksi` date NOT NULL,
  `jml_produksi` int(20) NOT NULL,
  `nama_produk` varchar(40) NOT NULL,
  `subtotal_bb` int(15) NOT NULL,
  `subtotal_overhead` int(20) NOT NULL,
  `subtotal_pekerja` int(25) NOT NULL,
  `hpp` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id_user` varchar(15) NOT NULL,
  `username` varchar(40) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id_user`, `username`, `password`) VALUES
('U0001', 'trioktap', '1234'),
('U0002', 'evaaa', '2345');

-- --------------------------------------------------------

--
-- Table structure for table `overhead`
--

CREATE TABLE `overhead` (
  `id_overhead` varchar(15) NOT NULL,
  `nama_overhead` varchar(40) NOT NULL,
  `satuan` varchar(20) NOT NULL,
  `biaya_satuan` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `overhead`
--

INSERT INTO `overhead` (`id_overhead`, `nama_overhead`, `satuan`, `biaya_satuan`) VALUES
('O0001', 'Listrik', 'Watt', 110);

-- --------------------------------------------------------

--
-- Table structure for table `produk`
--

CREATE TABLE `produk` (
  `id_produk` varchar(15) NOT NULL,
  `nama_produk` varchar(40) NOT NULL,
  `id_bb` varchar(15) NOT NULL,
  `nama_bb` varchar(30) NOT NULL,
  `qty` int(10) NOT NULL,
  `satuan` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `produk`
--

INSERT INTO `produk` (`id_produk`, `nama_produk`, `id_bb`, `nama_bb`, `qty`, `satuan`) VALUES
('P0001', 'Cinnamon', '', '', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `produksi`
--

CREATE TABLE `produksi` (
  `id_produksi` varchar(15) NOT NULL,
  `tgl_produksi` date NOT NULL,
  `jml_produksi` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tenaga_kerja`
--

CREATE TABLE `tenaga_kerja` (
  `id_pekerjaan` varchar(15) NOT NULL,
  `nama_pekerjaan` varchar(30) NOT NULL,
  `satuan` varchar(20) NOT NULL,
  `biaya` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tenaga_kerja`
--

INSERT INTO `tenaga_kerja` (`id_pekerjaan`, `nama_pekerjaan`, `satuan`, `biaya`) VALUES
('P0001', 'Pemanggang', 'Hari', 150000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bahan_baku`
--
ALTER TABLE `bahan_baku`
  ADD PRIMARY KEY (`id_bb`);

--
-- Indexes for table `detail_bahanbaku`
--
ALTER TABLE `detail_bahanbaku`
  ADD PRIMARY KEY (`id_detailbb`);

--
-- Indexes for table `detail_overhead`
--
ALTER TABLE `detail_overhead`
  ADD PRIMARY KEY (`id_detailoverhead`);

--
-- Indexes for table `detail_tenagakerja`
--
ALTER TABLE `detail_tenagakerja`
  ADD PRIMARY KEY (`id_detailpekerja`);

--
-- Indexes for table `harga_jual`
--
ALTER TABLE `harga_jual`
  ADD PRIMARY KEY (`id_hargajual`);

--
-- Indexes for table `hpp`
--
ALTER TABLE `hpp`
  ADD PRIMARY KEY (`id_hpp`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id_user`);

--
-- Indexes for table `overhead`
--
ALTER TABLE `overhead`
  ADD PRIMARY KEY (`id_overhead`);

--
-- Indexes for table `produk`
--
ALTER TABLE `produk`
  ADD PRIMARY KEY (`id_produk`);

--
-- Indexes for table `produksi`
--
ALTER TABLE `produksi`
  ADD PRIMARY KEY (`id_produksi`);

--
-- Indexes for table `tenaga_kerja`
--
ALTER TABLE `tenaga_kerja`
  ADD PRIMARY KEY (`id_pekerjaan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
