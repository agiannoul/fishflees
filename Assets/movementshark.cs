using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementshark : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform shark1;
    public Rigidbody2D shark;
   
    void Start()
    {
        
        shark.gravityScale = 0.0f;
       
    }

    
}
