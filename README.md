# Check Authors #

CheckAuthors is a project written ic C#.
The goal of this project is to look fail AUTHORS.

### What is an AUTHORS? ##

* When studying in Epita, you have to write a file without extension called AUTHORS
* This file contains your login if the project is done alone
* If it is a groupe project, you have to put the leader's login above all.
* All AUTHORS file must end with only one line feed and matching the following regular expression: __^* login_x$__

### Why this project? ###

This project is designed for ACDCs as they are supposed to check whether their students have failed
their AUTHORS or not. This project allows them to check AUTHORS faster than doing it by hand.

### How it works? ###

This project is written in C# as ACDCs teach C# to first year students, so in a Windows environment.
You have to write a list of login containing only one login per line without '*' at the beginning.
When opening CheckAuthors, you have to:

* Click on ***Load AUTHORS*** and specify your file containing all logins
* Click on ***Select Directories*** and specify the directory of all projects.
* Wait for the results. If there are still logins remaining in the list, they have failed their AUTHORS.

This project is not efficient when checking group of projects as it is not possible to give it a leader name.