using UnityEngine;
using System.Collections;


/// <summary>
/// 游戏场景,接收操作
/// </summary>
public class GameScene : QNode {

	void OnDragStart()
	{
		QPrint.Warn ("Drag start");
	}

	void OnDrag(Vector2 pos)
	{
		QPrint.Warn ("Drag:" + pos.x + ":" + pos.y);
	}

	void OnDragOver()
	{
		QPrint.Warn ("Drag Over");
	}
}
