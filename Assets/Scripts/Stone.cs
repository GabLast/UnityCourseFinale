using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public GameObject explosion;

    private const float yDie = -30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= yDie) {
            Destroy(gameObject);
            GameManager.hp--;
        }
    }

    private void OnMouseDown()
    {
        //delaying the explosion animation's destruction
        Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 2f);
        Destroy(gameObject);
        GameManager.totalStonesDestroyed++;
    }
}
