using UnityEngine;
using System.Collections;

/// <summary>
/// 游戏信息
/// </summary>
public static class GameInfo  {

	public const int RowCount = 5;
	public const int ColCount = 5;

	public static Vector3[,] ItemPosForIndex = new Vector3[RowCount, ColCount];

}