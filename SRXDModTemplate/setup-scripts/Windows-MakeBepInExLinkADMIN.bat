echo off
set /p bepinDir="Enter BepInEx Folder (\Spin Rhythm\BepInEx\): "
mklink /d "%~dp0..\BepInEx\" "%bepinDir%"
set /p end="Press enter to end..."