using UnityEngine;

//для вращения объектов по Y
public class Rotation : MonoBehaviour
{
    void Update()
    {
        int speedRotate = 80;
        transform.Rotate(Vector3.up * Time.deltaTime * speedRotate);
        
    }
}
