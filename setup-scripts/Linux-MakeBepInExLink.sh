#!/bin/bash
echo "Enter or Drag and Drop BepInEx Folder (\Spin Rhythm\BepInEx\): "
read bepinDirectory
ln -s -d "${bepinDirectory}" "../BepInEx/" 
read end