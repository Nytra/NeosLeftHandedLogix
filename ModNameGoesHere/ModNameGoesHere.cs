using HarmonyLib;
using NeosModLoader;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace ModNameGoesHere
{
    public class ModNameGoesHere : NeosMod
    {
        public override string Name => "ModNameGoesHere";
        public override string Author => "username";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/GithubUsername/RepoName/";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("net.username.Template");
            harmony.PatchAll();
        }
		
        [HarmonyPatch(typeof(LogixNode), "GenerateConnectPoint")]
        class ModNameGoesHerePatch
        {
            public static bool Prefix(ref bool outputSide, ref bool isOutput)
            {
                outputSide = !outputSide;
                isOutput = !isOutput;
                return true;
            }
        }
    }
}