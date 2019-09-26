using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Magic

{

	private int Maxmp = 53;

	public void Attack(int usemp)

	{





		if (Maxmp >= 5)

		{

			Maxmp -= usemp;

			Debug.Log("魔法攻撃をした。残りMPは" + Maxmp + "。");



		}

		else

		{

			Debug.Log("MPが足りないため魔法が使えない。");

		}







	}

}





public class Test : MonoBehaviour

{



	// Use this for initialization

	void Start()

	{

		int[] array = { 500, 4, 909, 298, 42 };

		for (int i = 0; i < array.Length; i++)

		{

			Debug.Log(array[i]);

		}

		for (int i = array.Length - 1; i >= 0; i--)

		{

			Debug.Log(array[i]);

		}





		Magic magic = new Magic();

		for (int i = 0; i <= 10; i++)

		{

			magic.Attack(5);

		}



	}





	// Update is called once per frame

	void Update()

	{



	}

}