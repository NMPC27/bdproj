USE MovieDB;

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
    tb_categoriaID INT NOT NULL,
    descricao VARCHAR(250) NOT NULL,

    PRIMARY KEY (tb_categoriaID)
);

CREATE TABLE Ator
(
    tb_atorID INT NOT NULL,
    equity_card BIT NOT NULL,
    bio VARCHAR(5000) NOT NULL,

    PRIMARY KEY (tb_atorID),
    FOREIGN KEY (tb_atorID) REFERENCES Pessoa(ID)
);

CREATE TABLE Team_Member
(
    tb_membroID INT NOT NULL,
    emprego VARCHAR(250) NOT NULL,

    PRIMARY KEY (tb_membroID),
    FOREIGN KEY (tb_membroID) REFERENCES Pessoa(ID)
);

CREATE TABLE IGAC
(
    classificacao INT CHECK(classificacao=3 OR classificacao=6
            OR classificacao=12 OR classificacao=14
            OR classificacao=16 OR classificacao=18) NOT NULL,
    descricao_igac VARCHAR(100) NOT NULL,

    PRIMARY KEY(classificacao)
);

CREATE TABLE Media_Entry
(
    entry_ID INT NOT NULL,
    pontuacao REAL CHECK(pontuacao>=0 AND pontuacao<=10) NOT NULL,
    idioma VARCHAR(100) NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    sinopse VARCHAR(5000) NOT NULL,
    data_de_lancamento DATE CHECK(data_de_lancamento>'1888-01-01') NOT NULL,
    IGAC INT CHECK(IGAC=3 OR IGAC=6
            OR IGAC=12 OR IGAC=14
            OR IGAC=16 OR IGAC=18) NOT NULL,
    poster VARCHAR(1000) NOT NULL,

    PRIMARY KEY(entry_ID),
    FOREIGN KEY (IGAC) REFERENCES IGAC(classificacao)
);

CREATE TABLE Entry_Categoria
(
    categoriaID INT NOT NULL,
    entryID_tb_categoria INT NOT NULL,

    FOREIGN KEY (categoriaID) REFERENCES Categoria(tb_categoriaID),
    FOREIGN KEY (entryID_tb_categoria) REFERENCES Media_Entry(entry_ID)
);

CREATE TABLE Entry_Ator
(
    atorID INT NOT NULL,
    entryID_tb_ator INT NOT NULL,

    FOREIGN KEY (atorID) REFERENCES Ator(tb_atorID),
    FOREIGN KEY (entryID_tb_ator) REFERENCES Media_Entry(entry_ID)
);

CREATE TABLE Entry_Team
(
    membroID INT NOT NULL,
    entryID_tb_team INT NOT NULL,

    FOREIGN KEY (membroID) REFERENCES Team_Member(tb_membroID),
    FOREIGN KEY (entryID_tb_team) REFERENCES Media_Entry(entry_ID)
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
    bio VARCHAR(5000),

    PRIMARY KEY(username_ID),
    UNIQUE(username)
);

CREATE TABLE Watchlist
(
    watchlist_ID INT NOT NULL,
    username_ID_tb_watchlist INT,
    entry_ID_tb_watchlist INT NOT NULL,

    UNIQUE(watchlist_ID),
    PRIMARY KEY(watchlist_ID),
	FOREIGN KEY (entry_ID_tb_watchlist) REFERENCES Media_Entry(entry_ID),
    FOREIGN KEY (username_ID_tb_watchlist) REFERENCES Username(username_ID) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE Critica
(
    critica_ID INT NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    texto VARCHAR(5000) NOT NULL,
    spoiler BIT NOT NULL,
    pontuacao REAL CHECK(pontuacao >=0 and pontuacao <=10) NOT NULL,
    entry_id_tb_critica INT,
    autor INT NOT NULL,

    PRIMARY KEY(critica_ID),
    FOREIGN KEY (entry_id_tb_critica) REFERENCES Media_Entry(entry_ID) ON DELETE SET NULL ON UPDATE CASCADE,
    FOREIGN KEY (autor) REFERENCES Username(username_ID)
);

CREATE TABLE Interage_critica
(
    username_ID_tb_interage INT,
    critica_ID_tb_interage INT,
    num_up_votes INT NOT NULL,
    num_down_votes INT NOT NULL,

    FOREIGN KEY (username_ID_tb_interage) REFERENCES Username(username_ID) ON DELETE SET NULL ON UPDATE CASCADE,
    FOREIGN KEY (critica_ID_tb_interage) REFERENCES Critica(critica_ID) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE Filme
(
    entry_ID_tb_filme INT NOT NULL,
    duracao INT CHECK(duracao>=80) NOT NULL,

    PRIMARY KEY(entry_ID_tb_filme),
    FOREIGN KEY (entry_ID_tb_filme) REFERENCES Media_Entry(entry_ID)
);

CREATE TABLE Serie
(
    entry_ID_tb_serie INT NOT NULL,
    numTemporadas INT CHECK(numTemporadas>=1) NOT NULL,
    numEpisodios INT CHECK(numEpisodios>=1) NOT NULL,

    PRIMARY KEY(entry_ID_tb_serie),
    FOREIGN KEY (entry_ID_tb_serie) REFERENCES Media_Entry(entry_ID)
);