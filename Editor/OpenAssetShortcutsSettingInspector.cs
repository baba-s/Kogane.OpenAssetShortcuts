using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace Kogane.Internal
{
    [CustomEditor( typeof( OpenAssetShortcutsSetting ) )]
    internal sealed class OpenAssetShortcutsSettingInspector : Editor
    {
        private ReorderableList m_reorderableList;

        private void OnEnable()
        {
            var assetsProperty = serializedObject.FindProperty( "m_assets" );

            m_reorderableList = new ReorderableList( serializedObject, assetsProperty )
            {
                displayAdd          = false,
                displayRemove       = false,
                drawElementCallback = OnDrawElement,
                footerHeight        = 0,
                headerHeight        = 0,
            };

            void OnDrawElement
            (
                Rect rect,
                int  index,
                bool isActive,
                bool isFocused
            )
            {
                const int labelWidth = 72;

                rect.y      += 1;
                rect.height -= 2;

                var labelRect    = new Rect( rect ) { width = labelWidth };
                var propertyRect = new Rect( rect ) { x     = labelWidth };

                propertyRect.width -= labelWidth * 0.75f;

                EditorGUI.LabelField
                (
                    position: labelRect,
                    label: new GUIContent( $"Alt + {( ( index + 1 ) % 10 ).ToString()}" )
                );

                var arrayElement = assetsProperty.GetArrayElementAtIndex( index );

                arrayElement.objectReferenceValue = EditorGUI.ObjectField
                (
                    position: propertyRect,
                    label: new GUIContent( "" ),
                    obj: arrayElement.objectReferenceValue,
                    objType: typeof( Object ),
                    allowSceneObjects: false
                );
            }
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            m_reorderableList.DoLayoutList();
            serializedObject.ApplyModifiedProperties();
        }
    }
}