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

---

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

---

<img src="images/Conda_downloads_by_OS.png" class="nb"/>

---

<img src="images/OS_choice_by_PSF_survey.png" class="nb"/>

---

<img src="images/OS_choice_by_VSCode_users.png" class="nb"/>

---

<img src="images/OS_choice_by_PyCharm_users.png" class="nb"/>

---

<img src="images/PythonOrg_downloads.png" class="nb"/>

---

<img src="images/24_million.png" class="nb"/>

---

## Python userbase 
<img src="images/community_1.png" class="nb"/>

---

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

- Get CI or collaborate (we'll get back to this)

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

- One last thing

</div>

*** 

## _One-click install from the Store_

<img src="images/store.jpeg" class="nb"/>

---

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

---

# _Windows Terminal (Preview)_

<img src="images/terminal.jpeg" class="nb"/>

---

## _Windows Terminal (Preview)_

- Multiple Tabs
- Command Prompt, PowerShell, Linux
- GPU accelerated text rendering
- glyps, emojis, ideograms, symbols, icons, ligatures
- Fully configurable and custimizable via json 
- Multiple profiles
- One-click install from the Microsoft Store
- Cascadia Code font, with ligatures (Preview)
- [Open Source at GitHub](https://github.com/Microsoft/Terminal) (MIT)

(cool video at https://aka.ms/terminal-video)

***

# Windows Subsystem for Linux 2

<img src="images/runwsl.gif" height="400" class="nb"/>

---

## WSL2 Quick Facts

<div class="fragment">

- WSL2 runs ELF64 Linux binaries on Windows

</div>
<div class="fragment">

- Windows ships a WSL2-tuned Linux kernel 

</div>
<div class="fragment">

- WSL2 runs on a lightweight utility virtual machine

</div>
<div class="fragment">

- Super fast boot, small footprint, zero configuration

</div>
<div class="fragment">

- [WSL2 and Linux kernel are Open Source](https://github.com/microsoft/WSL2-Linux-Kernel)

</div>

---

# One-click install of Linux distributions

<img src="images/store.png" height="400" class="nb"/>

***

# _Thank You!_

<br/><br/><br/><br/><br/><br/>

Nicola Iarocci<br/>
[@nicolaiarocci](https://twitter.com/nicolaiarocci)
