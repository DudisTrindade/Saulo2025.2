using UnityEngine;

public class Player : Personagem
{
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += new Vector3(0, getVelocidade()* Time.deltaTime, 0);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= new Vector3(0, getVelocidade()* Time.deltaTime, 0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(getVelocidade()* Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= new Vector3(getVelocidade()* Time.deltaTime, 0, 0);
        }
        
        
        if (getVidas() <= 0)
        {
            //desativa o objeto do Player
            gameObject.SetActive(false);
            
            Debug.Log("Jogador Morreu!!!");
        }
    }
}