using UnityEngine;
using UnityEngine.UIElements;

public class ColiisTrigg : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("OnTrigger" + " " + other.gameObject.name);
        if (other.gameObject.tag == "Money")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Powerup")
        {
            Destroy(other.gameObject);
            transform.localScale += Vector3.one;
            gameObject.GetComponent<CarGo>().goY += 5;
        }

        if (other.gameObject.tag == "PowerDown")
        {
            Destroy(other.gameObject);
            transform.localScale -= Vector3.one;
            gameObject.GetComponent<CarGo>().goY -= 5;
        }

        if (other.gameObject.tag == "Speed")
        {
            Destroy(other.gameObject);
            gameObject.GetComponent<CarGo>().goZ += 1;
        }

        if (other.gameObject.tag == "Teleport")
        {
            gameObject.transform.position = new Vector3(60, 11, -34);
        }

        if (other.gameObject.tag == "Teleport2")
        {
            gameObject.transform.position = new Vector3(-46, 11, 4);
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


