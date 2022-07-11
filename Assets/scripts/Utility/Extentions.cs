using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extentions 
{
    public static int findIndex<T>(this T[] array, T item) {
    return Array.IndexOf(array, item);
    }
}
