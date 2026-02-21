using UnityEngine;

public class rotationplayer1 : MonoBehaviour
{
    public float rotationSpeed = 150f;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * horizontal * rotationSpeed * Time.deltaTime);
    }
}
