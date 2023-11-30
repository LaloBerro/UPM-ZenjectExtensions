using System;

namespace ZenjectExtensions.Zinstallers
{
    public abstract class InstanceZinstaller<TypeToInstall> : Zinstaller
    {
        protected TypeToInstall _typeToInstall;

        public override void Install()
        {
            _typeToInstall = GetInitializedClass();

            Container.Bind<TypeToInstall>().FromInstance(_typeToInstall).AsSingle();
        }

        protected abstract TypeToInstall GetInitializedClass();

        protected virtual void OnDestroy()
        {
            if (_typeToInstall is IDisposable disposable)
                disposable.Dispose();
        }
    }
}