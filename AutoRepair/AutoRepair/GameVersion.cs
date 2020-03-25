namespace AutoRepair {
    using System;

    /// <summary>
    /// Game versions by expansion DLC.
    /// </summary>
    public class GameVersion {

        // date format: yyyy-mm-dd

        /// <summary>
        /// Gets the active game version (Major, minor, patch).
        /// </summary>
        public static Version Active => GetGameVersion();

        /// <summary>
        /// 2015-03-10 Release version. Used as default for all items.
        /// </summary>
        public static readonly Version DefaultRelease = new Version(0, 0, 0);

        /// <summary>
        /// Default for BrokenBy.
        /// </summary>
        public static readonly Version DefaultUntil = new Version(9, 9, 9);

        /// <summary>
        /// 2015-03-10 Initial release of Cities: Skylines.
        /// </summary>
        public static readonly Version InitialRelease = new Version(1, 0, 5);

        /// <summary>
        /// 2015-05-19 European buildings added.
        /// </summary>
        public static readonly Version EuropeBuildings = new Version(1, 1, 0);

        /// <summary>
        /// 2015-09-24 After Dark expansion.
        /// </summary>
        public static readonly Version AfterDark = new Version(1, 2, 0);

        /// <summary>
        /// 2016-02-18 Snowfall expansion.
        /// </summary>
        public static readonly Version Snowfall = new Version(1, 3, 0);

        /// <summary>
        /// 2016-06-09 Match Day free expansion.
        /// </summary>
        public static readonly Version MatchDay = new Version(1, 5, 0);

        /// <summary>
        /// 2016-11-29 Natural Disasters expansion.
        /// </summary>
        public static readonly Version NaturalDisasters = new Version(1, 6, 0);

        /// <summary>
        /// 2017-05-18 Mass Transit expansion.
        /// </summary>
        public static readonly Version MassTransit = new Version(1, 7, 0);

        /// <summary>
        /// 2017-08-17 Concerts expansion.
        /// </summary>
        public static readonly Version Concerts = new Version(1, 8, 0);

        /// <summary>
        /// 2017-10-19 Green Cities expansion.
        /// </summary>
        public static readonly Version GreenCities = new Version(1, 9, 0);

        /// <summary>
        /// ChirpX free expansion.
        /// </summary>
        public static readonly Version ChirpX = new Version(1, 9, 2);

        /// <summary>
        /// 2018-05-24 Park Life expansion.
        /// </summary>
        public static readonly Version ParkLife = new Version(1, 10, 0);

        /// <summary>
        /// 2018-10-23 Industries expansion.
        /// </summary>
        public static readonly Version Industries = new Version(1, 11, 0);

        /// <summary>
        /// 2019-05-21 Campus expansion.
        /// </summary>
        public static readonly Version Campus = new Version(1, 12, 0);

        /// <summary>
        /// 2020-01-22 Paradox Launcher fiasco.
        /// </summary>
        public static readonly Version PdxLauncher = new Version(1, 12, 3);

        /// <summary>
        /// 2020-03-26 Sunset Harbor expansion.
        /// </summary>
        public static readonly Version SunsetHarbor = new Version(1, 13, 0);

        /// <summary>
        /// Returns the game version as a <see cref="Version"/> instance.
        /// </summary>
        /// 
        /// <returns>Game version.</returns>
        public static Version GetGameVersion() {
            return new Version(
                Convert.ToInt32(BuildConfig.APPLICATION_VERSION_A),
                Convert.ToInt32(BuildConfig.APPLICATION_VERSION_B),
                Convert.ToInt32(BuildConfig.APPLICATION_VERSION_C));
        }
    }
}
