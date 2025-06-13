# Inventory Management System

The Inventory Management System is a web-based tool made to help you keep track of products or items. Whether you're running a store or managing stock, this app lets you easily add, update, view, or delete items as needed.
![image alt](https://github.com/Gayathri1261/Inventory-Management-System/blob/1b007491265d7386913118bc5ff1f23b91f130ae/HomePage.PNG)

# **How to Start Using It**

Navigating the App

**Home Page**
When the app first opens, you’ll see the Home Page. It may contain a short message or welcome note, along with menu links to the main pages—especially the one that shows your item list.

---
# **View All Items**
Where: Click the "Items" or "Inventory" option in the menu.

You’ll see a table with all your inventory items.
Each row will show details like:
Product Name
Quantity
Price
Category
Supplier (if available)

You’ll also see buttons to Edit, Delete, or View more info about each item.

![image alt](https://github.com/Gayathri1261/Inventory-Management-System/blob/main/Items%20List.PNG?raw=true)
---
#  Add a New Item
Where: Look for a button like “Add Item” or “Create New”.
A form will appear where you can type in item details.
Fill in things like name, quantity, price, etc.
Once done, click “Save” or “Create” to add it to your list.

![image alt](https://github.com/Gayathri1261/Inventory-Management-System/blob/main/Create.PNG?raw=true)
---
# **Update an Item**
Where: On the list of items, click the “Edit” button next to the item you want to change.
You’ll see a form with the current details already filled in.
Make your changes and click “Update” or “Save”.
The item will be updated and you’ll go back to the list.

![image alt](https://github.com/Gayathri1261/Inventory-Management-System/blob/main/Edit.PNG?raw=true)
---
# **View Item Details**
Where: Click the “Details” button for any item.
You’ll get a full view of that item’s info.
Use the “Back” link to return to the list when you're done.

![image alt](https://github.com/Gayathri1261/Inventory-Management-System/blob/main/Details.PNG?raw=true)
---
# **Delete an Item**
Where: On the item list, click “Delete” next to the item you want to remove.
You’ll go to a confirmation page asking if you’re sure.
If you’re sure, click “Delete” again. If not, just click “Back”.

![image alt](https://github.com/Gayathri1261/Inventory-Management-System/blob/main/Delete.PNG?raw=true)

 Note: Deleting an item removes it permanently, so double-check before you confirm.

## Deploy ASP.NET Project to Azure App Service & Azure SQL Database
# Create Azure App Service

1.Go to Azure Portal and log in.

2.Click "Create a resource" → "Web App".

3.Fill in the following details:
    Name: InventoryManagementSystem
    Publish: Code
    Runtime stack: .NET 8
    Region: Select your nearest region

4.Click Next (skip Monitoring) → Review + Create → Create

---
Step 2: Create Azure SQL Database

In the portal, click "Create a resource" → "SQL Database"
Provide:

Database name: InventoryManagementSystemDB

Server: Create new → Set admin username and password

Select Basic pricing tier

Click Review + Create → Create

After deployment:

Go to SQL Server → Firewalls and virtual networks

Add your current IP address

Enable "Allow Azure services to connect"

---
Step 3: Get the SQL Connection String

Open the SQL Database you created.

Go to the Connection Strings tab.

Copy the ADO.NET connection string, e.g.:

plaintext

Copy

Edit

    Server=tcp:<your-server>.database.windows.net,1433;
    Initial Catalog=InventoryManagementSystemDB;
    Persist Security Info=False;
    User ID=<your-user>;
    Password=<your-password>;
    MultipleActiveResultSets=False;
    Encrypt=True;
    TrustServerCertificate=False;
    Connection Timeout=30;

---
Step 4: Update appsettings.json in Your Project

Replace your local DB string with the Azure connection string:

json

Copy

Edit

    "ConnectionStrings": {

            "DefaultConnection": "Paste your Azure SQL connection string here"

       }

---

Step 5: Publish from Visual Studio

Right-click your ASP.NET project → Click Publish

Choose Azure App Service (Windows)

Select the App Service you created

Click Publish

---

Final Check

Visit your live app:

https://inventorymanagementsystem.azurewebsites.net

Test forms, buttons, and data saving.

Log into Azure SQL to verify data entries.
