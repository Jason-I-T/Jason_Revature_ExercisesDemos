-- On the Chinook DB, practice writing queries with the following exercises

-- List all customers (full name, customer id, and country) who are not in the USA
> SELECT CustomerId, FirstName, LastName FROM Customer WHERE Country != 'USA';

-- List all customers from Brazil
> SELECT * FROM Customer WHERE Country = 'Brazil';

-- List all sales agents
> SELECT * FROM Employee WHERE Title = 'Sales Support Agent';

-- Retrieve a list of all countries in billing addresses on invoices
> SELECT BillingCountry FROM Invoice;

-- Retrieve how many invoices there were in 2009, and what was the sales total for that year?
    -- (challenge: find the invoice count sales total for every year using one query)
> SELECT COUNT(InvoiceDate) As '2009 Invoices', SUM(Total) As 'Money Made' FROM Invoice WHERE YEAR(InvoiceDate) = 2009;

-- how many line items were there for invoice #37
> SELECT InvoiceId, COUNT(Quantity) as 'Quantity' FROM InvoiceLine WHERE InvoiceId = 37 GROUP BY InvoiceId;

-- how many invoices per country?
> SELECT  BillingCountry, Count(InvoiceID) as '# Of Invoices' FROM Invoice GROUP BY BillingCountry;

-- Retrieve the total sales per country, ordered by the highest total sales first.
> SELECT BillingCountry, SUM(Total) as 'Total Sales' FROM Invoice GROUP BY BillingCountry ORDER BY SUM(Total) DESC;


-- JOINS CHALLENGES
-- Show all invoices of customers from brazil (mailing address not billing)
> SELECT Customer.FirstName, Customer.LastName, Invoice.* FROM Customer LEFT JOIN Invoice ON Customer.CustomerId = Invoice.CustomerId WHERE Country = 'Brazil';

-- Show all invoices together with the name of the sales agent for each one
> SELECT Employee.EmployeeId, Employee.FirstName, Employee.LastName, Invoice.* FROM Customer LEFT JOIN Employee ON SupportRepId = EmployeeId LEFT JOIN Invoice ON Invoice.CustomerId = Customer.CustomerId;

-- Show all playlists ordered by the total number of tracks they have
> SELECT P.Name, COUNT(PT.TrackId) FROM Playlist as P LEFT JOIN PlayListTrack as PT ON P.PlaylistId = PT.PlaylistId GROUP BY P.Name ORDER BY COUNT(PT.TrackId) DESC;

-- Which sales agent made the most sales in 2009?
> SELECT Employee.Firstname, Employee.Lastname, COUNT(Invoice.InvoiceId) FROM Customer LEFT JOIN Employee ON SupportRepId = EmployeeId  LEFT JOIN Invoice ON Invoice.CustomerId = Customer.CustomerId WHERE Year(InvoiceDate) = 2009 GROUP BY Employee.Firstname, Employee.Lastname ORDER BY COUNT(Invoice.InvoiceId) DESC;

> Margaret Park (30)

-- How many customers are assigned to each sales agent?
> SELECT E.Employeeid, E.Firstname, E.Lastname, COUNT(C.CustomerId) FROM Invoice as I LEFT JOIN Customer as C ON C.CustomerId = I.CustomerId LEFT JOIN Employee as E on SupportRepId = EmployeeId GROUP BY E.Employeeid, E.Firstname, E.Lastname;

> Jane Peacock has 146 customers, Margaret Park has 140 customers, and Steve Johnson has 126 customers.

-- Which track was purchased the most ing 20010?
> SELECT T.Name, Count(IL.TrackId) as 'Tracks Purchased' FROM Invoice AS I LEFT JOIN InvoiceLine as IL ON I.Invoiceid = IL.Invoiceid LEFT JOIN Track as T ON IL.Trackid = T.Trackid WHERE YEAR(InvoiceDate) = 2010 GROUP BY T.Name ORDER BY Count(IL.TrackId) DESC;

> Dezesseis, Eruption, Gimme Some Truth, Onde Voce Mora?, King For A Day, The Number Of The Beast, Sure Know Something, Surrender, and No Quarter were all purchased twice in 2010.

-- Show the top three best selling artists.
> SELECT TOP 3 Ar.Name, Count(IL.TrackId) as 'Tracks Sold' FROM Artist AS Ar LEFT JOIN Album AS Al on Ar.ArtistId = Al.ArtistId LEFT JOIN Track AS T ON T.AlbumId = Al.AlbumId LEFT JOIN InvoiceLine IL on IL.TrackId = T.TrackId GROUP BY Ar.Name ORDER BY Count(IL.TrackId) DESC;

> Iron Maiden, U2, Metallica

-- Which customers have the same initials as at least one other customer?
> SELECT C1.Firstname, C1.Lastname FROM Customer AS C1, Customer AS C2 WHERE SUBSTRING(C1.Firstname, 1, 1) = SUBSTRING(C2.Firstname, 1, 1) AND SUBSTRING(C1.Lastname, 1, 1) = SUBSTRING(C2.Lastname, 1, 1) GROUP BY C1.Firstname, C1.Lastname HAVING Count(C2.CustomerId) > 1;


-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?

-- 2. which artists did not record any tracks of the Latin genre?

-- 3. which video track has the longest length? (use media type table)

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.


-- DML exercises

-- 1. insert two new records into the employee table.

-- 2. insert two new records into the tracks table.

-- 3. update customer Aaron Mitchell's name to Robert Walter

-- 4. delete one of the employees you inserted.

-- 5. delete customer Robert Walter.


