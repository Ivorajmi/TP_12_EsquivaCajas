using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed = 5f;
    public float aumento = 0.5f;
    private bool detenida = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                if (!detenida)
                    transform.Translate(0,-speed * Time.deltaTime,0);
    }
    public void AumentarVelocidad()
    {
        speed += aumento;
    }
    public void Detener()
    {
        detenida = true;
    }
}
