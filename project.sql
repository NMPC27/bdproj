CREATE TABLE Pessoa
(
    ID INT NOT NULL,
    nome VARCHAR(250) NOT NULL,
    dataNasc DATE CHECK(dataNasc>'1900-01-01') NOT NULL,
    cidadeNatal VARCHAR(250) NOT NULL,

    PRIMARY KEY (ID),
    UNIQUE (nome)
);

CREATE TABLE Categoria
(
    categoriaID INT NOT NULL,
    descricao VARCHAR(250) NOT NULL,

    PRIMARY KEY (categoriaID)
);

CREATE TABLE Ator
(
    atorID INT NOT NULL,
    equity_card BIT NOT NULL,
    bio VARCHAR(250) NOT NULL,

    PRIMARY KEY (atorID),
    FOREIGN KEY (atorID) REFERENCES Pessoa(ID)
);

CREATE TABLE Team_Member
(
    membroID INT NOT NULL,
    emprego VARCHAR(250) NOT NULL,

    PRIMARY KEY (membroID),
    FOREIGN KEY (membroID) REFERENCES Pessoa(ID)
);

CREATE TABLE IGAC
(
    classificacao INT CHECK(classificacao=3 OR classificacao=6
            OR classificacao=12 OR classificacao=14
            OR classificacao=16 OR classificacao=18) NOT NULL,
    descricao VARCHAR(100) NOT NULL,

    PRIMARY KEY(classificacao)
);

CREATE TABLE Media_Entry
(
    entry_ID INT NOT NULL,
    pontuacao REAL CHECK(pontuacao>=0 AND pontuacao<=10) NOT NULL,
    idioma VARCHAR(100) NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    sinopse VARCHAR(1000) NOT NULL,
    data_de_lancamento DATE CHECK(data_de_lancamento>'1888-01-01') NOT NULL,
    IGAC INT CHECK(classificacao=3 OR classificacao=6
            OR classificacao=12 OR classificacao=14
            OR classificacao=16 OR classificacao=18) NOT NULL,
    poster VARCHAR(1000) NOT NULL,

    PRIMARY KEY(entry_ID),
    FOREIGN KEY (IGAC) REFERENCES IGAC(classificacao)
);

CREATE TABLE Entry_Categoria
(
    categoriaID INT NOT NULL,
    entryID INT NOT NULL,

    FOREIGN KEY (categoriaID) REFERENCES Categoria(categoriaID),
    FOREIGN KEY (entryID) REFERENCES Media_Entry(entry_ID)
);

CREATE TABLE Entry_Ator
(
    atorID INT NOT NULL,
    entryID INT NOT NULL,

    FOREIGN KEY (atorID) REFERENCES Ator(atorID),
    FOREIGN KEY (entryID) REFERENCES Media_Entry(entry_ID)
);

CREATE TABLE Entry_Team
(
    membroID INT NOT NULL,
    entryID INT NOT NULL,

    FOREIGN KEY (membroID) REFERENCES Team_Member(membroID),
    FOREIGN KEY (entryID) REFERENCES Media_Entry(entry_ID)
);

CREATE TABLE Username
(
    username_ID INT NOT NULL,
    username VARCHAR(250) NOT NULL,
    user_password VARCHAR(25) NOT NULL,
    email VARCHAR(100) NOT NULL,
    data_nasc DATE CHECK(data_nasc>'1900-01-01') NOT NULL,
    genero VARCHAR(1) CHECK(genero='M' OR genero='F') NOT NULL,
    pais VARCHAR(100) NOT NULL,
    bio VARCHAR(250),

    PRIMARY KEY(username_ID),
    UNIQUE(username)
);

CREATE TABLE Watchlist
(
    watchlist_ID INT NOT NULL,
    username_ID INT,
    entry_ID INT NOT NULL,

    UNIQUE(watchlist_ID),
    PRIMARY KEY(watchlist_ID),
    FOREIGN KEY (username_ID) REFERENCES Username(username_ID) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE Critica
(
    critica_ID INT NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    texto VARCHAR(2000) NOT NULL,
    spoiler BIT NOT NULL,
    pontuacao REAL CHECK(pontuacao >=0 and pontuacao <=10) NOT NULL,
    entry_id INT,

    PRIMARY KEY(critica_ID),
    FOREIGN KEY (entry_id) REFERENCES Media_Entry(entry_ID) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE Interage_critica
(
    username_ID INT,
    critica_ID INT,
    num_up_votes INT CHECK(num_up_votes>=0) NOT NULL,
    num_down_votes INT CHECK(num_down_votes>=0) NOT NULL,

    FOREIGN KEY (username_ID) REFERENCES Username(username_ID) ON DELETE SET NULL ON UPDATE CASCADE,
    FOREIGN KEY (critica_ID) REFERENCES Critica(critica_ID) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE Filme
(
    entry_ID INT NOT NULL,
    duracao INT CHECK(duracao>=80) NOT NULL,

    PRIMARY KEY(entry_ID),
    FOREIGN KEY (entry_ID) REFERENCES Media_Entry(entry_ID)
);

CREATE TABLE Serie
(
    entry_ID INT NOT NULL,
    numTemporadas INT CHECK(numTemporadas>=1) NOT NULL,
    numEpisodios INT CHECK(numEpisodios>=1) NOT NULL,

    PRIMARY KEY(entry_ID),
    FOREIGN KEY (entry_ID) REFERENCES Media_Entry(entry_ID)
);