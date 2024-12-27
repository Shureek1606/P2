using UnityEngine;

public class ColiisTrigg : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("OnTrigger" + " " + other.gameObject.name);
        if (other.gameObject.tag == "Money")
        {
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CollisionEnter" + " " + collision.gameObject.name);
        if (collision.gameObject.tag == "DEATH")
        {
            Destroy(gameObject);
        }
    }
}
