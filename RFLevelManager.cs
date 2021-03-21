﻿namespace RipFight
{
    public sealed class RFLevelManager
    {
        private const byte mapType = 0;

        private string[] levelNames = new string[125]
        {
            "MainScene","Woods1","Woods2","Woods3","Woods4","Desert2","Desert3","Desert4","Desert5","Desert6","Desert7","Desert8","Desert9","factory1","factory2","factory3","factory5","factory7","factory8","factory9","factory10","factory11","Castle1","Castle2","Castle3","Castle4","Castle5","Castle5b","Castle6","Castle7","Castle8","Castle9","Castle10","Castle11","Castle12","Castle13","Castle14","Castle15","Castle16","Western 1","Western 2","Western 3","Western 4","Western 5","Western 6","Western 7","Western 8","Ice1","Ice2","Ice3","Ice4","Ice5","Ice6","Ice7","Ice8","Ice9","Ice10","Ice11","Ice12","Laser1","Laser2","Laser3","Laser4","Laser5","Laser6","Laser7","Laser8","Castle17","Laser10","Ice13","factory14","factory13","factory12","Western 10","Western 11","Desert10","Desert11","Desert12","Ice16","Ice15","Ice14","Lava2","Lava6","Lava3","Lava4","Lava5","Lava7","Lava8","Lava9","Lava10","Lava11","Halloween2","HalloweenBoss1","Halloween3","Halloween4","HalloweenBoss2","Halloween8","Halloween9","HalloweenBoss3","Halloween10","Halloween12","HalloweenBoss4","STATS","LevelEditor","Xmas1","Xmas2","Xmas3","Xmas4","Xmas5","Xmas6","Xmas7","Xmas8","Xmas9","Xmas10","Xmas11","Xmas12","Xmas13","Xmas14","Xmas15","Xmas16","Xmas17","Xmas18","Xmas19","Xmas20","Xmas21"
        };

        public MapWrapper GetMapByIndex(byte index)
        {
            return new MapWrapper()
            {
                MapType = mapType,
                MapData = new byte[] { index, 0, 0, 0 }
            };
        }

        public MapWrapper GetMapByName(string name)
        {
            byte mapIndex = 0;

            for (int i = 0; i < levelNames.Length; i++)
            {
                if (levelNames[i].ToLower() == name)
                    mapIndex = (byte)i;
            }

            return new MapWrapper()
            {
                MapType = mapType,
                MapData = new byte[] { mapIndex, 0, 0, 0 }
            };
        }
    }
}