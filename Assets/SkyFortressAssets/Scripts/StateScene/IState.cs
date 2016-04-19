/** edited by shenjun **/

using UnityEngine;
using System.Collections;


/** 基本状态 */
public abstract class IState 
{
	/** 初始化 */
	public abstract void Initialize ();

	/** 更新 */
	public abstract void Update ();

	/** 释放 */
	public abstract void Release();
}
