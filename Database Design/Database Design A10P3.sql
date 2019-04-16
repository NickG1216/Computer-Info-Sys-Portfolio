--Tanner Ellenberg
--Nick Gay
--DeMarcus George
--Joel Myambayi

--A10P3
Create Procedure [dbo].[a10P4prc]
As
Begin
Alter Table FACT
Drop Constraint PK_Fact, 
     Constraint FK_Time,
	 Constraint FK_Pilot,
	 Constraint FK_Aircraft
/* -- */
Alter Table PILOTDIM
Drop Constraint PK_PilotDim
/* -- */
Alter Table TIMEDIM 
Drop Constraint PK_TimeDim 
/* -- */
Alter Table AIRCRAFTDIM
Drop Constraint PK_AircraftDim
/* -- */
Truncate Table AIRCRAFTDIM
Truncate Table PILOTDIM
Truncate Table TIMEDIM
Truncate Table Fact
/* -- */
Insert Into AIRCRAFTDIM
Select *
From AIRCRAFT
/* -- */
Insert Into PILOTDIM
Select E.EMP_NUM, E.EMP_LNAME, E.EMP_FNAME, P.PIL_LICENSE, P.PIL_RATINGS,P.PIL_MED_TYPE, P.PIL_MED_DATE, P.PIL_PT135_DATE
From Pilot P INNER JOIN EMPLOYEES E On P.EMP_NUM = E.EMP_NUM
/* -- */
Insert Into TIMEDIM
Select Char_Date, Year(Char_Date), Month(Char_Date)
From Charter 
/* -- */
Create Table STAGING (
AC_NUMBER varchar(5) NOT NULL,
EMP_NUM int NOT NULL,
Char_Date datetime NOT NULL,
CHAR_DISTANCE float(8),
CHAR_FUEL_GALLONS float(8),
MOD_CHG_MILE float(8),
TIME_KEY int Default NULL,
PILOT_KEY int Default NULL,
AIRCRAFT_KEY int Default NULL
);
Insert Into STAGING
Select A.AC_NUMBER, E.EMP_NUM, C.CHAR_DATE, C.CHAR_DISTANCE, C.CHAR_FUEL_GALLONS, M.MOD_CHG_MILE, TD.TIME_KEY, PD.PILOT_KEY, AD.AIRCRAFT_KEY
From AIRCRAFT A INNER JOIN MODEL M On A.MOD_CODE = M.MOD_CODE 
     INNER JOIN CHARTER C On A.AC_NUMBER = C.AC_NUMBER 
	 INNER JOIN CREW CR On C.CHAR_TRIP = CR.CHAR_TRIP
	 INNER JOIN EMPLOYEES E On CR.EMP_NUM = E.EMP_NUM
	 INNER JOIN PILOTDIM PD On E.EMP_NUM = PD.EMP_NUM
	 INNER JOIN TIMEDIM TD On C.CHAR_DATE = TD.CHAR_DATE
	 INNER JOIN AIRCRAFTDIM AD ON A.AC_NUMBER = AD.AC_NUMBER

UPDATE STAGING
Set TIME_KEY = T.TIME_KEY, PILOT_KEY = P.PILOT_KEY, AIRCRAFT_KEY = A.AIRCRAFT_KEY
From STAGING S INNER JOIN TIMEDIM T On S.TIME_KEY = T.TIME_KEY
     INNER JOIN PILOTDIM P On S.PILOT_KEY = P.PILOT_KEY
	 INNER JOIN AIRCRAFTDIM A On S.AIRCRAFT_KEY = A.AIRCRAFT_KEY
/* -- */
Insert Into FACT
Select TIME_KEY, PILOT_KEY, AIRCRAFT_KEY, CHAR_DISTANCE, CHAR_FUEL_GALLONS, MOD_CHG_MILE
From STAGING
/* -- */
Drop Table STAGING
/* -- */
End



