--Tanner Ellenberg
--Nick Gay
--DeMarcus George
--Joel Myambayi

--A10P1
CREATE TABLE AIRCRAFTDIM (
AIRCRAFT_KEY int Identity NOT NULL,
AC_NUMBER varchar(5),
MOD_CODE varchar(10),
AC_TTAF float(8),
AC_TTEL float(8),
AC_TTER float(8)
);
/* -- */
CREATE TABLE PILOTDIM (
PILOT_KEY int Identity NOT NULL,
EMP_NUM int,
EMP_LNAME varchar(15),
EMP_FNAME varchar(15),
PIL_LICENSE varchar(25) NOT NULL,
PIL_RATINGS varchar(25),
PIL_MED_TYPE varchar(1),
PIL_MED_DATE datetime,
PIL_PT135_DATE datetime
);
/* -- */
CREATE TABLE TIMEDIM(
TIME_KEY int Identity NOT NULL,
CHAR_DATE datetime,
CHAR_YEAR datetime,
CHAR_MONTH datetime
);
/* -- */
CREATE TABLE FACT(
TIME_KEY int NOT NULL,
PILOT_KEY int NOT NULL,
AIRCRAFT_KEY int NOT NULL,
CHAR_DISTANCE float(8),
CHAR_FUEL_GALLONS float(8),
MOD_CHG_MILE float(8)
);
/* -- */
Alter Table AIRCRAFTDIM
Add Constraint PK_AircraftDim Primary Key(AIRCRAFT_KEY)
/* -- */
Alter Table PILOTDIM
Add Constraint PK_PilotDim Primary Key(PILOT_KEY)
/* -- */
Alter Table TIMEDIM 
Add Constraint PK_TimeDim Primary Key(TIME_KEY)
/* -- */
Alter Table FACT
Add Constraint PK_Fact Primary Key(TIME_KEY,PILOT_KEY,AIRCRAFT_KEY),
    Constraint FK_Time Foreign Key(TIME_KEY) References TIMEDIM,
	Constraint FK_Pilot Foreign Key(PILOT_KEY) References PILOTDIM,
	Constraint FK_Aircraft Foreign Key(AIRCRAFT_KEY) References AIRCRAFTDIM 

    