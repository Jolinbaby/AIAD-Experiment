using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextBtnController : MonoBehaviour
{
    public GameObject recordPNG01;
    public GameObject recordPNG02;
    public GameObject recordPNG03;
    public GameObject nextBtn;
    public GameObject restartBtn;
    public GameObject recordBtn;
    public GameObject timer;
 
    // Start is called before the first frame update
    void Start()
    {
        //点击下一步
        nextBtn.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            nextBtn.SetActive(false);
            restartBtn.SetActive(false);
            //显示拍摄按钮
            recordBtn.SetActive(true);
           
            if (recordPNG01.activeInHierarchy == true)
            {
                recordPNG01.SetActive(false);
                recordPNG02.SetActive(true);
            }
            else if (recordPNG02.activeInHierarchy == true)
            {
                recordPNG02.SetActive(false);
                recordPNG03.SetActive(true);
            }
            else if (recordPNG03.activeInHierarchy == true)
            {
                recordPNG03.SetActive(false);
                recordPNG01.SetActive(true);
            }
        });
        //点击重新拍摄
        restartBtn.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            nextBtn.SetActive(false);
            restartBtn.SetActive(false);
            //计时消失
            timer.SetActive(false);
            Timer.myTimer = 0;
            //显示拍摄按钮
            recordBtn.SetActive(true);
           
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
