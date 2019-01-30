using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class login: MonoBehaviour
{
    // Start is called before the first frame update
    string text = "";

    string myName = "";

    void OnGUI()

    {
        Rect area = new Rect(100, 100,200 , 200);
        //用标签显示文本
        GUILayout.BeginArea(area);

        GUILayout.Label("请输入你的名字：");

        //用文本区域输入名字

        text = GUILayout.TextField(text);

        //

        
        if (GUILayout.Button("提交"))

        {

            myName = text;

        }

        //当myName不为空的时候，说明我们已经提交了名字，则显示名字

        if (!string.IsNullOrEmpty(myName))

        {

            GUILayout.Label("提交成功，名字：" + myName);

        }

        GUILayout.EndArea();
    }
}
