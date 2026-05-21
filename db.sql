CREATE DATABASE dbPosttestPemvis;
USE dbPosttestPemvis;

CREATE TABLE TabelTim (
    id INT AUTO_INCREMENT PRIMARY KEY,
    namaTim VARCHAR(100) NOT NULL,
    negara VARCHAR(100) NOT NULL,
    mesin VARCHAR(100) NOT NULL,
    chasis VARCHAR(100) NOT NULL,
    logo VARCHAR(255) NULL
);


CREATE TABLE TabelPembalap (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    negara VARCHAR(100) NOT NULL,
    nomor INT NOT NULL,
    foto VARCHAR(255) NULL,
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
    putaran INT NOT NULL
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

INSERT INTO TabelTim
(namaTim, negara, mesin, chasis, logo)
VALUES
('Ferrari', 'Italia', 'Ferrari', 'SF-25', 'images/Ferrari.png'),
('Mercedes AMG', 'Jerman', 'Mercedes', 'W16', 'images/MercedesAMG.png'),
('McLaren', 'Inggris', 'Mercedes', 'MCL39', 'images/Mclaren.png');

INSERT INTO TabelPembalap
(nama, negara, nomor, foto, idTim)
VALUES
('Charles Leclerc', 'Monako', 16, 'images/Leclerc.jpg', 1),
('Lewis Hamilton', 'Inggris', 44, 'images/Hamilton.jpg', 2),
('Andrea Kimi Antonelli', 'Italia', 12, 'images/Antonelli.jpg', 2),
('George Russell', 'Inggris', 63, 'images/Russell.jpg', 2),
('Lando Norris', 'Inggris', 4, 'images/Norris.jpg', 3),
('Oscar Piastri', 'Australia', 81, 'images/Piastri.jpg', 3);

INSERT INTO TabelRace
(namaRace, lokasi, tanggal, putaran)
VALUES
('Australian GP', 'Melbourne', '2025-03-16', 58),
('Japanese GP', 'Suzuka', '2025-04-06', 53),
('Miami GP', 'Miami', '2025-05-04', 57);

INSERT INTO TabelHasilRace
(idRace, idPembalap, posisiFinish, gap, statusFinish, fastestLap, poin)
VALUES
(1, 5, 1, '+0.000', 'Finished', TRUE, 26),
(1, 6, 2, '+2.112', 'Finished', FALSE, 18),
(1, 1, 3, '+5.330', 'Finished', FALSE, 15),
(1, 4, 4, '+9.876', 'Finished', FALSE, 12),
(1, 2, 5, '+13.445', 'Finished', FALSE, 10),
(1, 3, 6, '+18.002', 'Finished', FALSE, 8);

INSERT INTO TabelHasilRace
(idRace, idPembalap, posisiFinish, gap, statusFinish, fastestLap, poin)
VALUES
(2, 1, 1, '+0.000', 'Finished', TRUE, 26),
(2, 5, 2, '+3.221', 'Finished', FALSE, 18),
(2, 4, 3, '+7.880', 'Finished', FALSE, 15),
(2, 6, 4, '+11.230', 'Finished', FALSE, 12),
(2, 2, 5, '+16.450', 'Finished', FALSE, 10),
(2, 3, 6, '+20.551', 'Finished', FALSE, 8);

INSERT INTO TabelHasilRace
(idRace, idPembalap, posisiFinish, gap, statusFinish, fastestLap, poin)
VALUES
(3, 4, 1, '+0.000', 'Finished', TRUE, 26),
(3, 1, 2, '+1.998', 'Finished', FALSE, 18),
(3, 5, 3, '+6.450', 'Finished', FALSE, 15),
(3, 6, 4, '+10.221', 'Finished', FALSE, 12),
(3, 2, 5, '+14.678', 'Finished', FALSE, 10),
(3, 3, 6, '+19.330', 'Finished', FALSE, 8);