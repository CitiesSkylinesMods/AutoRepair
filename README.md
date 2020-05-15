# AutoRepair
The incompatible mods list, in a mod!

> Note to modders: Create issues rather than pull requests please; this mod is still undergoing regular mass-refactorings and PRs will just clog up with merge conflicts.

## Current status

The mod contains over 1,100 descriptors and over 10,000 compatibility vectors.

The goal is to get every single mod added, then start enhancing core functionality.

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/aubergine18)

## Future plans

Once all mods are added, the next task will be to provide a better interface for users to review results (the log file works, but is not great usability, and a PITA on Mac OS/X platform):

1. Integrate with BP's Improved Content Manager mod
2. Maybe add web interface to view the full report

After that, future plans include:

* Mod localisation - already have this part baked in another project (the earlier attempt at making AutoRepair mod), the sooner it's added the better.
* Game localisation - I'm tracking locale of mods, radio stations, flag assets, etc. It could give user a way to see country/language specific mods and assets.
* Integration with other mods - for example, I will have all the "flag replacer" mods and "CSL Music" mods linked to their parent mod; if user has parent mod a button could be added in Content Manager > Mods allowing them to see a list of "addons" for that mod (example: see a list of radio stations for CSL Music mod and easily subscribe them).
* Provide a complete new UI for mod management - due to mods being grouped in semantic categories, and knowing what is compatible with current subscriptions, user could be given a radically improved UI for managing their mods. They could also browse mods by author, language, reliability, etc.
* Asset and mod suggestions can be attached to items to help user get some initial content for mods that require it.
* Assets could start getting added - the item descriptor is already designed to handle assets, but would need some way to automate that as there are just too many assets to sort through. If 1500 mods takes about 2 months to manually process, imagine the time taken to process over 200,000 assets! The goal will be to add auto-discovery (eg. detect RICO assets) and hoepfully also give users some simple way to send details back to me so they could be copy-pasted in to catalogs.
