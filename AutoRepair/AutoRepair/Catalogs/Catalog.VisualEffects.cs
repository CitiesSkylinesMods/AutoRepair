namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Cubemaps, weather, disasters, graphics rendering, etc.
    ///
    /// See also: <c>Catalog.VehicleEffects.cs</c>.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void VisualEffectsCatalog() {

            string catalog = "VisualEffects";

            /*
            # ███    ███  ██████  ██████  ███████
            # ████  ████ ██    ██ ██   ██ ██
            # ██ ████ ██ ██    ██ ██   ██ ███████
            # ██  ██  ██ ██    ██ ██   ██      ██
            # ██      ██  ██████  ██████  ███████
            */

            AddMod(new Item(1886877404u, "Custom Effect Loader") {
                Affect = Factor.Rendering
                       | Factor.Textures,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1889349343u, Status.Recommended },
                    { 1886961495u, Status.Recommended },
                    // If active, some vehicles will get hard-dependency for Custom Effect Loader:
                    { 800820816u , Status.MinorIssues }, // Extended Asset Editor
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.EditorMod // assets created with it require it
                      | ItemFlags.MinorBugs // can become hard dependency for vehicle assets if Extended Asset Editor active
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/boformer/CustomEffectLoader",
            });

            AddMod(new Item(1883101331u, "Persistent Fog Adjuster") {
                Affect = Factor.Environment,
                Authors = "Cgameworld",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 672248733u, Status.MinorIssues }, // Ultimate Eyecandy v1.5.2 (UE setting overriden by PFA setting)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Cgameworld/PersistentFogAdjuster",
                Tags = new[] { "Fog", "Mist", "Cloud", "Weather", "Eyecandy" },
            });

            AddMod(new Item(1794015399u, "Render It!") {
                Affect = Factor.Environment
                       | Factor.Rendering,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1794015399u, Status.Incompatible }, // Render It!
                    { 1138510774u, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 412146081u , Status.Incompatible }, // PostProcessFX v1.9.0
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // harmony patch management could be better, TAA is shit
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/keallu/CSL-RenderIt",
                Tags = new[] { "Effects", "Visual", "Graphics", "Eyecandy" },
            });

            // todo: check if source still obfu
            AddMod(new Item(1760945529u, "Terrain Level Of Detail (TLOD)") {
                Affect = Factor.Environment
                       | Factor.Rendering
                       | Factor.Textures,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1680642819u, Status.Required }, // Ultimate Level Of Detail (ULOD)
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                Tags = new[] { "LODs", "Detail", "Graphics", "Eyecandy", "Terrain", "Map" },
            });

            // LOD toggler has conflicting shortcut, and is also obsoleted by ULOD
            AddMod(new Item(1680642819u, "Ultimate Level Of Detail (ULOD)") {
                Affect = Factor.Rendering
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 898480258u, Status.Recommended  }, // Camera Positions Utility
                    { 812713438u, Status.Recommended  }, // Dynamic Resolution (Fixed for 1.9!)
                    { 625608461u, Status.Recommended  }, // Adaptive Prop Visibility Distance
                    { 561888259u, Status.Incompatible }, // LOD Toggler (deprecated)
                    { 556784825u, Status.Recommended  }, // Random Tree Rotation
                },
                ContinuationOf = 561888259u, // LOD Toggler (deprecated)
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/boformer/UltimateLevelOfDetail",
                Tags = new[] { "LODs", "Detail", "Graphics", "Eyecandy", "Trees", "Props", "Buildings", "Networks", "Decals" },
            });

            // Some Daylight Classic settings conflict with Relight
            // Game engine issues: Shadow acne vs. Shadow detachment
            AddMod(new Item(1209581656u, "Relight") {
                Affect = Factor.Environment
                       | Factor.Rendering,
                Authors = "Ronyx69, TPB, Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1889738001u, Status.Recommended  }, // Real Neutral LUT - for Relight, Daylight Classic and Vanilla
                    { 1539183804u, Status.Recommended  }, // Testing LUTs (for asset creators)
                    { 1539181199u, Status.Recommended  }, // More Relight LUTs
                    { 1414802020u, Status.Recommended  }, // Color & Material Test Charts
                    { 1122189715u, Status.Recommended  }, // Realtime (for asset creators)
                    { 762520291u , Status.Recommended  }, // Shadow Strength Adjuster
                    { 672248733u , Status.Recommended  }, // Ultimate Eye Candy
                    { 643364914u , Status.Incompatible }, // Softer Shadows
                    { 530871278u , Status.MinorIssues  }, // Daylight Classic
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/ronyx69/a75400389e7561164bacabadf0095a2b",
                Tags = new[] { "Render", "Lighting", "Eyecandy", "Brightness", "Gamma", "Contrast", "Temperature", "Tint", "Sun", "Sky", "Moon", "Tonemapping" },
            });

            AddMod(new Item(1183931915u, "Cubemap Replacer") {
                Affect = Factor.Environment
                       | Factor.Rendering,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1209581656u, Status.Recommended }, // Relight
                    { 1183931915u, Status.Compatible  }, // Cubemap Replacer
                    { 1138510774u, Status.Recommended }, // PostProcessFX - Multi-platform
                    { 530871278u , Status.Required    }, // Daylight classic (classic fog efffect option must be enabled)
                    { 412146081u , Status.Compatible  }, // PostProcessFX v1.9.0
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/bloodypenguin/Skylines-CubemapReplacer",
                Tags = new[] { "Cubemap", "Sky", "Environment", "Stars", "Clouds" },
            });

            AddMod(new Item(1138510774u, "PostProcessFX - Multi-platform") {
                Affect = Factor.Rendering,
                Authors = "cor3ntin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1794015399u, Status.Incompatible }, // Render It!
                    { 1183931915u, Status.Compatible   }, // Cubemap Replacer
                    { 1138510774u, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 412146081u , Status.Incompatible }, // PostProcessFX v1.9.0
                    // recommend: dynamic resolution
                    // recommend: sun shafts
                },
                ContinuationOf = 412146081u, // PostProcessFX v1.9.0
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // some users have problems opening GUI
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // some users say it stopped working
                Notes = new[] {
                    "Keycodes for shortcut key config: https://pastebin.com/qe5BwdA2",
                },
                Tags = new[] { "Render", "Lighting", "Eyecandy", "Bloom", "Lensflare", "FXAA", "TAA", "Ambient Occlusion", "Grain", "Sun shafts" },
            });

            AddMod(new Item(940299505u, "AnimUV Params") {
                Affect = Factor.Props
                       | Factor.Rendering,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceUnavailable,
                Notes = new[] {
                    "Asset creators: See https://cslmodding.info/shader/animuv/",
                },
            });

            AddMod(new Item(412146081u, "PostProcessFX v1.9.0") {
                Affect = Factor.Rendering,
                Authors = "MazK",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1794015399u, Status.Incompatible }, // Render It!
                    { 1183931915u, Status.Compatible   }, // Cubemap Replacer
                    { 1138510774u, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 412146081u , Status.Incompatible }, // PostProcessFX v1.9.0
                    // recommend: dynamic resolution
                    // recommend: sun shafts
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete // newer version available: 1138510774u
                      | ItemFlags.MinorBugs // some users have problems displaying the GUI
                      | ItemFlags.SourceUnavailable,
                Notes = new[] {
                    "Keycodes for shortcut key config: https://pastebin.com/qe5BwdA2",
                },
                ReplaceWith = 1138510774u, // PostProcessFX - Multi-platform
                Tags = new[] { "Render", "Lighting", "Eyecandy", "Bloom", "Lensflare", "FXAA", "SMAA", "Ambient Occlusion" },
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(959894658u, "Custom Light Effects") {
                Affect = Factor.Rendering
                       | Factor.Textures,
                Authors = "Ronyx69, vasimr22",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // memory leaks = crashes
                      | ItemFlags.SourceUnavailable,
                Notes = new[] {
                    "This mod causes memory leaks which eventually result in lag then crash to desktop.",
                    "Use Custom Effect Loader mod instead.",
                },
                ReplaceWith = 1886877404u, // Custom Effects Loader
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            AddMod(new Item(1980656676u, "MARS Sky - Cubemap Replacer Pack") {
                Affect = Factor.Environment,
                Authors = "citywokcitywall",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915u, Status.Required    }, // Cubemap Replacer
                },
                Flags = ItemFlags.LargeFileWarning
                      | ItemFlags.SourceUnavailable,
                Tags = new[] { "Cubemap", "4K", "Sky", "Mars", "Environment" },
            });

            AddMod(new Item(1771841274u, "HDRI Haven Cubemap Pack 2") {
                Affect = Factor.Environment,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915u, Status.Required }, // Cubemap replacer
                },
                Flags = ItemFlags.LargeFileWarning
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://hdrihaven.com/",
                Tags = new[] { "Cubemap", "2K", "Sky", "Earth", "Day", "Sunny", "Dusk", "Night", "Sunset", "Weather", "Environment" },
            });

            AddMod(new Item(1591584836u, "HDRI 2K Cubemap Pack") {
                Affect = Factor.Environment,
                Authors = "Sparks",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915u, Status.Required }, // Cubemap replacer
                },
                Flags = ItemFlags.LargeFileWarning
                      | ItemFlags.SourceAvailable,
                SourceURL = "http://noemotionhdrs.net/hdrday.html",
                Tags = new[] { "Cubemap", "2K", "Sky", "Earth", "Day", "Sunny", "Sunset", "Weather", "Environment" },
            });

            AddMod(new Item(1585691173u, "HDRI Haven Cubemap Pack") {
                Affect = Factor.Environment,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915u, Status.Required }, // Cubemap replacer
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://hdrihaven.com/",
                Tags = new[] { "Cubemap", "1K", "Sky", "Earth", "Sunset", "Weather", "Environment" },
            });

            AddMod(new Item(1186800787u, "Pastel Cubemap Pack") {
                Affect = Factor.Environment,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915u, Status.Required }, // Cubemap replacer
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://imgur.com/a/WSGJ5",
                Tags = new[] { "Cubemap", "1K", "Sky", "Earth", "Sunset", "Weather", "Environment" },
            });
        }
    }
}