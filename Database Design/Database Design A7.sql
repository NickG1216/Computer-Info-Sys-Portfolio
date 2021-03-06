--Tanner Ellenberger
--Nick Gay
--DeMarcus George
--Joel Mwambayi

--Assignment 7
--March 26, 2018

--1
SELECT C.CUSTOMERID, C.LASTNAME, C.FIRSTNAME, B.MODELTYPE, P.COLORLIST, B.ORDERDATE, B.SALESTATE
FROM BICYCLE B INNER JOIN CUSTOMER C ON B.CUSTOMERID = C.CUSTOMERID INNER JOIN PAINT P ON P.PAINTID = B.PAINTID
WHERE B.SALESTATE = 'CA' AND P.COLORLIST = 'RED' AND B.MODELTYPE LIKE '%MOUNTAIN%' AND 
YEAR(B.ORDERDATE) = '2003' AND MONTH(B.ORDERDATE) = 9

--2
SELECT E.EMPLOYEEID, E.LASTNAME, B.SALESTATE, B.MODELTYPE,  B.STOREID, B.ORDERDATE 
FROM EMPLOYEE E INNER JOIN BICYCLE B ON E.EMPLOYEEID = B.EMPLOYEEID 
WHERE B.SALESTATE = 'WI' AND B.MODELTYPE = 'RACE' AND YEAR(B.ORDERDATE) = '2001' AND 
STOREID IS NOT NULL 

--3 
SELECT DISTINCT C.COMPONENTID, M.MANUFACTURERNAME, C.PRODUCTNUMBER 
FROM COMPONENT C INNER JOIN MANUFACTURER M ON C.ManufacturerID = M.MANUFACTURERID  
INNER JOIN BIKEPARTS BP ON C.COMPONENTID = BP.COMPONENTID 
INNER JOIN BICYCLE B ON BP.SERIALNUMBER = B.SERIALNUMBER 
WHERE B.MODELTYPE = 'ROAD' AND YEAR(B.ORDERDATE)= '2002' AND B.SALESTATE='FL' AND 
C.CATEGORY ='REAR DERAILLEUR' 
 
--4 
SELECT B.CUSTOMERID, C.LASTNAME, C.FIRSTNAME, B.MODELTYPE, B.SALESTATE, B.FRAMESIZE, B.ORDERDATE 
FROM BICYCLE B INNER JOIN CUSTOMER C ON C.CUSTOMERID = B.CUSTOMERID 
WHERE B.MODELTYPE = 'MOUNTAIN FULL' AND B.SALESTATE = 'GA' AND YEAR(B.ORDERDATE) = 2004  
AND FRAMESIZE = (SELECT MAX(FRAMESIZE) 
 	 	 	 	 FROM BICYCLE 
 	 	 	 	 WHERE MODELTYPE = 'MOUNTAIN FULL' AND SALESTATE = 'GA' AND          
YEAR(ORDERDATE) = 2004) 
 

--5
SELECT M.MANUFACTURERNAME, P.MANUFACTURERID 
FROM MANUFACTURER M INNER JOIN PURCHASEORDER P ON M.MANUFACTURERID = P.MANUFACTURERID 
WHERE YEAR(P.ORDERDATE) = '2003' AND DISCOUNT = (SELECT MAX(DISCOUNT) 
 	 	 	 	 	 	 	FROM PURCHASEORDER 
 	 	 	 	 	 	       WHERE YEAR(ORDERDATE) = 2003 
) 

--6
SELECT C.COMPONENTID, M.MANUFACTURERNAME, C.PRODUCTNUMBER, C.ROAD, C.CATEGORY, C.LISTPRICE, C.QUANTITYONHAND 
FROM COMPONENT C INNER JOIN MANUFACTURER M ON C.MANUFACTURERID = M.MANUFACTURERID 
WHERE C.QUANTITYONHAND > 200  AND C.ROAD = 'ROAD' 
ORDER BY LISTPRICE DESC 
 
 
--7 
SELECT C.COMPONENTID, M.MANUFACTURERNAME, C.PRODUCTNUMBER, C.CATEGORY, C.YEAR, (C.ESTIMATEDCOST) AS [VALUE] 
FROM COMPONENT C INNER JOIN MANUFACTURER M ON C.MANUFACTURERID= M.MANUFACTURERID 
ORDER BY [VALUE] DESC 
 
--8 
SELECT E.EMPLOYEEID, E.LASTNAME, BP.DATEINSTALLED, COUNT(BP.COMPONENTID) AS 
[COUNTOFCOMPONENTS]    
FROM EMPLOYEE E INNER JOIN BIKEPARTS BP ON E.EMPLOYEEID = BP.EMPLOYEEID 
WHERE BP.DATEINSTALLED IS NOT NULL 
GROUP BY E.EMPLOYEEID, E.LASTNAME, BP.DATEINSTALLED 
ORDER BY [COUNTOFCOMPONENTS] DESC 
  
