# autoClose

Simple tool that closes a specific process at any given time.

Requirements:
- Windows Operating System
- Understanding of 24HR time
- Understanding of process names

# Screenshot (Version 0.0.2)
<p align="center">
<img align="center" src="https://i.imgur.com/cxvaAA8.png"> <img align="center" src="https://i.imgur.com/bsjApGf.png">
</p>

# How to determine process name?
In version 0.0.2; a process list was introduced to show all running processes in a list that can be called.

[Powershell / Manual Method]
- Open powershell as administrator
- Run the following command.

In this example, I am searching for the Discord process running. Keep the * before the name.

get-process | Where-Object {$_.processname -Like "*Discord"} | select ProcessName




