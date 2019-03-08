# EpicService_AutoRestart_AutoUpdater_Controller
The program I wrote about in a story I posted in r/prorevenge

I'm keeping the code here. open source, free, and available to anyone.

There are 4 programs.


1. Epic Service (project t): the main program that deals with killing programs
2. Controller (project to): controls the main program. lets you disable the programs with one key.
3. Automatic Restarter: detects if the epic service dies and reopens it.
4. endlessly searches for an update, and when one is found, close both programs, update, and start them back up.

very simple. very cool. 

I've decided to comment on everything that may be confusing to underantd.


One thing to note before you install, later versions will be more customizable. so some steps will be taken out. and it will be alot less confusing than it currently is.


INSTALLATION INSTRUCTIONS:

1. apache web server:
    download xampp from this link:
     https://www.apachefriends.org/index.html
     make sure you only have apache and php checked. find a folder to store the local files
    Let it install the server.

1b. Find your local IP:
    if you open CMD (by typing CMD into the start menu). a box will show up. what you want to do, is type "ipconfig".
    if you use comcast, you'll see this "IPv4 Address" in there. note that down too, it's very important. 

2. settings.txt

    either configure, compile and use the controller. or manually enter "Kill Them!" as the first line of your text file to activate the software.
    every line after the first will be the name of the exe. notepad.exe would be "notepad". and then to enable the bottom program, just press enter again at the end.
    to disable the program just change "Kill Them!" to anything else.
    save it in your xampp htdocs folder. (xampp has a button called explorer on the right). click that explorer button and navigate to the htdocs folder. note the path where you are somewhere. mines (C:\Games\x\htdocs).

3. delete everything from the htdocs folder. 
    trust me, youll be fine without those files. save the settings.txt to the place you noted earlier.
    the file will show up in that folder.

3b. open your web browser and type your local ip address followed by /settings.txt

4. open the "Project T.sln" stored in this projects folder with your version of Visual Studio.

5. solution explorer open Project T's Program.cs script. at the top you'll notice a string called data site with a @"". Please enter your local ipv4 into that. Example: "10.0.0.6/settings.txt"

6. set the build mode from debug, to release and hit shift-f6. it will compile into the "project t/bin/release/" folder. drag the exe into it's own folder.

if you open a bunch of notepads, edit the settings.txt to include notepad like in the example.txt
and start the program, you'll see those notepads all close at once. if that happened, youre almost done.

kill epicservice.exe with taskmanager.

7. enable the autorestarter
    open t-series's program files, and press shift-f6 once more. just like with the main program, it'll compile into "tseries/bin/release/" folder.
    the autorestarter needs to be in the same folder as the main program. so put it in that folder. with both programs in the folder, package it up and send it to sons computer. where you will unpack it and create a shortcut to place in your start up folder. 
    the start up folder is usually located at: "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp"
    launch the shortcut and close everything.

now you can kill the programs you wanted to. go back to your site and add as many game's exes as you can think of. if your unsure what you should type, ask google and maybe it'll give you the game's exe file. like chrome.exe.

remember to start the program you need "Kill Them!" as the first line, and all the programs on every line below it. dont forget to hit enter at the end.

Later versions of the software will contain the source for the controller and updater. however, since they are the more confusing two, I'll postpone their release until later. this will be done in order to finalize their code and make them less dependant.

Hope you enjoy the program. - Zak Kaioken