using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private int dano = 1;
    [SerializeField] private float velocidade = 1.5f;

    private Renderer m_Renderer;
    
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
        m_Renderer = GetComponent<Renderer>();
    }

    
    void Update()
    {
        transform.Translate(velocidade * Time.deltaTime, 0, 0);

        if (!m_Renderer.isVisible)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            // Causa dano ao Inimigo
            int novaVida = collision.gameObject.GetComponent<Personagem>().getVidas() - getDano();
            collision.gameObject.GetComponent<Personagem>().setVidas(novaVida);
            
            //collision.gameObject.GetComponent<Personagem>().recebeDano(getDano());
        }
        
        // desliga a bala apos a colisão
        gameObject.SetActive(false);
    }
}