using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    
    PlayerMovement pm;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject Firepoint;
    [SerializeField] float bulletSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (pm == null)
            pm = GetComponent<PlayerMovement>();

       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();

           // instantite bullet prefab at spesific direction depending on dir.
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, Firepoint.transform.position, Quaternion.identity);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(pm.facingDirX * bulletSpeed, 3f);

    }
}
