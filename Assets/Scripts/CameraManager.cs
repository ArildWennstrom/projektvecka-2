using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [SerializeField] PlayerMovement pm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(pm.transform.position.x, transform.position.y, transform.position.z);
    }
}
