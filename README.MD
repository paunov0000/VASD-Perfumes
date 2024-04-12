## WebStore: Your One-Stop Shop for Exquisite Fragrances

WebStore is a curated online fragrance haven, offering a delightful selection of perfumes and colognes to tantalize your senses. Explore a diverse collection and discover your perfect scent, from timeless classics to the latest niche discoveries. WebStore provides a seamless shopping experience with features to enhance your olfactory journey, while an intuitive admin panel empowers you to manage your store with ease.

### Features

- **Diverse Fragrance Collection:** Explore a wide variety of high-quality fragrances to find the perfect match for your style and personality.
- **Tiered User System:** Earn rewards and unlock exclusive benefits as you become a valued customer.
- **Seamless Shopping Experience:** Browse products, add items to your cart with ease, and checkout securely.
- **Comprehensive Admin Panel:** Manage users, orders, products, and more with a user-friendly interface.

### User Roles

WebStore implements a tiered user system, acknowledging your dedication to fragrance:

- **User (Default):** Upon registration, gain access to browsing products, making purchases, and tracking your order history.
- **Customer (Automatic upon reaching 10 Orders):** Enjoy exclusive access to special sales and promotions tailored to your fragrance preferences.
- **VIP (100 Orders or 1500 BGN+ Total Spend):** Enjoy deeper discounts on sale items compared to the Customer role.
- **Admin (Restricted Access):** Manage the entire WebStore platform, including users, orders, products, and more.

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

## Images

