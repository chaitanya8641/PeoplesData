
Create Database PeoplesDataDB

CREATE TABLE PeopleDetails(
  PeopleDetailsId UNIQUEIDENTIFIER DEFAULT (newsequentialid()) NOT NULL,
  FirstName   NVARCHAR(256) NOT NULL, 
  LastName    NVARCHAR(256) NOT NULL,
  DataofBirth DATETIME  NOT NULL,
  Email       NVARCHAR(256) NOT NULL,
  Address     NVARCHAR(256) NOT NULL,
  City        NVARCHAR(256) NOT NULL,
  Country     NVARCHAR(256) NOT NULL,
  ZipCode     NVARCHAR(256)  NOT NULL,
  CONSTRAINT [PK_dbo.PeopleDetails] PRIMARY KEY CLUSTERED ([PeopleDetailsId] ASC)
);

INSERT INTO [PeopleDetails] VALUES
(NewID(),'Emma','Dunham','31 Mar 1980','emma.dunham@vtgrafix.gov','76 Sherman Road','Hastings','Aruba','06830'),
(NewID(),'Ivan','Risley','09 Aug 1958','ivan.risley@nitrosystems.co','18 Hartswood Road','Stanford','Algeria','04346'),
(NewID(),'Rikki','Paquette','18 Sep 1963','rikki.paquette@anaplex.xyz','56 Canal Street','London','Iceland','16935'),
(NewID(),'Roman','Bourne','14 Aug 1979','roman.bourne@baramax.co','55 Wooster Road','Adelaide','Eritrea','46446'),
(NewID(),'Lyn','Chapman','12 May 1955','lyn.chapman@loopsys.xyz','31 Bramble Lane','Auckland','Netherlands','45893'),
(NewID(),'Rosie','Finn','15 Feb 1981','rosie.finn@sealine.co','42 Walford Way','Beaverton','France','10697'),
(NewID(),'Cedric','Webster','18 May 1956','cedric.webster@solexis.co','38 Colwood Place','Wilmington','Guatemala','01521'),
(NewID(),'Rosanne','Starck','16 Jan 1989','rosanne.starck@dalserve.org','50 Hunt Street','Cardiff','Tanzania, United Republic of','65339'),
(NewID(),'Emma','Young','14 Aug 1976','emma.young@terralabs.info','22 Clarendon Street','Portsmouth','Guernsey','02285'),
(NewID(),'Stan','Milling','22 Sep 1953','stan.milling@corerobotics.gov','85 Golden Lane','Medford','Nigeria','29916'),
(NewID(),'Jenette','Oldman','16 May 1985','jenette.oldman@hivemind.biz','50 Mount Street','Woodville','Puerto Rico','47870'),
(NewID(),'Max','Hyder','13 Dec 1954','max.hyder@polycore.gov','30 Buckley Street','Tacoma','Latvia','73729'),
(NewID(),'Juliana','Kelsey','03 Jan 1982','juliana.kelsey@grafixmedia.xyz','26 Mercer Street','Hobart','Hong Kong','98550'),
(NewID(),'Adam','Hollis','06 Aug 1985','adam.hollis@triosys.co','64 Bramble Lane','Adelaide','Malta','50998'),
(NewID(),'Alexis','Brandt','12 Sep 1971','alexis.brandt@terralabs.gov','52 Orchard Road','Boston','Norfolk Island','56707'),
(NewID(),'Travis','Cappel','12 Mar 1955','travis.cappel@ulogica.gov','42 Glenn Drive','Toledo','Nicaragua','54985'),
(NewID(),'Layla','Flinn','18 May 1976','layla.flinn@seelogic.club','89 Rivington Street','Lancaster','Congo','40390'),
(NewID(),'Raylene','Sager','03 Sep 1968','raylene.sager@infratouch.net','87 Coleman Avenue','Durham','Guyana','85733'),
(NewID(),'Chloe','Turner','13 Sep 1989','chloe.turner@playtech.mobi','73 Robinson Street','Wilmington','Zambia','82963'),
(NewID(),'Roman','Porras','24 Jan 1978','roman.porras@mediadime.xyz','45 Windsor Avenue','Sheffield','Zimbabwe','05706');

