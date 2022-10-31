using UnityEngine;
using Zenject;

namespace ZenjectExtensions.Zinstallers
{
    public abstract class Zinstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Install();
        }

        public abstract void Install();
    }
}