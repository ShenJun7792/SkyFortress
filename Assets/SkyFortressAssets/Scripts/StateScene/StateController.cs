/** edited by shenjun **/

using UnityEngine;
using System.Collections;

/** 状态控制 */
public class StateController : IState 
{
	/** 当前状态 */
	private IState m_pState = null;

	/** 设置当前状态 */
	public void SetState(IState pState)
	{
		if (pState == null) return;

		// 前一个状态释放
		if (m_pState != null)
			m_pState.Release ();

		m_pState = pState;

		m_pState.Initialize ();
	}
		
	/** 初始化 */
	public override void Initialize ()
	{
		if (m_pState == null) return;

		m_pState.Initialize ();
	}
		
	/** 更新 */
	public override void Update ()
	{
		if (m_pState == null) return;

		m_pState.Update ();
	}

	/** 释放 */
	public override void Release ()
	{
		if (m_pState == null) return;

		m_pState.Release ();
	}

}
