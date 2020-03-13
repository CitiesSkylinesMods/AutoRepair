/*

Just jotting down details of WG mods soon to be retired:

Configurable Population Modifiers v1.8:
https://steamcommunity.com/sharedfiles/filedetails/?id=652921941
This project is to just enable population modfiers for configuration and could be seen as the
simple cousin of Realistic Population and Consumption Mod.
A file named WG_PopOnly.xml will appear in the default location

Incompatible:
* Realistic Population and Consumption Mod (this mod will shut down on detection of that mod being enabled)
* Building Simulation Overhaul
* Proper Hardness
* PopBalanceMod
* Enhanced Building Capacity
* Any mod which overlaps changes to building's households, worker count.

---

Citizen Lifecycle Rebalance v2.6:
https://steamcommunity.com/sharedfiles/filedetails/?id=654707599
code: https://github.com/WhitefangGreytail/WG_CitizenEdit
- Changes travel probability (car, bicycle, taxi) within the city, depending on age group and wealth level.
- Lifespan spread out as a multiplier of the original (default is triple the lifespan)
- Early death, depending on the age decile (tenth segment of the approximate life).
- Mapped survival values using the Australian Government Actuary table (2010-12)[www.aga.gov.au]
and imposed a decade's value to a tenth of a citizen's life
- More people will become ill and require treatment at clincs or hospitals.
- Enables people from a wide range of ages to migrate in, from child to seniors (yes, seniors). Partners have similar ages.
- Citizens will have a chance to have a higher (or lower) level of education that what is requested by the game.
- Teens will be at elementary school education and some young adults will be at high school education.
- Immigration greatly reduces the chance that the city has been seeded for death waves in the future.

Recommended: Realistic Pop & Consumption http://steamcommunity.com/sharedfiles/filedetails/?id=426163185

Incompatible:
WG Travel Rebalance (is already included)
WG Lifespan Multiplier (is already included)
Randomize Age Cim Move In (similar functionality)
Lifespan Changer (similar functionality)
Slow Citizen Aging (similar functionality)
Very Slow Citizen Aging (similar functionality)
Slow Citizen Aging Configurable (similar functionality)
[ARIS] Early Death (similar functionality)

---

Realistic Population and Consumption Mod v8.4.0:
https://steamcommunity.com/sharedfiles/filedetails/?id=426163185
code: https://github.com/WhitefangGreytail/WG_RealisticCitySkylines
- Low density houses are now one household, without an override.
- The number of workers and high density households will be determined by the volume of the building as seen
by the size of construction scaffolding.
- Employment based on education level have changed. Offices shifts to more university educated, while
commercial and industry will shift towards high school educated.
- Tweaked pollution levels, water and electricity consumption, garbage accumulation and income of different buildings.
- Production of goods for extraction of specialised industry (farm, forest, ore, oil) has been reduced.
- Production values from offices are determined by the number of people.
- Land values affect land tax income (as a 50% land value per household/production unit).
A file named WG_RealisticCity.xml will appear in the default location.

Recommended Mods
* WG Citizen Lifecycle Rebalance http://steamcommunity.com/sharedfiles/filedetails/?id=654707599
* Rebalanced Industries http://steamcommunity.com/sharedfiles/filedetails/?id=1562650024

Incompatible Mods:
Building Simulation Overhaul
Proper Hardness
PopBalanceMod
Enhanced Building Capacity
Any mod which overlaps changes to building's households, worker count, power, water, sewage, garbage, income, pollution or production.

---

Resident Travel Rebalance v1.1:
https://steamcommunity.com/sharedfiles/filedetails/?id=541673195
A file named WG_ResidentTravel.xml will appear in below directories.
Mod is NOT compatible with WG Citizen Life Rebalance (this mod is included)

---

Thermal Solar Rebalance v1.3:
https://steamcommunity.com/sharedfiles/filedetails/?id=569879360
code: https://github.com/WhitefangGreytail/ImprovedSolar
A file named WG_RealisticSolar.xml will appear in the below location depending on the OS.
Incompatible Mods: Any mod that affects the ability of solar power plants could overwrite this one.

---

Lifespan multiplier v1.1:
https://steamcommunity.com/sharedfiles/filedetails/?id=643642403
code: https://github.com/WhitefangGreytail/WG_Lifespan
This mod is meant to be as a replacement for Slow Citizen Aging Configurable
A file named WG_Lifespan.xml will appear in the default location

---

Slow Citizen Aging Configurable:
https://steamcommunity.com/sharedfiles/filedetails/?id=409071509
Slows Citizen Aging to 1/2 by default, but also creates a file in the Game Directory after you load a map up that you can change. 
config: slowCitizenAging.txt
incompatible: https://steamcommunity.com/sharedfiles/filedetails/?id=409070218

---

Note: Older WG user has loads of earlier versions of the mods:
https://steamcommunity.com/profiles/76561198053046087/myworkshopfiles/?appid=255710
 */