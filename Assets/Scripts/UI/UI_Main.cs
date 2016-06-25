using UnityEngine;
using System.Collections;

public class UI_Main : MonoBehaviour {

    private JFSocket mJFsocket;

    private string req;

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

    //点击开始游戏按钮
    public void OnPress_Start()
	{
		Debug.Log("OnPress_Start");
		UI_Manager.Instance.PageTransition( UIState.Loading);
	}
	//点击设置选项按钮
	public void OnPress_Settings()
	{
		UI_Manager.Instance.Sound_Click();
		Debug.Log("OnPress_Settings");
		UI_Manager.Instance.PageTransition( UIState.Settings);
	}
}
