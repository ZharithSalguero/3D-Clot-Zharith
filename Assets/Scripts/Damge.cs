using UnityEngine;

public class Damge : MonoBehaviour
{
    public int cantidad = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<healthController>().ResrarVida(cantidad);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
