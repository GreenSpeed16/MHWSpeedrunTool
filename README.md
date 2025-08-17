# Speedrun Tool for Monster Hunter World: Iceborne.
A program to allow a more user-friendly way to fix track RNG for Monster Hunter World speedrunning.

## Setup
The application will attempt to locate your Monster Hunter World install folder automatically. If it fails, you will be asked to manually enter it.
If your install location changes for any reason, you can update the program's stored path via either the "Locate MHW Folder" to have the program attempt to automatically locate it, or the "Input MHW Folder" button if you want to manually input your new folder path.

![image](https://github.com/user-attachments/assets/a86a9a94-26cb-473a-a4db-fc11a41fc286)

## Usage
For any monster that you want to fix the track RNG for, simply select the pattern you want from the appropriate dropdown, then click "Load to NativePC" once you've selected all the patterns you want.

![image](https://github.com/user-attachments/assets/a135d365-32f7-450b-be4c-56a5b342b593)

Currently, the program does not save the track patterns you've loaded on restart. However, when you load a set of patterns they will stay loaded in your `nativePC` folder until the next time you press "Load to NativePC", so once you load the patterns you want once, you no longer need to use this program unless you want to change them.

## Save Management

As of version 2.0, MHWSpeedrunTool now has the ability to manage save backups for both Monster Hunter: World and Monster Hunter Wilds. On startup, your current save file will be backed up as "Main" assuming the game is installed on your computer *and* Steam is running.

Note: The program will load/backup the save data of the currently active Steam user, so no save management functionality will work if Steam is not running. It will work if Steam is open and in offline mode however.

To create a new backup, press the "Backup Current Save" button.

To load a backup, press the "Load Selected Save" button while the backup you want to load is selected in the list. If you try to load a backup while on your main save file, you will be prompted to re-backup your main save so you don't lose any progress.

Saves can be reordered via drag/drop in the list, or can be manually re-ordered using a text editor in the program's `appSettings.json` file, found at `AppData/Roaming/MHWSpeedrunTool` on your PC.

If there is ever a desync between the physical backed up save files and the save list in the UI (most likely caused by manually placing a save data backup in the program's `AppData` folder), it will be rectified on startup and you will be notified of the saves that changed.

### Transfer From Old Save Manager

The "Transfer From Old Manager" button allows you to transfer all save backups **including your main save** from the old version of the save manager for Monster Hunter: World. The old save manager must be open for this button to work, though you can also provide it the path to the old save manager instead if it is not detected as running.

## Additional Credit

- Fennikko for help building out save management.
- AsteriskAmpersand for figuring out how to fix track RNG.
