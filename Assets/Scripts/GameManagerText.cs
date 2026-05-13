using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerText : MonoBehaviour
{
    
    public static GameManagerText instancia;
    public TMP_Text textoTiempo;
    private float tiempo = 0f;
    public bool corriendo = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Awake()
        {
            instancia = this;
        }

    // Update is called once per frame
    void Update()
    {
        if (corriendo)
        {
            tiempo += Time.deltaTime;
            textoTiempo.text = tiempo.ToString("F2") + " s";
        }
    }
    public void DetenerJuego()
    {
        corriendo = false;
        CajaMovement caja = FindObjectOfType<CajaMovement>();
        if (caja != null) caja.Detener();
    }
}
