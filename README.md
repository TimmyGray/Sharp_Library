I am not strong in unit tests but you can clone this mini console app to test this library - https://github.com/TimmyGray/Test_Console  
  
  
  
Answer for third question:  
SELECT Products.Name, Cathegories.Name FROM Products,Cathegories
WHERE Products.Id = Cathegories.ProductId OR Products.CathegoriesId IS NULL

