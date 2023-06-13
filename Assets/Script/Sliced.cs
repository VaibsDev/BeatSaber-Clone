using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class Sliced : MonoBehaviour
{
    // reference of the plane gameObject 
    public Transform planeDebug;
    //target gameObject that we want to slice
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Slice(GameObject target)
    {
        SlicedHull hull = target.Slice(planeDebug.position,planeDebug.up);
        if(hull != null)
        {
            GameObject upperHull = hull.CreateUpperHull(target);
            GameObject LowerHull = hull.CreateLowerHull(target);
        }
    }
}
