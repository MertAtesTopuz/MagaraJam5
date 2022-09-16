using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealt : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        //rb.AddForce(Vector2.right * 200);

        health -= amount;

        if (health <= 0)
        {
            StartCoroutine(Dead());
        }
    }

    private void Dead2()
    {

        Destroy(gameObject);

    }

    IEnumerator Dead()
    {
        yield return new WaitForSeconds(1.0f);

        Dead2();
    }
}
