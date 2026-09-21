using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionador : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Tocó algo");
    }
}
