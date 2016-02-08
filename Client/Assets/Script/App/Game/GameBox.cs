using UnityEngine;
using System.Collections;
using QFramework;

public class GameBox : QNode {



	void Awake()
	{
		Transform tempTrans;

		// 获取位置数据
		for (int rowIndex = 0; rowIndex < GameInfo.RowCount; rowIndex++) {
			for (int colIndex = 0; colIndex < GameInfo.ColCount; colIndex++) {
				tempTrans = trans.Find ("" + rowIndex + "" + colIndex + "pos");
				GameInfo.ItemPosForIndex[rowIndex, colIndex] = tempTrans.localPosition;
				Destroy (tempTrans.gameObject);
				tempTrans = null;
			}
		}
	}

	void Start()
	{

	}


	void SetupHero()
	{

	}
}
