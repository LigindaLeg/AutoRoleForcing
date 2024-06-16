using System;
using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using Exiled.Events.Features;
using Exiled.Events.EventArgs.Server;
using MEC;
using PlayerRoles;

namespace AutoRoleForcing 
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "AutoRoleForcing";
        public override string Author => "Liginda";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 9, 5);

        public static Plugin Instance;
        private EventHandlers _handlers;

        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();


            Log.Info("AutoRoleForcing was enabled.");
            Exiled.Events.Handlers.Server.RoundStarted += AutoRoleForce;
            base.OnEnabled();
        }

        /// <summary>
        /// Вызывается при отключении плагина.
        /// </summary>
        public override void OnDisabled()
        {
            Instance = null;
            UnregisterEvents();

            Log.Info("AutoRoleForcing was disabled.");
            Exiled.Events.Handlers.Server.RoundStarted -= AutoRoleForce;
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            // Регистрация обработчиков событий
            _handlers = new EventHandlers();
        }

        private void UnregisterEvents()
        {
            // Отмена регистрации обработчиков событий
            _handlers = null;
        }

        public void AutoRoleForce()
        {
            switch (Plugin.Instance.Config.ForceRole)
            {
                case "DClass":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.ClassD);
                    }
                    break;
                case "Tutorial":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.Tutorial);
                    }
                    break;
                case "SCP173":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.Scp173);
                    }
                    break;
                case "SCP049":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.Scp049);
                    }
                    break;
                case "SCP106":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.Scp106);
                    }
                    break;
                case "SCP079":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.Scp079);
                    }
                    break;
                case "SCP096":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.Scp096);
                    }
                    break;
                case "SCP3114":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.Scp3114);
                    }
                    break;
                case "Scientist":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.Scientist);
                    }
                    break;
                case "NTF":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.NtfCaptain);
                    }
                    break;
                case "CI":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.ChaosRepressor);
                    }
                    break;
                case "Security":
                    foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
                    {
                        player.Role.Set(RoleTypeId.FacilityGuard);
                    }
                    break;
                default:
                    Log.Error("Error, incorrect role specified in the config\nRole list:\nTutorial\nSCP173\nSCP049\nSCP106\nSCP079\nSCP096\nSCP3114\nDClass\nScientist\nNTF\nCI\nSecurity");
                    break;
            }
        }
    }
}
