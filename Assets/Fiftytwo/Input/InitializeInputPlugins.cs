using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.iOS;
using UnityEngine.InputSystem.Layouts;


namespace Fiftytwo
{
    public static class InitializeInputPlugins
    {
#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [RuntimeInitializeOnLoadMethod( RuntimeInitializeLoadType.BeforeSceneLoad )]
#endif
        private static void Initialize ()
        {
#if UNITY_EDITOR || UNITY_IOS || UNITY_TVOS
            InputSystem.RegisterLayout<iOSGameControllerRemote>(
                matches: new InputDeviceMatcher()
                    .WithInterface( "iOS", false )
                    .WithDeviceClass( "iOSGameController", false )
                    .WithProduct( "Remote", false )
            );
#endif
        }
    }
}
