using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{

	public float S_fTime; // 시간
	public float S_fMoney; // 돈
	public int S_Popul; // 인구
	public int S_Repute; // 평판
	public int S_Preacher = 2; // 전도사

	private static GameManager instance = null;
	public static GameManager Instance
	{
		get
		{
			if (instance == null)
				instance = new GameManager();
			return instance;
		}
	}
	private GameManager()
	{ }

}