- ### Default Area:

  - #### Home/Index:

    !["index.png"](https://private-user-images.githubusercontent.com/98036540/321810211-41fa33fd-f75a-419f-bae8-d24879f3c429.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MTI4NzgyMzcsIm5iZiI6MTcxMjg3NzkzNywicGF0aCI6Ii85ODAzNjU0MC8zMjE4MTAyMTEtNDFmYTMzZmQtZjc1YS00MTlmLWJhZTgtZDI0ODc5ZjNjNDI5LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDA0MTElMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQwNDExVDIzMjUzN1omWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTlhNWJhMDA3ZjAwODE0OTM0ZjY0MDk1YjI0YjllNDU3Y2UxOTM4N2IwM2ZjMzI4Nzg1MWFkMDc2OGE4OWEyNzQmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.-S36gNLYEcbIN2UzgHD6k21PmYA1s-c8oKosYNG8nY4)

  - #### Default area footer:

    !["index-footer.png"](https://private-user-images.githubusercontent.com/98036540/321810213-e76cc53c-2e79-4010-9e52-4f23c77d7ff2.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MTI4Nzg2MDYsIm5iZiI6MTcxMjg3ODMwNiwicGF0aCI6Ii85ODAzNjU0MC8zMjE4MTAyMTMtZTc2Y2M1M2MtMmU3OS00MDEwLTllNTItNGYyM2M3N2Q3ZmYyLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDA0MTElMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQwNDExVDIzMzE0NlomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTk4NDMzMGUxMDFlNDQ5MjdkZDZhNmMxMWM1MTA2NjgzMGYyZWQ5NmU5OGNmZDU3YWU3ZDQyZjgxOWY5NTdhMWEmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.6071oxAaPMz56-n67Sa2F09yHkf_2foBgDOScP9knDw)

  - #### Product/Details (WIP):

    !["product-details-wip"](https://private-user-images.githubusercontent.com/98036540/321810225-bdc62272-3bff-4e8d-a8d2-d6d7f147e8dd.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MTI4Nzk5MzEsIm5iZiI6MTcxMjg3OTYzMSwicGF0aCI6Ii85ODAzNjU0MC8zMjE4MTAyMjUtYmRjNjIyNzItM2JmZi00ZThkLWE4ZDItZDZkN2YxNDdlOGRkLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDA0MTElMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQwNDExVDIzNTM1MVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTJhMzc4NDBkN2IzZjBhYTc0NzI4MWZjMjdhMzhmZDY1OTUxMTg0OTkyYjg1Y2Y4NGI2MTBjNTEwNzI5ZTk5OWYmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.YoxqugNsIa8rsZ0iimHtBidjuGI4jWqY3E6q3BRbnFE)

  - #### Account/Login:

    !["sign-in.png"](https://private-user-images.githubusercontent.com/98036540/321810230-12d09602-1823-4471-8128-a58583c30a68.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MTI4NzkxNDYsIm5iZiI6MTcxMjg3ODg0NiwicGF0aCI6Ii85ODAzNjU0MC8zMjE4MTAyMzAtMTJkMDk2MDItMTgyMy00NDcxLTgxMjgtYTU4NTgzYzMwYTY4LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDA0MTElMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQwNDExVDIzNDA0NlomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTU5OGIyMmQyMzhjOThiYzcxZTU1N2YwMjEwOWQyYjI0YTBlOGJiNTAxZTNmMGI5MTM4ZDM1Njc2NDMxNTRjOTkmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.R-ZpvDgfgZ13Xb_1wgRkXxxRgyU1lctsf6gob0BxkeU)

    - ##### Account/Login error:
      !["sign-in-error.png"](https://private-user-images.githubusercontent.com/98036540/321810233-da5556f6-2862-4142-a699-3b8d4e7572a8.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MTI4NzkxNDYsIm5iZiI6MTcxMjg3ODg0NiwicGF0aCI6Ii85ODAzNjU0MC8zMjE4MTAyMzMtZGE1NTU2ZjYtMjg2Mi00MTQyLWE2OTktM2I4ZDRlNzU3MmE4LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDA0MTElMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQwNDExVDIzNDA0NlomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTE2YzQ3NjY1NWVkODNlYTRlYzg1ZTYyZjEwODlkYzgwZjYzNDMwYTU2MWI5MWE3MTNkM2I5ZTZlYzY1NGYyZDAmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.eNKnz4alDnH3lpItQt52dy88REghTcKo3mnWro0Tjb4)

  - #### Account/Register:
    !["sign-up.png"](https://private-user-images.githubusercontent.com/98036540/321810239-229a4fb2-968d-4b4b-8a4d-a926f654ac4a.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MTI4NzkxNDYsIm5iZiI6MTcxMjg3ODg0NiwicGF0aCI6Ii85ODAzNjU0MC8zMjE4MTAyMzktMjI5YTRmYjItOTY4ZC00YjRiLThhNGQtYTkyNmY2NTRhYzRhLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDA0MTElMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQwNDExVDIzNDA0NlomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTc0ODM3Y2VlNjVhMWNhZDBjYWYzYTE1ZDI1MjY1NTRhNWIwYzMyMWQ4MDJhMWUzZGZhMDhiNTIwNzdiZmUzMGYmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.GZD43VqbhYJxORMIkz1zlGW0GYARnYcLT9xz2ZMz4gQ)

- ### Admin Area:
  - #### Product/Index:
    !["admin-product.png"](https://private-user-images.githubusercontent.com/98036540/321810192-7ff60596-3d81-4671-8a25-81e6f9343c37.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MTI4Nzk5MzEsIm5iZiI6MTcxMjg3OTYzMSwicGF0aCI6Ii85ODAzNjU0MC8zMjE4MTAxOTItN2ZmNjA1OTYtM2Q4MS00NjcxLThhMjUtODFlNmY5MzQzYzM3LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDA0MTElMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQwNDExVDIzNTM1MVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPWMyZDRmMmE4ZWI3ODgxNDg1YTdiOTliMGVjNTZmOGY1ZGViZjlmYTdlY2I0YWJiYmU3M2NmZDdjNzc1ZDZjMTUmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.hyoJyYGVbTLt6KDj0iYNs2SOVecYKdmhx_FXbSUPBAU)
  - #### User/Index:
    !["admin-user.png"](https://private-user-images.githubusercontent.com/98036540/321810199-d4d9982f-dc8c-489c-adec-d13f407eb2f4.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MTI4Nzk5MzEsIm5iZiI6MTcxMjg3OTYzMSwicGF0aCI6Ii85ODAzNjU0MC8zMjE4MTAxOTktZDRkOTk4MmYtZGM4Yy00ODljLWFkZWMtZDEzZjQwN2ViMmY0LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDA0MTElMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQwNDExVDIzNTM1MVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPWNjYjZmYzliMWU3ZTE0MTJiMjA4NDMwZTQyMmVjODUwMzE5Njk1YThlNzhlMzY4Y2IzZWY3MjdmZjYzYmRkMTUmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.sohOFVyjaC47rELPk1YmVsQdIxY1PBrgnuafAqTzZB8)
