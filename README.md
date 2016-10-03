# KspPartFinder
A little winform application to find a part in game data folder of ksp with any sort of text related to it. The concept is really simple, you just set the game data folder, then type a text, when you hit search, the application will find all the .cfg files in  game data and it's sub folders. Reading all the text inside the config, the whole thing is a simple string comparison that ignores casing to see if your text is inside the config one or not.

If the text was inside the config file, then the program adds that config to a list. At the end, if less than 5 folders where found, they will be opened and the config files with your text in them will be selected.

In the root folder of this software, there will be a simple settings.cfg file that would keep track of your inputs for the software, like the game data address, the search text, and the settings to ignore special folders.
