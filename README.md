# ProNatur-Biomarkt GmbH Solution
## learning material, I don't recommend using it productive.

This solution is a Windows Forms application for managing products in a store. The application is written in C# and uses SQL for database operations.

## Current State

The solution consists of several screens:

- `LoadingScreen.cs`: This is the initial screen that is displayed when the application starts. The code for this screen is currently not provided.
- `MainMenuScreen.cs`: This is the main menu of the application. It contains two buttons: one for managing products (`btnProducts`) and another for billing (`btnBill`).
- `ProductsScreen.cs`: This screen is used for managing products. It contains various controls for entering product details (name, brand, category, price), buttons for performing operations (save, edit, clear, delete), and a data grid view for displaying the list of products (`productsDGV`). The screen retrieves and displays all products from the database in the `ShowProducts` method. It validates the input fields in the `ValidateInput` method. The `btnProductSave_Click` method handles the click event of the save button to save the product details. The `ClearAllFields` method clears all text boxes and combo boxes on the form.

## Additional Information

The solution uses a SQL database for storing product data. The database connection and operations are performed in the `ProductsScreen.cs` file. The SQL queries are written as strings and executed using the `SqlCommand` class.

Please note that the solution is currently in development and may contain bugs or incomplete features.
