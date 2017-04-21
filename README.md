# SimpleWindowsSessionTimer
This is a simple tool to limit the amount of time that a user can be logged on to a session. I designed it for Public Access computers that belong to a client.

## How to use
This application is very simple. To download it ready to go, you'll want everything in the bin/Release folder. Place all of the contents of the relase folder
in a folder on your pc (C:\Timer for example). Then, open SessionTimer2.exe.config and modify the minutes value to the desired number of minutes for you session.

Edit the quitpassword value to your desired quit password. Now, go to the Windows startup folder for the user who's time you want to limit and create a shortcut to SessionTimer2.exe.

**Note:** You could easily use a network share and startup script as well.**

Now, every time the user logs in, the session timer will open. It cannot be closed by the GUI without the proper quit password.

**Note: The app can be closed from the task manager which would circumvent the time limit. I recommend that you use this app in place with other restrictions (like blocking the task manager and command prompt).**

The app will display a warning when two minutes remain in the session. When the time is up, the app will use the Windows API to create a forced logoff.
