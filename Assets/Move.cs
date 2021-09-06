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
        // delta Time 설정 !!
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime
            );
        transform.Translate(vec);


        // 1. Move Toward
        // 등속도 운동
        //transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);

        // 2. SmoothDamp
        // 빠르게 움직이다가 목적지에 도착해서 부드럽게 감속. ref velo 가 있는게 차이점
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.2f);

        // 3. Lerp
        // 선형 보간을 이용한 목표지점 이동
        //transform.position =
        //    Vector3.Lerp(transform.position, target, 0.1f);

        // 4. SLerp
        // 구면 보간을 이용한 목표지점 이동
        //transform.position =
        //    Vector3.Slerp(transform.position, target, 0.1f * Time.deltaTime);

    }
}
