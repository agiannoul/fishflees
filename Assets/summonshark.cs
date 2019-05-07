using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonshark : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        Physics2D.IgnoreLayerCollision(4, 1,true);
        Physics2D.IgnoreLayerCollision(0, 1, false);
    }
        
    // Update is called once per frame
    void FixedUpdate()
    {
      

    }
}