--9 
SELECT LETTERSTYLEID, COUNT(LETTERSTYLEID) AS [COUNTOFSERIALNUMBER] 
FROM BICYCLE 
WHERE YEAR(ORDERDATE) = '2003' AND MODELTYPE = 'RACE' 
GROUP BY LETTERSTYLEID 
ORDER BY [COUNTOFSERIALNUMBER] DESC 
 
--10
SELECT B.CUSTOMERID, C.LASTNAME, C.FIRSTNAME, COUNT(B.SERIALNUMBER) AS 
[NUMBEROFBIKES], SUM(CT.AMOUNT) AS [AMOUNTSPENT] 
FROM CUSTOMER C INNER JOIN CUSTOMERTRANSACTION CT ON C.CUSTOMERID = CT.CUSTOMERID 
INNER JOIN BICYCLE B ON B.CUSTOMERID = C.CUSTOMERID 
WHERE YEAR(TRANSACTIONDATE) = '2002' AND CT.AMOUNT > 0 
GROUP BY B.CUSTOMERID, C.LASTNAME, C.FIRSTNAME 
ORDER BY SUM(CT.AMOUNT) DESC

--11 
Select Year(OrderDate) As SaleYear, COUNT(SerialNumber) AS CountOfSerialNumber
From Bicycle
Where Year(OrderDate) >= '2000' AND Year(OrderDate) <= '2004'  AND ModelType = 'Mountain' 
Group By Year(OrderDate)
ORDER By SaleYear

--12 
SELECT C.COMPONENTID, M.MANUFACTURERNAME, C.PRODUCTNUMBER, C.CATEGORY, P.PRICEPAID AS
[VALUE]
FROM PURCHASEORDER PO INNER JOIN PURCHASEITEM P ON PO.PURCHASEID = P.PURCHASEID
 INNER JOIN COMPONENT C ON P.COMPONENTID =
C.COMPONENTID
 INNER JOIN MANUFACTURER M ON C.MANUFACTURERID =
M.MANUFACTURERID
WHERE YEAR(PO.ORDERDATE) = '2003' AND P.PRICEPAID = (SELECT MAX(P.PRICEPAID)

FROM PURCHASEITEM P INNER JOIN PURCHASEORDER PO ON P.PURCHASEID = PO.PURCHASEID
WHERE YEAR(PO.ORDERDATE) = '2003'
)
--13
Select E.EmployeeID, E.LastName, Count(B.SerialNumber) AS [Number Painted]
FROM Paint P INNER JOIN Bicycle B On P.PaintID = B.PaintID
     INNER JOIN Employee E On E.EmployeeID = B.EmployeeID 
Where Year(B.OrderDate) = '2003'AND Month(OrderDate) = 5 AND B.ModelType = 'Race' AND P.ColorList = 'Red'
Group By E.EmployeeID, E.LastName

--14
Select TOP 1 RS.StoreID, RS.StoreName, C.City, SUM(B.SalePrice) AS [SumofSalePrice]
From City C INNER JOIN RetailStore RS On C.CityID = RS.CityID INNER JOIN Bicycle B ON RS.StoreID = B.StoreID
Where C.State = 'CA' AND Year(B.OrderDate) = '2003'
Group By RS.StoreID, RS.StoreName, C.City
Order By SumofSalePrice DESC

--15
Select SUM(C.Weight) AS [TotalWeight]
From Component C INNER JOIN BikeParts B ON C.ComponentID = B.ComponentID
Where B.SerialNumber = '11356'


--16
Select G.GroupName, SUM(C.ListPrice) AS [SumofListPrice]
From Groupo G INNER JOIN GroupComponents GC On G.ComponentGroupID = GC.GroupID INNER JOIN Component C ON C.ComponentID = GC.ComponentID
Where G.GroupName = 'Campy Record 2002'
Group by G.GroupName

--17
Select T.Material, COUNT(B.SerialNumber) AS [CountofSerialNumber]
From TubeMaterial T INNER JOIN BicycleTubeUsage BTU On T.TubeID = BTU.TubeID INNER JOIN Bicycle B On BTU.SerialNumber = B.SerialNumber
Where Year(B.OrderDate) = '2003' AND B.ModelType = 'Race' AND (T.Material = 'Carbon fiber' OR T.Material = 'Titanium')
Group By T.Material
Order By CountofSerialNumber DESC 

--18
SELECT AVG(PI.PRICEPAID) AS [AVGOFPRICEPAID]
FROM PURCHASEITEM PI INNER JOIN COMPONENT C ON PI.COMPONENTID = C.COMPONENTID
 INNER JOIN GROUPCOMPONENTS G ON G.COMPONENTID = PI.COMPONENTID
 INNER JOIN GROUPO GP ON GP.COMPONENTGROUPID = G.GROUPID
WHERE GP.GROUPNAME = 'SHIMANO XTR 2001' AND C.CATEGORY = 'REAR DERAILLEUR'

