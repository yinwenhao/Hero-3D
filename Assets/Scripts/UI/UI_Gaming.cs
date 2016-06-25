using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class UI_Gaming : MonoBehaviour {
	public static UI_Gaming Instance;
	//十字准心图片
	public Image cross; 
	//瞄准镜内视图片
	public Image scope;
	//受伤动画
	public Animator hurtAni; 
	//显示生命值的Text
	public Text text_life;
	//显示弹药情况的Text
	public Text text_ammo;
	//移动设备特有按钮的根节点
	public GameObject mobile_Root;
	//开火按钮
	public Button button_fire;
	//用bool值判断点击按钮是否有效，例如换子弹的时候是不能跳跃的
	public bool mobile_canFire{get;set;}
	public bool mobile_canReload{get;set;}
	public bool mobile_canScope{get;set;}
	public bool mobile_canSwap{get;set;}
	public bool mobile_canJump{get;set;}
	void Awake()
	{
		Instance = this;

		#if mobile
			mobile_Root.SetActive(true);
			//设置事件
			EventTriggerListener.Get(button_fire.gameObject).onDown = Event_FireBt_Press;
			EventTriggerListener.Get(button_fire.gameObject).onUp = Event_FireBt_Release;
		#else
			mobile_Root.SetActive(false);
		#endif
	}

	void Update () {
		// TODO: 
	}
	
	//暂停
	void Pause()
	{
		Time.timeScale = 0;
		UI_Manager.Instance.PageTransition(UIState.Paused);
	}

	#region mobile
	//点击暂停按钮
	public void OnPress_Pause()
	{
		Pause();
	}
	
	#endregion
}
