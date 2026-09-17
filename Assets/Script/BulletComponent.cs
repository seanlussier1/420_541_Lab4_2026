using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletComponent : MonoBehaviour
{

    void Start()
    {
        // Destroy object after a few seconds
        Destroy(gameObject, 5f);
    }
}
