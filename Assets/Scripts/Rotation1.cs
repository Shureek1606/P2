using UnityEngine;

//для вращения объектов по Y
public class Rotation1 : MonoBehaviour
{
    void Update()
    {
        int speedRotate = 240;
        transform.Rotate(Vector3.back * Time.deltaTime * speedRotate);
        
    }
}