--19
Select AVG(TopTube) AS [AvgTopTubeLength]
From Bicycle
Where Year(OrderDate) = '1999' AND FrameSize = '54' AND ModelType = 'Road'
--20Select Road, AVG(ListPrice) AS [AvgListPrice]From ComponentWhere Category = 'Tire' AND (Road = 'Road' OR Road = 'MTB')Group By RoadOrder By AvgListPrice DESC --21SELECT DISTINCT E.EMPLOYEEID, LASTNAME
FROM EMPLOYEE E INNER JOIN BICYCLE B ON B.EMPLOYEEID = E.EMPLOYEEID
WHERE MODELTYPE = 'ROAD' AND YEAR(B.ORDERDATE) = 2003 AND MONTH(B.ORDERDATE) = 5 AND
PAINTER = B.EMPLOYEEID--22 Select P.PaintID, P.ColorName, Count(B.SerialNumber) AS [Number of Bikes Painted]From Paint P INNER JOIN Bicycle B ON P.PaintID = B.PaintID Where Year(B.OrderDate) = '2002' AND B.LetterStyleID = 'English'Group By P.PaintID, P.ColorNameOrder By [Number of Bikes Painted] DESC--23SELECT SERIALNUMBER, MODELTYPE, ORDERDATE, SALEPRICE
FROM BICYCLE
WHERE MODELTYPE = 'RACE' AND YEAR(ORDERDATE) = '2003' AND SALEPRICE >
(SELECT AVG(SALEPRICE)
FROM BICYCLE
WHERE MODELTYPE = 'RACE' AND YEAR(ORDERDATE) = '2002'
)--24SELECT M.MANUFACTURERNAME, C.PRODUCTNUMBER, C.CATEGORY, SUM(C.LISTPRICE *
C.QUANTITYONHAND) AS [VALUE], BP.DATEINSTALLED
FROM MANUFACTURER M INNER JOIN COMPONENT C ON C.MANUFACTURERID = M.MANUFACTURERID
 INNER JOIN BIKEPARTS BP ON C.COMPONENTID = BP.COMPONENTID
WHERE YEAR(BP.DATEINSTALLED) NOT LIKE '2004'
GROUP BY C.LISTPRICE, C.PRODUCTNUMBER, C.CATEGORY, M.MANUFACTURERNAME, BP.DATEINSTALLED
ORDER BY [VALUE] DESC--25SELECT R.STORENAME, R.PHONE
FROM RETAILSTORE R INNER JOIN BICYCLE B ON B.STOREID = R.STOREID
     INNER JOIN CITY C ON C.CITYID = R.CITYID
WHERE YEAR(B.ORDERDATE) = '2004' AND (C.STATE = 'CA' OR B.SALESTATE = 'CA')
GROUP BY R.STORENAME, R.PHONE--26SELECT (SELECT LASTNAME
 FROM EMPLOYEE
 WHERE EMPLOYEEID = (SELECT EMPLOYEEID
 FROM EMPLOYEE
WHERE LASTNAME = 'VENETIAAN')) AS [MANAGER NAME], EMPLOYEEID,
FIRSTNAME, LASTNAME, TITLE
FROM EMPLOYEE
WHERE CURRENTMANAGER = (SELECT EMPLOYEEID
 FROM EMPLOYEE
WHERE LASTNAME = 'VENETIAAN'
)--27SELECT C.COMPONENTID, M.MANUFACTURERNAME, C.PRODUCTNUMBER, C.CATEGORY,
PI.QUANTITYRECEIVED AS [TOTALRECEIVED],
 COUNT(BP.DATEINSTALLED) AS [TOTALUSED], ((COUNT(DATEINSTALLED) -
PI.QUANTITYRECEIVED) * (C.LISTPRICE - PI.PRICEPAID)) AS [NETGAIN],
 ((COUNT(DATEINSTALLED) - PI.QUANTITYRECEIVED) / (C.LISTPRICE - PI.PRICEPAID))
AS [NETPCT], C.LISTPRICE
FROM COMPONENT C INNER JOIN MANUFACTURER M ON M.MANUFACTURERID = C.MANUFACTURERID
INNER JOIN BIKEPARTS BP ON BP.COMPONENTID = C.COMPONENTID
INNER JOIN PURCHASEITEM PI ON PI.COMPONENTID = C.COMPONENTID
INNER JOIN PURCHASEORDER PO ON PO.PURCHASEID = PI.PURCHASEID
WHERE PO.RECEIVEDATE <= '30-JUN-2000'
GROUP BY C.COMPONENTID, M.MANUFACTURERNAME, C.PRODUCTNUMBER, C.CATEGORY,
PI.QUANTITYRECEIVED, PI.PRICEPAID, C.LISTPRICE
HAVING PI.QUANTITYRECEIVED >= 1.25 * COUNT(BP.DATEINSTALLED)

--28
SELECT YEAR(ORDERDATE) AS [YEAR], AVG(DATEDIFF(DAY, ORDERDATE, SHIPDATE)) AS [BUILD TIME]
FROM BICYCLE
GROUP BY YEAR(ORDERDATE)
HAVING AVG(DATEDIFF(DAY, ORDERDATE, SHIPDATE)) > (

SELECT AVG(DATEDIFF(DAY, ORDERDATE, SHIPDATE)) AS [TOTAL AVERAGE]

FROM BICYCLE
 )