using static NWN.NWScript;

namespace PluginTest
{
    public class MyPlugin
    {
        public void Test()
        {
            SendMessageToPC(GetFirstPC(), "Hello from plugin test");
        }
    }
}
