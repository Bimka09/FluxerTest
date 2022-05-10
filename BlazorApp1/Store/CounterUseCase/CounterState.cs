﻿using Fluxor;

namespace BlazorApp1.Store.CounterUseCase
{
	[FeatureState]
	public class CounterState
	{
		public int ClickCount { get; }

		public CounterState() { }
		public CounterState(int clickCount)
		{
			ClickCount = clickCount;
		}
	}
}
