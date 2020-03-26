namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// After a game update, this class is used to temporary adjust the catalog
    /// to indicate which items are confirmed compatible or broken, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Specify the version number of the update.
        /// </summary>
        private static readonly Version LatestUpdate = GameVersion.SunsetHarbor;

        /// <summary>
        /// Declare the broken or updated mods.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void CatalogAddendum() {
            // credit to AquilaSol/Avanya for compiling these lists in google docs

            if (GameVersion.Active >= LatestUpdate) {
                //Log.Info($"Game update {LatestUpdate.ToString()} has affected following items:");
                Broken(576327847u, "81 Tiles (Fixed for 1.2+)"); // very broken
                Broken(1844440354u, "Fine Road Anarchy 2"); // network mouse detection
                Broken(928128676u, "Improved Public Transport 2"); // transport not working
                Broken(1312735149u, "Klyte Commons");
                Broken(667342976u, "Loading Screen Mod"); // doesn't load DLC content
                Broken(833779378u, "Loading Screen Mod [Test]"); // doesn't load DLC content
                Broken(650436109u, "Quay Anarchy");
                Broken(1420955187u, "Real Time");
                Broken(934994075u, "Service Vehicle Selector 2"); // stack overflow
                Broken(465318661u, "Toggleable Whiteness"); // makes fishing paths invisible
                Broken(583429740u, "Traffic Manager: President Edition [STABLE]");
                Broken(1312767991u, "Transport Lines Manager 11.1.2");
                Broken(912329352u, "Building Anarchy"); // breaks placement mode
                Broken(512314255u, "More Network Stuff"); // breaks fishing route bulldoze
                Broken(1349895184u, "Tree LOD Fix"); // Error on launch
                Broken(621002682u, "No Questions Asked"); // crash to desktop

                // will be updated quickly after update
                Broken(1637663252u, "TM:PE V11 STABLE");
                Broken(1806963141u, "TM:PE v11.1.2 LABS");
            }

            // dead mods
            Dead(421188880u , "[ARIS] Early Death");
            Dead(439582006u , "[ARIS] Enhanced Garbage Truck AI");
            Dead(433249875u , "[ARIS] Enhanced Hearse AI");
            Dead(421050717u , "[ARIS] Remove Cows");
            Dead(421052798u , "[ARIS] Remove Pigs");
            Dead(421041154u , "[ARIS] Remove Seagulls", 564141599u);
            Dead(428094792u , "[ARIS] Remove Stuck Vehicles", 1637663252u);
            Dead(421028969u , "[ARIS] Skylines Overwatch");
            //Dead(932939897u , "5 way Clover Full Capacity Final");
            Dead(422554572u , "81 Tiles Updated", 576327847u);
            Dead(1361478243u, "81 Tiles (Not the real 81 tiles!)", 576327847u);
            Dead(1444491969u, "Achievements with Mods", 407055819u);
            Dead(412168106u , "Adjustable Demand v2", 409776678u);
            Dead(1647686914u, "Advanced Junction Rule", 1637663252u);
            Dead(442167376u , "Advanced Vehicle Options (AVO)", 1548831935u);
            Dead(793489846u , "Aedificium");
            Dead(1452259306u, "Aedificium RELOADED");
            Dead(616078328u , "All Tile Start", 576327847u);
            Dead(474652684u , "Asset Prefab(+Building) AI Changer");
            Dead(408760323u , "Auto Line Color", 1415090282u);
            Dead(406132323u , "Automatic Bulldoze", 639486063u);
            Dead(686588890u , "Automatic Emptying: Extended", 407873631u);
            Dead(683304621u , "Barrier Placer", 694512541u);
            Dead(1072157697u, "Cargo Info");
            Dead(416064574u , "Cimtographer", 1485051886u);
            Dead(549792340u , "Cimtographer updated for Natural_Disasters", 1485051886u);
            Dead(408613485u , "City Statistics Easy Access");
            Dead(658232246u , "Compass");
            Dead(420469721u , "Compass Mod");
            Dead(410535198u , "Control Building Level Up", 1403136223u);
            Dead(529979180u , "CSL Service Reserve");
            Dead(959894658u , "Custom Light Effects");
            Dead(1398502258u, "Dam Upkeep Scaler");
            Dead(649522495u , "District Service Limit", 927293560u);
            Dead(1181352643u, "District Service Limit 3.0", 927293560u);
            Dead(406629464u , "Dynamic Resolution", 812713438u);
            Dead(813835487u , "Early Death [1.6]");
            Dead(587516082u , "Early Death [Fixed for v1.4+]");
            Dead(569008960u , "Employ Overeducated Workers", 1674732053u);
            Dead(1114249433u, "Employ Overeducated Workers (1.10+)", 1674732053u);
            Dead(813835391u , "Enhanced Garbage Truck AI [1.6]");
            Dead(583552152u , "Enhanced Garbage Truck AI [Fixed for v1.4+]");
            Dead(813835241u , "Enhanced Hearse AI [1.6]");
            Dead(583556014u , "Enhanced Hearse AI [Fixed for v1.4+]");
            Dead(414469593u , "Extended Building Information", 1556715327u);
            Dead(1133108993u, "Extended Building Information (1.10+)", 1556715327u);
            Dead(456408505u , "European Buildings Unlocker");
            Dead(411164732u , "Extended Public Transport UI");
            Dead(802489150u , "Extended Public Transport UI (+DLCs!)");
            Dead(408209297u , "Extended Road Upgrade");
            Dead(451700838u , "Extended Toolbar", 563229150u);
            Dead(651322972u , "Fine Road Tool", 1844442251u);
            Dead(802066100u , "Fine Road Anarchy", 1844440354u);
            Dead(410234967u , "Fire Spread");
            Dead(637901778u , "Fire Spread [ Fixed for C:S 1.3.2+ ]");
            Dead(406255342u , "First-person camera", 650805785u);
            Dead(1275678215u, "Force Building Level", 523818382u);
            Dead(636687806u , "Freewalking");
            //Dead(1368078347u, "French Architecture Style (Paris) District Style");
            Dead(406749417u , "Ground Level Camera - Broken by Mass Transit, don't use");
            Dead(413748580u , "ImageOverlay");
            Dead(1115699323u, "Immersive Water 0.9.0.0 (beta release)");
            Dead(508195208u , "Improved Asset Icons", 747836519u);
            Dead(417430545u , "Improved Assets Panel", 814498849u);
            Dead(416033610u , "Improved Mods Panel", 814498849u);
            Dead(424106600u , "Improved Public Transport", 928128676u);
            Dead(580335918u , "Infinite Oil And Ore Redux [DEPRECATED]");
            //Dead(1633845925u, "International Finance Center GuangZhou");
            Dead(635815270u , "IOperateIt");
            Dead(472128528u , "Larger Footprints");
            Dead(649674529u , "Mark-a-Route");
            Dead(1416566861u, "Moorfield Houses");
            Dead(505480567u , "More Beautification", 837734529u);
            Dead(766190099u , "Move It! (old original mod)", 1619685021u);
            Dead(1120637951u, "Move it! Extra Filters");
            Dead(1588340989u, "Move It Tool Extensions");
            Dead(420230361u , "Moving Sun");
            Dead(532863263u , "Multi-Track Station Enabler 1.2.0", 1394468624u);
            Dead(950807008u , "Network Extensions 2 Fix", 812125426u);
            Dead(478820060u , "Network Extensions Project", 812125426u);
            Dead(658653260u , "Network Nodes Editor [Experimental]", 1619685021u);
            Dead(929114228u , "New Roads For NE 2");
            Dead(407270433u , "No More Purple Pollution", 666425898u);
            Dead(409073164u , "NoPillars", 463845891u);
            Dead(635815270u , "Operate It");
            Dead(771161159u , "OSM Import");
            Dead(418352365u , "Pedestrian Suspension Bridge");
            Dead(410842044u , "Persistent Resource View");
            Dead(1204126182u, "Ploppable RICO - High Density Fix", 586012417u);
            Dead(685747254u , "Prop Fine Tune");
            Dead(1499486217u, "Ragnarok EXTREME EDITION");
            //Dead(1122848011u, "regency_corner_restaurant");
            Dead(813835951u , "Remove Cows [1.6]");
            Dead(587545554u , "Remove Cows [Fixed for v1.4+]");
            Dead(813835851u , "Remove Pigs [1.6]");
            Dead(587549083u , "Remove Pigs [Fixed for v1.4+]");
            Dead(813835673u , "Remove Seagulls [1.6]", 564141599u);
            Dead(587536931u , "Remove Seagulls [Fixed for v1.4+]", 564141599u);
            Dead(813834836u , "Remove Stuck Vehicles [1.6]", 442167376u);
            Dead(587530437u , "Remove Stuck Vehicles [Fixed for v1.4+]", 442167376u);
            Dead(820547325u , "Resilient Owners (Make Historical)", 1330381737u);
            Dead(418556522u , "Road Anarchy", 1844440354u);
            Dead(954034590u , "Road Anarchy V2", 1844440354u);
            Dead(417926819u , "Road Assistant - BROKEN");
            Dead(417585852u , "Road Color Changer", 932192868u);
            Dead(651610627u , "Road Color Changer Continued", 932192868u);
            Dead(436253779u , "Road Protractor", 445589127u);
            Dead(726005715u , "Roads United Core+", 633547552u);
            Dead(1691909129u, "Rotate Brush");
            Dead(605590542u , "Rush Hour II - Formerly Rush Hour [Beta]", 1420955187u);
            Dead(1432430887u, "Rush Hour II [Development]", 1420955187u);
            Dead(540758804u , "Search Box Mod", 837734529u);
            Dead(553184329u , "Sharp Junction Angles", 1844440354u);
            Dead(1383456057u, "Shicho - Fundamental support mod for hardcore builders");
            Dead(813833476u , "Skylines Overwatch [1.6]");
            Dead(583538182u , "Skylines Overwatch [Fixed for v1.3+]");
            Dead(512194601u , "Slope Limits (WtM)");
            //Dead(438937962u , "Small Hanger no Reqs");
            //Dead(667891104u , "Small Ship");
            //Dead(931760630u , "Small Ship");
            Dead(413847191u , "SOM - Services Optimization Module");
            Dead(1393831156u, "Sub Mesh Flags");
            Dead(556416380u , "Telemetry Control");
            Dead(411095553u , "Terraform tool 0.9", 502750307u);
            Dead(510802741u , "Toggle District Snapping");
            Dead(415782697u , "Toggle Zoning", 592076973u);
            Dead(755839415u , "Touch This!", 1393797695u);
            Dead(498363759u , "Traffic Manager + Improved AI", 1637663252u);
            Dead(583429740u , "Traffic Manager: President Edition [STABLE]", 1637663252u);
            Dead(409184143u , "Traffic++", 812125426u);
            Dead(626024868u , "Traffic++V2", 812125426u);
            Dead(408875519u , "Transport Lines Manager", 1312767991u);
            Dead(679377572u , "Trash & Dead Cleaner 1");
            Dead(406723376u , "Tree Brush", 502750307u);
            Dead(1498036881u, "UltimateMod 2.1 ( Higher Income and More Options )");
            Dead(627047745u , "Winter Buildings Unlocker");
            Dead(414702884u , "Zonable Pedestrian Paths - Stable", 812125426u);

            // incompatible mods
            Incompatible(412146081u , "PostProcessFX v1.9.0",                    812713438u , "Dynamic Resolution (Fixed for 1.9!)");
            Incompatible(412146081u , "PostProcessFX v1.9.1",                    1794015399u, "Render It!");
            Incompatible(442167376u , "Advanced Vehicle Options (AVO)",          1548831935u, "Advanced Vehicle Options AVO (Industries DLC ready)");
            Incompatible(451700838u , "Extended Toolbar",                        563229150u , "Advanced Toolbar");
            Incompatible(455403039u , "Unlimited Trees Mod",                     869134690u, "Tree Snapping");
            Incompatible(502750307u , "Extra Landscaping Tools",                 411095553u, "Terraform tool 0.9");
            Incompatible(543722850u , "Network Skins",                           1312735149u, "Klyte Commons");
            Incompatible(543722850u , "Network Skins",                           1758376843u, "Network Skins 2 (Beta)");
            Incompatible(583429740u , "Traffic Manager: President Edition",      407335588u, "No Despawn Mod");
            Incompatible(583429740u , "Traffic Manager: President Edition",      418556522u, "Road Anarchy");
            Incompatible(583429740u , "Traffic Manager: President Edition",      498363759u, "Traffic Manager + Improved AI");
            Incompatible(583429740u , "Traffic Manager: President Edition",      631930385u, "Realistic Vehicle Speeds");
            Incompatible(583429740u , "Traffic Manager: President Edition",      844180955u, "City Drive");
            Incompatible(583429740u , "Traffic Manager: President Edition",      927293560u, "Geli-Districts v3.0");
            Incompatible(583429740u , "Traffic Manager: President Edition",      954034590u, "Road Anarchy V2");
            Incompatible(583429740u , "Traffic Manager: President Edition",      1181352643u, "District Service Limit 3.0");
            Incompatible(583429740u , "Traffic Manager: President Edition",      1637663252u, "TM:PE V11 STABLE (formerly TMPE [LABS])");
            Incompatible(583429740u , "Traffic Manager: President Edition",      1764208250u, "More Vehicles");
            Incompatible(586012417u , "Ploppable RICO",                          1204126182u, "Ploppable RICO - High Density Fix");
            Incompatible(586012417u , "Ploppable RICO",                          2016920607u, "Ploppable RICO revisited");
            Incompatible(602077938u , "TotalyFree Camera",                       406629464u, "Dynamic Resolution");
            Incompatible(602077938u , "TotalyFree Camera",                       812713438u, "Dynamic Resolution (Fixed for 1.9!)");
            Incompatible(633547552u , "Roads United Core 2.0",                   726005715u, "Roads United Core+");
            Incompatible(666425898u , "No Radioactive Desert And More!",         1591417160u, "Hide It!");
            Incompatible(667342976u , "Loading Screen Mod",                      833779378u, "Loading Screen Mod [Test]");
            Incompatible(775021554u , "Theme Mixer",                             1899640536u, "Theme Mixer 2");
            Incompatible(791968744u , "Dynamic Foliage",                         666425898u, "No Radioactive Desert And More!");
            Incompatible(812125426u , "Network Extensions 2",                    547126602u, "Street Light Replacer");
            Incompatible(812125426u , "Network Extensions 2",                    1959342332u, "CSUR ToolBox");
            Incompatible(812713438u , "Dynamic Resolution (Fixed for 1.9!)",     406629464u, "Dynamic Resolution");
            Incompatible(816260433u , "Metro Overhaul Mod 9.0",                  1530376523u, "Railway Replacer");
            Incompatible(821539759u , "Disable Zone Check",                      924884948u, "Plop The Growables");
            Incompatible(837734529u , "Find It!",                                540758804u, "Search Box Mod");
            Incompatible(844180955u , "City Drive",                              406255342u, "First-person camera");
            Incompatible(844180955u , "City Drive",                              583429740u, "Traffic Manager: President Edition");
            Incompatible(844180955u , "City Drive",                              650805785u, "First Person Camera: Updated");
            Incompatible(844180955u , "City Drive",                              651056665u, "Enhanced Zoom Continued");
            Incompatible(844180955u , "City Drive",                              1406625743u, "EnhancedZoomContinued");
            Incompatible(917543381u , "No Problem [BETA]",                       561293123u, "Hide Problems AKA Politician's Mod");
            Incompatible(924884948u , "Plop The Growables",                      821539759u, "Disable Zone Check");
            Incompatible(928128676u , "Improved Public Transport 2",             424106600u, "Improved Public Transport");
            Incompatible(928128676u , "Improved Public Transport 2",             472128528u, "Larger Footprints");
            Incompatible(928128676u , "Improved Public Transport 2",             531401164u, "Vehicle Unbuncher");
            Incompatible(928128676u , "Improved Public Transport 2",             1218121337u, "Automatic Vehicle Numbers Adjuster");
            Incompatible(959894658u , "Custom Light Effects",                    651322972u, "Fine Road Tool");
            Incompatible(1138510774u, "PostProcessFX - Multi-platform",          412146081u, "PostProcessFX v1.9.0");
            Incompatible(1138510774u, "PostProcessFX - Multi-platform",          812713438u, "Dynamic Resolution (Fixed for 1.9!)");
            Incompatible(1138510774u, "PostProcessFX - Multi-platform",          1794015399u, "Render It!");
            Incompatible(1204126182u, "Ploppable RICO - High Density Fix",       2016920607u, "Ploppable RICO revisited");
            Incompatible(1312767991u, "Transport Lines Manager13.1",             934994075u, "Service Vehicle Selector 2");
            Incompatible(1312767991u, "Transport Lines Manager 13.1",            928128676u, "Improved Public Transport 2");
            Incompatible(1400711138u, "[BETA] ParallelRoadTool",                 543722850u, "Network Skins");
            Incompatible(1406625743u, "EnhancedZoomContinued",                   651056665u, "Enhanced Zoom Continued");
            Incompatible(1442713872u, "Detail",                                  1094334744u, "Ploppable Asphalt objects turned into Procedural Objects");
            Incompatible(1637663252u, "TM:PE V11 STABLE (formerly TMPE [LABS])", 407335588u, "No Despawn Mod");
            Incompatible(1637663252u, "TM:PE V11 STABLE (formerly TMPE [LABS])", 418556522u, "Road Anarchy");
            Incompatible(1637663252u, "TM:PE V11 STABLE (formerly TMPE [LABS])", 498363759u, "Traffic Manager + Improved AI");
            Incompatible(1637663252u, "TM:PE V11 STABLE (formerly TMPE [LABS])", 583429740u, "Traffic Manager: President Edition");
            Incompatible(1637663252u, "TM:PE V11 STABLE (formerly TMPE [LABS])", 631930385u, "Realistic Vehicle Speeds");
            Incompatible(1637663252u, "TM:PE V11 STABLE (formerly TMPE [LABS])", 844180955u, "City Drive");
            Incompatible(1637663252u, "TM:PE V11 STABLE (formerly TMPE [LABS])", 954034590u, "Road Anarchy V2");
            Incompatible(1637663252u, "TM:PE V11 STABLE (formerly TMPE [LABS])", 1181352643u, "District Service Limit 3.0");
            Incompatible(1637663252u, "TM:PE V11 STABLE (formerly TMPE [LABS])", 1764208250u, "More Vehicles");
            Incompatible(1645781000u, "Elektrix's Road Tools 2.0",               1597198847u, "[Legacy] Segment Slope Smoother");
            Incompatible(1758376843u, "Network Skins 2 (Beta)",                  1440928803u, "Parallel Road Tool");
            Incompatible(1764208250u, "More Vehicles",                           442167376u, "Advanced Vehicle Options");
            Incompatible(1764208250u, "More Vehicles",                           576327847u, "81 Tiles");
            Incompatible(1764208250u, "More Vehicles",                           816260433u, "Metro Overhaul Mod");
            Incompatible(1764208250u, "More Vehicles",                           1548831935u, "Advanced Vehicle Options AVO (Industries DLC ready)");
            Incompatible(1831805509u, "Dynamic Text Props",                      651322972u, "Fine Road Tool");
            Incompatible(1844440354u, "Fine Road Anarchy 2",                     802066100u, "Fine Road Anarchy");
            Incompatible(1844442251u, "Fine Road Tool 2",                        651322972u, "Fine Road Tool");
            Incompatible(1959342332u, "CSUR ToolBox",                            427258853u, "Crossings");
            Incompatible(1959342332u, "CSUR ToolBox",                            812125426u, "Network Extensions 2");

            // breaks editor
            BreaksEditor(412146081u, "PostProcessFX v1.9.0");
            BreaksEditor(543722850u, "Network Skins");
            BreaksEditor(586012417u, "Ploppable RICO");
            BreaksEditor(672248733u, "Ultimate Eyecandy");
            BreaksEditor(1138510774u, "PostProcessFX - Multi-platform");
            BreaksEditor(1204126182u, "Ploppable RICO - High Density Fix");
        }

        /// <summary>
        /// Mark an item as compatible with latest version.
        ///
        /// If the item is not yet in catalog, it will be added, otherwise the existing item will be updated.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Workshop.</param>
        internal void Compatible(ulong workshopId, string workshopName) {
            //Log.Info($"- Confirmed compatible: {workshopId} '{workshopName}'");

            if (Items.TryGetValue(workshopId, out Item item)) {
                item.BrokenBy = GameVersion.DefaultUntil;
                item.CompatibleWith = LatestUpdate;
                if (item.Notes == null) {
                    item.Notes = new[] { "Compatible with Sunset Harbor update." };
                } else {
                    List<string> arr = new List<string>(item.Notes) {
                        { "Compatible with Sunset Harbor!" },
                    };
                    item.Notes = arr.ToArray();
                }
            } else {
                AddMod(new Item(workshopId, workshopName) {
                    Affect = Factor.Other,
                    Authors = "(not specified)",
                    Catalog = "Addendum",
                    CompatibleWith = LatestUpdate,
                    Flags = ItemFlags.Unrecognised,
                });
            }
        }

        /// <summary>
        /// Mark an item as NOT compatible with latest version.
        ///
        /// If the item is not yet in catalog, it will be added, otherwise the existing item will be updated.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Workshop.</param>
        internal void Broken(ulong workshopId, string workshopName) {
            //Log.Info($"- Broken: {workshopId} '{workshopName}'");

            if (Items.TryGetValue(workshopId, out Item item)) {
                item.BrokenBy = LatestUpdate;
                if (item.CompatibleWith >= LatestUpdate) {
                    item.CompatibleWith = GameVersion.DefaultRelease;
                }
            } else {
                AddMod(new Item(workshopId, workshopName) {
                    Affect = Factor.Other,
                    Authors = "(not specified)",
                    BrokenBy = LatestUpdate,
                    Catalog = "Addendum",
                    Flags = ItemFlags.Unrecognised,
                });
            }
        }

        /// <summary>
        /// Marks a mod as editor-breaking.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Workshop.</param>
        internal void BreaksEditor(ulong workshopId, string workshopName) {
            if (Items.TryGetValue(workshopId, out Item item)) {
                item.Flags |= ItemFlags.EditorBreaking;
            } else {
                AddMod(new Item(workshopId, workshopName) {
                    Affect = Factor.Other,
                    Authors = "(not specified)",
                    Catalog = "Addendum",
                    Flags = ItemFlags.EditorBreaking
                          | ItemFlags.Unrecognised,
                });
            }
        }

        /// <summary>
        /// A temporary way to mark a mod as dead. Thes should be converted to full
        /// item descriptors later to define all the additional information.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Workshop.</param>
        /// <param name="replacement">(Optional) Workshop ID of a suitable replacement.</param>
        internal void Dead(ulong workshopId, string workshopName, ulong replacement = 0u) {
            if (Items.TryGetValue(workshopId, out Item item)) {
                item.Flags |= ItemFlags.Abandonware | ItemFlags.GameBreaking | ItemFlags.Obsolete;
                if (item.ReplaceWith != 0u) {
                    item.Flags |= ItemFlags.ForceMigration;
                } else if (replacement != 0u) {
                    item.Flags |= ItemFlags.ForceMigration;
                    item.ReplaceWith = replacement;
                }
            } else {
                AddMod(new Item(workshopId, workshopName) {
                    Affect = Factor.Other,
                    Authors = "(not specified)",
                    Catalog = "Addendum",
                    Flags = ItemFlags.Abandonware
                          | ItemFlags.GameBreaking
                          | ItemFlags.Obsolete
                          | ItemFlags.Unrecognised,
                    ReplaceWith = replacement,
                });
                if (replacement != 0u) {
                    Items[workshopId].Flags |= ItemFlags.ForceMigration;
                }
            }
        }

        /// <summary>
        /// Mark two items as incompatible with each other.
        ///
        /// Items will be updated or added as applicable. This should only be used as a
        /// temporary measure to quickly define incompatibilities. Ideally these should
        /// be later converted to full item descriptors containing more detailed info
        /// about the items.
        /// </summary>
        /// 
        /// <param name="idA">Workshop id for first item.</param>
        /// <param name="nameA">Workshop name for first item.</param>
        /// <param name="idB">Workshop id fof second item.</param>
        /// <param name="nameB">Workshop name for second item.</param>
        internal void Incompatible(ulong idA, string nameA, ulong idB, string nameB) {
            // first item
            if (Items.TryGetValue(idA, out Item itemA)) {
                if (itemA.Compatibility == null) {
                    itemA.Compatibility = new Dictionary<ulong, Status>() {
                        { idB, Status.Incompatible },
                    };
                } else if (!itemA.Compatibility.ContainsKey(idB)) {
                    itemA.Compatibility.Add(idB, Status.Incompatible);
                }
            } else {
                AddMod(new Item(idA, nameA) {
                    Affect = Factor.Other,
                    Authors = "(not specified)",
                    Catalog = "Addendum",
                    Compatibility = new Dictionary<ulong, Status>() {
                        { idB, Status.Incompatible },
                    },
                    Flags = ItemFlags.Unrecognised,
                });
            }

            if (Items.TryGetValue(idB, out Item itemB)) {
                if (itemB.Compatibility == null) {
                    itemB.Compatibility = new Dictionary<ulong, Status>() {
                        { idA, Status.Incompatible },
                    };
                } else if (!itemB.Compatibility.ContainsKey(idA)) {
                    itemB.Compatibility.Add(idA, Status.Incompatible);
                }
            } else {
                AddMod(new Item(idB, nameB) {
                    Affect = Factor.Other,
                    Authors = "(not specified)",
                    Catalog = "Addendum",
                    Compatibility = new Dictionary<ulong, Status>() {
                        { idA, Status.Incompatible },
                    },
                    Flags = ItemFlags.Unrecognised,
                });
            }
        }
    }
}
