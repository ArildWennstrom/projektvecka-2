using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    EnemyMovement em;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject Firepoint;
    [SerializeField] float bulletSpeed = 10f;
    float coolDown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (em == null)
            em = GetComponent<EnemyMovement>();


    }

    // Update is called once per frame
    void Update()
    {

        if (em.seesPlayer)
        {
            if (coolDown < 0)
            {
                Shoot();
                coolDown = 2;

            }
            else { coolDown -= Time.deltaTime;}

            // instantite bullet prefab at spesific direction depending on dir.
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, Firepoint.transform.position, Quaternion.identity);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.linearVelocity = new Vector2(em.facingDirX * bulletSpeed, 0f);
    }
}
