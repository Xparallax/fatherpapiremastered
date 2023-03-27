using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    private Transform barrel;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private GameObject[] ammo;

    public int ammoAmount;

    // Start is called before the first frame update
    void Start()
    {
      ammoAmount = 0;
      UpdateBulletUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && ammoAmount > 0)
        {
            var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnedBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500f * Mathf.Sign(transform.localScale.x));
            ammoAmount -= 1;
            ammo[ammoAmount].gameObject.SetActive(false);
        }

        // if (Input.GetKeyDown(KeyCode.R))
        // {
        //     ammoAmount = 3;
        //     UpdateBulletUI();
        // }
    }

    void UpdateBulletUI()
    {
        for (int i = 0; i <= 2; i++)
        {
            //ammo[i].gameObject.SetActive(ammoAmount > i);
            if(ammoAmount > i){
                ammo[i].gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        lootheal lb = col.gameObject.GetComponent<lootheal>();
        if (lb == null) return;

        if (lb.lootType.lootName == "Bible")
        {
            ammoAmount = Mathf.Clamp(ammoAmount + 1, 0, 3);
            UpdateBulletUI();
        }
    }
}
