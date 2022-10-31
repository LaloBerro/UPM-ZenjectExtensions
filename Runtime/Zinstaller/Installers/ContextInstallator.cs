using UnityEngine;
using Zenject;

namespace ZenjectExtensions.Zinstallers
{
    public class ContextInstallator : Zinstaller
    {
        [Header("References")]
        [SerializeField] private RunnableContext[] _contexts;

        public override void Install()
        {
            foreach (var context in _contexts)
            {
                context.Run();
            }
        }
    }
}