using UnityEngine;
using System.Collections;
using QFramework;

/// <summary>
/// 数据存储
/// </summary>
public class DataManager : QSingleton<DataManager> {
	private DataManager() {}

	public int soundState;
}
