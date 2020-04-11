namespace AutoRepair {
    using AutoRepair.Util;
    using System;
    using System.Globalization;

    /// <summary>
    /// Game versions by expansion DLC.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "Meh.")]
    public class GameVersion {

        /// <summary>
        /// Initializes static members of the <see cref="GameVersion"/> class.
        /// </summary>
        static GameVersion() {
            Active = GetGameVersion();
            LatestMilestone = GetMilestone(Active);

            if (Active.Minor != LatestMilestone.Minor) {
                Log.Debug("### GameVersion.LatestMilestone mismatch with GameVersion.Active");
            }
        }

        /// <summary>
        /// Gets the active game version (Major, minor, patch, build).
        /// </summary>
        public static Version Active { get; private set; }

        /// <summary>
        /// Gets version number for latest <c>Major.minor</c> release.
        /// </summary>
        public static Version LatestMilestone { get; private set; }

        /// <summary>
        /// 2015-03-10 Release version. Used as default for all items.
        /// </summary>
        public static readonly Version DefaultRelease = new Version(0, 0, 0, 0);

        /// <summary>
        /// Default for BrokenBy.
        /// </summary>
        public static readonly Version DefaultUntil = new Version(9, 9, 9, 9);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2015-03-10 Initial release of Cities: Skylines.
        /// </summary>
        public static readonly Version InitialRelease = new Version(1, 0, 5, 0);

        /// <summary>
        /// 2015-03-10 Deluxe Upgrade content pack.
        /// </summary>
        public static readonly Version DeluxeUpgrade = new Version(1, 0, 5, 0);

        /// <summary>
        /// 2015-03-10 First release.
        /// </summary>
        public static readonly Version Patch_1_0_5 = new Version(1, 0, 5, 0);

        /// <summary>
        /// 2015-03-21 Hotfix.
        /// </summary>
        public static readonly Version Patch_1_0_6b = new Version(1, 0, 6, 2);

        /// <summary>
        /// 2015-03-27 Asset editor hotfix.
        /// </summary>
        public static readonly Version Patch_1_0_7b = new Version(1, 0, 7, 2);

        /// <summary>
        /// 2015-04-07 Asset editor hotfix.
        /// </summary>
        public static readonly Version Patch_1_0_7c = new Version(1, 0, 7, 3);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2015-05-19 European biome and buildings added.
        /// </summary>
        public static readonly Version EuropeBiome = new Version(1, 1, 0, 0);

        /// <summary>
        /// 2015-05-19 Tunnels and European themed buildings and maps added.
        /// </summary>
        public static readonly Version Patch_1_1_0 = new Version(1, 1, 0, 0);

        /// <summary>
        /// 2015-07-01 IUserMod changed. Any mod older than this is toast.
        /// </summary>
        public static readonly Version Patch_1_1_1 = new Version(1, 1, 1, 0);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2015-09-24 After Dark expansion.
        /// </summary>
        public static readonly Version AfterDark = new Version(1, 2, 0, 0);

        /// <summary>
        /// 2015-09-24 Day/night cycle, tourism/leisure, taxis, prisons, bicycle paths.
        /// </summary>
        public static readonly Version Patch_1_2_0 = new Version(1, 2, 0, 0);

        /// <summary>
        /// 2015-10-01 Asset editor hotfix.
        /// </summary>
        public static readonly Version Patch_1_2_1_f1 = new Version(1, 2, 1, 1);

        /// <summary>
        /// 2015-11-05 Several game limits increased.
        /// </summary>
        public static readonly Version Patch_1_2_2_f2 = new Version(1, 2, 2, 2);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2016-02-18 Snowfall expansion.
        /// </summary>
        public static readonly Version Snowfall = new Version(1, 3, 0, 4);

        /// <summary>
        /// 2016-02-18 Winter biome, tram, road maintenance, heating.
        /// </summary>
        public static readonly Version Patch_1_3_0_f4 = new Version(1, 3, 0, 4);

        /// <summary>
        /// 2016-02-23 Hotfix.
        /// </summary>
        public static readonly Version Patch_1_3_1_f1 = new Version(1, 3, 1, 1);

        /// <summary>
        /// 2016-03-02 Rendernig and pathfinding hotfix.
        /// </summary>
        public static readonly Version Patch_1_3_2_f1 = new Version(1, 3, 2, 1);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2016-03-22 Landscaping tools update, rocks added, ruins added, map editor updated.
        /// </summary>
        public static readonly Version Patch_1_4_0_f3 = new Version(1, 4, 0, 3);

        /// <summary>
        /// 2016-04-19 Hotfix.
        /// </summary>
        public static readonly Version Patch_1_4_1_f2 = new Version(1, 4, 1, 2);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2016-06-09 Match Day free expansion.
        /// </summary>
        public static readonly Version MatchDay = new Version(1, 5, 0, 4);

        /// <summary>
        /// 2016-06-09 Football stadiums and match mechanics.
        /// </summary>
        public static readonly Version Patch_1_5_0_f4 = new Version(1, 5, 0, 4);

        /// <summary>
        /// 2016-09-01 Art Deco content pack.
        /// </summary>
        public static readonly Version ArtDeco = new Version(1, 5, 1, 0);

        /// <summary>
        /// 2016-09-01 Art Deco content pack.
        /// </summary>
        public static readonly Version Patch_1_5_1 = new Version(1, 5, 1, 0);

        /// <summary>
        /// 2016-10-18 Stadiums DLC (no longer available).
        /// </summary>
        public static readonly Version Stadiums = new Version(1, 5, 2, 0);

        /// <summary>
        /// 2016-10-18 Stadiums content packs.
        /// </summary>
        public static readonly Version Patch_1_5_2 = new Version(1, 5, 2, 0);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2016-11-29 Natural Disasters expansion.
        /// </summary>
        public static readonly Version NaturalDisasters = new Version(1, 6, 0, 4);

        /// <summary>
        /// 2016-11-29 Natural Disasters expansion.
        /// </summary>
        public static readonly Version HighTechBuildings = new Version(1, 6, 0, 4);

        /// <summary>
        /// 2016-11-29 Unity 5.4. Natural disasters, disaster services & buildings, fires spread, helicopters, sub-buildings.
        /// </summary>
        public static readonly Version Patch_1_6_0_f4 = new Version(1, 6, 0, 4);

        /// <summary>
        /// 2016-12-11 Service enumerators fixed in modding API, lots of bug fixes.
        /// </summary>
        public static readonly Version Patch_1_6_1_f2 = new Version(1, 6, 1, 2);

        /// <summary>
        /// 2016-12-21 Sub building fixes, asset editor pillar fixes.
        /// </summary>
        public static readonly Version Patch_1_6_2_f1 = new Version(1, 6, 2, 1);

        /// <summary>
        /// 2017-01-26 Content manager asset sorting, bug fixes.
        /// </summary>
        public static readonly Version Patch_1_6_3_f1 = new Version(1, 6, 3, 1);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2017-05-18 Mass Transit expansion.
        /// </summary>
        public static readonly Version MassTransit = new Version(1, 7, 0, 5);

        /// <summary>
        /// 2017-05-18 Ferries, cable cars, blimps, monorail, road naming, citizen assets, emergency vehicle swerving,
        /// unlimited soil/ore mods added, railway intercity toggle, stop signs, transport unbunching...
        /// </summary>
        public static readonly Version Patch_1_7_0_f5 = new Version(1, 7, 0, 5);

        /// <summary>
        /// 2017-05-23 Hotfix.
        /// </summary>
        public static readonly Version Patch_1_7_1_f1 = new Version(1, 7, 1, 1);

        /// <summary>
        /// 2017-06-01 Hotfix.
        /// </summary>
        public static readonly Version Patch_1_7_2_f1 = new Version(1, 7, 2, 1);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2017-08-17 Concerts expansion.
        /// </summary>
        public static readonly Version Concerts = new Version(1, 8, 0, 3);

        /// <summary>
        /// 2017-08-17 Concerts and festival mechanics, content manager overhaul.
        /// </summary>
        public static readonly Version Patch_1_8_0_f3 = new Version(1, 8, 0, 3);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2017-10-19 Green Cities expansion.
        /// </summary>
        public static readonly Version GreenCities = new Version(1, 9, 0, 5);

        /// <summary>
        /// 2017-10-19 Green Cities expansion.
        /// </summary>
        public static readonly Version EuropeanSuburbia = new Version(1, 9, 0, 5);

        /// <summary>
        /// 2017-10-19 Unity 5.6.3, new commerical/residentail/office specialisations, new service buildings,
        /// electric cars, noise pollution overhaul, moddable roads, train track intersection rules...
        /// </summary>
        public static readonly Version Patch_1_9_0_f5 = new Version(1, 9, 0, 5);

        /// <summary>
        /// 2017-12-05 All That Jazz DLC.
        /// </summary>
        public static readonly Version AllThatJazz = new Version(1, 9, 1, 0);

        /// <summary>
        /// 2017-12-05 Carols, Candles and Candies DLC.
        /// </summary>
        public static readonly Version CarolsCandlesCandies = new Version(1, 9, 1, 0);

        /// <summary>
        /// 2017-12-05 Unity 5.6.4p2, dams and powerlines editable in asset editor.
        /// </summary>
        public static readonly Version Patch_1_9_1 = new Version(1, 9, 1, 0);

        /// <summary>
        /// 2018-03-09 ChirpX free expansion.
        /// </summary>
        public static readonly Version ChirpX = new Version(1, 9, 2, 1);

        /// <summary>
        /// 2018-03-09 Mars Radio free station.
        /// </summary>
        public static readonly Version MarsRadio = new Version(1, 9, 2, 1);

        /// <summary>
        /// 2018-03-09 ChirpX, Mars Radio.
        /// </summary>
        public static readonly Version Patch_1_9_2_f1 = new Version(1, 9, 2, 1);

        /// <summary>
        /// Hotfix.
        /// </summary>
        public static readonly Version Patch_1_9_3_f1 = new Version(1, 9, 3, 1);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2018-05-24 Park Life expansion.
        /// </summary>
        public static readonly Version ParkLife = new Version(1, 10, 0);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2018-10-23 Industries expansion.
        /// </summary>
        public static readonly Version Industries = new Version(1, 11, 0);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2019-05-21 Campus expansion.
        /// </summary>
        public static readonly Version Campus = new Version(1, 12, 0);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2020-01-22 Paradox Launcher fiasco.
        /// </summary>
        public static readonly Version ParadoxLauncher = new Version(1, 12, 3);

        // ----------------------------------------------------------------------

        /// <summary>
        /// 2020-03-26 Sunset Harbor expansion.
        /// </summary>
        public static readonly Version SunsetHarbor = new Version(1, 13, 0, 7);

        /// <summary>
        /// 2020-03-26 Modern Japan content pack.
        /// </summary>
        public static readonly Version ModernJapan = new Version(1, 13, 0, 7);

        /// <summary>
        /// 2020-03-26 Coast to Coast radio station.
        /// </summary>
        public static readonly Version CoastToCoastRadio = new Version(1, 13, 0, 7);

        /// <summary>
        /// 2020-03-26 Fishing industry, intercity bus, trolleybus, passenger helicopter,
        /// waste transfer system, inland water treatment, aviation club, child/elder care,
        /// overground metro, tutorial log, pedestrian path snap to quays, walkable quays.
        /// </summary>
        public static readonly Version Patch_1_13_0_f7 = new Version(1, 13, 0, 7);

        /// <summary>
        /// 2020-04-06 Hotfix.
        /// </summary>
        public static readonly Version Patch_1_13_0_f8 = new Version(1, 13, 0, 8);

        // ----------------------------------------------------------------------

        /// <summary>
        /// Returns version as a string in the format shown on Pardox Launcher screen.
        /// </summary>
        /// 
        /// <param name="version">The version to stringify.</param>
        /// 
        /// <returns>String represenation of the version.</returns>
        public static string GetVersionString(Version version) {
            return $"{version.ToString(3)}-f{version.Revision}";
        }

        /// <summary>
        /// Parses a date string from the Patches wiki page in to a <see cref="DateTime"/> instance.
        ///
        /// Format it expects is: <c>yyyy-mm-dd</c>.
        /// </summary>
        /// 
        /// <param name="dateStr">The string copied from <see cref="https://skylines.paradoxwikis.com/Patches"/>.</param>
        /// 
        /// <returns>A <see cref="DateTime"/> instance.</returns>
        public static DateTime PatchDate(string dateStr) {
            return DateTime.ParseExact(dateStr, "yyyy-mm-dd", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets the latest milestone version based on the active game version.
        ///
        /// It just replaces the build and revision with <c>0</c>.
        /// </summary>
        /// 
        /// <param name="active">The currently active game version.</param>
        /// 
        /// <returns>The milestone version.</returns>
        public static Version GetMilestone(Version active) {
            return new Version(active.Major, active.Minor, 0, 0);
        }

        /// <summary>
        /// Returns the game version as a <see cref="Version"/> instance.
        /// </summary>
        /// 
        /// <returns>Game version.</returns>
        public static Version GetGameVersion() {
            return new Version(
                Convert.ToInt32(BuildConfig.APPLICATION_VERSION_A),
                Convert.ToInt32(BuildConfig.APPLICATION_VERSION_B),
                Convert.ToInt32(BuildConfig.APPLICATION_VERSION_C),
                Convert.ToInt32(BuildConfig.APPLICATION_BUILD_NUMBER));
        }
    }
}
