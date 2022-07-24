using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GritManager))]
public class CustomInspector : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GritManager gm = (GritManager) target;
        if (GUILayout.Button("Generate Grit"))
        {
            gm.GenerateResponsiveGrit();
        }
        if (GUILayout.Button("Delete Grit"))
        {
            gm.DeleteGrit();
        }
        
    }
   
}
