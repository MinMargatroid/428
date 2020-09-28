using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    private Vector3 m_camRot;
    private Transform m_transform;//摄像机父物体Transform
    public float m_movSpeed=10;//移动系数
    public float m_rotateSpeed=1;//旋转系数
    private void Start()
    {
        m_transform = GetComponent<Transform>();
    }
    private void Update()
    {
        Control();
    }
    void Control()
    {
 
        // 定义3个值控制移动
        float xm = 0, ym = 0, zm = 0;
 
        //按键盘W向上移动
        if (Input.GetKey(KeyCode.UpArrow))
        {
            zm += m_movSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))//按键盘S向下移动
        {
            zm -= m_movSpeed * Time.deltaTime;
        }
 
        if (Input.GetKey(KeyCode.LeftArrow))//按键盘A向左移动
        {
            xm -= m_movSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))//按键盘D向右移动
        {
            xm += m_movSpeed * Time.deltaTime;
        }
        m_transform.Translate(new Vector3(xm,ym,zm),Space.Self);
    }
}
