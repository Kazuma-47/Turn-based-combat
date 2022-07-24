using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class GritManager : MonoBehaviour
{
    [SerializeField] private Vector3 expantionRadius;
    [SerializeField] private Tile prefab;
    private BoxCollider _collider;
    
    private void Start()
    {
        //GenerateGrit();
    }


    public void OnTriggerEnter(Collider other)
    {
        print("TO BAD");
        if(other.CompareTag("Ground"))
        {
            print("I EXIST");
            var position = other.transform.gameObject.transform.position;
            Instantiate(prefab,new Vector3(position.x,position.y+2,position.z), Quaternion.identity ,gameObject.transform);
        }
    }
    //will respond to objects as a grit
    public void GenerateResponsiveGrit()
    {
        Collider[] Objects=  Physics.OverlapBox(gameObject.transform.position, expantionRadius, quaternion.identity);
        foreach (var surface in  Objects)
        {
            Vector3 position = surface.transform.gameObject.transform.position;
            var spawnedTile = Instantiate(prefab, new Vector3(position.x,position.y +0.5f , position.z) , Quaternion.identity ,gameObject.transform);
            spawnedTile.transform.localScale = new Vector3(surface.transform.localScale.x, spawnedTile.transform.localScale.y,surface.transform.localScale.z);
            spawnedTile.name = $"Tile";
        }
    }
    
    //if you want to generate a flat terain as grit
   /* public void GeneratePlainGrit()
    {
        for(int x = 0; x < width; x++){
            for (int y = 0; y < height; y++){
                for (int z = 0; z < depth; z++)
                {
                    var spawnedTile = Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity ,gameObject.transform);
                    spawnedTile.name = $"Tile {x} {y}";
                }
              
            }
        }
    }*/

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
