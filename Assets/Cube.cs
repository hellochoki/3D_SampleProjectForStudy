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

        //// Property 라 () 없음
        //if (Input.anyKeyDown)
        //{
        //    Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        //}



        //if (Input.GetButtonDown("Horizontal"))
        //{
        //    Debug.Log("횡 이동 중!.." 
        //        + Input.GetAxisRaw("Horizontal"));
        //}

        //if (Input.GetButton("Horiznotal"))
        //{
        //    Debug.Log("점프 모으는 중");
        //}
        //if (Input.GetButtonUp("Horiznotal"))
        //{
        //    Debug.Log("슈퍼 점프");
        //}

        //if (Input.GetButtonDown("Jump"))
        //{
        //    Debug.Log("점프!");
        //}
        //if (Input.GetButton("Jump"))
        //{
        //    Debug.Log("점프 모으는 중");
        //}
        //if (Input.GetButtonUp("Jump"))
        //{
        //    Debug.Log("슈퍼 점프");
        //}

    }
}
