## WebStore: Your One-Stop Shop for Exquisite Fragrances

WebStore is a curated online fragrance haven, offering a delightful selection of perfumes and colognes to tantalize your senses. Explore a diverse collection and discover your perfect scent, from timeless classics to the latest niche discoveries. WebStore provides a seamless shopping experience with features to enhance your olfactory journey, while an intuitive admin panel empowers you to manage your store with ease.

### Features

* **Diverse Fragrance Collection:** Explore a wide variety of high-quality fragrances to find the perfect match for your style and personality.
* **Tiered User System:** Earn rewards and unlock exclusive benefits as you become a valued customer.
* **Seamless Shopping Experience:** Browse products, add items to your cart with ease, and checkout securely.
* **Comprehensive Admin Panel:** Manage users, orders, products, and more with a user-friendly interface.

### User Roles

WebStore implements a tiered user system, acknowledging your dedication to fragrance:

* **User (Default):** Upon registration, gain access to browsing products, making purchases, and tracking your order history.
* **Customer (Automatic upon reaching 10 Orders):** Enjoy exclusive access to special sales and promotions tailored to your fragrance preferences.
* **VIP (100 Orders or 1500 BGN+ Total Spend):** Enjoy deeper discounts on sale items compared to the Customer role.
* **Admin (Restricted Access):** Manage the entire WebStore platform, including users, orders, products, and more.


### Technology Stack

- **Backend:** C#, ASP.NET Core, Entity Framework Core (MS SQL Server)
- **Frontend:** JavaScript (JS), HTML, CSS with TailwindCSS

### Getting Started (Developers)

**Prerequisites:**

- **.NET Core SDK:** Download and install from [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download).
- **MS SQL Server:** Install MS SQL Server on your machine or use a compatible SQL database service (download options: [https://learn.microsoft.com/en-us/answers/questions/1168524/ms-sql-2019-developer-edition-download-link](https://learn.microsoft.com/en-us/answers/questions/1168524/ms-sql-2019-developer-edition-download-link)).
- **Command Prompt or Terminal:** Access the command line interface on your operating system.

**Instructions:**

1. **Clone the Repository:**

Assuming you have Git installed and configured, navigate to your desired directory in the terminal and run the following command to clone the WebStore repository:

```bash
git clone https://github.com/paunov0000/WebStore.git
```

2. **Navigate to Project Directory:**

   Use the `cd` command to change directory to the cloned repository. For instance:

   ```bash
   cd WebStore  // Replace with your actual directory name
   ```

3. **Restore Dependencies:**

   Since the project relies on external libraries, use the following command to restore them:

   ```bash
   dotnet restore
   ```

4. **Apply Database Migrations:**

   WebStore uses Entity Framework Core for database migrations. Run the following commands to create the database schema based on your models (replace with a descriptive migration name if needed):

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. **Run the Application:**

   Finally, execute the following command to start the WebStore application:

   ```bash
   dotnet run
   ```

This will launch WebStore and you should be able to access it in your web browser, typically at http://localhost:5000 (the default port may vary).

**Admin Login:**

- Username: `admin@admin.bg`
- Password: `admin123`

### Contributing

We welcome contributions to WebStore! Feel free to fork the repository and submit pull requests with your enhancements.

### License

This project is licensed under the MIT License: [https://opensource.org/license/mit](https://opensource.org/license/mit).

We hope you enjoy exploring the world of fragrances with WebStore!