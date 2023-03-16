using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class Movement : MonoBehaviour  
{  
    Vector3 Vec;  
    [SerializeField] private Material myMaterial;
    // Start is called before the first frame update  
    void Start()  
    {  
          myMaterial.color=Color.green;
    }  
  
    // Update is called once per frame  
    void Update()  
    {  
  
        Vec = transform.localPosition;  
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 10;  
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 5;  
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 5;  
        transform.localPosition = Vec;  
    }  
} 
