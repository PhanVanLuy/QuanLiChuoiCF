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

	
	create proc USP_GetDrinkList
	as select * from dbo.Drink
	go
	exec dbo.USP_GetDrinkList
	select*from dbo.Bill 
	select * from DetailOfBill 
	select *from Branch 
	select *from dbo.Drink


	select dr.Name, de.count, dr.Price, dr.Price*de.count from dbo.DetailOfBill as de, dbo.Bill as bi, dbo.Drink as dr
	where de.IDOfBill=bi.IDOfBill and de.IDOfDrink =Dr.IDOfDrink and dr.IDOfDrink='DU01' and bi.IDOfBranch='CN09'
	select Branch.IDOfBranch from dbo.Branch, dbo.Employee, dbo.Account where Branch.IDOfBranch=Employee.IDOfBranch and Employee.IDOfEmloyee='NV01      '
