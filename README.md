# SQLTestingWFA
Testing working with SQL Server using a Windows Forms Application so I can put it in a GUI.

I'm trying to write an application using Forms to connect to a database and populate tables with believable random data.

Current features:
* Connect to SQL Server (tested w/ localhost only)
* Select database and table from dropdown lists
* View column names and datatypes for currently select table

Planned features:
* Populate string fields from a user selected list of strings, i.e. nouns
* Generate addresses with random street numbers and street names pulled from a list (zip codes, states, cities, etc.)
* Generate phonenumbers to fit a desired format
* Generate dates within a specified range
* Generate integer and double numbers within a specified range (perhaps with a bias or frequency curve)

Classes

MainForm
* SQLConnDisconn - button - the (dis)connect button for the main dialog
* Connstatus - label - Display of the database connection status (Indicates 'Connected' only after successful test connection)
* CurrentDatabase - ComboBox - Dropdown list of all databases on the server? (Permissions may affect this... idk.)
* CurrentTable - ComboBox - Dropdown list of all tables in the selected database; click to select
* dataGridView1 - DataGridView - Information about currently selected table

SQLConnectDialog
* UserIdTextBox
* PasswordTextBox
* ServerTextBox
* TrustedConnectionCheck - CheckBox
* Connect - Button - calls SqlConnect() on MainForm to test the connection and closes the dialog
