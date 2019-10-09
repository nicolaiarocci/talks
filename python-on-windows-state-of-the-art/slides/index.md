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

- One-click install from the Windows Store

</div>
<div class="fragment">

- Visual Studio (all editions) full support for Python

</div>
<div class="fragment">

- Code+Python extension works seamlessly 

</div>
<div class="fragment">

- Windows Subsystem for Linux (oh, the coolness)

</div>
<div class="fragment">

- A brand new Windows Terminal

</div>

*** 

## _One-click install from the Store_

<img src="images/store.jpeg" class="nb"/>

***

## _Visual Studio_

- Install Python from the VS Installer
- Package Management
- Virtual Environments
- IntelliSense and code analysis
- Interactive debugging (remote too)
- Unit Tests
- REPL
- Templates (Django, Flask, PyGame, etc.)
- Code Imports
- Jupyter, etc.
- Community edition is free and open source

_PyCharm also works great on Windows._

***

# _Thank You!_

<br/><br/><br/><br/><br/><br/>

Nicola Iarocci<br/>
[@nicolaiarocci](https://twitter.com/nicolaiarocci)
