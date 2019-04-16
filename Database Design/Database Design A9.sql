--A9
--Tanner Ellenberger
--Nick Gay
--Demarcus George
--Joel Mwambayi

Create TRIGGER TRG_MEM_BALANCE
On DetailRental
AFTER Update
As 
Declare @Prior_LateFee int
Declare @New_LateFee int 
Declare @Update_Amount int
Declare @Rent_Num int
Declare @Vid_Num int
Declare @Detail_DueDate datetime
Declare @Detail_ReturnDate datetime
Declare @Detail_DailyLateFee int

If(Exists (Select * From deleted) AND Exists(Select * From inserted))
Begin
Declare Update_Cursor Cursor For
Select 
deleted.Rent_Num,
deleted.Vid_num,
deleted.Detail_DueDate,
deleted.Detail_REturnDate,
deleted.Detail_DailyLateFee
From deleted
Open Update_Cursor 
FETCH NEXT FROM Update_Cursor INTO 
	@Rent_Num, 
	@Vid_Num,
	@Detail_DueDate,
	@Detail_ReturnDate,
	@Detail_DailyLateFee
	

WHILE @@FETCH_STATUS = 0
BEGIN
IF (Select ISNULL(DATEDIFF(DD,Detail_DueDate,Detail_ReturnDate)*Detail_DailyLateFee,0) 
		From DETAILRENTAL 
		Where Rent_Num = @Rent_Num AND Vid_Num = @Vid_Num)<0
		
		Set @New_LateFee =  0
ELSE
	Set @New_LateFee = (Select ISNULL(DATEDIFF(DD,Detail_DueDate,Detail_ReturnDate)*Detail_DailyLateFee,0) 
					From DETAILRENTAL 
					Where Rent_Num = @Rent_Num AND Vid_Num = @Vid_Num)

IF (Select ISNULL(DATEDIFF(DD,@Detail_DueDate,@Detail_ReturnDate)*@Detail_DailyLateFee,0))<0 
		Set @Prior_LateFee =  0

ELSE
	Set @Prior_LateFee=Isnull(DATEDIFF(DD,@Detail_DueDate,@Detail_ReturnDate)*@Detail_DailyLateFee,0)
	
    Set @Update_Amount = @Prior_LateFee - @New_LateFee 

Update MEMBERSHIP 
Set Mem_Balance = Mem_Balance + @Update_Amount
FETCH NEXT FROM Update_Cursor INTO @Rent_Num, @Vid_Num,@Detail_DueDate,@Detail_ReturnDate,@Detail_DailyLateFee
END
CLOSE Update_Cursor;
DEALLOCATE Update_Cursor;
