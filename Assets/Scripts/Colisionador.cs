// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Colisionador : MonoBehaviour
// {
//     void OnTriggerEnter2D(Collider2D coll)
//     {
//         Debug.Log("Tocó algo");
//     }
// }
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionador : MonoBehaviour
{
    public Animator burbuja1;
    public Animator burbuja2;
    public Animator burbuja3;

    void Start()
    {
        burbuja1.SetBool("EsBurbujeante", false);
        burbuja2.SetBool("EsBurbujeante", false);
        burbuja3.SetBool("EsBurbujeante", false);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Flama_a")
        {
            Debug.Log("Icono2 tocó Flama_a");

            burbuja1.SetBool("EsBurbujeante", true);
            burbuja2.SetBool("EsBurbujeante", true);
            burbuja3.SetBool("EsBurbujeante", true);
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Flama_a")
        {
            Debug.Log("Icono2 dejó de tocar Flama_a");

            burbuja1.SetBool("EsBurbujeante", false);
            burbuja2.SetBool("EsBurbujeante", false);
            burbuja3.SetBool("EsBurbujeante", false);
        }
    }
}