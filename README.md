# autoClose

Simple tool that closes a specific process at any given time.

<img src="https://img.shields.io/github/issues/deanfx/autoClose?style=plastic">

**Requirements:**
- Windows Operating System
- Understanding of process names

# Screenshot (Version 0.0.2)
<p align="center">
<img align="center" src="https://i.imgur.com/cxvaAA8.png"> <img align="center" src="https://i.imgur.com/bsjApGf.png">
</p>

# How to determine process name?
> In version 0.0.2; a process list was introduced to show all running processes in a list that can be called.

**[Powershell / Manual Method]**
- Open powershell as administrator
- Run the following command.

In this example, I am searching for the Discord process running. Keep the * before the name.

get-process | Where-Object {$_.processname -Like "*Discord"} | select ProcessName


# Downloads (Application/Compiled)
> Version 0.0.3 - https://mega.nz/#!s0Jg0I6S!PR-Qvi6-okJc_adrdVUxZSE3Je5gXmdzdFQ8FdHfbSw

> Version 0.0.2 - https://mega.nz/#!Vto1RIiC!YvytBh5VtRFwZuytiao2SvAncWEZt7R8CkXU-CkSa_U

> Version 0.0.1 - https://mega.nz/#!o1xBESCa!hVydan27Ar2AT0xdeyeiR3DJcH60FnxdTW3Ms9q6AFU



