using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour{
	
	public int playerCoin;
	public int playerPoint;
	public Text coin;
    public Text point;
	
	public void Awake(){
		playerCoin = PlayerPrefs.GetInt("coin",0);
		playerPoint = PlayerPrefs.GetInt("point",0);
		SetData ();
	}

	public void AddCoin()
        {
          playerCoin += 1;
          playerPoint += 100;

	}

	public void LossCoin() 
        {
          if(playerCoin >= 10 && playerPoint >= 1000)
          {
            playerCoin -= 10;
            playerPoint -= 1000;
          }
          else
          {
             playerCoin = 0;
             playerPoint = 0;
          }
        }

	public void BigAddCoin(){
		playerCoin += 30;
		playerPoint += 3000;
	}

	public void BigLossCoin(){
		if (playerCoin >= 30 && playerPoint >= 3000) {
			playerCoin -= 30;
			playerPoint -= 3000;
		} 
		else {
			playerCoin = 0;
			playerPoint = 0;
		}
	}

	public void SetData(){
		coin.text = playerCoin.ToString("000");
		point.text = playerPoint.ToString("0000000");
	}

	public void LogData(){
		PlayerPrefs.SetInt("coin", playerCoin);
		PlayerPrefs.SetInt("point", playerPoint);
	}

    private static PointController m_instance;

    public static PointController instance{
        get{
            if (m_instance == false){
                m_instance = FindObjectOfType<PointController>();
            }
            return m_instance;
        }
    }
	
}
