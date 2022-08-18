using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GritManager))]
public class CustomInspector : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GritManager gm = (GritManager) target;
        if (GUILayout.Button("Generate Responsive Grit"))   //calculate the surface size to fill it with tiles must have a int as size.
        {
            gm.GenerateResponsiveGrit();
        }
        if (GUILayout.Button("Generate Island Grit"))   //will cover a surface with one tile.
        {
            gm.GenerateIslandGrit();
        }
        if (GUILayout.Button("Delete Grit"))        //clear all spawned tiles
        {
            gm.DeleteGrit();
        }
        
    }
   
}
