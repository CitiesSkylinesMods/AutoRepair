using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair.Catalogs {
    public partial class Camera {
        private void AddModsToList() {
            // Camera control via SpaceMouse
            Add(new Item(2021361606u, "SpaceMouse for CSL") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/graealex/CSL-SpaceMouse",
            });

            // Stereoscopic camera (split screen)
            // todo: prolly incompat with first person camera mods
            Add(1828737770u, "StereoscopicView");

            Add(new Item(1756089251u, "Zoom It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
            });

            // Camera control by joystick
            Add(new Item(1721824249u, "Joystick Camera Control") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/RenaKunisaki/CSL-JoystickCameraControl",
            });

            Add(new Item(1721823173u, "NoOffScreenScroll") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/RenaKunisaki/CSL-NoOffScreenScroll",
            });

            Add(new Item(1406625743u, "EnhancedZoomContinued") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://drive.google.com/file/d/1n9Bga69WamgKPk8rsWDjdJOSEJBTLNId",
                IncompatibleMods = new List<ulong>() {
                    { 411016892u }, // Enhanced Zoom (no longer in workshop)
                    { 651056665u }, // Enhanced Zoom Continued (no longer in workshop)
                    // other camera mods?
                },
            });

        }
    }
}
