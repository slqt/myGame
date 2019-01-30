using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class login: MonoBehaviour
{
    string text = "";

    string myName = "";

    void OnGUI()

    {
        Rect area = new Rect(100, 100,200 , 200);
        GUILayout.BeginArea(area);
        GUILayout.Label("请输入你的名字：");

        text = GUILayout.TextField(text);
        if (GUILayout.Button("提交"))

        {

            myName = text;

        }

        if (!string.IsNullOrEmpty(myName))

        {

            GUILayout.Label("提交成功，名字：" + myName);

        }

        GUILayout.EndArea();
    }
}
