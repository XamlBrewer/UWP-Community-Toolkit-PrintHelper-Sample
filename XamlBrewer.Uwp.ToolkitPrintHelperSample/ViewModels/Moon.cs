using System.Collections.Generic;

namespace XamlBrewer.Uwp.ToolkitPrintHelperSample
{
    public class Moon
    {
        public string Name { get; set; }

        public string ImagePath { get; set; }

        public string Planet { get; set; }

        public string Description { get; set; }

        public double Mass { get; set; } // Unit: Earths

        public double Albedo { get; set; }

        public double OrbitalEccentricity { get; set; }

        public static List<Moon> Moons
        {
            get
            {
                return new List<Moon>
                {
                    new Moon {
                        Name = "Callisto",
                        ImagePath = "ms-appx:///Assets/Moons/callisto.png",
                        Planet="Jupiter",
                        Description="With a diameter of over 2,985 miles (4,800 km), Callisto is the third largest moon in our solar system and is almost the size of Mercury. Callisto is the outermost of the Galilean satellites, and orbits beyond Jupiter's main radiation belts. It has the lowest density of the Galilean satellites (1.86 grams/cubic cm). Its interior is probably similar to Ganymede except the inner rocky core is smaller, and this core is surrounded by a large icy mantle. Callisto's surface is the darkest of the Galileans, but it is twice as bright as our own Moon. (Source: https://solarsystem.nasa.gov/moons/jupiter-moons/callisto/in-depth/)",
                        Mass = 0.018,
                        Albedo=0.22,
                        OrbitalEccentricity = 0.0074
                    },
                    new Moon
                    {
                        Name = "Europa",
                        ImagePath = "ms-appx:///Assets/Moons/europa.png",
                        Planet="Jupiter",
                        Description="Beneath the icy surface of Jupiter’s moon Europa is perhaps the most promising place to look for present-day environments suitable for life. Slightly smaller than Earth's moon, Europa’s water-ice surface is crisscrossed by long, linear fractures. Like our planet, Europa is thought to have an iron core, a rocky mantle and an ocean of salty water. Unlike Earth, however, Europa’s ocean lies below a shell of ice probably 10 to 15 miles (15 to 25 kilometers) thick and has an estimated depth of 40 to 100 miles (60 to 150 kilometers). While evidence for an internal ocean is strong, its presence awaits confirmation by a future mission.",
                        Mass = 0.008,
                        Albedo=0.67,
                        OrbitalEccentricity=0.009
                    },
                    new Moon
                    {
                        Name = "Ganymede",
                        ImagePath = "ms-appx:///Assets/Moons/ganymede.png",
                        Description = "Ganymede is the largest satellite in our solar system. It is larger than Mercury and Pluto, and three-quarters the size of Mars. If Ganymede orbited the sun instead of orbiting Jupiter, it would easily be classified as a planet. Ganymede has three main layers. A sphere of metallic iron at the center (the core, which generates a magnetic field), a spherical shell of rock (mantle) surrounding the core, and a spherical shell of mostly ice surrounding the rock shell and the core. The ice shell on the outside is very thick, maybe 800 km (497 miles) thick. The surface is the very top of the ice shell. Though it is mostly ice, the ice shell might contain some rock mixed in. Scientists believe there must be a fair amount of rock in the ice near the surface. Ganymede's magnetic field is embedded inside Jupiter's massive magnetosphere. Astronomers using the Hubble Space Telescope found evidence of thin oxygen atmosphere on Ganymede in 1996.The atmosphere is far too thin to support life as we know it.",
                        Mass =0.025,
                        Albedo=0.025,
                        OrbitalEccentricity=0.0013
                    },
                    new Moon
                    {
                        Name = "Not a Moon",
                        ImagePath = "ms-appx:///Assets/Moons/notamoon.png",
                        Description = "The first Death Star was stated to be more than 100 km to 160 km in diameter, depending on source. It was crewed by an estimated 1.7 million military personnel and 400,000 droids. Its superweapon delivered enough energies on a scale equivalent to all the energy released by the Sun in an entire week. The second Death Star was significantly larger, between 200 km to 400 km in diameter depending on source, and technologically more advanced than its predecessor. Both versions of these dwarf planet-sized fortresses were designed for massive power projection capabilities, capable of destroying multiple naval fleets or entire planets with one blast from their superlasers.",
                        Mass=0.001,
                        Albedo=0,
                        OrbitalEccentricity=0
                    }
                };
            }
        }
    }
}
