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
        vert = Input.GetAxis("Vertical"); //��������� �������� +1 ����� ������ ������� W,-1 ����� S
        horiz = Input.GetAxis("Horizontal"); //��������� �������� +1 ����� ������ ������� D,-1 ����� A
        jump = Input.GetAxis("Jump"); //��������� �������� +1 ����� ������ ������� space



        //gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, goZ);

        //transform.Translate(Vector3.forward * goZ * Time.deltaTime - �������� �����
        //* Input.GetAxis("Vertical")); - ��������� ������� ��� ������� ������ W,S,Arrow up,Arrow down
        transform.Translate(Vector3.forward * goZ * Time.deltaTime);

        //(Vector3.right * goX * Time.deltaTime - �������� � �������
        //Input.GetAxis("Horizontal")); - ��������� ������� ��� ������� ������ D,A,Arrow right,Arrow left
        transform.Translate(Vector3.right * goX * Time.deltaTime * horiz);

        transform.Translate(Vector3.up * goY * Time.deltaTime * jump);

        if (transform.localScale.x < 0.1f)
        {
            Destroy(gameObject);
        }
    }
}

