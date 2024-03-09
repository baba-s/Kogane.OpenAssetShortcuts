using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
    [FilePath( "UserSettings/Kogane/OpenAssetShortcutsSetting.asset", FilePathAttribute.Location.ProjectFolder )]
    internal sealed class OpenAssetShortcutsSetting : ScriptableSingleton<OpenAssetShortcutsSetting>
    {
        [SerializeField] private Object[] m_assets = new Object[ 10 ];

        public IReadOnlyList<Object> Assets => m_assets;

        public void Save()
        {
            Save( true );
        }
    }
}