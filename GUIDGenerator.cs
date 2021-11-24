using UnityEngine;
using UnityEditor;

public class GUIDGenerator : EditorWindow
{
    private string m_GUID = "";

    [MenuItem("Tools/GUID Generator...", false, 0)]
    private static void Init()
    {
        GUIDGenerator window = (GUIDGenerator)EditorWindow.GetWindow(typeof(GUIDGenerator));
    }

    private void OnGUI()
    {
        m_GUID = EditorGUILayout.TextField("GUID (Unique ID):", m_GUID);

        if (GUILayout.Button("Generate"))
        {
            m_GUID = System.Guid.NewGuid().ToString();
        }
    }
}