# 📦 Warehouse Inventory Management System

A robust inventory management desktop application developed with **C#**, **Entity Framework Core**, and **Windows Forms**, designed to efficiently manage warehouses, products, and all inventory operations including supply, release, and transfer activities.

---

## 💽 Application Screenshots
### 📸 Dashboard 
![Dashboard](Screenshots/dashboard.png)
### 📸 Add Product 
![Add Product](Screenshots/add_product.png)
### 📸 Generating a Report For WArehouse 
![Warehouse Report](Screenshots/warehouse_report.png)
### 📸 Adding a Transfer Permission 
![Trsnsfer Permission](Screenshots/Trsnsfer_Permission.png)

```

---

## 🚀 Features

### 🔹 Warehouse Management
- Add, edit, and delete warehouse details
- View a centralized list of all warehouses

### 🔹 Product Management
- Add, edit, and manage products with supplier associations
- Track stock levels per warehouse and per supplier

### 🔹 Supply & Release Permissions
- Issue supply permissions to warehouses from suppliers
- Handle product releases from warehouses to customers
- Filter permissions by date range

### 🔹 Transfer Operations
- Transfer products between warehouses
- View and manage all transfer transactions

### 🔹 Reports Module
Generate insightful reports including:

- **Warehouse Report**: View stock, supply, and release history of a specific warehouse
- **Product Report**: See item movement and availability across warehouses
- **Product Movement Report**: Analyze all inventory movement (supply, release, transfer) in a time period
- **Expired Products Report**: Track items that exceeded their shelf life
- **Expiring Soon Report**: Monitor products approaching expiration

> All reports support optional filtering (date range, warehouse ID) and are displayed using intuitive DataGridViews.

---

## 🛠️ Technologies Used

- **C# .NET Framework**
- **Windows Forms**
- **Entity Framework Core (Code First)**
- **SQL Server**
- **LINQ**


---

## 📁 Project Structure

```
InventoryManagementSystem/
│
├── Entities/               # Database models
├── Services/               # Business logic and report generation
├── context/                # EF Core DBContext
├── UserControls/           # Modular UI components (Reports, Management screens)
├── Forms/                  # Main application forms
└── Program.cs              # App entry point
```

---

## ✅ Prerequisites

- Visual Studio 2019/2022
- .NET Framework 4.7 or higher
- SQL Server (LocalDB or Full Edition)

---

## 🔧 Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/rawanysoliman/inventory-management-system.git
   ```

2. Open the solution in Visual Studio

3. Update your connection string in `myContext.cs`

4. Apply Migrations:
   ```
   Update-Database
   ```

5. Run the application

---

## ✨ Future Enhancements

- Export reports to PDF/Excel
- Add user authentication with roles
- Enable cloud database support
- Implement unit testing

---

## 📬 Contact

For any inquiries or feedback, feel free to contact me at [your-email@example.com] or visit [LinkedIn Profile].

