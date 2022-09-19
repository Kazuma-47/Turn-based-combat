using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


    public static class Extensions 
    {
        public static int CEfindIndex<T>(this T[] array, T item){
            return Array.IndexOf(array, item);}
         
        
        public static bool Dingen (this List<Transform> list , List<Transform> item)
        {
            Debug.Log("Hello");
            foreach (var indexItem in list)
            {
                if (Equals(item, indexItem)) return true;
            }

            return false;
        }
    }
    


