using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTesting : MonoBehaviour
{

    //private GameObject targetObject;
    private Transform targetObject;

    // Start is called before the first frame update
    void Start()
    {
        //targetObject = GameObject.FindGameObjectWithTag("Movable");
        targetObject = gameObject.GetComponent<Transform>();
    }

    float moveSpeed = 500f;
    float rotateSpeed = 500f;

    // Update is called once per frame
    void Update()
    {
        // float horizontal = Input.GetAxis("Horizontal"); //获取横轴参数。（如：按A键返回-1 按D键返回+1，但中间有一个过度，而不是直接变-1或+1。）
        // float vertical = Input.GetAxis("Vertical"); //获取垂直参数。
        // Debug.Log("horizontal: " + horizontal + ",vertical:" + vertical);

        // float mouseX = Input.GetAxis("Mouse X");//获取鼠标X轴滑动参数
        // float mouseY = Input.GetAxis("Mouse Y");//获取鼠标Y轴滑动参数
        // Debug.Log("mouseX: " + mouseX + ",mouseY:" + mouseY);

        // float mouseScrollWheel = Input.GetAxis("Mouse ScrollWheel");
        
        
        //键盘ADWS键控制物体移动。（当乘以Time.deltaTime实际表示：每秒移动物体N米，而不是每帧N米。）
        if(Input.GetKeyUp(KeyCode.U)){
            targetObject.Translate(Vector3.forward * 0.1f, Space.World);
        }
        //targetObject.transform.Translate(new Vector3(horizontal * Time.deltaTime * moveSpeed, 0, vertical * Time.deltaTime * moveSpeed));

        //鼠标XY轴滑动控制物体旋转
        //targetObject.transform.Rotate(new Vector3(mouseX * Time.deltaTime * rotateSpeed, mouseY * Time.deltaTime * rotateSpeed));

        //鼠标中键控制物体缩放
        //targetObject.transform.localScale += new Vector3(mouseScrollWheel, mouseScrollWheel, mouseScrollWheel);
    }
}
