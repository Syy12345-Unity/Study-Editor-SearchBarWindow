using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SearchBarWindow : EditorWindow {
    [MenuItem("Tools/SearchBarWindow")]
    public static void Open()
    {
        GetWindow<SearchBarWindow>();
    }

    string search;

    void OnGUI()
    {
        using(new EditorGUILayout.HorizontalScope()){
            GUILayout.Label("label:", GUILayout.Width(30));
            GUI.SetNextControlName("searchControl");
            search = GUILayout.TextField(search, "SearchTextField", GUILayout.Width(119));
            GUI.FocusControl("searchControl");
            if(!string.IsNullOrEmpty(search))
            {
                if (GUILayout.Button("", "SearchCancelButton"))
                {
                    search = string.Empty;
                }
            } else {
                if(GUILayout.Button("","SearchCancelButtonEmpty"))
                {

                }
            }
        }

        EditorGUILayout.LabelField(search);
    }
}
