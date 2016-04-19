/** edited by shenjun **/

using UnityEngine;
using System.Collections;

public class State_MenuScene : IState 
{

	const string m_szSceneName = "MenuScene";

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
