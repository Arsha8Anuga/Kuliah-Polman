-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 27, 2024 at 01:48 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_sbd_kel_1`
--

-- --------------------------------------------------------

--
-- Table structure for table `t_admin`
--

CREATE TABLE `t_admin` (
  `nip` varchar(20) NOT NULL,
  `id_user` int(4) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `jurusan` char(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_admin`
--

INSERT INTO `t_admin` (`nip`, `id_user`, `nama`, `jurusan`) VALUES
('224443012', 1, 'Anugrah Muhammad Arafah', 'AE');

-- --------------------------------------------------------

--
-- Table structure for table `t_mahasiswa`
--

CREATE TABLE `t_mahasiswa` (
  `nim` char(9) NOT NULL,
  `id_user` int(4) DEFAULT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `kelas` char(4) DEFAULT NULL,
  `jurusan` char(2) DEFAULT NULL,
  `jumlah_sp` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_mahasiswa`
--

INSERT INTO `t_mahasiswa` (`nim`, `id_user`, `nama`, `kelas`, `jurusan`, `jumlah_sp`) VALUES
('224443048', 1, 'Anugrah Muhammad Arafah', 'C-13', 'AE', 0),
('224443049', 2, 'Azka Zulkahfi', 'C-13', 'AE', 0),
('224443050', 3, 'Bilal Rizky Akbar', 'C-13', 'AE', 0),
('224443051', 4, 'Danika Taqia Zahra', 'C-13', 'AE', 0),
('224443052', 5, 'Fathan Eka Wirabuana', 'C-13', 'AE', 0),
('224443053', 6, 'Fazel Muhammad Rizwan', 'C-13', 'AE', 0),
('224443054', 7, 'Gustian Adi Nurman', 'C-13', 'AE', 0),
('224443055', 8, 'Jahwara Ahmad Firmansyah', 'C-13', 'AE', 0),
('224443056', 9, 'Jaqckline Yesyuruniwati', 'C-13', 'AE', 0),
('224443057', 10, 'Marshall Noverta Giri', 'C-13', 'AE', 0),
('224443059', 11, 'Muhammad Rizal Ahyar Tazul Arifin', 'C-13', 'AE', 0),
('224443060', 12, 'Muhammad Farrel Krisnanegara', 'C-13', 'AE', 0),
('224443061', 13, 'Muhammad Miftah Rizqi', 'C-13', 'AE', 0),
('224443062', 14, 'Muhammad Pasya Pramudya', 'C-13', 'AE', 0),
('224443063', 15, 'Muhammad Rendy Breventa Bharm', 'C-13', 'AE', 0),
('224443064', 16, 'Mutia Saladina Daryono', 'C-13', 'AE', 0),
('224443065', 17, 'Prasetyo Dwi Mulyono', 'C-13', 'AE', 0),
('224443066', 18, 'Reynata Posya Rahdi', 'C-13', 'AE', 0),
('224443068', 19, 'Sakhra Yusriza Mawla', 'C-13', 'AE', 0),
('224443069', 20, 'Tetah', 'C-13', 'AE', 0),
('224443070', 21, 'Wahyu Budi Santosa', 'C-13', 'AE', 0);

-- --------------------------------------------------------

--
-- Table structure for table `t_notfikasi`
--

CREATE TABLE `t_notfikasi` (
  `id` int(11) NOT NULL,
  `id_user` int(4) DEFAULT NULL,
  `pesan` text DEFAULT NULL,
  `waktu_kirim` datetime DEFAULT NULL,
  `dibaca` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `t_role`
--

CREATE TABLE `t_role` (
  `id` int(11) NOT NULL,
  `role` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_role`
--

INSERT INTO `t_role` (`id`, `role`) VALUES
(1, 'admin'),
(2, 'mahasiswa'),
(3, 'staff');

-- --------------------------------------------------------

--
-- Table structure for table `t_surat_peringatan`
--

CREATE TABLE `t_surat_peringatan` (
  `kd_peringatan_depan` char(2) NOT NULL,
  `kd_peringatan_belakang` int(4) NOT NULL,
  `nim` char(9) DEFAULT NULL,
  `kode_etik` varchar(20) DEFAULT NULL,
  `laporan` text DEFAULT NULL,
  `jenis_peringatan` enum('tulis','lisan') DEFAULT NULL,
  `diterima` tinyint(1) DEFAULT NULL,
  `link_surat` text DEFAULT NULL,
  `waktu_peringatan` datetime DEFAULT NULL,
  `waktu_diterima` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Triggers `t_surat_peringatan`
--
DELIMITER $$
CREATE TRIGGER `surat_peringatan_masuk` AFTER INSERT ON `t_surat_peringatan` FOR EACH ROW BEGIN 

    INSERT INTO t_notfikasi (id_user, pesan, waktu_kirim, dibaca)
    SELECT id_user, NEW.laporan, NOW(), false
    FROM t_mahasiswa 
    WHERE t_mahasiswa.nim = NEW.nim;

    UPDATE t_mahasiswa
    SET jumlah_sp = jumlah_sp + CASE 
        WHEN LOWER(NEW.jenis_peringatan) = 'lisan' THEN 1
        ELSE 4
    END
    WHERE t_mahasiswa.nim = NEW.nim;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `t_user`
--

CREATE TABLE `t_user` (
  `id` int(11) NOT NULL,
  `id_role` int(4) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(20) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_user`
--

INSERT INTO `t_user` (`id`, `id_role`, `username`, `password`, `email`) VALUES
(1, 1, 'anugrah_muhammad_arafah', 'pass12023', 'anugrah_muhammad_arafah@polma-bandung.ac.id'),
(2, 2, 'azka_zulkahfi', 'pass22023', 'azka_zulkahfi@polma-bandung.ac.id'),
(3, 2, 'bilal_rizky_akbar', 'pass32023', 'bilal_rizky_akbar@polma-bandung.ac.id'),
(4, 2, 'danika_taqia_zahra', 'pass42023', 'danika_taqia_zahra@polma-bandung.ac.id'),
(5, 2, 'fathan_eka_wirabuana', 'pass52023', 'fathan_eka_wirabuana@polma-bandung.ac.id'),
(6, 2, 'fazel_muhammad_rizwan', 'pass62023', 'fazel_muhammad_rizwan@polma-bandung.ac.id'),
(7, 2, 'gustian_adi_nurman', 'pass72023', 'gustian_adi_nurman@polma-bandung.ac.id'),
(8, 2, 'jahwara_ahmad_firmansyah', 'pass82023', 'jahwara_ahmad_firmansyah@polma-bandung.ac.id'),
(9, 2, 'jaqckline_yesyuruniwati', 'pass92023', 'jaqckline_yesyuruniwati@polma-bandung.ac.id'),
(10, 2, 'marshall_noverta_giri', 'pass102023', 'marshall_noverta_giri@polma-bandung.ac.id'),
(11, 2, 'muhammad_rizal_ahyar_tazul_arifin', 'pass112023', 'muhammad_rizal_ahyar_tazul_arifin@polma-bandung.ac'),
(12, 2, 'muhammad_farrel_krisnanegara', 'pass122023', 'muhammad_farrel_krisnanegara@polma-bandung.ac.id'),
(13, 2, 'muhammad_miftah_rizqi', 'pass132023', 'muhammad_miftah_rizqi@polma-bandung.ac.id'),
(14, 2, 'muhammad_pasya_pramudya', 'pass142023', 'muhammad_pasya_pramudya@polma-bandung.ac.id'),
(15, 2, 'muhammad_rendy_breventa_bharm', 'pass152023', 'muhammad_rendy_breventa_bharm@polma-bandung.ac.id'),
(16, 2, 'mutia_saladina_daryono', 'pass162023', 'mutia_saladina_daryono@polma-bandung.ac.id'),
(17, 2, 'prasetyo_dwi_mulyono', 'pass172023', 'prasetyo_dwi_mulyono@polma-bandung.ac.id'),
(18, 2, 'reynata_posya_rahdi', 'pass182023', 'reynata_posya_rahdi@polma-bandung.ac.id'),
(19, 2, 'sakhra_yusriza_mawla', 'pass192023', 'sakhra_yusriza_mawla@polma-bandung.ac.id'),
(20, 2, 'tetah', 'pass202023', 'tetah@polma-bandung.ac.id'),
(21, 2, 'wahyu_budi_santosa', 'pass212023', 'wahyu_budi_santosa@polma-bandung.ac.id');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `t_admin`
--
ALTER TABLE `t_admin`
  ADD PRIMARY KEY (`nip`),
  ADD KEY `FK_ADMIN_MEMILIKI_ID_USER` (`id_user`);

--
-- Indexes for table `t_mahasiswa`
--
ALTER TABLE `t_mahasiswa`
  ADD PRIMARY KEY (`nim`),
  ADD KEY `FK_MAHASISWA_MEMILIKI_ID_USER` (`id_user`);

--
-- Indexes for table `t_notfikasi`
--
ALTER TABLE `t_notfikasi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_NOTIFIKASI_MEMILIKI_ID` (`id_user`);

--
-- Indexes for table `t_role`
--
ALTER TABLE `t_role`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `t_surat_peringatan`
--
ALTER TABLE `t_surat_peringatan`
  ADD PRIMARY KEY (`kd_peringatan_belakang`,`kd_peringatan_depan`),
  ADD KEY `FK_PERINGATAN_MEMILIKI_NIM` (`nim`);

--
-- Indexes for table `t_user`
--
ALTER TABLE `t_user`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_USER_MEMILIKI_ID_ROLE` (`id_role`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `t_notfikasi`
--
ALTER TABLE `t_notfikasi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `t_role`
--
ALTER TABLE `t_role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `t_surat_peringatan`
--
ALTER TABLE `t_surat_peringatan`
  MODIFY `kd_peringatan_belakang` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `t_user`
--
ALTER TABLE `t_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `t_admin`
--
ALTER TABLE `t_admin`
  ADD CONSTRAINT `FK_ADMIN_MEMILIKI_ID_USER` FOREIGN KEY (`id_user`) REFERENCES `t_user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `t_mahasiswa`
--
ALTER TABLE `t_mahasiswa`
  ADD CONSTRAINT `FK_MAHASISWA_MEMILIKI_ID_USER` FOREIGN KEY (`id_user`) REFERENCES `t_user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `t_notfikasi`
--
ALTER TABLE `t_notfikasi`
  ADD CONSTRAINT `FK_NOTIFIKASI_MEMILIKI_ID` FOREIGN KEY (`id_user`) REFERENCES `t_user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `t_surat_peringatan`
--
ALTER TABLE `t_surat_peringatan`
  ADD CONSTRAINT `FK_PERINGATAN_MEMILIKI_NIM` FOREIGN KEY (`nim`) REFERENCES `t_mahasiswa` (`nim`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `t_user`
--
ALTER TABLE `t_user`
  ADD CONSTRAINT `FK_USER_MEMILIKI_ID_ROLE` FOREIGN KEY (`id_role`) REFERENCES `t_role` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
