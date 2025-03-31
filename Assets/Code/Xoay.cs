using UnityEngine;

public class Xoay : MonoBehaviour
{
    public float rotationSpeed = 1.0f;

    void Update()
    {
        // Tạo quaternion quay theo trục z
        Quaternion quaternion = Quaternion.Euler(0, 0, rotationSpeed * Time.deltaTime);
        transform.localRotation = transform.localRotation * quaternion; 
    }
}
