/** edited by shenjun **/

using UnityEngine;
using System.Collections;

/** 状态——游戏场景 */
public class State_GameScene : IState 
{
	const string m_szSceneName = "GameScene";

	/** 初始化 */
	public override void Initialize ()
	{
		SkyFortressGame.Instance.Initialize ();
	}

	/** 更新 */
	public override void Update ()
	{
		SkyFortressGame.Instance.Update ();
	}

	/** 释放 */
	public override void Release ()
	{
		SkyFortressGame.Instance.Release ();
	}
}
