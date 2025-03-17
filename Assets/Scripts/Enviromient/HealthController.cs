using UnityEngine;

public class healthController : MonoBehaviour
{
    public int vidamax = 100;
    public int vida;
    public void ResrarVida(int cantidad)
    {
        vida -= cantidad;
    }

    public void Regenerate()
    {
        vida = vida + 1;

    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
