/*
 * Copyright (C) 2021 Jerry Verhoeven - All Rights Reserved
 * You may use, distribute and modify this code under the terms of the MIT license.
 */

using UnityEngine;
using UnityEditor;

public class GUIDGenerator : EditorWindow
{
    private string m_GUID = "";

    [MenuItem("Tools/GUID Generator...", false, 0)]
    private static void Init()
    {
        //Create EditorWindow
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