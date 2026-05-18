CREATE DATABASE dbPosttestPemvis;
USE dbPosttestPemvis;

CREATE TABLE TabelTim (
    id INT AUTO_INCREMENT PRIMARY KEY,
    namaTim VARCHAR(100) NOT NULL,
    negara VARCHAR(100) NOT NULL,
    mesin VARCHAR(100) NOT NULL,
    chasis VARCHAR(100) NOT NULL
);
 
CREATE TABLE TabelPembalap (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    negara VARCHAR(100) NOT NULL,
    nomor VARCHAR(10) NOT NULL,
    idTim INT NOT NULL,
    CONSTRAINT fk_pembalap_tim
        FOREIGN KEY (idTim) REFERENCES TabelTim(id)
        ON DELETE RESTRICT
        ON UPDATE CASCADE
);

CREATE TABLE TabelRace (
    id INT AUTO_INCREMENT PRIMARY KEY,
    namaRace VARCHAR(100) NOT NULL,
    lokasi VARCHAR(100) NOT NULL,
    tanggal DATE NOT NULL,
    putaran VARCHAR(10) NOT NULL
);

CREATE TABLE TabelHasilRace (
    id INT AUTO_INCREMENT PRIMARY KEY,
    idRace INT NOT NULL,
    idPembalap INT NOT NULL,
    posisiFinish INT NOT NULL,
    gap VARCHAR(50),
    statusFinish VARCHAR(50),
    fastestLap BOOLEAN DEFAULT FALSE,
    poin INT DEFAULT 0,

    FOREIGN KEY (idRace) REFERENCES TabelRace(id)
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    FOREIGN KEY (idPembalap) REFERENCES TabelPembalap(id)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);