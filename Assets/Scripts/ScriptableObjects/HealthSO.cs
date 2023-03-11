using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Health", menuName = "Health", order = 1)]
public class HealthSO : ScriptableObject
{
    private float health = 100;
    
    public float Health
    {
        get { return health; }
        set { health = value; }
    }
}
