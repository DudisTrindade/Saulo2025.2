using UnityEngine;
using UnityEngine.UIElements;

public class Inimigo : Personagem
{
    [SerializeField] private int dano = 1;

    public void setdano(int dano)
    {
        this.dano = dano;
    }

    public int getdano()
    {
        return this.dano;
    }
   void Start()
   {
      
   }

   void Update()
   {
       if (getVidas() <= 0)
       {
           //desativa o objeto Inimigo
           gameObject.SetActive(false);
       }   
   }

    void OnCollisionEnter2D(Collision2D collision)
   {
       if (collision.gameObject.tag == "Player")
       {
             // Causa dano ao Player
             int novaVida = collision.gameObject.GetComponent<Personagem>().getVidas() - getdano();
             collision.gameObject.GetComponent<Personagem>().setVidas(novaVida); 
             print ("A Vida restante do Player é " + novaVida);
       }
   }
}
