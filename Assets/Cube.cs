using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0);
        transform.Translate(vector);

        //Vector3 vec = new Vector3(0, 0.01f, 0);

        //transform.Translate(vec);

        //// Property �� () ����
        //if (Input.anyKeyDown)
        //{
        //    Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        //}



        //if (Input.GetButtonDown("Horizontal"))
        //{
        //    Debug.Log("Ⱦ �̵� ��!.." 
        //        + Input.GetAxisRaw("Horizontal"));
        //}

        //if (Input.GetButton("Horiznotal"))
        //{
        //    Debug.Log("���� ������ ��");
        //}
        //if (Input.GetButtonUp("Horiznotal"))
        //{
        //    Debug.Log("���� ����");
        //}

        //if (Input.GetButtonDown("Jump"))
        //{
        //    Debug.Log("����!");
        //}
        //if (Input.GetButton("Jump"))
        //{
        //    Debug.Log("���� ������ ��");
        //}
        //if (Input.GetButtonUp("Jump"))
        //{
        //    Debug.Log("���� ����");
        //}

    }
}
