using UnityEngine;

public class Random : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        healthController hCtr = collision.gameObject.GetComponent<healthController>();
        hCtr.Regenerate();

        Debug.Log(collision.name);

        Destroy(this.gameObject); 
    }
}

