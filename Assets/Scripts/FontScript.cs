using System.Linq;
using UnityEngine;
using UnityEngine.UI;

	public class FontScript : MonoBehaviour
	{
		public Font myFont;


		// Start is called before the first frame update
		void Start()
		{

			Text[] textArray = GetComponentsInChildren<Text>();

			foreach (Text textItem in textArray)
			{
				Debug.Log(textItem.text);
				textItem.font = myFont;
			}

		}

		// Update is called once per frame
		void Update()
		{

		}
	}
