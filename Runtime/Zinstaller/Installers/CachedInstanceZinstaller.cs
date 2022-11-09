using System;

namespace ZenjectExtensions.Zinstallers
{
    public abstract class CachedInstanceZinstaller<TypeToInstall> : Zinstaller
    {
        protected TypeToInstall _typeToInstall;

        public override void Install()
        {
            _typeToInstall = GetInitializedClass();

            Container.Bind<TypeToInstall>().FromInstance(_typeToInstall).AsCached();
        }

        protected abstract TypeToInstall GetInitializedClass();

        private void OnDestroy()
        {
            if (_typeToInstall is IDisposable)
                (_typeToInstall as IDisposable).Dispose();
        }
    }
}