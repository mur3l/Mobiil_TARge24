using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury1m.png",
                Description = "Mercury is the first planet from the Sun and " +
                "the smallest in the Solar System. It is a rocky planet" +
                " with a trace atmosphere and a surface gravity slightly higher " +
                "than that of Mars. The surface of Mercury is similar to Earth's " +
                "Moon, being heavily cratered, with an expansive rupes system " +
                "generated from thrust faults, and bright ray systems, formed by " +
                "ejecta. Its largest crater, Caloris Planitia, has a diameter " +
                "of 1,550 km (960 mi), which is about one-third the diameter of " +
                "the planet (4,880 km or 3,030 mi)",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "mercury1m.jpg",
                    "mercury2m.jpg",
                    "mercury3m.jpg",
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "Similar size to Earth",
                HeroImage = "venus1v.jpg",
                Description = "covered in thick clouds of carbon dioxide. It has an extreme greenhouse effect, making it the hottest planet in the Solar System.",
                AccentColorStart = Color.FromArgb("##a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "venus1v.jpg",
                    "venus2v.jpg",
                    "venus3c.jpg",
                    "venus4v.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "Our home planet.",
                HeroImage = "earth1e.png",
                Description = "Our home planet, the only known world with liquid water on the surface and life. It has a balanced atmosphere of nitrogen and oxygen.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "earth1e.png",
                    "earth2e.jpg",
                    "earth3e.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "Known as the Red Planet.",
                HeroImage = "mars1m.jpg",
                Description = "It has the largest volcano (Olympus Mons) and a thin atmosphere, with evidence of ancient water.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "mars1m.jpg",
                    "mars2m.jpg",
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The largest planet..",
                HeroImage = "jupiter1j.jpg",
                Description = "Gas giant with strong storms (like the Great Red Spot). It has a strong magnetic field and dozens of moons, including Ganymede, the largest in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "jupiter1j.jpg",
                    "jupiter2j.jpg",
                    "jupiter3j.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "Famous for its spectacular rings",
                HeroImage = "saturn1s.jpg",
                Description = "Made of ice and rock. It’s a gas giant with many moons, including Titan, which has lakes of liquid methane.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "saturn1s.jpg",
                    "saturn2s.jpg",
                    "saturn3s.jpg",
                    "saturn4s.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "Ice giant.",
                HeroImage = "uran1u.jpg",
                Description = "Rotates on its side, making its seasons extreme. Its atmosphere contains methane, giving it a pale blue color.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "uran1u.jpg",
                    "uran2u.jpg",
                    "uran3u.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "Farthest planet from the Sun.",
                HeroImage = "neptun1n.jpg",
                Description = "Deep blue ice giant with supersonic winds and the moon Triton.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "neptun1n.jpg",
                    "neptun2n.jpg",
                    "neptun3n.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            new()
            {
                Name = "Pluto",
                Subtitle = "In 2006 it was reclassified as a dwarf planet.",
                HeroImage = "pluto.jpg",
                Description = "Deep blue ice giant with supersonic winds and the moon Triton.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "pluto.jpg",
                    "https://cdn.mos.cms.futurecdn.net/DoZSMXF87kCuzbymsuEFHo.jpg"
                }
            },

            new()
            {
                Name = "Ceres",
                Subtitle = "The only dwarf planet in the inner solar system..",
                HeroImage = "ceres.jpg",
                Description = "Ceres is unique among the five because it resides in the asteroid belt between Mars and Jupiter, It is the largest object in the asteroid belt and was visited by NASA’s Dawn mission in 2015, the first spacecraft to orbit a dwarf planet.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "ceres.jpg",
                    "https://cdn.mos.cms.futurecdn.net/v2/t:0,l:420,cw:1080,ch:1080,q:80,w:1080/qnft8kRfeGWWLgaygo4fb9.jpg"
                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "Is highly elongated (oval-shaped).",
                HeroImage = "haumea.jpg",
                Description = "It's one of the fastest spinning large objects in the solar system. Because of this fast spin, its shape is distorted, more like a football than a sphere.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "haumea.jpg",
                    "https://cdn.mos.cms.futurecdn.net/v2/t:25,l:0,cw:1024,ch:768,q:80,w:1024/FLYgpN3GGHzkyNY8wr8B2M.jpg"
                }
            },

            new()
            {
                Name = "Makemake",
                Subtitle = "lies in the Kuiper Belt beyond Neptune, along with Pluto, Haumea, and Eris.",
                HeroImage = "makemake.jpg",
                Description = "It is slightly smaller than Pluto and is known for being the second-brightest object in the Kuiper Belt (after Pluto) as observed from Earth.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "makemake.jpg",
                    "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg"
                }
            },

            new()
            {
                Name = "Eris",
                Subtitle = "Eris is one of the largest known dwarf planets and is comparable in size to Pluto.",
                HeroImage = "eris.jpg",
                Description = "it orbits much farther from the Sun — about three times farther in many dimensions. The discovery of Eris was one of the factors that pushed astronomers to revisit and refine the definition of a planet, which led to the 2006 IAU decision.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "eris.jpg",
                    "https://cdn.mos.cms.futurecdn.net/ufTfK2rbpQXZBjt2ZPsm57.jpg"
                }
            },
        };


        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}