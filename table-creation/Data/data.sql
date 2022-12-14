----======== LOCATION INSERT =========--
--INSERT INTO LOCATION
--(LOC_HOURS,
--LOC_ADDRESS,
--LOC_PHONE,
--LOC_NAME)
--VALUES ('1 to 1', '2 camino santa maria', '210-123-3333', 'location 1')
--INSERT INTO LOCATION
--(LOC_HOURS,
--LOC_ADDRESS,
--LOC_PHONE,
--LOC_NAME)
--VALUES ('2 to 2', '2 camino santa maria', '210-123-3333', 'location 2')
--INSERT INTO LOCATION
--(LOC_HOURS,
--LOC_ADDRESS,
--LOC_PHONE,
--LOC_NAME)
--VALUES ('3 to 3', '3 camino santa maria', '210-123-3333', 'location 3')
--INSERT INTO LOCATION
--(LOC_HOURS,
--LOC_ADDRESS,
--LOC_PHONE,
--LOC_NAME)
--VALUES ('4 to 4', '4 camino santa maria', '210-123-4444', 'location 4')
--INSERT INTO LOCATION
--(LOC_HOURS,
--LOC_ADDRESS,
--LOC_PHONE,
--LOC_NAME)
--VALUES ('5 to 5', '5 camino santa maria', '210-123-5555', 'location 5')

----======== RESERVATION INSERT =========--
-- DATE FORMAT -> YYYY-MM-DD
--INSERT INTO RESERVATION
--(RES_EMP_ID,
--RES_CUST_ID,
--RES_LOC_ID,
--RES_ROOM_NO,
--RES_START_DATE,
--RES_END_DATE)
--VALUES (1, 1, 1, 1, '20220101', '20220101')
--INSERT INTO RESERVATION
--(RES_EMP_ID,
--RES_CUST_ID,
--RES_LOC_ID,
--RES_ROOM_NO,
--RES_START_DATE,
--RES_END_DATE)
--VALUES (2, 2, 2, 2, '20220202', '20220202')
--INSERT INTO RESERVATION
--(RES_EMP_ID,
--RES_CUST_ID,
--RES_LOC_ID,
--RES_ROOM_NO,
--RES_START_DATE,
--RES_END_DATE)
--VALUES (3, 3, 3, 3, '20220303', '20220303')
--INSERT INTO RESERVATION
--(RES_EMP_ID,
--RES_CUST_ID,
--RES_LOC_ID,
--RES_ROOM_NO,
--RES_START_DATE,
--RES_END_DATE)
--VALUES (4, 4, 4, 4, '20220404', '20220404')
--INSERT INTO RESERVATION
--(RES_EMP_ID,
--RES_CUST_ID,
--RES_LOC_ID,
--RES_ROOM_NO,
--RES_START_DATE,
--RES_END_DATE)
--VALUES (5, 5, 5, 5, '20220505', '20220505')

--======== ROOM INSERT =========--
--INSERT INTO ROOM
--(ROOM_NO,
--ROOM_LOC,
--ROOM_TYPE,
--ROOM_AVAILABLE)
--VALUES (101, 1, 1, 'Y')
--INSERT INTO ROOM
--(ROOM_NO,
--ROOM_LOC,
--ROOM_TYPE,
--ROOM_AVAILABLE)
--VALUES (202, 2, 2, 'Y')
--INSERT INTO ROOM
--(ROOM_NO,
--ROOM_LOC,
--ROOM_TYPE,
--ROOM_AVAILABLE)
--VALUES (303, 3, 3, 'Y')
--INSERT INTO ROOM
--(ROOM_NO,
--ROOM_LOC,
--ROOM_TYPE,
--ROOM_AVAILABLE)
--VALUES (404, 4, 4, 'Y')
--INSERT INTO ROOM
--(ROOM_NO,
--ROOM_LOC,
--ROOM_TYPE,
--ROOM_AVAILABLE)
--VALUES (505, 5, 5, 'Y')

