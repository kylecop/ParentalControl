# ParentalControl
This project provides a parental control environment with enough security for kids. Younger kids who do not have enough knowledge of the Windows Operating System will not know how to close the program.

Suggested windows configuration: 
- User is a standard user (not an administrator)
- Disable Task Manager
- Disable command prompt and powershell
- launch application on start up
- logon times command; net user username /times:Su-Sa,7am-8pm
- Use applocker
  a. block all web browsers
  b. block microsoft store
  c. block communication apps like email, skype, etc


The default PIN is 9999.

Current Features:
1. Windows Session Limit
2. Automatic Log Off
3. Prevent Closure of the software by a standard user. Does not work for Admin Accounts, or accounts that have access to command prompt, or task manager. Younger kids who do not have enough knowledge of the Windows Operating System will not know how to close the program.
4. Require certain software to be limited as desired, With "Coins"


