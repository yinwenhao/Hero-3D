﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    public JFSocket mJFsocket;

    public string req;

    // Use this for initialization
    void Start()
    {
        mJFsocket = JFSocket.GetInstance();

        req = "{\"bean\":\"login\",\"method\":\"login\",\"param\":{\"sss\":1,\"token\":\"12345678901234567890123456789012999\"}}";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (req != null)
        {
            mJFsocket.SendMessage(req);
            req = null;
        }
    }
}