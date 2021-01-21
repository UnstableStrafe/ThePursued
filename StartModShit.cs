using System.Linq;
using ItemAPI;

namespace ThePursued
{
    public class StartModShit : ETGModule
    {
        public static readonly string Modname = "The Pursued";
        public static readonly string Version = "1";
        public static readonly string Color = "#FCA4E2";
        public override void Start()
        {
            ItemAPI.FakePrefabHooks.Init();
            ItemBuilder.Init();
            PhantomPistol.Add();
            TemporalShift.Init();
            PhaseBurst.Init();
            Log($"{Modname} v{Version} started successfully.", Color);
        }
        public override void Exit()
        {

        }
        public static void Log(string text, string color = "FFFFFF")
        {
            ETGModConsole.Log($"<color={color}>{text}</color>");
        }

        public override void Init()
        {

        }
    }
}
