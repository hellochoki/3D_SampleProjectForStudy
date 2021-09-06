using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 target = new Vector3(40, 2, 3);

    // Update is called once per frame
    void Update()
    {
        // delta Time ���� !!
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime
            );
        transform.Translate(vec);


        // 1. Move Toward
        // ��ӵ� �
        //transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);

        // 2. SmoothDamp
        // ������ �����̴ٰ� �������� �����ؼ� �ε巴�� ����. ref velo �� �ִ°� ������
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.2f);

        // 3. Lerp
        // ���� ������ �̿��� ��ǥ���� �̵�
        //transform.position =
        //    Vector3.Lerp(transform.position, target, 0.1f);

        // 4. SLerp
        // ���� ������ �̿��� ��ǥ���� �̵�
        //transform.position =
        //    Vector3.Slerp(transform.position, target, 0.1f * Time.deltaTime);

    }
}
