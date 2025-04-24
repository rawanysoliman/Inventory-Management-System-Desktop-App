# 📦 Warehouse Inventory Management System

A robust inventory management desktop application developed with **C#**, **Entity Framework Core**, and **Windows Forms**, designed to efficiently manage warehouses, products, and all inventory operations including supply, release, and transfer activities.

---

## 📸 Application Screenshots

### 🖥️ Dashboard
![Dashboard](Screenshots/Dashboard.png)

### ➕ Add Product
![Add Product](Screenshots/add_product.png)

### 📊 Generating a Report for Warehouse
![Warehouse Report](Screenshots/warehouse_report.png)

### 🔁 Adding a Transfer Permission
![Transfer Permission](Screenshots/Trsnsfer_Permission.png)

---

## 🚀 Features

### **Warehouse Management**
- Add, update, delete, and view warehouses.
- Track warehouse-specific inventory and manage stock levels.
- View supply and release permissions for each warehouse.

### **Product Management**
- Add, update, delete, and view products.
- Assign products to categories and manage their pricing.
- Track product stock across multiple warehouses.

### **Category Management**
- Add, update, delete, and view product categories.
- Organize products into categories for better inventory management.

### **Supplier Management**
- Add, update, delete, and view suppliers.
- Manage supplier details, including location, phone number, email, and fax.

### **Reports**
The system provides the ability to generate detailed reports for better decision-making:
1. **Warehouse Report**:
   - View details of a specific warehouse, including supply and release permissions.
   - Filter by a time period to analyze historical data.
   - View current stock levels for all products in the warehouse.

2. **Product Report**:
   - View details of a specific product, including its stock across warehouses.
   - Analyze supply and release permissions for the product.
   - Filter by time period and specific warehouses.

3. **Product Movement Report**:
   - Track the movement of products (supply, release, and transfer) across warehouses.
   - Filter by a time period and specific warehouses.
   - View detailed logs of product movements.

4. **Expired Products Report**:
   - Identify products that have been in storage for more than a specified number of days.
   - Helps in managing inventory turnover and reducing waste.

5. **Expiring Soon Report**:
   - Identify products that are nearing their expiration date within a specified number of days.
   - Helps in planning sales or transfers to avoid losses.

---

## Technologies Used

- **.NET 9**
- **C# 13.0**
- **Windows Forms** for the user interface.
- **Entity Framework Core** for database operations.
- **SQL Server** for data storage.

---

## System Requirements

- **Operating System**: Windows 10 or later.
- **Development Environment**: Visual Studio 2022 or later.
- **Database**: SQL Server 2019 or later.
- **.NET SDK**: .NET 9 SDK.

---

## Prerequisites

1. Install **Visual Studio 2022** with the following workloads:
   - .NET Desktop Development
   - Data Storage and Processing
2. Install **SQL Server** and ensure it is running.
3. Install **.NET 9 SDK**.

---

## Installation

1. Clone the repository:
   git clone https://github.com/your-username/InventoryManagementSystem.git
2. Open the solution in Visual Studio.
3. Update the database connection string in the `myContext` class:
   optionsBuilder.UseSqlServer("Your_Connection_String");
4. Open the **Package Manager Console** and run the following command to apply migrations:

Update-Database
5. Build and run the application.

---

## User Interface

The application features a user-friendly interface with the following modules:

### **Warehouse Management**
- A DataGridView displays all warehouses with options to add, update, or delete warehouses.
- Textboxes and buttons allow for easy data entry and modification.

### **Product Management**
- Manage products with a DataGridView showing product details.
- Dropdowns for category selection and textboxes for product details.
- Buttons for adding, updating, and deleting products.

### **Category Management**
- A simple interface for managing product categories.
- Add, update, or delete categories with ease.

### **Supplier Management**
- Manage supplier details with a DataGridView and input fields.
- Add, update, or delete supplier information.

### **Reports**
- Generate reports directly from the application.
- Reports are displayed in the console or can be exported (future enhancement).

---

## Database Schema

The database schema is managed using Entity Framework Core and includes the following key entities:

1. **Warehouse**:
   - Tracks warehouse details and inventory.
   - Relationships:
     - `WhProductsBySupplier`: Tracks stock for each product in the warehouse.
     - `SupplyPermission`: Tracks supply permissions for the warehouse.
     - `ReleasePermission`: Tracks release permissions for the warehouse.

2. **Products**:
   - Tracks product details, including name, price, and category.
   - Relationships:
     - `Category`: Each product belongs to a category.
     - `WhProductsBySupplier`: Tracks stock for each product in warehouses.
     - `SupplyPermProducts`: Tracks supply permissions for the product.
     - `ReleasePermProducts`: Tracks release permissions for the product.

3. **Category**:
   - Organizes products into categories.
   - Relationships:
     - `Products`: A category can have multiple products.

4. **Supplier**:
   - Tracks supplier details.
   - Relationships:
     - `SupplyPermission`: Tracks supply permissions for the supplier.
     - `WhProductsBySupplier`: Tracks stock supplied by the supplier.

5. **SupplyPermission**:
   - Tracks supply transactions.
   - Relationships:
     - `SupplyPermProducts`: Tracks products supplied in each transaction.

6. **ReleasePermission**:
   - Tracks release transactions.
   - Relationships:
     - `ReleasePermProducts`: Tracks products released in each transaction.

7. **TransferPermission**:
   - Tracks product transfers between warehouses.
   - Relationships:
     - `TransferProductsBySuppliers`: Tracks products transferred in each transaction.

---

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your changes.

---

## License

This project is licensed under the [MIT License](LICENSE).

---

## Contact

For any questions or feedback, feel free to reach out:

- **Email**: rawanysoliman@gmail.com
- **GitHub**: [your-username](https://github.com/rawanysoliman)
