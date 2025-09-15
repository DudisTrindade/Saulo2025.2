using UnityEngine;
using UnityEngine.UIElements;

public class Bala : MonoBehaviour
{
    
    [ SerializeField ] private int dano = 1;

    public void setDano(int dano)
    {
        this.dano = dano;
    }

    public int getDano()
    {
        return this.dano;
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            //causa dano do Inimigo 
            int novaVida = collision.gameObject.GetComponent<Personagem>().getVidas() - getDano();
            collision.gameObject.GetComponent<Personagem>().setVidas( novaVida );
            print ("A Vida restante do inimigo é " + novaVida);
        }
        
        // desligar a bala apos a colisao
        gameObject.SetActive(false);
        
    }
}


