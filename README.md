Description
===========
This is a (very) simple interface for the Windows netsh command, which allows computers to create their own wireless local area network. 

FAQ
===========
What operating systems will this work on?
-----------
This program should work on every version of Windows, back until Windows 2000. Unix, Linux, OSX and others are not currently supported.
If you have any Bluetooth adapters in your computer there is a decent chance this will not work, as they have their own AdHoc networking system and disable this one (or something, I'm still confused as to how it works, but I haven't worked on this in years).

What are the system requirements?
-----------
Windows 2000 or newer, and a wireless network interface card. If you have Windows 2000 or newer, and can connect to WiFi, you're good to go.

Why do I need Administrator permissions?
-----------
This program creates a hosted network through use of Windows' netsh command.
The command requires administrator permissions, and without them, the command and program will fail.

What is "AdHoc"?
-----------
An AdHoc network is an easy to set up and launch, low maintenance network.

Why does the program renew my IP address?
-----------
Previously I was having a problem where the program would only successfully create the network about 50% of the time. After searching around a bit, running this fixed the problem.
 
Why do I have to have a password?
-----------
The netsh command requires it, so this program does too.

Why is there no exit button?
-----------
Running a network like this is technically a security hole. It should only be up while you're using it, in order to help you to remember if your network is up or not.	
If you really want to close the box while your network is up, you can close the program from the taskbar after launching your network.

Your program isn't working, or is making my computer act funny. What should I do?
-----------
E-mail me at qanazoga@gmail.com with details on your problem.

Why did you make this?
-----------
To be honest? I wanted to play [Risk of Rain](http://riskofraingame.com/) with my buddies at school.

I have great ideas and want to help with this program. How can I contact you?
-----------
E-mail me at qanazoga@gmail.com. I'm always happy to hear your opinions.

This program harmed my computer, released Satan unto the world, and gave the NSA access to every file on earth! I wanna sue you!
-----------
First, that isn't a question. Second, I hold no responsibility for whatever happens to your computer, Earth, the well being of mankind, nor anything else as result of this program. It comes with no warranty and should be used at the users own risk.
