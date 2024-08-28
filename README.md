<h1>XML Extractor</h1>

This repo's history begins with a snapshot of Scumbumbo's XML Extractor as maintained by LittleMsSam taken from her 30 May 2024 revision.
This repo *is not* authoritative, as I am not the designated maintainer of XML Extractor.
The original source listed below is authoritative, as it is where LittleMsSam uploads her authorized updates to XML Extractor as its designated maintainer.

**If you need to use XML Extractor as a mod creator for The Sims 4, *do not use this repo*. Go get LittleMsSam's official version available at the link below.**

Original source: https://scumbumbomods.com/#/xml-extractor/

<!-- TOC -->

- [Original Documentation](#original-documentation)
  - [INFO](#info)
  - [INSTALL](#install)
  - [EXTRA](#extra)
    - [REQUIREMENTS](#requirements)
    - [BASIC USAGE](#basic-usage)
    - [FILE FINDER USAGE](#file-finder-usage)
- [Okay, but why this repo?](#okay-but-why-this-repo)

<!-- /TOC -->

# Original Documentation

## INFO

This is a utility program to extract the game's XML files for use in creating mods. XML can be extracted from the installed game packages or a single combined tuning file. The program can also easily be used to extract a single binary tuning file from the game packages and convert that to a combined XML tuning file.

The program is designed to perform these functions quickly by only loading those parts of the game packages that are required for producing the XML and looking ahead to quickly build required lookup tables.

When extracting the XML in Full Automatic mode (the recommended and default mode) the game's strings and references to other XML resource names can be included in comments. This feature is not available when working with a single combined tuning file. If you have multiple game language packages installed, you can select which language you want the XML comments to use.

Also in Full Automatic, the program can optionally output three tab delimited text files with all strings and XML resource names. The two reference files are suitable for opening in a spreadsheet package for easy searching, and the XML File Index can be loaded into the companion XML File Finder program to quickly locate files for viewing and editing.

There are three naming conventions available for the final XML files:
* Type, Group and Instance (TGI) for quick import into S4PE (e.g. S4_E882D22F_00000000_000000000001A2BC.xml)
* TGI plus resource name, formatted to automatically create a _KEY Name when imported in S4PE (e.g. S4_B61DE6B4_00000001_000000000001C8C5_object_drink_Cider.xml)
* Native TS4 naming format using the TGI (e.g. 0x00000000!0x00000000000029c3.0x2451c101)
* Or just the resource name

*- Scumbumbo*

## INSTALL

Extract the zip file and place the executable files in a folder of your choice.<br/>
Launch the program(s) from the executable files.

## EXTRA

### REQUIREMENTS

The program requires Windows XP or higher with the .Net Framework 4.5.1.

The program requires access to an installed copy of the game in order to extract the XML from the packages. To work on a machine that does not have the game installed you would need to copy the required packages, binary or combined tuning files to the PC you need to work on.
These files cannot be provided by the author for copyright reasons.

### BASIC USAGE

Launch the program. This step is important!

1. Select the Full Automatic Extract mode. This should be selected by default.
2. The program should automatically locate your Sims 4 install folder. If not, you can browse manually for it (this setting is saved when you exit the program).
3. Choose the options for the extract. Again, these options will be saved for the next time you use the program.
4. Under Output Options, select the Destination Folder for the XML files. You should create a new empty work folder for your first time. Subfolders will automatically be created for each game pack (see screenshot).
5. By default, the program will ask you before overwriting any files. You can also choose automatic overwrite at this time, which is useful if you're performing a full extract overr an existing extract (to avoid being prompted billions and billions of times). If you forget, you can select to "Stop Asking Me" when the overwrite dialog appears.
6. If you choose to rename existing files, any file will be automatically renamed with (Copy #) appended to that file rather than overwriting. You will be warned if you choose this option as it is very slow if doing a full extract over an existing extract (30,000+ files would need to be renamed).
7. Click the Begin Extracting button and wait. The program only updates it's user interface once for every file, so for the long steps it may appear to hang. Just wait and it will move on. The entire extraction process should take less than 3 minutes on a fast PC. Including strings, XML references and the file index will take only a few extra seconds!

### FILE FINDER USAGE

In order to use the file finder, you must have extracted the full XML using the "Create XML File Index" option. This option is on by default.

If you installed using the MSI file, a hot key is registered with Windows to launch the File Finder application using the Ctrl-Alt-F keys. Note that this key sequence will not be active until Windows Explorer is restarted - the easiest way to do this is to logout and log back in after installing. You can change this key sequence if desired by editing the properties of the XML File Finder application in your Start menu.

The first time you launch the file finder, you will need to load an index file produced by the extractor. This file should be in the output folder of the XML extract in a text file called "XML File Index". Since the full path to the XML files is included inside the file index, if you move the XML files to another location on your hard drive you will have to recreate the index file using the extractor.

Once an index file is loaded, simply type the search terms you wish to look for in the Search For field. There is no need to hit Enter to search, if you pause typing for 1/2 second the search will being. You can continue typing to modify the search. Searches are not case sensitive.

So for instance, when looking for interactions dealing with the piano, you might start by typing "interaction". The program will find (currently) 7,720 matches, which is a bit much to look through, so add a space and type "piano" which yields 53 matches. You can keep adding terms until you find what you are looking for, so if you then added "pract" to the search terms you would see 6 matches.

The search can find files using portions of the TGI, so if you're looking for the 0x7B2E action (loot_Buff_Computer_HighScore_Typing) you could find this using the terms from the name, or by just typing "7b2e" (which also finds the interaction 0x17B2E).

The instance is also stored for searching in decimal form, so if you see the broadcaster type "129459" in an XML file which doesn't have comments, you can easily find that file by just typing "129459" into your search terms to find "broadcaster_Jealousy_ClubEncouraged".

Once you have a short enough list of files that you can find what you're looking for, you can simply right-click the file in the list to select either "Open in Windows Explorer" or "Open in XML Editor".

# Okay, but why this repo?

![Scumbumbo delivering a lecture on adding a SimData for the Tag enum tuning](marmotte.gif)

XML Extractor survives in the form its original creator—[the legendary TS4 modding trailblazer, Scumbumbo](https://scumbumbomods.com/about)—left it to us, under the watchful eye and care of LittleMsSam.
I decided to maintain this repo as an auxilliary resource to begin to publicisize its revision history and to make it possible for LittleMsSam to review proposed pull requests.