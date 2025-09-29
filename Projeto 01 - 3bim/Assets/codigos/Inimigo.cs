using UnityEngine;

public class Inimigo : Personagem
{
    [SerializeField] private int dano = 1;

    [SerializeField] private Transform posicaoDoPlayer;
    
    private SpriteRenderer spriteRenderer;

    
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
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        if (posicaoDoPlayer == null)
        {
            posicaoDoPlayer =  GameObject.Find("Player").transform;
        }
    }

    void Update()
    {
        if (posicaoDoPlayer.position.x - transform.position.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        
        if (posicaoDoPlayer.position.x - transform.position.x < 0)
        {
            spriteRenderer.flipX = true;
        }


        if (posicaoDoPlayer != null)
        {
            Debug.Log("Posição do Pluer"+ posicaoDoPlayer.position);
            
            transform.position = Vector3.MoveTowards(transform.position, 
                posicaoDoPlayer.transform.position,
                getVelocidade() * Time.deltaTime);
        }
        
        if (getVida() <= 0)
        {
            //desativa o objeto do Inimigo
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Causa dano ao Player
            int novaVida = collision.gameObject.GetComponent<Personagem>().getVida() - getDano();
            collision.gameObject.GetComponent<Personagem>().setVida(novaVida);

            //collision.gameObject.GetComponent<Personagem>().recebeDano(getDano());
            
            //desativa quando bate no player
            gameObject.SetActive(false);
        }
    }
}