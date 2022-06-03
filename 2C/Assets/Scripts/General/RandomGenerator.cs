using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public bool RandomHit(int percent)
    {  
        if(percent < 0 || percent > 100) return false;
        
        return (percent >= Random.Range(0, 100.0f));
    }
}
