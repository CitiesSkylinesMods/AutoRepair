# AutoRepair
The incompatible mods list, in a mod!

## Current status

Current ETA for basic working mod is about 1-2 weeks (as of 15/Mar/2020).

Initial goal is to have the mod create a log file detailing incompatibilities and other information based on users' subscribed mods.

Main task currently is adding mod definitions (up to page 20 on the Worskhop mods section). Mod currently won't build, as entire focus is currently getting all the mod definitions done and lots of ongoing refactoring to group them more semantically. Only after that will proper functionality start getting added.

In particular some base classes will be developed to drastically reduce duplicate code across dozens of mod catalogs.

## Future plans

Once initial mod is deployed (just log file) the next goal will be to add user interface. That will likely wait until new Form Builder UI wrapper is complete (a TM:PE project by kvakvs). This will allow user to view compatibility reports via mod options screen (or some other entry point) and subscribe/unsubscribe mods, switch between versions, etc.

After that, future plans include:

* Mod localisation - already have this part baked in another project (the earlier attempt at making AutoRepair mod), the sooner it's added the better.
* Game localisation - I'm tracking locale of mods, radio stations, flag assets, etc. It could give user a way to see country/language specific mods and assets.
* Integration with other mods - for example, I will have all the "flag replacer" mods and "CSL Music" mods linked to their parent mod; if user has parent mod a button could be added in Content Manager > Mods allowing them to see a list of "addons" for that mod (example: see a list of radio stations for CSL Music mod and easily subscribe them).
* Provide a complete new UI for mod management - due to mods being grouped in semantic categories, and knowing what is compatible with current subscriptions, user could be given a radically improved UI for managing their mods. They could also browse mods by author, language, reliability, etc.
* Asset and mod suggestions can be attached to items to help user get some initial content for mods that require it.
* Assets could start getting added - the item descriptor is already designed to handle assets, but would need some way to automate that as there are just too many assets to sort through. If 1500 mods takes about 3 weeks to manually process, imagine the time taken to process over 200k assets! The goal will be to add auto-discovery (eg. detect RICO assets) and hoepfully also give users some simple way to send details back to me so they could be copy-pasted in to catalogs.
