using UnityEditor;
using UnityEditor.ShortcutManagement;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Kogane.Internal
{
    internal static class OpenAssetShortcuts
    {
        [Shortcut( "Kogane/Open Asset Shortcuts/Open Asset 1", KeyCode.Alpha1, ShortcutModifiers.Alt )]
        private static void OpenAsset1() => OpenAsset( OpenAssetShortcutsSetting.instance.Assets[ 0 ] );

        [Shortcut( "Kogane/Open Asset Shortcuts/Open Asset 2", KeyCode.Alpha2, ShortcutModifiers.Alt )]
        private static void OpenAsset2() => OpenAsset( OpenAssetShortcutsSetting.instance.Assets[ 1 ] );

        [Shortcut( "Kogane/Open Asset Shortcuts/Open Asset 3", KeyCode.Alpha3, ShortcutModifiers.Alt )]
        private static void OpenAsset3() => OpenAsset( OpenAssetShortcutsSetting.instance.Assets[ 2 ] );

        [Shortcut( "Kogane/Open Asset Shortcuts/Open Asset 4", KeyCode.Alpha4, ShortcutModifiers.Alt )]
        private static void OpenAsset4() => OpenAsset( OpenAssetShortcutsSetting.instance.Assets[ 3 ] );

        [Shortcut( "Kogane/Open Asset Shortcuts/Open Asset 5", KeyCode.Alpha5, ShortcutModifiers.Alt )]
        private static void OpenAsset5() => OpenAsset( OpenAssetShortcutsSetting.instance.Assets[ 4 ] );

        [Shortcut( "Kogane/Open Asset Shortcuts/Open Asset 6", KeyCode.Alpha6, ShortcutModifiers.Alt )]
        private static void OpenAsset6() => OpenAsset( OpenAssetShortcutsSetting.instance.Assets[ 5 ] );

        [Shortcut( "Kogane/Open Asset Shortcuts/Open Asset 7", KeyCode.Alpha7, ShortcutModifiers.Alt )]
        private static void OpenAsset7() => OpenAsset( OpenAssetShortcutsSetting.instance.Assets[ 6 ] );

        [Shortcut( "Kogane/Open Asset Shortcuts/Open Asset 8", KeyCode.Alpha8, ShortcutModifiers.Alt )]
        private static void OpenAsset8() => OpenAsset( OpenAssetShortcutsSetting.instance.Assets[ 7 ] );

        [Shortcut( "Kogane/Open Asset Shortcuts/Open Asset 9", KeyCode.Alpha9, ShortcutModifiers.Alt )]
        private static void OpenAsset9() => OpenAsset( OpenAssetShortcutsSetting.instance.Assets[ 8 ] );

        [Shortcut( "Kogane/Open Asset Shortcuts/Open Asset 0", KeyCode.Alpha0, ShortcutModifiers.Alt )]
        private static void OpenAsset0() => OpenAsset( OpenAssetShortcutsSetting.instance.Assets[ 9 ] );

        private static void OpenAsset( Object asset )
        {
            if ( asset == null )
            {
                SettingsService.OpenProjectSettings( OpenAssetShortcutsSettingProvider.PATH );
                return;
            }

            var assetPath = AssetDatabase.GetAssetPath( asset );

            if ( string.IsNullOrEmpty( assetPath ) ) return;

            AssetDatabase.OpenAsset( asset );
        }
    }
}