using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroler : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
        transform.Translate(0, 0.2f, 0);

        if(transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(coll.gameObject);
        Destroy(gameObject);

        GameObjet.Find("Canvas").GetComponent<UIController>().AddScore();

        GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
        Destroy(effect, 1.0f);
    }
}
