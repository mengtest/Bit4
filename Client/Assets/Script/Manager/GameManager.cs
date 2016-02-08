using UnityEngine;
using System.Collections;
using QFramework;

/// <summary>
/// 游戏的管理器
/// </summary>
public class GameManager : QSingleton<GameManager> {
	
	public Hero hero;


	// 各个模块
	private GameManager() {}
	/// <summary>
	/// 由App启动的入口函数
	/// </summary>
	public IEnumerator OnStart () {



		yield return 0;
	}

}
