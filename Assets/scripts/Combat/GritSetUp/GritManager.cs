using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Object = System.Object;

public class GritManager : MonoBehaviour
{
    [SerializeField] private Vector3 expantionRadius;
    [SerializeField] private Tile prefab;
    [SerializeField] private Tile nonSelectableTileprefab;

    
    //will respond to objects as a grit can be used for a island type level/large scale map etc
    //if map is one object needs to fill it with multiple instances?
    //otherwise this works
    public void GenerateIslandGrit()
    {
        Collider[] objects=  Physics.OverlapBox(gameObject.transform.position, expantionRadius, quaternion.identity);
        foreach (var surface in  objects)
        {
            Vector3 position = surface.transform.gameObject.transform.position;
            var spawnHeight = surface.GetComponent<Renderer>().bounds.extents.y + surface.transform.position.y ;
            
            var spawnedTile = Instantiate(prefab, new Vector3(position.x,spawnHeight , position.z) , Quaternion.identity ,gameObject.transform);
            spawnedTile.transform.localScale = new Vector3(surface.transform.localScale.x, spawnedTile.transform.localScale.y,surface.transform.localScale.z);
            spawnedTile.name = $"Tile";
        }
    }

    public void GenerateResponsiveGrit()
    {
        Collider[] objects = Physics.OverlapBox(gameObject.transform.position, expantionRadius, quaternion.identity);
        foreach (var ground in objects)
        {
            if (ground.CompareTag("Ground"))
            {
                FillObject(ground, prefab);
            }
            else if (ground.CompareTag("NonSelectable"))
            {
                FillObject(ground, nonSelectableTileprefab);
            }
        }
    }

    void FillObject(Collider objectToFill , Tile filler)
    {
        var prefabWidth = prefab.GetComponent<Renderer>().bounds.size.x;
        float prefabDepth = prefab.GetComponent<Renderer>().bounds.size.z ;
        float prefabHeight = objectToFill.GetComponent<Renderer>().bounds.size.y;
        float fillWidth = objectToFill.GetComponent<Renderer>().bounds.size.x;
        float fillDepth = objectToFill.GetComponent<Renderer>().bounds.size.z;
        float fillHeight = objectToFill.GetComponent<Renderer>().bounds.size.y;
        var spawnHeight = objectToFill.GetComponent<Renderer>().bounds.extents.y + fillHeight /2;


        var halfOfPrefab = prefab.GetComponent<Renderer>().bounds.size / 2;
        
        float horizontalAmount = fillWidth / prefabDepth;
        float verticalAmount = fillDepth / prefabDepth;
        
        for (int i = 0; i < horizontalAmount; i++)
        {
            for (int j = 0; j < verticalAmount; j++)
            {
                Tile obj = Instantiate(filler, objectToFill.GetComponent<Renderer>().bounds.min+ halfOfPrefab +  new Vector3(i * prefabWidth ,  spawnHeight , j * prefabDepth ), objectToFill.transform.rotation ,gameObject.transform);
                    obj.name = $"Tile {i} : {j}";
                
            }
        }
    }

    public void DeleteGrit()
    {
        foreach (Transform child in transform) {
            DestroyImmediate(child.gameObject);
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, expantionRadius);
    }
}