--======== ROOM TYPE INSERT =========--
--INSERT INTO ROOM_TYPE
--(TYPE_CODE,
--TYPE_PRICE,
--TYPE_DESCRIPTION)
--VALUES (1, 100.00, 'type 1')
--INSERT INTO ROOM_TYPE
--(TYPE_CODE,
--TYPE_PRICE,
--TYPE_DESCRIPTION)
--VALUES (2, 200.00, 'type 2')
--INSERT INTO ROOM_TYPE
--(TYPE_CODE,
--TYPE_PRICE,
--TYPE_DESCRIPTION)
--VALUES (3, 300.00, 'type 3')
--INSERT INTO ROOM_TYPE
--(TYPE_CODE,
--TYPE_PRICE,
--TYPE_DESCRIPTION)
--VALUES (4, 400.00, 'type 4')
--INSERT INTO ROOM_TYPE
--(TYPE_CODE,
--TYPE_PRICE,
--TYPE_DESCRIPTION)
--VALUES (5, 500.00, 'type 5')

---- CUSTOMER INSERTIONS
--INSERT INTO CUSTOMER (cust_fname,cust_lname,cust_phone,cust_balance) VALUES('Bob','Dylan','111-111-1111',100.00);
--INSERT INTO CUSTOMER (cust_fname,cust_lname,cust_phone,cust_balance) VALUES('Mariah','Carrey','222-222-2222',200.00);
--INSERT INTO CUSTOMER (cust_fname,cust_lname,cust_phone,cust_balance) VALUES('Kurt','Cobain','333-333-3333',300.00);
--INSERT INTO CUSTOMER (cust_fname,cust_lname,cust_phone,cust_balance) VALUES('David','Bowie','444-444-4444',400.00);


---- CREDIT CARD INSERTIONS
--INSERT INTO CREDIT_CARD (credit_card_no,credit_card_fname,credit_card_lname,credit_expire_date,credit_sec_code)
--   VALUES('1111 1111 1111 1111','Bob','Dylan','05/27',523);
--INSERT INTO CREDIT_CARD (credit_card_no,credit_card_fname,credit_card_lname,credit_expire_date,credit_sec_code)
--   VALUES('2222 2222 2222 2222','Mariah','Carrey','06/25',523);
--INSERT INTO CREDIT_CARD (credit_card_no,credit_card_fname,credit_card_lname,credit_expire_date,credit_sec_code)
--   VALUES('3333 3333 3333 3333','Kurt','Cobain','03/26',627);
--INSERT INTO CREDIT_CARD (credit_card_no,credit_card_fname,credit_card_lname,credit_expire_date,credit_sec_code)
--   VALUES('4444 4444 4444 4444','David','Bowie','01/28',523);


---- REQUIRES LOCATION TO COME FIRST
---- EMPLOYEE INSERTION
--INSERT INTO EMPLOYEE (emp_fname,emp_lname,emp_title,emp_ssn) VALUES('Employee','One','Housekeeper',1234567);
--INSERT INTO EMPLOYEE (emp_fname,emp_lname,emp_title,emp_ssn) VALUES('Employee','Two','Housekeeper',7654321);
--INSERT INTO EMPLOYEE (emp_fname,emp_lname,emp_title,emp_ssn) VALUES('Employee','3','Front Desk',2468910);
--INSERT INTO EMPLOYEE (emp_fname,emp_lname,emp_title,emp_ssn) VALUES('Employee','4','General Manager',1098642);


-- TRANSACTIONS INSERTION
--INSERT INTO TRANSACTIONS (trans_no, trans_date, trans_amt) VALUES(111111,'',100);
--INSERT INTO TRANSACTIONS (trans_no, trans_date, trans_amt) VALUES(222222,'',100);
--INSERT INTO TRANSACTIONS (trans_no, trans_date, trans_amt) VALUES(333333,'',100);
--INSERT INTO TRANSACTIONS (trans_no, trans_date, trans_amt) VALUES(444444,'',100);
