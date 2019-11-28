using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float fireballSpeed = 10f;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, fireballSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        ReactiveTarget target = other.GetComponent<ReactiveTarget>();
        if (player != null)
        {
            player.Hurt(damage);

        }

        if (target != null)
        {
            target.ReactToHit();
        }
        Destroy(this.gameObject);
    }
}
