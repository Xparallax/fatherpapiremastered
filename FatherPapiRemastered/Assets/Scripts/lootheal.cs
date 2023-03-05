    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lootheal : MonoBehaviour
{
    public Loot lootType;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                var HealComponent = collision.GetComponent<Health>();
                if (HealComponent != null)
                {
                    HealComponent.Heal(3);
                }
                
                Destroy(gameObject);
            }
        }

        
    
}
