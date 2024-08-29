CREATE TABLE BOOK
(
  year INT NOT NULL,
  name VARCHAR(255) NOT NULL,
  price INT NOT NULL,
  id INT NOT NULL PRIMARY KEY,
  quantity INT NOT NULL,
  BuyersNO INT NULL,
  Offer int null,
  AUTH_ID INT NOT NULL,
  Category VARCHAR(255) NOT NULL,
);

CREATE TABLE [USER]
(
  Lname VARCHAR(255) NOT NULL,
  Fname VARCHAR(255) NOT NULL,
  USR_ID INT NOT NULL,
  street VARCHAR(255) NOT NULL,
  buildingNo INT NOT NULL,
  city VARCHAR(255) NOT NULL,
  passowrd VARCHAR(255) NOT NULL,
  phone VARCHAR(255) NOT NULL,
  PRIMARY KEY (USR_ID)
);

CREATE TABLE reader
(
  RDR_ID INT NOT NULL,
  PRIMARY KEY (RDR_ID),
  FOREIGN KEY (RDR_ID) REFERENCES [USER](USR_ID)
);

CREATE TABLE student
(
  STD_ID INT NOT NULL,
  PRIMARY KEY (STD_ID),
  FOREIGN KEY (STD_ID) REFERENCES reader(RDR_ID),
);

CREATE TABLE [admin]
(
  ADM_ID INT NOT NULL,
  PRIMARY KEY (ADM_ID),
  FOREIGN KEY (ADM_ID) REFERENCES [USER](USR_ID),
);

CREATE TABLE author
(
  AUTH_ID INT NOT NULL,
  PRIMARY KEY (AUTH_ID),
  FOREIGN KEY (AUTH_ID) REFERENCES [USER](USR_ID),
);


CREATE TABLE buys
(
  date DATE NOT NULL,
  RDR_ID INT NOT NULL,
  id INT NOT NULL,
  PRIMARY KEY (RDR_ID, id),
  FOREIGN KEY (RDR_ID) REFERENCES reader(RDR_ID),
  FOREIGN KEY (id) REFERENCES BOOK(id)
);

CREATE TABLE comments
(
     comment varchar(320),
     RDR_ID INT NOT NULL,
     id INT NOT NULL,
     PRIMARY KEY (RDR_ID, id),
     FOREIGN KEY (RDR_ID) REFERENCES reader(RDR_ID),
     FOREIGN KEY (id) REFERENCES BOOK(id)
);
create table temp(  -- for using the third requirement
	emptycol int not null
);


--requirement 1 (done)
select name from book where BuyersNo = (select max(BuyersNo) from book);

 -- requirement 2 (done)
SELECT distinct book.name from buys,reader,book 
where reader.RDR_ID=buys.RDR_ID
and book.id=buys.id and date < DATEADD(day,-30, getdate()) 
and date < getdate()
except
SELECT distinct book.name from buys,reader,book 
where reader.RDR_ID=buys.RDR_ID
and book.id=buys.id and date > DATEADD(day,-30, getdate()) 
and date < getdate()

-- requirement 3 (done)
select count(*) as NUM_of_authors from(
SELECT author.AUTH_ID from buys,author,book,reader
where reader.RDR_ID=buys.RDR_ID and author.AUTH_ID=book.AUTH_ID
and book.id=buys.id and date < DATEADD(day,-30, getdate()) 
and date < getdate()
except
SELECT author.AUTH_ID from buys,reader,book,author
where reader.RDR_ID=buys.RDR_ID and author.AUTH_ID=book.AUTH_ID
and book.id=buys.id and date > DATEADD(day,-30, getdate()) 
and date < getdate()
) temp;

-- requirement 4 (done)
select distinct author.AUTH_ID from book, author
where author.AUTH_ID!=book.AUTH_ID
except
select distinct author.AUTH_ID from book, author
where author.AUTH_ID=book.AUTH_ID
 
-- requirement 6 (done)
select [user].Lname, [user].fNAME, [user].USR_ID,
[user].street, [user].buildingno,[user].city, [user].passowrd, [user].phone,
boughtNO = (select count(buys.RDR_ID) from buys where buys.RDR_ID = reader.RDR_ID)
from [user],reader where [user].USR_ID = reader.RDR_ID


-- requirement 5
select top 1  category,count(category) as TotalNo 
from book 
group by category 
order by TotalNo asc;






