using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;
    [SerializeField] float bulletSpeed = 15f;
    PlayerMovement pm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        pm.
    }
}
