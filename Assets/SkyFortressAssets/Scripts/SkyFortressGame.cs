/** edit by shenjun **/

using UnityEngine;
using System.Collections;

public class SkyFortressGame : IState
{
    private static SkyFortressGame _instance;
	/** 单例 */
    public static SkyFortressGame Instance
    {
        get {
            if(_instance == null)
                _instance = new SkyFortressGame();
            return _instance;
        }
    }
		
    private bool m_bGameOver = false;

	/** 初始化 */
	public override void Initialize ()
	{
		
	}

	/** 更新 */
	public override void Update ()
	{
		
	}

	/** 释放 */
	public override void Release ()
	{
		
	}

}
