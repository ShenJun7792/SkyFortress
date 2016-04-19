/** edit by shenjun **/

using UnityEngine;
using System.Collections;

public class GameLoop : MonoBehaviour 
{
	private StateController m_pController = null;

	void Awake()
	{
		m_pController = new StateController ();
	}

	void Start()
	{
		GameObject.DontDestroyOnLoad (this.gameObject);

		m_pController.SetState (new State_GameScene());
	}

	void Update()
	{
		
	}
   
}
