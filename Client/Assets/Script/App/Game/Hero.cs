using UnityEngine;
using System.Collections;
using QFramework;

public class Hero : QNode {

	void Awake()
	{
		// 将自己注册到GameManager中
		GameManager.Instance ().hero = this;
	}


	void Start()
	{
		// 位置放在最中央
		trans.localPosition = GameInfo.ItemPosForIndex [2, 2];
	}
}
