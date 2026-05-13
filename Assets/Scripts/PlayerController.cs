using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            if (transform.position.x < 2f)
                transform.Translate(2f,0,0);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            if (transform.position.x > -2f)
                transform.Translate(-2f,0,0);
        }
    }
}
