using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changematerial2 : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private Material myMaterial;

   private void OnTriggerEnter(Collider other)
   {
    if(other.CompareTag("Player"))
    {
        myMaterial.color=Color.red;
    }
   }
   
//    private void OnTriggerExit(Collider other)
//    {
//     if(other.CompareTag("Player"))
//     {
//         myMaterial.color=Color.green;
//     }
//    }
}
