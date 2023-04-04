using Godot;
using System.Collections.Generic;

namespace CivilizationsRoad.Scripts.Common;

public static class Variables
{
    
    public static class Program
    {
        public static string ProgramMainSceneName = "ProgramMain";

        public static HashSet<string> ResourcePaths = new()
        {
            "res://Scenes/Program/ProgramMain.tscn",
            "res://Scenes/Game/TestGameScene.tscn"
        };

        public static Dictionary<string, Resource> Resources = new();
    }

   
}
