use QuationData;

create table Customer(
 code int not null IDENTITY(1,1),
 id_number varchar(50),
 first_name varchar(50),
 last_name varchar(50),
 date_of_birth date,
 contact_number varchar(50),
 income money ,
 job varchar(50),
 employer varchar(50)

 constraint PK_Customer primary key clustered
  (
    code
  )
);


create table Loan(

 code int not null IDENTITY(1,1),
 customer_code int not null ,
 loan_amount money ,
 interest_rate varchar(10),
 repayment varchar(30)


 constraint PK_Loan primary key clustered
  (
    code
  )

);