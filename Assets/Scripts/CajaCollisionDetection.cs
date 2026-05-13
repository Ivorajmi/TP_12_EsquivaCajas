using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col){
        if (col.gameObject.CompareTag("Player")){
            Destroy(col.gameObject);
        }else if(col.gameObject.CompareTag("Piso")){
            
            float [] posiciones = { -2f, 0f, 2f };
            float x = posiciones[Random.Range(0, posiciones.Length)];
            transform.position = new Vector3(x, transform.position.y + 10f, 0f);
            CajaMovement mov = GetComponent<CajaMovement>();
            if (mov != null) mov.AumentarVelocidad();
        }
    }
}
