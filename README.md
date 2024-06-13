# ProNatur-Biomarkt GmbH Solution
## Educational Material - Not Recommended for Production Use

This solution is a Windows Forms application developed in C# for managing products in a store. It uses SQL for database operations.

## Current State

The solution comprises several screens:

- `LoadingScreen.cs`: This is the initial screen displayed when the application starts. The code for this screen is not provided in the current context.
- `MainMenuScreen.cs`: This is the application's main menu. It features two buttons: one for managing products (`btnProducts`) and another for handling billing (`btnBill`).
- `ProductsScreen.cs`: This screen is used for managing products. It includes various controls for entering product details (name, brand, category, price), buttons for performing operations (save, edit, clear, delete), and a data grid view (`productsDGV`) for displaying the list of products. The `ShowProducts` method retrieves and displays all products from the database. The `btnProductSave_Click` method handles the click event of the save button to save the product details. The `ClearAllFields` method clears all text boxes and combo boxes on the form.

## Additional Information

The solution uses a SQL database for storing product data. The database connection and operations are performed in the `ProductsScreen.cs` file. SQL queries are written as strings and executed using the `SqlCommand` class.

Please note that this solution is currently under development and may contain bugs or incomplete features. It is intended for educational purposes and is not recommended for production use.
