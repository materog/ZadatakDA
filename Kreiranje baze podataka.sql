CREATE TABLE Korisnici (
  KorisnikID INT IDENTITY(1,1) PRIMARY KEY,
  KorisnickoIme VARCHAR(50),
  Lozinka VARCHAR(50),
  Uloga INT,
  Potvrda BIT
);

CREATE TABLE Profesori (
  ProfesorID INT IDENTITY(1,1) PRIMARY KEY,
  KorisnikID INT,
  Ime VARCHAR(50),
  Prezime VARCHAR(50),
  FOREIGN KEY (ProfesorID) REFERENCES Korisnici (KorisnikID)
);

CREATE TABLE Studenti (
  StudentID INT IDENTITY(1,1) PRIMARY KEY,
  KorisnikID INT,
  Ime VARCHAR(50),
  Prezime VARCHAR(50),
  TipStudija INT,
  FOREIGN KEY (KorisnikID) REFERENCES Korisnici (KorisnikID)
);

CREATE TABLE Teme (
  TemaID INT IDENTITY(1,1) PRIMARY KEY,
  ProfesorID INT,
  StudentID INT,
  Dostupnost BIT,
  NazivTeme VARCHAR(100),
  KratkiOpis VARCHAR(500),
  Studij INT,
  FOREIGN KEY (ProfesorID) REFERENCES Profesori (ProfesorID),
  FOREIGN KEY (StudentID) REFERENCES Studenti (StudentID)
);

CREATE TABLE Prijave (
  PrijavaID INT IDENTITY(1,1) PRIMARY KEY,
  TemaID INT,
  StudentID INT,
  Prihvaceno BIT,
  FOREIGN KEY (TemaID) REFERENCES Teme (TemaID),
  FOREIGN KEY (StudentID) REFERENCES Studenti (StudentID)
);

INSERT INTO Korisnici (KorisnickoIme, Lozinka, Uloga, Potvrda)
VALUES ('admin', 'admin', 1, 1);