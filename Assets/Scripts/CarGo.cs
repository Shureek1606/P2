using UnityEngine;

public class CarGo : MonoBehaviour
{

    public float goZ = 15;
    public float goX = 15;
    public float goY = 15;


    public float vert;
    public float horiz;
    public float jump;

    void Update()
    {
        vert = Input.GetAxis("Vertical"); //принимает значение +1 когда нажата клавиша W,-1 когда S
        horiz = Input.GetAxis("Horizontal"); //принимает значение +1 когда нажата клавиша D,-1 когда A
        jump = Input.GetAxis("Jump"); //принимает значение +1 когда нажата клавиша space



        //gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, goZ);

        //transform.Translate(Vector3.forward * goZ * Time.deltaTime - движение вперёд
        //* Input.GetAxis("Vertical")); - запускает функцию при нажатии клавиш W,S,Arrow up,Arrow down
        transform.Translate(Vector3.forward * goZ * Time.deltaTime);

        //(Vector3.right * goX * Time.deltaTime - движение в сторону
        //Input.GetAxis("Horizontal")); - запускает функцию при нажатии клавиш D,A,Arrow right,Arrow left
        transform.Translate(Vector3.right * goX * Time.deltaTime * horiz);

        transform.Translate(Vector3.up * goY * Time.deltaTime * jump);

        if (transform.localScale.x < 0.1f)
        {
            Destroy(gameObject);
        }
    }
}

