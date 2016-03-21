﻿

using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.GamePlay
{
	public class SkillBg : MonoBehaviour
	{
		public static SkillBg Instance;
		public  static Image BgImage => Instance._myImage;
		private Image _myImage;
		public void Awake()
		{
			Instance = this;
			_myImage = GetComponent<Image>();
		}

	}
}