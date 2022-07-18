# Rosewinery
Rosewinery wines inventory tracking tool

This console application is intended to help the user to track the inventory of 5 sorts of wines as an owner of Rosewinery boutique. The user can add a wine, select to review a wine by name, pull the inventory status and Exit. The wines list is stored in json file that can be retrieved by Select option that pulls a list of current inventory. For any invalid choice, the error is logged to Errors.txt file 

Feature requirements implemented in this project:
1) Implement a "master loop" console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program.
2) Create a list, populate it with several values, retrieve at least one value and use it in your program.
3) Read data from an external file, JSON and use that data in your application.
4) Implement a log that records errors, invalid inputs or other and writes them to a text file.

Description of functionality:
Rosewinery inventory list includes 5 wines. Each wine has 5 detail fields:
- Wine Name;
- Wine Description;
- Quantity;
- Supplier Name;
- Price;
Originally I was going to list 9 wines, but for the scope of this project, I decided to decrease the number to 5 wines to make it more readable.

Rosewinery inventory Main menu:
1  Add wine to inventory file
2  Select wine from inventory file
3  Inventory current status
4  Exit
It is expected a user will choose a number of the menu option (from 1 to 4).
After the number is entered the program writes the line "You have chosen menu option #3" for example. 
In next line it shows the results of that option.

Functionality of each Main menu option:
Option 1 Add wine to inventory file:
When #1 option is chosen, the app shows the instructions to enter these fields:
- Wine Name
- Wine Description
- Quantity
- Supplier Name
- Price
After the user enters all these fields, the app cycles to show Main menu options again. 
At this point, if the user chooses option #3 (Inventory current status), the app shows the status of all available wines including the wine the user just added.

Option 2 Select wine from inventory file:
When #2 option is chosen, the app asks to enter the wine name. 
For the scope of this project I assume, only a wine from the current inventory might be chosen. Also, I decided not to do the Remove feature. 
Current inventory wines list (Please copy/paste the wine name to test this option):
Malbec 2016
Syrah 2006
Chardonnay 2016
Cabernet Sauvignon 2016
Cabernet Sauvignon 2014

After the user enters the wine name and clicks Enter, the app pulls and shows 5 detail fields of that wine to review.

Option 3 Inventory current status:
When #3 option is chosen, the app shows the list of all wines currently in the inventory (with all detail fields included).

Option 4 Exit:
When #4 option is chosen, the program exits.

Errors log:
When the user enters anything except Main menu options number choices,
The program writes
"Please enter a valid menu choice: 1,2,3 or 4
An error is logged"
During one run the app logs all errors to Error.txt file. After the terminal is closed and for each next run, the app clears the errors log and creates a new one. 