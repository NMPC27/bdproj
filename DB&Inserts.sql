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
    username_ID INT IDENTITY(1, 1),
    username VARCHAR(250) NOT NULL,
    user_password BINARY(40) NOT NULL,
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
    watchlist_ID INT IDENTITY(1, 1),
    username_ID_tb_watchlist INT,
    entry_ID_tb_watchlist INT NOT NULL,

    UNIQUE(watchlist_ID),
    PRIMARY KEY(watchlist_ID),
	FOREIGN KEY (entry_ID_tb_watchlist) REFERENCES Media_Entry(entry_ID),
    FOREIGN KEY (username_ID_tb_watchlist) REFERENCES Username(username_ID) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE Critica
(
    critica_ID INT IDENTITY(1, 1),
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

------------------------------------------
------------------------------------------
------------------------------------------

USE MovieDB;

INSERT INTO Pessoa
VALUES
    (
        1,
        'Tim Robbins',
        '1958-10-16',
        'West Covina, California, USA'
);

INSERT INTO Pessoa
VALUES
    (
        2,
        'Morgan Freeman',
        '1937-06-01',
        'Memphis, Tennessee, USA'
);

INSERT INTO Pessoa
VALUES
    (
        3,
        'Bob Gunton',
        '1945-11-15',
        'Santa Monica, California, USA'
);

INSERT INTO Pessoa
VALUES
    (
        4,
        'William Sadler',
        '1950-04-13',
        'Buffalo, New York, USA'
);

INSERT INTO Pessoa
VALUES
    (
        5,
        'Frank Darabont',
        '1959-01-28',
        'Montbéliard, Doubs, France'
);

INSERT INTO Pessoa
VALUES
    (
        6,
        'Stephen King',
        '1947-09-21',
        'Portland, Maine, USA'
);

INSERT INTO Pessoa
VALUES
    (
        7,
        'Elijah Wood',
        '1981-01-28',
        'Cedar Rapids, Iowa, USA'
);

------------------------------------------

INSERT INTO Categoria
VALUES
    (
        1,
        'Drama'
);

INSERT INTO Categoria
VALUES
    (
        2,
        'Policial'
);

INSERT INTO Categoria
VALUES
    (
        3,
        'Acção'
);

INSERT INTO Categoria
VALUES
    (
        4,
        'Biografia'
);

INSERT INTO Categoria
VALUES
    (
        5,
        'História'
);

INSERT INTO Categoria
VALUES
    (
        6,
        'Aventura'
);

INSERT INTO Categoria
VALUES
    (
        7,
        'Faroeste'
);

INSERT INTO Categoria
VALUES
    (
        8,
        'Suspence'
);

---------------------------------


INSERT INTO Ator
VALUES
    (
        1,
        1,
        'Born in West Covina, California, but raised in New York City, Tim Robbins is the son of former The Highwaymen singer Gil Robbins and actress Mary Robbins (née Bledsoe). Robbins studied drama at UCLA, where he graduated with honors in 1981. That same year, he formed the Actors Gang theater group, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater. He started film work in television movies in 1983, but hit the big time in 1988 with his portrayal of dimwitted fastball pitcher Nuke Laloosh in Sorte no Amor (1988). Tall with baby-faced looks, he has the ability to play naive and obtuse (Um Conquistador em Apuros (1990) and Na Roda da Fortuna (1994)) or slick and shrewd (O Jogador (1992) and Bob Roberts (1992)).'
);

INSERT INTO Ator
VALUES
    (
        2,
        1,
        'With an authoritative voice and calm demeanor, this ever popular American actor has grown into one of the most respected figures in modern US cinema. Morgan was born on June 1, 1937 in Memphis, Tennessee, to Mayme Edna (Revere), a teacher, and Morgan Porterfield Freeman, a barber. The young Freeman attended Los Angeles City College before serving several years in the US Air Force as a mechanic between 1955 and 1959. His first dramatic arts exposure was on the stage including appearing in an all-African American production of the exuberant musical Hello, Dolly!.'
);

INSERT INTO Ator
VALUES
    (
        3,
        1,
        'Bob Gunton is an American actor, primarily known for portraying strict and authoritarian characters in popular films. His better known roles include Chief George Earle in Demolition Man (1993), Prison Warden Samuel Norton in The Shawshank Redemption (1994), medical school dean Dr. Walcott in Patch Adams (1998), and politician Cyrus Vance in Argo (2012).'
);

INSERT INTO Ator
VALUES
    (
        4,
        0,
        'William Thomas Sadler was born on April 13, 1950 in Buffalo, New York, to Jane and William Sadler. He began his acting career in New York theaters, appearing in more than 75 productions over the course of 12 years. His roles included that of Sgt. Merwin J. Toomey in Neil Simons Tony Award winning play Biloxi Blues. He is best remembered for his roles in Duro de Matar 2 (1990), Bill & Ted: Dois Loucos no Tempo (1991), Um Sonho de Liberdade (1994) and Os Demônios da Noite (1995). He is also a television star, appearing in such sitcoms as Roseanne (1988) and Murphy Brown (1988) and such movies-of-the weeks as Charlie and the Great Balloon Chase (1981). Sadler also starred as Sheriff Jim Valenti on the WB science fiction television series Arquivo Roswell (1999).'
);

INSERT INTO Ator
VALUES
    (
        7,
        1,
        'Elijah Wood is an American actor best known for portraying Frodo Baggins in Peter Jacksons blockbuster Lord of the Rings film trilogy. In addition to reprising the role in The Hobbit series, Wood also played Ryan in the FX television comedy Wilfred (2011) and voiced Beck in the Disney XD animated television series Tron: A Resistência (2012). Born Elijah Jordan Wood on 28 January, 1981, in Cedar Rapids, Iowa, Wood is the son of Debbie (Krause) and Warren Wood, who ran a delicatessen. He has an older brother, Zach, and a younger sister, Hannah Wood. He is of English, German, Austrian, and Danish descent. Demonstrating a gift for performing at a young age, Woods natural talent inspired his mother to take him to an International Modeling and Talent Association annual convention in Los Angeles. Soon after, he began to get bookings for small parts on television.'
);

------------------------------------

INSERT INTO Team_Member
VALUES
    (
        5,
        'Director'
);

INSERT INTO Team_Member
VALUES
    (
        6,
        'Writer'
);

----------

INSERT INTO IGAC
VALUES
    (
        18,
        'Proibida a entrada de menores de 18 anos'
);

INSERT INTO IGAC
VALUES
    (
        16,
        'Não recomendado para menores de 16 anos'
);

INSERT INTO IGAC
VALUES
    (
        14,
        'Não recomendado para menores de 14 anos'
);

INSERT INTO IGAC
VALUES
    (
        12,
        'Não recomendado para menores de 12 anos'
);

INSERT INTO IGAC
VALUES
    (
        6,
        'Não recomendado para menores de 6 anos, Deve ser acompanhado pelo responsável legal'
);

INSERT INTO IGAC
VALUES
    (
        3,
        'Livre para todas as idades'
);

------------------------------------------

--1
INSERT INTO Media_Entry
VALUES
    (
        0111161,
        9.3,
        'English',
        'The Shawshank Redemption',
        'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.',
        '1994-10-14',
        16,
        'https://br.web.img2.acsta.net/medias/nmedia/18/90/16/48/20083748.jpg'
);

--2
INSERT INTO Media_Entry
VALUES
    (
        0068646,
        9.2,
        'English',
        'The Godfather',
        'The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.',
        '1972-03-24',
        14,
        'https://br.web.img3.acsta.net/medias/nmedia/18/90/93/20/20120876.jpg'
);

--3
INSERT INTO Media_Entry
VALUES
    (
        0468569,
        9.0,
        'English',
        'The Dark Knight',
        'When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.',
        '2008-07-18',
        12,
        'https://upload.wikimedia.org/wikipedia/pt/d/d1/The_Dark_Knight.jpg'
);

--4
INSERT INTO Media_Entry
VALUES
    (
        0071562,
        9.0,
        'English',
        'The Godfather: Part II',
        'The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.',
        '1974-12-18',
        14,
        'https://br.web.img3.acsta.net/medias/nmedia/18/90/93/27/20120933.jpg'
);

--5
INSERT INTO Media_Entry
VALUES
    (
        0050083,
        9.0,
        'English',
        '12 Angry Men',
        'The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.',
        '1957-04-10',
        3,
        'https://br.web.img3.acsta.net/medias/nmedia/18/94/89/49/20363466.jpg'
);

--6
INSERT INTO Media_Entry
VALUES
    (
        0108052,
        8.9,
        'English',
        'Schindlers List',
        'In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.',
        '1994-02-04',
        18,
        'https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg'
);

--7
INSERT INTO Media_Entry
VALUES
    (
        0167260,
        8.9,
        'English',
        'The Lord of the Rings: The Return of the King',
        'Gandalf and Aragorn lead the World of Men against Saurons army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.',
        '2003-12-17',
        12,
        'https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg'
);

--8
INSERT INTO Media_Entry
VALUES
    (
        0110912,
        8.9,
        'English',
        'Pulp Fiction',
        'The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.',
        '1994-10-14',
        18,
        'https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg'
);

INSERT INTO Media_Entry
VALUES
    (
        0120737,
        8.8,
        'English',
        'The Lord of the Rings: The Fellowship of the Ring',
        'A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.',
        '2001-12-19',
        12,
        'https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_SX300.jpg'
);

--9


-- 10
INSERT INTO Media_Entry
VALUES
    (
        0060196,
        8.8,
        'Italian',
        'The Good, the Bad and the Ugly',
        'A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.',
        '1967-12-29',
        18,
        'https://m.media-amazon.com/images/M/MV5BNjJlYmNkZGItM2NhYy00MjlmLTk5NmQtNjg1NmM2ODU4OTMwXkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_SX300.jpg'
);

-- serie 1
INSERT INTO Media_Entry
VALUES
    (
        0903747,
        9.5,
        'English',
        'Breaking Bad',
        'Um professor de química diagnosticado com câncer de pulmão se transforma em fabricante e vendedor de metanfetamina, a fim de garantir o futuro da sua família.',
        '2008-09-28',
        16,
        'https://br.web.img3.acsta.net/pictures/14/03/31/19/28/462555.jpg'
);


INSERT INTO Entry_Categoria
VALUES
    (
        7,
        0060196
);

INSERT INTO Entry_Categoria
VALUES
    (
        6,
        0060196
);


INSERT INTO Entry_Categoria
VALUES
    (
        3,
        0120737
);

INSERT INTO Entry_Categoria
VALUES
    (
        1,
        0120737
);

INSERT INTO Entry_Categoria
VALUES
    (
        6,
        0120737
);

INSERT INTO Entry_Categoria
VALUES
    (
        1,
        0110912
);

INSERT INTO Entry_Categoria
VALUES
    (
        2,
        0110912
);

INSERT INTO Entry_Categoria
VALUES
    (
        1,
        0167260
);

INSERT INTO Entry_Categoria
VALUES
    (
        6,
        0167260
);

INSERT INTO Entry_Categoria
VALUES
    (
        3,
        0167260
);

INSERT INTO Entry_Categoria
VALUES
    (
        1,
        0108052
);

INSERT INTO Entry_Categoria
VALUES
    (
        4,
        0108052
);

INSERT INTO Entry_Categoria
VALUES
    (
        5,
        0108052
);

INSERT INTO Entry_Categoria
VALUES
    (
        1,
        0050083
);

INSERT INTO Entry_Categoria
VALUES
    (
        2,
        0050083
);

INSERT INTO Entry_Categoria
VALUES
    (
        1,
        0071562
);

INSERT INTO Entry_Categoria
VALUES
    (
        2,
        0071562
);

INSERT INTO Entry_Categoria
VALUES
    (
        1,
        0468569
);

INSERT INTO Entry_Categoria
VALUES
    (
        2,
        0468569
);

INSERT INTO Entry_Categoria
VALUES
    (
        3,
        0468569
);

INSERT INTO Entry_Categoria
VALUES
    (
        1,
        0068646
);

INSERT INTO Entry_Categoria
VALUES
    (
        2,
        0068646
);

INSERT INTO Entry_Categoria
VALUES
    (
        1,
        0111161
);


INSERT INTO Entry_Categoria
VALUES
    (
        1,
        0903747
);


INSERT INTO Entry_Categoria
VALUES
    (
        2,
        0903747
);

INSERT INTO Entry_Categoria
VALUES
    (
        8,
        0903747
);


-------------------------------------


INSERT INTO Entry_Ator
VALUES
    (
        1,
        0111161
);

INSERT INTO Entry_Ator
VALUES
    (
        2,
        0111161
);

INSERT INTO Entry_Ator
VALUES
    (
        3,
        0111161
);

INSERT INTO Entry_Ator
VALUES
    (
        4,
        0111161
);

INSERT INTO Entry_Ator
VALUES
    (
        7,
        0120737
);

INSERT INTO Entry_Ator
VALUES
    (
        7,
        0167260
);

----------------------



INSERT INTO Entry_Team
VALUES
    (
        5,
        0111161
);

INSERT INTO Entry_Team
VALUES
    (
        6,
        0111161
);


-----------------------------

INSERT INTO Username
VALUES
    (
        'nuno',
        0xEF797C8118F02DFB649607DD5D3F8C7623048C9C063D532CC95C5ED7A898A64F,
        'nuno@gmail.com',
        '2001-09-27',
        'M',
        'Portugal',
        'Ola o meu nome é Nuno, eu sou um português, e gosto de ver filmes.'
);

INSERT INTO Username
VALUES
    (
        'filipe',
        0xEF797C8118F02DFB649607DD5D3F8C7623048C9C063D532CC95C5ED7A898A64F,
        'filipe@gmail.com',
        '2001-11-24',
        'M',
        'Portugal',
        'Ver filmes é a minha paixão'
);


-----------------------------------------------


INSERT INTO Watchlist
VALUES
    (
        1,
        0111161    
);

INSERT INTO Watchlist
VALUES
    (
        1,
        0071562    
);

INSERT INTO Watchlist
VALUES
    (
        1,
        0167260    
);


INSERT INTO Watchlist
VALUES
    (
        2,
        0050083    
);

INSERT INTO Watchlist
VALUES
    (
        2,
        0060196    
);
-----------------------------------

INSERT INTO Critica
VALUES
    (
        'Tied for the best movie I have ever seen',
        'Why do I want to write the 234th comment on The Shawshank Redemption? I am not sure - almost everything that could be possibly said about it has been said. But like so many other people who wrote comments, I was and am profoundly moved by this simple and eloquent depiction of hope and friendship and redemption.
    The only other movie I have ever seen that effects me as strongly is To Kill a Mockingbird. Both movies leave me feeling cleaner for having watched them.
    I didnt intend to see this movie at all: I do not like prison movies and I dont normally watch them. I work at a branch library and one day as I was checking The Shawshank Redemption out to one of our older patrons, she said to me, Whenever I feel down or depressed, I check out this movie and watch it and it always makes me feel better. At the time, I thought that was very strange. One day there was nothing on TV except things I absolutely would not watch under any circumstance or things that I had seen too many times already. I remembered what she said, so I watched it. I have watched it many many times since then and it gets better with every showing.',
        0,
        10,
        0111161,
        1
);

INSERT INTO Critica
VALUES
    (
        'This is How Movies Should Be Made',
        'The Shawshank Redemption is written and directed by Frank Darabont. It is an adaptation of the Stephen King novella Rita Hayworth and Shawshank Redemption. Starring Tim Robbins and Morgan Freeman, the film portrays the story of Andy Dufresne (Robbins), a banker who is sentenced to two life sentences at Shawshank State Prison for apparently murdering his wife and her lover. Andy finds it tough going but finds solace in the friendship he forms with fellow inmate Ellis Red Redding (Freeman). While things start to pick up when the warden finds Andy a prison job more befitting his talents as a banker. However, the arrival of another inmate is going to vastly change things for all of them.',
        0,
        9,
        0111161,
        1
);

INSERT INTO Critica
VALUES
    (
        'I Had To Go To Prison To Learn To Be A Crook',
        'Shawshank Redemption is without doubt one of the best films ever made, and definitely the best film of 1994. Yes, it is better than Lion King, and I really like that too. It is not only enthralling but powerful and moving too. I will confess that I didnt understand it when I first saw it as a lot happens in the film, and I have now seen it three times. I seriously hope, that those who ignored the film when it was first released now recognise it as a great film, as it really is. The dialogue was extremely well-written, with lines that really stick in your mind. The cinematography and music are both gorgeous, and the prison itself is like a character that dominates the film. In the script, there are some true elements of Stephen King Now I admit I am not a huge king fan, and usually dont like coarse language in books. But in his books like It, which is very good, I have accepted the language represents brutality and rebellion, shown perfectly in the film with the battle of acceptance I suppose between the inmates and the superiors(like the scene with the warden yelling coarse language at the new inmates lined up in a row at the beginning.)The acting was exceptional. I am not hugely familiar with Tim Robbins, but he did a great job in a very demanding role.',
        1,
        10,
        0111161,
        2
);

INSERT INTO Interage_critica
VALUES
    (
        1,
        1,
        1,
        0
);

INSERT INTO Interage_critica
VALUES
    (
        2,
        2,
        1,
        0
);

INSERT INTO Interage_critica
VALUES
    (
        1,
        3,
        1,
        0
);

INSERT INTO Interage_critica
VALUES
    (
        2,
        2,
        0,
        1
);

INSERT INTO Interage_critica
VALUES
    (
        1,
        3,
        0,
        1
);

INSERT INTO Interage_critica
VALUES
    (
        2,
        3,
        0,
        1
);


----------------------------------------------------

-- 1
INSERT INTO Filme
VALUES
    (
        0111161,
        142
);

-- 2
INSERT INTO Filme
VALUES
    (
        0068646,
        175
);

-- 3
INSERT INTO Filme
VALUES
    (
        0468569,
        152
);

-- 4
INSERT INTO Filme
VALUES
    (
        0071562,
        202
);

-- 5
INSERT INTO Filme
VALUES
    (
        0050083,
        96
);

-- 6
INSERT INTO Filme
VALUES
    (
        0108052,
        195
);

-- 7
INSERT INTO Filme
VALUES
    (
        0167260,
        201
);

-- 8
INSERT INTO Filme
VALUES
    (
        0110912,
        174
);

-- 9
INSERT INTO Filme
VALUES
    (
        0120737,
        178
);

-- 10
INSERT INTO Filme
VALUES
    (
        0060196,
        161
);

----------------------------------------------------
INSERT INTO Serie
VALUES
    (
        0903747,
        5,
        62
);