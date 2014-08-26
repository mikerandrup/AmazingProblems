using System;
using System.Collections.Generic;

namespace Problems.ChemSpell.EnglishWordProvider
{
    public static class WordProvider
    {
        private static IEnumerable<String> _words;
        public static IEnumerable<String> WordsSortedByLengthDescending
        {
            get
            {
                if (_words == null)
                {
                    _words = new List<String>()
                    {
                        "lopadotemachoselachogaleokranioleipsanodrimhypotrimmatosilphioparaomelitokatakechymenokichlepikossyphophattoperisteralektryonoptekephalliokigklopeleiolagoiosiraiobaphetraganopterygon",
                        "pneumonoultramicroscopicsilicovolcanoconiosis",
                        "supercalifragilisticexpialidocious",
                        "pseudopseudohypoparathyroidism",
                        "floccinaucinihilipilification",
                        "pseudopseudohypoparathyroidism",
                        "antidisestablishmentarianism",
                        "hepaticocholangiogastrostomy",
                        "spectrophotofluorometrically",
                        "honorificabilitudinitatibus",
                        "psychoneuroendocrinological",
                        "pneumoencephalographically",
                        "radioimmunoelectrophoresis",
                        "immunoelectrophoretically",
                        "psychophysicotherapeutics",
                        "thyroparathyroidectomized",
                        "otorhinolaryngological",
                        "parastratiosphecomyia",
                        "stratiosphecomyioides",
                        "subdermatoglyphic"
                    };
                }
                return _words;
            }
        }
    }
}