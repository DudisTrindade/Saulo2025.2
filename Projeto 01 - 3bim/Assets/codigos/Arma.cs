using JetBrains.Annotations;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public Transform saidaDaTiro;
    
    public GameObject bala;
    public float intervaloDeDisparo = 0.5f;

    private float tempoDeDisparo;



    void Start()
    {
        
    }

    void Update()
    {
        if (tempoDeDisparo <= 0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Bala disparada");
            GameObject bala = Instantiate(this.bala);
            
            tempoDeDisparo = intervaloDeDisparo;
        }

        if (tempoDeDisparo > 0)
        {
            tempoDeDisparo -= Time.deltaTime;
        }    
    }
}