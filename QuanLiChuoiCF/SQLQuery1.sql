	create	proc USP_GetAccountByUserName
	@userName nvarchar(100)
	as
	begin
	select *from dbo.Account where ID = @userName
	end 
	go

	exec dbo.USP_GetAccountByUserName @userName = N'NV01' 
	 


	select * from dbo.account where ID = N'NV01' and password = N'2560'


	 create proc USP_GetDrinkList
	 as select * from dbo.Drink
	 go	
