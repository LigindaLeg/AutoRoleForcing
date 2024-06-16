using System.ComponentModel;
using Exiled.API.Interfaces;

namespace AutoRoleForcing
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Are debug messages displayed?")]
        public bool Debug { get; set; } = false;

        [Description("What role should spawning?\n(Tutorial, SCP173, SCP049, SCP106, SCP079, SCP096, SCP3114, DClass, Scientist, NTF, CI, Security)")]

        public string ForceRole { get; set; } = "DClass";
    }
}
