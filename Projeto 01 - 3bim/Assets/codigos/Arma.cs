using UnityEngine;

public class Arma : MonoBehaviour
{
    public Transform saidaDaTiro;
    
    public GameObject bala;
    public float intevaloDeDisparo = 0.2f;
    
    private float tempoDeDisparo = 0;
    
    void Update()
    {
        if (tempoDeDisparo <=0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Bala disparada");
         
            GameObject b = Instantiate (this.bala,saidaDaTiro.position, saidaDaTiro.rotation) as GameObject;
            
            tempoDeDisparo = intevaloDeDisparo;
        }

        if (tempoDeDisparo > 0)
        {
            tempoDeDisparo -= Time.deltaTime;
        }
    }
}