- title : Python on Windows
- description : The State of the Art of Developing with Python on Windows
- author : Nicola Iarocci
- theme : simple
- transition : none

***

# _Python on Windows<br/><span style="font-weight:300">State of the Art</span>_

<br/><br/><br/><br/><br/><br/>

Nicola Iarocci<br/>
[@nicolaiarocci](https://twitter.com/nicolaiarocci)

***

# Question

How many of you in this room are on Windows?
<div class="fragment">

_I am not surprised_

</div>

***

# _The Goals of this talk_

## Quite ambitious ones

<div class="fragment">

_1. Awareness of Windows relevance for Python_

</div>
<div class="fragment">

_2. Make your code "just work" on Windows_

</div>
<div class="fragment">

_3. Wonders of Python development on Windows_

</div>
<div class="fragment">

_(Not kidding about #3)_

</div>

***

<img src="images/PyPI_downloads_by_OS.png" class="nb"/>

***

<img src="images/Conda_downloads_by_OS.png" class="nb"/>

***

<img src="images/OS_choice_by_PSF_survey.png" class="nb"/>

***

<img src="images/OS_choice_by_VSCode_users.png" class="nb"/>

***

<img src="images/OS_choice_by_PyCharm_users.png" class="nb"/>

***

<img src="images/PythonOrg_downloads.png" class="nb"/>

***

<img src="images/24_million.png" class="nb"/>

***

## Python userbase 
<img src="images/community_1.png" class="nb"/>

***

## Python userbase (our perception)
<img src="images/community_2.png" class="nb"/>

***

## Make sure your libs "just work" on Windows
<div class="fragment">

- Make sure `-m` works on your project

</div>
<div class="fragment">

- Use `pathlib.path` to handle paths

</div>
<div class="fragment">

- Adopt `appdirs` to store user and configuration data

</div>
<div class="fragment">

- Use `str` and let Python handle OS conversions.
  Do your own IO stream conversions

</div>
<div class="fragment">

- Get CI, collaborate, or...

</div>

(more info at https://youtu.be/uoI57uMdDD4)

***

## _Python development <span style="font-weight:300">on Windows</span>_

<div class="fragment">

- Python tooling has been rapidly evolving

</div>
<div class="fragment">

- One-click install from the Microsoft Store

</div>
<div class="fragment">

- Visual Studio has great Python support

</div>
<div class="fragment">

- VSCode+Python extension works on Windows too

</div>
<div class="fragment">

- A brand new Windows Terminal

</div>
<div class="fragment">

- Windows Subsystem for Linux 2

</div>

*** 

## _One-click install from the Store_

<img src="images/store.jpeg" class="nb"/>

*** 

## _Visual Studio_

- Python install from VS Installer
- Package Management
- Virtual Environments
- IntelliSense and code analysis
- Interactive debugging (remote too)
- Unit Tests
- Templates (Django, Flask, PyGame, etc.)
- Code Imports
- Jupyter support
- REPL
- Community edition is free 

_PyCharm also works great on Windows._

*** 

# _Windows Terminal (Preview)_

<img src="images/terminal.jpeg" class="nb"/>

***

## _Windows Terminal (Preview)_

- Multiple Tabs
- Command Prompt, PowerShell, Linux
- GPU accelerated text rendering
- glyps, emojis, ideograms, symbols, icons, ligatures
- Fully configurable and custimizable via json 
- Multiple profiles
- Cascadia Code font, with ligatures (Preview)
- Terminal is Open Source ([link](https://github.com/Microsoft/Terminal)) 

(cool video at https://aka.ms/terminal-video)

***

# Windows Subsystem for Linux 2

<img src="images/runwsl.gif" height="400" class="nb"/>

***

# _WSL2 Quick Facts_
## Runs ELF64 Linux binaries on Windows

<img src="images/hello.png" height="400" class="nb"/>

***

# _WSL2 Quick Facts_
## Windows ships with a Linux kernel

<img src="images/kali.png" height="400" class="nb"/>

***

# _WSL2 Quick Facts_
## 
<div class="fragment">

- WSL2 runs on a **lightweight** utility virtual machine

</div>
<div class="fragment">

- Super **fast boot**, small footprint, **zero configuration**

</div>
<div class="fragment">

- Both WSL2 and Linux kernel are Open Source ([link](https://github.com/microsoft/WSL2-Linux-Kernel))

</div>

***

# _One-click install of Linux distributions_

<img src="images/store.png" height="400" class="nb"/>

***

# _DEMO #1_
## _LINUX ON WINDOWS, WITH TERMINAL_

***

# _Code + Remote + Linux_
## _What are we looking at?_

<img src="images/code+wsl1.png" class="nb"/>

***

# _Code + Remote + Linux_
## _Windows-side Code, connected to Linux_

<img src="images/code+wsl2.png" class="nb"/>

***

# _Code + Remote + Linux_
## _Courtesy of Remote extension_

<img src="images/code+wsl3.png" class="nb"/>

***

# _Code + Remote + Linux_
## _Extensions work across boundaries_

<img src="images/code+wsl4.png" class="nb"/>

***

# _DEMO #2_
## _Code + Remote + Linux_

***

# _WSL2 IS IN PREVIEW_
## _JOIN THE INSIDER PROGRAM (Fast ring)_

<img src="images/insiderprogram.png" class="nb"/>

***
# _You also need to know_
## _So you can avoid pain_

- BIOS virtualization must be active
- Virtual Machine Platform feature must be active
- WSL feature must be active
- distros will be on WSL1 once installed
- status: `wsl --list --verbose` _*_
- switch to v2: `wsl --set-version Ubuntu 2` _*_
- set v2 as default: `wsl --set-default-version 2` _*_

_(*) in PowerShell, as admin_

***

## _Suggested reading_ 

<img src="images/reading.png" class="nb"/>

Smashing Magazine ([link](https://www.smashingmagazine.com/2019/09/moving-javascript-development-bash-windows/))

***

# _Thank You!_

<br/><br/><br/><br/><br/><br/>

Nicola Iarocci<br/>
[@nicolaiarocci](https://twitter.com/nicolaiarocci)
